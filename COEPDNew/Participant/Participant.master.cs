using System;
using System.Collections.Generic;
using BusinessLayer;
public partial class Participant : System.Web.UI.MasterPage
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
                BindParticipantMenu();
                lblSubscriptionExpiredOn.Text = "Your LMS Subscription Expires on " + Participant.SubscriptionExpiredOn.ToString("dd MMM yyyy");
                lblGoal.Text = "MY GOAL - DATED : " + Participant.SetGoalOn.ToString("dd MMM yyyy") +", " + " I want " + Participant.PurposeOfAttending + " by " + Participant.TargetDate.ToString("dd MMM yyyy") + " and I will invest atleast "+ Participant.DailyTimeSpend + " Hrs time in a day  for learning and Practice BA Concepts until I reach my Goal.";
                if (CurrentUser.IsIntern == true)
                {
                    lblUsername.Text = CurrentUser.CurrentName + " - Intern";
                    lbltimeshet.Text = "<a href='ParticipantTimeSheetSearch.aspx'><i class='fa fa-clock-o'></i>Timesheet</a>";
                }
                else
                {
                    lblUsername.Text = CurrentUser.CurrentName + " - Participant";
                   lbltimeshet.Text = "<a href='NormalParticipantTimeSheetSearch.aspx'><i class='fa fa-clock-o'></i>Timesheet</a>";
                }
            }
            else
            {
                Response.Redirect("~/Login.html");
            }
        }
    }
    //This Method is used to Display Resume Status linkModule when Participant Login.
    //public void BindMenu()
    //{
    //    clsResumePreparation obj = new clsResumePreparation();
    //    int ItemId = CurrentUser.CurrentParticipantId;
    //    obj = obj.Load(ItemId);
    //    if (obj != null)
    //    {
    //        lisResumePrep.Visible = false;
    //        if (obj.ResumeStatus == true)
    //        {
    //            lisApprovedResume.Visible = true;
    //            lisMyResume.Visible = false;
    //        }
    //        else
    //        {
    //            lisMyResume.Visible = true;
    //            lisApprovedResume.Visible = false;
    //        }
    //    }
    //    else
    //    {
    //        lisResumePrep.Visible = true;
    //        lisMyResume.Visible = false;
    //        lisApprovedResume.Visible = false;
    //    }
    //}
    //This method is used to Display Assigned Features with Module to Participant,when Participant Login .
    protected void BindParticipantMenu()
    {
        List<clsParticipantFeatureAccess> items = new List<clsParticipantFeatureAccess>();
        clsParticipantFeatureAccess obj = new clsParticipantFeatureAccess();
        obj.ParticipantId = Convert.ToInt16(CurrentUser.CurrentParticipantId);
        items = obj.LoadAll(obj);

        lisDashboard.Visible = true;
        //lisIdeaPostSearch.Visible = true;
        //lisCalendar.Visible = true;

        if (items != null)
        {

            string Nurturinglinks = string.Empty;
            string Documentslinks = string.Empty;
            string Placementslinks = string.Empty;
            string Examslinks = string.Empty;
            string Certificatelinks = string.Empty;
            string Sessionlinks =string.Empty;
            foreach (clsParticipantFeatureAccess item in items)
            {
                if (item.ModuleId == 1)
                {
                    Nurturinglinks = Nurturinglinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                else if (item.ModuleId == 2)
                {
                    Documentslinks = Documentslinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                else if (item.ModuleId == 3)
                {
                    Placementslinks = Placementslinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                else if (item.ModuleId == 4)
                {
                    Examslinks = Examslinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                else if (item.ModuleId == 5)
                {
                    Certificatelinks = Certificatelinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                else if (item.ModuleId == 6)
                {
                    Sessionlinks = Sessionlinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                if (Nurturinglinks.Length > 0)
                {
                    ltNurturing.Text = "<li class=''><a href='#'><i class='fa fa-group'></i>Nurturing</a><ul>" + Nurturinglinks + "</ul>";
                }

                if (Documentslinks.Length > 0)
                {
                    ltDocuments.Text = "<li class=''><a href='#'><i class='fa fa-file-text'></i>Documents</a><ul>" + Documentslinks + "</ul>";
                }
                if (Placementslinks.Length > 0)
                {
                    ltPlacements.Text = "<li class=''><a href='#'><i class='fa fa-tasks'></i>Bajobmarket</a><ul>" + Placementslinks + "</ul>";
                }
                if (Examslinks.Length > 0)
                {
                    ltExams.Text = "<li class=''><a href='#'><i class='fa fa-bar-chart-o'></i>Exams</a><ul>" + Examslinks + "</ul>";
                }
                if (Certificatelinks.Length > 0)
                {
                    ltCertificate.Text = "<li class=''><a href='#'><i class='fa fa-certificate'></i>Certificate</a><ul>" + Certificatelinks + "</ul>";
                }
                if (Sessionlinks.Length > 0)
                {
                    ltSession.Text = "<li class=''><a href='#'><i class='fa fa-certificate'></i>Session</a><ul>" + Sessionlinks + "</ul>";
                }
            }       
        }
    }
}