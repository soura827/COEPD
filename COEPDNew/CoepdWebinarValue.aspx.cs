using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class CoepdWebinarValue : System.Web.UI.Page
{
    string Title, USP1, USP2, USP3, USP4, USP5, USP6, USP7, USP8, USP9, USP10;
    bool ismobilerequired, isemailrequired, isspecificenquiryrequired;
    int CountNo = 0;
    int Offer;
    DateTime DateTime;
    int CreatedBy;
    string FullName;
    string OwnerEmail;
    string FilePath;

    clsCampaignWebinar ItemCampaign = new clsCampaignWebinar();
   clsCoepdWebinarValue ItemLead = new clsCoepdWebinarValue();
    clsUser ItemUser = new clsUser();
    protected void Page_Load(object sender, EventArgs e)
    {

        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        if (IsPostBack)
        {
            int ItemId = Convert.ToInt32(Request["Offer"]);
            ItemCampaign = ItemCampaign.Load(ItemId);
            ItemLead.Offer = Convert.ToInt32(ItemId);
            if (ItemCampaign != null)
            {
                FilePath = ItemCampaign.FilePath;
                CreatedBy = Convert.ToInt32(ItemCampaign.CreatedBy);
                ItemUser = ItemUser.Load(CreatedBy);
                if (ItemUser != null)
                {
                    FullName = ItemUser.Fullname;
                    OwnerEmail = ItemUser.Username;
                     
                }

            }

        }

        if (!String.IsNullOrEmpty(Request.QueryString["Offer"]))
        {
            int value;
            bool isNumeric = int.TryParse(Request.QueryString["Offer"], out value);
            if (isNumeric)
            {
                int id = Convert.ToInt32(Request.QueryString["Offer"]);
                ItemCampaign = ItemCampaign.Load(id);
                if (ItemCampaign != null)
                {
                    Offer = Convert.ToInt32(Request.QueryString["Offer"]);
                    clsCampaignWebinar ItemCampaign = new clsCampaignWebinar();
                    if (Offer > 0)
                    {
                        ItemCampaign = ItemCampaign.Load(Offer);
                        Title = ItemCampaign.Title;
                        if (ItemCampaign.Title.Length > 0)
                        {
                            lblTitle.Visible = true;
                            lblTitle.Text = ItemCampaign.Title.ToString();
                        }
                        if (ItemCampaign.USP1.ToString().Length > 0)
                        {
                            lblUSP1.Visible = true;
                            lblUSP1.Text = ItemCampaign.USP1.ToString();
                        }
                        else
                        {
                            lblUSP1.Visible = false;
                        }
                        if (ItemCampaign.USP2.ToString().Length > 0)
                        {
                            lblUSP2.Visible = true;
                            lblUSP2.Text = ItemCampaign.USP2.ToString();
                        }
                        else
                        {
                            lblUSP2.Visible = false;
                        }
                        if (ItemCampaign.USP3.ToString().Length > 0)
                        {
                            lblUSP3.Visible = true;
                            lblUSP3.Text = ItemCampaign.USP3.ToString();
                        }
                        else
                        {
                            lblUSP3.Visible = false;
                        }
                        if (ItemCampaign.USP4.ToString().Length > 0)
                        {
                            lblUSP4.Visible = true;
                            lblUSP4.Text = ItemCampaign.USP4.ToString();
                        }
                        else
                        {
                            lblUSP4.Visible = false;
                        }
                        if (ItemCampaign.USP5.ToString().Length > 0)
                        {
                            lblUSP5.Visible = true;
                            lblUSP5.Text = ItemCampaign.USP5.ToString();
                        }
                        else
                        {
                            lblUSP5.Visible = false;
                        }
                        if (ItemCampaign.USP6.ToString().Length > 0)
                        {
                            lblUSP6.Visible = true;
                            lblUSP6.Text = ItemCampaign.USP6.ToString();
                        }
                        else
                        {
                            lblUSP6.Visible = false;
                        }
                        if (ItemCampaign.USP7.ToString().Length > 0)
                        {
                            lblUSP7.Visible = true;
                            lblUSP7.Text = ItemCampaign.USP7.ToString();
                        }
                        else
                        {
                            lblUSP7.Visible = false;
                        }
                        if (ItemCampaign.USP8.ToString().Length > 0)
                        {   Image83.Visible = true;
                            lblUSP8.Visible = true;
                            lblUSP8.Text = ItemCampaign.USP8.ToString();
                        }
                        else
                        {   Image83.Visible = false;
                            lblUSP8.Visible = false;
                        }
                        if (ItemCampaign.USP9.ToString().Length > 0)
                        {
                            Image84.Visible = true;
                            lblUSP9.Visible = true;
                            lblUSP9.Text = ItemCampaign.USP9.ToString();
                            
                        }
                        else
                        {
                            Image84.Visible = false;
                            lblUSP9.Visible = false;
                           
                          
                        }
                        if (ItemCampaign.USP10.ToString().Length > 0)
                        {
                            Image85.Visible = true;
                            lblUSP10.Visible = true;
                            lblUSP10.Text = ItemCampaign.USP10.ToString();
                            
                        }
                        else
                        {
                            Image85.Visible = false;
                            lblUSP10.Visible = false;
                           
                        }
                        if (ItemCampaign.MobileNumberRequired)
                        {
                            txtTelephone.Visible = true;
                        }
                        else
                        {
                            txtTelephone.Visible = false;
                        }
                        if (ItemCampaign.EmailIdRequired)
                        {
                            txtEmail.Visible = true;
                        }
                        else
                        {
                            txtEmail.Visible = false;
                        }
                        if (ItemCampaign.SpecificEnquiryRequired)
                        {
                            txtSpecEnq.Visible = true;
                        }
                        else
                        {
                            txtSpecEnq.Visible = false;
                        }
                    }
                }
                else
                {
                    Response.Redirect("https://www.coepd.com");
                }
            }
            else
            {
                Response.Redirect("https://www.coepd.com");
            }

        }
        else
        {
            Response.Redirect("https://www.coepd.com");
        }

        ////Offer = Convert.ToInt16(Request.QueryString["Offer"]);
        //ItemCampaign = new clsCampaign();
        //if (Offer > 0)
        //{
        //    ItemCampaign = ItemCampaign.Load(Offer);
        //    Title = ItemCampaign.Title;
        //    if (ItemCampaign.Title.Length > 0)
        //    {
        //        lblTitle.Visible = true;
        //        lblTitle.Text = ItemCampaign.Title.ToString();
        //    }
        //    if (ItemCampaign.USP1.ToString().Length > 0)
        //    {
        //        lblUSP1.Visible = true;
        //        lblUSP1.Text = ItemCampaign.USP1.ToString();
        //    }
        //    else
        //    {
        //        lblUSP1.Visible = false;
        //    }
        //    if (ItemCampaign.USP2.ToString().Length > 0)
        //    {
        //        lblUSP2.Visible = true;
        //        lblUSP2.Text = ItemCampaign.USP2.ToString();
        //    }
        //    else
        //    {
        //        lblUSP2.Visible = false;
        //    }
        //    if (ItemCampaign.USP3.ToString().Length > 0)
        //    {
        //        lblUSP3.Visible = true;
        //        lblUSP3.Text = ItemCampaign.USP3.ToString();
        //    }
        //    else
        //    {
        //        lblUSP3.Visible = false;
        //    }
        //    if (ItemCampaign.USP4.ToString().Length > 0)
        //    {
        //        lblUSP4.Visible = true;
        //        lblUSP4.Text = ItemCampaign.USP4.ToString();
        //    }
        //    else
        //    {
        //        lblUSP4.Visible = false;
        //    }
        //    if (ItemCampaign.USP5.ToString().Length > 0)
        //    {
        //        lblUSP5.Visible = true;
        //        lblUSP5.Text = ItemCampaign.USP5.ToString();
        //    }
        //    else
        //    {
        //        lblUSP5.Visible = false;
        //    }
        //    if (ItemCampaign.USP6.ToString().Length > 0)
        //    {
        //        lblUSP6.Visible = true;
        //        lblUSP6.Text = ItemCampaign.USP6.ToString();
        //    }
        //    else
        //    {
        //        lblUSP6.Visible = false;
        //    }
        //    if (ItemCampaign.USP7.ToString().Length > 0)
        //    {
        //        lblUSP7.Visible = true;
        //        lblUSP7.Text = ItemCampaign.USP7.ToString();
        //    }
        //    else
        //    {
        //        lblUSP7.Visible = false;
        //    }
        //    if (ItemCampaign.USP8.ToString().Length > 0)
        //    {
        //        lblUSP8.Visible = true;
        //        lblUSP8.Text = ItemCampaign.USP8.ToString();
        //    }
        //    else
        //    {
        //        lblUSP8.Visible = false;
        //    }
        //    if (ItemCampaign.USP9.ToString().Length > 0)
        //    {
        //        lblUSP9.Visible = true;
        //        lblUSP9.Text = ItemCampaign.USP9.ToString();
        //    }
        //    else
        //    {
        //        lblUSP9.Visible = false;
        //    }
        //    if (ItemCampaign.USP10.ToString().Length > 0)
        //    {
        //        lblUSP10.Visible = true;
        //        lblUSP10.Text = ItemCampaign.USP10.ToString();
        //    }
        //    else
        //    {
        //        lblUSP10.Visible = false;
        //    }
        //    if (ItemCampaign.MobileNumberRequired)
        //    {
        //        txtTelephone.Visible = true;
        //    }
        //    else
        //    {
        //        txtTelephone.Visible = false;
        //    }
        //    if (ItemCampaign.EmailIdRequired)
        //    {
        //        txtEmail.Visible = true;
        //    }
        //    else
        //    {
        //        txtEmail.Visible = false;
        //    }
        //    if (ItemCampaign.SpecificEnquiryRequired)
        //    {
        //        txtSpecEnq.Visible = true;
        //    }
        //    else
        //    {
        //        txtSpecEnq.Visible = false;
        //    }
        //}
    }
    //protected void BindReset()
    //{
    //    txtKPIName.Text = "";
    //    ddlKPIApplicableTo.SelectedIndex = -1;
    //}
    protected void SendFile()
    {
       // Response.ContentType = "Application/pdf";
       // Response.AppendHeader("Content-Disposition", "attachment; filename=" + FilePath + "");
       // Response.TransmitFile(Server.MapPath("~/UserDocs/CampaignDocs/" + FilePath + ""));
    }
    protected void BindMobileCount()
    {
        clsCoepdWebinarValue obj = new clsCoepdWebinarValue();
        obj.MobileNo = Convert.ToString(txtTelephone.Text);
        CountNo = obj.LoadCoepdValueMobileValidation(obj);
    }
    protected void BindEmailCount()
    {
        clsCoepdWebinarValue obj = new clsCoepdWebinarValue();
        obj.EmailId = Convert.ToString(txtEmail.Text);
        CountNo = obj.LoadCoepdValueEmailValidation(obj);

    }
    protected void btnSubmit_Click(object sender, EventArgs e)

    {
        btnSubmit.Enabled = false;
        ItemLead.Name = txtName.Text;
        ItemLead.EmailId = txtEmail.Text;
        ItemLead.MobileNo = txtTelephone.Text;
        ItemLead.SpecificEnquiry = txtSpecEnq.Text;
        //ItemLead.Title = ItemCampaign.Title;
        ItemLead.Location = txtLocation.Text;
        ItemLead.Date = DateTime.Now;
        //ItemLead.Date = Convert.ToDateTime(txtTargetDate.Text);
        ItemLead.AddUpdate(ItemLead);
        //string toMail = "venkat.coepd@gmail.com,pe01.hyd@coepd.com" + "," + OwnerEmail;
        string toMail = "developer2@coepd.com" + "," + OwnerEmail;
        string Subject = "New Lead from " + ItemCampaign.Title + " - " + DateTime.UtcNow.AddHours(5).AddMinutes(30).ToString("dd MMM yyyy hh:mm tt");
        string Body =
        "New Lead Details:" + "<br>" +
        "________________________" + "<br>" +
        //"SNO :" + ItemLead.Lead_ID + "<br>" +
        "Lead Name : " + txtName.Text + "<br>" +
         "Lead Email ID :" + txtEmail.Text + "<br>" +
        "Lead Mobile Number : " + txtTelephone.Text + "<br>" +
        "Lead Specific Enquiry : " + txtSpecEnq.Text + "<br>" +
        "Lead Location : " + txtLocation.Text + "<br>" +

         "________________________" + "<br>" +
        "Campaign Owner Details:" + "<br>" +
        "_________________________" + "<br>" +
        "Campaign Id : " + ItemCampaign.Offer + "<br>" +
        "Campaign Title : " + ItemCampaign.Title + "<br>" +
        "Campaign Owner : " + FullName + "<br>" +
        "_________________________" + "<br>"
        ;
        //string Attachment = "UserEmail" + "," + UserEmail;
        Alerts.SendEmail(toMail, Subject, Body);
        txtName.Text = "";
        txtEmail.Text = "";
        txtLocation.Text = "";
        txtTelephone.Text = "";
        txtSpecEnq.Text = "";
        btnSubmit.Visible = false;
        //ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
        //SendFile();
        //string FileAddress = "";
        //FormMessage.Text = "Your details successfully submitted. Our helpdesk team contact you shortly. " + "<a href='https://www.coepd.com/'>Click here to go to our website.</a>";
        //FormMessage.Visible = true;
        Response.Redirect("~/UserDocs/CampaignDocs/" + FilePath);

        //Response.End();
        //Response.Redirect("https://www.coepd.com/");
    }

    protected void txtEmail_TextChanged(object sender, EventArgs e)
    {
        BindEmailCount();
        if (CountNo > 0)
        {
            //ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtEmail.Text = "";
            ErrorMessage.Text = "Your email already registered with us.";
            ErrorMessage.Visible = true;
        }
        else
        {
            ErrorMessage.Visible = false;
        }
    }

    protected void txtTelephone_TextChanged(object sender, EventArgs e)
    {
        BindMobileCount();
        if (CountNo > 0)
        {
            //ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtTelephone.Text = "";
            ErrorMessage.Text = "Your Mobile number already registered with us.";
            ErrorMessage.Visible = true;
        }
        else
        {
            ErrorMessage.Visible = false;
        }
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://wa.me/+918712655794");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://wa.me/+919765068117");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://wa.me/+918712655810");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://wa.me/+918712655810");
    }
}