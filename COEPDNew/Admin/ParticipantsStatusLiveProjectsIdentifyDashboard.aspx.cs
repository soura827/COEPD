using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ParticipantsStatusLiveProjectsIdentifyDashboard : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindLiveProjectsIdentifyDashboard();
        }
    }
    protected void BindLiveProjectsIdentifyDashboard()
    {
        clsParticipantStatusDashboard CPSD = new clsParticipantStatusDashboard();
        CPSD = CPSD.LoadParticipantStatusLiveProjectsIdentifyDashboardCount(CPSD);
        lblLiveProjectsIdentify.Text = Convert.ToString(CPSD.TotalLiveProjectsIdentify);
        ltlPrevExperienceDocument.Text = Convert.ToString(CPSD.TotalPrevExperienceDocument);
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusDashboardSearch.aspx");
    }

    protected void btnPrevExperienceDocument_Click(object sender, EventArgs e)
    {
        //Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20330);
    }
}