using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_PlacementDashboard : System.Web.UI.Page
{
    int TotalResumesFinalized = 0;
    int TotalMovetoPlacementWing = 0;
    int TotalJobsPosted = 0;
    int TotalNewFAQsAdded = 0;
    int TotalJobsApplied = 0;
    int PendingSeviceRequests = 0;
    int PendingEscalations = 0;
    int PendingDataSheets = 0;
    int AssignedProfileOwner = 0;
    int PendingHRMocks = 0;
    int PendingRequestFAQs = 0;
    int PendingReviseFAQs = 0;
    int PendingInterviewSupport = 0;
    int TotalProfileOwnerResumes = 0;
    int TotalPlacementCount = 0;


    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        BindPlacementDashboard();
        ltlResumesFinalized.Text = Convert.ToString(TotalResumesFinalized);
        ltlMovetoPlacementWing.Text = Convert.ToString(TotalMovetoPlacementWing);
        ltlJobsPosted.Text = Convert.ToString(TotalJobsPosted);
        ltlNewFAQsAdded.Text = Convert.ToString(TotalNewFAQsAdded);
        ltlJobsApplied.Text = Convert.ToString(TotalJobsApplied);
        ltlServiceRequests.Text = Convert.ToString(PendingSeviceRequests);
        ltlEscalations.Text = Convert.ToString(PendingEscalations);
        ltlDataSheets.Text = Convert.ToString(PendingDataSheets);
        ltlAssignProfileOwner.Text = Convert.ToString(AssignedProfileOwner);
        ltlConductHRMocks.Text = Convert.ToString(PendingHRMocks);
        ltlRequestFAQs.Text = Convert.ToString(PendingRequestFAQs);
        ltlReviseFAQs.Text = Convert.ToString(PendingReviseFAQs);
        ltlInterviewSupport.Text = Convert.ToString(PendingInterviewSupport);
        ltlProfileOwnerResumes.Text = Convert.ToString(TotalProfileOwnerResumes);
        ltlPlacementCount.Text= Convert.ToString(TotalPlacementCount);
    }
    protected void BindPlacementDashboard()
    {

        clsPlacementDashboard PDB = new clsPlacementDashboard();
        PDB = PDB.PlacementDashboardCount(PDB);
        TotalResumesFinalized = PDB.TotalResumesFinalized;
        TotalMovetoPlacementWing = PDB.TotalMovetoPlacementWing;
        TotalJobsPosted = PDB.TotalJobsPosted;
        TotalNewFAQsAdded = PDB.TotalNewFAQsAdded;
        TotalJobsApplied = PDB.TotalJobsApplied;
        PendingSeviceRequests = PDB.PendingSeviceRequests;
        PendingEscalations = PDB.PendingEscalations;
        PendingDataSheets = PDB.PendingDataSheets;
        AssignedProfileOwner = PDB.AssignedProfileOwner;
        PendingHRMocks = PDB.PendingHRMocks;
        PendingRequestFAQs = PDB.PendingRequestFAQs;
        PendingReviseFAQs = PDB.PendingReviseFAQs;
        PendingInterviewSupport = PDB.PendingInterviewSupport;
        TotalProfileOwnerResumes= PDB.TotalProfileOwnerResumes;
    }

    protected void btnResumesFinalized_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingProcessSearch.aspx");
    }

    protected void btnMovetoPlacementWing_Click(object sender, EventArgs e)
    {
        Response.Redirect("PlacementParticipantsListAdmin.aspx");
    }

    protected void btnJobsPosted_Click(object sender, EventArgs e)
    {
        Response.Redirect("JobSearch.aspx");
    }

    protected void btnNewFAQsAdded_Click(object sender, EventArgs e)
    {
        Response.Redirect("FAQsMasterSearch.aspx");
    }

    protected void btnJobsApplied_Click(object sender, EventArgs e)
    {
        Response.Redirect("ResumeSubmissionSearch.aspx");
    }


    protected void btnServiceRequests_Click(object sender, EventArgs e)
    {
        Response.Redirect("PlacementServiceRequestSearch.aspx");
    }

    protected void btnEscalations_Click(object sender, EventArgs e)
    {
        Response.Redirect("PlacementEscalationSearch.aspx");
    }

    protected void btnDataSheet_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantPlacementAssistanceDataSheetSearch.aspx");
    }

    protected void btnAssignProfileOwner_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantPlacementAssistanceDataSheetSearch.aspx");
    }

    protected void btnConductHRMocks_Click(object sender, EventArgs e)
    {
        Response.Redirect("PlacementInductionSearch.aspx");
    }

    protected void btnRequestFAQs_Click(object sender, EventArgs e)
    {
        Response.Redirect("RequestFAQsSearch.aspx");
    }

    protected void btnReviseFAQs_Click(object sender, EventArgs e)
    {
        Response.Redirect("FAQsMasterSearch.aspx");
    }

    protected void btnInterviewSupport_Click(object sender, EventArgs e)
    {
        Response.Redirect("InterviewSupportSearch.aspx");
    }

    protected void btnProfileOwnerResumes_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantPlacementAssistanceDataSheetSearchAdmin.aspx");
    }

}