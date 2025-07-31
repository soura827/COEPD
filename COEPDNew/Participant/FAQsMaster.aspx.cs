using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_FAQsMaster : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsFAQsMaster Item = new clsFAQsMaster();
    clsResumeSubmission ResumeSubmission = new clsResumeSubmission();
    int RSId = 0;
    string ItemId = "";
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Request.QueryString["ItemId"];
        RSId = Convert.ToInt32(Request.QueryString["RSId"]);
       // Item.RevisedBy = CurrentUser.CurrentUserId;

        Item = new clsFAQsMaster();
        if (!IsPostBack)
        {
            LoadInterviewStatus();
            if (ItemId !=null)
            {
                if(RSId>0)
                {
                    lblTitle.Text = "Add FAQs";
                    ResumeSubmission = ResumeSubmission.Load(RSId);
                    if (ResumeSubmission != null)
                    {
                        txtCompany.Enabled = false;
                        txtExperience.Enabled = false;
                        ddlInterviewStatus.Enabled = false;
                        txtCompany.Text = ResumeSubmission.CompanyName;
                        txtExperience.Text = ResumeSubmission.Experience;
                        ddlInterviewStatus.SelectedValue = Convert.ToString(ResumeSubmission.InterviewStatusId);
                    }
                }
                else
                {
                    lblTitle.Text = "Edit FAQs";
                    Item = Item.Load(ItemId);
                    if (Item != null)
                    {
                        txtCompany.Enabled = false;
                        txtExperience.Enabled = false;
                        txtSkilSet.Enabled = false;
                        ddlInterviewStatus.Enabled = false;
                        hdnFAQsId.Value = Convert.ToString(Item.FAQsId);
                        ddlInterviewStatus.SelectedValue = Convert.ToString(Item.InterviewStatusId);
                        txtCompany.Text = Item.CompanyName;
                        txtExperience.Text = Item.Experience;
                        txtSkilSet.Text = Item.SkilSet;
                        txtNoOfQuestions.Text = Item.NoOfQuestions.ToString();
                        if (Item.IsRevised == true)
                        {
                            btnSubmit.Enabled = false;
                        }
                        else
                        {
                            btnSubmit.Enabled = true;
                        }

                        txtFAQNote.Text = Item.FAQs.ToString();

                    }
                }

            }
            else
            {
                //lblTitle.Text = "Add FAQs";
                //ResumeSubmission = ResumeSubmission.Load(RSId);
                //if(ResumeSubmission != null)
                //{
                //    txtCompany.Text = ResumeSubmission.CompanyName;
                //    txtExperience.Text = ResumeSubmission.Experience;
                //    ddlInterviewStatus.SelectedValue = Convert.ToString(ResumeSubmission.InterviewStatusId);
                //}

            }
        }
    }
    protected void LoadInterviewStatus()
    {
        clsJobApplied obj = new clsJobApplied();
        ddlInterviewStatus.DataSource = obj.LoadAllInterviewStatus(obj);
        ddlInterviewStatus.DataTextField = "InterviewStatus";
        ddlInterviewStatus.DataValueField = "InterviewStatusId";
        ddlInterviewStatus.DataBind();
        ddlInterviewStatus.Items.Insert(0, new ListItem("-- Select Interview Round --", ""));


    }
    protected void btnSubmit_Click(object sender, EventArgs e)

    {
        if (Convert.ToInt32(hdnFAQsId.Value) > 0)
        {
            Item.FAQsId = Convert.ToInt32(hdnFAQsId.Value);
        }
        Item.InterviewStatusId = Convert.ToInt32(ddlInterviewStatus.SelectedValue);
        Item.CompanyName = Convert.ToString(txtCompany.Text);
        Item.SkilSet = Convert.ToString(txtSkilSet.Text);
        Item.Experience = txtExperience.Text;
        Item.NoOfQuestions = Convert.ToInt32(txtNoOfQuestions.Text);
        string id = Guid.NewGuid().ToString();
        Item.UniqueId = Convert.ToString(id);
        Item.FAQs = txtFAQNote.Text;
        Item.IsSourceParticipant = true;
        Item.IsRevised = false; 
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        btnSubmit.Enabled = false;
        Response.Redirect("FAQsMasterSearch.aspx");
        //if (ItemId != null)
        //{
        //    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        //}
        //else
        //{
        //    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        //}

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ResumeSubmissionSearch.aspx");
    }
}