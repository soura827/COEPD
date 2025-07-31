using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ParticipantsStatusResumeDashboard : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindResumeDashboard();
        }
    }
    protected void BindResumeDashboard()
    {
        clsParticipantStatusDashboard CPSD = new clsParticipantStatusDashboard();
        CPSD = CPSD.LoadParticipantStatusResumeDashboardCount(CPSD);
        lblResume.Text = Convert.ToString(CPSD.TotalResume);
        ltlASISResumeStage.Text = Convert.ToString(CPSD.TotalASISResumeStage);
        ltlTOBEResume.Text = Convert.ToString(CPSD.TotalTOBEResume);
        ltlStableResumeMold.Text = Convert.ToString(CPSD.TotalStableResumeMold);
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusDashboardSearch.aspx");
    }

    protected void btnASISResumeStage_Click(object sender, EventArgs e)
    {
        //  Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20430);
    }

    protected void btnTOBEResume_Click(object sender, EventArgs e)
    {
        //Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20440);
    }

    protected void btnStableResumeMold_Click(object sender, EventArgs e)
    {
        // Response.Redirect("ParticipantStageStatusCodeSearch.aspx");

        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20450);
    }
}