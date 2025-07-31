using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public partial class Admin_ReferFriend : System.Web.UI.Page
{

    int CountNo = 0;

    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    CurrentUser CurrentUser = new CurrentUser();
    clsReferFriend Item = new clsReferFriend();
    int ItemId = 0;

    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);

        if (!IsPostBack)
        {
            LoadLocation();
            LoadEmployee();
            lblTitle.Text = "Add Refer Friend";


        }
    }

    protected void LoadLocation()
    {
        clsLocation obj = new clsLocation();
        ddlReferralLocationPreference.DataSource = obj.LoadAll(obj);
        ddlReferralLocationPreference.DataTextField = "Location";
        ddlReferralLocationPreference.DataValueField = "LocationId";
        ddlReferralLocationPreference.DataBind();
        ddlReferralLocationPreference.Items.Insert(0, new ListItem("Select Location", ""));
    }

    protected void BindName()
    {
        clsReferFriend obj = new clsReferFriend();
        obj.ReferralName = Convert.ToString(txtReferralName.Text);
        CountNo = obj.LoadReferFriendNameValidation(obj);
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtReferralName.Text = "";
        }
    }

    protected void BindEmail()
    {
        clsReferFriend obj = new clsReferFriend();
        obj.ReferralEmail = Convert.ToString(txtReferralEmail.Text);
        CountNo = obj.LoadReferFriendEmailValidation(obj);
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtReferralEmail.Text = "";

        }
    }

    protected void LoadEmployee()
    {
        clsEmployee item = new clsEmployee();
        int itemId = CurrentUser.CurrentEmployeeId;
        item = item.Load(itemId);
        txtParticipantName.Text = item.Employee;
        txtLocationId.Text = item.LocationId.ToString();
        LoadEmployeeLocation();
    }

    protected void LoadEmployeeLocation()
    {
        clsLocation item = new clsLocation();
        int Loc = Convert.ToInt32(txtLocationId.Text);
        item = item.Load(Loc);
        txtParticipantLocation.Text = item.Location;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
            Item.ReferFriendId = Convert.ToInt16(ItemId);
        Item.ReferralName = txtReferralName.Text;
        Item.ReferralContact = txtReferralContact.Text;
        Item.ReferralEmail = txtReferralEmail.Text;
        Item.ReferralLocationPreference = Convert.ToInt32(ddlReferralLocationPreference.SelectedValue);
        Item.Domain = txtDomain.Text;
        Item.PlanningToJoinTheCourse = Convert.ToString(ddlPlanningToJoinTheCourse.SelectedValue);
        Item.ReferralAvailableTimeSchedule = Convert.ToDateTime(txtReferralAvailableTimeSchedule.Text);
        
        
        if(ddlReferralBonusInterest.SelectedIndex > 0)
        Item.IsReferralBonus = Convert.ToBoolean(ddlReferralBonusInterest.SelectedValue);
        
        Item.CreatedBy = CurrentUser.CurrentEmployeeId;
        Item.EmployeeId = CurrentUser.CurrentEmployeeId;

        if (ddlPaymentType.SelectedIndex > 0)
        {
            switch (Convert.ToInt32(ddlPaymentType.SelectedValue))
            {
                case 1:
                    Item.ParticipantUPIID = txtGooglePay.Text;
                    break;
                case 2:
                    lblPaytm.Visible = true;
                    Item.ParticipantUPIID = txtPaytm.Text;
                    break;
                case 3:
                    lblPhonePay.Visible = true;
                    Item.ParticipantUPIID = txtPhonePay.Text;
                    break;
                case 4:
                    lblAmazonpay.Visible = true;
                    Item.ParticipantUPIID = txtAmazonPay.Text;
                    break;
            }
        }

        #region "Location "
        //28297 - rajeshaker - hyderbad - pe07@coepd.com
        //10031 - Rasika A.Kotasthane - pune - pe.pune@coepd.com
        //27205 - F Sherlin divya-chennai - pe05@coepd.com

        switch (Item.ReferralLocationPreference)
        {
            case 1:
                Item.ProcessExecutiveLocationId = Convert.ToInt32(28297);//hyd
                break;
            case 2:
                Item.ProcessExecutiveLocationId = Convert.ToInt32(27205);                      //chennai
                break;
            case 3:
                Item.ProcessExecutiveLocationId = Convert.ToInt32(10031);          //pune
                break;
            case 4:
                Item.ProcessExecutiveLocationId = Convert.ToInt32(10031);          //pune
                break;
            case 5:
                Item.ProcessExecutiveLocationId = Convert.ToInt32(28297);//hyd
                break;
            case 6:
                Item.ProcessExecutiveLocationId = Convert.ToInt32(28297);//hyd
                break;
            case 7:
                Item.ProcessExecutiveLocationId = Convert.ToInt32(10031);          //pune
                break;
            case 8:
                Item.ProcessExecutiveLocationId = Convert.ToInt32(10031);          //pune
                break;
            case 9:
                Item.ProcessExecutiveLocationId = Convert.ToInt32(28297);//hyd
                break;
            case 10:
                Item.ProcessExecutiveLocationId = Convert.ToInt32(28297);//hyd
                break;
            case 11:
                Item.ProcessExecutiveLocationId = Convert.ToInt32(10031);          //pune
                break;
            case 12:
                Item.ProcessExecutiveLocationId = Convert.ToInt32(28297);//hyd
                break;
            case 13:
                Item.ProcessExecutiveLocationId = Convert.ToInt32(28297);//hyd
                break;
        }
        #endregion
        Item.AddUpdate(Item);
        btnSubmit.Enabled = false;
        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }


        if (Item != null)
        {
            #region "Send Email"
            string strMessage = string.Empty;
            strMessage = "Hi <br /><br /><br />";
            strMessage = strMessage + "New referrel from Participant <br /><br />";
            strMessage = strMessage + "Please find the below Deatils<br />";
            strMessage = strMessage + "Name : " + Item.ReferralName + "<br />";
            strMessage = strMessage + "Email : " + Item.ReferralEmail + "<br /><br /><br />";
            strMessage = strMessage + "Mobile : " + Item.ReferralContact + "<br />";
            strMessage = strMessage + "Referred By : " + Item.Participant + "<br /><br /><br />";
            strMessage = strMessage + "<a href=https://www.coepd.com><img src='https://www.coepd.com/img/logo.png'></a><br />";
            string strSubject = "New Referral Deatils From " + Item.Participant;
            Alerts.SendEmail("helpdesk@coepd.com", strSubject, strMessage);
            //string script = "window.onload = function(){ alert('Account details sent to registered email.'); window.location = '" + Request.Url.AbsoluteUri + "'; }";
            //ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
            #endregion
        }


    }
    protected void ddlReferralBonusInterest_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlReferralBonusInterest.SelectedIndex == 1)
        {

            if (ItemId == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "message()", true);
            }
            lblPaymentType.Visible = true;
            ddlPaymentType.Visible = true;

        }
        else
        {
            lblPaymentType.Visible = false;
            ddlPaymentType.Visible = false;
            ddlPaymentType.SelectedIndex = 0;

            lblGooglepay.Visible = false;
            txtGooglePay.Visible = false;
            lblPaytm.Visible = false;
            txtPaytm.Visible = false;
            lblPhonePay.Visible = false;
            txtPhonePay.Visible = false;
            lblAmazonpay.Visible = false;
            txtAmazonPay.Visible = false;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReferFriendSearch.aspx");
    }
    protected void ddlPaymentType_SelectedIndexChanged(object sender, EventArgs e)
    {

        switch (Convert.ToInt32(ddlPaymentType.SelectedValue))
        {
            case -1:
                lblGooglepay.Visible = false;
                txtGooglePay.Visible = false;
                lblPaytm.Visible = false;
                txtPaytm.Visible = false;
                lblPhonePay.Visible = false;
                txtPhonePay.Visible = false;
                lblAmazonpay.Visible = false;
                txtAmazonPay.Visible = false;
                break;
            case 1:
                lblGooglepay.Visible = true;
                txtGooglePay.Visible = true;

                lblPaytm.Visible = false;
                txtPaytm.Visible = false;
                lblPhonePay.Visible = false;
                txtPhonePay.Visible = false;
                lblAmazonpay.Visible = false;
                txtAmazonPay.Visible = false;
                break;
            case 2:
                lblPaytm.Visible = true;
                txtPaytm.Visible = true;

                lblGooglepay.Visible = false;
                txtGooglePay.Visible = false;
                lblPhonePay.Visible = false;
                txtPhonePay.Visible = false;
                lblAmazonpay.Visible = false;
                txtAmazonPay.Visible = false;
                break;
            case 3:
                lblPhonePay.Visible = true;
                txtPhonePay.Visible = true;

                lblGooglepay.Visible = false;
                txtGooglePay.Visible = false;
                lblPaytm.Visible = false;
                txtPaytm.Visible = false;
                lblAmazonpay.Visible = false;
                txtAmazonPay.Visible = false;
                break;
            case 4:
                lblAmazonpay.Visible = true;
                txtAmazonPay.Visible = true;

                lblGooglepay.Visible = false;
                txtGooglePay.Visible = false;
                lblPaytm.Visible = false;
                txtPaytm.Visible = false;
                lblPhonePay.Visible = false;
                txtPhonePay.Visible = false;
                break;

        }

    }
}