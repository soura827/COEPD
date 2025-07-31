using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Collections.Specialized;
using CCA.Util;
public partial class ccavResponseHandler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


       //string workingKey = "9BB933D7EB6EE50A319459B8723511A9";
        string workingKey = "CD704861D788AB1F35E610C70E2613FE";//put in the 32bit alpha numeric key in the quotes provided here
        CCACrypto ccaCrypto = new CCACrypto();
        string encResponse = ccaCrypto.Decrypt(Request.Form["encResp"], workingKey);
        NameValueCollection Params = new NameValueCollection();
        string[] segments = encResponse.Split('&');
        foreach (string seg in segments)
        {
            string[] parts = seg.Split('=');
            if (parts.Length > 0)
            {
                string Key = parts[0].Trim();
                string Value = parts[1].Trim();
                Params.Add(Key, Value);
            }
        }
        OrderID.Text = Params.Keys[0];
        OrderIDValue.Text = Params[0];
        TransactionId.Text = Params.Keys[1];
        TransactionValue.Text = Params[1];
        bank_ref_no.Text = Params.Keys[2];
        bank_ref_Value.Text = Params[2];
        OrderStatus.Text = Params.Keys[3];
        OrderStatusValue.Text = Params[3];
        //Failuremessage.Text = Params.Keys[4];
        //FailuremessageValue.Text = Params[4];
        //Paymentmode.Text = Params.Keys[5];
        //PaymentmodeValue.Text = Params[5];
        //CardName.Text = Params.Keys[6];
        //CardNameValue.Text = Params[6];
        //status_code.Text = Params.Keys[7];
        //status_codeValue.Text = Params[7];
        //status_message.Text = Params.Keys[8];
        //status_messageValue.Text = Params[8];
        //currency.Text = Params.Keys[9];
        //currencyValue.Text = Params[9];
        //amount.Text = Params.Keys[10];
        //amountValue.Text = Params[10];
        //billing_name.Text = Params.Keys[11];
        //billing_nameValue.Text = Params[11];
        //billing_address.Text = Params.Keys[12];
        //billing_addressValue.Text = Params[12];
        //billing_city.Text = Params.Keys[13];
        //billing_cityValue.Text = Params[13];
        //billing_state.Text = Params.Keys[14];
        //billing_stateValue.Text = Params[14];
        //billing_zip.Text = Params.Keys[15];
        //billing_zipValue.Text = Params[15];
        //billing_country.Text = Params.Keys[16];
        //billing_countryValue.Text = Params[16];
        //billing_tel.Text = Params.Keys[17];
        //billing_telValue.Text = Params[17];
        //billing_email.Text = Params.Keys[18];
        //billing_emailValue.Text = Params[19];
        //mer_amount.Text = Params.Keys[36];
        //mer_amountValue.Text = Params[36];
        //retry.Text = Params.Keys[38];
        //retryValue.Text = Params[38];
        //response_code.Text = Params.Keys[39];
        //response_Value.Text = Params[39];
        //billing_notes.Text = Params.Keys[40];
        //billing_notesValue.Text = Params[40];
        //trans_date.Text = Params.Keys[41];
        //trans_dateValue.Text = Params[41];
        //bin_country.Text = Params.Keys[42];
        //bin_countryValue.Text = Params[42];

    }
}