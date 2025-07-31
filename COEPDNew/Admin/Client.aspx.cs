using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Client : System.Web.UI.Page
{
    clsClient Item;
    int ItemId = 0;
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsClient();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Client";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtClient.Text = Item.Client;
                    txtDescription.Text = Item.Description;
                }
            }
            else
            {
                lblTitle.Text = "Add New Client";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.ClientId = Convert.ToInt16(ItemId);
        }
        Item.Client = Convert.ToString(txtClient.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = 1;
        Item.AddUpdate(Item);
        Response.Redirect("ClientSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ClientSearch.aspx");
    }
}