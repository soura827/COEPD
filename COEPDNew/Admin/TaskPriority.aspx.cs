using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_TaskPriority : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;
    clsNurturingProcessStageTaskAccess Item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsNurturingProcessStageTaskAccess();
        if (!IsPostBack)
        {
            if(ItemId>0)
            {
                lblTitle.Text = "Add Task Priority";
                Item = Item.Load(ItemId);
                if(Item != null)
                {
                    
                    ddlEmployee.SelectedValue = Item.EmployeeId.ToString();
                    ddlEmployee.Enabled = false;
                    ddlNurturingProcessStageTask.SelectedValue = Item.NurturingProcessStageTaskId.ToString();
                    ddlNurturingProcessStageTask.Enabled = false;
                    txtPriority.Text = Convert.ToString(Item.TaskPriority);
                    btnSave.Enabled = true;
                }
            }
            else
            {
                ddlEmployee.Enabled = false;
                ddlNurturingProcessStageTask.Enabled = false;
                btnSave.Enabled = false;
            }
            
            BindNurturingProcessStageTask();
            BindEmployee();
            
        }

    }
    protected void BindEmployee()
    {
        clsEmployee obj = new clsEmployee();
        ddlEmployee.DataSource = obj.LoadAll(obj);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("-- Select Employee --", "0"));
    }
    protected void BindNurturingProcessStageTask()
    {
        clsNurturingProcessStageTask obj = new clsNurturingProcessStageTask();
        ddlNurturingProcessStageTask.DataSource = obj.LoadAll(obj);
        ddlNurturingProcessStageTask.DataTextField = "NurturingProcessStageTaskName";
        ddlNurturingProcessStageTask.DataValueField = "NurturingProcessStageTaskId";
        ddlNurturingProcessStageTask.DataBind();
        ddlNurturingProcessStageTask.Items.Insert(0, new ListItem("--Select Nurturing Process Stage Task--", "0"));
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Item = new clsNurturingProcessStageTaskAccess();
        if (ItemId > 0)
        {
            Item.NurturingProcessStageTaskAccessId = Convert.ToInt32(ItemId);
        }
        Item.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        Item.NurturingProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.SelectedValue);
        Item.TaskPriority = Convert.ToInt16(txtPriority.Text);
        Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
        Item.AddUpdate(Item);
        btnSave.Enabled = false;
        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
btnSave.Enabled = false;
}
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TaskPrioritySearch.aspx");
    }

    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddlNurturingProcessStageTask_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}