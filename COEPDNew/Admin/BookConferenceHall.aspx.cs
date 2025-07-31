using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class BookConferenceHall : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsBookConferenceHall Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);

        Item = new clsBookConferenceHall();
        if (!IsPostBack)
        {
            BindHall();
            ShowHall();
            BindData();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Conference Hall Slot";
                Item = Item.Load(ItemId);
                if (Item != null)
                {

                }
            }
            else
            {
                lblTitle.Text = "Add Conference Hall Slot";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.ConferenceHallId = Convert.ToInt16(ItemId);
        }
        Item.HallId = Convert.ToInt16(ddlConference.SelectedValue);
        Item.EmployeeId = CurrentUser.CurrentEmployeeId;
        int day = Convert.ToInt16(txtDay.Text);
        int month = Convert.ToInt16(txtMonth.Text);
        int year = Convert.ToInt16(txtYear.Text);
        DateTime dt = new DateTime(year, month, day);
        Item.Date = dt;
        int SHour = Convert.ToInt16(txtHSTime.Text);
        int SMin = Convert.ToInt16(txtMSTime.Text);
        DateTime dt1 = new DateTime(year, month, day, SHour, SMin, 00);
        Item.StartTime = dt1;
        int EHour = Convert.ToInt16(txtHETime.Text);
        int EMin = Convert.ToInt16(txtMETime.Text);
        DateTime dt2 = new DateTime(year, month, day, EHour, EMin, 00);
        Item.EndTime = dt2;
        Item.Purpose = txtPurpose.Text;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        ddlConference.SelectedIndex = 0;
        txtDay.Text = "";
        txtMonth.Text = "";
        txtYear.Text = "";
        txtHSTime.Text = "";
        txtMSTime.Text = "";
        txtHETime.Text = "";
        txtMETime.Text = "";
        txtPurpose.Text = "";
        ErrorMessage.Text = "";
        ErrorMessage.Visible = false;
        BindData();
    }
    protected void BindHall()
    {
        ddlConference.Items.Clear();
        clsConferenceHall obj = new clsConferenceHall();
        ddlConference.DataSource = obj.LoadAll(obj);
        ddlConference.DataTextField = "ConferenceHall";
        ddlConference.DataValueField = "HallId";
        ddlConference.DataBind();
        ddlConference.Items.Insert(0, new ListItem("-- Select --", ""));
    }
    protected void ShowHall()
    {
        ddlConference1.Items.Clear();
        clsConferenceHall obj = new clsConferenceHall();
        ddlConference1.DataSource = obj.LoadAll(obj);
        ddlConference1.DataTextField = "ConferenceHall";
        ddlConference1.DataValueField = "HallId";
        ddlConference1.DataBind();
        ddlConference1.Items.Insert(0, new ListItem("-- Select  --", "0"));
    }
    protected void BindData()
    {
        clsBookConferenceHall obj = new clsBookConferenceHall();
        obj.HallId = Convert.ToInt16(ddlConference1.SelectedValue);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdDelete")
        {
            clsBookConferenceHall obj = new clsBookConferenceHall();
            obj.Remove(Convert.ToInt32(e.CommandArgument));
            BindData();
            ErrorMessage.Text = "Book conference hall visit successfully removed";
            ErrorMessage.Visible = true;
        }
    }
    protected void ddlConference1_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            HiddenField hf = (HiddenField)e.Row.FindControl("hdnEmpId");
            LinkButton hl = (LinkButton)e.Row.FindControl("lnkDelete");
            if (CurrentUser.CurrentEmployeeId != Convert.ToInt16(hf.Value))
            {
                hl.Visible = false;
            }
        }
    }
}