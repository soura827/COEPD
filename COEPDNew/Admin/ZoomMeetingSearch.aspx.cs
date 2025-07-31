using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_ZoomMeetingSearch : System.Web.UI.Page
{
    int Total = 0;
    string strFeedBack = string.Empty;

    CurrentUser CurrentUser = new CurrentUser();
    
    // clsZoomMeeting Item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
            BindCategory();
        }
    }
    protected void BindCategory()
    {
        clsZoomCategory obj = new clsZoomCategory();
        ddlZoommeetingCategory.DataSource = obj.LoadAll(obj);
        ddlZoommeetingCategory.DataTextField = "ZoomMeetingCategory";
        ddlZoommeetingCategory.DataValueField = "ZoomMeetingCategoryId";
        ddlZoommeetingCategory.DataBind();
        ddlZoommeetingCategory.Items.Insert(0, new ListItem("-- Select Catagory --", ""));
    }

    protected void BindData()
    {
        clsZoomMeeting Item = new clsZoomMeeting();
        if (txtEmployee.Text != "")
            Item.Employee = Convert.ToString(txtEmployee.Text);
        if (ddlZoommeetingCategory.Text != "")
            Item.ZoomMeetingCategory = Convert.ToString(ddlZoommeetingCategory.Text);

        List<clsZoomMeeting> items = Item.LoadAll(Item);
        if (items != null)
        {
            Total = items.Count;

        }
        gv.DataSource = Item.LoadAll(Item);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("ZoomMeeting.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdAttend")
        {
            int ItemId = Convert.ToInt32(e.CommandArgument);
            clsZoomMeetingAttendance Item = new clsZoomMeetingAttendance();
            Item.ZoomMeetingId = ItemId;
            Item.UserId = CurrentUser.CurrentUserId;

            Item.IsZoomMeetingAttended = true;
            // string time = DateTime.Now.ToLongTimeString();
            TimeZone zone = TimeZone.CurrentTimeZone;
            DateTime Date = zone.ToUniversalTime(DateTime.Now);
            Item.ZoomMeetingAttendedOn = Date;
            Item.ZoomMeetingEndedOn = null;
            Item.IsZoomMeetingEnded = false;
            Item.Feedback = "";
            Item.IsFeedbackAdded = false;
            Item.FeedbackAddedOn = Date;
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.AddUpdate(Item);
            Response.Redirect("ZoomMeetingAttendanceSearch.aspx");

        }
        else if (e.CommandName == "cmdEnded")
        {
            int ItemId = Convert.ToInt32(e.CommandArgument);
            clsZoomMeetingAttendance Item = new clsZoomMeetingAttendance();
            clsZoomMeeting Items = new clsZoomMeeting();  
            Items.ZoomMeetingId = ItemId;
            Item.ZoomMeetingAttendanceId= ItemId;
            Item.IsZoomMeetingAttended = true;
            TimeZone zone = TimeZone.CurrentTimeZone;
            DateTime Date = zone.ToUniversalTime(DateTime.Now);
            Item.ZoomMeetingAttendedOn = Date;
            Item.ZoomMeetingEndedOn = Date;
            Item.IsZoomMeetingEnded = true;
            Item.Feedback = "";
            Item.IsFeedbackAdded = false;
            Item.FeedbackAddedOn = null;
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.AddUpdate(Item);
            //Response.Redirect("ZoomMeetingAttendanceSearch.aspx");
           

        }
        else if (e.CommandName == "cmdFeedBack")
        {
            Response.Redirect("ZoomFeedBack.aspx");

        }
        //string strMessage = string.Empty;
        //clsZoomMeetingAttendance Item=new clsZoomMeetingAttendance();
        //int ItemId = Convert.ToInt32(e.CommandArgument);

        //if (Items != null)
        //{
        //    foreach (clsZoomMeetingAttendance item in Items)
        //    {

        //        strFeedBack = strFeedBack + "<ul>" + "<li>" + "&nbsp;" + "<b>" + item.Feedback + "</b>" + " FeedBack " + "<b>"  + " For his/her committment and dedicated efforts for the Month of " + "<b>" + item.FeedbackAddedOn.ToString() + "</b>" + ". </li>";

        //        strFeedBack = strFeedBack + "</ul>";
        //    }

        //    strFeedBack = strFeedBack.Replace("<p>", "");
        //    strFeedBack = strFeedBack.Replace("</p>", "");
        //    strMessage = strFeedBack;
        //    Item = Item.Load(Convert.ToString(ItemId));
        // }

      
    }
    protected void gv_PreRender(object sender, EventArgs e)
    {
        
        BindData();
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        int TotalRecords = 0;
        string Records = "";
        TotalRecords = (gv.PageSize * (gv.PageIndex + 1));
        if (TotalRecords > Total)
            Records = Total.ToString();
        else
            Records = TotalRecords.ToString();

        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }

    protected void txtEmployee_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtZoomCategoryName_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ZoomMeeting.aspx");
    }
    protected void ddlZoommeetingCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindCategory();
    }
}