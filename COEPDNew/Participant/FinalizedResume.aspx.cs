using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_FinalizedResume : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsNurturingProcess Item;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsNurturingProcess();
        if(!IsPostBack)
        {
            if(CurrentUser.CurrentParticipantId>0)
            {
                Item = Item.LoadFinalizedResume(CurrentUser.CurrentParticipantId);
                if(Item != null)
                {
                    if (Item.ReceiverImagePath != "")
                    {
                        hplReplyFile.Visible = true;
                        hplReplyFile.NavigateUrl = "~/UserDocs/NurturingProcess/" + Item.ReceiverImagePath;
                    }
                }
                else
                {
                    lblErrorMessage.Visible = true;
                }
            }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dashboard.aspx");
    }
}