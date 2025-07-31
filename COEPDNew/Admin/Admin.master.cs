using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin : System.Web.UI.MasterPage
{
    CurrentUser CurrentUser = new CurrentUser();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (CurrentUser.CurrentUserId > 0)
            {
                lblUsername.Text = CurrentUser.CurrentName + " - " + CurrentUser.CurrentDesignation;

                if (CurrentUser.CurrentRoleId == Convert.ToInt16(clsUtility.Role.Admin.GetHashCode()))
                {

                }
                else if (CurrentUser.CurrentRoleId == Convert.ToInt16(clsUtility.Role.Employee.GetHashCode()))
                {
                    BindMenu();
                }
                else if (CurrentUser.CurrentRoleId == Convert.ToInt16(clsUtility.Role.Participant.GetHashCode()))
                {
                    BindMenu();
                }
                //else if (CurrentUser.CurrentRoleId == Convert.ToInt16(clsUtility.Role.HR.GetHashCode()))
                //{
                //    BindMenu();
                //}
            }
            else
            {
                Response.Redirect("~/Login.html");
            }
        }
    }

    protected void BindMenu()
    {
        List<clsFeatureAccess> items = new List<clsFeatureAccess>();
        clsFeatureAccess obj = new clsFeatureAccess();
        obj.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
        items = obj.LoadAll(obj);

        if (items != null)
        {
            string Adminlinks = string.Empty;
            string CMSlinks = string.Empty;
            string Officelinks = string.Empty;
            string Accountlinks = string.Empty;
            string Traininglinks = string.Empty;
            string Inventorylinks = string.Empty;
            string Nurturelinks = string.Empty;
            string Reportlinks = string.Empty;
            string Examinks = string.Empty;
            string Leadinks = string.Empty;
            string Placementslinks = string.Empty;
            string Configurelinks = string.Empty;
            string NewNurturingLinks = string.Empty;
            string HRSlotsLinks =string.Empty;    
            string FMSLinks =string.Empty;
            string SessionLinks = string.Empty;
            foreach (clsFeatureAccess item in items)
            {
                if (item.ModuleId == 1)
                {
                    Adminlinks = Adminlinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                else if (item.ModuleId == 2)
                {
                    CMSlinks = CMSlinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                else if (item.ModuleId == 3)
                {
                    Officelinks = Officelinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                else if (item.ModuleId == 4)
                {
                    Accountlinks = Accountlinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                else if (item.ModuleId == 5)
                {
                    if (item.PageName.Contains("FeedbackSearch.aspx") == true)
                    {
                        int FeedbackChatCount = 0;
                        clsFeedback objCount = new clsFeedback();
                        FeedbackChatCount = Convert.ToInt32(objCount.LoadFeedbackPendingChatCount(objCount));

                        Traininglinks = Traininglinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "(" + FeedbackChatCount + ")</a></li>";
                    }
                    else
                    {
                        Traininglinks = Traininglinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                    }
                    
                }
                else if (item.ModuleId == 6)
                {
                    Inventorylinks = Inventorylinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                //else if (item.ModuleId == 7)
                //{
                //    if (item.PageName.Contains("NurtureSearch.aspx") == true)
                //    {
                //        int NurtureChatCount = 0;
                //        clsNurture objCount = new clsNurture();
                //        NurtureChatCount = Convert.ToInt32(objCount.NurtureChatCount());
                //        Nurturelinks = Nurturelinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "(" + NurtureChatCount + ")" + " </a></li>";
                //    }
                //    else
                //    {
                //        Nurturelinks = Nurturelinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                //    }
               // }
                else if (item.ModuleId == 8)
                {
                    Reportlinks = Reportlinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                else if (item.ModuleId == 9)
                {
                    if (item.PageName.Contains("Retakeexamsearch.aspx") == true)
                    {
                        int cnt = 0;
                        clsRetakeExam objCount = new clsRetakeExam();
                        cnt = Convert.ToInt16(objCount.RetakeExamCount());

                        Examinks = Examinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "(" + cnt + ")</a></li>";
                    }
                    else
                    {
                        Examinks = Examinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                    }
                }
                else if (item.ModuleId == 10)
                {
                    Leadinks = Leadinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                else if (item.ModuleId == 11)
                {
                    if (item.PageName.Contains("PlacementServiceRequestSearch.aspx") == true)
                    {
                        int PlacementServiceCount = 0;
                        clsPlacementServiceRequest objCount = new clsPlacementServiceRequest();
                        PlacementServiceCount = Convert.ToInt32(objCount.LoadPlacementPendingServiceRequestCount(objCount));
                        Placementslinks = Placementslinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "(" + PlacementServiceCount + ")" + "</a></li>";
                    }
                    else
                    {
                        Placementslinks = Placementslinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                    }
                    
                }
                else if (item.ModuleId == 12)
                {
                    Configurelinks = Configurelinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                else if (item.ModuleId == 13)
                    if (item.PageName.Contains("NurturingChatSearch.aspx") == true)
                    {
                        int NurtureChatCount = 0;
                        clsNurturingChat objCount = new clsNurturingChat();
                        NurtureChatCount = Convert.ToInt32(objCount.LoadNurturingPendingChatCount(objCount));
                        NewNurturingLinks = NewNurturingLinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "(" + NurtureChatCount + ")" + "</a></li>";
                    }
                
                else
                    {
                        NewNurturingLinks = NewNurturingLinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>"; 
                    }

                else if (item.ModuleId == 14)
                   
                    {
                        HRSlotsLinks = HRSlotsLinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                    }

                else if (item.ModuleId == 15)

                {
                    FMSLinks = FMSLinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }
                else if (item.ModuleId == 17)

                {
                    SessionLinks = SessionLinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                }

                //else if (item.ModuleId == 7)
                //{
                //    if (item.PageName.Contains("NurtureSearch.aspx") == true)
                //    {
                //        int NurtureChatCount = 0;
                //        clsNurture objCount = new clsNurture();
                //        NurtureChatCount = Convert.ToInt32(objCount.NurtureChatCount());
                //        Nurturelinks = Nurturelinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "(" + NurtureChatCount + ")" + " </a></li>";
                //    }
                //    else
                //    {
                //        Nurturelinks = Nurturelinks + "<li><a href=" + item.PageName.Trim() + ">" + item.Feature.Trim() + "</a></li>";
                //    }
                // }



            }
            if (Adminlinks.Length > 0)
            {
                ltAdmin.Text = "<li class=''><a href='#'><i class='fa fa-dashboard'></i>Admin</a><ul>" + Adminlinks + "</ul>";
            }
            if (Configurelinks.Length > 0)
            {
                ltConfigure.Text = "<li class=''><a href='#'><i class='fa fa-tachometer'></i>Configure</a><ul>" + Configurelinks + "</ul>";
            }
            if (CMSlinks.Length > 0)
            {
                ltCMS.Text = "<li class=''><a href='#'><i class='fa fa-dashboard'></i>CMS</a><ul>" + CMSlinks + "</ul>";
            }
            if (Officelinks.Length > 0)
            {
                ltOffice.Text = "<li class=''><a href='#'><i class='fa fa-tachometer'></i>Company</a><ul>" + Officelinks + "</ul>";
            }
            if (Accountlinks.Length > 0)
            {
                ltAccounting.Text = "<li class=''><a href='#'><i class='fa fa-tachometer'></i>Accounting</a><ul>" + Accountlinks + "</ul>";
            }
            if (Traininglinks.Length > 0)
            {
                ltTraining.Text = "<li class=''><a href='#'><i class='fa fa-users'></i>Training</a><ul>" + Traininglinks + "</ul>";
            }
            if (Inventorylinks.Length > 0)
            {
                ltInventory.Text = "<li class=''><a href='#'><i class='fa fa-tachometer'></i>Inventory</a><ul>" + Inventorylinks + "</ul>";
            }
            //if (Nurturelinks.Length > 0)
            //{
            //    ltNurture.Text = "<li class=''><a href='#'><i class='fa fa-tachometer'></i>Nurturing</a><ul>" + Nurturelinks + "</ul>";
            //}
            if (Reportlinks.Length > 0)
            {
                ltReports.Text = "<li class=''><a href='#'><i class='fa fa-tachometer'></i>Reports</a><ul>" + Reportlinks + "</ul>";
            }
            if (Examinks.Length > 0)
            {
                ltExam.Text = "<li class=''><a href='#'><i class='fa fa-tachometer'></i>Exams</a><ul>" + Examinks + "</ul>";
            }
            if (Leadinks.Length > 0)
            {
                ltLeads.Text = "<li class=''><a href='#'><i class='fa fa-tachometer'></i>Leads</a><ul>" + Leadinks + "</ul>";
            }
            if (Placementslinks.Length > 0)
            {
                ltPlacements.Text = "<li class=''><a href='#'><i class='fa fa-tachometer'></i>job - market</a><ul>" + Placementslinks + "</ul>";
            }
            if (NewNurturingLinks.Length > 0)
            {
                ltNewNurturing.Text = "<li class=''><a href='#'><i class='fa fa-tachometer'></i>Nurturing</a><ul>" + NewNurturingLinks + "</ul>";
            }
            if (HRSlotsLinks.Length > 0)
            {
                ltHrSlots.Text = "<li class=''><a href='#'><i class='fa fa-tachometer'></i>HrSlots</a><ul>" + HRSlotsLinks + "</ul>";
            }
            if (FMSLinks.Length > 0)
            {
                ltFMS.Text = "<li class=''><a href='#'><i class='fa fa-tachometer'></i>Fee</a><ul>" + FMSLinks + "</ul>";
            }
            if (FMSLinks.Length > 0)
            {
                ltSession.Text = "<li class=''><a href='#'><i class='fa fa-tachometer'></i>Session</a><ul>" + SessionLinks + "</ul>";
            }

            //This Functionality is used to get Default Features along with Module Name when Creating a new Employee 
            //if(CurrentUser.CurrentEmployeeId>85)
            //{
            //    liCompany.Visible = true;
            //}
            //else
            //{
            //    liCompany.Visible = false;
            //}
        }
    }
}