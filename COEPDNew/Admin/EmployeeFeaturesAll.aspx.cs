using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_EmployeeFeaturesAll : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindEmployee();
            BindFeatures();
            //BindModule();
            BindLocation();
            BindDesgination();
        }

    }

    protected void BindEmployee()
    {
        clsEmployee obj = new clsEmployee();
        ddlEmployee.DataSource = obj.LoadAll(obj);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("-- All --", "0"));
    }


    protected void BindFeatures()
    {
        clsFeature obj = new clsFeature();
        ddlFeature.DataSource = obj.LoadAll(obj);
        ddlFeature.DataTextField = "Feature";
        ddlFeature.DataValueField = "FeatureId";
        ddlFeature.DataBind();
        ddlFeature.Items.Insert(0, new ListItem("-- Select Feature --", "0"));
    }
    protected void BindDesgination()
    {
       clsDesignation obj= new clsDesignation();
        ddldesignation.DataSource = obj.LoadAll(obj);
        ddldesignation.DataTextField = "Designation";
        ddldesignation.DataValueField = "DesignationId";
        ddldesignation.DataBind();
        ddldesignation.Items.Insert(0, new ListItem("-- Select Designation --", "0"));
    }
    protected void BindLocation()
    {
      clsLocation obj = new clsLocation();  
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("-- Select Location --", "0"));
    }

    protected void BindgvAssigned()
    {
        clsFeatureAccess obj = new clsFeatureAccess();
        //obj.ModuleId = Convert.ToInt16(ddlModule.SelectedValue);
        obj.EmployeeId = Convert.ToInt16(ddlEmployee.SelectedValue);
        if (ddlLocation.SelectedValue != null)
        {
            obj.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
        }
        if (ddldesignation.SelectedValue!=null)
        {
            obj.DesignationId = Convert.ToInt32(ddldesignation.SelectedValue);
        }
        if (ddlFeature.SelectedValue != null)
        {
            obj.FeatureId =Convert.ToInt32( ddlFeature.SelectedValue);
        }
        gvAssign.DataSource = obj.LoadAll(obj);
        gvAssign.DataBind();
    }
    protected void gvAssign_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdRemove")
        {
            if (ddlEmployee.SelectedIndex > 0)
            {
                clsFeatureAccess objfeature = new clsFeatureAccess();
                objfeature.Remove(Convert.ToInt32(e.CommandArgument));
                BindgvAssigned();
            }
            else
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Select Employee First";
            }
        }
    }

    protected void btnBackToFeatureAccess_Click(object sender, EventArgs e)
    {
        Response.Redirect("FeatureAccessSearch.aspx");
    }

    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlEmployee.SelectedIndex > 0)
        {
            BindgvAssigned();
        }
    }

    protected void ddlFeature_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindgvAssigned();

    }

 
    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindgvAssigned();

    }




    protected void ddldesignation_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindgvAssigned();
    }
}