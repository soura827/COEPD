using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class RepTimeSheet : System.Web.UI.Page
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
            BindEmployee();
            DateTime dt;
            dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            txtFromDate.Text = dt.ToString("dd/MM/yyyy");
            txtToDate.Text = dt.ToString("dd/MM/yyyy");
        }
    }

    protected void BindEmployee()
    {
        clsEmployeeMapped Item = new clsEmployeeMapped();
        Item.EmployeeId = CurrentUser.CurrentEmployeeId;
        ddlEmployee.DataSource = Item.Hierarchy(Item);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("-- Select Employees -- ", ""));
        ddlclient.Items.Insert(0, new ListItem("-- Select Client -- ", ""));
        ddlProject.Items.Insert(0, new ListItem("-- Select Project -- ", "0"));
    }

    protected void BindClient()
    {
        ddlclient.Items.Clear();
        if (ddlEmployee.SelectedIndex > 0)
        {
            clsEmpClientAccess Item = new clsEmpClientAccess();
            Item.EmployeeId = Convert.ToInt16(ddlEmployee.SelectedValue);
            ddlclient.DataSource = Item.LoadAll(Item);
            ddlclient.DataTextField = "Client";
            ddlclient.DataValueField = "ClientId";
            ddlclient.DataBind();
            ddlclient.Items.Insert(0, new ListItem("-- Select Client --", "0"));
        }

    }
    protected void BindProject()
    {
        ddlProject.Items.Clear();
        if (ddlclient.SelectedIndex > 0)
        {
            clsProject obj = new clsProject();
            obj.ClientId = Convert.ToInt32(ddlclient.SelectedValue);
            ddlProject.DataSource = obj.LoadAll(obj);
            ddlProject.DataTextField = "Project";
            ddlProject.DataValueField = "ProjectId";
            ddlProject.DataBind();
        }
        ddlProject.Items.Insert(0, new ListItem("-- Select Project -- ", "0"));
    }

    protected void BindData()
    {
        clsTimeSheet obj = new clsTimeSheet();
        obj.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        obj.ClientId = Convert.ToInt32(ddlclient.SelectedValue);
        if (ddlProject.SelectedValue != "0")
        {
            obj.ProjectId = Convert.ToInt32(ddlProject.SelectedValue);

        }
        if (txtFromDate.Text != "")
        {
            obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.FromDate = null;
        }
        if (txtToDate.Text != "")
        {
            obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.ToDate = null;
        }
        gv.DataSource = obj.LoadAllReports(obj);
        gv.DataBind();

        if (ddlEmployee.SelectedValue != "0" && ddlclient.SelectedValue != "0" && ddlProject.SelectedValue != "0")
        {
            gv.Caption = ddlEmployee.SelectedItem + " : Timesheet Reports" + " From " + txtFromDate.Text + " To " + txtToDate.Text;
        }
        else
        {
            gv.Caption = "Coepd Global Associates TimeSheet Reports";
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void btnDownload_Click(object sender, EventArgs e)
    {
        clsTimeSheet obj = new clsTimeSheet();
        ExportToExcel("Employee.xls", gv);
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

    protected void ddlclient_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindProject();
    }

    protected void ddlProject_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindClient();
    }
}



