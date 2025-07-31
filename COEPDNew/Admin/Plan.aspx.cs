using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Plan : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsPlan Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsPlan();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                if (Item != null)
                {
                    lblTitle.Text = "Edit Data";
                    Item = Item.Load(ItemId);
                    txtPlan.Text = Item.TimeRequired;
                    txtDescription.Text = Item.Description;
                }
            }

            else
            {
                lblTitle.Text = "Add New";
            }
        }
    }
    
   
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.PlanId = Convert.ToInt16(ItemId);
        }
        
        Item.TimeRequired = Convert.ToString(txtPlan.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("PlanSearch.aspx");
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("PlanSearch.aspx");
    }
}