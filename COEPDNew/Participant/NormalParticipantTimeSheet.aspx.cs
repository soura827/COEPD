using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Participant_NormalParticipantTimeSheet : System.Web.UI.Page
{
    clsNormalParticipantTimeSheet Item;
    int ItemId = 0;
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsNormalParticipantTimeSheet();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit TimeSheet Data";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    if (Item.StartTime != null)
                    {
                        DateTime dtStartTime = Convert.ToDateTime(Item.StartTime);
                        txtsHours.Text = dtStartTime.Hour.ToString();
                        txtsmints.Text = dtStartTime.Minute.ToString();
                    }
                    if (Item.EndTime != null)
                    {
                        DateTime dtEndTime = Convert.ToDateTime(Item.EndTime);
                        txtEHours.Text = dtEndTime.Hour.ToString();
                        txtEmints.Text = dtEndTime.Minute.ToString();
                    }
                    txtNote.Text = Item.Note;
                }
            }
            else
            {
                lblTitle.Text = "Add New TimeSheet Data";

            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.TimeSheetId = Convert.ToInt16(ItemId);
        }
        Item.ParticipantId = CurrentUser.CurrentParticipantId;
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
            Item.StartTime = dt1;
        }
        if (txtEHours.Text.Length > 0)
        {
            string etHours;
            if (txtEHours.Text.Length == 1)
            {
                etHours = "0" + txtEHours.Text;
            }
            else
            {
                etHours = txtEHours.Text;
            }
            string etMin;
            if (txtEmints.Text.Length == 1)
            {
                etMin = "0" + txtEmints.Text;
            }
            else
            {
                etMin = txtEmints.Text;
            }
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy") + " " + etHours + ":" + etMin, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            Item.EndTime = dt1;
        }
        Item.Date = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null));
        Item.StartTimeAmPm = DropDownList1.SelectedItem.Text;
        Item.EndTimeAmPm = DropDownList2.SelectedItem.Text;
        Item.Note = Convert.ToString(txtNote.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.NurturingId = 0;
        Item.AddUpdate(Item);
        Response.Redirect("NormalParticipantTimeSheetSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("NormalParticipantTimeSheetSearch.aspx");
    }
}