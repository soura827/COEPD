//This code behind Page is used to Add and Update the Employee Features.
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Feature : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsFeature Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    //This Page_Load Event will fire When page is loading and editing. 
    protected void Page_Load(object sender, EventArgs e)
    {
        // ItemId value will set when u click on edit the perticular Employee Feature.
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsFeature();
        if (!IsPostBack)
        {
            BindModule();
            if (ItemId > 0)
            {
                if (Item != null)
                {
                    lblTitle.Text = "Edit Employee Feature";
                    Item = Item.Load(ItemId);
                    if (Item != null)
                    {
                        ddlModule.SelectedValue = Item.ModuleId.ToString();                                     
                        txtFeature.Text = Item.Feature;
                        txtPageName.Text = Item.PageName;
                        ddlModule.Enabled = false;
                    }
                }
            }

            else
            {
                lblTitle.Text = "Add Employee Feature";
            }
        }
    }
    //This method is used to Bind the Employee module along with Features.
    protected void BindModule()
    {
        clsModule obj = new clsModule();
        ddlModule.DataSource = obj.LoadAll(obj);
        ddlModule.DataTextField = "Module";
        ddlModule.DataValueField = "ModuleId";
        ddlModule.DataBind();
        ddlModule.Items.Insert(0, new ListItem("-- SELECT --", ""));
    }
    //This Button click event will fired when saving the features. 
    //When u are saving the feature along with the Module the perticular Moduleid set To ItemId.
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.FeatureId = Convert.ToInt16(ItemId);
        }
        Item.ModuleId = Convert.ToInt16(ddlModule.SelectedValue);
        Item.Feature = Convert.ToString(txtFeature.Text);
        Item.PageName = Convert.ToString(txtPageName.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        if (ItemId > 0)
        {
            FormMessage.Text = "Employee Feature successfully updated";
            FormMessage.Visible = true;
            btnSubmit.Enabled = false;
        }
        else
        {
            FormMessage.Text = "Employee Feature successfully created";
            FormMessage.Visible = true;
            btnSubmit.Enabled = false;
        }
        //Response.Redirect("FeatureSearch.aspx?ItemId=" + Item.ModuleId);
    }
    // This event will fired when  click on Back to list button  
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("FeatureSearch.aspx");
    }
}