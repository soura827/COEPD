using BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_CoepdEmployeeTreeSearch : System.Web.UI.Page
{
    int Total = 0;
    DateTime DateTime;
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
            BindVerticalHead();


        }

    }

    protected void BindData()      //loading gv
    {
        clsEmployee obj = new clsEmployee();
        obj.IsVerticalHead = true;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void BindVerticalHead()  // loading ddl 1
    {
        clsEmployee obj = new clsEmployee();
        obj.IsVerticalHead = true;
        ddlVerticialHead.DataSource = obj.LoadAll(obj);
        ddlVerticialHead.DataTextField = "Employee";
        ddlVerticialHead.DataValueField = "EmployeeId";
        ddlVerticialHead.DataBind();
        ddlVerticialHead.Items.Insert(0, new ListItem("--Select Vertical Head--", "0"));
    }
    protected void ddlVerticialHead_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindReportingmanagers();     //Loading gv1
        BindReportingManager();       //loading dd2
       

    }
    protected void BindReportingmanagers()    //  loading  gv 1
    {


        clsEmployeeMapped obj = new clsEmployeeMapped();
        if (ddlVerticialHead.SelectedValue != "")
            obj.EmployeeId = Convert.ToInt32(ddlVerticialHead.SelectedValue);
        GridView1.DataSource = obj.ReportingLoadAll(obj);
        GridView1.DataBind();

    }
    protected void BindReportingManager()
    {

        clsEmployeeMapped obj = new clsEmployeeMapped();
        if (ddlVerticialHead.SelectedValue != "")
            obj.EmployeeId = Convert.ToInt32(ddlVerticialHead.SelectedValue);
        ddlReportingManager.DataSource = obj.ReportingLoadAll(obj);
        ddlReportingManager.DataTextField = "Employee";
        ddlReportingManager.DataValueField = "ReportingManagerEmployeeId";
        ddlReportingManager.DataBind();
        ddlReportingManager.Items.Insert(0, new ListItem("--Select Reporting Manager--", "0"));

    }

    protected void ddlReportingManager_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindEmployees();
    }

    protected void BindEmployees()
    {

        if(ddlReportingManager.SelectedValue != "")
        {
            clsEmployeeMapped obj = new clsEmployeeMapped();
            if (ddlReportingManager.SelectedValue != "")
                obj.EmployeeId = Convert.ToInt32(ddlReportingManager.SelectedValue);
            GridView2.DataSource = obj.LoadAll(obj);
            GridView2.DataBind();
        }


    }









}