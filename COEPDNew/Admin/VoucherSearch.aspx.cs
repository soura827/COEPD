using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class VoucherSearch : System.Web.UI.Page
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
            BindVoucher();
            BindCompany();
            BindPaymentType();
            BindVendor();
            BindData();
        }
    }

    protected void BindPaymentType()
    {
        clsPaymentType obj = new clsPaymentType();
        ddlPaymentType.DataSource = obj.LoadAll(obj);
        ddlPaymentType.DataTextField = "Paymenttype";
        ddlPaymentType.DataValueField = "PaymenttypeId";
        ddlPaymentType.DataBind();
        ddlPaymentType.Items.Insert(0, new ListItem("--Select Payment--", "0"));
    }
    protected void BindVendor()
    {

        clsVendor obj = new clsVendor();
        ddlVendor.DataSource = obj.LoadAll(obj);
        ddlVendor.DataTextField = "Vendor";
        ddlVendor.DataValueField = "VendorId";
        ddlVendor.DataBind();
        ddlVendor.Items.Insert(0, new ListItem("-- Select Vendor --", "0"));
    }
    protected void BindCompany()
    {
        clsCompany obj = new clsCompany();
        ddlCompany.DataSource = obj.LoadAll(obj);
        ddlCompany.DataTextField = "Company";
        ddlCompany.DataValueField = "CompanyId";
        ddlCompany.DataBind();
        ddlCompany.Items.Insert(0, new ListItem("--Select Company --", "0"));
    }
    protected void BindVoucher()
    {
        clsVoucherType obj = new clsVoucherType();
        ddlVoucher.DataSource = obj.LoadAll(obj);
        ddlVoucher.DataTextField = "VoucherType";
        ddlVoucher.DataValueField = "VoucherTypeId";
        ddlVoucher.DataBind();
        ddlVoucher.Items.Insert(0, new ListItem("--Select VoucherType--", "0"));
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Voucher.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindData()
    {
       
        clsVoucher obj = new clsVoucher();
        obj.keywords = txtSearch.Text;
        obj.VendorId = Convert.ToInt32(ddlVendor.SelectedValue);
        obj.PaymentTypeId = Convert.ToInt32(ddlPaymentType.SelectedValue);
        obj.CompanyId = Convert.ToInt32(ddlCompany.SelectedValue);
        obj.VoucherTypeId = Convert.ToInt32(ddlVoucher.SelectedValue);
      
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Voucher.aspx?ItemId=" + e.CommandArgument);
        }
    }

    protected void ddlVoucher_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlCompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlVendor_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlPaymentType_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

}