//This code behind Page is used to Add and Update the Participant Features.
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ParticipantFeature : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsParticipantFeature Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    //This Page_Load Event will fire When page is loading and editing.
    protected void Page_Load(object sender, EventArgs e)
    {
        // ItemId value will set when u click on edit the perticular Participant Feature.
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsParticipantFeature();
        if (!IsPostBack)
        {
            BindParticipantModule();
            if (ItemId > 0)
            {
                if (Item != null)
                {

                    lblTitle.Text = "Edit Participant Feature";
                    Item = Item.Load(ItemId);
                    if (Item != null)
                    {
                        ddlParticipantModule.SelectedValue = Item.ModuleId.ToString();
                        txtParticipantFeature.Text = Item.Feature;
                        txtParticipantPageName.Text = Item.PageName;
                        ddlParticipantModule.Enabled = false;
                    }
                }
            }

            else
            {
                lblTitle.Text = "Add Participant Feature";


            }
        }
    }

    //This method is used to Bind the Participant module along with Features.
    protected void BindParticipantModule()
    {
        clsParticipantModule obj = new clsParticipantModule();
        ddlParticipantModule.DataSource = obj.LoadAll(obj);
        ddlParticipantModule.DataTextField = "Module";
        ddlParticipantModule.DataValueField = "ModuleId";
        ddlParticipantModule.DataBind();
        ddlParticipantModule.Items.Insert(0, new ListItem("-- SELECT --", ""));
    }

    //This Button click event will fired when saving the features. 
    //When u are saving the feature along with the Module the perticular Moduleid set To ItenmId.
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (ItemId > 0)
        {
            Item.FeatureId = Convert.ToInt16(ItemId);
        }

        Item.ModuleId = Convert.ToInt16(ddlParticipantModule.SelectedValue);
        Item.Feature = Convert.ToString(txtParticipantFeature.Text);
        Item.PageName = Convert.ToString(txtParticipantPageName.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);

        if (ItemId > 0)
        {
            FormMessage.Text = "Participant Feature successfully updated";
            FormMessage.Visible = true;
            btnSubmit.Enabled = false;
        }
        else
        {
            
            FormMessage.Text = "Participant Feature successfully created";
            FormMessage.Visible = true;
            btnSubmit.Enabled = false;
        }
       // Response.Redirect("ParticipantFeatureSearch.aspx?ItemId=" + Item.ModuleId);

    }
    // This event will fired when  click on Back to list button 
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantFeatureSearch.aspx");
    }
}



