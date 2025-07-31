using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_InventoryStockSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindInventoryType();
            BindData();
        }
    }
    protected void BindInventoryType()
    {
        clsInventoryType obj = new clsInventoryType();
        ddlInventoryType.DataSource = obj.LoadAll(obj);
        ddlInventoryType.DataTextField = "InventoryType";
        ddlInventoryType.DataValueField = "InventoryTypeId";
        ddlInventoryType.DataBind();
        ddlInventoryType.Items.Insert(0, new ListItem("-- All InventoryTypes --", "0"));
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
        ddlInventory.Items.Insert(0, new ListItem("-- Select Inventory --", "0"));
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("InventoryStock.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindData()
    {
        clsInventoryStock obj = new clsInventoryStock();
        obj.keywords = txtSearch.Text;
        obj.InventoryTypeId = Convert.ToInt16(ddlInventoryType.SelectedValue);
        obj.InventoryId = Convert.ToInt16(ddlInventory.SelectedValue);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("InventoryStock.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsInventoryStock Item = new clsInventoryStock();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Inventory Stock successfully removed";
            ErrorMessage.Visible = true;
        }
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
    protected void ddlInventoryType_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlInventory.Items.Clear();
        if (ddlInventoryType.SelectedIndex > 0)
        {
            BindInventory();
        }
        else
        {
            ddlInventory.Items.Insert(0, new ListItem("-- Select Inventory --", "0"));
            BindData();
        }
    }

    protected void ddlInventory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}