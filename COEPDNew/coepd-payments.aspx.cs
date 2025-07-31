using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class coepd_payments : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPayNow_Click(object sender, EventArgs e)
    {
        if(RButton.SelectedIndex==0)
            //Response.Redirect("https://rzp.io/l/OeCyAwx2oI");
        Response.Redirect("https://rzp.io/l/F5zirBSU6");
        else if(RButton.SelectedIndex==1)
            Response.Redirect("Payment.aspx");
        else
            Response.Redirect("http://coepd.net/");
    }
}