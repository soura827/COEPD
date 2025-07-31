using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_OnJobSupport : System.Web.UI.Page
{
    int itemId = 0;
    clsOnJobSupport item;
    //clsParticipant Item = new clsParticipant();
    CurrentUser CurrentUser = new CurrentUser();
    clsResumeSubmission Item = new clsResumeSubmission();
    int ItemId = 0;
    int RSId = 0;
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = CurrentUser.CurrentParticipantId;
        itemId = Convert.ToInt32(Request.QueryString["itemId"]);
        RSId = Convert.ToInt32(Request.QueryString["RSId"]);
        lblParticipant.Text = CurrentUser.CurrentName;
        hdnRSId.Value = Convert.ToString(RSId);
        if (!IsPostBack)
        {
            item = new clsOnJobSupport();
            if (itemId > 0)
            
            {
                lblTitle.Text = "View OnJob Support";
                item = item.Load(itemId);

                if (item != null)
                {
                    txtProject.Enabled = false;
                    txtNotes.Enabled = false;
                    btnSubmit.Enabled = false;
                    txtProject.Text = item.Project;
                    txtNotes.Text = item.Notes.ToString();
                    divUpload.Visible = false;
                    if (item.GoogleReviewPath != "")
                    {
                        hplSentFile.Visible = true;
                        hplSentFile.NavigateUrl = "~/UserDocs/GoogleReview/" + item.GoogleReviewPath;
                    }
                    else
                    {
                        hplSentFile.Visible = false;
                    }

                    if (item.CaseStudyPath != "")
                    {
                        hplReplyFile.Visible = true;
                        hplReplyFile.NavigateUrl = "~/UserDocs/OnJobSupport/" + item.CaseStudyPath;
                    }
                    else
                    {
                        hplReplyFile.Visible = false;
                    }
                    if(item.CaseStudyReplyPath !="")
                    {
                        hplReplyInputs.Visible = true;
                        hplReplyInputs.NavigateUrl="~/UserDocs/OnJobSupport/" + item.CaseStudyReplyPath;
                    }
                    else
                        hplReplyInputs.Visible = false;
                }
            }
            else
            {
                lblTitle.Text = "Request OnJob Support";
                divAttachments.Visible = false;
                divUpload.Visible = true;
            }
        }

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        item = new clsOnJobSupport();
        if (itemId > 0)
        {
            item.OnJobSupportId = itemId;
        }
        item.ResumeSubmissionId = Convert.ToInt32(hdnRSId.Value);
        if (flUploadGoogleReview.FileName.Length > 0)
        {
            clsFileUpload Upload = new clsFileUpload();
            string strFilePath = Upload.GoogleReview(flUploadGoogleReview);
            item.GoogleReviewPath = strFilePath;
        }

        if (flUploadCaseStudy.FileName.Length > 0)
        {
            clsFileUpload Upload = new clsFileUpload();
            string strFilePath = Upload.OnJobSupportCaseStudy(flUploadCaseStudy);
            item.CaseStudyPath = strFilePath;
        }

        item.Project = txtProject.Text;
        item.Notes = txtNotes.Text;
        item.CreatedBy = CurrentUser.CurrentUserId;
        item.AddUpdate(item);
        btnSubmit.Enabled = false;

        if (itemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);

        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ResumeSubmissionSearch.aspx");
    }

}