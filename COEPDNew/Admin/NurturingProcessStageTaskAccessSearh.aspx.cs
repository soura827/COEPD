using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_NurturingProcessStageTaskAccessSearh : System.Web.UI.Page
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
            BindEmployee();
            BindNurturingProcessStage();
            BindData();
            //BindgvAssigned();
        }
    }
    protected void BindEmployee()
    {
        clsEmployee obj = new clsEmployee();
        ddlEmployee.DataSource = obj.LoadAll(obj);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("-- All --", "0"));
    }
    protected void BindNurturingProcessStage()
    {
        clsNurturingProcessStage obj = new clsNurturingProcessStage();
        ddlNurturingProcessStage.DataSource = obj.LoadAll(obj);
        ddlNurturingProcessStage.DataTextField = "NurturingProcessStageName";
        ddlNurturingProcessStage.DataValueField = "NurturingProcessStageId";
        ddlNurturingProcessStage.DataBind();
    }

    protected void ddlNurturingProcessStage_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
        if (ddlEmployee.SelectedIndex > 0)
        {
            BindgvAssigned();
        }
    }

    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        ErrorMessage.Visible = false;
        if (ddlEmployee.SelectedIndex > 0)
        {
            BindgvAssigned();
        }
        BindData();
    }
    protected void BindData()
    {
        clsNurturingProcessStageTask obj = new clsNurturingProcessStageTask();
        obj.NurturingProcessStageId = Convert.ToInt16(ddlNurturingProcessStage.SelectedValue);
        obj.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        gv.DataSource = obj.LoadAllAvilable(obj);
        gv.DataBind();
    }
    protected void BindgvAssigned()
    {
        clsNurturingProcessStageTaskAccess obj = new clsNurturingProcessStageTaskAccess();
        obj.NurturingProcessStageId = Convert.ToInt16(ddlNurturingProcessStage.SelectedValue);
        obj.EmployeeId = Convert.ToInt16(ddlEmployee.SelectedValue);
        gvAssign.DataSource = obj.LoadAll(obj);
        gvAssign.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdAdd")
        {
            if (ddlEmployee.SelectedIndex > 0)
            {
                clsNurturingProcessStageTaskAccess objTaskAccess = new clsNurturingProcessStageTaskAccess();
                objTaskAccess.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
                objTaskAccess.NurturingProcessStageTaskId = Convert.ToInt32(e.CommandArgument);
                objTaskAccess.CreatedBy = CurrentUser.CurrentUserId;
                objTaskAccess.AddUpdate(objTaskAccess);
                BindgvAssigned();
                BindData();
            }
            else
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Select Employee First";
            }
        }
    }
    //This RowCommand will fire when un-assigning the feature.
    protected void gvAssign_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdRemove")
        {
            if (ddlEmployee.SelectedIndex > 0)
            {
                clsNurturingProcessStageTaskAccess objTaskAccess = new clsNurturingProcessStageTaskAccess();
                objTaskAccess.Remove(Convert.ToInt32(e.CommandArgument));
                BindgvAssigned();
                BindData();
            }
            else
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Select Employee First";
            }
        }
    }

    protected void btnEmployeeNurturingProcessStageTasks_Click(object sender, EventArgs e)
    {
        Response.Redirect("TaskPrioritySearch.aspx");
    }
}