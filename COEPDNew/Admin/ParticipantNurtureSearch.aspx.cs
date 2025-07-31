using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ParticipantNurtureSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    public List<clsEmployee> emp;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

   
    protected void Page_Load(object sender, EventArgs e)
    {
        clsEmployee employee = new clsEmployee();
        employee.DesignationId = 3;
        if (employee.LoadAll(employee) != null)
        {
            emp = employee.LoadAll(employee).Where(x => x.EmployeeId != CurrentUser.CurrentEmployeeId).ToList();
        }
        if (!IsPostBack)
        {
            BindData();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantNurture.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindData()
    {
        clsParticipantNurture obj = new clsParticipantNurture();
        obj.keywords = txtSearch.Text;
        obj.EmployeeId = CurrentUser.CurrentEmployeeId;
        gv.DataSource = obj.GetLatestRecord(obj);
        gv.DataBind();
        
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("ParticipantNurture.aspx?ItemId=" + e.CommandArgument);
        }
        if (e.CommandName == "cmdUpdate")
        {
            clsParticipantNurture Item = new clsParticipantNurture();
            int ItemId = Convert.ToInt16(e.CommandArgument);

            GridViewRow gvRow = (GridViewRow)((Control)e.CommandSource).NamingContainer;
           
            var ddlEmployee = (DropDownList)gvRow.FindControl("ddlEmployee");
            
            if (ddlEmployee.SelectedItem.Value == "0")
            {
                ErrorMessage.Text = "Please select a value in dropdown";
                ErrorMessage.Visible = true;
            }
            else
            {
                ErrorMessage.Visible = false;
                Item.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
                Item.ParticipantNurtureId = ItemId;
                Item.UpdateEmpId(Item);
                BindData();
            }
            
        }
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DropDownList ddlEmployee = (DropDownList)e.Row.FindControl("ddlEmployee");
            ddlEmployee.DataSource = emp;
            ddlEmployee.DataTextField = "Employee";
            ddlEmployee.DataValueField = "EmployeeId";
            ddlEmployee.DataBind();
            ddlEmployee.Items.Insert(0, new ListItem("--Select Mentor--", "0"));

            HiddenField hdnEmpId = (HiddenField)e.Row.FindControl("hdnEmpId");
            int EmpId = Convert.ToInt32(hdnEmpId.Value);
            ddlEmployee.SelectedValue = EmpId.ToString();
        }
    }
}