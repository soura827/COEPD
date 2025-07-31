using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_RepEmployees : System.Web.UI.Page
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
            BindDesignation();
            BindBranch();
            BindDepartment();
            BindData();
        }
    }

    protected void BindDesignation()
    {
        clsDesignation obj = new clsDesignation();
        ddlDesignation.DataSource = obj.LoadAll(obj);
        ddlDesignation.DataTextField = "Designation";
        ddlDesignation.DataValueField = "DesignationId";
        ddlDesignation.DataBind();
        ddlDesignation.Items.Insert(0, new ListItem("-- All --", "0"));

    }

    protected void ddlDesignation_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindBranch()
    {
        clsBranch obj = new clsBranch();
        ddlBranch.DataSource = obj.LoadAll(obj);
        ddlBranch.DataTextField = "Branch";
        ddlBranch.DataValueField = "BranchId";
        ddlBranch.DataBind();
        ddlBranch.Items.Insert(0, new ListItem("-- All --", "0"));

    }
    protected void ddlBranch_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindDepartment()
    {
        clsDepartment obj = new clsDepartment();
        ddlDepartment.DataSource = obj.LoadAll(obj);
        ddlDepartment.DataTextField = "Department";
        ddlDepartment.DataValueField = "DepartmentId";
        ddlDepartment.DataBind();
        ddlDepartment.Items.Insert(0, new ListItem("-- All --", "0"));

    }
    protected void BindData()
    {
        clsEmployee obj = new clsEmployee();
        obj.DesignationId = Convert.ToInt16(ddlDesignation.SelectedValue);
        obj.BranchId = Convert.ToInt16(ddlBranch.SelectedValue);
        obj.DepartmentId = Convert.ToInt16(ddlDepartment.SelectedValue);
        gv.Caption ="Coepd Global Associates Reports";
        gv.DataSource = obj.LoadAllReports(obj);
        gv.DataBind();
    }
    protected void ExportToExcel(string strFileName, GridView gv)
    {
        Response.ClearContent();
        Response.AddHeader("content-disposition", "attachment; filename=" + strFileName);
        Response.ContentType = "application/excel";
        System.IO.StringWriter sw = new System.IO.StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        gv.RenderControl(htw);
        Response.Write(sw.ToString());
        Response.End();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {

    }

    protected void btnDownload_Click(object sender, EventArgs e)
    {
        ExportToExcel("Employees.xls", gv);
    }



    protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}