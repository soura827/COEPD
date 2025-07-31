using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Participant_InterviewSupport : System.Web.UI.Page
{
    int itemId = 0, CountNo = 0, RSId = 0, ItemId = 0;
    clsInterviewSupport item;
    CurrentUser CurrentUser = new CurrentUser();
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
        clsResumeSubmission CRS = new clsResumeSubmission();
        CRS.ResumeSubmissionId = RSId;
        CRS = CRS.Load(RSId);
        if (CRS != null)
        {
            hdnISId.Value = Convert.ToString(CRS.InterviewStatusId);
        }
        if (!IsPostBack)
        {
            
            item = new clsInterviewSupport();
            if (itemId > 0)
            {
                //divParticipant.Visible = false;

                lblTitle.Text = "View Interview Support";
                item = item.Load(itemId);

                if (item != null)
                {
                    btnSubmit.Enabled = false;
                    txtNotes.Enabled = false;
                    flUpload.Enabled = false;
                    txtTargetDate.Enabled = false;
                    if (item.TargetDate != null)
                        txtTargetDate.Text = Convert.ToDateTime(item.TargetDate).ToString("dd/MM/yyyy");
                    txtNotes.Text = item.Notes.ToString();
                    if (item.CaseStudyPath != "")
                    {
                        hplSentFile.Visible = true;
                        hplSentFile.NavigateUrl = "~/UserDocs/InterviewSupport/" + item.CaseStudyPath;
                    }
                    else
                    {
                        hplSentFile.Visible = false;
                    }
                    if (item.CaseStudyReplyPath != "")
                    {
                        hplReplyFile.Visible = true;
                        hplReplyFile.NavigateUrl = "~/UserDocs/InterviewSupport/" + item.CaseStudyReplyPath;
                    }
                    else
                    {
                        hplReplyFile.Visible = false;
                    }
                }
            }
            else
            {
                lblTitle.Text = "Request Interview Support";
                BindValidation();
            }

        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(flUpload.FileName.Length> 0)
        {
            item = new clsInterviewSupport();
            if (itemId > 0)
            {
                item.InterviewSupportId = ItemId;
            }
            //item.ParticipantId = CurrentUser.CurrentParticipantId;
            item.ResumeSubmissionId = Convert.ToInt32(hdnRSId.Value);
            if (flUpload.FileName.Length > 0)
            {
                clsFileUpload Upload = new clsFileUpload();
                string strFilePath = Upload.InterviewSupport(flUpload);
                item.CaseStudyPath = strFilePath;
            }
            if (txtTargetDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtTargetDate.Text, "dd/MM/yyyy", null);
                item.TargetDate = Convert.ToDateTime(Date);
            }
            item.Notes = txtNotes.Text;
            item.InterviewStatusId = Convert.ToInt32(hdnISId.Value);
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
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeFileUpload()", true);
        }
           
        
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ResumeSubmissionSearch.aspx");
    }
    protected void BindValidation()
    {

        clsInterviewSupport obj = new clsInterviewSupport();
        obj.ResumeSubmissionId = RSId;
        obj.InterviewStatusId = Convert.ToInt32(hdnISId.Value);
        CountNo = obj.LoadInterviewSupportValidation(obj);
        if (CountNo > 0)
        {
            txtTargetDate.Text = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            btnSubmit.Enabled = false;
        }
        else
        {
            btnSubmit.Enabled = true;
        }

    }

    protected void txtTargetDate_TextChanged(object sender, EventArgs e)
    {
        BindValidation();
    }
}