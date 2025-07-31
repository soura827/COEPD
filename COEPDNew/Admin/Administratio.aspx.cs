using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Administratio : System.Web.UI.Page
{

    CurrentUser CurrentUser = new CurrentUser();
    clsEmployee Item;

    int Total = 0;
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindLocation();   /*loading location in the drop down list*/
            Item = new clsEmployee();
            Item = Item.Loadfew(CurrentUser.CurrentUserId);
            if (Item.LocationId == 12 || CurrentUser.CurrentEmployeeId == 6349) //* for Global location and also praveena *//
            {
                ddlLocation.Enabled = true;
                BindData();
            }
            else if (Item.LocationId != 12 || Item.EmployeeId != 6349)
            {
                ddlLocation.SelectedValue = Convert.ToString(Item.LocationId);
                ddlLocation.Enabled = false;
                BindData();
            }
            /* binding data in the grid view*/

        }
    }

    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("-- All Locations --", "-1"));
    }


    protected void BindData()
    {


        clsEmployee obj = new clsEmployee();
        obj.IsActive = true;
        obj.DesignationId = 11;
        obj.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);

        List<clsEmployee> employees = obj.LoadAll(obj);

        if (employees != null)
        {
            foreach (var employee in employees)
            {
                if (string.IsNullOrEmpty(employee.CUGMobile))
                {
                    employee.CUGMobile = "Not Assigned";
                }
                if (employee.EmployeeId == 6310)
                {
                    employee.Roles = "Team Lead";
                }
                else
                {
                    employee.Roles = "Team Associate";
                }
            }
        }
        else
        {
            lblMessage.Visible = true;
        }
        gv.DataSource = employees;
        gv.DataBind();



    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dashboard.aspx");
    }



    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

}