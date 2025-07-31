using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Faq : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsFaq Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsFaq();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                if (Item != null)
                {
                    lblTitle.Text = "Edit Faq";
                    Item = Item.Load(ItemId);
                    txtFaq.Text = Item.Faq;
                    txtDescription.Text = Item.Description;
                }
            }
            else
            {
                lblTitle.Text = "Add New Faq";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.FaqId = Convert.ToInt16(ItemId);
        }
        
        Item.Faq = Convert.ToString(txtFaq.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.FaqTypeId = Convert.ToInt16(0);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("FaqSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("FaqSearch.aspx");
    }
}