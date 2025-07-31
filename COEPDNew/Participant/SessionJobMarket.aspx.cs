using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Participant_SessionJobMarket : System.Web.UI.Page
{
    int itemId = 0, CountNo = 0, ItemId = 0;
    int Total = 0;
    int SessionId = 0;
    DateTime DateTime;
    CurrentUser CurrentUser = new CurrentUser();
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs9"].ConnectionString.ToString());
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            BindData();
        }

        RestoreDropdownSelections();

    }
    protected void BindData()
    {
        clsSession obj = new clsSession();
        if (ddlSession.SelectedValue == "")
        {
            // obj.SessionTypeId = Convert.ToInt32(ddlSession.SelectedValue);
            obj.SessionTypeId = 4;

        }
        List<clsSession> objList = obj.LoadAllJobMarket(obj);





        if (objList != null)
        {

            for (int i = 0; i < objList.Count; i++)
            {
                if (objList[i].AttendId == 0)
                {

                  
                }
                else if (objList[i].AttendId == 1)
                {
                   
                }
               
            }


            for (int i = 0; i < objList.Count; i++)
            {
               

            }





        }


        gv.DataSource = objList;
        gv.DataBind();

    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ShowDetails")
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = gv.Rows[rowIndex];

            Label lblZoomMeetingID = (Label)row.FindControl("lblZoomMeetingID");
            Label lblPassword = (Label)row.FindControl("lblPassword");
            lblZoomMeetingID.Visible = true;
            lblPassword.Visible = true;
        }
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.DataItem != null)
            {
                HiddenField hdnStatus = (HiddenField)e.Row.FindControl("hdnStatusId");
                int AttendId = Convert.ToInt32(hdnStatus.Value);
                DropDownList ddlAction = (DropDownList)e.Row.FindControl("ddlAction");
                ddlAction.SelectedValue = AttendId.ToString();
                //if (ddlAction.SelectedValue == "0")
                //{
                //    e.Row.Cells[0].Text = "";
                //}

            }

        }
    }

    protected void ddlAction_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        clsSession Item = new clsSession();
        DropDownList ddlAction = (DropDownList)sender;
        GridViewRow row = (GridViewRow)ddlAction.NamingContainer;

        Label lblZoomMeetingID = (Label)row.FindControl("lblZoomMeetingID");
        Label lblPassword = (Label)row.FindControl("lblPassword");

        string selectedValue = ddlAction.SelectedValue;

        if (selectedValue == "1")
        {
            lblZoomMeetingID.Visible = true;
            lblPassword.Visible = true;
        }

        Item.AttendId = Convert.ToInt32(ddlAction.SelectedValue);

        Item.SessionId = Convert.ToInt32(gv.DataKeys[row.RowIndex].Value.ToString());
        Item.ParticipantId = CurrentUser.CurrentParticipantId;

        Item.IsDeleted = false;
        Item.IsActive = true;
        if (Item.AttendId == 0)
        {
            Response.Write("<script>window.open('" + ddlAction.SelectedValue + "');</script>");
            Item.IsDeleted = true;
            Item.IsActive = false;
        }

        clsSession obj = new clsSession();
        obj.SessionId = Item.SessionId;
        obj.ParticipantId = CurrentUser.CurrentParticipantId;
        CountNo = obj.LoadSessionValidation(obj);
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }
        else
        {
            Item.AddJobMarket(Item);
            ddlAction.Enabled = false;
        }
        // Store selected value in a cookie
        int sessionId = Item.SessionId.HasValue ? Item.SessionId.Value : 0; // Provide a default value if needed
        StoreParticipantSessionCookie(Item.ParticipantId, sessionId, ddlAction.SelectedValue);

        //StoreParticipantSessionCookie(Item.ParticipantId, Item.SessionId, ddlAction.SelectedValue);

        // Store related data in cookies
        // Store related data in cookies
        StoreCookie("ZoomMeetingID_" + Item.SessionId, lblZoomMeetingID.Text);
        StoreCookie("Password_" + Item.SessionId, lblPassword.Text);
    }
    private void RestoreDropdownSelections()
    {
        foreach (GridViewRow row in gv.Rows)
        {
            DropDownList ddlAction = (DropDownList)row.FindControl("ddlAction");
            Label lblZoomMeetingID = (Label)row.FindControl("lblZoomMeetingID");
            Label lblPassword = (Label)row.FindControl("lblPassword");
            int sessionId = Convert.ToInt32(gv.DataKeys[row.RowIndex].Value);

            string selectedValue = GetParticipantSessionCookie(CurrentUser.CurrentParticipantId, sessionId);

            if (!string.IsNullOrEmpty(selectedValue))
            {
                ddlAction.SelectedValue = selectedValue;

                if (selectedValue == "1")
                {
                    lblZoomMeetingID.Visible = true;
                    lblPassword.Visible = true;
                    ddlAction.Enabled = false;
                }
            }
        }
    }
    private void StoreParticipantSessionCookie(int participantId, int sessionId, string selectedValue)
    {
        HttpCookie cookie = new HttpCookie($"SelectedValue_{participantId}_{sessionId}", selectedValue);
        cookie.Expires = DateTime.Now.AddYears(1000); // Set the expiration as needed
        Response.Cookies.Add(cookie);
    }


    private string GetParticipantSessionCookie(int participantId, int sessionId)
    {
        HttpCookie cookie = Request.Cookies[$"SelectedValue_{participantId}_{sessionId}"];
        return cookie != null ? cookie.Value : null;
    }

    private void StoreCookie(string name, string value)
    {
        HttpCookie cookie = new HttpCookie(name, value);
        cookie.Expires = DateTime.Now.AddYears(1000); // Set the expiration as needed
        Response.Cookies.Add(cookie);
    }

    protected void ddlSession_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}