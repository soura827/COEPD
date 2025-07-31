using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class QuestionSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCategory();
            ddlCategory.SelectedValue = Request.QueryString["CatId"]; 
            BindTopic();
            ddlTopic.SelectedValue = Request.QueryString["TpcId"];
            BindData();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("QuestionAnswer.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlTopic_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCategory.SelectedIndex > 0)
        {
            BindTopic();
        }
        else
        {
            BindTopic();
            gv.DataBind();
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
        ddlCategory.Items.Insert(0, new ListItem("-- Select Category --", "0"));
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

    protected void BindData()
    {
        clsQuestion obj = new clsQuestion();

        if (ddlTopic.SelectedIndex >  0)
        {
            obj.TopicId = Convert.ToInt16(ddlTopic.SelectedValue);
            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();

        }
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Question.aspx?ItemId=" + e.CommandArgument + "&CatId=" + ddlCategory.SelectedValue);
        }

        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsQuestion Item = new clsQuestion();
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Question successfully removed";
            ErrorMessage.Visible = true;
        }
    }

}