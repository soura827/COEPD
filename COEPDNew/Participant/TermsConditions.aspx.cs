using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_TermsConditions : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsEmployeeCMS Item;
    clsTermsAcceptedParticipants item;
    int itemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        itemId = Convert.ToInt16(Request.QueryString["itemId"]);
        item = new clsTermsAcceptedParticipants();
        if (!IsPostBack)
        {
            if (itemId > 0)
            {
                item = item.Load(itemId);
                if (item != null)
                {

                    if (item.IsTermsAccepted == true)
                    {
                        chkTermsAccepted.Checked = true;
                    }
                    else
                    {
                        chkTermsAccepted.Checked = false;
                    }
                }
            }
            else
            {

            }
        }

        btnSubmit.Visible = false;
        if (chkTermsAccepted.Checked == true)
        {
            btnSubmit.Visible = true;
        }
        Item = new clsEmployeeCMS();
        Item = Item.Load(3);
        if (Item != null)
        {
            lblTitle.Text = Convert.ToString(Item.EmployeeCMSTitle);
            lilcontent.Text = Convert.ToString(Item.EmployeeCMSContent);
        }

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (itemId > 0)
        {
            item.TermsAcceptedParticipantsId = Convert.ToInt16(itemId);
        }
        item.ParticipantId = Convert.ToInt32(CurrentUser.CurrentParticipantId);
        if (chkTermsAccepted.Checked == true)
        {
            item.IsTermsAccepted = true;
        }
        else
        {
            item.IsTermsAccepted = false;
        }

        item.CreatedBy = CurrentUser.CurrentUserId;
        item.AddUpdate(item);
        Response.Redirect("Dashboard.aspx");
    }
}