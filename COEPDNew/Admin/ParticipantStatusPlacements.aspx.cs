using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ParticipantStatusPlacements : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindparticipantPalcements();
        }
    }
    protected void BindparticipantPalcements()
    {
        clsParticipantStatusDashboard CPSD = new clsParticipantStatusDashboard();
        CPSD = CPSD.LoadParticipantStatusPlacementsCount(CPSD);

        lblparticipantPlacements.Text = Convert.ToString(CPSD.TotalParticipantPlacements);
        ltlOfferRelesed.Text = Convert.ToString(CPSD.TotalOfferRelesed);
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusDashboardSearch.aspx");
    }

    protected void btnParticipantPlacements_Click(object sender, EventArgs e)
    {
        //Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
    }

    protected void btnOfferRelesed_Click(object sender, EventArgs e)
    {
       // Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
    }
}