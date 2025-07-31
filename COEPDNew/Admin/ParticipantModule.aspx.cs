// This code behind page is used to Add and Update the ParticipantModule.

using System;
using System.Web.UI;
using BusinessLayer;
public partial class ParticipantModule : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsParticipantModule Item;
    int ItemId = 0;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        // ItemId value will set when u click on edit the perticular Participant Module.
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsParticipantModule();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {               
                lblTitle.Text = "Edit Participant Module";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtParticipantModule.Text = Item.Module;
                }
            }
            else
            {
                lblTitle.Text = "Add Participant Module";
            }
        }


    }
    //When click on Save button This Event will fire and used to Save the Participant module.
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       
        if (ItemId > 0)
        {
            Item.ModuleId = Convert.ToInt16(ItemId);
        }

        Item.Module = Convert.ToString(txtParticipantModule.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        if (ItemId > 0)
        {
            FormMessage.Text = "Participant Module successfully updated";
            FormMessage.Visible = true;
            btnSubmit.Enabled = false;
        }
        else
        {
            
            FormMessage.Text = "Participant Module successfully created";
            FormMessage.Visible = true;
            btnSubmit.Enabled = false;
            txtParticipantModule.Text = null;
        }
     
    }

    //This button click  event is not used now.
    //protected void btnAddNew_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("ParticipantModule.aspx");
    //}

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantModuleSearch.aspx");
    }
}