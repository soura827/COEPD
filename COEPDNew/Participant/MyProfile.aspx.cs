using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class MyProfile : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsParticipant Item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsParticipant();
        if (!IsPostBack)
        {
            if (CurrentUser.CurrentParticipantId > 0)
            {
                Item = Item.Load(CurrentUser.CurrentParticipantId);
                if (Item != null)
                {
                    lblParticipant.Text = Item.Participant;
                    lblMobile.Text = Item.Mobile;
                    lblEmail.Text = Item.Email;
                }
            }
        }
    }
    protected void btnChangePwd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ChangePwd.aspx");
    }
}