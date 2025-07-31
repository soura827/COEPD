using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_InventoryStatus : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsInventoryStatus Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsInventoryStatus();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Inventory Status";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtInventoryStatus.Text = Item.InventoryStatus;
                }
            }
            else
            {
                lblTitle.Text = "Add New Inventory Status";
            }
        }

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("InventoryStatus.aspx");
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.InventoryStatusId = Convert.ToInt16(ItemId);
        }

        Item.InventoryStatus = Convert.ToString(txtInventoryStatus.Text);

        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("InventorystatusSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("InventorystatusSearch.aspx");
    }
}