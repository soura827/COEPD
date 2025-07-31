using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Vendor : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsVendor Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsVendor();
        if (!IsPostBack)
        {
            BindVendorCategory();
            BindLocation();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Vendor";
               
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlVendorCategory.SelectedValue =  Convert.ToString(Item.VendorCategoryId);
                    txtVendor.Text = Item.Vendor;
                    txtContactName.Text = Item.ContactName;
                    txtEmail.Text = Item.Email;
                    txtMobile.Text = Item.Mobile;
                    txtPhone.Text = Item.Phone;
                    txtWebsite.Text = Item.Website;
                    txtNotes.Text = Item.Notes;

                }
            }
            else
            {
                lblTitle.Text = "Add New Vendor";
            }
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Vendor.aspx");
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.VendorId = Convert.ToInt16(ItemId);
        }

        Item.Vendor = Convert.ToString(txtVendor.Text);
        Item.ContactName = Convert.ToString(txtContactName.Text);
        Item.Email = Convert.ToString(txtEmail.Text);
        Item.Mobile = Convert.ToString(txtMobile.Text);
        Item.Phone = Convert.ToString(txtPhone.Text);
        Item.Website = Convert.ToString(txtWebsite.Text);
        Item.Notes = Convert.ToString(txtNotes.Text);
        Item.VendorCategoryId = Convert.ToInt32(ddlVendorCategory.SelectedValue);
        Item.LocationId=Convert.ToInt32(ddlLocation.SelectedValue);
        Item.LocationOffice = Convert.ToString(txtofficeaddress.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);

        Response.Redirect("VendorSearch.aspx");

    }
    protected void BindVendorCategory()
    {
        clsVendorCategory obj = new clsVendorCategory();
        ddlVendorCategory.DataSource = obj.LoadAll(obj);
        ddlVendorCategory.DataTextField = "VendorCategory";
        ddlVendorCategory.DataValueField = "VendorCategoryId";
        ddlVendorCategory.DataBind();
        ddlVendorCategory.Items.Insert(0, new ListItem("-- Select Category --", ""));

    }
    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("--Select Location--", ""));

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("VendorSearch.aspx");
    }
}