using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Trainer : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsBestPractices Item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsBestPractices();
        Item = Item.Load(11);
        if (Item != null)
        {

            lblTitle.Text = Convert.ToString(Item.Stream);
            lilcontent.Text = Convert.ToString(Item.Practices);
        }
    }
}