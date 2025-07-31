using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class LeadCategory : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsLeadCategory Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsLeadCategory();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Lead Status";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtLeadCategory.Text = Item.LeadCategory;
                    txtDescription.Text = Item.Description;
                    
                }
            }
            else
            {
                lblTitle.Text = "Add Lead Status";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (ItemId > 0)
        {
            Item.LeadCategoryId = Convert.ToInt16(ItemId);
        }

        Item.LeadCategory = Convert.ToString(txtLeadCategory.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId; 
        Item.AddUpdate(Item);
        Response.Redirect("LeadCategorySearch.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("LeadCategorySearch.aspx");
    }
}