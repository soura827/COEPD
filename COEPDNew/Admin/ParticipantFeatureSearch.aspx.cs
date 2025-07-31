//This codebehind Page is used Binding all Features in GridView and Search the Participant  Features Based on KeyWords.
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ParticipantFeatureSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    // Here it will Bind the All  Participant Modules and Features.
    protected void Page_Load(object sender, EventArgs e)
    {
        //when u click on Add button the perticular ModuleId will bind to ItemId.
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);

        if (!IsPostBack)
        {
            BindParticipantModule();
            BindData();
        }
    }
    //In This Method Binding  All Participant Modules in DropDownList.
    protected void BindParticipantModule()
    {
        clsParticipantModule obj = new clsParticipantModule();
        ddlParticipantModule.DataSource = obj.LoadAll(obj);
        ddlParticipantModule.DataTextField = "Module";
        ddlParticipantModule.DataValueField = "ModuleId";
        ddlParticipantModule.DataBind();
        ddlParticipantModule.Items.Insert(0, new ListItem("-- All --", "0"));
       
        if (ItemId > 0)
        {
            ddlParticipantModule.SelectedValue = ItemId.ToString();
        }
    }

    //Here we are select one Participant Module It will display Particular Module Features in GridView.

    protected void ddlParticipantModule_SelectedIndexChanged(object sender, EventArgs e)
    {
        ErrorMessage.Visible = false;
        BindData();
    }
    //When u cklick on Add New Button this event will fired and used to create the new Feature.

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantFeature.aspx");
    }

    //This event will fired when u click on Find button and search the Feature. 
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    //This method is used to Bind and search by keywords Perticular Module along with features to Employees.
    protected void BindData()
    {
        clsParticipantFeature obj = new clsParticipantFeature();
        obj.ModuleId = Convert.ToInt16(ddlParticipantModule.SelectedValue);
        obj.keywords = txtSearch.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }

    //This Rowcommand is raised when Clicked on Edit button  in the GridView Control.
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("ParticipantFeature.aspx?ItemId=" + e.CommandArgument);
        }
        //We are not using this command now as per requirement
        //else if (e.CommandName == "cmdDelete")
        //{
        //    clsParticipantFeature Item = new clsParticipantFeature();
        //    int ItemId = Convert.ToInt16(e.CommandArgument);
        //    Item.Remove(ItemId);
        //    BindData();
        //    ErrorMessage.Text = "Item successfully removed";
        //    ErrorMessage.Visible = true;
        //}
    }


}