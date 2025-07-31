using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_NurtureDashboard : System.Web.UI.Page
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
    int CountBAConceptsRevision = 0;
    int CountCapstoneProjects = 0;
    int CountProfileBuilding = 0;
    int CountWaterfallModel = 0;
    int CountAgileScrumModel = 0;
    int CountBAExposure = 0;
    int CountMocks = 0;
    int CountResume = 0;
    int CountInterviewReady = 0;
    int TotalPreparation = 0;
    int CountPreparaion = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            if(ItemId>0)
            {
                BindNurtureDashboard();
                ltlRevision.Text = CountBAConceptsRevision + "/ " + TotalBAConceptsRevision;
                ltlCapstoneProjects.Text = CountCapstoneProjects + "/" + TotalCapstoneProjects;
                ltlProfileBuilding.Text = CountProfileBuilding + "/" + TotalProfileBuilding;
                ltlWaterfallModel.Text = CountWaterfallModel + "/" + TotalWaterfallModel;
                ltlAgileScrumModel.Text = CountAgileScrumModel + "/" + TotalAgileScrumModel;
                ltlBAExposure.Text = CountBAExposure + "/" + TotalBAExposure;
                ltlMocks.Text = CountMocks + "/" + TotalMocks;
                ltlResume.Text = CountResume + "/" + TotalResume;
                ltlInterviewReady.Text = CountInterviewReady + "/" + TotalInterviewReady;
                ltlPreparation.Text = CountPreparaion + "/" + TotalPreparation;
            }
            else
            {
                Response.Redirect("NurtureStatus.aspx");
            }
            
        }
            
    }
    //protected void BindCount()
    //{
    //    clsNurturingRevision Obj = new clsNurturingRevision();
    //    Obj.ParticipantId = ItemId;
    //    //Obj.ParticipantId = 18189;
    //    CountNo = Obj.LoadNurturingRevisionCount(Obj);
    //}
    protected void BindNurtureDashboard()
    {
        clsNurturingProcessStageTask NPST = new clsNurturingProcessStageTask();
        NPST.ParticipantId = ItemId;
        NPST = NPST.NurturingDashboardCount(NPST);
        TotalBAConceptsRevision = NPST.TotalBAConceptsRevision;
        TotalCapstoneProjects = NPST.TotalCapstoneProjects;
        TotalProfileBuilding = NPST.TotalProfileBuilding;
        TotalWaterfallModel = NPST.TotalWaterfallModel;
        TotalAgileScrumModel = NPST.TotalAgileScrumModel;
        TotalBAExposure = NPST.TotalBAExposure;
        TotalMocks = NPST.TotalMocks;
        TotalResume = NPST.TotalResume;
        TotalInterviewReady = NPST.TotalInterviewReady;
        CountBAConceptsRevision = NPST.CountBAConceptsRevision;
        CountCapstoneProjects = NPST.CountCapstoneProjects;
        CountProfileBuilding = NPST.CountProfileBuilding;
        CountWaterfallModel = NPST.CountWaterfallModel;
        CountAgileScrumModel = NPST.CountAgileScrumModel;
        CountBAExposure = NPST.CountBAExposure;
        CountMocks = NPST.CountMocks;
        CountResume = NPST.CountResume;
        CountInterviewReady = NPST.CountInterviewReady;
        TotalPreparation = NPST.TotalPreparation;
        CountPreparaion = NPST.CountPreparation;
    }

    protected void btnRevision_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingRevisionSearch.aspx?ItemId=" + ItemId);
    }

    protected void btnProjectIntro_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?ItemId=" + ItemId + "&NPSI=2");
    }
    protected void btnWaterfallModel_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?ItemId=" + ItemId + "&NPSI=4");
    }

    protected void btnAgileScrumModel_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?ItemId=" + ItemId + "&NPSI=5");
    }
    protected void btnProfileBuilding_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?ItemId=" + ItemId + "&NPSI=3");
    }

    protected void btnBAExposure_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?ItemId=" + ItemId + "&NPSI=6");
    }

    protected void btnMocks_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?ItemId=" + ItemId + "&NPSI=7");
    }

    protected void btnResume_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?ItemId=" + ItemId + "&NPSI=8");
    }

    protected void btnInterviewReady_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?ItemId=" + ItemId + "&NPSI=9");
    }
    protected void btnPreparaion_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?ItemId=" + ItemId + "&NPSI=12");
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureStatus.aspx");
    }

    protected void btnSendToPlacement_Click(object sender, EventArgs e)
    {
        Response.Redirect("SendToPlacement.aspx?ItemId=" + ItemId);
    }
}