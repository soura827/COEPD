using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_LocationOffice : System.Web.UI.Page
{
    int ItemId = 0;
    clsLocationOffice item = new clsLocationOffice();
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            BindLocation();
            if (ItemId > 0)
            {

                lblTitle.Text = "Edit Location Office";
                item = item.Load(ItemId);
                if (item != null)
                {


                    ddlLocation.SelectedValue = Convert.ToString(item.LocationId);
                    txtLocationOffice.Text = Convert.ToString(item.LocationOffice);

                }
            }
            else
            {
                lblTitle.Text = "Add Location Office";

            }
        }
    }
    protected void BindLocation()
    {
        clsLocation item = new clsLocation();
        ddlLocation.DataSource = item.LoadAll(item);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("---Please select Location---", ""));
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(ItemId>0)
        {
            item.LocationOfficeId = Convert.ToInt16(ItemId);
           
        }
        item.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
        item.LocationOffice = Convert.ToString(txtLocationOffice.Text);
        item.CreatedBy = CurrentUser.CurrentUserId;
        item.AddUpdate(item);
        ddlLocation.SelectedIndex = -1;
        txtLocationOffice.Text = "";
        if (ItemId > 0)
        {
            FormMessage.Text = "Office successfully updated";
            FormMessage.Visible = true;
        }
        else
        {
            btnSubmit.Enabled = false;
            FormMessage.Text = "Office successfully saved";
            FormMessage.Visible = true;
        }

    }
    protected void btnBackToList_Click(object sender, EventArgs e)
    {
        Response.Redirect("LocationOfficeSearch.aspx");
    }
}