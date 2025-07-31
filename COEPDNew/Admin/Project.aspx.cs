using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Project : System.Web.UI.Page
{
    clsProject Item;
    int ItemId = 0;
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsProject();

        if (!IsPostBack)
        {
            bindClients();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Project";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtProject.Text = Item.Project;
                    txtDescription.Text = Item.Description;
                    ddlClient.SelectedValue = Item.ClientId.ToString();
                }
            }
            else
            {
                lblTitle.Text = "Add New Project";
            }
        }
    }



    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.ProjectId = Convert.ToInt16(ItemId);
        }

        Item.ClientId = Convert.ToInt32(ddlClient.SelectedValue.ToString());
        Item.Project = Convert.ToString(txtProject.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("ProjectSearch.aspx");
    }

    protected void bindClients()
    {
        clsClient obj = new clsClient();
        ddlClient.DataSource = obj.LoadAll(obj);
        ddlClient.DataTextField = "Client";
        ddlClient.DataValueField = "ClientId";
        ddlClient.DataBind();
        ddlClient.Items.Insert(0, new ListItem("-- Select --", ""));
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProjectSearch.aspx");
    }

}