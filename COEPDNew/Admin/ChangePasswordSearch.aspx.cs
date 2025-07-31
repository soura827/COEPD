using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ChangePasswordSearch : System.Web.UI.Page
{
    int Total = 0;
    int ItemId = 0;
    DateTime DateTime;
    CurrentUser CurrentUser = new CurrentUser();
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
    }
    protected void BindData()
    {
        ClsChangePassword obj = new ClsChangePassword();
     

      
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();

    }


    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("ChangePassword.aspx");
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
            if (e.CommandName == "cmdEdit")
            {
                Response.Redirect("ChangePassword.aspx?ItemId=" + e.CommandArgument);
            }
            else if (e.CommandName == "cmdRequest")
            {
                Response.Redirect("ChangePassword.aspx?ItemId=" + e.CommandArgument);
            }
            //else if (e.CommandName == "cmdDelete")
            //{
            //        ClsChangePassword Item = new ClsChangePassword();
            //    int ItemId = Convert.ToInt16(e.CommandArgument);
            //    Item.Remove(ItemId);
            //    BindData();
            //    ErrorMessage.Text = "Employee successfully removed";
            //    ErrorMessage.Visible = true;
            //}
            else if (e.CommandName == "cmdSend")
            {
                int ItemId = Convert.ToInt16(e.CommandArgument);

                //Send User Credentials to Employee
                ClsChangePassword  ItemUser = new ClsChangePassword();
                ItemUser = ItemUser.Load(ItemId);
            clsEmployee Employee = new clsEmployee();
            Employee = Employee.Load(ItemId);


            if (ItemUser != null)
                {
                    if (ItemUser.FullName == "")
                    {
                        ErrorMessage.Text = "Please Enter EmployeeId ";
                        ErrorMessage.Visible = true;
                    }
                    else
                    {
                        FormMessage.Text = ItemUser.FullName + " Credentials successfully sent";
                        FormMessage.Visible = true;
                        #region "Send Email"

                        string strMessage = string.Empty;
                        //#region "old versition"
                        //strMessage = "Dear Mr./Ms. " + ItemUser.Fullname + ",<br /><br /><br />";
                        //strMessage = strMessage + "Greetings from COEPD !!!<br /><br />";
                        //strMessage = strMessage + "Please find the below COEPD Participant credentials.<br />";
                        //strMessage = strMessage + "Here you can get daily Job Openings, Documents and daily updates on trainings.<br /><br />";

                        //strMessage = strMessage + "Login : <a href=https://www.coepd.com/login.html>www.coepd.com/login.html</a><br />";
                        //strMessage = strMessage + "Username : " + ItemUser.Username + "<br />";
                        //strMessage = strMessage + "Password : " + ItemUser.Pwd + "<br /><br /><br />";

                        //strMessage = strMessage + "Please check and revert back if any assistance required.<br /><br /><br />";
                        //strMessage = strMessage + "Thanks & Regards<br />";
                        //strMessage = strMessage + "COEPD Team<br />";
                        //strMessage = strMessage + "+91 99635 55711<br />";
                        //strMessage = strMessage + "+91 40 66612216<br />";
                        //strMessage = strMessage + "dhileep.coepd@gmail.com<br />";
                        //strMessage = strMessage + "<a href=https://www.coepd.com>www.coepd.com</a><br />";

                        //strMessage = strMessage + "<a href=https://www.coepd.com><img src='https://www.coepd.com/img/logo.png'></a><br />";
                        //#endregion

                        #region "New vertion"

                        strMessage = "<p style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Dear Mr./Ms. " + ItemUser.FullName + ",</p>";
                        strMessage = strMessage + "<p style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Greetings from COEPD !!!</p>";
                        strMessage = strMessage + "<p style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Please find below credentials for Portal, Blog, Forums.</p>";
                        //strMessage = strMessage + "<p style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Congratulations on kick starting your journey on Business Analysis by attending the Business Analyst Training Program.</p>";
                        //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Now it&#39;s time to start the next phase -&nbsp;<b><i>THE&nbsp;MENTORING&nbsp;PROCESS</i></b>.</p>";
                        //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'><strong><em>Why&nbsp;Mentoring&nbsp;Process?</em></strong></p>";
                        //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Job is a consequence of your acquired or gained knowledge. Before attending interview, you should make sure that you speak Business Analyst Language and act and contribute like a Business Analyst. It is just like a stage show. The more you practice, the better you can impress your audience (interviewers/ recruiters). We understand that you have some prior work experience but we want you to justify BA knowledge rather than your past experience. Kindly follow the success mantra aligned to achieve your Goal by expert services at each phase of the&nbsp;process.</p>";
                        //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Kindly make sure that you score minimum 7 points out of 10 in all Activities (evaluated by Mentors).</p>";
                        //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>If you score less, kindly repeat that activity until you score 7 points.</p>";
                        //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Please find below, the Activities of&nbsp;<strong><em>THE&nbsp;MENTORING&nbsp;PROCESS</em></strong>.</p>";
                        //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Take minimum 3 Examinations (descriptive) with at least 80% score in 2.</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Prepare UML diagrams (Minimum 10 No&rsquo;s) such as Use case along with Specification Documents &amp; Activity diagrams for our Workbook Case studies/ Generic case Studies and get it evaluated by the Mentors.</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Work on following BA Tools for minimum 3 Workbook Case Studies/Generic Case Studies and get it evaluated by the Mentors.</p>";
                        //strMessage = strMessage + "<ol style='list-style-type:none'>";
                        //strMessage = strMessage + "<li ><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>a. MS Visio </p></li><li><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>b. Axure</p></li><li><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>c. Balsamiq Mockups</p></li>";
                        //strMessage = strMessage + "</ol>";
                        //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Write and Post minimum 3 Blogs in our COEPD Blog Portal.</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Participate in minimum 10 Forums (Either New Topics or Existed Topics).</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Work on Documents like BRD, FRD, RTM and Understanding Documents for minimum 2 Workbook Case Studies/ Generic Case Studies and get it evaluated by Mentors.</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Projects/Domain Selection(If Any) by the Mentors.</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Assistance/Guidance in Resume Preparation.</p>";
                        //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For Selected Projects, repeat 2, 3 and 6 phases in&nbsp; Mentoring &nbsp; process.</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'> 10.&nbsp; Attend Mock Interviews </p> ";
                        //strMessage = strMessage + "<ol style='list-style-type:none'>";
                        //strMessage = strMessage + "<li><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>a. HR</p></li><li><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>b.Technical</p></li><li><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>c. Techno-Functional</p></li>";
                        //strMessage = strMessage + "</ol>";
                        //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Find below attachment.</p>";
                        strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'><strong><em><u>COEPD Web Portal Login credentials:</u></em></strong></p><p style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Here you can get daily Job Openings, Documents and daily updates on trainings.</p>";
                        strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Login :&nbsp;<a  href='https://www.coepd.com/login.html' target='_blank'>www.coepd.com/login.html</a><br />";
                        strMessage = strMessage + "Username :  " + ItemUser.FullName + "<br />";
                        strMessage = strMessage + "Password : " + ItemUser.Pwd + "</p>";
                        strMessage = strMessage + "<p style='color: red;'> <strong>Note:</strong> Blogs and Forums login Credentials will be activated after completing waterfall and agile project</p>";
                        strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'><strong><em><u>Blogs Credentials(Refer Mentoring Phase No. 4):</u></em></strong></p><p style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Here you can post your own blogs and make some comments to other blogs as well.</p>";
                        strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Blogs Login :<a  href='http://blog.coepd.com/wp-login.php' target='_blank'>http://blog.coepd.com/wp-login.php<wbr />/login.aspx</a></p>";
                        strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Username :  " + ItemUser.FullName + "<br />Password : " + ItemUser.Pwd + "</p>";
                        strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'><strong><em><u>Forums Credentials(Refer Mentoring Phase No. 5):</u></em></strong></p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Here you can contribute your acquired BA knowledge and give &amp; take inputs from group members.</p>";
                        strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Forums Login :<a  href='http://forum.coepd.com/' target='_blank'>http://forum.coepd.com</a>&nbsp;</p>";
                        strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Username :  " + ItemUser.FullName + "<br />Password : " + ItemUser.Pwd + "</p>";

                       
                        //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>&nbsp;</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'><strong><em>Note:&nbsp;</em></strong>In&nbsp;Resume Projections&nbsp;you can use&nbsp;<strong><em>Active Blogger</em></strong>&nbsp;keyword by participating in these Blogs.</p>";
                        strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Please revert if you need any further clarifications.</p>";
                        strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Thanks &amp; Regards,</p>";
                        strMessage = strMessage + "<hr style='border-color: red; width: 1000px; margin: 0; ' >";
                        strMessage = strMessage + "<h3 >Mentoring Team</h3>";
                        strMessage = strMessage + "<p ><span >Mobile (India): +91&nbsp;<span >83744 21444<span >&nbsp;<span >|<span >&nbsp;<span >Desk: +91 40 66612216 Ext-24<span >&nbsp;<span >|<span >&nbsp;<span ></p><p ><a href='https://www.coepd.com/' target='_blank'>www.coepd.com</a>&nbsp;|&nbsp;<a href='mailto:NurtureBA@coepd.com' target='_blank'>NurtureBA@coepd.com</a>&nbsp; &nbsp; &nbsp;&nbsp;</p><hr style='border-color: red;width: 1000px ;margin:0;' >";



                        #endregion

                        string strSubject = "COEPD Portal Access, Blog, Forums - Mr./ Ms. " + ItemUser.FullName;

                        Alerts.SendEmail(Employee.Email, strSubject, strMessage);
                        Alerts.SendEmail("nurtureba@coepd.com", strSubject, strMessage);
                        FormMessage.Text = ItemUser.FullName + " Credentials successfully sent";
                        FormMessage.Visible = true;
                        ErrorMessage.Visible = false;
                        //lblMessage.Text = ItemUser.Username + " credentials successfully sent";
                        //lblMessage.Visible = true;
                        #endregion
                    }

                }
            }
        }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }

    
}