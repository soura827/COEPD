using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Participant_SetGoal : System.Web.UI.Page
{
    int ItemId = 0;
    clsParticipant Item = new clsParticipant();
    CurrentUser CurrentUser = new CurrentUser();
    string SelectedGoal = "";
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = CurrentUser.CurrentParticipantId;
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Set Goal";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    if (Item.IsGoalSet == true)
                        Response.Redirect("Dashboard.aspx");
                    
                }

            }
            else
            {
                Response.Redirect("~/Login.html");
                lblTitle.Text = "Set Goal";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(CurrentUser.CurrentUserId>0)
        {
            if (CurrentUser.CurrentParticipantId > 0)
            {
                Item.ParticipantId = CurrentUser.CurrentParticipantId;
            }
            Item.IsGoalSet = true;
            foreach(ListItem item in chkModuleList.Items)
            {
                if(item.Selected)
                {
                    SelectedGoal +=item.Value + " and ";
                }
            }
           SelectedGoal = SelectedGoal.Remove(SelectedGoal.Length - 4);
            Item.PurposeOfAttending = SelectedGoal;
            if (txtTargetDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtTargetDate.Text, "dd/MM/yyyy", null);
                Item.TargetDate = Date;
            }
            Item.DailyTimeSpend = Convert.ToInt16(ddlDailyTimeSpend.SelectedValue);
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.GoalSettingAddUpdate(Item);
            btnSubmit.Enabled = false;
            Response.Redirect("Dashboard.aspx");
        }
        else
        {
            Response.Redirect("~/Login.html");
        }
    }
}