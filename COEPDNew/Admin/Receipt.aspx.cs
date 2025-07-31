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
using System.Data.SqlClient;

public partial class Receipt : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsReceipt Item;
    int ItemId = 0;
    string CS = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
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
            LoadReceiptType();
            LoadLocation();
            LoadCompany();
            LoadPaymentType();
           

            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Receipt";
                Item = Item.Load(ItemId);


                btnSubmit.Enabled = false;/**/
                txtAmount.Enabled = false;/**/


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
                    LoadParticipant();

                    ddlLocation.Enabled = false;
                    ddlBatch.Enabled = false;
                    ddlParticipant.SelectedValue = Item.ParticipantId.ToString();
                    ddlParticipant.Enabled = false;

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
        ddlPaymenttype.Attributes.Add("onchange", "javascript:checkpay();");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReceiptSearch.aspx");
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


    protected void LoadParticipant()
    {

        ddlParticipant.ClearSelection();
        int BatchId = Convert.ToInt32(ddlBatch.SelectedValue);
        SqlConnection sqlconn = new SqlConnection(CS);
        sqlconn.Open();
        SqlCommand con = new SqlCommand("select * from [dbo].[tblParticipant] where BatchId =" + BatchId, sqlconn);
        con.CommandType = CommandType.Text;
        ddlParticipant.DataSource = con.ExecuteReader();
        ddlParticipant.DataTextField = "Participant";
        ddlParticipant.DataValueField = "ParticipantId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant --", "0"));
        sqlconn.Close();
    }



    //protected void LoadParticipant()
    //{
    //    clsParticipant obj = new clsParticipant();
    //    obj.BatchId = Convert.ToInt16(ddlBatch.SelectedValue);
    //    //ddlParticipant.DataSource = obj.LoadAll(obj).Where(x => x.BatchId == obj.BatchId);
    //    ddlParticipant.DataSource = obj.LoadAll(obj);
    //    ddlParticipant.DataTextField = "Participant";
    //    ddlParticipant.DataValueField = "ParticipantId";
    //    ddlParticipant.DataBind();
    //    ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant --", ""));
    //}

    protected void LoadLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("- Select Location --", ""));
        ddlBatch.Items.Insert(0, new ListItem("-- Select Batch --", ""));
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant --", ""));
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

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.ReceiptId = ItemId;
        }

        if (txtDay.Text.Length > 0 && txtMonth.Text.Length > 0 && txtYear.Text.Length > 0)
        {
            int day = Convert.ToInt16(txtDay.Text);
            int month = Convert.ToInt16(txtMonth.Text);
            int year = Convert.ToInt16(txtYear.Text);
            DateTime dt = new DateTime(year, month, day);
            Item.ReceiptDate = dt;
        }

        Item.PaymentTypeId = Convert.ToInt32(ddlPaymenttype.SelectedValue);
        Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
        Item.ReceiptTypeId = Convert.ToInt32(ddlReceiptType.SelectedValue);
        Item.CompanyId = Convert.ToInt32(ddlCompany.SelectedValue);
        Item.Amount = Convert.ToDecimal(txtAmount.Text);
        Item.Tax = Convert.ToDecimal(txtTax.Text);
        Item.Total = Convert.ToDecimal(Convert.ToDecimal(txtTax.Text) + Convert.ToDecimal(txtAmount.Text));
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
        Response.Redirect("ReceiptSearch.aspx");
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
            LoadParticipant();
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
}
