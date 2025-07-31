using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ParticipantsStatusDashboardSearch : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindNurtureDashboard(); 
        }
    }

    protected void BindNurtureDashboard() 
    {
        clsParticipantStatusDashboard CPSD = new clsParticipantStatusDashboard();
        CPSD = CPSD.LoadParticipantStatusDashboardCount(CPSD);
        lblParticipantStatusDashboard.Text = CPSD.TotalCount + " of " + CPSD.TotalActiveParticipants;
        ltlNotYetStartedParticipants.Text = Convert.ToString(CPSD.TotalNotYetStartedParticipants);
        ltlPreparation.Text = Convert.ToString(CPSD.TotalPreparation);
        ltlRevision.Text = Convert.ToString(CPSD.TotalBAConceptsRevision);
        ltlCapstoneProjects.Text = Convert.ToString(CPSD.TotalCapstoneProjects);
        ltlLiveProjectsIdentify.Text = Convert.ToString(CPSD.TotalLiveProjectsIdentify);
        ltlWaterfallModel.Text = Convert.ToString(CPSD.TotalWaterfallModel);
        ltlAgileScrumModel.Text = Convert.ToString(CPSD.TotalAgileScrumModel);
        ltlBAExposure.Text = Convert.ToString(CPSD.TotalBAExposure);
        ltlMocks.Text = Convert.ToString(CPSD.TotalMocks);
        ltlResume.Text = Convert.ToString(CPSD.TotalResume);
        ltlIIBACertificate.Text = Convert.ToString(CPSD.TotalIIBACertificate);
        ltlParticipantPlacements.Text = Convert.ToString(CPSD.TotalParticipantPlacements);
        ltlOfferRelesed.Text = Convert.ToString(CPSD.TotalOfferRelesed);

    }

    protected void btnPreparation_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusPreparationDashboard.aspx");
    }

    protected void btnRevision_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusRevisionDashboard.aspx");
    }

    protected void btnCapstoneProjects_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusCapstoneProjectsDashboard.aspx");
    }

    protected void btnLiveProjectsIdentify_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusLiveProjectsIdentifyDashboard.aspx");
    }

    protected void btnWaterfallModel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusWaterfallModelDashboard.aspx");
    }

    protected void btnAgileScrumModel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusAgileScrumModelDashboard.aspx");
    }

    protected void btnBAExposure_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusBAExposureDashboard.aspx");
    }

    protected void btnMocks_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusMocksDashboard.aspx");
    }

    protected void btnResume_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusResumeDashboard.aspx");
    }

    protected void btnIIBACertificate_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusIIBACertificateDashboard.aspx");
    }

    protected void btnNotYetStartedParticipants_Click(object sender, EventArgs e)
    {
        // Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 1900);
    }

    protected void btnPlacements_Click(object sender, EventArgs e)
    {
        
    }

    protected void btnParticipantPlacements_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20500);
    }

    protected void btnOfferRelesed_Click(object sender, EventArgs e)
    {

    }
}

