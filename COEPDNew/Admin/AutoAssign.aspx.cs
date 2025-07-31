using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_AutoAssign : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsAutoAssign Item;
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
        Item = new clsAutoAssign();
        if (!IsPostBack)
        {
            BindNurturingProcessStage();
            Item = new clsAutoAssign();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Task";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    BindNurturingProcessStage();
                    ddlNurturingProcessStage.SelectedValue = Convert.ToString(Item.NurturingProcessStageId);
                    BindNurturingProcessStageTask();
                    ddlNurturingProcessStageTask.Text = Convert.ToString(Item.NurturingProcessStageTaskId);
                    ddlTargetDateInterval.SelectedValue = Convert.ToString(Item.TargetDateInterval);
                    txtNotes.Text = Item.Notes;
                    if (Item.SenderImagePath != "")
                    {
                        hplSentFile.NavigateUrl = "~/UserDocs/NurturingProcess/" + Item.SenderImagePath;
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

        clsNurturingProcessStage obj = new clsNurturingProcessStage();
        ddlNurturingProcessStage.DataSource = obj.LoadAll(obj);
        ddlNurturingProcessStage.DataTextField = "NurturingProcessStageName";
        ddlNurturingProcessStage.DataValueField = "NurturingProcessStageId";
        ddlNurturingProcessStage.DataBind();
        ddlNurturingProcessStage.Items.Insert(0, new ListItem("---Select Nurturing Process Stage---", ""));
    }
    protected void BindNurturingProcessStageTask()
    {
        ddlNurturingProcessStageTask.Items.Clear();
        if (ddlNurturingProcessStage.SelectedValue != "")
        {
            clsNurturingProcessStageTask obj = new clsNurturingProcessStageTask();
            obj.NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
            ddlNurturingProcessStageTask.DataSource = obj.LoadAll(obj);
            ddlNurturingProcessStageTask.DataTextField = "NurturingProcessStageTaskName";
            ddlNurturingProcessStageTask.DataValueField = "NurturingProcessStageTaskId";
            ddlNurturingProcessStageTask.DataBind();
            ddlNurturingProcessStageTask.Items.Insert(0, new ListItem("--Select Nurturing Process Stage Task-- ", ""));
        }

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AutoAssignSearch.aspx");
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
            Item.NurturingAutoAssignId = Convert.ToInt32(ItemId);
        //Item.NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
        if (ddlNurturingProcessStageTask.SelectedValue != "")
            Item.NurturingProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.SelectedValue);
        if (flUpload.HasFile)
        {
            clsFileUpload Upload = new clsFileUpload();
            string filePath = Upload.NurturingProcessUploadDoc(flUpload);
            Item.SenderImagePath = filePath;
        }
        Item.TargetDateInterval = Convert.ToInt32(ddlTargetDateInterval.SelectedValue);
        Item.Notes = txtNotes.Text;
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
