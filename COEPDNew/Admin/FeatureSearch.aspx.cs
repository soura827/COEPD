//This codebehind Page is used Binding all Features in GridView and Search the Employee Features Based on KeyWords.
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class FeatureSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;    
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    // Here it will Bind the All Employee Modules and Features.
    protected void Page_Load(object sender, EventArgs e)
    { 
        //when u click on Add button the perticular ModuleId will bind to ItemId.
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            BindModule();
            BindData();
        }
    }
    //In This Method Binding  All Employee Modules in DropDownList.
    protected void BindModule()
    {
        clsModule obj = new clsModule();
        ddlModule.DataSource = obj.LoadAll(obj);
        ddlModule.DataTextField = "Module";
        ddlModule.DataValueField = "ModuleId";
        ddlModule.DataBind();
        //Here  Select "All" it will Load All Features in GridView and It will return ItemId=0 .
        ddlModule.Items.Insert(0, new ListItem("-- All --", "0"));
        if (ItemId > 0)
        {
            ddlModule.SelectedValue = ItemId.ToString();
        }
    }
    //Here we are select one Employee Module It will display Particular Module Features in GridView.
    protected void ddlModule_SelectedIndexChanged(object sender, EventArgs e)
    {
        ErrorMessage.Visible = false;
        BindData();
    }
    //When u cklick on Add New Button this event will fired and used to create the new Feature.
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Feature.aspx");
    }
    //This event will fired when u click on Find button and search the Feature. 
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    //This method is used to Bind and search by keywords Perticular Module along with features to Employees.
    protected void BindData()
    {
        clsFeature obj = new clsFeature();
        obj.ModuleId = Convert.ToInt16(ddlModule.SelectedValue);
        obj.keywords = txtSearch.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    //This Rowcommand is raised when Clicked on Edit button  in the GridView Control.
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //This Statement Puts the current record in edit mode.
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Feature.aspx?ItemId=" + e.CommandArgument);
        }
        //We are not used this command now as per requirement
        //else if (e.CommandName == "cmdDelete")
        //{
        //    clsFeature Item = new clsFeature();
        //    int ItemId = Convert.ToInt16(e.CommandArgument);
        //    Item.Remove(ItemId);
        //    BindData();
        //    ErrorMessage.Text = "Item successfully removed";
        //    ErrorMessage.Visible = true;
        //}
    }
}