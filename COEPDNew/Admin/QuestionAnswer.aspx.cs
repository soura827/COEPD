using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class QuestionAnswer : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();

    clsQuestion Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsQuestion();
        clsAnswer item = new clsAnswer();

        if (!IsPostBack)
        {
            BindCategory();


            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Question";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtQuestion.Text = Item.Question;
                    txtQuestion.Text = Item.Question;
                    txtDescription.Enabled = true;
                    txtDescription.Visible = true;
                    txtDescription.Text = Item.Description;
                    txtAnswer1.Text = item.Answer;
                    txtAnswer2.Text = item.Answer;
                    txtAnswer3.Text = item.Answer;
                    txtAnswer4.Text = item.Answer;
                    txtMarks1.Text = Convert.ToString(item.AnswerMarks);
                    txtMarks2.Text = Convert.ToString(item.AnswerMarks);
                    txtMarks3.Text = Convert.ToString(item.AnswerMarks);
                    txtMarks4.Text = Convert.ToString(item.AnswerMarks);
                    ddlCategory.Enabled = false;
                    ddlTopic.Enabled = false;
                    txtQuestion.Enabled = false;
                    txtAnswer1.Enabled = false;
                    txtAnswer2.Enabled = false;
                    txtAnswer3.Enabled = false;
                    txtAnswer4.Enabled = false;
                    txtMarks1.Enabled = false;
                    txtMarks2.Enabled = false;
                    txtMarks3.Enabled = false;
                    txtMarks4.Enabled = false;


                    if (Item.TopicId > 0)
                    {
                        clsTopic Topic = new clsTopic();
                        Topic = Topic.Load(Item.TopicId);

                        if (Topic != null)
                        {
                            ddlCategory.SelectedValue = Topic.CategoryId.ToString();
                            BindTopic();
                            ddlTopic.SelectedValue = Item.TopicId.ToString();
                        }
                    }
                }
            }
            else
            {
                BindTopic();
                lblTitle.Text = "Add New Question";
            }
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

    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindTopic();
    }

   

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.QuestionId = Convert.ToInt16(ItemId);
        }

        Item.Question = Convert.ToString(txtQuestion.Text);
        Item.TopicId = Convert.ToInt16(ddlTopic.SelectedValue);
        Item.QuestionTypeId = Convert.ToInt16(1);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = 1;

        string outmsg = Item.AddUpdate(Item);

        if (ItemId > 0)
        {
            FormMessage.Text = "Question & Answer successfully updated";
            FormMessage.Visible = true;
        }
        else
        {
            if (txtAnswer1.Text.Length > 0)
            {
                clsAnswer Answer1 = new clsAnswer();
                Answer1.QuestionId = Convert.ToInt16(outmsg);
                Answer1.Answer = Convert.ToString(txtAnswer1.Text);
                Answer1.AnswerMarks = Convert.ToDecimal(txtMarks1.Text);
                Answer1.CreatedBy = 1;
                Answer1.AddUpdate(Answer1);
            }

            if (txtAnswer2.Text.Length > 0)
            {
                clsAnswer Answer2 = new clsAnswer();
                Answer2.QuestionId = Convert.ToInt16(outmsg);
                Answer2.Answer = Convert.ToString(txtAnswer2.Text);
                Answer2.AnswerMarks = Convert.ToDecimal(txtMarks2.Text);
                Answer2.CreatedBy = 1;
                Answer2.AddUpdate(Answer2);
            }

            if (txtAnswer3.Text.Length > 0)
            {
                clsAnswer Answer3 = new clsAnswer();
                Answer3.QuestionId = Convert.ToInt16(outmsg);
                Answer3.Answer = Convert.ToString(txtAnswer3.Text);
                Answer3.AnswerMarks = Convert.ToDecimal(txtMarks3.Text);
                Answer3.CreatedBy = 1;
                Answer3.AddUpdate(Answer3);
            }

            if (txtAnswer4.Text.Length > 0)
            {
                clsAnswer Answer4 = new clsAnswer();
                Answer4.QuestionId = Convert.ToInt16(outmsg);
                Answer4.Answer = Convert.ToString(txtAnswer4.Text);
                Answer4.AnswerMarks = Convert.ToDecimal(txtMarks4.Text);
                Answer4.CreatedBy = 1;
                Answer4.AddUpdate(Answer4);
            }


            btnSubmit.Enabled = false;
            FormMessage.Text = "Question & Answer successfully saved";
            FormMessage.Visible = true;
        }
    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Question.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("QuestionSearch.aspx");
    }
}