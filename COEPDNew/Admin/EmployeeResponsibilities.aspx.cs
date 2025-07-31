using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class EmployeeResponsibilities : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsEmployee Item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsEmployee();
        Item = Item.Load(CurrentUser.CurrentEmployeeId);
        if (Item != null)
        {
            lblTitle.Text = "Employee Responsibilities";
            lilcontent.Text = Convert.ToString(Item.Roles);
        }
    }
}