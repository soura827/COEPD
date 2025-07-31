using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Designation : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsDesignation Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsDesignation();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Designation";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtDesignation.Text = Item.Designation;
                    txtDescription.Text = Item.Description;
                }
            }
            else
            {
                lblTitle.Text = "Add Designation";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.DesignationId = Convert.ToInt16(ItemId);
        }
        Item.Designation = Convert.ToString(txtDesignation.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        if (ItemId > 0)
        {
            FormMessage.Text = "Designation successfully updated";
            FormMessage.Visible = true;
        }
        else
        {
            btnSubmit.Enabled = false;
            FormMessage.Text = "Designation successfully saved";
            FormMessage.Visible = true;
        }
    }
    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Designation.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DesignationSearch.aspx");
    }
}