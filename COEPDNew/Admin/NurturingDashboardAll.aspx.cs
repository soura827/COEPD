using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_NurturingDashboardAll : System.Web.UI.Page
{
    int ItemId = 0;
    int TotalBAConceptsRevision = 0;
    int TotalCapstoneProjects = 0;
    int TotalProfileBuilding = 0;
    int TotalWaterfallModel = 0;
    int TotalAgileScrumModel = 0;
    int TotalBAExposure = 0;
    int TotalMocks = 0;
    int TotalResume = 0;
    int TotalInterviewReady = 0;
    int TotalPreparation = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            BindNurtureDashboard();
            ltlRevision.Text = Convert.ToString(TotalBAConceptsRevision);
            ltlCapstoneProjects.Text = Convert.ToString(TotalCapstoneProjects);
            ltlProfileBuilding.Text = Convert.ToString(TotalProfileBuilding);
            ltlWaterfallModel.Text = Convert.ToString(TotalWaterfallModel);
            ltlAgileScrumModel.Text = Convert.ToString(TotalAgileScrumModel);
            ltlBAExposure.Text = Convert.ToString(TotalBAExposure);
            ltlMocks.Text = Convert.ToString(TotalMocks);
            ltlResume.Text = Convert.ToString(TotalResume);
            ltlInterviewReady.Text = Convert.ToString(TotalInterviewReady);
            ltlPreparation.Text = Convert.ToString(TotalPreparation);
        }
    }
    protected void BindNurtureDashboard()
    {
        clsNurturingProcessStageStatus NPSS = new clsNurturingProcessStageStatus();
        //NPSS.ParticipantId = ItemId;
        NPSS = NPSS.NurturingDashboardCount(NPSS);
        TotalBAConceptsRevision = NPSS.TotalBAConceptsRevision;
        TotalCapstoneProjects = NPSS.TotalCapstoneProjects;
        TotalProfileBuilding = NPSS.TotalProfileBuilding;
        TotalWaterfallModel = NPSS.TotalWaterfallModel;
        TotalAgileScrumModel = NPSS.TotalAgileScrumModel;
        TotalBAExposure = NPSS.TotalBAExposure;
        TotalMocks = NPSS.TotalMocks;
        TotalResume = NPSS.TotalResume;
        TotalInterviewReady = NPSS.TotalInterviewReady;
        TotalPreparation = NPSS.TotalPreparation;

    }
    protected void btnRevision_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingStatusSearch.aspx?ItemId=1");
    }

    protected void btnCapstoneProjects_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingStatusSearch.aspx?ItemId=2");
    }

    protected void btnProfileBuilding_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingStatusSearch.aspx?ItemId=3");
    }
    protected void btnWaterfallModel_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingStatusSearch.aspx?ItemId=4");
    }

    protected void btnAgileScrumModel_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingStatusSearch.aspx?ItemId=5");
    }

    protected void btnBAExposure_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingStatusSearch.aspx?ItemId=6");
    }

    protected void btnMocks_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingStatusSearch.aspx?ItemId=7");
    }

    protected void btnResume_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingStatusSearch.aspx?ItemId=8");
    }

    protected void btnInterviewReady_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingStatusSearch.aspx?ItemId=9");
    }

    protected void btnPreparation_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingStatusSearch.aspx?ItemId=12");
    }
}