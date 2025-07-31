//This codebehind Page is used Display Participant Features in GridView based on selected module
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class FeatureAccessParticipantSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    //When Page Loading Bind all Participant,Modules, Available Features and Asigned Features.
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            if(ItemId>0)
            {
                BindParticipant();
                ddlParticipant.SelectedValue = Convert.ToString(ItemId);
                lblPartcipant.Visible = false;
                txtSearch.Visible = false;
                btnSearch.Visible = false;
            }
            BindParticipantModule();
            BindModuleFeatureUnassign();
            BindgvAssigned(); 
        }
    }
    // Bind All Participants names in to Dropdown based on search keywords
    protected void BindParticipant()
    {       
        ddlParticipant.Items.Clear();
        clsParticipant obj = new clsParticipant();
        obj.keywords = txtSearch.Text;
        if (ItemId > 0)
            obj.ParticipantId = ItemId;
        ddlParticipant.DataSource = obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Participant";
        ddlParticipant.DataValueField = "ParticipantId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant --", "0"));      
    }
    //Bind  Participant Modules in to Dropdown.
    protected void BindParticipantModule()
    {
        clsParticipantModule obj = new clsParticipantModule();
        ddlParticipantModule.DataSource = obj.LoadAll(obj);
        ddlParticipantModule.DataTextField = "Module";
        ddlParticipantModule.DataValueField = "ModuleId";
        ddlParticipantModule.DataBind();		 
    }

    //This Method is  used to returns List of feature of a perticular Module which are  not assigned to given Participant if participant selected in dropdown.
    protected void BindModuleFeatureUnassign()
    {
        if(ddlParticipant.SelectedIndex>0)
        { 
        clsParticipantFeature obj = new clsParticipantFeature();
        obj.ModuleId = Convert.ToInt16(ddlParticipantModule.SelectedValue);
        obj.ParticipantId = Convert.ToInt16(ddlParticipant.SelectedValue);
        gv.DataSource = obj.LoadAllAvilable(obj);
        gv.DataBind();
        }
    }
    //This Method is used to Load All assigned Features to Participant in Gridview if participant selected in dropdown.
    protected void BindgvAssigned()
    {
        if (ddlParticipant.SelectedIndex > 0)
        {
            clsParticipantFeatureAccess obj = new clsParticipantFeatureAccess();
            obj.ModuleId = Convert.ToInt16(ddlParticipantModule.SelectedValue);
            obj.ParticipantId = Convert.ToInt16(ddlParticipant.SelectedValue);
            gvAssign.DataSource = obj.LoadAll(obj);
            gvAssign.DataBind();
        }
    }
    //This event will fire when selecting the Participant Module and Display assigned features in GridView.
    protected void ddlParticipantModule_SelectedIndexChanged(object sender, EventArgs e)
    {
        ErrorMessage.Visible = false;
        if (ddlParticipant.SelectedIndex >0)
        {
            BindgvAssigned();
        }
        BindModuleFeatureUnassign();
    }
    //This method is used to  assigning the feature to participant.
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //This RowCommand will fire when assigning the feature.
        if (e.CommandName == "cmdAdd")
        {
            if (ddlParticipant.SelectedIndex >0)
            {
                clsParticipantFeatureAccess objfature = new clsParticipantFeatureAccess();
                objfature.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
                objfature.FeatureId = Convert.ToInt32(e.CommandArgument);
                objfature.CreatedBy = CurrentUser.CurrentUserId;
                objfature.AddUpdate(objfature);
                BindgvAssigned();
                BindModuleFeatureUnassign();
            }
            else
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Select Participant First";
            }         
        }
    }
    //This method is used to  un-assign the feature to participant.
    protected void gvAssign_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //This RowCommand will fire when un-assigning the feature.
        if (e.CommandName == "cmdRemove")
        {
            if (ddlParticipant.SelectedIndex > 0)
            {
                clsParticipantFeatureAccess objfeature = new clsParticipantFeatureAccess();
                int ItemId = Convert.ToInt32(e.CommandArgument);
                objfeature.FeatureAccessId = ItemId;
                objfeature.CreatedBy = CurrentUser.CurrentUserId;
                objfeature.Remove(objfeature);
                BindgvAssigned();
                BindModuleFeatureUnassign();
            }
            else
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Select Participant First";
            }
        }              
    }
    //This method is used to Redirect the Exam Category Assignment page
    protected void btnGoToExamCategory_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
            Response.Redirect("ExamCategoryAssignmentSearch.aspx?ItemId=" + ItemId);
        else
            Response.Redirect("ExamCategoryAssignmentSearch.aspx");
    }
    //This method executes when user clicks on search button and  
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        ddlParticipant.Items.Clear();
        ErrorMessage.Visible = false;
        gv.Visible = false;
        gvAssign.Visible = false;
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant --", "0"));
        if (txtSearch.Text != "")
        {
            BindParticipant();
        }
        else
        {
            ErrorMessage.Text = "Please enter Participant Name or Mobile No or Email or ReferenceNo";
            ErrorMessage.Visible = true;
        }
    }

    //When selecting Participant in dropdown this event will fire and that perticular Participant Features Dispalay in grid views.
    protected void ddlParticipant_SelectedIndexChanged(object sender, EventArgs e)
    {
        ErrorMessage.Visible = false;
        if (ddlParticipant.SelectedIndex > 0)
        {
            gv.Visible = true;
            gvAssign.Visible = true;
            BindgvAssigned();
            BindModuleFeatureUnassign();            
        }
        else
        {
            gv.Visible = false;
            gvAssign.Visible = false;
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantSearch.aspx");
    }
}