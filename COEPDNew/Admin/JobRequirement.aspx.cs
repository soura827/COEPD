using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlTypes;
using BusinessLayer;
public partial class JobRequirement : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsJobRequirement Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsJobRequirement();
        if(!IsPostBack)
        {
            if(ItemId > 0)
            {
                lblTitle.Text = "Edit Job Requirement";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtCompanyName.Text = Item.CompanyName;
                    txtContact.Text = Item.ContactPerson;
                    txtEmail.Text = Item.EmailId;
                    txtMobile.Text = Item.Mobile;
                    txtDescription.Text = Item.JobDescription;
                    txtExpiry.Text = Convert.ToString(Item.ExpiryDate);
                    txtRole.Text = Item.JobRole;
                }
            }
            else
            {
                lblTitle.Text = "Add Job Requirement";
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.JobRequirementId = Convert.ToInt16(ItemId);
        }
        Item.CompanyName = txtCompanyName.Text;
        Item.ContactPerson = txtContact.Text;
        Item.EmailId = txtEmail.Text;
        Item.Mobile = txtMobile.Text;
        Item.JobDescription = txtDescription.Text;
        Item.ExpiryDate = Convert.ToString(txtExpiry.Text);
        Item.JobRole = txtRole.Text;
        Item.IsActive = true;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("JobRequirementSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("JobRequirementSearch.aspx");
    }
}