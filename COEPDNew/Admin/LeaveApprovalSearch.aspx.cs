using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class LeaveApprovalSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    DateTime DateTime;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            txtFromDate.Text = DateTime.ToString("dd/MM/yyyy");
            txtToDate.Text = DateTime.ToString("dd/MM/yyyy");
            BindLocation();
            BindData();
            gv.RowDataBound += gv_RowDataBound;
        }
    }


    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        clsLeave obj = new clsLeave();
        obj = obj.Load(Convert.ToInt32(e.CommandArgument));
        obj.ApprovedBy = CurrentUser.CurrentEmployeeId;
        if (e.CommandName == "cmdApprove")
        {
            obj.IsApproved = 1;
            obj.AddUpdate(obj);
            BindData();
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal(); ", true);

        }
        if (e.CommandName == "cmdReject")
        {
            obj.IsApproved = 2;
            obj.AddUpdate(obj);
            BindData();
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal1').modal(); ", true);
        }

    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            // Find the link buttons in the row
            LinkButton lnkApprove = e.Row.FindControl("lnkEdit") as LinkButton;
            LinkButton lnkReject = e.Row.FindControl("LinkButton1") as LinkButton;

            if (lnkApprove != null && lnkReject != null)
            {
                // Get the IsApproved value from the row's data item
                int isApproved = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "IsApproved"));

                // Hide the buttons if the IsApproved value is 1 (Approved) or 2 (Rejected)
                if (isApproved == 1 || isApproved == 2)
                {
                    lnkApprove.Visible = false;
                    lnkReject.Visible = false;
                }
            }
        }
    }
    //protected void setGridView()
    //{
    //    if (CurrentUser.IsAdmin == false)
    //    {
    //        gv.Columns[0].Visible = true;
    //    }
    //}
    protected void BindLocation()
    {
        if (CurrentUser.IsAdmin == true)
        {
            clsLocation obj = new clsLocation();
            ddllocation.DataSource = obj.LoadAll(obj);
            ddllocation.DataTextField = "Location";
            ddllocation.DataValueField = "LocationId";
            ddllocation.DataBind();
            ddllocation.Items.Insert(0, new ListItem("-- All Locations --", "0"));
        }
        else
        {
            clsUserLocation obj = new clsUserLocation();
            obj.UserId = CurrentUser.CurrentUserId;
            ddllocation.DataSource = obj.LoadAll(obj);
            ddllocation.DataTextField = "Location";
            ddllocation.DataValueField = "LocationId";
            ddllocation.DataBind();
        }
    }
    protected void BindData()
    {
        clsEmployee ObjEmp = new clsEmployee();
        ObjEmp = ObjEmp.Load(CurrentUser.CurrentEmployeeId);

        clsLeave obj = new clsLeave();
        if (CurrentUser.CurrentUserId == 2817 || CurrentUser.CurrentUserId == 4468)
        {
            txtemployeename.Visible= true;

            if (txtemployeename.Text != "")
            {
                obj.Employee = txtemployeename.Text;
            }

            ddllocation.Visible = true;
            obj.LocationId =Convert.ToInt32(ddllocation.SelectedValue);
        }
        else
        {
            if (ObjEmp.IsReportingManager == true)
            {
                txtemployeename.Visible= true;
                if (txtemployeename.Text != "")
                {
                    obj.Employee = txtemployeename.Text;
                }

                obj.DepartmentId = ObjEmp.DepartmentId;
                obj.LocationId = ObjEmp.LocationId;
            }
            else
            {
                obj.UserId = CurrentUser.CurrentUserId;
            }
        }

        DateTime fromDate;
        if (DateTime.TryParseExact(txtFromDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fromDate))
        {
            obj.FromDate = fromDate;
        }
        else
        {
            obj.FromDate = null;
        }

        DateTime toDate;
        if (DateTime.TryParseExact(txtToDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out toDate))
        {
            obj.ToDate = toDate;
        }
        else
        {
            obj.ToDate = null;
        }
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();

    }
    protected void txtemployeename_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void ddllocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtToDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtFromDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
}