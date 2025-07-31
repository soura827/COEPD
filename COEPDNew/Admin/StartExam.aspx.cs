using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_StartExam : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;
    //int itemId = 0;
    clsTopic Item;
    // int NurturingProcessStageTaskId = 0;
    //int StageTaskCountNo = 0;
    int StageCountNo = 0;
    int NurturingProcessStageId = 1;
    int CategoryId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsTopic();
        if (ItemId > 0)
        {
            Item = Item.Load(ItemId);
            if (Item != null)
            {
                CategoryId = Convert.ToInt16(Item.CategoryId);
            }
        }
    }
    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        clsExam ExamBank = new clsExam();
        ExamBank.TopicId = ItemId;
        ExamBank.UserId = CurrentUser.CurrentUserId;
        ExamBank.StartDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        Session["StartDate"] = ExamBank.StartDate;
        DateTime StartTime = Convert.ToDateTime(DateTime.Now.ToString());
        Session["StartTime"] = StartTime;
        ExamBank.EndDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        ExamBank.StatusId = 1;
        ExamBank.CreatedBy = CurrentUser.CurrentUserId;
        int ExamId = Convert.ToInt32(ExamBank.AddUpdate(ExamBank));
        Session["ExamId"] = ExamId;
        List<clsUserExam> Items = new List<clsUserExam>();
        clsUserExam obj = new clsUserExam();
        obj.ExamId = Convert.ToInt32(ExamId);
        Items = obj.LoadAll(obj);
        Session["QBank"] = Items;
        Session["SNo"] = 0;
        if (CategoryId == 1)
        {
            clsNurturingProcessStageStatus StageObj = new clsNurturingProcessStageStatus();
            StageObj.ParticipantId = CurrentUser.CurrentParticipantId;
            StageObj.NurturingProcessStageId = NurturingProcessStageId;
            StageCountNo = StageObj.LoadNurturingProcessStageStatusValidation(StageObj);
            if (StageCountNo == 0)
            {
                StageObj.NurturingProcessStageId = NurturingProcessStageId;
                StageObj.ParticipantId = CurrentUser.CurrentParticipantId;
                StageObj.AddUpdate(StageObj);
            }
        }
        //clsNurturingProcessStageTaskStatus Obj = new clsNurturingProcessStageTaskStatus();
        //Obj.ParticipantId = CurrentUser.CurrentParticipantId;
        //Obj.NurturingProcessStageTaskId = NurturingProcessStageTaskId;
        //StageTaskCountNo = Obj.LoadNurturingProcessStageTaskStatusValidation(Obj);
        //if(StageTaskCountNo == 0)
        //{
        //    Obj.NurturingProcessStageTaskId = NurturingProcessStageTaskId;
        //    Obj.ParticipantId = CurrentUser.CurrentParticipantId;
        //    Obj.AddUpdate(Obj);
        //}
        Response.Redirect("RunExam.aspx?ItemId=" + ExamBank.TopicId);
    }
}