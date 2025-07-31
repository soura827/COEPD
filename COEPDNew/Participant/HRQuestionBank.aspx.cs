using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_HRQuestionBank : System.Web.UI.Page
{
    clsEmployeeCMS Item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsEmployeeCMS();
        Item = Item.Load(5);
        if(Item !=null)
        {
            lblTitle.Text = Item.EmployeeCMSTitle;
            ltlContent.Text = Item.EmployeeCMSContent;
        }

    }
}