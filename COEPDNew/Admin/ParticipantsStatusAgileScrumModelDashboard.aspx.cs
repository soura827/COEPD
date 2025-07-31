using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ParticipantsStatusAgileScrumModelDashboard : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindAgileScrumModelDashboard();
        }
    }
    protected void BindAgileScrumModelDashboard()
    {
        clsParticipantStatusDashboard CPSD = new clsParticipantStatusDashboard();
        CPSD = CPSD.LoadParticipantStatusAgileScrumModelDashboardCount(CPSD);
        lblAgileScrumModel.Text = Convert.ToString(CPSD.TotalAgileScrumModel);
        ltlAgileProjectScopePPT.Text = Convert.ToString(CPSD.TotalAgileProjectScopePPT);
        ltlAgileProjectBAImplementation.Text = Convert.ToString(CPSD.TotalAgileProjectBAImplementation);
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusDashboardSearch.aspx");
    }

    protected void btnAgileProjectScopePPT_Click(object sender, EventArgs e)
    {
        // Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20360);
    }

    protected void btnAgileProjectBAImplementation_Click(object sender, EventArgs e)
    {
        // Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20370);
    }
}