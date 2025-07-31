using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_HrTaskPriority : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;
    clsHrProcessStageTaskAccess Item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsHrProcessStageTaskAccess();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Add Hr Task Priority";
                Item = Item.Load(ItemId);
                if (Item != null)
                {

                    ddlEmployee.SelectedValue = Item.EmployeeId.ToString();
                    ddlNurturingProcessStageTask.SelectedValue = Item.HrProcessStageTaskId.ToString();
                    txtPriority.Text = Convert.ToString(Item.TaskPriority);
                    ddlEmployee.Enabled = false;
                    txtSearch.Enabled = false;
                    ddlNurturingProcessStageTask.Enabled = false;
                    btnSave.Enabled = true;
                }
            }
            else
            {
                txtSearch.Enabled = true;
                ddlEmployee.Enabled = true;
                ddlNurturingProcessStageTask.Enabled = true;
                btnSave.Enabled = true;
            }

            BindNurturingProcessStageTask();
            BindEmployee();

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
        ddlEmployee.Items.Insert(0, new ListItem("-- Select Employee --", "0"));
    }
    protected void BindNurturingProcessStageTask()
    {
        clsHrProcessStageTask obj = new clsHrProcessStageTask();
        ddlNurturingProcessStageTask.DataSource = obj.LoadAll(obj);
        ddlNurturingProcessStageTask.DataTextField = "HrProcessStageTaskName";
        ddlNurturingProcessStageTask.DataValueField = "HrProcessStageTaskId";
        ddlNurturingProcessStageTask.DataBind();
        ddlNurturingProcessStageTask.Items.Insert(0, new ListItem("--Select Hr Process Stage Task--", "0"));
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Item = new clsHrProcessStageTaskAccess();
        if (ItemId > 0)
        {
            Item.HrProcessStageTaskAccessId = Convert.ToInt32(ItemId);
        }
        Item.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        Item.HrProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.SelectedValue);
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
        Response.Redirect("HrTaskPrioritySearch.aspx");
    }

    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddlNurturingProcessStageTask_SelectedIndexChanged(object sender, EventArgs e)
    {

    }



    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        BindEmployee();
    }
}