using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_HrViewshortlistResume : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsResumePreparation Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsResumePreparation();
        if (!IsPostBack)
        {
            BindSampleQuestions();
            BindData();
            if (ItemId > 0)
            {
                Item = Item.LoadById(ItemId);
                if (Item != null)
                {
                    lblJobExpDomain.Text = Item.JobExperienceDomain;
                    lblJobExpectedDomain.Text = Item.JobExpectedDomain;
                    lblExpInYears.Text = Item.ExpInYears.ToString();
                    lblExpectedSalary.Text = Item.ExpectedSalary.ToString();
                    lblListOfCompetencies.Text = Item.ListOfCompentencies;
                    lblPreferedLocations.Text = Item.PreferedLocations;
                    lblSkills.Text = Item.Skills;
                    lblComments.Text = Item.Comments;
                    hplResumeView.NavigateUrl = "~/UserDocs/ResumePreparation/" + Item.ResumePath;
                    hplResumeDownload.NavigateUrl = "~/UserDocs/ResumePreparation/" + Item.ResumePath;
                    lblApprovedBy.Text = Item.ApprovedBy;
                    lblApprovedDate.Text = Convert.ToDateTime(Item.ApprovedDate).ToString("dd/MM/yyyy");
                }
            }
        }
    }
    protected void btnBackToList_Click(object sender, EventArgs e)
    {
        Response.Redirect("HrShortlistedResumes.aspx");
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        Item = Item.LoadById(ItemId);
        if (txtChat.Text.Length > 0)
        {
            clsResumeChat objResumeChat = new clsResumeChat();
            objResumeChat.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            objResumeChat.ParticipantId = Convert.ToInt16(Item.ParticipantId);
            objResumeChat.ResumeChat = txtChat.Text;
            objResumeChat.CreatedBy = CurrentUser.CurrentUserId;
            objResumeChat.AddUpdate(objResumeChat);
            txtChat.Text = "";
            FormMessage.Text = "Your request is successfully sent.";
            FormMessage.Visible = true;
            Response.Redirect("HrViewshortlistResume.aspx?ItemId=" + ItemId);
        }
    }
    protected void BindData()
    {
        Item = Item.LoadById(ItemId);
        clsResumeChat objChat = new clsResumeChat();
        objChat.ParticipantId = Convert.ToInt32(Item.ParticipantId);
        rp.DataSource = objChat.LoadAll(objChat);
        rp.DataBind();
    }
    protected void rp_OnItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        RepeaterItem item = e.Item;
        if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
        {
            HiddenField hdnRoleId = (HiddenField)item.FindControl("hdnRoleId");
            int RoleId = Convert.ToInt16(hdnRoleId.Value);
            if (RoleId == 2)
            {
                Panel pnlIn = (Panel)item.FindControl("pnlIn");
                pnlIn.Visible = true;
            }
            else
            {
                Panel PnlOut = (Panel)item.FindControl("PnlOut");
                PnlOut.Visible = true;
            }
        }
    }  
    protected void btnReviewLater_Click(object sender, EventArgs e)
    {
        Response.Redirect("HrShortlistedResumes.aspx");
    }
    protected void btnSendQuestions_Click(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsResumePreparation();
        Item = Item.LoadById(ItemId);
        int ParticipantId = Convert.ToInt32(Item.ParticipantId);
        clsSampleQuestions obj = new clsSampleQuestions();
        if (flUpload.HasFile)
        {
            HttpFileCollection UploadedFiles = Request.Files;
            for (int i = 0; i < UploadedFiles.Count; i++)
            {
                HttpPostedFile hpfiles = UploadedFiles[i];
                if (hpfiles.ContentLength > 0)
                {
                    clsFileUpload Upload = new clsFileUpload();
                    string strFilePath = Upload.SampleQuestionsUploadDoc(flUpload);
                    obj.SampleQuestionsPath = strFilePath;
                    obj.SampleQuestionsName = hpfiles.FileName;
                }
                obj.ParticipantId = ParticipantId;
                obj.CreatedBy = CurrentUser.CurrentUserId;
                obj.AddUpdate(obj);
            }
        }
        else
        {
            Response.Write("<script>alert(Please Select Files)</script>");
        }
        Item.InterviewQuestionReceive = false;
        Item.AddUpdate(Item);
        BindSampleQuestions();
    }

    public void BindSampleQuestions()
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsResumePreparation();
        Item = Item.LoadById(ItemId);
        int ParticipantId = Convert.ToInt32(Item.ParticipantId);
        clsSampleQuestions obj = new clsSampleQuestions();
        obj.keywords = null;
        obj.ParticipantId = ParticipantId;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdDownload")
        {
            clsSampleQuestions obj = new clsSampleQuestions();
            if (e.CommandArgument != null)
            {
                string FilePath = Server.MapPath("~/UserDocs/SampleQuestions/" + e.CommandArgument);
                Response.ContentType = "application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + System.IO.Path.GetFileName(FilePath));
                Response.TransmitFile(FilePath);
            }
        }
    }
}