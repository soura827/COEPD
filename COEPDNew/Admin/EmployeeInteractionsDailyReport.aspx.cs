using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net.Mail;
using BusinessLayer;
using System.Text;
using System.Net;

public partial class Admin_EmployeeInteractionsDailyReport : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    List <string> dailySummary;
    int hoursContributed;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    //protected void setGridView()
    //{
    //    if (CurrentUser.IsAdmin == false)
    //    {
    //        // gv.Columns[0].Visible = false;
    //    }
    //}
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
            gvReport.Visible = false;
            lblEmployeeName.Text = CurrentUser.CurrentName;
            lblDate.Text = DateTime.UtcNow.AddHours(5).AddMinutes(30).ToString("D");

        }
    }

    protected void BindData()
    {
        DateTime dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        clsActivityInteractions obj = new clsActivityInteractions();
        obj.Date = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null));
        obj.CreatedBy = CurrentUser.CurrentUserId;
        gv.DataSource = obj.LoadDailyReportByEmployee(obj);
        gv.DataBind();
        //setGridView();
    }

    //protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    //{

    //    if (e.CommandName == "cmdEdit")
    //    {
    //        Response.Redirect("TimeSheet.aspx?ItemId=" + e.CommandArgument);
    //    }
    //    else if (e.CommandName == "cmdDelete")
    //    {
    //        clsTimeSheet Item = new clsTimeSheet();
    //        int ItemId = Convert.ToInt32(e.CommandArgument);
    //        Item.Remove(ItemId);
    //        BindData();

    //        string script = "window.onload = function(){ alert('Details removed successfully');  }";
    //        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
    //    }
    //}

    //protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.DataRow)
    //    {
    //        if (e.Row.RowIndex == 0)
    //        {
    //            e.Row.Cells[0].Text = "";
                
    //        }

    //    }
        
    //}

    protected void btnSendReport_Click(object sender, EventArgs e)
    {

        clsActivityInteractions obj = new clsActivityInteractions();
        obj.CreatedBy = CurrentUser.CurrentUserId;
        // obj.Date = System.DateTime.Now;
        obj.Date = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        gvReport.DataSource = obj.LoadDailyReportByEmployee(obj);
        

        gvReport.DataBind();
        gvReport.Visible = true;
        SendEmail();
        gvReport.Visible = false;
        gv.Visible = true;
        //FormMessage.Text = "Report Sent Sucessfully";
        //FormMessage.Visible = true;



    }

    public void SendEmail()
    {
        clsActivityInteractions obj1 = new clsActivityInteractions();
        using (StringWriter sw = new StringWriter())
        {
            using (HtmlTextWriter hw = new HtmlTextWriter(sw))
            {
                DateTime dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                gvReport.RenderControl(hw);
                StringReader sr = new StringReader(sw.ToString());
                MailMessage msg = new MailMessage("timesheets@coepd.com", "reports@coepd.com");
                if (CurrentUser.CurrentUsername != null)
                {
                        msg.To.Add(new MailAddress(CurrentUser.CurrentUsername));
                        msg.Subject = "Activity Report of :" + " " + CurrentUser.CurrentName + " - " + lblDate.Text;
                        
                        obj1.CreatedBy = CurrentUser.CurrentUserId;
                        // obj1.Date = System.DateTime.Now;
                        obj1.Date = dt;
                        dailySummary = obj1.LoadDailySummaryByEmployee(obj1);

                        msg.Body = "<br>Employee Name:" + " " + "<b>" + CurrentUser.CurrentName + "</b>";

                        if (dailySummary != null)
                        {
                            hoursContributed = Convert.ToInt32(dailySummary[2]);
                            string employeeMinutesContributed;
                            string systemMinutesContributed;
                            string employeeHoursContributed;
                            string SystemHoursContributed;

                            employeeMinutesContributed = (Convert.ToInt32(dailySummary[3]) % 60).ToString();
                            systemMinutesContributed = (Convert.ToInt32(dailySummary[5]) % 60).ToString();
                            employeeHoursContributed = (Convert.ToInt32(dailySummary[3]) / 60).ToString();
                            SystemHoursContributed = (Convert.ToInt32(dailySummary[5]) / 60).ToString();
                            msg.Body = msg.Body + "<br> Start Time &nbsp;" + dailySummary[0] + "&nbsp;and End Time &nbsp;" + dailySummary[1] + "<br>" +
                                        "Contribution towards work is &nbsp;" + dailySummary[3] + "&nbsp;minutes or&nbsp;" + employeeHoursContributed + 
                                        "&nbsp;hours&nbsp;" + employeeMinutesContributed + "&nbsp; minutes&nbsp;" + "<br>" +
                                        "System Utilization time is &nbsp;" + dailySummary[5] + "&nbsp;minutes or&nbsp;" + SystemHoursContributed + 
                                        "&nbsp;Hours&nbsp;" + systemMinutesContributed + "&nbsp;minutes <br>";

                            if (hoursContributed < 6)
                                msg.Body = msg.Body + "<h3 style=\"color:Red;\">Contribution is less than 6 hours, please check your activities entry and resubmit.</h3 ><br>";
                            else if (hoursContributed > 9)
                                msg.Body = msg.Body + "<h3 style=\"color: Green;\">Contribution is more than 9 hours, please check your activities entry and resubmit.</h3 ><br><br>";

                            msg.Body = msg.Body + sw.ToString() + "<br/>";

                            msg.IsBodyHtml = true;

                        }
                        else
                        {
                            msg.Body = msg.Body + "<center> <h1 style=\"color: Red;\">No data available for daily report. </h1 ><br><br> </center>";
                            msg.IsBodyHtml = true;
                        }


                    // Set the SMTP server and port for Gmail
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                    // Enable SSL encryption for secure communication
                    smtpClient.EnableSsl = true;

                    // Set the credentials for authentication
                    smtpClient.Credentials = new NetworkCredential("developer2@coepd.com", "Manuguru123#");
                      //smtpClient.Credentials = new NetworkCredential("developer3@coepd.com", "sushankb96");    /**/
                    // Create a new email message
                    // message.From = new MailAddress("developer1@coepd.com");
                    //message.To.Add(receipient);
                    //message.Subject = subject;
                    //message.Body = Body;
                    //message.IsBodyHtml = true;
                    // Send the email
                    smtpClient.Send(msg);

                    FormMessage.Text = "Report Sent Sucessfully";
                    FormMessage.Visible = true;
                    //SmtpClient smtp = new SmtpClient();
                    //// smtp.Host = "smtp.gmail.com";
                    //// SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    //smtp.Host = "relay-hosting.secureserver.net";
                    //smtp.Port = 25;
                    //smtp.UseDefaultCredentials = false;
                    //smtp.Credentials = new System.Net.NetworkCredential("developer1@coepd.com", "@123@Sateesh");
                    //smtp.Send(msg);


                    //SmtpClient smtp = new SmtpClient();
                    //smtp.Host = "webmail.coepdglobal.com";
                    //smtp.EnableSsl = false;
                    //smtp.UseDefaultCredentials = false;
                    //smtp.Port = 8025;
                    //smtp.Credentials = new System.Net.NetworkCredential("timesheet@coepdglobal.com", "Y@89ge9t");
                    //smtp.Send(msg);
                    //FormMessage.Text = "Report Sent Sucessfully";
                    //FormMessage.Visible = true;

                }
                else
                {
                    Response.Redirect("https://www.coepd.com/Login.html");
                }
            }
        }
    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Verifies that the control is rendered */
    }

    protected void btnGoToTasks_Click(object sender, EventArgs e)
    {
        Response.Redirect("ActivityTasks.aspx");
    }
}