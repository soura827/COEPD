using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_RequestFAQs : System.Web.UI.Page
{
    int itemId = 0, CountNo = 0, RSId = 0, ItemId = 0;
    clsRequestFAQs item;
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
            
            item = new clsRequestFAQs();
            if (itemId > 0)
            {
                //divParticipant.Visible = false;

                lblTitle.Text = "View Request FAQs";
                item = item.Load(itemId);

                if (item != null)
                {
                    btnSubmit.Visible=false;
                    txtNotes.Enabled = false;
                    divUpload.Visible=false;
                    txtInterviewDate.Enabled = false;
                    lblCompanyName.Text = item.CompanyName;
                    if (item.InterviewDate != null)
                        txtInterviewDate.Text = Convert.ToDateTime(item.InterviewDate).ToString("dd/MM/yyyy");
                    txtNotes.Text = item.Notes;
                    txtNote.Text = item.FAQs;
                    if (item.ProofOfInterviewPath != "")
                    {
                        hplSentFile.Visible = true;
                        hplSentFile.NavigateUrl = "~/UserDocs/PlacementFAQs/" + item.ProofOfInterviewPath;
                    }
                    else
                    {
                        hplSentFile.Visible = false;
                    }
                   
                }
            }
            else
            {
                BindValidation();
                lblTitle.Text = "Request FAQs";
                divCKEditor.Visible = false;
                divAttachments.Visible = false;
                divCompany.Visible = false;
            }
           
        }
   }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(flUpload.FileName.Length> 0)
        {
            item = new clsRequestFAQs();
            if (itemId > 0)
            {
                item.RequestFAQsId = ItemId;
            }
            item.ResumeSubmissionId = Convert.ToInt32(hdnRSId.Value);
            if (flUpload.FileName.Length > 0)
            {
                clsFileUpload Upload = new clsFileUpload();
                string strFilePath = Upload.PlacementFAQs(flUpload);
                item.ProofOfInterviewPath = strFilePath;
            }
            if (txtInterviewDate.Text != "")
            {
                DateTime InterviewDate = DateTime.ParseExact(txtInterviewDate.Text, "dd/MM/yyyy", null);
                item.InterviewDate = Convert.ToDateTime(InterviewDate);
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

        clsRequestFAQs obj = new clsRequestFAQs();
        obj.ResumeSubmissionId = RSId;
        obj.InterviewStatusId = Convert.ToInt32(hdnISId.Value);
        CountNo = obj.LoadRequestFAQsMultiValidation(obj);
        if (CountNo > 0)
        {
            txtInterviewDate.Text = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }

    }

    protected void txtInterviewDate_TextChanged(object sender, EventArgs e)
    {
        BindValidation();
    }
}
