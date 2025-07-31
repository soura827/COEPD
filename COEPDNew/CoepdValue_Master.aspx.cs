using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CoepdValue_Master : System.Web.UI.Page
{
    //string Title, USP1, USP2, USP3, USP4, USP5, USP6, USP7, USP8, USP9, USP10;
    //bool ismobilerequired, isemailrequired, isspecificenquiryrequired;
    int CountNo = 0;
    //int Offer;
    DateTime DateTime;
    //int CreatedBy;
    //string FullName;
    //string OwnerEmail;
    //string FilePath;

    //clsCampaign ItemCampaign = new clsCampaign();
    clsValue ItemLead = new clsValue();
    clsUser ItemUser = new clsUser();
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        //txtLocation.Text = "Hyderbad";
    }
    //protected void BindMobileCount()
    //{
    //    clsValue obj = new clsValue();
    //   // obj.MobileNo = Convert.ToString(txtTelephone.Text);
    //    CountNo = obj.LoadCoepdValueMobileValidation(obj);
    //}
    //protected void BindEmailCount()
    //{
    //    clsValue obj = new clsValue();
    //   // obj.EmailId = Convert.ToString(txtEmail.Text);
    //    CountNo = obj.LoadCoepdValueEmailValidation(obj);

    //}
    //protected void btnSubmit_Click(object sender, EventArgs e)
    //{
    //    btnSubmit.Enabled = false;

    //    ItemLead.Name = txtName.Text;

    //    ItemLead.EmailId = txtEmail.Text;

    //    ItemLead.MobileNo = txtTelephone.Text;

    //    ItemLead.Location = txtLocation.Text;

    //    ItemLead.Date = DateTime;

    //    ItemLead.SpecificEnquiry = txtSpecEnq.Text;
    //    //ItemLead.Title = ItemCampaign.Title;
    //    ItemLead.AddUpdate(ItemLead);

  

    //}

    //protected void txtEmail_TextChanged(object sender, EventArgs e)
    //{
    //    BindEmailCount();
    //    if (CountNo > 0)
    //    {
    //        txtEmail.Text = "";
    //        ErrorMessage.Text = "Your email already registered with us.";
    //        ErrorMessage.Visible = true;
    //    }
    //    else
    //    {
    //        ErrorMessage.Visible = false;
    //    }
    //}

    //protected void txtTelephone_TextChanged(object sender, EventArgs e)
    //{
    //    BindMobileCount();
    //    if (CountNo > 0)
    //    {
    //        txtTelephone.Text = "";
    //        ErrorMessage.Text = "Your Mobile number already registered with us.";
    //        ErrorMessage.Visible = true;
    //    }
    //    else
    //    {
    //        ErrorMessage.Visible = false;
    //    }
    //}

    //protected void Button1_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("https://www.coepd.com/CoepdValue_Hyderbad.html");
    //}

    //protected void Button2_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("https://www.coepd.com/CoepdValue_Chennai.html");
    //}

    //protected void Button3_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("https://www.coepd.com/CoepdValue_Pune.html");
    //}

    //protected void Button4_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("https://www.coepd.com/CoepdValue_Mumbai.html");
    //}

    //protected void Button5_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("https://www.coepd.com/CoepdValue_Visakhapatnam.html");
    //}

    //protected void Button6_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("https://www.coepd.com/CoepdValue_Banglore.html");
    //}

    //protected void Button7_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("https://www.coepd.com/CoepdValue_Delhi.html");
    //}
}