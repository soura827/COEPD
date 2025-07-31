using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_OnJobSupport : System.Web.UI.Page
{
    int itemId = 0;
    clsOnJobSupport item;
    clsParticipant Item = new clsParticipant();
    CurrentUser CurrentUser = new CurrentUser();
    //clsResumeSubmission Item = new clsResumeSubmission();
    int ItemId = 0;
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        itemId = Convert.ToInt32(Request.QueryString["itemId"]);
        
        if (!IsPostBack)
        {
            item = new clsOnJobSupport();
            if (itemId > 0)

            {
                lblTitle.Text = "Send OnJob Support Inputs";
                item = item.Load(itemId);

                if (item != null)
                {
                    ItemId = item.ParticipantId;
                    if (ItemId > 0)
                    {
                        hdnParticipantId.Value = Convert.ToString(ItemId);
                        Item = Item.Load(ItemId);
                        if (Item != null)
                        {
                            lblParticipant.Text = Item.Participant;
                        }

                    }
                    txtProject.Enabled = false;
                   // txtNotes.Enabled = false;
                    txtProject.Text = item.Project;
                    txtNotes.Text = item.Notes.ToString();
                    divUpload.Visible = true;
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
                    if (item.CaseStudyReplyPath != "")
                    {
                        hplReplyCaseStudeyFile.Visible = true;
                        hplReplyCaseStudeyFile.NavigateUrl = "~/UserDocs/OnJobSupport/" + item.CaseStudyReplyPath;
                    }
                    else
                    {
                        hplReplyCaseStudeyFile.Visible = false;
                    }
                    if (item.IsApproved == true)
                        btnSubmit.Visible = false;
                    else
                        btnSubmit.Visible = true;
                }
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
        if (flUploadReplyCaseStudeyFile.FileName.Length > 0)
        {
            clsFileUpload Upload = new clsFileUpload();
            string strFilePath = Upload.OnJobSupportCaseStudy(flUploadReplyCaseStudeyFile);
            item.CaseStudyReplyPath = strFilePath;
        }
        item.IsApproved = true;
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
        Response.Redirect("OnJobSupportSearch.aspx");
    }
}