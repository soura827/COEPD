using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Confirmation : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsLead Item;
    int ItemId = 0;
    DateTime DateTime;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        clsLeadReceipt Item = new clsLeadReceipt();
        if (!IsPostBack)
        {
            lblTitle.Text = "Lead Fee PayMent ";
            txtPayingAmount.Text = "0";

            BindLead();
          
           
            LoadCompany();
            LoadPaymentType();
            if (ItemId > 0)
            {
                Item = Item.Load(ItemId);
                if (Item != null)
                {

                    lblLocation.Text = Item.Location;

                    lblAgreedAmount.Text = Item.AgreedFee.ToString();
                    lblServiceTaken.Text = Item.ServiceName;
                    lblServiceOwner.Text = Convert.ToString(CurrentUser.CurrentName);
                    lblMobile.Text = Item.PrimaryMobile;

                    ddlParticipant.SelectedValue = Convert.ToString(Item.LeadId);
                    BindData();

                    ddlGSTTypeCompany.SelectedValue = Convert.ToString(Item.GSTTypeCompany);
                    txtComapanyName.Text = Convert.ToString(Item.CompanyName);
                    txtCompanyGSTnumber.Text = Convert.ToString(Item.GSTNumber);
                    txtAddress.Text = Convert.ToString(Item.Address);



                    txtPayingDate.Text = Convert.ToDateTime(Item.PayingDate).ToString("yyyy-MM-dd");


                    txtPayingAmount.Text = Convert.ToString(Item.PayingAmount);
                    txtCompanyGSTnumber.Text = Convert.ToString(Item.FeeAmount);
                    txtGST.Text = Convert.ToString(Item.GST);
                    txtPendingAmount.Text = Convert.ToString(Item.PendingAmount);
                    ddlInputCompany.SelectedValue = Convert.ToString(Item.InputCompany);
                    ddlPaymentGateway.SelectedValue = Convert.ToString(Item.PaymentGateway);
                    txtReferenceNumber.Text = Convert.ToString(Item.ReferenceNumber);
                    txtAccountName.Text = Convert.ToString(Item.AccountName);
                    txtAccountNumber.Text = Convert.ToString(Item.AccountNumber);
                    txtBankName.Text = Convert.ToString(Item.BankName);
                    txtBankBranch.Text = Convert.ToString(Item.BankBranch);
                    txtFeeAmount.Text = Convert.ToString(Item.FeeAmount);




                 



                }
            
            }

        }
    }
    protected void BindLead()
    {
        clsLead obj = new clsLead();
        ddlParticipant.DataSource = obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Lead";
        ddlParticipant.DataValueField = "LeadId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant --", ""));
    }

    protected void BindData()
    {
        clsFeeInstallment obj = new clsFeeInstallment();
        obj.LeadId = Convert.ToInt32(ddlParticipant.SelectedValue);
        gv1.DataSource = obj.LoadAll(obj);
        gv1.DataBind();
    }
    protected void LoadCompany()
    {
        clsCompany obj = new clsCompany();
        ddlInputCompany.DataSource = obj.LoadAll(obj);
        ddlInputCompany.DataTextField = "Company";
        ddlInputCompany.DataValueField = "CompanyId";
        ddlInputCompany.DataBind();
        ddlInputCompany.Items.Insert(0, new ListItem("-- Select Company --", ""));
    }
    protected void LoadPaymentType()
    {
        clsPaymentType obj = new clsPaymentType();
        ddlPaymentGateway.DataSource = obj.LoadAll(obj);
        ddlPaymentGateway.DataTextField = "Paymenttype";
        ddlPaymentGateway.DataValueField = "PaymenttypeId";
        ddlPaymentGateway.DataBind();
        ddlPaymentGateway.Items.Insert(0, new ListItem("-- Select Payment Type --", ""));
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsLeadReceipt Item = new clsLeadReceipt();
        Item.ReceiptId = Convert.ToInt32(ItemId);
        Item.ConfirmationReferenceNo = Convert.ToString(txtConfirmationReferenceNumber.Text);
        Item.ConfirmationBy = CurrentUser.CurrentUserId;
        Item.IsConfirmation =true;

        Item.Update(Item);
        Response.Redirect("ConfirmationSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ConfirmationSearch.aspx");
    }



















}