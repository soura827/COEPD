//This code behind page is used to Display all Participant moduels and to search the Participant modules based on Keywords.
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ParticipantModuleSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    //When page is loading all the Participant modules diplayed in Gridview.
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantModule.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    //This Method is used to  bind Participant  modules to Gridview and Searching Modules Based on input Keywords.
    protected void BindData()
    {
        clsParticipantModule obj = new clsParticipantModule();
        obj.keywords = txtSearch.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    //When click on Edit Button,GridView RowCommand event will fire and edit the perticular Participant Module.
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("ParticipantModule.aspx?ItemId=" + e.CommandArgument);
        }
        //This method is not used now.
        //else if (e.CommandName == "cmdDelete")
        //{
        //    int ItemId = Convert.ToInt16(e.CommandArgument);
        //    clsParticipantModule Item = new clsParticipantModule();
        //    Item.Remove(ItemId);
        //    BindData();
        //    ErrorMessage.Text = "Item successfully removed";
        //    ErrorMessage.Visible = true;
        //}
    }
}