using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_InterviewSupport : System.Web.UI.Page
{
    int itemId = 0;
    clsInterviewSupport item;
    clsParticipant Item = new clsParticipant();
    CurrentUser CurrentUser = new CurrentUser();
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
            item = new clsInterviewSupport();
            if (itemId > 0)
            {
                lblTitle.Text = "Send Interview Support Inputs";
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
                    txtCompanyName.Text = item.CompanyName;
                    txtCompanyName.Enabled = false;
                    txtTargetDate.Enabled = false;
                    if (item.TargetDate != null)
                        txtTargetDate.Text = Convert.ToDateTime(item.TargetDate).ToString("dd/MM/yyyy");
                    txtNotes.Text = item.Notes;
                    if (item.IsApproved == true)
                        btnSubmit.Visible = false;
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
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        item = new clsInterviewSupport();
        if (itemId > 0)
        {
            item.InterviewSupportId = itemId;
        }
        if (flUpload.FileName.Length > 0)
        {
            clsFileUpload Upload = new clsFileUpload();
            string strFilePath = Upload.InterviewSupport(flUpload);
            item.CaseStudyReplyPath = strFilePath;
        }
        item.Notes = txtNotes.Text;
        item.IsApproved = true;
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
        Response.Redirect("InterviewSupportSearch.aspx");
    }
}