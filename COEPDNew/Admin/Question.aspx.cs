using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Question : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();

    clsQuestion Item;
    int ItemId = 0, CategoryId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        CategoryId = Convert.ToInt16(Request.QueryString["CatId"]);
        Item = new clsQuestion();

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
                    txtDescription.Text = Item.Description; 
                    ddlCategory.Enabled = false;
                    ddlTopic.Enabled = false;
                    txtDescription.Enabled = true;
                    txtDescription.Visible = true;

                    if (Item.TopicId > 0)
                    {
                        ddlCategory.SelectedValue = Convert.ToString(CategoryId);
                        BindTopic();
                        ddlTopic.SelectedValue = Item.TopicId.ToString();
                    }
                }
            }
        }
        else
        {
            lblTitle.Text = "Add New Question";
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

    private string QuerystringParameters()
    {
        if (ddlCategory.SelectedIndex > 0 && ddlTopic.SelectedIndex > 0)
        {
            CategoryId = Convert.ToInt32(ddlCategory.SelectedValue);
            int TopicId = Convert.ToInt32(ddlTopic.SelectedValue);
            return "?CatId=" + CategoryId + "&TpcId=" + TopicId;
        }
        return "";
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
        Item.AddUpdate(Item);
        if (ItemId > 0)
        {
            FormMessage.Text = "Question successfully updated";
            FormMessage.Visible = true;
        }
        else
        {
            btnSubmit.Enabled = false;
            FormMessage.Text = "Question successfully saved";
            FormMessage.Visible = true;
        }
    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Question.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("QuestionSearch.aspx" + QuerystringParameters());
    }
}