using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_MentoringTeam : System.Web.UI.Page
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
                BindData2();
                BindData();
                BindData1();
            }
            else if (Item.LocationId != 12 || Item.EmployeeId != 6349)
            {
                ddlLocation.SelectedValue = Convert.ToString(Item.LocationId);
                ddlLocation.Enabled = false;
                BindData2();
                BindData();
                BindData1();
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
        obj.DesignationId = 3;
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
                if (employee.EmployeeId == 2234)
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




    protected void BindData2()
    {
        clsEmployee obj = new clsEmployee();
        obj.IsActive = true;
        obj.DesignationId = 2;
        List<clsEmployee> employees = obj.LoadAll(obj);
        obj.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);

        if (employees != null)
        {

            foreach (var employee in employees)
            {

                if (employee.EmployeeId == 2)
                {
                    employee.Roles = "Reporting Manager";
                }
                else
                {
                    employee.Roles = "Team Associate";
                }
            }

            List<clsEmployee> filteredEmployees = employees.Where(e => e.Roles != "Team Associate").ToList();

            if (filteredEmployees.Count > 0)
            {

                obj.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);


                if (obj.LocationId == 1)
                {

                    Gv3.DataSource = filteredEmployees;
                    Gv3.DataBind();
                }
                else
                {
                    Gv3.DataSource = null;
                    Gv3.DataBind();
                    lblMessage.Visible = true;
                }
            }
            else
            {
                Gv3.DataSource = null;
                //Gv3.DataBind();
                lblMessage.Visible = true;
            }

        }

    }


    protected void BindData1()
    {
        clsEmployee obj = new clsEmployee();
        obj.IsActive = true;
        obj.DesignationId = 3;
        obj.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);

        List<clsEmployee> employees = obj.LoadAll(obj);

        if (employees != null)
        {

            foreach (var employee in employees)
            {

                if (employee.EmployeeId == 2234)
                {
                    employee.Roles = "Team Lead";
                }
                else
                {
                    employee.Roles = "Team Associate";
                }
            }


            List<clsEmployee> filteredEmployees = employees.Where(e => e.Roles != "Team Associate").ToList();

            if (filteredEmployees.Count > 0)
            {
                Gv2.DataSource = filteredEmployees;
                Gv2.DataBind();
            }
            else
            {
                Gv2.DataSource = null;
                Gv2.DataBind();
                lblMessage.Visible = true;
            }
        }
        else
        {
            Gv2.DataSource = null;
            Gv2.DataBind();
            lblMessage.Visible = true;
        }

    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dashboard.aspx");

    }



    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData2();
        BindData();
        BindData1();
    }

}