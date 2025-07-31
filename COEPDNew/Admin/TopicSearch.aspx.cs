using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class TopicSearch : System.Web.UI.Page
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
            BindData();
        }
    }
    protected void BindCategory()
    {
        clsCategory obj = new clsCategory();
        ddlCategory.DataSource = obj.LoadAll(obj);
        ddlCategory.DataTextField = "Category";
        ddlCategory.DataValueField = "CategoryId";
        ddlCategory.DataBind();
        ddlCategory.Items.Insert(0, new ListItem("-- Select Category --", "0"));
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Topic.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindData()
    {
        clsTopic obj = new clsTopic();
        obj.keywords = txtSearch.Text;
        obj.CategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
       
    }

    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Topic.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsTopic Item = new clsTopic();
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Topic successfully removed";
            ErrorMessage.Visible = true;
        }
    }
}