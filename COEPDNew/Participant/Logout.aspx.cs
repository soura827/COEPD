using System;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Logout : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsNormalParticipantTimeSheet Item;
    int ItemId = 0;
    int participantid = 0;
    int TimeSheetId = 0;
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
        participantid = CurrentUser.CurrentParticipantId;
        if (participantid > 0)
        {
            clsNormalParticipantTimeSheet obj = new clsNormalParticipantTimeSheet();
            obj.Date= Date;
            obj.ParticipantId = participantid;
            obj.EndTime= Convert.ToDateTime(Date);
            
            Item = new clsNormalParticipantTimeSheet();
            Item = Item.LoadTimeSheet(obj);
            ItemId = Convert.ToInt32(Item.TimeSheetId);
            if (ItemId > 0)
            Item.TimeSheetId = Convert.ToInt32(ItemId);
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
