using BusinessLayer;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Participant_SessionSearch : System.Web.UI.Page
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
            txtFromDate.Text = DateTime.UtcNow.AddHours(5).AddMinutes(30).ToString("dd/MM/yyyy");
            txtToDate.Text = DateTime.UtcNow.AddHours(5).AddMinutes(30).ToString("dd/MM/yyyy");
            txtupFromdate.Text = DateTime.UtcNow.AddHours(5).AddMinutes(30).AddDays(1).ToString("dd/MM/yyyy");
            txtupTodate.Text = DateTime.UtcNow.AddHours(5).AddMinutes(30).AddDays(30).ToString("dd/MM/yyyy");

            BindData();
            BindData1();
        }

        RestoreDropdownSelections();

    }
    protected void BindData()
    {
        clsSession obj = new clsSession();
        if (txtFromDate.Text != "")
        {
            obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.FromDate = null;
        }
        if (txtToDate.Text != "")
        {
            obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.ToDate = null;
        }

        List<clsSession> objList = obj.LoadAllParticipant(obj);



        gv.DataSource = objList;
        gv.DataBind();


    }



    protected void BindData1()
    {
        clsSession obj1 = new clsSession();

        if (txtupFromdate.Text != "")
        {
            obj1.UpComingFromDate = DateTime.ParseExact(txtupFromdate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj1.UpComingFromDate = null;
        }
        if (txtupTodate.Text != "")
        {
            obj1.UpComingToDate = DateTime.ParseExact(txtupTodate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj1.UpComingToDate = null;
        }











        List<clsSession> objList1 = obj1.LoadAllUpComingSession(obj1);



        GridView1.DataSource = objList1;
        GridView1.DataBind();


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
            Item.Add(Item);
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


    protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
    {
        for (int i = 0; i < gv.Rows.Count; i++)
        {
            DateTime date = Convert.ToDateTime(gv.Rows[i].Cells[4].Text);
            if (date < DateTime.Now)
            {
                gv.Rows[i].Cells[3].BackColor = System.Drawing.Color.Red;
            }
        }
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







    protected void txtFromDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtToDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }


    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        BindData1();

    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        BindData1();
    }



    protected void txtupFromdate_TextChanged(object sender, EventArgs e)
    {
        BindData1();
    }

    protected void txtupTodate_TextChanged(object sender, EventArgs e)
    {
        BindData1();
    }
}