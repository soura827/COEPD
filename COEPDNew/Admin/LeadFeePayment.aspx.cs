using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_LeadFeePayment : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsLead Item;
    int ItemId = 0;
    DateTime DateTime;

    int LeadId = 0;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {


        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        clsParticipantFeeMapping Item = new clsParticipantFeeMapping();




        if (!IsPostBack)
        {
            lblTitle.Text = "Lead Fee Payment ";
            txtPayingAmount.Text = "0";
            ddlParticipant.Enabled = false;

            BindLead();
            BindLocation();
            BindServices();
           
            LoadCompany();
            LoadPaymentType();
            if (ItemId > 0)
            {
                Item = Item.LoadLead(ItemId);
                if (Item != null)
                {
                    ddlParticipant.SelectedValue = Convert.ToString(Item.LeadId);
                    BindData();
                    LeadId = Convert.ToInt32(ddlParticipant.SelectedValue);
                    lblAgreedAmount.Text = Convert.ToString(Item.AgreedFee);
                    ddlServices.SelectedValue = Convert.ToString(Item.ServiceId);
                    ddlServices.Enabled = false;

                    lblServiceOwner.Text = Convert.ToString(Item.Fullname);
                    ddlLocation.SelectedValue = Convert.ToString(Item.LocationId);
                    ddlLocation.Enabled = false;
                    lblMobile.Text = Convert.ToString(Item.PrimaryMobile);
                }
            }

        }

    }




    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("-- Select Location -- ", ""));
    }




    protected void BindServices()
    {
        clsService obj = new clsService();
        ddlServices.DataSource = obj.LoadAll(obj);
        ddlServices.DataTextField = "ServiceName";
        ddlServices.DataValueField = "ServiceId";
        ddlServices.DataBind();
        ddlServices.Items.Insert(0, new ListItem("-- Select Services -- ", ""));
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


        gv1.DataSource = obj.LoadFeeAll(obj);
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
        Item.LeadId = Convert.ToInt32(ddlParticipant.SelectedValue);

        Item.GSTTypeCompany = Convert.ToInt32(ddlGSTTypeCompany.SelectedValue);
        Item.CompanyName = Convert.ToString(txtComapanyName.Text);
        Item.GSTNumber = Convert.ToString(txtCompanyGSTnumber.Text);
        Item.Address = Convert.ToString(txtAddress.Text);


        Item.PayingDate = Convert.ToDateTime(txtPayingDate.Text);
        Item.PayingAmount = Convert.ToInt32(txtPayingAmount.Text);


        Item.FeeAmount = Convert.ToDecimal(txtFeeAmount.Text);
        Item.GST = Convert.ToDecimal(txtGST.Text);


        Item.PendingAmount = Convert.ToDecimal(txtPendingAmount.Text);


        Item.InputCompany = Convert.ToInt32(ddlInputCompany.SelectedValue);
        Item.PaymentGateway = Convert.ToInt32(ddlPaymentGateway.SelectedValue);

        if (ddlPaymentGateway.SelectedValue == "2")
        {
            Item.ReferenceNumber = Convert.ToString(txtReferenceNumber.Text);
            Item.AccountName = Convert.ToString(txtAccountName.Text);
            Item.AccountNumber = Convert.ToString(txtAccountNumber.Text);
            Item.BankName = Convert.ToString(txtBankName.Text);
            Item.BankBranch = Convert.ToString(txtBankBranch.Text);
        }

        Item.ReferenceNumber = Convert.ToString(txtReferenceNumber.Text);

        Item.CreatedBy = CurrentUser.CurrentUserId;





        Item.AddUpdate(Item);

        btnSubmit.Enabled = false;

        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }

        if (ddlPaymentGateway.SelectedValue == "1")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "document.getElementById('divCheque').style.display = ''", true);
        }


    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("InstallmentFollowUp.aspx");
    }


    protected void ddlPaymentGateway_TextChanged(object sender, EventArgs e)
    {
        if (ddlPaymentGateway.SelectedValue == "2")
        {
            divReferenceNumber.Visible = true;
        }
        else
        {
            divReferenceNumber.Visible = false;
        }


    }

    protected void ddlGSTTypeCompany_TextChanged(object sender, EventArgs e)
    {
        int companytype = Convert.ToInt32(ddlGSTTypeCompany.SelectedValue);
        switch (companytype)
        {
            case 0:
                divCompanyGst.Visible = false;
                break;
            case 1:
                divCompanyGst.Visible = true;
                break;
            case 2:
                divCompanyGst.Visible = false;
                break;
        }

    }



    protected void txtPayingAmount_TextChanged(object sender, EventArgs e)
    {
        if (decimal.TryParse(txtPayingAmount.Text, out decimal itemPrice))
        {
            decimal gstRate = 0.18m; // Assuming GST rate is 18%
            decimal gstAmount = itemPrice * gstRate;

            txtGST.Text = gstAmount.ToString("0.00");
            decimal payingamount = Convert.ToDecimal(txtPayingAmount.Text);
            decimal GStamount = Convert.ToDecimal(txtGST.Text);
            decimal feeamount = payingamount - GStamount;
            txtFeeAmount.Text = feeamount.ToString("0.00");

        }
        else
        {
            txtGST.Text = "Invalid item price";
        }
    }




    protected void txtParticipant_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
}
