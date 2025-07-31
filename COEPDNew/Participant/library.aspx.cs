using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_library : System.Web.UI.Page
{
    clsEmployeeCMS Item = new clsEmployeeCMS();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = Item.Load(4);
        if (Item != null)
        {
            lblTitle.Text = Item.EmployeeCMSTitle;
            lilcontent.Text = Item.EmployeeCMSContent;
        }
    }
}