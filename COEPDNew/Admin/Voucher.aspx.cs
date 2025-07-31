using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Voucher : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsVoucher Item;
    int ItemId = 0;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        Item = new clsVoucher();

        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);

        if (!IsPostBack)
        {
            LoadVoucherType();
            LoadVendor();
            LoadCompany();
            LoadPaymentType();

            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Voucher";
                Item = Item.Load(ItemId);

                if (Item != null)
                {
                    DateTime dtVoucherDate = Convert.ToDateTime(Item.VoucherDate);
                    txtDay.Text = dtVoucherDate.Day.ToString();
                    txtMonth.Text = dtVoucherDate.Month.ToString();
                    txtYear.Text = dtVoucherDate.Year.ToString();
                    txtVoucher.Text = Item.Voucher;
                    ddlVendor.SelectedValue = Item.VendorId.ToString();
                    ddlVoucherType.SelectedValue = Item.VoucherTypeId.ToString();
                    ddlPaymenttype.SelectedValue = Item.PaymentTypeId.ToString();
                    ddlPaymenttype.Enabled = false;
                    ddlCompany.SelectedValue = Item.CompanyId.ToString();
                    ddlCompany.Enabled = false;

                    if (Item.PaymentTypeId == 2)
                    {
                        #region "Cheque"

                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "document.getElementById('divCheque').style.display = ''", true);

                        DateTime dtChequeDate = Convert.ToDateTime(Item.ChequeDate);
                        txtCDay.Text = dtChequeDate.Day.ToString();
                        txtCMonth.Text = dtChequeDate.Month.ToString();
                        txtCYear.Text = dtChequeDate.Year.ToString();

                        txtNameOnAccount.Text = Item.NameOnAccount;
                        txtAccountNo.Text = Item.AccountNumber;
                        txtChequeNo.Text = Item.ChequeNo;
                        txtBankName.Text = Item.BankName;
                        txtBranch.Text = Item.BankBranch;

                        #endregion
                    }
                    txtAmount.Text = String.Format("{0:#}", Item.Amount);
                    txtTax.Text = String.Format("{0:#}", Item.Tax);
                    txtNotes.Text = Item.Notes;
                }
            }
            else
            {
                lblTitle.Text = "Add New Voucher";

                DateTime dt;
                dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                txtDay.Text = dt.Day.ToString();
                txtMonth.Text = dt.Month.ToString();
                txtYear.Text = dt.Year.ToString();

                txtCDay.Text = dt.Day.ToString();
                txtCMonth.Text = dt.Month.ToString();
                txtCYear.Text = dt.Year.ToString();

            }
        }
        ddlPaymenttype.Attributes.Add("onchange", "javascript:checkpay();");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("VoucherSearch.aspx");
    }

    protected void LoadPaymentType()
    {
        clsPaymentType obj = new clsPaymentType();
        ddlPaymenttype.DataSource = obj.LoadAll(obj);
        ddlPaymenttype.DataTextField = "Paymenttype";
        ddlPaymenttype.DataValueField = "PaymenttypeId";
        ddlPaymenttype.DataBind();
        ddlPaymenttype.Items.Insert(0, new ListItem("-- Select Payment Type --", ""));
    }

    protected void LoadVoucherType()
    {
        clsVoucherType obj = new clsVoucherType();
        ddlVoucherType.DataSource = obj.LoadAll(obj);
        ddlVoucherType.DataTextField = "VoucherType";
        ddlVoucherType.DataValueField = "VoucherTypeId";
        ddlVoucherType.DataBind();
        ddlVoucherType.Items.Insert(0, new ListItem("-- Select Voucher Type --", ""));
    }

    protected void LoadCompany()
    {
        clsCompany obj = new clsCompany();
        ddlCompany.DataSource = obj.LoadAll(obj);
        ddlCompany.DataTextField = "Company";
        ddlCompany.DataValueField = "CompanyId";
        ddlCompany.DataBind();
        ddlCompany.Items.Insert(0, new ListItem("-- Select Company --", ""));
    }

    protected void LoadVendor()
    {
        clsVendor obj = new clsVendor();

        ddlVendor.DataSource = obj.LoadAll(obj);
        ddlVendor.DataTextField = "Vendor";
        ddlVendor.DataValueField = "VendorId";
        ddlVendor.DataBind();
        ddlVendor.Items.Insert(0, new ListItem("-- Select Vendor --", ""));
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.VoucherId = ItemId;
        }

        if (txtDay.Text.Length > 0 && txtMonth.Text.Length > 0 && txtYear.Text.Length > 0)
        {
            int day = Convert.ToInt16(txtDay.Text);
            int month = Convert.ToInt16(txtMonth.Text);
            int year = Convert.ToInt16(txtYear.Text);
            DateTime dt = new DateTime(year, month, day);
            Item.VoucherDate = dt;
        }
        Item.Voucher = txtVoucher.Text;
        Item.VoucherTypeId = Convert.ToInt32(ddlVoucherType.SelectedValue);
        Item.PaymentTypeId = Convert.ToInt32(ddlPaymenttype.SelectedValue);
        Item.VendorId = Convert.ToInt32(ddlVendor.SelectedValue);
        Item.CompanyId = Convert.ToInt32(ddlCompany.SelectedValue);
        Item.Amount = Convert.ToDecimal(txtAmount.Text);
        Item.Tax = Convert.ToDecimal(txtTax.Text);
        Item.Total = Convert.ToDecimal(Convert.ToDecimal(txtAmount.Text) +Convert.ToDecimal(txtTax.Text));
        Item.Notes = txtNotes.Text;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.IsActive = true;
        Item.IsDeleted = false;

        if (ddlPaymenttype.SelectedValue == "2")
        {
            if (txtCDay.Text.Length > 0 && txtCMonth.Text.Length > 0 && txtCYear.Text.Length > 0)
            {
                int day = Convert.ToInt16(txtCDay.Text);
                int month = Convert.ToInt16(txtCMonth.Text);
                int year = Convert.ToInt16(txtCYear.Text);
                DateTime dt = new DateTime(year, month, day);
                Item.ChequeDate = dt;
            }
            Item.NameOnAccount = txtNameOnAccount.Text;
            Item.AccountNumber = txtAccountNo.Text;
            Item.ChequeNo = txtChequeNo.Text;
            Item.BankName = txtBankName.Text;
            Item.BankBranch = txtBranch.Text;
        }

        string receipId = Convert.ToString(Item.AddUpdate(Item));

        if (ddlPaymenttype.SelectedValue == "1")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "document.getElementById('divCheque').style.display = ''", true);
        }
        Response.Redirect("VoucherSearch.aspx");
    }

}