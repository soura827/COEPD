using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ReceiptType : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsReceiptType Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsReceiptType();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit ReceiptType";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtReceiptType.Text = Item.ReceiptType;
                    
                }
            }
            else
            {
                lblTitle.Text = "Add ReceiptType";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (ItemId > 0)
        {
            Item.ReceiptTypeId = Convert.ToInt16(ItemId);
        }

        Item.ReceiptType = Convert.ToString(txtReceiptType.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId; 
        Item.AddUpdate(Item);
        Response.Redirect("ReceiptTypeSearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReceiptTypeSearch.aspx");
    }
}