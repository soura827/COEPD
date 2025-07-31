using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_InventoryStock : System.Web.UI.Page
{

    CurrentUser CurrentUser = new CurrentUser();
    clsInventoryStock Item;
    clsUtility utility = new clsUtility();
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsInventoryStock();
        if (!IsPostBack)
        {
            BindInventoryType();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Inventory Stock";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlInventoryType.SelectedValue = Item.InventoryTypeId.ToString();
                    BindInventory();
                    ddlInventory.SelectedValue = Item.InventoryId.ToString();
                    txtQuantity.Text = Item.Quantity.ToString();
                }
            }
            else
            {
                lblTitle.Text = "Add New Inventory Stock";

            }
        }
    }
    protected void BindInventoryType()
    {
        clsInventoryType obj = new clsInventoryType();
        ddlInventoryType.DataSource = obj.LoadAll(obj);
        ddlInventoryType.DataTextField = "InventoryType";
        ddlInventoryType.DataValueField = "InventoryTypeId";
        ddlInventoryType.DataBind();
        ddlInventoryType.Items.Insert(0, new ListItem("-- Select InventoryType --", ""));
        ddlInventory.Items.Insert(0, new ListItem("-- Select Inventory --", "0"));
    }
    protected void BindInventory()
    {
        clsInventory obj = new clsInventory();
        obj.InventoryTypeId = Convert.ToInt16(ddlInventoryType.SelectedValue);
        ddlInventory.DataSource = obj.LoadAll(obj);
        ddlInventory.DataTextField = "InventoryName";
        ddlInventory.DataValueField = "InventoryId";
        ddlInventory.DataBind();
        ddlInventory.Items.Insert(0, new ListItem("-- Select Inventory --", ""));
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.InventoryStockId = Convert.ToInt16(ItemId);
        }
        Item.InventoryTypeId = Convert.ToInt16(ddlInventoryType.SelectedValue);
        Item.InventoryId = Convert.ToInt16(ddlInventory.SelectedValue);
        Item.Quantity = Convert.ToInt16(txtQuantity.Text);
        Item.EmployeeId = 0;
        Item.ParticipantId = 0;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        string OutMsg = Item.AddUpdate(Item);
        if (OutMsg.Contains("Entered") == true)
        {
            ErrorMessage.Text = "Entered Quantity Limit Exceeded Inventory Stock ";
            ErrorMessage.Visible = true;
        }
        else
        {
            Response.Redirect("InventoryStockSearch.aspx");
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("InventoryStockSearch.aspx");
    }
    protected void ddlInventoryType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlInventoryType.SelectedValue != "0")
        {
            ddlInventory.Items.Clear();
            BindInventory();
        }
    }
}