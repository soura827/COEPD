using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ParticipantsStatusCapstoneProjectsDashboard : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCapstoneProjectsDashboard();
        }
    }
    protected void BindCapstoneProjectsDashboard()
    {
        clsParticipantStatusDashboard CPSD = new clsParticipantStatusDashboard();
        CPSD = CPSD.LoadParticipantStatusCapstoneProjectsDashboardCount(CPSD);
        lblCapstoneProjects.Text = Convert.ToString(CPSD.TotalCapstoneProjects);
        ltlProjPrep1Case.Text = Convert.ToString(CPSD.TotalProjPrep1Case);
        ltlProjPrep2Case.Text = Convert.ToString(CPSD.TotalProjPrep2Case);
        ltlProjPrep3Case.Text = Convert.ToString(CPSD.TotalProjPrep3Case);
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusDashboardSearch.aspx");
    }

    protected void btnProjPrep1Case_Click(object sender, EventArgs e)
    {
        //Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20300);
    }

    protected void btnProjPrep2Case_Click(object sender, EventArgs e)
    {
        // Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20300);
    }

    protected void btnProjPrep3Case_Click(object sender, EventArgs e)
    {
        // Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20320);
    }
}