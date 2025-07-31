using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_VoucherType : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsVoucherType Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsVoucherType();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Voucher Type";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtVoucherType.Text = Item.VoucherType;

                }
            }
            else
            {
                lblTitle.Text = "Add New Voucher Type";
            }
        }

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (ItemId > 0)
        {
            Item.VoucherTypeId = Convert.ToInt16(ItemId);
        }

        Item.VoucherType = Convert.ToString(txtVoucherType.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("VoucherTypeSearch.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("VoucherTypeSearch.aspx");
    }
}