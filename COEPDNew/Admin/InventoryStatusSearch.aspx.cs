using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_InventoryStatusSearch : System.Web.UI.Page
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
            BindData();
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("InventoryStatus.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        clsInventoryStatus obj = new clsInventoryStatus();
        obj.keywords = txtsearch.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void BindData()
    {
        clsInventoryStatus obj = new clsInventoryStatus();
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("InventoryStatus.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsInventoryStatus Item = new clsInventoryStatus();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Inventory status successfully removed";
            ErrorMessage.Visible = true;
        }
    }
}