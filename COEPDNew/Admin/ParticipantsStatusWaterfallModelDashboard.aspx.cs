using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ParticipantsStatusWaterfallModelDashboard : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindWaterfallModelDashboard();
        }
    }
    protected void BindWaterfallModelDashboard()
    {
        clsParticipantStatusDashboard CPSD = new clsParticipantStatusDashboard();
        CPSD = CPSD.LoadParticipantStatusWaterfallModelDashboardCount(CPSD);
        lblWaterfallModel.Text = Convert.ToString(CPSD.TotalWaterfallModel);
        ltlWaterfallProjectScopePPT.Text = Convert.ToString(CPSD.TotalWaterfallProjectScopePPT);
        ltlWaterfallProjectBAImplementation.Text = Convert.ToString(CPSD.TotalWaterfallProjectBAImplementation);
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusDashboardSearch.aspx");
    }

    protected void btnWaterfallProjectScopePPT_Click(object sender, EventArgs e)
    {
        //Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20340);
    }

    protected void btnWaterfallProjectBAImplementation_Click(object sender, EventArgs e)
    {
        // Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20350);
    }
}