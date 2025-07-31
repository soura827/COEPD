using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ResumeSubmission : System.Web.UI.Page
{
    int ItemId = 0;
    int UserId = 0;
    int EmployeeId = 0;
    CurrentUser CurrentUser = new CurrentUser();
    clsResumeSubmission Item = new clsResumeSubmission();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        UserId = CurrentUser.CurrentUserId;
        EmployeeId = CurrentUser.CurrentEmployeeId;
        if (!IsPostBack)
        {
            LoadInterviewStatus();
            BindParticipant();
            if (ItemId > 0)
            {
                
                lblTitle.Text = "Edit Resume Submission Details";
                Item = Item.Load(ItemId);
               
                if (Item != null)
                {
                    divSelected.Visible= true;
                    divRemarks.Visible = true;
                    divParticipant.Visible= false; 
                    ddlParticipant.Text =Convert.ToString(Item.ParticipantId);
                    txtCompanyName.Enabled = false;
                    txtJobDescription.Enabled = false;
                    txtLocation.Enabled = false;
                    txtExperience.Enabled = false;
                    txtDomain.Enabled = false;
                    ddlAppliedThrough.Enabled = false;
                   // txtAppliedOn.Enabled = false;
                    //ddlInterviewStatus.Enabled = false;
                    txtCompanyName.Text = Item.CompanyName.ToString();
                    txtJobDescription.Text = Item.JobDescription.ToString();
                    txtLocation.Text = Item.Location.ToString();
                    txtExperience.Text = Item.Experience.ToString();
                    txtDomain.Text = Item.Domain.ToString();
                    //txtremakrs.Text =Item.Remarks.ToString();
                    if(ddlSelectorRejected != null)
                    {
                        ddlSelectorRejected.SelectedValue = Convert.ToString(Item.SelectedorRejected);
                    }
                    //else
                    //{
                    //    ddlSelectorRejected.SelectedValue = Convert.ToString(Item.SelectedorRejected);
                    //}
                    ddlAppliedThrough.SelectedValue = Convert.ToString(Item.AppliedThroughId);
                    txtAppliedOn.Text = Item.AppliedOn.ToString("dd/MM/yyyy");
                    ddlInterviewStatus.SelectedValue = Convert.ToString(Item.InterviewStatusId);


                    if (ddlInterviewStatus.SelectedValue == "5" || ddlInterviewStatus.SelectedValue == "6" || ddlInterviewStatus.SelectedValue == "7")
                    {
                        divOnJobSupport.Visible = true;
                        txtDesignation.Enabled = false;
                        txtPackageOffered.Enabled = false;
                    }
                    else
                    {
                        divOnJobSupport.Visible = false;
                    }
                    txtDesignation.Text = Item.Designation.ToString();
                    txtPackageOffered.Text = Item.PackageOffered.ToString();
                    if (Item.DateofJoining != null)
                    {
                        txtDateofJoining.Text = Convert.ToDateTime(Item.DateofJoining).ToString("dd/MM/yyyy");
                    }
                    // btnSubmit.Visible = false;
                }
            }
            else
            {
                if (ItemId < 0)
                {
                    lblTitle.Text = "Add Resume Submission Details";
                    
                }
             

            }
        }
    }
    protected void BindParticipant()
    {
        ddlParticipant.Items.Clear();
      clsParticipant obj = new clsParticipant();
        obj.keywords = txtSearch.Text;
        ddlParticipant.DataSource = obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Participant";
        ddlParticipant.DataValueField = "ParticipantId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant -- ", ""));
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
    protected void LoadRefernceno()
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
        if (ItemId > 0)
            Item.ResumeSubmissionId = Convert.ToInt32(ItemId);
            Item.ParticipantId = Convert.ToInt32(ddlParticipant.Text);
        Item.CompanyName = txtCompanyName.Text;
        Item.JobDescription = txtJobDescription.Text;
        Item.Location = txtLocation.Text;
        Item.Experience = txtExperience.Text;
        Item.Domain = txtDomain.Text;
        divSelected.Visible = false;
        divRemarks.Visible = false;
        Item.Remarks=txtRemarks.Text;
        if (txtAppliedOn.Text != "")
        {
            DateTime AppliedOn = DateTime.ParseExact(txtAppliedOn.Text, "dd/MM/yyyy", null);
            Item.AppliedOn = AppliedOn;
        }
        if (ddlSelectorRejected != null)
        {
            Item.SelectedorRejected = ddlSelectorRejected.Text;
        }
        //else
        //{
           
        //    Item.Rejected = ddlSelectorRejected.Text;
        //}

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
        {
            Item.OfferAcceptedOn = InterviewOn;
            Item.IsOfferAccepted = true;
        }

        else if (ddlInterviewStatus.SelectedValue == "6")
        {

            Item.OfferReleasedOn = InterviewOn;
            Item.IsOfferAccepted = true;
        }


        else if (ddlInterviewStatus.SelectedValue == "10")
            Item.InitialDiscussionRound = Convert.ToString(InterviewOn);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("ResumeSubmissionSearch.aspx");
        txtCompanyName.Text = "";
        txtJobDescription.Text = "";
        txtLocation.Text = "";
        txtExperience.Text = "";
        txtDomain.Text = "";
        txtAppliedOn.Text = "";
        ddlAppliedThrough.Text = "";
        btnSubmit.Enabled = false;
      
        if (ItemId > 0)
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

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        ddlParticipant.Items.Clear();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select participant -- ", ""));
        
        if (txtSearch.Text != "")
        {
            BindParticipant();
            
        }      
    }

    protected void ddlParticipant_SelectedIndexChanged(object sender, EventArgs e)
    {
      

    }

    protected void ddlSelectorRejected_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}