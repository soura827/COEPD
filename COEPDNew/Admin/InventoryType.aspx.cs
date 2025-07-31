using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_InventoryType : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsInventoryType Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsInventoryType();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Inventory Type";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtInventoryType.Text = Item.InventoryType;
                }
            }
            else
            {
                lblTitle.Text = "Add New Inventory Type";
            }
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("InventoryType.aspx");
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.InventoryTypeId = Convert.ToInt16(ItemId);
        }

        Item.InventoryType = Convert.ToString(txtInventoryType.Text);

        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("InventoryTypeSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("InventoryTypeSearch.aspx");
    }
}