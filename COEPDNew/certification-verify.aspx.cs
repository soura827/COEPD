using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class certification_verify : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        clsParticipant Participant = new clsParticipant();
        string Mail;
        if (txtEMail.Text == "")
        {
            Mail = null;
        }
        else
        {
            Mail = txtEMail.Text.Trim();
        }
        Participant = Participant.LoadByEmailRefNo(Mail, txtReferenceNo.Text.Trim());
        if (Participant != null)
        {
            ErrorMessage.Visible = false;
            string strMessage = string.Empty;
            strMessage = Participant.Participant + " successfully completed Business Analyst Workshop from COEPD on " + Participant.Batch + ".";
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + strMessage + "');", true);
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "@#$", "alert('" + strMessage + " ');", true);
            //FormMessage.Visible = true;
            //FormMessage.Text = strMessage;
        }
        else
        {
            FormMessage.Visible = false;
            ErrorMessage.Visible = true;
            ErrorMessage.Text = "<span class=color:red>ReferenceNo or Email invalid. Please try again with correct data</span>";
        }
    }
    protected void BtnClear_Click(object sender, EventArgs e)
    {
        txtEMail.Text = "";
        txtReferenceNo.Text = "";
    }
}