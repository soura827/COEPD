using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ExamReview : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;
    
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);

        if (!IsPostBack)
        {
            BindData();
            checkvisible();
        }
    }
    //protected void BindData()
    //{
    //    clsUserExam objUserExam = new clsUserExam();
    //    objUserExam.ExamId = ItemId;
    //    gvHistory.DataSource = objUserExam.LoadAll_History(objUserExam);
    //    gvHistory.DataBind();
    //    clsUserExam obj = new clsUserExam();
    //    obj.ExamId = ItemId;
    //    gv.DataSource = obj.LoadAll(obj);
    //    gv.DataBind();
    //    decimal totalMarks = 0;
    //    if (gv.Rows.Count > 0)
    //    {
    //        foreach (GridViewRow grow in gv.Rows)
    //        {
    //            HiddenField hdnMarks = (HiddenField)grow.FindControl("hdnMarks");
    //            if (hdnMarks != null)
    //            {
    //                Label lblCorrectAnswer = (Label)grow.FindControl("lblCorrectAnswer");
    //                Label lblAnswer = (Label)grow.FindControl("lblAnswer");
    //                Label lblMarks = (Label)grow.FindControl("lblMarks");
    //                totalMarks = totalMarks + Convert.ToDecimal(hdnMarks.Value);
    //                if (hdnMarks.Value.ToString() == "0.00")
    //                {
    //                    lblAnswer.ForeColor = System.Drawing.Color.Red;
    //                    lblAnswer.Font.Strikeout = true;
    //                  //  lblCorrectAnswer.Visible = true;
    //                }
    //                else
    //                {
    //                    lblAnswer.ForeColor = System.Drawing.Color.Green;
    //                    lblAnswer.Font.Strikeout = false;
    //                    lblAnswer.Visible = false;
    //                    //lblCorrectAnswer.Visible = false;
    //                }
    //            }
    //        }
    //        Label lblTotalMarks = (Label)gv.FooterRow.FindControl("lblTotalMarks");
    //        lblTotalMarks.Text = "Total Marks : " + totalMarks.ToString();
    //    }
    //}
    protected void BindData()
    {
        clsUserExam objUserExam = new clsUserExam();
        objUserExam.ExamId = ItemId;
        gvHistory.DataSource = objUserExam.LoadAll_History(objUserExam);
        gvHistory.DataBind();
        clsUserExam obj = new clsUserExam();
        obj.ExamId = ItemId;
        gv.DataSource = obj.LoadAllWrong(obj);
        gv.DataBind();
        decimal totalMarks = 0;
        if (gv.Rows.Count > 0)
        {
            foreach (GridViewRow grow in gv.Rows)
            {
                HiddenField hdnMarks = (HiddenField)grow.FindControl("hdnMarks");
                if (hdnMarks != null)
                {
                    Label lblCorrectAnswer = (Label)grow.FindControl("lblCorrectAnswer");
                    Label lblAnswer = (Label)grow.FindControl("lblAnswer");
                    Label lblMarks = (Label)grow.FindControl("lblMarks");
                    totalMarks = totalMarks + Convert.ToDecimal(hdnMarks.Value);
                    if (hdnMarks.Value.ToString() == "0.00")
                    {
                        lblAnswer.ForeColor = System.Drawing.Color.Red;
                        lblAnswer.Font.Strikeout = true;
                        lblAnswer.Visible = true;
                        //  lblCorrectAnswer.Visible = true;
                    }
                    else
                    {
                        lblAnswer.ForeColor = System.Drawing.Color.Green;
                        lblAnswer.Font.Strikeout = false;
                        lblAnswer.Visible = false;
                        //lblCorrectAnswer.Visible = false;
                    }
                }
            }
            //Label lblTotalMarks = (Label)gv.FooterRow.FindControl("lblTotalMarks");
            //lblTotalMarks.Text = "Total Marks : " + totalMarks.ToString();
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserExamMaster.aspx");
    }
    protected void checkvisible()
    {
        clsRetakeExam RetakeExam = new clsRetakeExam();
        RetakeExam.RetakeStatusId = 0;
        RetakeExam.ExamID = ItemId;
        RetakeExam.ParticipantId = (CurrentUser.CurrentParticipantId);
        List<clsRetakeExam> list = RetakeExam.LoadAll(RetakeExam);
        if (list != null)
        {
            foreach (var a in list)
            {
                if (a.ExamID == ItemId)
                {
                    divRetakeExam.Visible = false;
                    lblretake.Text = "Retake exam request under review ";
                    lblretake.Visible = true;
                    lblretake.ForeColor = System.Drawing.Color.Green;
                }
            }
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        float MarksPersontage = 0;
        int TotalQuestions = 0;
        int CorrectAnswers = 0;
        clsUserExam obj = new clsUserExam();
        obj.ExamId = ItemId;
        obj = obj.LoadAllQuestions_History(obj);
        if(obj != null)
        {
            TotalQuestions = obj.TotalQuestions;
            CorrectAnswers = obj.CorrectAnswers;
            MarksPersontage = (CorrectAnswers * 100) / TotalQuestions;
        }
        

        if (MarksPersontage>89)
        {
            clsRetakeExam RetakeExam = new clsRetakeExam();
            RetakeExam.ExamID = ItemId;
            RetakeExam.Description = txtdiscription.Text;
            RetakeExam.CreatedBy = CurrentUser.CurrentParticipantId;
            RetakeExam.AddUpdate(RetakeExam);
            Response.Redirect("UserExamMaster.aspx");
        }
        else
        {
            clsExam Exam = new clsExam();
            Exam.Remove(ItemId);
            clsUserExam UserExam = new clsUserExam();
            UserExam.RemoveExam(ItemId);
            Response.Redirect("UserExamMaster.aspx");
        }
       
    }
}