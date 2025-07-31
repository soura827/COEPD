using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_InventoryClassificationSearch : System.Web.UI.Page
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
        Response.Redirect("InventoryClassification.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {

        clsInventoryClassification obj = new clsInventoryClassification();
        obj.keywords = txtsearch.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();   

    }
    protected void BindData()
    {
        clsInventoryClassification obj = new clsInventoryClassification();
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("InventoryClassification.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsInventoryClassification Item = new clsInventoryClassification();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Inventory Classification successfully removed";
            ErrorMessage.Visible = true;
        }
    }
}