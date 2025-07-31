using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_HrProcessStageTaskAccessSearch : System.Web.UI.Page
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
            //BindData();
            //BindgvAssigned();
        }

    }
    protected void BindEmployee()
    {
        clsEmployee obj = new clsEmployee();
        if (txtSearch.Text != "")
            obj.keywords = txtSearch.Text;
        ddlEmployee.DataSource = obj.LoadAll(obj);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("-- All --", "-1"));
    }
    protected void BindNurturingProcessStage()
    {
        clsHrProcessStage obj = new clsHrProcessStage();
        ddlNurturingProcessStage.DataSource = obj.LoadAll(obj);
        ddlNurturingProcessStage.DataTextField = "HrProcessStageName";
        ddlNurturingProcessStage.DataValueField = "HrProcessStageId";
        ddlNurturingProcessStage.DataBind();
        ddlNurturingProcessStage.Items.Insert(0, new ListItem("-- All --", "-1"));
    }

    protected void ddlNurturingProcessStage_SelectedIndexChanged(object sender, EventArgs e)
    {

    

        if (ddlEmployee.SelectedIndex > 0)
        {
            BindgvAssigned();
        }
        BindData();
    }

    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
       // ErrorMessage.Visible = false;
        if (ddlEmployee.SelectedIndex > 0)
        {
            BindgvAssigned();
        }
        BindData();
    }

    protected void BindData()
    {
        clsHrProcessStageTask obj = new clsHrProcessStageTask();
        obj.HrProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
        obj.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        gv.DataSource = obj.LoadAllAvilable(obj);
        gv.DataBind();
    }

    protected void BindgvAssigned()
    {
        clsHrProcessStageTaskAccess obj = new clsHrProcessStageTaskAccess();
        obj.HrProcessStageId = Convert.ToInt16(ddlNurturingProcessStage.SelectedValue);
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
                clsHrProcessStageTaskAccess objTaskAccess = new clsHrProcessStageTaskAccess();
                objTaskAccess.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
                objTaskAccess.HrProcessStageTaskId = Convert.ToInt32(e.CommandArgument);
                objTaskAccess.CreatedBy = CurrentUser.CurrentUserId;
                objTaskAccess.AddUpdate(objTaskAccess);
                BindgvAssigned();
                BindData();
            }
            else
            {
                //ErrorMessage.Visible = true;
                //ErrorMessage.Text = "Select Employee First";
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
                clsHrProcessStageTaskAccess objTaskAccess = new clsHrProcessStageTaskAccess();
                objTaskAccess.Remove(Convert.ToInt32(e.CommandArgument));
                BindgvAssigned();
                BindData();
            }
            else
            {
                //ErrorMessage.Visible = true;
                //ErrorMessage.Text = "Select Employee First";
            }
        }
    }

    protected void btnEmployeeNurturingProcessStageTasks_Click(object sender, EventArgs e)
    {
        Response.Redirect("HrTaskPrioritySearch.aspx");
    }

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        BindEmployee();
    }
}