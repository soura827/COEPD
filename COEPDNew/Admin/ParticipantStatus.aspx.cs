using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class ParticipantStatus : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsParticipantStatus Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsParticipantStatus();
        if (!IsPostBack)
        {
          
         
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Participant Status";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtParticipantStatus.Text = Item.ParticipantStatus;
                }
            }
            else
            {
                lblTitle.Text = "Add New Participant Status";
            }
        }
    }
    

    

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (ItemId > 0)
        {
            Item.ParticipantStatusId = Convert.ToInt16(ItemId);
        }
        Item.ParticipantStatus = txtParticipantStatus.Text;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        if (ItemId > 0)
        {
            FormMessage.Text = "Participant Status successfully updated";
            FormMessage.Visible = true;
        }
        else
        {
            btnSubmit.Enabled = false;
            FormMessage.Text = "Participant Status successfully saved";
            FormMessage.Visible = true;
        }

    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStatus.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStatusSearch.aspx");
    }
}