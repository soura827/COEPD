using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ParticipantsStatusPreparationDashboard : System.Web.UI.Page
{

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindPreparationDashboard();
        }
    }

    protected void BindPreparationDashboard()
    {
        clsParticipantStatusDashboard CPSD = new clsParticipantStatusDashboard();
        CPSD = CPSD.LoadParticipantStatusPreparationDashboardCount(CPSD);
        lblNurturingPreparation.Text = Convert.ToString(CPSD.TotalPreparation);
        ltlToolsInstallation.Text = Convert.ToString(CPSD.TotalToolsInstallation);
        ltlYouTubeAccessConfirmation.Text = Convert.ToString(CPSD.TotalYouTubeAccessConfirmation);
    }


    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusDashboardSearch.aspx");
    }

    protected void btnYouTubeAccessConfirmation_Click(object sender, EventArgs e)
    {
        //Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20020);
    }

    protected void btnToolsInstallation_Click(object sender, EventArgs e)
    {
        // Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20010);
    }
}