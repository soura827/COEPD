using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_HrTask : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsHrTask Item;
    int ItemId = 0;
    int Selectedvalue = 0;
    int NurturingProcessStageId = 0;
    int NurturingProcessStageTaskId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsHrTask();
        if (!IsPostBack)
        {
            BindNurturingProcessStage();
            Item = new clsHrTask();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Task";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    BindNurturingProcessStage();
                    ddlNurturingProcessStage.SelectedValue = Convert.ToString(Item.HrProcessStageId);
                    ddlNurturingProcessStage.Enabled = false;
                    BindNurturingProcessStageTask();
                    ddlNurturingProcessStageTask.Text = Convert.ToString(Item.HrProcessStageTaskId);
                    ddlNurturingProcessStageTask.Enabled = false;
                    ddlTargetDateInterval.SelectedValue = Convert.ToString(Item.TargetDateInterval);
                    txtTaskInputs.Text = Item.TaskInputs;
                    if (Item.SenderImagePath != "")
                    {
                        hplSentFile.NavigateUrl = "~/UserDocs/NurturingTask/" + Item.SenderImagePath;
                    }
                    else
                    {
                        hplSentFile.Visible = false;
                    }
                }
            }
            else
            {
                divAttachments.Visible = false;
            }

        }
    }
    protected void BindNurturingProcessStage()
    {

        clsHrProcessStage obj = new clsHrProcessStage();
        ddlNurturingProcessStage.DataSource = obj.LoadAll(obj);
        ddlNurturingProcessStage.DataTextField = "HrProcessStageName";
        ddlNurturingProcessStage.DataValueField = "HrProcessStageId";
        ddlNurturingProcessStage.DataBind();
        ddlNurturingProcessStage.Items.Insert(0, new ListItem("---Select Hr Process Stage---", ""));
    }
    protected void BindNurturingProcessStageTask()
    {
        ddlNurturingProcessStageTask.Items.Clear();
        if (ddlNurturingProcessStage.SelectedValue != "")
        {
            clsHrProcessStageTask obj = new clsHrProcessStageTask();
            obj.HrProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
            ddlNurturingProcessStageTask.DataSource = obj.LoadAll(obj);
            ddlNurturingProcessStageTask.DataTextField = "HrProcessStageTaskName";
            ddlNurturingProcessStageTask.DataValueField = "HrProcessStageTaskId";
            ddlNurturingProcessStageTask.DataBind();
            ddlNurturingProcessStageTask.Items.Insert(0, new ListItem("--Select Hr Process Stage Task-- ", ""));
        }

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("HrTaskSearch.aspx");
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
            Item.NurturingTaskId = Convert.ToInt32(ItemId);
        //Item.NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
        if (ddlNurturingProcessStageTask.SelectedValue != "")
            Item.NurturingProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.SelectedValue);
        if (flUpload.HasFile)
        {
            clsFileUpload Upload = new clsFileUpload();
            string filePath = Upload.NurturingTask(flUpload);
            Item.SenderImagePath = filePath;
        }
        Item.TargetDateInterval = Convert.ToInt32(ddlTargetDateInterval.SelectedValue);
        Item.TaskInputs = txtTaskInputs.Text;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        btnSubmit.Enabled = false;
        //Response.Redirect("AutoAssignSearch.aspx");
        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);

        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }
    }
    protected void ddlNurturingProcessStage_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (ddlNurturingProcessStage.SelectedValue != null)
            BindNurturingProcessStageTask();
    }
    protected void ddlNurturingProcessStageTask_SelectedIndexChanged1(object sender, EventArgs e)
    {
        //BindNurturingProcessStageTask();
    }
}