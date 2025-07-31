using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_RepGuestVisits : System.Web.UI.Page
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
            BindData();
            DateTime dateTime;
            dateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            txtFromDate.Text = dateTime.ToString("dd/MM/yyyy");
            txtToDate.Text = dateTime.ToString("dd/MM/yyyy");
            gv.Caption = "Visitor Reports on " + txtFromDate.Text;
        }
    }
    protected void BindEmployee()
    {
        clsEmployee obj = new clsEmployee();
        ddlEmployee.DataSource = obj.LoadAll(obj);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("--ALL Employee--", "0"));

    }
    protected void BindData()
    {
        clsRegister obj = new clsRegister();
        obj.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
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
        obj.RegisterTypeId = 1;
        if (ddlEmployee.SelectedValue != "0")
        {
            gv.Caption = " Visitor Reports of " + ddlEmployee.SelectedItem + " From " + txtFromDate.Text + " To " + txtToDate.Text;
            gv.DataSource = obj.LoadAllGuestReports(obj);
            gv.DataBind();
        }
        else
        {
            gv.Caption = "Visitor Reports on " + txtFromDate.Text + " To " + txtToDate.Text; 
            gv.DataSource = obj.LoadAllGuestReports(obj);
            gv.DataBind();
        }
    }
    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BindData();
    }

}