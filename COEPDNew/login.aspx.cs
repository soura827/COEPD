using BusinessLayer;
using System;

public partial class login : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    string LoginIPAddress = string.Empty;
    DateTime DateTime;

    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30).Date;
        LoginIPAddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        if (string.IsNullOrEmpty(LoginIPAddress))
            LoginIPAddress = Request.ServerVariables["REMOTE_ADDR"];

    }

    protected void btnLogin_Click(object sender, EventArgs e)

    {
        clsUser obj = new clsUser();
        obj.Username = Convert.ToString(txtUserName.Text);
        obj.Pwd = Convert.ToString(txtPassword.Text);
        obj.LoginIPAddress = LoginIPAddress;
        obj = obj.CheckValidate(obj);

        if (obj != null)
        {
            CurrentUser.CurrentUserId = Convert.ToInt32(obj.UserId);
            CurrentUser.UserBranchId = Convert.ToInt32(obj.BranchId);
            CurrentUser.CurrentRoleId = Convert.ToInt32(obj.RoleId);
            CurrentUser.CurrentUsername = obj.Username;
            // Session["CurrentUsername"] = obj.Username;
            CurrentUser.CurrentName = obj.Fullname;
            CurrentUser.CurrentParticipantId = Convert.ToInt32(obj.ParticipantId);
            CurrentUser.CurrentEmployeeId = Convert.ToInt32(obj.EmployeeId);
            CurrentUser.CurrentUserMobile = obj.Mobile;

            if (CurrentUser.CurrentRoleId == 1)
            {
                CurrentUser.CurrentDesignation = "TechAdmin";
                CurrentUser.IsAdmin = true;
                Response.Redirect("Admin/Dashboard.aspx");
            }
            else if (CurrentUser.CurrentRoleId == 2)
            {
                CurrentUser.IsAdmin = false;
                if (CurrentUser.CurrentEmployeeId > 0)
                {
                    clsEmployee Employee = new clsEmployee();
                    Employee = Employee.Load(CurrentUser.CurrentEmployeeId);
                    if (Employee != null)
                    {
                        clsDesignation Designation = new clsDesignation();
                        Designation = Designation.Load(Employee.DesignationId);
                        CurrentUser.CurrentDesignationId = Employee.DesignationId;
                        CurrentUser.CurrentDesignation = Designation.Designation;
                        CurrentUser.IsLead = Convert.ToBoolean(Employee.IsLeadPermit);
                    }
                }
                Response.Redirect("Admin/Dashboard.aspx");
            }
            else if (CurrentUser.CurrentRoleId == 3)
            {
                clsParticipant Participant = new clsParticipant();
                Participant = Participant.Load(CurrentUser.CurrentParticipantId);
                CurrentUser.IsIntern = Convert.ToBoolean(Participant.IsIntern);
                CurrentUser.CurrentLastSlotStartTime = Convert.ToDateTime(Participant.LastSlotStartTime);
                if (Participant.SubscriptionExpiredOn >= DateTime)
                {
                    clsTermsAcceptedParticipants TermsAcceptedParticipants = new clsTermsAcceptedParticipants();
                    TermsAcceptedParticipants = TermsAcceptedParticipants.LoadByParticipantId(CurrentUser.CurrentParticipantId);
                    if (TermsAcceptedParticipants != null)
                    {
                        Response.Redirect("Participant/Dashboard.aspx");
                    }
                    else
                    {

                        Response.Redirect("Participant/TermsConditions.aspx");
                    }
                }
                else
                {
                    //lblmessage.Text = "Your Subscription Expired On " +Participant.SubscriptionExpiredOn.ToString("dd MMM yyyy") + "- Please contact Helpdesk Team.";
                    //lblmessage.ForeColor = System.Drawing.Color.Red;
                    //lblmessage.Visible = true;
                    Response.Redirect("SubscriptionExpiredParticipant/Dashboard.aspx");
                }

            }
        }
        else
        {
            lblmessage.Text = "Invalid Username/Password - Please contact Helpdesk.";
            lblmessage.ForeColor = System.Drawing.Color.Red;
            lblmessage.Visible = true;
        }



    }
}