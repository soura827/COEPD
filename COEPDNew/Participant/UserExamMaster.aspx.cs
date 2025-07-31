//This code behind Page is used to Display Assigned ExamCategories of Participant with Available Exams,Attempted Exams and Retake Request History .
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class UserExamMaster : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    //When Page Loading Display Assigned ExamCategories,AvailableExams,AttemptedExams and Retake Exam History in GridViews.
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindAssignedExamCategory();
            BindData();
            BindExamData();
            BindRetakeExam();
        }                  
    }

    // This is the old code,This method is used to bind All Exam Categories 
    //protected void BindCategory()
    //{
    //    clsCategory obj = new clsCategory();
    //    ddlCategory.DataSource = obj.LoadAll(obj);
    //    ddlCategory.DataTextField = "Category";
    //    ddlCategory.DataValueField = "CategoryId";
    //    ddlCategory.DataBind();
    //    ddlCategory.Items.Insert(0, new ListItem("-- All --", "0"));
    //}

    //This Method is Used to bind Based Assigned  ExamCategories to Participant Based on  ParticipantId.
    protected void BindAssignedExamCategory()
    {
        clsExamCategoryAssignment obj = new clsExamCategoryAssignment();
        obj.ParticipantId = CurrentUser.CurrentParticipantId;
        ddlCategory.DataSource = obj.LoadAll(obj);
        ddlCategory.DataTextField = "Category";
        ddlCategory.DataValueField = "CategoryId";
        ddlCategory.DataBind();
    }

    //This is the old code.Not used anywhere.
    //protected void btnAdd_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("Topic.aspx");
    //}
    //This is the old code.Not used anywhere.
    //protected void btnSearch_Click(object sender, EventArgs e)
    //{
    //    BindData();
    //}
    //This Method is used Bind Available Exams in GridView.
    protected void BindData()
    {
        List<clsTopic> items = new List<clsTopic>();
        List<clsTopic> AvailableItems = new List<clsTopic>();

        clsTopic obj = new clsTopic();
        obj.UserId = CurrentUser.CurrentUserId;
        if (ddlCategory.Items.Count > 0)
        {
            obj.CategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
            //This LoadAll method is used to getting the topics list Based on CategoryId  from database table
            items = obj.LoadAll(obj);
        }            
        if (items != null)
        {
            int sno = 1;
            foreach (clsTopic iItem in items)
            {
                if (iItem.StatusId == 0)
                {
                    iItem.SNo = sno;
                    AvailableItems.Add(iItem);
                    sno = sno + 1;
                }
            }
        }

        if (AvailableItems != null)
        {
            gv.DataSource = AvailableItems;
            gv.DataBind();        
            lblCount.Text = "Available Exams : " + Convert.ToString(gv.Rows.Count);
        }
        else
        {
            lblCount.Text = "Exams Not Available";
        }
    }
   //This Method  is used to Display Attempted Exams in GridView.
    protected void BindExamData()
    {
        clsExam obj = new clsExam();
        obj.UserId = Convert.ToInt32(CurrentUser.CurrentUserId);
        if (ddlCategory.Items.Count > 0)
        {
            obj.CategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
        }
        List<clsExam> item = obj.LoadAll(obj);
        if (item != null)
        {
            lblCountfooter.Text = "Attempted Exams : " + item.Count.ToString();
        }
        gvExam.DataSource = item;
        gvExam.DataBind();
    }
    //This Row command is used when click on TakeExam in Gridview,Exam will start and page will Redirect to StartExam Page .
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdStart")
        {
            Response.Redirect("StartExam.aspx?ItemId=" + e.CommandArgument);
        }
    }
  //This Row comand is used when click on Review in Gridview,page will Redirect to ExamReview page.
    protected void gvExam_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdReview")
        {
            Response.Redirect("ExamReview.aspx?ItemId=" + e.CommandArgument);
        }
    }
    //This Event will fire when selecting the Exam Categories and it will bind the Selected ExamCategory related Data.
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
    //This Method is Used to Display Retake Exam History in GridView.
    public void BindRetakeExam()
    {
        clsRetakeExam obj = new clsRetakeExam();
        obj.ParticipantId = CurrentUser.CurrentParticipantId;
        gvRetakeExam.DataSource = obj.LoadAll(obj);
        gvRetakeExam.DataBind();
    }
}