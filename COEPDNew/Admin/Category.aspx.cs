using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Category : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsCategory Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsCategory();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Category";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtCategory.Text = Item.Category;
                    txtDescription.Text = Item.Description;       
                }
            }
            else
            {
                lblTitle.Text = "Add Category";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.CategoryId = Convert.ToInt16(ItemId);
        }
        Item.Category = Convert.ToString(txtCategory.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId; 
        Item.AddUpdate(Item);
        if (ItemId > 0)
        {
            FormMessage.Text = "Category successfully updated";
            FormMessage.Visible = true;
        }
        else
        {
            btnSubmit.Enabled = false;
            FormMessage.Text = "Category successfully saved";
            FormMessage.Visible = true;
        }
    }
    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Category.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CategorySearch.aspx");
    }
}