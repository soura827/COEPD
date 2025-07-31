using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ReceiptPrints : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsReceipt Item;
    int ItemId = 0;
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsReceipt();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    lblDate.Text = Item.ReceiptDate.Value.ToString("dd MMM yyyy");
                    lblCreatedOn.Text = Item.ReceiptDate.Value.ToString("dd MMM yyyy");
                    lblNumber.Text = Item.ReceiptId.ToString();
                    lblName.Text = Item.Participant;
                    lblAmount.Text = Item.Amount.ToString("N0");
                    lblEmployee.Text = Item.Fullname.ToString();
                    lblAmountInWords.Text = ((ConvertNumbertoWords(Convert.ToInt32(Item.Amount))) + " Rupees Only ");
                    lblLocation.Text = Convert.ToString(Item.Location);
                    lblCheque.Text = Item.PaymentType.ToString();
                    if (lblCheque.Text == "APTIT Razorpay")
                    {
                        TopCoepdImage.Visible = false;
                        TopAptitImage.Visible = true;
                        imgCoepdbottem.Visible = false;
                        imgAptitbottem.Visible = true;
                        imgCoepdstamp.Visible = false;
                        imgAptitstamp.Visible = true;
                    }

                }
            }

        }
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReceiptSearch.aspx");
    }

    public static string ConvertNumbertoWords(int number)
    {
        if (number == 0)
            return "ZERO";
        if (number < 0)
            return "minus " + ConvertNumbertoWords(Math.Abs(number));
        string words = "";
        if ((number / 1000000) > 0)
        {
            words += ConvertNumbertoWords(number / 1000000) + " Million ";
            number %= 1000000;
        }
        if ((number / 1000) > 0)
        {
            words += ConvertNumbertoWords(number / 1000) + " Thousand ";
            number %= 1000;
        }
        if ((number / 100) > 0)
        {
            words += ConvertNumbertoWords(number / 100) + " Hundred ";
            number %= 100;
        }
        if (number > 0)
        {
            if (words != "")
                words += "AND ";
            var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += " " + unitsMap[number % 10];
            }
        }
        return words;
    }

}