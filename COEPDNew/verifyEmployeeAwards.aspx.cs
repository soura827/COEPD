using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class verifyEmployeeAwards : System.Web.UI.Page
{
    clsAssignAward ItemId = new clsAssignAward();
    clsAward Item = new clsAward();
    string strMessage = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BindAwards()
    {
        string strAwards = string.Empty;

        List<clsEmployee> Items = new List<clsEmployee>();
        clsEmployee Awards = new clsEmployee();
        if (txtEmail.Text != string.Empty)
            Awards.Email = txtEmail.Text;
        if (txtCertificateId.Text != string.Empty)
            Awards.CertificateId = txtCertificateId.Text;
        Items = Awards.LoadAll_VerifyCertificate(Awards);

        if (Items != null)
        {
            foreach (clsEmployee item in Items)
            {
                //strAwards = strAwards + "&nbsp;" + item.CertificateId + "::&nbsp;&nbsp;";
                strAwards = strAwards + "<ul>" +"<li>" + "&nbsp;" +"<b>"+ item.AwardName + "</b>" + " Certificate ID " + "<b>" + item.CertificateId + "</b>" + " is awarded to Mr. / Ms. " + "<b>" + item.Employee+ "</b>" + " For his/her committment and dedicated efforts for the Month of " + "<b>" + item.IssuedFortheMonth.ToString("MMM yyyy") + "</b>" + ". </li>";

                strAwards = strAwards + "</ul>";
            }

            strAwards = strAwards.Replace("<p>", "");
            strAwards = strAwards.Replace("</p>", "");
            strMessage = strAwards;
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BindAwards();
            
            if (strMessage.Length>0)
            {
                ErrorMessage.Visible = false;
                
                //strMessage = strMessage + " successfully Awarded" + ".";
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + strMessage + "');", true);
            }
            else
            {
                FormMessage.Visible = false;
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "<span class=color:red>Email / Certificate Id  invalid. Please try again with correct Email / Certificate Id.</span>";
            }
      
    }
    protected void Reset()
    {
        txtEmail.Text = "";
        txtCertificateId.Text = "";
        ddlSearchBy.SelectedIndex = -1;
        divCertificate.Visible = false;
        divEmail.Visible = false;
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
       Reset();
    }

    protected void ddlSearchBy_SelectedIndexChanged(object sender, EventArgs e)
    {
        ErrorMessage.Visible = false;
        if (ddlSearchBy.SelectedValue == "1")
        {
            divCertificate.Visible = true;
            divEmail.Visible = false;
            txtEmail.Text = "";
            txtCertificateId.Text = "";

        }
        else if(ddlSearchBy.SelectedValue == "2")
        {
            divCertificate.Visible = false;
            divEmail.Visible = true;
            txtEmail.Text = "";
            txtCertificateId.Text = "";
        }
        else
        {
            Reset();
        }
    }
}