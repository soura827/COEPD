using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ParticipantsStatusMocksDashboard : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindMocksDashboard();
        }
    }
    protected void BindMocksDashboard()
    {
        clsParticipantStatusDashboard CPSD = new clsParticipantStatusDashboard();
        CPSD = CPSD.LoadParticipantStatusMocksDashboardCount(CPSD);
        lblMocks.Text = Convert.ToString(CPSD.TotalMocks);
        ltlBAMock1.Text = Convert.ToString(CPSD.TotalBAMock1);
        ltlBAMockvivavoice.Text = Convert.ToString(CPSD.TotalBAMockvivavoice);
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusDashboardSearch.aspx");
    }

    protected void btnBAMock1_Click(object sender, EventArgs e)
    {
        // Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20410);
    }


    protected void btnBAMockvivavoice_Click(object sender, EventArgs e)
    {
        //  Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20420);
    }
}