using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Management;

public partial class Admin_ParticipantFeePayReceipt : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsParticipantFeePayReceipt Item;
    int ItemId = 0;
    string CS = ConfigurationManager.ConnectionStrings["cs5"].ConnectionString.ToString();
    string Constr = ConfigurationManager.ConnectionStrings["cs5"].ConnectionString.ToString();

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsParticipantFeePayReceipt();

        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);

        if (!IsPostBack)
        {
            LoadReceiptType();
            LoadLocation();
            LoadCompany();
            LoadPaymentType();
            LoadServices();

            txtPayingAmount.Text = "0";
            txtAgreedFee.Text = "0";
            txtPreviousFee.Text = "0";
            txtPreviousAmountPayingAmount.Text = "0";
            txtPendingFee.Text = "0";

            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Receipt";
                btnSubmit.Text = "Update";
                btnSubmit.Enabled = false;
                txtPayingAmount.Enabled = false;

                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    DateTime dtVoucherDate = Convert.ToDateTime(Item.ReceiptDate);
                    txtDay.Text = dtVoucherDate.Day.ToString();
                    txtMonth.Text = dtVoucherDate.Month.ToString();
                    txtYear.Text = dtVoucherDate.Year.ToString();
                    ddlReceiptType.SelectedValue = Item.ReceiptTypeId.ToString();

                    clsParticipant ItemParticipant = new clsParticipant();
                    clsBatch ItemBatch = new clsBatch();
                    clsLocation ItemLocation = new clsLocation();
                    if (Item.ParticipantId > 0)
                    {
                        ItemParticipant = ItemParticipant.Load(Item.ParticipantId);

                        if (ItemParticipant.BatchId > 0)
                        {
                            ItemBatch = ItemBatch.Load(ItemParticipant.BatchId);

                            if (ItemBatch.LocationId > 0)
                            {
                                ItemLocation = ItemLocation.Load(ItemBatch.LocationId);
                            }
                        }
                    }

                    LoadLocation();

                    ddlLocation.SelectedValue = ItemLocation.LocationId.ToString();
                    LoadBatch();
                    ddlBatch.SelectedValue = ItemBatch.BatchId.ToString();
                    LoadLead();

                    ddlLocation.Enabled = false;
                    ddlBatch.Enabled = false;
                    ddlParticipant.SelectedValue = Item.ParticipantId.ToString();
                    ddlParticipant.Enabled = false;

                    ddlPaymenttype.SelectedValue = Item.PaymentTypeId.ToString();
                    ddlPaymenttype.Enabled = false;
                    ddlCompany.SelectedValue = Item.PaymentRecivingCompanyId.ToString();
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


                    ddlServices.Enabled = false;
                    ddlGSTtype.Enabled = false;



                    ddlReceiptType.SelectedValue = Convert.ToString(Item.ReceiptTypeId);/**/
                    ddlLocation.SelectedValue = Convert.ToString(Item.LocationId);
                   
                    ddlServices.SelectedValue = Convert.ToString(Item.ServiceId);
           
                    ddlPaymenttype.SelectedValue = Convert.ToString(Item.PaymentTypeId);
                    txtReferenceNumber.Text = Item.ReferenceNumber;
                    txtAgreedFee.Text = Convert.ToString(Item.AgreedFee);
                    txtPayingAmount.Text = Convert.ToString(Item.PayingAmount);
                    ddlGSTtype.SelectedValue = Item.GSTtype;
                    txtNotes.Text = Item.Notes;
                    // ddlBatch.SelectedValue = Item.;
                    //txtPayingAmount.Text = String.Format("{0:#}", Item.Amount);
                    //txtGSTtax.Text = String.Format("{0:#}", Item.Tax);
                    LoadGSTtype();

                }
            }
            else
            {
                lblTitle.Text = "Add New Receipt";
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

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantFeePayReceiptSearch.aspx");
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

    protected void LoadReceiptType()
    {
        clsReceiptType obj = new clsReceiptType();
        ddlReceiptType.DataSource = obj.LoadAll(obj);
        ddlReceiptType.DataTextField = "ReceiptType";
        ddlReceiptType.DataValueField = "ReceiptTypeId";
        ddlReceiptType.DataBind();
        ddlReceiptType.Items.Insert(0, new ListItem("-- Select Receipt Type --", ""));
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

    //protected void LoadParticipant()
    //{

    //    ddlParticipant.ClearSelection();
    //    int BatchId = Convert.ToInt32(ddlBatch.SelectedValue);
    //    SqlConnection sqlconn = new SqlConnection(CS);
    //    sqlconn.Open();
    //    SqlCommand con = new SqlCommand("select * from tblParticipant where BatchId =" + BatchId, sqlconn);
    //    con.CommandType = CommandType.Text;
    //    ddlParticipant.DataSource = con.ExecuteReader();
    //    ddlParticipant.DataTextField = "Participant";
    //    ddlParticipant.DataValueField = "ParticipantId";
    //    ddlParticipant.DataBind();
    //    ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant --", "0"));
    //    sqlconn.Close();


    //}
  //  #region
    protected void LoadLead()
    {
        clsLead obj = new clsLead();
        obj.BatchId = Convert.ToInt16(ddlBatch.SelectedValue);
        //ddlParticipant.DataSource = obj.LoadAll(obj).Where(x => x.BatchId == obj.BatchId);
        ddlParticipant.DataSource = obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Lead";
        ddlParticipant.DataValueField = "LeadId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Lead --", ""));
    }
   // #endregion
    protected void LoadLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("- Select Location --", ""));
        ddlBatch.Items.Insert(0, new ListItem("-- Select Batch --", ""));
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Lead --", ""));
    }
    protected void LoadBatch()
    {
        clsBatch obj = new clsBatch();
        obj.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        ddlBatch.DataSource = obj.LoadAll(obj);
        ddlBatch.DataTextField = "Batch";
        ddlBatch.DataValueField = "BatchId";
        ddlBatch.DataBind();
        ddlBatch.Items.Insert(0, new ListItem("- select Batch -", ""));
    }
    protected void LoadServices()
    {
        clsService obj = new clsService();
        ddlServices.DataSource = obj.LoadAll(obj);
        ddlServices.DataTextField = "ServiceName";
        ddlServices.DataValueField = "ServiceId";
        ddlServices.DataBind();
        ddlServices.Items.Insert(0, new ListItem("select Services", ""));
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
            Item.ReceiptId = ItemId;
        if (txtDay.Text.Length > 0 && txtMonth.Text.Length > 0 && txtYear.Text.Length > 0)
        {
            int day = Convert.ToInt16(txtDay.Text);
            int month = Convert.ToInt16(txtMonth.Text);
            int year = Convert.ToInt16(txtYear.Text);
            DateTime dt = new DateTime(year, month, day);
            Item.ReceiptDate = dt;
        }
        Item.ReceiptTypeId = Convert.ToInt32(ddlReceiptType.SelectedValue);
        Item.LeadId = Convert.ToInt32(ddlParticipant.SelectedValue);
        Item.ServiceId = Convert.ToInt32(ddlServices.SelectedValue);
        Item.PaymentRecivingCompanyId = Convert.ToInt32(ddlCompany.SelectedValue);
        Item.PaymentTypeId = Convert.ToInt32(ddlPaymenttype.SelectedValue);
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
           
            Item.ChequeNo = txtChequeNo.Text;
            Item.NameOnAccount = txtNameOnAccount.Text;
            Item.AccountNumber = txtAccountNo.Text;
            Item.BankName = txtBankName.Text;
            Item.BankBranch = txtBranch.Text;
        }
        Item.ReferenceNumber = txtReferenceNumber.Text;
        Item.AgreedFee = Convert.ToDecimal(txtAgreedFee.Text);
        Item.PreviousAmount = Convert.ToDecimal(txtPreviousFee.Text);
        Item.PayingAmount = Convert.ToDecimal(txtPayingAmount.Text);
        Item.GSTtype = ddlGSTtype.SelectedValue;
        Item.WithOutGSTfees = Convert.ToDecimal(txtWithOutGSTfees.Text);   /**/
        Item.GSTtax = Convert.ToDecimal(txtGSTtax.Text);
        Item.PreviousAmountPayingAmountFee = Convert.ToDecimal(txtPreviousAmountPayingAmount.Text);
        Item.PendingAmount = Convert.ToDecimal(txtPendingFee.Text);
        Item.Notes = txtNotes.Text;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);

        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }

        if (ddlPaymenttype.SelectedValue == "1")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "document.getElementById('divCheque').style.display = ''", true);
        }
        
    }

    protected void ddlBatch_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlBatch.SelectedIndex == 0)
        {
            ddlParticipant.SelectedIndex = 0;
            ddlParticipant.Enabled = false;
        }
        else
        {
            ddlParticipant.Enabled = true;
            LoadLead();
        }
    }

    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlLocation.SelectedIndex == 0)
        {
            ddlBatch.SelectedIndex = 0;
            ddlParticipant.SelectedIndex = 0;
            ddlBatch.Enabled = false;
            ddlParticipant.Enabled = false;
        }
        else
        {
            ddlBatch.Enabled = true;
            LoadBatch();
            ddlParticipant.Enabled = false;
        }
    }




    protected void ddlPaymenttype_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlPaymenttype.SelectedIndex == 1)
        {
            divCheque.Visible = false;
            divReferenceNumber.Visible = false;
        }
        else if (ddlPaymenttype.SelectedIndex == 2)
        {
            divCheque.Visible = true;
            divReferenceNumber.Visible = false;
        }
        else
        {
            divCheque.Visible = false;
            divReferenceNumber.Visible = true;
        }

    }
    protected void LoadGSTtype()
    {
        switch (ddlGSTtype.SelectedIndex)
        {
            case 0:
                divFees.Visible = false;
                divTax.Visible = false;
                txtWithOutGSTfees.Text = "";
                txtGSTtax.Text = "";
                break;
            case 1:
                divFees.Visible = true;
                divTax.Visible = true;
                break;
            case 2:
                divFees.Visible = false;
                divTax.Visible = false;
                txtWithOutGSTfees.Text = "";
                txtGSTtax.Text = "";
                break;
        }

        if (ddlGSTtype.SelectedIndex == 1 && txtPayingAmount != null)
        {
            Decimal Amount = Convert.ToDecimal(txtPayingAmount.Text);
            Decimal GST = Math.Ceiling(Convert.ToDecimal(0.18) * Amount);
            txtGSTtax.Text = GST.ToString();

            Decimal Fees = Math.Floor(Amount - GST);
            txtWithOutGSTfees.Text = Fees.ToString();

            //lblAmount.Text = Item.Amount.ToString("N0");

            Decimal PreviousFee = Convert.ToDecimal(txtPreviousFee.Text);
            Decimal PayingAmount = Convert.ToDecimal(txtPayingAmount.Text);
            Decimal PreviousAmountPayingAmount = (PreviousFee + PayingAmount);

            txtPreviousAmountPayingAmount.Text = Convert.ToString(PreviousAmountPayingAmount);

            Decimal AgreedFee = Convert.ToDecimal(txtAgreedFee.Text);
            Decimal PendingFee = (AgreedFee - PreviousAmountPayingAmount);
            txtPendingFee.Text = Convert.ToString(PendingFee);

        }

    }

    protected void ddlGSTtype_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadGSTtype();
    }

    protected void ddlParticipant_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        SqlConnection sqlcon = new SqlConnection(Constr);
        String pname = "ParticipantFeePayReceipt_PreviousAmount"; ;
        sqlcon.Open();
        SqlCommand com = new SqlCommand(pname, sqlcon);
        com.CommandType = CommandType.StoredProcedure;
        com.Parameters.AddWithValue("@LeadId", Convert.ToInt32(ddlParticipant.SelectedValue));
        SqlDataReader dr;
        dr = com.ExecuteReader();
        if (dr.Read())
        {

            txtPreviousFee.Text = dr["PreviousAmount"].ToString();
            if (txtPreviousFee.Text == "")
                txtPreviousFee.Text = "0";


        }
        sqlcon.Close();
    }

}