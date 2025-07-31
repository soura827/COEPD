using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_NurtureStatus : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindLocation();
            BindTrainer();
            BindData();
        }

    }
    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("Search by Location", "0"));
    }
    protected void BindTrainer()
    {
        clsEmployee obj = new clsEmployee();
        obj.DesignationId = 2;
        ddlTrainer.DataSource = obj.LoadAll(obj);
        ddlTrainer.DataTextField = "Employee";
        ddlTrainer.DataValueField = "EmployeeId";
        ddlTrainer.DataBind();
        ddlTrainer.Items.Insert(0, new ListItem("Search by Trainer", "0"));
    }
    protected void BindData()
    {
        clsParticipant obj = new clsParticipant();
        if (txtSearch.Text.Length > 0)
        {
            obj.keywords = txtSearch.Text;
        }
        //obj.CourseId = Convert.ToInt16(ddlCourse.SelectedValue);
        //obj.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedValue);
        obj.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        obj.EmployeeId = Convert.ToInt16(ddlTrainer.SelectedValue);
        if (txtFromDate.Text != "")
        {
            obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.FromDate = null;
        }
        if (txtToDate.Text != "")
        {
            obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.ToDate = null;
        }
        if(rbActive.Checked)
        {
            obj.IsSubscriptionExpired= true;
        }
        else
        {
            obj.IsSubscriptionExpired= false;
        }
        //gv.Caption = "Participants Batch From " + txtFromDate.Text + " To " + txtToDate.Text;
        gv.DataSource = obj.LoadAllNurturing(obj);
        gv.DataBind();

    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdSend")
        {
            Response.Redirect("NurtureDashboard.aspx?ItemId=" + e.CommandArgument);
        }
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    if (((Label)e.Row.FindControl("Edit")).Text == "Active")
        //    {
        //        //disable
        //    }
        //}
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        FormMessage.Visible = false;
        ErrorMessage.Visible = false;
        BindData();
    }
    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        FormMessage.Visible = false;
        ErrorMessage.Visible = false;
        BindData();
    }

    protected void ddlTrainer_SelectedIndexChanged(object sender, EventArgs e)
    {
        FormMessage.Visible = false;
        ErrorMessage.Visible = false;
        BindData();
    }


    protected void gv_PreRender(object sender, EventArgs e)
    {
        PageNumberHeader.Text = "Displaying Page" + (gv.PageIndex + 1).ToString() + "of" + gv.PageCount.ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = "Displaying Page" + (gv.PageIndex + 1).ToString() + "of" + gv.PageCount.ToString();
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }

    protected void txtFromDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtToDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void rbActive_CheckedChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void rbDeleted_CheckedChanged(object sender, EventArgs e)
    {
        BindData();
    }
}