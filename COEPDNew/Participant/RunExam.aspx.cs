using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class RunExam : System.Web.UI.Page
{
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    CurrentUser CurrentUser = new CurrentUser();
    List<clsUserExam> sitems;
    int ItemId = 0;
    int ItemId1 = 0;
    float MarksPersontage = 0;
    int ObjId = 0;
    int CountNo = 0;
    int NurturingProcessStageTaskId = 0;
   // int NurturingProcessStageTaskStatusId = 0;
    int NurturingProcessStageId = 1;
    int NurturingProcessStageStatusId = 0;
    int CountBAConceptsRevision = 0;
    int ParticipantStatusDashboardId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        sitems = (List<clsUserExam>)Session["QBank"];
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        clsTopic item = new clsTopic();
        item=item.Load(ItemId);
       // int CategoryId = Convert.ToInt32(item.CategoryId);
       // Session["CategoryId"] = CategoryId;
        lblcategory.Text = Convert.ToString(item.Category);
        Session["Category"] = Convert.ToString(lblcategory.Text);
        lblTopic.Text = Convert.ToString(item.Topic);
        Session["TopicName"] = Convert.ToString(lblTopic.Text);

        clsTopic Item = new clsTopic();
        if (ItemId > 0)
        {
            Item = Item.LoadNurturingProcessStageTaskId(ItemId);
            if (Item != null)
            {
                NurturingProcessStageTaskId = Item.NurturingProcessStageTaskId;
            }


            }
            if (!IsPostBack)
        {
            if (sitems != null)
            {
                BindData();
            }
            else
            {
            }
        }
    }
    protected void BtnPrev_Click(object sender, EventArgs e)
    {
        //System.Threading.Thread.Sleep(6000);
        BtnPrev.Enabled = false;
        if (Session["SNo"] != null)
        {
            UpdateData();
            Session["SNo"] = Convert.ToInt16(Session["SNo"]) - 1;
            BindData();
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Your session is expired! Click OK to login again');window.location ='https://www.coepd.com/login.html';", true);
        }
        BtnPrev.Enabled = true;
    }
    protected void BindNurturingProcessStageStatus()
    {
        clsNurturingProcessStageTask NPST = new clsNurturingProcessStageTask();
        NPST.ParticipantId = CurrentUser.CurrentParticipantId;
        NPST = NPST.NurturingDashboardCount(NPST);
        CountBAConceptsRevision = NPST.CountBAConceptsRevision;
        if(CountBAConceptsRevision == 26 )
        {
            clsNurturingProcessStageStatus StageObj = new clsNurturingProcessStageStatus();
            StageObj.ParticipantId = CurrentUser.CurrentParticipantId;
            StageObj.NurturingProcessStageId = NurturingProcessStageId;
            if (StageObj.ParticipantId > 0)
            {
                StageObj = StageObj.LoadNurturingProcessStageStatusId(StageObj.ParticipantId, StageObj.NurturingProcessStageId);
                if (StageObj != null)
                {
                    NurturingProcessStageStatusId = Convert.ToInt32(StageObj.NurturingProcessStageStatusId);

                }

            }
        }
    }
    protected void BtnNext_Click(object sender, EventArgs e)
    {
        //System.Threading.Thread.Sleep(6000);
        BtnNext.Enabled = false;
        if (Session["SNo"] != null)
        {
            UpdateData();
            Session["SNo"] = Convert.ToInt16(Session["SNo"]) + 1;
            BindData();
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Your session is expired! Click OK to login again');window.location ='https://www.coepd.com/login.html';", true);
        }
        BtnNext.Enabled = true;
    }
   protected void BindExamData()
    {
        clsUserExam item = new clsUserExam();
        item.ExamId = Convert.ToInt32(Session["ExamId"]);
        item = item.LoadAllQuestions_History(item);
       if(item!=null)
        {
            lblTotalQuestions.Text =Convert.ToString(item.TotalQuestions);
        Session["TotalQuestions"] = lblTotalQuestions.Text;
            lblCorrectAnswers.Text = Convert.ToString(item.CorrectAnswers);
        Session["CorrectAnswers"] = lblCorrectAnswers.Text;
            lblMarksPersontage.Text = Convert.ToString(((Convert.ToInt32(Session["CorrectAnswers"])) * 100) / (Convert.ToInt32(Session["TotalQuestions"])));
            Session["MarksPersontage"] = lblMarksPersontage.Text;
        }
    }
    protected void BtnFinish_Click(object sender, EventArgs e)
    {
       // System.Threading.Thread.Sleep(6000);

        if (Session["SNo"] != null)
        {
            UpdateData();
            Session["QBank"] = null;
            Session["SNo"] = 0;

            BindExamData();
            UserExamReportCount();
            clsUserExamReport item = new clsUserExamReport();
            MarksPersontage = Convert.ToInt32(Session["MarksPersontage"]);
            if (ItemId1 > 0)
            {
                item.UserExamReportId = Convert.ToInt16(ItemId1);
            }
            item.UserId = Convert.ToInt32(CurrentUser.CurrentUserId);
            item.ExamId = Convert.ToInt32(Session["ExamId"]);
            item.Category = Convert.ToString(Session["Category"]);
            item.Topic = Convert.ToString(Session["TopicName"]);
            item.TotalQuestions = Convert.ToInt32(Session["TotalQuestions"]);
            item.CorrectAnswers = Convert.ToInt32(Session["CorrectAnswers"]);
            item.StartDate = Convert.ToString(Session["StartDate"]);
            item.StartTime = Convert.ToDateTime(Session["StartTime"]);
            DateTime StartTime1 = Convert.ToDateTime(item.StartTime);
            item.EndTime = Convert.ToDateTime(DateTime.Now.ToString());
            DateTime EndTime1 = item.EndTime;
            TimeSpan ts = EndTime1 - StartTime1;
            item.Duration = Convert.ToString(ts);
            item.RetakeExamCount = Convert.ToInt32(Session["UserExamCount"]);
            item.MarksPersontage = MarksPersontage;
            item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
            item.AddUpdate(item);
            if(MarksPersontage>89)
            {
                clsParticipantStatusDashboard PSD= new clsParticipantStatusDashboard();
                PSD.ParticipantId = CurrentUser.CurrentParticipantId;
                PSD.StatusCode = Convert.ToInt32(Session["Statuscode"]);
                if (PSD.ParticipantId > 0 && PSD.StatusCode >0)
                {
                    PSD = PSD.LoadParticipantStatusCodeDashboardId(PSD.ParticipantId, PSD.StatusCode);
                    if (PSD != null)
                    {
                        ParticipantStatusDashboardId = Convert.ToInt32(PSD.ParticipantStatusDashboardId);

                    }
                    if(ParticipantStatusDashboardId> 0) 
                    {
                        PSD.ParticipantStatusDashboardId = ParticipantStatusDashboardId;
                        PSD.CreatedBy = CurrentUser.CurrentUserId;
                        PSD.AddUpdate(PSD);
                    }

                }

            }
            if (MarksPersontage >= 0)
            {
                clsNurturingRevision Obj = new clsNurturingRevision();
                Obj.ParticipantId = CurrentUser.CurrentParticipantId;
                Obj.TopicId = ItemId;
                CountNo = Obj.LoadNurturingRevisionValidation(Obj);
                if (CountNo == 0)
                {
                    if (ObjId > 0)
                    {
                        Obj.NurturingRevisionId = ObjId;
                    }
                    Obj.NurturingProcessStageId = 1;
                    Obj.NurturingProcessStageTaskId = Convert.ToInt32(NurturingProcessStageTaskId);
                    Obj.ParticipantId = CurrentUser.CurrentParticipantId;
                    Obj.ExamId = Convert.ToInt32(Session["ExamId"]);
                    Obj.TopicId = ItemId;
                    Obj.TotalQuestions = Convert.ToInt32(Session["TotalQuestions"]);
                    Obj.CorrectAnswers = Convert.ToInt32(Session["CorrectAnswers"]);
                    Obj.MarksPersontage = MarksPersontage;
                    if (MarksPersontage > 89)
                    {
                        Obj.IsApproved = Convert.ToBoolean(1);
                    }
                    else
                    {
                        Obj.IsApproved = Convert.ToBoolean(0);
                    }
                    Obj.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                    Obj.AddUpdate(Obj);
                }
                else
                {
                    clsNurturingRevision obj = new clsNurturingRevision();
                    obj.ParticipantId = CurrentUser.CurrentParticipantId;
                    // obj.NurturingProcessStageTaskId = NurturingProcessStageTaskId;
                    obj.NurturingProcessStageTaskId = Convert.ToInt32(Session["NurturingProcessStageTaskId"]);
                    if (obj.ParticipantId > 0 && obj.NurturingProcessStageTaskId > 0)
                    {
                        obj = obj.Load(obj);
                        if (obj != null)
                        {
                            ObjId = Convert.ToInt32(obj.NurturingRevisionId);
                            if (ObjId > 0)
                            {
                                Obj.NurturingRevisionId = ObjId;
                            }
                            Obj.NurturingProcessStageId = 1;
                            Obj.NurturingProcessStageTaskId = Convert.ToInt32(NurturingProcessStageTaskId);
                            Obj.ParticipantId = CurrentUser.CurrentParticipantId;
                            Obj.TopicId = ItemId;
                            Obj.ExamId = Convert.ToInt32(Session["ExamId"]);
                            Obj.TotalQuestions = Convert.ToInt32(Session["TotalQuestions"]);
                            Obj.CorrectAnswers = Convert.ToInt32(Session["CorrectAnswers"]);
                            Obj.MarksPersontage = MarksPersontage;
                            if (MarksPersontage > 89)
                            {
                                Obj.IsApproved = Convert.ToBoolean(1);
                            }
                            else
                            {
                                Obj.IsApproved = Convert.ToBoolean(0);
                            }
                            Obj.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                            Obj.AddUpdate(Obj);
                        }
                    }

                }
                BindNurturingProcessStageStatus();
                if (NurturingProcessStageStatusId > 0)
                {
                    clsNurturingProcessStageStatus ObjStageExit = new clsNurturingProcessStageStatus();
                    ObjStageExit.Exit(NurturingProcessStageStatusId);
                }

                //if (NurturingProcessStageTaskStatusId > 0)
                //{
                //    clsNurturingProcessStageTaskStatus ObjStageTaskExit = new clsNurturingProcessStageTaskStatus();
                //    ObjStageTaskExit.Exit(NurturingProcessStageTaskStatusId);
                //}


            }

            Response.Redirect("CloseExam.aspx?ItemId=" + ItemId);
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Your session is expired! Click OK to login again');window.location ='https://www.coepd.com/login.html';", true);
        } 
    }
    public int UserExamReportCount()
    {
        using (SqlConnection objConn = new SqlConnection(Constr))
        {
            int UserId = CurrentUser.CurrentUserId;
            string Category= Convert.ToString(Session["Category"]); 
            string Topic = Convert.ToString(Session["TopicName"]);
            string Query = "Select COUNT (*)from tblUserExamReport where UserId = @UserId And Category = @Category And Topic = @Topic";
            using (SqlCommand objCmd = new SqlCommand(Query, objConn))
            {
                objConn.Open();
                objCmd.Parameters.Add("UserId", SqlDbType.VarChar).Value = UserId;
                objCmd.Parameters.Add("Category", SqlDbType.VarChar).Value = Category;
                objCmd.Parameters.Add("Topic", SqlDbType.VarChar).Value = Topic;
                int UserExamCount = Convert.ToInt32(objCmd.ExecuteScalar());
                Session["UserExamCount"] = Convert.ToString(UserExamCount);
                return UserExamCount;
            }
        }
    }
    protected void BindData()
    {
        if (Convert.ToInt16(Session["SNo"]) < sitems.Count)
        {
            lblTitle.Text = (Convert.ToInt16(Session["SNo"]) + 1) + " of " + sitems.Count + " Questions";
            //lblAnswer.Text = sitems.Count + "Correct Answers";

            List<clsAnswer> Items = new List<clsAnswer>();
            clsAnswer obj = new clsAnswer();
            obj.QuestionId = Convert.ToInt16(sitems[Convert.ToInt16(Session["SNo"])].QuestionId);
            Items = obj.LoadAll(obj);
            if (Items != null)
            {
                if (Items.Count > 0)
                {
                    rdAnswer.DataSource = Items;
                    rdAnswer.DataTextField = "Answer";
                    rdAnswer.DataValueField = "AnswerId";
                    rdAnswer.DataBind();
                    lblQuestion.Text = Items[0].Question;
                    //lblAnswer.Text = Convert.ToString(Items[3].AnswerMarks);
                    foreach (ListItem row in rdAnswer.Items)
                    {
                        clsUserExam Item = new clsUserExam();
                        Int64 UserExamId = Convert.ToInt64(sitems[Convert.ToInt16(Session["SNo"])].UserExamId);
                        Item = Item.Load(UserExamId);
                        if (Item != null)
                        {
                            if (row.Value == Item.AnswerId.ToString())
                            {
                                row.Selected = true;
                            }
                        }
                    }
                }
            }
        }
        if (Convert.ToInt16(Session["SNo"]) == 0)
        {
            BtnPrev.Visible = false;
            BtnNext.Visible = true;
            BtnFinish.Visible = false;
        }
        else if (Convert.ToInt16(Session["SNo"]) + 1 == sitems.Count)
        {
            BtnPrev.Visible = true;
            BtnNext.Visible = false;
            BtnFinish.Visible = true;
        }
        else if (Convert.ToInt16(Session["SNo"]) < sitems.Count)
        {
            BtnPrev.Visible = true;
            BtnNext.Visible = true;
            BtnFinish.Visible = false;
        }
    }
    protected void UpdateData()
    {
        foreach (ListItem row in rdAnswer.Items)
        {
            if (row.Selected == true)
            {
                clsUserExam Item = new clsUserExam();
                Item.UserExamId = Convert.ToInt64(sitems[Convert.ToInt16(Session["SNo"])].UserExamId);
                Item.QuestionId = Convert.ToInt32(sitems[Convert.ToInt16(Session["SNo"])].QuestionId);
                Item.AnswerId = Convert.ToInt32(row.Value);
                Item.IsChecked = true;
                Item.StatusId = 1;
                Item.CreatedBy = CurrentUser.CurrentUserId;
                Item.AddUpdate(Item);
            }
        }
        clsExam ExamBank = new clsExam();
        ExamBank.ExamId = Convert.ToInt32(Session["ExamId"]);
        ExamBank.UserId = CurrentUser.CurrentUserId;
        ExamBank.EndDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        if (Convert.ToInt16(Session["SNo"]) + 1 == sitems.Count)
        {
            ExamBank.StatusId = 3;
        }
        else
        {
            ExamBank.StatusId = 2;
        }
        ExamBank.CreatedBy = CurrentUser.CurrentUserId;
        ExamBank.AddUpdate(ExamBank);
    }
}