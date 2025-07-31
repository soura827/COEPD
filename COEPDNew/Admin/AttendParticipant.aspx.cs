using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_AttendParticipant : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsAttendParticipant Item;
    int ItemId = 0;
    int ParticipantId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        ParticipantId = Convert.ToInt32(Request.QueryString["ParticipantId"]);
        Item = new clsAttendParticipant();       
        if (!IsPostBack)
        {
            if (ParticipantId > 0)
            {
                btnSearch.Enabled = false;
                BindParticipant();
                ddlParticipant.SelectedValue = Convert.ToString(ParticipantId);
                ddlParticipant.Enabled = false;
            }
            if (ItemId > 0)
            {
                BindParticipant();
                lblTitle.Text = "Edit Participant Attendence";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    if (Item.EnterTime != null)
                    {
                        DateTime dtStartTime = Convert.ToDateTime(Item.EnterTime);
                        txtsHours.Text = dtStartTime.Hour.ToString();
                        txtsmints.Text = dtStartTime.Minute.ToString();
                    }
                    ddlParticipant.SelectedValue = Convert.ToString(Item.ParticipantId);
                    ddlParticipant.Enabled = false;
                }
            }
            else
            {
                lblTitle.Text = "Add Partcicpant Attendence";
            }
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        ddlParticipant.Items.Clear();
        BindParticipant();
    }
    protected void BindParticipant()
    {
        ddlParticipant.Items.Clear();
        clsParticipant obj = new clsParticipant();
        obj.keywords = txtSearch.Text;
        ddlParticipant.DataSource = obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Participant";
        ddlParticipant.DataValueField = "ParticipantId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant -- ", ""));
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.AttendParticipantId = ItemId;
        }
        Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
        DateTime dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        if (txtsHours.Text.Length > 0)
        {
            string stHours;
            if (txtsHours.Text.Length == 1)
            {
                stHours = "0" + txtsHours.Text;
            }
            else
            {
                stHours = txtsHours.Text;
            }
            string stMin;
            if (txtsmints.Text.Length == 1)
            {
                stMin = "0" + txtsmints.Text;
            }
            else
            {
                stMin = txtsmints.Text;
            }
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy") + " " + stHours + ":" + stMin, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            Item.EnterTime = dt1;
        }
        Item.Date = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null));
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("AttendParticipantSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AttendParticipantSearch.aspx");
    }
}