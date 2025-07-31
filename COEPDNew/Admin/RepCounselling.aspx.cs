 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_RepCounselling : System.Web.UI.Page
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
            gv.Caption = "Counselling Reports Of " + txtFromDate.Text;
        }
    }


    protected void BindEmployee()
    {
        clsEmployee obj = new clsEmployee();
        ddlEmployee.DataSource = obj.LoadAll(obj);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("-- Select Employee --", "0"));

    }
    protected void BindData()
    {
        clsCounselling obj = new clsCounselling();
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
       
        if (ddlEmployee.SelectedValue != "0")
        {
            gv.Caption = " Counselling Reports Of " + ddlEmployee.SelectedItem + " From " + txtFromDate.Text + " To " + txtToDate.Text;
            gv.DataSource = obj.LoadAllReports(obj);
            gv.DataBind();
        }
        else
        {
            gv.Caption = "Counselling Reports Of " + txtFromDate.Text + " To " + txtToDate.Text;
            gv.DataSource = obj.LoadAllReports(obj);
            gv.DataBind();
        }
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BindData();
    }
}