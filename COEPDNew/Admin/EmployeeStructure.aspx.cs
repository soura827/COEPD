using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class Admin_EmployeeStructure : System.Web.UI.Page
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
            DropBindEmployees();
            DropBindDesignation();
        }

    }
    protected void ddlDesignation_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddlDesignation.SelectedIndex > 0)
        {
            gvUser.Visible = true;
            rbAssigned.Checked = false;
            rbUnAssigned.Checked = false;

            BindEmployee();
        }
        else
        {
            gvUser.Visible = false;
        }
       
    }
    protected void BindEmployee()
    {
        clsEmployeeStructure obj = new clsEmployeeStructure();
        obj.DesignationId = Convert.ToInt32(ddlDesignation.SelectedValue);
        gvUser.DataSource = obj.LoadAll(obj);
        gvUser.DataBind();

    }

    protected void rbAssigned_CheckedChanged(object sender, EventArgs e)
    {
        ddlDesignation.SelectedIndex = 0;

        
        ddlemployee.SelectedIndex = 0;
        gvUser.Visible = true;


        gv.Visible = false;
        clsEmployeeStructure obj = new clsEmployeeStructure();
        if (rbAssigned.Checked == true)
        {
            obj.IsAssigned = true;
            gvUser.DataSource = obj.LoadAllIsAssigned(obj);
            gvUser.DataBind();
        }

    }
    protected void rbUnAssigned_CheckedChanged(object sender, EventArgs e)
    {
        ddlDesignation.SelectedIndex = 0;
        gvUser.Visible = true;


        ddlemployee.SelectedIndex = 0;
        gv.Visible = false;

        clsEmployeeStructure obj = new clsEmployeeStructure();
        if (rbUnAssigned.Checked == true)
        {
            obj.IsAssigned = false;
            gvUser.DataSource = obj.LoadAllIsAssigned(obj);
            gvUser.DataBind();
        }
    }

    protected void DropBindDesignation()
    {
        clsDesignation obj = new clsDesignation();
        ddlDesignation.DataSource = obj.LoadAll(obj);
        ddlDesignation.DataTextField = "Designation";
        ddlDesignation.DataValueField = "DesignationId";
        ddlDesignation.DataBind();
        ddlDesignation.Items.Insert(0, new ListItem("--Select Designation--", "0"));
    }
    protected void DropBindEmployees()
    {
        clsEmployee obj = new clsEmployee();
        obj.IsReportingManager = true;
        ddlemployee.DataSource = obj.LoadAll(obj);
        ddlemployee.DataTextField = "Employee";
        ddlemployee.DataValueField = "EmployeeId";
        ddlemployee.DataBind();
        ddlemployee.Items.Insert(0, new ListItem("--Select Reporting Manager--", "0"));
    }

    protected void gvUser_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdAdd")
        {
            if (ddlemployee.SelectedIndex > 0)
            {
                clsEmployeeStructure Items = new clsEmployeeStructure();
                Items.EmployeeId = Convert.ToInt16(e.CommandArgument);
                Items.ReportingManagerEmployeeId = Convert.ToInt32(ddlemployee.SelectedValue);
                Items.IsAssigned = true;
                Items.AddUpdate(Items);
                BindEmployee();
                BindData();

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSelection()", true);
            }

        }
    }

    protected void ddlemployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlemployee.SelectedIndex > 0)
        {
            gv.Visible = true;
            BindData();
        }
        else
        {
            gv.Visible = false;
        }
    }


    protected void BindData()
    {
        clsEmployeeStructure obj = new clsEmployeeStructure();
        obj.ReportingManagerEmployeeId = Convert.ToInt32(ddlemployee.SelectedValue);
        obj.IsAssigned = true;
        gv.DataSource = obj.LoadAllRE(obj);
        gv.DataBind();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdRemove")
        {
            clsEmployeeStructure Items = new clsEmployeeStructure();
            Items.EmployeeId = Convert.ToInt16(e.CommandArgument);
            Items.ReportingManagerEmployeeId = Convert.ToInt32('0');
            Items.IsAssigned = false;
            Items.AddUpdate(Items);

            BindEmployee();
            BindData();
        }
    }




}