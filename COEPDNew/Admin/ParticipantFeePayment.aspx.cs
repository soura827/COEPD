using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ParticipantFeePayment : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsLead Item;
    int ItemId = 0;
    DateTime DateTime;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            BindLead();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Participant Installment  Details";
            }
        }


    }
    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        ddlParticipant.Items.Clear();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select participant -- ", ""));
        if (txtSearch.Text != "")
            BindLead();
    }

    protected void BindLead()
    {
        ddlParticipant.Items.Clear();
        clsLead obj = new clsLead();
        obj.keywords = txtSearch.Text;
        ddlParticipant.DataSource = obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Lead";
        ddlParticipant.DataValueField = "LeadId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Lead -- ", ""));
    }

    protected void ddlParticipant_SelectedIndexChanged(object sender, EventArgs e)
    {
        clsActivity Item;
        Item = new clsActivity();
        Item = Item.Load(ItemId);
        if (Item != null)
        {
            //ddlActivityCategory.SelectedValue = Item.ActivityCategoryId.ToString();
            //BindActivitySubCategory();
            //ddlActivitySubCategory.Text = Item.ActivitySubCategoryId.ToString();
            //txtActivity.Text = Item.Activity.ToString();
            //txtDescription.Text = Item.Description.ToString();

        }
    }

}