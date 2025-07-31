using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class VendorSubCategory : System.Web.UI.Page
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

            BindVenderCategory();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Vendor Sub Category";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtVendorsubCategory.Text = Item.VendorCategory;
                    ddlVenderCategory.SelectedValue = Convert.ToString(Item.ParentCategoryId);

                }
            }
            else
            {
                lblTitle.Text = "Add Vendor Sub Category";
            }
        }

    }
    protected void BindVenderCategory()
    {
        clsVendorCategory obj = new clsVendorCategory();
        obj.ParentCategoryId = 0;
        ddlVenderCategory.DataSource = obj.LoadAll(obj);
        ddlVenderCategory.DataTextField = "VendorCategory";
        ddlVenderCategory.DataValueField = "VendorCategoryId";
        ddlVenderCategory.DataBind();
        ddlVenderCategory.Items.Insert(0, new ListItem("-- Select VendorCategory --", ""));
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.VendorCategoryId = Convert.ToInt16(ItemId);
        }

        Item.VendorCategory = Convert.ToString(txtVendorsubCategory.Text);

        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.ParentCategoryId = Convert.ToInt32(ddlVenderCategory.SelectedValue);
        Item.AddUpdate(Item);
        Response.Redirect("VendorSubCategorySearch.aspx");


    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("VendorSubCategorySearch.aspx");
    }
}