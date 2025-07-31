using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ClientAccess : System.Web.UI.Page
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
        }
        ErrorMessage.Visible = false;
    }
    protected void BindEmployee()
    {
        clsEmployee obj = new clsEmployee();
        ddlEmployee.DataSource = obj.LoadAll(obj);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("-- Select Employee --", ""));
    }
    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlEmployee.SelectedIndex > 0)
        {       
            BindgvAssign();
            BindData();
        }
        else
        {
            ErrorMessage.Text = "Please select an employee";
            ErrorMessage.Visible = true;
            gv.DataBind();
            gvAssign.DataBind();
        }
    }
    protected void BindData()
    {
        clsClient obj = new clsClient();
        obj.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        gv.DataSource = obj.LoadAllAvailable(obj);
        gv.DataBind();
    }
    protected void BindgvAssign()
    {
        clsEmpClientAccess obj = new clsEmpClientAccess();
        obj.EmployeeId = Convert.ToInt16(ddlEmployee.SelectedValue);
        gvAssign.DataSource = obj.LoadAll(obj);
        gvAssign.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName== "cmdAdd")
        {
            clsEmpClientAccess objProject = new clsEmpClientAccess();
            objProject.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
            objProject.ClientId = Convert.ToInt32(e.CommandArgument);
            objProject.CreatedBy = CurrentUser.CurrentUserId;
            objProject.AddUpdate(objProject);
            BindgvAssign();
            BindData();
        }
    }
    protected void gvAssign_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdRemove")
        {
            clsEmpClientAccess objProject = new clsEmpClientAccess();
            objProject.Remove(Convert.ToInt32( e.CommandArgument));
            BindgvAssign();
            BindData();
        }
    }
}