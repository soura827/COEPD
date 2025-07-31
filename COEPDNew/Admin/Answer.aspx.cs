using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Answer : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsAnswer Item;
    int ItemId = 0, TopicId = 0, CategoryId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        TopicId = Convert.ToInt32(Request.QueryString["TId"]);
        CategoryId = Convert.ToInt32(Request.QueryString["CId"]);
        Item = new clsAnswer();
        if (!IsPostBack)
        {
            BindCategory();
            BindTopic();
            BindQuestion();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Answer";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    //clsQuestion Question = new clsQuestion();
                    //Question = Question.Load(Convert.ToInt16(Item.QuestionId));
                    ddlCategory.SelectedValue= Convert.ToString(CategoryId);
                    ddlCategory.Enabled= false;
                    BindTopic();
                    ddlTopic.SelectedValue =Convert.ToString(TopicId);
                    ddlTopic.Enabled= false;
                    // ddlTopic.Enabled = false;
                    BindQuestion();
                    ddlQuestion.SelectedValue = Item.QuestionId.ToString();
                    ddlQuestion.Enabled= false;
                    txtAnswer.Text = Item.Answer;
                    txtMarks.Text = Item.AnswerMarks.ToString();
                    txtMarks.Enabled= false;
                }
            }
            else
            {
                lblTitle.Text = "Add Answer";
               // ddlQuestion.SelectedValue = QId.ToString();
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
            Item.AnswerId = Convert.ToInt32(ItemId);
        Item.QuestionId = Convert.ToInt16(ddlQuestion.SelectedValue);
        Item.Answer = Convert.ToString(txtAnswer.Text);
        Item.AnswerMarks = Convert.ToDecimal(txtMarks.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        if (ItemId > 0)
        {
            FormMessage.Text = "Answer successfully updated";
            FormMessage.Visible = true;
        }
        else
        {
            btnSubmit.Enabled = false;
            FormMessage.Text = "Answer successfully saved";
            FormMessage.Visible = true;
        }
    }
    protected void BindCategory()
    {
        ddlCategory.Items.Clear();
        clsCategory obj = new clsCategory();
        ddlCategory.DataSource = obj.LoadAll(obj);
        ddlCategory.DataTextField = "Category";
        ddlCategory.DataValueField = "CategoryId";
        ddlCategory.DataBind();
        ddlCategory.Items.Insert(0, new ListItem("-- Select Category --", ""));
    }
    protected void BindTopic()
    {
        ddlTopic.Items.Clear();
        if (ddlCategory.SelectedIndex > 0)
        {
            clsTopic obj = new clsTopic();
            obj.CategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
            ddlTopic.DataSource = obj.LoadAll(obj);
            ddlTopic.DataTextField = "Topic";
            ddlTopic.DataValueField = "TopicId";
            ddlTopic.DataBind();
        }
        ddlTopic.Items.Insert(0, new ListItem("-- Select Topic --", ""));
    }
    protected void BindQuestion()
    {
        ddlQuestion.Items.Clear();
        if (ddlTopic.SelectedIndex > 0)
        {
            clsQuestion obj = new clsQuestion();
            obj.TopicId = Convert.ToInt16(ddlTopic.SelectedValue);
            ddlQuestion.DataSource = obj.LoadAll(obj);
            ddlQuestion.DataTextField = "Question";
            ddlQuestion.DataValueField = "QuestionId";
            ddlQuestion.DataBind();
        }
        ddlQuestion.Items.Insert(0, new ListItem("-- Select Question--", ""));
    }
    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Answer.aspx");
    }
    private string QueryStringParameters()
    {
        if (ddlCategory.SelectedIndex > 0 && ddlQuestion.SelectedIndex > 0 && ddlTopic.SelectedIndex > 0)
        {
            int CId = Convert.ToInt32(ddlCategory.SelectedValue);
            int TId = Convert.ToInt32(ddlTopic.SelectedValue);
            int Qid = Convert.ToInt32(ddlQuestion.SelectedValue);
            return "?TId=" + TId + "&CId=" + CId + "&Qid=" + Qid;
        }
        return "";  
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AnswerSearch.aspx" + QueryStringParameters());
    }
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindTopic();
    }
    protected void ddlTopic_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindQuestion();
    }
}