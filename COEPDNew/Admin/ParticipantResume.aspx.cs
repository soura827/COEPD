using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ParticipantResume : System.Web.UI.Page
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
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsParticipantResume();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Participant Resume";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    hdnParticipantId.Value = Convert.ToString(Item.ParticipantId);
                    if (Item.IsApproved == false)
                    {
                        txtParticipantResume.Text = Item.ParticipantResume;
                    }
                    else
                    {
                        txtParticipantResume.Text = Item.ParticipantResume;
                        txtParticipantResume.ReadOnly = true;
                        btnSubmit.Enabled = false;
                        btnApproved.Enabled = false;
                    }

                }
            }
            else
            {
                lblTitle.Text = "Add Participant Resume";
                hdnParticipantId.Value = Convert.ToString("3357");
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
        Item.ParticipantId = Convert.ToInt16(hdnParticipantId.Value);
        Item.ApprovedBy = 0;
        Item.IsApproved = false;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);

        if (ItemId > 0)
        {
            FormMessage.Text = "Item successfully updated";
            FormMessage.Visible = true;
        }
        else
        {
            btnSubmit.Enabled = false;
            FormMessage.Text = "Item successfully saved";
            FormMessage.Visible = true;
        }

    }

    protected void btnApproved_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.ParticipantResumeId = Convert.ToInt16(ItemId);
        }

        Item.ParticipantResume = Convert.ToString(txtParticipantResume.Text);
        Item.ParticipantId = Convert.ToInt16(hdnParticipantId.Value);
        Item.ApprovedBy = CurrentUser.CurrentUserId;
        Item.IsApproved = true;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);

        if (ItemId > 0)
        {
            FormMessage.Text = "Participant Resume successfully updated";
            FormMessage.Visible = true;
        }
        else
        {
            btnSubmit.Enabled = false;
            FormMessage.Text = "Participant Resume successfully saved";
            FormMessage.Visible = true;
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantResumeSearch.aspx");
    }
}