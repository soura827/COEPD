using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Logout : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsEmployeeLogInLogOutReport Item;
    int ItemId = 0;
    int EmployeeId = 0;
    string LogoutIPAddress = string.Empty;
    DateTime Date = DateTime.UtcNow.AddHours(5).AddMinutes(30);
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        LogoutIPAddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        if (string.IsNullOrEmpty(LogoutIPAddress))
            LogoutIPAddress = Request.ServerVariables["REMOTE_ADDR"];
       EmployeeId = CurrentUser.CurrentEmployeeId;

        if(EmployeeId >0)
        {
            clsEmployeeLogInLogOutReport obj = new clsEmployeeLogInLogOutReport();
            obj.Date = Date;
            obj.EmployeeId = EmployeeId;
            Item = new clsEmployeeLogInLogOutReport();
            Item = Item.Load(obj);
            ItemId = Convert.ToInt32(Item.EmployeeLogInLogOutReportId);
            if (ItemId > 0)
                Item.EmployeeLogInLogOutReportId = Convert.ToInt32(ItemId);
            Item.EndTime = Convert.ToDateTime(Date);
            Item.LogoutIPAddress = LogoutIPAddress;
            Item.CreatedBy = CurrentUser.CurrentEmployeeId;
            Item.AddUpdate(Item);
            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
        else
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
        
    }
}
