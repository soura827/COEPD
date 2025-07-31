using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class VendorCategory : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsVendorCategory Item;
    int ItemId = 0;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsVendorCategory();
        if (!IsPostBack)
        {
           

            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Vendor Category";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtVendorCategory.Text = Item.VendorCategory;
                  

                }
            }
            else
            {
                lblTitle.Text = "Add Vendor Category";
            }
        }

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("VendorCategory.aspx");
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.VendorCategoryId = Convert.ToInt16(ItemId);
        }

        Item.VendorCategory = Convert.ToString(txtVendorCategory.Text);
      
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.ParentCategoryId = 0;
        Item.AddUpdate(Item);
        Response.Redirect("VendorCategorySearch.aspx");


    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("VendorCategorySearch.aspx");
    }
}