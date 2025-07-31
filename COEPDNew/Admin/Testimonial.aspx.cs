using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Testimonial : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsTestimonial Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsTestimonial();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Testimonial";
                Item = Item.Load(ItemId);
                txtTestimonial.Text = Item.Testimonial;
                if (Item.IsFeatured == true)
                {
                    chkFeatured.Checked = true;
                }
                else
                {
                    chkFeatured.Checked = false;
                }
                txtDescription.Text = Item.Description;
            }
            else
            {
                lblTitle.Text = "Add Testimonial";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (ItemId > 0)
        {
            Item.TestimonialId = Convert.ToInt16(ItemId);
        }

        Item.Testimonial = Convert.ToString(txtTestimonial.Text);
        if (chkFeatured.Checked == true)
        {
            Item.IsFeatured = true;
        }
        else
        {
            Item.IsFeatured = false;
        }
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("TestimonialSearch.aspx");

    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Testimonial.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TestimonialSearch.aspx");
    }
}