using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using BusinessLayer;

public partial class Errors : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["key"] == null)
            {
                Error();
                Session["key"] = 1;
            }
        }
    }

    public void Error()
    {
        string Str = "";
        Str = System.Net.Dns.GetHostName();
        IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(Str);
        IPAddress[] addr = ipEntry.AddressList;
        string ip = addr[1].ToString();
        string MachineName = Application["MachineName"].ToString();
        CurrentUser CurrentUser = new CurrentUser();
        Exception caughtException = (Exception)Application["TheException"];
        Exception InnerException = new Exception();
        if (caughtException.InnerException != null)
        {
            InnerException = caughtException.InnerException;
        }
        string exceptionString = "<b>User Id</b> :  " + CurrentUser.CurrentUsername + "<br><br>" + "<b>Machine Name </b> :  " + MachineName + "<br><br>" + "<b>System Name</b>  :  " + Str.ToString() + "<br><br>" + "<b>IP Address</b>  :  " + ip + "<br><br>" + caughtException.Source + "<br>" + "<html><body><p style = 'color:red' >" + caughtException.Message + "<br>" + "<br>" + InnerException.Message + "</p></ body ></html > " + InnerException.TargetSite + " < br><br>" + caughtException.InnerException + "<br>" + caughtException.HelpLink;
        exceptionString = exceptionString.Replace(" at ", "<br><b> at</b> ");
        string toMail = "developer2@coepd.com";
        string Subject = "Error Occured in coepd.com:" + Convert.ToDateTime(DateTime.UtcNow).AddHours(5).AddMinutes(30);
        string Body = "<u><b>Error Details :-</b></u>" + "<br><br>" + exceptionString;
        Alerts.SendEmail(toMail, Subject, Body);

    }

}