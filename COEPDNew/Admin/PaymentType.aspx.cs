using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class PaymentType : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsPaymentType Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsPaymentType();
        if (!IsPostBack)
        {

            if (ItemId > 0)
            {

                lblTitle.Text = "Edit PaymentType";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtPaymentType.Text = Item.PaymentType;
                }
            }
            else
            {
                lblTitle.Text = "Add PaymentType";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (ItemId > 0)
        {
            Item.PaymentTypeId = Convert.ToInt16(ItemId);
        }

        Item.PaymentType = Convert.ToString(txtPaymentType.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId; 
        Item.AddUpdate(Item);
        Response.Redirect("PaymentTypeSearch.aspx");

    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentTypeSearch.aspx");
    }
}