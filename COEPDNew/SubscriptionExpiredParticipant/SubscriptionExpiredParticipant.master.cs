using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class SubscriptionExpiredParticipant_SubscriptionExpiredParticipant : System.Web.UI.MasterPage
{
    CurrentUser CurrentUser = new CurrentUser();
    //This Page_Load method is used to Display the Assigned Features with Module and Resume Status link Modules  To Participant,when Participant Login  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (CurrentUser.CurrentUserId > 0)
            {
                clsParticipant Participant = new clsParticipant();
                Participant = Participant.Load(CurrentUser.CurrentParticipantId);

                //BindMenu();
                lblSubscriptionExpiredOn.Text = "Your LMS Subscription Expires on " + Participant.SubscriptionExpiredOn.ToString("dd MMM yyyy");
                lblGoal.Text = "MY GOAL - DATED : " + Participant.SetGoalOn.ToString("dd MMM yyyy") + ", " + " I want " + Participant.PurposeOfAttending + " by " + Participant.TargetDate.ToString("dd MMM yyyy") + " and I will invest atleast " + Participant.DailyTimeSpend + " Hrs time in a day  for learning and Practice BA Concepts until I reach my Goal.";
            }
            else
            {
                Response.Redirect("~/Login.html");
            }
        }
    }

}
