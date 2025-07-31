using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class CommunicationType : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsCommunicationType Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsCommunicationType();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Communication Type";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtCommunicationType.Text = Item.CommunicationType;
                }
            }
            else
            {
                lblTitle.Text = "Add Communication Type";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.CommunicationTypeId = Convert.ToInt16(ItemId);
        }

        Item.CommunicationType = Convert.ToString(txtCommunicationType.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId; 
        Item.AddUpdate(Item);
        Response.Redirect("CommunicationTypeSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CommunicationTypeSearch.aspx");
    }
}