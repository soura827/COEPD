using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Dashboard : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsParticipant clsParticipant = new clsParticipant();
    //clsEmployeeCMS Item;
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
    int CountPreparation = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            clsParticipant = clsParticipant.Load(CurrentUser.CurrentParticipantId);
            if(clsParticipant != null)
            {
                if(clsParticipant.IsGoalSet == true)
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
                    ltlPreparation.Text = CountPreparation + "/" + TotalPreparation;
                    //BindTotalExams(); 
                    //BindExamCount();
                    //BindResumesCount();
                    //BindQuestionsCount();
                    BindNews();
                    // ltlRevision.Text = CountNo + "/ " + "26";
                }
                else
                {
                    Response.Redirect("SetGoal.aspx");
                }
            }
        }
    }
    protected void BindNurtureDashboard()
    {
        clsNurturingProcessStageTask NPST = new clsNurturingProcessStageTask();
        NPST.ParticipantId = CurrentUser.CurrentParticipantId;
        NPST = NPST.NurturingDashboardCount(NPST);
        TotalPreparation = NPST.TotalPreparation;
        TotalBAConceptsRevision = NPST.TotalBAConceptsRevision;
        TotalCapstoneProjects = NPST.TotalCapstoneProjects;
        TotalProfileBuilding = NPST.TotalProfileBuilding;
        TotalWaterfallModel = NPST.TotalWaterfallModel;
        TotalAgileScrumModel = NPST.TotalAgileScrumModel;
        TotalBAExposure = NPST.TotalBAExposure;
        TotalMocks = NPST.TotalMocks;
        TotalResume = NPST.TotalResume;
        TotalInterviewReady = NPST.TotalInterviewReady;
        CountPreparation = NPST.CountPreparation;
        CountBAConceptsRevision = NPST.CountBAConceptsRevision;
        CountCapstoneProjects = NPST.CountCapstoneProjects;
        CountProfileBuilding = NPST.CountProfileBuilding;
        CountWaterfallModel = NPST.CountWaterfallModel;
        CountAgileScrumModel = NPST.CountAgileScrumModel;
        CountBAExposure = NPST.CountBAExposure;
        CountMocks = NPST.CountMocks;
        CountResume = NPST.CountResume;
        CountInterviewReady = NPST.CountInterviewReady;

    }

    protected void btnRevision_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingRevisionSearch.aspx");
    }

    protected void btnProjectIntro_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?NPSI=2");
    }
    protected void btnWaterfallModel_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?NPSI=4");
    }

    protected void btnAgileScrumModel_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?NPSI=5");
    }
    protected void btnProfileBuilding_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?NPSI=3");
    }
   
    protected void btnBAExposure_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?NPSI=6");
    }

    protected void btnMocks_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?NPSI=7");
    }

    protected void btnResume_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?NPSI=8");
    }

    protected void btnInterviewReady_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?NPSI=9");
    }
    protected void btnPreparation_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboardSearch.aspx?NPSI=12");
    }

    protected void BindNews()
    {
        string strNews = string.Empty;

        List<clsNews> Items = new List<clsNews>();
        clsNews News = new clsNews();
        News.CMSId = 18;
        News.IsFeatured = true;
        News.IsActive = true;
        Items = News.LoadAll(News);

        if (Items != null)
        {
            foreach (clsNews item in Items)
            {
                strNews = strNews + "&nbsp;" + item.NewsDescription + "::&nbsp;&nbsp;";
            }

            strNews = strNews.Replace("<p>", "");
            strNews = strNews.Replace("</p>", "");
            lblNews.Text = strNews;
        }
    }
    //protected void BindTotalExams()
    //{
    //    List<clsTopic> items = new List<clsTopic>();
    //    clsTopic obj = new clsTopic();
    //    obj.UserId = Convert.ToInt16(CurrentUser.CurrentUserId);
    //    if (items != null)
    //    {
    //        BindData();
    //        lblTotal.Text = items.Count.ToString();
    //    }
    //}





    //protected void BindExamCount()
    //{
    //    clsExam obj = new clsExam();
    //    obj.UserId = Convert.ToInt16(CurrentUser.CurrentUserId);
    //    obj = obj.ExamCount(obj);
    //    if (obj != null)
    //    {
    //        lblTotal.Text = obj.TotalExams.ToString();
    //        lblComplete.Text = obj.CompletedExams.ToString();
    //        lblActivities.Text = obj.Activites.ToString();
    //        lblDocuments.Text = obj.Documents.ToString();
    //    }
    //}
    //protected void BindResumesCount()
    //{
    //    clsSampleResume obj = new clsSampleResume();
    //    obj.ParticipantId = Convert.ToInt16(CurrentUser.CurrentParticipantId);
    //    obj = obj.ResumesCount(obj);
    //    if (obj != null)
    //    {
    //        ltlResumeCount.Text = obj.CountSampleResumes.ToString();
    //    }
    //}
    //protected void BindQuestionsCount()
    //{
    //    clsSampleQuestions obj = new clsSampleQuestions();
    //    obj.ParticipantId = Convert.ToInt16(CurrentUser.CurrentParticipantId);
    //    obj = obj.QuestionsCount(obj);
    //    if (obj != null)
    //    {
    //        ltlQuestionsCount.Text = obj.CountSampleQuestions.ToString();
    //    }
    //}
}