using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Resume : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsParticipantResume Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsParticipantResume();
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    if (Item.IsApproved == false)
                    {
                        txtParticipantResume.Text = Item.ParticipantResume;
                    }
                    else
                    {
                        txtParticipantResume.Text = Item.ParticipantResume;
                    }
                }
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.ParticipantResumeId = Convert.ToInt16(ItemId);
        }
        Item.ParticipantResume = Convert.ToString(txtParticipantResume.Text);
        Item.ParticipantId = Convert.ToInt16(CurrentUser.CurrentParticipantId);
        Item.ApprovedBy = 0;
        Item.IsApproved = false;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingSearch.aspx");
    }
}