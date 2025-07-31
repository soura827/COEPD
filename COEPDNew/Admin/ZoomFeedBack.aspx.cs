using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ZoomFeedBack : System.Web.UI.Page
{

    CurrentUser CurrentUser = new CurrentUser();
    clsZoomMeetingAttendance Item = new clsZoomMeetingAttendance();
    int ItemId = 0;
    int CountNo = 0;
   
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)

        {
            if (ItemId > 0)
            {

             
                if (Item != null)
                {

                    
                   txtFeedBack.Text = Convert.ToString(Item.Feedback);


                }

            }
            else
            {
                lblTitle.Text = " FeedBack Form ";
            }

        }

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.ZoomMeetingAttendanceId = Convert.ToInt32(ItemId);
        }
        Item.ZoomMeetingId = ItemId;
        //clsZoomMeeting Items= new clsZoomMeeting();
        //Item.ZoomMeetingAttendedOn = DateTime.Now;
        Item.Feedback = txtFeedBack.Text;
        Item.FeedbackAddedOn = DateTime.UtcNow;
        Item.IsFeedbackAdded= true;
        Item.ZoomMeetingEndedOn=DateTime.Now;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
       
        txtFeedBack.Text = "";
        btnSave.Enabled = false;

        if (ItemId > 0)
       
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ZoomMeetingSearch.aspx");
    }

   
}
