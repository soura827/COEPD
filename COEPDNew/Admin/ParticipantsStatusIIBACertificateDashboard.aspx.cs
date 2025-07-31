using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ParticipantsStatusIIBACertificateDashboard : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindIIBACertificateDashboard();
        }
    }
    protected void BindIIBACertificateDashboard()
    {
        clsParticipantStatusDashboard CPSD = new clsParticipantStatusDashboard();
        CPSD = CPSD.LoadParticipantStatusIIBACertificateDashboardCount(CPSD);
        lblIIBACertificate.Text = Convert.ToString(CPSD.TotalIIBACertificate);
        ltl40PDHoursCertificate.Text = Convert.ToString(CPSD.Total40PDHoursCertificate);
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusDashboardSearch.aspx");
    }

    protected void btn40PDHoursCertificate_Click(object sender, EventArgs e)
    {
        //Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20460);
    }
}