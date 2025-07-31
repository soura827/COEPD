using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Collections.Generic;
using BusinessLayer;

public partial class ReceiptPay : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsReceipt Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsReceipt();

        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);

        if (!IsPostBack)
        {
            LoadLead();
            LoadPaymentType();

            if (ItemId > 0)
            {
                lblTitle.Text = "Add New Receipt";

                ddlLead.SelectedValue = ItemId.ToString();
                ddlLead.Enabled = false;
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
        Response.Redirect("LeadRegisteredSearch.aspx");
    }

    protected void LoadLead()
    {
        clsLead obj = new clsLead();
        obj.LeadStatusId = 3;
        ddlLead.DataSource = obj.LoadAll(obj);
        ddlLead.DataTextField = "Lead";
        ddlLead.DataValueField = "LeadId";
        ddlLead.DataBind();
        ddlLead.Items.Insert(0, new ListItem("- select -", ""));
    }

    protected void LoadPaymentType()
    {
        clsPaymentType obj = new clsPaymentType();
        ddlPaymenttype.DataSource = obj.LoadAll(obj);
        ddlPaymenttype.DataTextField = "Paymenttype";
        ddlPaymenttype.DataValueField = "PaymenttypeId";
        ddlPaymenttype.DataBind();
        ddlPaymenttype.Items.Insert(0, new ListItem("- select -", ""));
    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReceiptPay.aspx?ItemId=" + ItemId);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtDay.Text.Length > 0 && txtMonth.Text.Length > 0 && txtYear.Text.Length > 0)
        {
            int day = Convert.ToInt16(txtDay.Text);
            int month = Convert.ToInt16(txtMonth.Text);
            int year = Convert.ToInt16(txtYear.Text);
            DateTime dt = new DateTime(year, month, day);
            Item.ReceiptDate = dt;
        }

       // Item.LeadId = Convert.ToInt16(ddlLead.SelectedValue);
        Item.PaymentTypeId = Convert.ToInt32(ddlPaymenttype.SelectedValue);
        Item.Amount = Convert.ToDecimal(txtAmount.Text);
        // Item.Remarks = txtNotes.Text;
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
            //   Item.AccountNo = txtAccountNo.Text;
            Item.ChequeNo = txtChequeNo.Text;
            Item.BankName = txtBankName.Text;
            Item.BankBranch = txtBranch.Text;
        }

        string receipId = Convert.ToString(Item.AddUpdate(Item));

        if (ddlPaymenttype.SelectedValue == "2")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "document.getElementById('divCheque').style.display = ''", true);
        }

        btnSubmit.Enabled = false;
        FormMessage.Text = "Item successfully saved";
        FormMessage.Visible = true;
    }

}
