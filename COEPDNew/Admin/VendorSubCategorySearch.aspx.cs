using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class VendorSubCategorySearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void setGridView()
    {
        if (CurrentUser.IsAdmin == false)
        {
            //gv.Columns[0].Visible = false;
        }
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
        Response.Redirect("VendorsubCategory.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {

        BindData();

    }
    protected void BindData()
    {
        clsVendorCategory obj = new clsVendorCategory();
        obj.keywords = txtsearch.Text;
        gv.DataSource = obj.LoadAllSubCategory(obj);
        gv.DataBind();

        setGridView();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("VendorSubCategory.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsVendorCategory Item = new clsVendorCategory();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Vendor category successfully removed";
            ErrorMessage.Visible = true;
        }
    }
}