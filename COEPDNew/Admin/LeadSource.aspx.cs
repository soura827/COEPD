using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class LeadSource : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsLeadSource Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsLeadSource();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit LeadSource";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtLeadSource.Text = Item.LeadSource;
                    txtDescription.Text = Item.Description;
                    
                }
            }
            else
            {
                lblTitle.Text = "Add LeadSource";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (ItemId > 0)
        {
            Item.LeadSourceId = Convert.ToInt16(ItemId);
        }

        Item.LeadSource = Convert.ToString(txtLeadSource.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId; 
        Item.AddUpdate(Item);
        Response.Redirect("LeadSourceSearch.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("LeadSourceSearch.aspx");
    }
}