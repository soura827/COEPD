using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class HolidayList : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    //clsEmployeeCMS Item;
    clsBranchHolidays Item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //Item = new clsEmployeeCMS();
        //Item = Item.Load(2);
        //if (Item != null)
        //{

        //    lblTitle.Text = Convert.ToString(Item.EmployeeCMSTitle);
        //    lilcontent.Text = Convert.ToString(Item.EmployeeCMSContent);
        //}
        CurrentUser cu = new CurrentUser();
        Int32 CurrentUserBrachID = CurrentUser.UserBranchId;

        Item = new clsBranchHolidays();
        Item = Item.Load_By_Branch(CurrentUserBrachID);

        if (Item != null)
        {
            lblTitle.Text = Convert.ToString(Item.BranchHolidaysTitle);
            lilcontent.Text = Convert.ToString(Item.BranchHolidaysContent);
        }
    }
}