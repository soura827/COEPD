using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class AnswerSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    int TopicId = 0, CategoryId = 0, Qid = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        TopicId = Convert.ToInt16(Request.QueryString["TId"]);
        CategoryId = Convert.ToInt16(Request.QueryString["CId"]);
        Qid = Convert.ToInt16(Request.QueryString["Qid"]);
        if (!IsPostBack)
        {
            BindCategory();
            ddlCategory.SelectedValue = Convert.ToString(CategoryId);
            BindTopic();
            ddlTopic.SelectedValue = Convert.ToString(TopicId);
            BindQuestion();
            if (Qid > 0)
            {
                ddlQuestion.SelectedValue = Convert.ToString(Qid);
                BindData();
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
        ddlTopic.Items.Insert(0, new ListItem("-- Select Topic --", "0"));
        ddlQuestion.Items.Clear();
        ddlQuestion.Items.Insert(0, new ListItem("-- Select Question --", "0"));
        gv.DataBind();
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
        ddlQuestion.Items.Insert(0, new ListItem("-- Select Question --", "0"));
        gv.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Answer.aspx");
    }
    protected void BindData()
    {
        if (ddlQuestion.Items.Count > 1)
        {
            clsAnswer obj = new clsAnswer();
            obj.QuestionId = Convert.ToInt32(ddlQuestion.SelectedValue);
            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();
        }
        else
        {
            gv.DataSource = null;
            gv.DataBind();
        }
    }
    private string QueryStringParameters()
    {
        string CId = ddlCategory.SelectedValue;
        string TId = ddlTopic.SelectedValue;
        return "TId=" + TId + "&CId=" + CId;
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Answer.aspx?ItemId=" + e.CommandArgument + "&" + QueryStringParameters());
        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt32(e.CommandArgument);
            clsAnswer Item = new clsAnswer();
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Answer successfully removed";
            ErrorMessage.Visible = true;
        }
    }
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindTopic();
    }
    protected void ddlQuestion_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlQuestion.SelectedIndex > 0)
        {
            BindData();
        }
        gv.DataBind();
    }
    protected void ddlTopic_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindQuestion();
    }
}