using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Topic : System.Web.UI.Page
{
    clsTopic Item;
    int ItemId = 0;
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsTopic();

        if (!IsPostBack)
        {
            BindCategory();

            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Topic";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtTopic.Text = Item.Topic;
                    txtDescription.Text = Item.Description;
                    ddlCategory.SelectedValue = Item.CategoryId.ToString();

                }
            }
            else
            {
                lblTitle.Text = "Add New Topic";
            }
        }
    }

    protected void BindCategory()
    {
        clsCategory obj = new clsCategory();
        ddlCategory.DataSource = obj.LoadAll(obj);
        ddlCategory.DataTextField = "Category";
        ddlCategory.DataValueField = "CategoryId";
        ddlCategory.DataBind();
        ddlCategory.Items.Insert(0, new ListItem("-- select --", ""));
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.TopicId = Convert.ToInt16(ItemId);
        }

        Item.Topic = Convert.ToString(txtTopic.Text);
        Item.CategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = 1;
        Item.AddUpdate(Item);
        if (ItemId > 0)
        {
            FormMessage.Text = "Topic successfully updated";
            FormMessage.Visible = true;
        }
        else
        {
            btnSubmit.Enabled = false;
            FormMessage.Text = "Topic successfully saved";
            FormMessage.Visible = true;
        }
    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Topic.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TopicSearch.aspx");
    }

}