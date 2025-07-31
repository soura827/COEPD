using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class JobCategory : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsJobCategory Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsJobCategory();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Job Category";
                Item = Item.Load(ItemId);
                txtJobCategory.Text = Item.JobCategory;
               
            }
            else
            {
                lblTitle.Text = "Add Job Category";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (ItemId > 0)
        {
            Item.JobCategoryId = Convert.ToInt16(ItemId);
        }

        Item.JobCategory = Convert.ToString(txtJobCategory.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("JobCategorySearch.aspx");

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("JobCategorySearch.aspx");
    }
}