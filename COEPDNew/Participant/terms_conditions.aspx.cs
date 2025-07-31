using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class terms_conditions : System.Web.UI.Page
{
    clsEmployeeCMS Item;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsEmployeeCMS();
        Item = Item.Load(3);
        if (Item != null)
        {
            lblTitle.Text = Convert.ToString(Item.EmployeeCMSTitle);
            lilcontent.Text = Convert.ToString(Item.EmployeeCMSContent);
        }
       
    }
}