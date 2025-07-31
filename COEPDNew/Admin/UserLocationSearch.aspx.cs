using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class UserLocationSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindLocation();
            BindUsers();
            BindData();
        }
    }

    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindUsers()
    {
        clsUserLocation obj = new clsUserLocation();
        if (txtEmployee.Text != "")
            obj.keywords = txtEmployee.Text;
        obj.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        gvUser.DataSource = obj.LoadAllAssigned(obj);
        gvUser.DataBind();
    }

    protected void BindData()
    {
        clsUserLocation obj = new clsUserLocation();
        obj.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
       
    }
    protected void gvUser_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdAdd")
        {
            clsUserLocation Item = new clsUserLocation();
            Item.UserId = Convert.ToInt32(e.CommandArgument);
            Item.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
            Item.AddUpdate(Item);

            BindUsers();
            BindData();

            FormMessage.Text = "Item successfully saved";
            FormMessage.Visible = true;
            ErrorMessage.Visible = false;
        }
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdRemove")
        {
            clsUserLocation Item = new clsUserLocation();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindUsers();
            BindData();
            FormMessage.Visible = false;
            ErrorMessage.Text = "Location successfully removed";
            ErrorMessage.Visible = true;
        }
    }

    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindUsers();
        BindData();
    }


    protected void txtEmployee_TextChanged(object sender, EventArgs e)
    {
        BindUsers();
    }
}