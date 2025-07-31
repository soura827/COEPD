using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_ResumeSubmission : System.Web.UI.Page
{
    int ItemId = 0;
    CurrentUser CurrentUser = new CurrentUser();
    clsResumeSubmission Item = new clsResumeSubmission();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            LoadInterviewStatus();
            if (ItemId > 0)
            {
                lblTitle.Text = "View Resume Submission Details";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtCompanyName.Enabled = false;
                    txtJobDescription.Enabled = false;
                    txtLocation.Enabled = false;
                    txtExperience.Enabled = false;
                    txtDomain.Enabled = false;
                    ddlAppliedThrough.Enabled = false;
                    txtAppliedOn.Enabled = false;
                    txtCompanyName.Text = Item.CompanyName.ToString();
                    txtJobDescription.Text = Item.JobDescription.ToString();
                    txtLocation.Text = Item.Location.ToString();
                    txtExperience.Text = Item.Experience.ToString();
                    txtDomain.Text = Item.Domain.ToString();
                    //ddlAppliedThrough.Text = Item.AppliedThroughId.ToString();
                    if (ddlSelectorRejected != null)
                    {
                        ddlSelectorRejected.SelectedValue = Convert.ToString(Item.SelectedorRejected);
                    }

                    ddlAppliedThrough.SelectedValue = Convert.ToString(Item.AppliedThroughId);
                    txtAppliedOn.Text = Item.AppliedOn.ToString("dd/MM/yyyy");
                    ddlInterviewStatus.SelectedValue = Convert.ToString(Item.InterviewStatusId);
                    if (Item.GoogleReviewLink.Length > 0)
                    {
                        hpl.NavigateUrl = Item.GoogleReviewLink;
                    }
                    else
                    {
                        hpl.NavigateUrl = "#";
                    }
                    if (ddlInterviewStatus.SelectedValue == "5" || ddlInterviewStatus.SelectedValue == "6" || ddlInterviewStatus.SelectedValue == "7")
                    {
                        divOnJobSupport.Visible = true;
                        txtDesignation.Enabled = false;
                        txtPackageOffered.Enabled = false;
                        divFeedback.Visible=true;
                    }
                    else
                    {
                        divOnJobSupport.Visible = false;
                        divFeedback.Visible = false;
                    }
                    txtDesignation.Text = Item.Designation.ToString();
                    txtPackageOffered.Text = Item.PackageOffered.ToString();
                    if (Item.DateofJoining != null)
                    {
                        txtDateofJoining.Text = Convert.ToDateTime(Item.DateofJoining).ToString("dd/MM/yyyy");
                    }
                        

                }
            }
            else
            {
                lblTitle.Text = "Add Resume Submission Details";
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

    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        if(CurrentUser.CurrentParticipantId>0)
        {
            if (ItemId > 0)
                Item.ResumeSubmissionId = Convert.ToInt32(ItemId);
            Item.CompanyName = txtCompanyName.Text;
            Item.JobDescription = txtJobDescription.Text;
            Item.Location = txtLocation.Text;
            Item.Experience =txtExperience.Text;
            Item.Domain = txtDomain.Text;
            if (txtAppliedOn.Text != "")
            {
                DateTime AppliedOn = DateTime.ParseExact(txtAppliedOn.Text, "dd/MM/yyyy", null);
                Item.AppliedOn = AppliedOn;
            }
            
            if (ddlAppliedThrough.Text != "")
                Item.AppliedThroughId = Convert.ToInt16(ddlAppliedThrough.SelectedValue);
            Item.InterviewStatusId = Convert.ToInt32(ddlInterviewStatus.SelectedValue);
            Item.Designation = txtDesignation.Text;
            Item.PackageOffered = txtPackageOffered.Text;
            if (txtDateofJoining.Text != "")
            {
                DateTime DateofJoining = DateTime.ParseExact(txtDateofJoining.Text, "dd/MM/yyyy", null);
                Item.DateofJoining = DateofJoining;
            }
            if (ddlInterviewStatus.SelectedValue == "5" || ddlInterviewStatus.SelectedValue == "6" || ddlInterviewStatus.SelectedValue == "7")
                Item.IsRegisteredOnJobSupport = true;
            else
                Item.IsRegisteredOnJobSupport = false;
            DateTime InterviewOn = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            if (ddlInterviewStatus.SelectedValue == "1")
                Item.InitialDiscussionRound = Convert.ToString(InterviewOn);
            if (ddlInterviewStatus.SelectedValue == "2")
                Item.InterviewRound1On = InterviewOn;

            else if (ddlInterviewStatus.SelectedValue == "3")
                Item.InterviewRound2On = InterviewOn;
            else if (ddlInterviewStatus.SelectedValue == "4")
                Item.InterviewRound3On = InterviewOn;

            else if (ddlInterviewStatus.SelectedValue == "5")
                Item.OfferReleasedOn = InterviewOn;


            else if (ddlInterviewStatus.SelectedValue == "6")
            {
                Item.OfferAcceptedOn = InterviewOn;
                Item.IsOfferAccepted = true;
            }

            Item.ParticipantId = CurrentUser.CurrentParticipantId;
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.AddUpdate(Item);
            //txtCompanyName.Text = "";
            //txtJobDescription.Text = "";
            //txtLocation.Text = "";
            //txtExperience.Text = "";
            //txtDomain.Text = "";
            //txtAppliedOn.Text = "";
            //ddlAppliedThrough.Text = "";
            btnSubmit.Enabled = false;
            if (ddlInterviewStatus.SelectedValue == "5" || ddlInterviewStatus.SelectedValue == "6" || ddlInterviewStatus.SelectedValue == "7")
                divFeedback.Visible = true;
            if (ItemId > 0)
            {
                //ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
                FormMessage.Visible = true;
                FormMessage.Text = "Interview Status successfully Updated";
                ErrorMessage.Visible = false;


            }
            else
            {
                //ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
                FormMessage.Visible = true;
                FormMessage.Text = "Interview Status successfully Added";
                ErrorMessage.Visible = false;
            }
        }
        else
        {
            Response.Redirect("~/Login.html");
        }
        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ResumeSubmissionSearch.aspx");
    }

    protected void btnClickHere_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://g.co/kgs/eX529M");
    }

    protected void ddlInterviewStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlInterviewStatus.SelectedValue == "5" || ddlInterviewStatus.SelectedValue == "6" || ddlInterviewStatus.SelectedValue == "7")
        {
            divOnJobSupport.Visible = true;
        }
        else
        {
            divOnJobSupport.Visible = false;
        }
    }

   

    protected void ddlSelectorRejected_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}