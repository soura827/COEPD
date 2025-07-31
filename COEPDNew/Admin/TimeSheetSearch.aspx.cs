using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using BusinessLayer;
public partial class TimeSheetSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void setGridView()
    {
        if (CurrentUser.IsAdmin == false)
        {
            // gv.Columns[0].Visible = false;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
            gvReport.Visible = false;

        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        FormMessage.Visible = false;
        Response.Redirect("TimeSheet.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        FormMessage.Visible = false;
        BindData();
    }

    protected void BindData()
    {
        DateTime dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        clsTimeSheet obj = new clsTimeSheet();
        obj.Date = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null));
        obj.keywords = txtSearch.Text;
        obj.EmployeeId = CurrentUser.CurrentEmployeeId;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
        setGridView();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("TimeSheet.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsTimeSheet Item = new clsTimeSheet();
            int ItemId = Convert.ToInt32(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();

            string script = "window.onload = function(){ alert('Details removed successfully');  }";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
        }
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if(e.Row.RowIndex == 0)
            {
                e.Row.Cells[0].Text = "";
            }
            
        }
    }

    protected void btnSendReport_Click(object sender, EventArgs e)
    {
        
        clsTimeSheet obj = new clsTimeSheet();
            
        obj.EmployeeId = CurrentUser.CurrentEmployeeId;
        obj.Date = System.DateTime.Now;
        gvReport.DataSource= obj.LoadAll(obj);
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
        using (StringWriter sw = new StringWriter())
        {
            using (HtmlTextWriter hw = new HtmlTextWriter(sw))
            {    
                DateTime dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                gvReport.RenderControl(hw);
                StringReader sr = new StringReader(sw.ToString());
                MailMessage msg = new MailMessage();                
                if (CurrentUser.CurrentUsername != null)
                {
                    try
                    {
                        msg.From = new MailAddress("radhika@sathyamedha.com");
                        msg.To.Add(new MailAddress(CurrentUser.CurrentUsername));
                        msg.Subject = "Time Sheet Report of :" + " " + CurrentUser.CurrentName + " " + dt;
                        msg.Body = "Employee Name:" + " " + "<b>" + CurrentUser.CurrentName + "</b>" + sw.ToString() + "<br/>";
                        msg.IsBodyHtml = true;
                        SmtpClient smtp = new SmtpClient();
                        // smtp.Host = "smtp.gmail.com";
                        // SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                        //smtp.Host = "relay-hosting.secureserver.net";
                        smtp.Host = "webmail.sathyamedha.com";
                        smtp.Port = 8025;
                        smtp.UseDefaultCredentials = false;
                      //  smtp.Credentials = new System.Net.NetworkCredential("timesheets@coepd.com", "9yWY9MzJ");
                        smtp.Credentials = new System.Net.NetworkCredential("radhika@sathyamedha.com", "Vfi93w0_");
                        smtp.Send(msg);
                        FormMessage.Text = "Report Sent Sucessfully";
                        FormMessage.Visible = true;
                    }
                    catch (SmtpException ex)
                    {
                        string msg1 = "Mail cannot be sent:";
                        msg1 += ex.Message;
                        throw new Exception(msg1);
                    }
                
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
}



