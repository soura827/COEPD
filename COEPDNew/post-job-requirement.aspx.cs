using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class post_job_requirement : System.Web.UI.Page
{
    
    string message;
    clsJobRequirement Item;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            // Calendar1.Visible = false;
            //DateTime dateTime;
            //dateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            //txtExpiry.Text = dateTime.ToString("dd/MM/yyyy");
            
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Item = new clsJobRequirement();

        Item.CompanyName = txtCompanyName.Text;
        Item.ContactPerson = txtPerson.Text;
        Item.EmailId = txtEmail.Text;
        Item.Mobile = txtMobile.Text;
        Item.JobDescription = txtDescription.Text;
        Item.KeySkills = txtSkills.Text;
        Item.AvailableTimings = txtContact.Text;
        Item.Location = txtLocation.Text;
        Item.JobRole = txtRole.Text;
        if (txtExpiry.Text != "")
        {
         message += "From : " + txtExpiry.Text + " ";
        Item.ExpiryDate = Convert.ToString(DateTime.ParseExact(txtExpiry.Text, "dd/MM/yyyy", null));
           
        }
        else
        {
           Item.ExpiryDate = null;
            
        }
        Item.YearsOfExp = txtExp.Text;
        Item.IsActive = true;
        Item.CreatedBy = 1;
        Item.AddUpdate(Item);
        txtCompanyName.Text = "";
        txtPerson.Text = "";
        txtContact.Text = "";
        txtEmail.Text = "";
        txtMobile.Text = "";
        txtDescription.Text = "";
        txtSkills.Text = "";
        txtContact.Text = "";
        txtLocation.Text = ""; ;
        txtRole.Text = "";
        txtExp.Text = "";
        txtExpiry.Text = "";
        string strMessage = string.Empty;
        strMessage = "Thank you. Your job requirement has been posted successfully. Our HR Executive will contact you shortly.";
        ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + strMessage + "');", true);
     

    }

    //protected void txtimg_Click(object sender, ImageClickEventArgs e)
    //{

    //    if (Calendar1.Visible)
    //    {
    //        Calendar1.Visible = false;
    //    }
    //    else
    //    {
    //        Calendar1.Visible = true;
    //    }
    //}

    //protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    //{
    //    if (Calendar1.SelectedDate >= System.DateTime.Today)
    //    {
    //        txtExpiry.Text = Calendar1.SelectedDate.ToShortDateString();
    //        Calendar1.Visible = false;

    //    }
    //    else
    //    {
    //        ClientScript.RegisterStartupScript(this.GetType(), "Popup", "warn();", true);
    //    }

    //}


}