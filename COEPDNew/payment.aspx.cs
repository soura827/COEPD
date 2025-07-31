using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Text;
using System.Collections;
using System.Web.UI.HtmlControls;

public partial class Payment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPayment_Click(object sender, EventArgs e)
    {
        //string secret_key = "118589ce04746264c3211fe2f88f799d3308ffdf";

        //string secret_key = "9BB933D7EB6EE50A319459B8723511A9";
        string secret_key = "CD704861D788AB1F35E610C70E2613FE";

        string OidPrefix = "coepd_";
        string TidPrefix = "Txn_";
        string merchantTxnId = (Convert.ToInt64(DateTime.Now.Millisecond) + 1).ToString();
        string orderAmount = "1";
        orderAmount = txtAmount.Text;
        string currency = "";
        if (ddlCurrency.SelectedItem.Text == "INR")
        {
             currency = "INR";
        }
        else
        {
             currency = "USD";
        }
        //string currency = "INR";

        string data = OidPrefix + orderAmount + merchantTxnId + currency;

        string OID = OidPrefix + (Convert.ToInt64(DateTime.Now.Millisecond) + 1).ToString();
        string TID = TidPrefix + (Convert.ToInt64(DateTime.Now.Millisecond) + 1).ToString();

        System.Security.Cryptography.HMACSHA1 myhmacsha1 = new System.Security.Cryptography.HMACSHA1(Encoding.ASCII.GetBytes(secret_key));
        System.IO.MemoryStream stream = new System.IO.MemoryStream(Encoding.ASCII.GetBytes(data));
        string securitySignature = BitConverter.ToString(myhmacsha1.ComputeHash(stream)).Replace("-", "").ToLower();

        // string Url = "https://sandbox.citruspay.com/o1ybozr3hp";
        string Url = "ccavRequestHandler.aspx";

        string formId = "customerData";

        StringBuilder htmlForm = new StringBuilder();
        htmlForm.AppendLine("<html>");
        htmlForm.AppendLine(String.Format("<body onload='document.forms[\"{0}\"].submit()'>", formId));
        htmlForm.AppendLine(String.Format("<form id='{0}' method='POST' action='{1}'>", formId, Url));
        htmlForm.AppendLine("<input type='hidden' name='txnid' value='" + TID + "'/>");
        if (ddlCurrency.SelectedItem.Text == "INR")
        {
            htmlForm.AppendLine("<input type='hidden' name='currency' value='INR'/>");
        }
        else
        {
            htmlForm.AppendLine("<input type='hidden' name='currency' value='USD'/>");
        }
        //htmlForm.AppendLine("<input type='hidden' name='currency' value='INR'/>");
        htmlForm.AppendLine("<input type='hidden' name='merchant_id' id='merchant_id' value='140004'/>");
        htmlForm.AppendLine("<input type='hidden' name='order_id' value='" + OID + "'/>");
        htmlForm.AppendLine("<input type='hidden' name='amount' value='" + txtAmount.Text + "'/>");
        htmlForm.AppendLine("<input type='hidden' name='redirect_url' value='https://www.coepd.com/ccavResponseHandler.aspx'/>");
        htmlForm.AppendLine("<input type='hidden' name='cancel_url' value='https://www.coepd.com/ccavResponseHandler.aspx'/>");
        htmlForm.AppendLine("<input type='hidden' name='billing_name' value='" + txtName.Text + "'/>");
        htmlForm.AppendLine("<input type='hidden' name='billing_address' value='" + txtAddress.Text + "'/>");
        htmlForm.AppendLine("<input type='hidden' name='billing_tel' value='" + txtMobile.Text + "'/>");
        htmlForm.AppendLine("<input type='hidden' name='billing_email' value='" + txtEmail.Text + "'/>");
        htmlForm.AppendLine("</form>");
        htmlForm.AppendLine("</body>");
        htmlForm.AppendLine("</html>");
        HttpContext.Current.Response.Clear();
        HttpContext.Current.Response.Write(htmlForm.ToString());
        HttpContext.Current.Response.End();
    }

    protected void ddlCurrency_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblamount.Text = ddlCurrency.SelectedItem.Text;
        if (ddlCurrency.SelectedItem.Text == "USD")
        {
            divmsg.Visible = true;
        }
        else
        {
            divmsg.Visible = false;
        }
    }
}
