using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ParticipantsStatusRevisionDashboard : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindRevisionDashboard();
        }
    }
    protected void BindRevisionDashboard()
    {
        clsParticipantStatusDashboard CPSD = new clsParticipantStatusDashboard();
        CPSD = CPSD.LoadParticipantStatusRevisionDashboardCount(CPSD);
        lblRevision.Text = Convert.ToString(CPSD.TotalBAConceptsRevision);
        ltlBusinessAnalystPrep1.Text = Convert.ToString(CPSD.TotalBusinessAnalystPrep1);
        ltlBusinessAnalystPrep2.Text = Convert.ToString(CPSD.TotalBusinessAnalystPrep2);
        ltlBusinessAnalystPrep3.Text = Convert.ToString(CPSD.TotalBusinessAnalystPrep3);
        ltlBusinessAnalystPrep4.Text = Convert.ToString(CPSD.TotalBusinessAnalystPrep4);
        ltlBusinessAnalystPrep5.Text = Convert.ToString(CPSD.TotalBusinessAnalystPrep5);
        ltlBusinessAnalystPrep6.Text = Convert.ToString(CPSD.TotalBusinessAnalystPrep6);
        ltlBusinessAnalystPrep7.Text = Convert.ToString(CPSD.TotalBusinessAnalystPrep7);
        ltlBusinessAnalystPrep8.Text = Convert.ToString(CPSD.TotalBusinessAnalystPrep8);
        ltlBusinessAnalystPrep9.Text = Convert.ToString(CPSD.TotalBusinessAnalystPrep9);
        ltlBusinessAnalystPrep10.Text = Convert.ToString(CPSD.TotalBusinessAnalystPrep10);
        ltlBusinessAnalystPrep11.Text = Convert.ToString(CPSD.TotalBusinessAnalystPrep11);
        ltlSDLCMETHODOLOGIES.Text = Convert.ToString(CPSD.TotalSDLCMETHODOLOGIES);
        ltlObjectOrientedApproach.Text = Convert.ToString(CPSD.TotalObjectOrientedApproach);
        ltlUseCases.Text = Convert.ToString(CPSD.TotalUseCases);
        ltlActivityDiagrams.Text = Convert.ToString(CPSD.TotalActivityDiagrams);
        ltlSequenceDiagramsandDomainModeling.Text = Convert.ToString(CPSD.TotalSequenceDiagramsandDomainModeling);
        ltlUAT.Text = Convert.ToString(CPSD.TotalUAT);
        ltlStakeHolderAnalysis1.Text = Convert.ToString(CPSD.TotalStakeHolderAnalysis1);
        ltlStakeHolderAnalysis2.Text = Convert.ToString(CPSD.TotalStakeHolderAnalysis2);
        ltlRequirements1.Text = Convert.ToString(CPSD.TotalRequirements1);
        ltlRequirements2.Text = Convert.ToString(CPSD.TotalRequirements2);
        ltlRequirementElicitationTechniques.Text = Convert.ToString(CPSD.TotalRequirementElicitationTechniques);
        ltlPrioritizationandValidation.Text = Convert.ToString(CPSD.TotalPrioritizationandValidation);
        ltlMSVisioRose.Text = Convert.ToString(CPSD.TotalMSVisioRose);
        ltlAxureBalsamiq.Text = Convert.ToString(CPSD.TotalAxureBalsamiq);
        ltlSupportingTools.Text = Convert.ToString(CPSD.TotalSupportingTools);

    }
    protected void btnBusinessAnalystPrep2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20050);
    }

    protected void btnBusinessAnalystPrep3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20060);
    }

    protected void btnBusinessAnalystPrep4_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20070);
    }

    protected void btnBusinessAnalystPrep5_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20080);
    }

    protected void btnBusinessAnalystPrep6_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20090);
    }

    protected void btnBusinessAnalystPrep7_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20100);
    }

    protected void btnBusinessAnalystPrep8_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20110);

    }

    protected void btnBusinessAnalystPrep9_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20120);
    }

    protected void btnBusinessAnalystPrep10_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20130);
    }

    protected void btnBusinessAnalystPrep11_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20140);
    }

    protected void btnSDLCMETHODOLOGIES_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20150);
    }

    protected void btnObjectOrientedApproach_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20160);
    }

    protected void btnUseCases_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20170);
    }

    protected void btnActivityDiagrams_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20180);
    }

    protected void btnSequenceDiagramsandDomainModeling_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20190);
    }

    protected void btnUAT_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20200);
    }

    protected void btnStakeHolderAnalysis1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20210);
    }

    protected void btnStakeHolderAnalysis2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20220);
    }

    protected void btnRequirements1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20230);
    }

    protected void btnRequirements2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20240);
    }

    protected void btnRequirementElicitationTechniques_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20250);
    }

    protected void btnPrioritizationandValidation_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20260);
    }

    protected void btnMSVisioRose_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20270);
    }

    protected void btnAxureBalsamiq_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20280);
    }

    protected void btnSupportingTools_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20290);
    }

    protected void btnBusinessAnalystPrep1_Click(object sender, EventArgs e)
    {
        //Response.Redirect("ParticipantStageStatusCodeSearch.aspx");
        Response.Redirect("ParticipantStageStatusCodeSearch.aspx?ParticipantStatusCode=" + 20040);
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusDashboardSearch.aspx");
    }

}