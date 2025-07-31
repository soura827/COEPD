using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_VoucherTypeSearch : System.Web.UI.Page
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
        Response.Redirect("VoucherType.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        clsVoucherType obj = new clsVoucherType();
        obj.keywords = txtSearch.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
        setGridView();
    }
    protected void BindData()
    {
        clsVoucherType obj = new clsVoucherType();
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
        setGridView();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("VoucherType.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsVoucherType Item = new clsVoucherType();
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Voucher type successfully removed";
            ErrorMessage.Visible = true;
        }
    }

}