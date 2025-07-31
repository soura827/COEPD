using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class EmployeeMappingSearch : System.Web.UI.Page
{
    string CS = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindUnAssignedEmployeeList();
            BindReportingManager();
          
        }
    }

    protected void ddlemployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        BindData();
        BindUnAssignedEmployeeList();
    }

    protected void BindUnAssignedEmployeeList()          
    {
        clsEmployeeMapped obj = new clsEmployeeMapped();
        if (txtSearchEmployee.Text != "")
            obj.keywords = txtSearchEmployee.Text;

        obj.IsReportingManager = false;
        obj.IsVerticalHead = false;
        obj.IsReportingTo = false;
        gvUser.DataSource = obj.UnAssignedEmployeeList(obj);
        gvUser.DataBind();
    }

    protected void gvUser_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (ddlemployee.SelectedValue == "0")
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSelectReportingmanager()", true);
        }
        else
        {
            if (e.CommandName == "cmdAdd")
            {
                clsEmployeeMapped Item = new clsEmployeeMapped();
                Item.EmployeeId = Convert.ToInt32(e.CommandArgument);
                Item.ParentEmployeeId = Convert.ToInt32(ddlemployee.SelectedValue);
                Item.IsAssigned = true;
                Item.CreatedBy = CurrentUser.CurrentUserId;
                Item.AddUpdate(Item);


                BindUnAssignedEmployeeList();
                BindData();
            }
        }

    }

    protected void txtSearchEmployee_TextChanged(object sender, EventArgs e)   //when ever to know the unassigned employee we can search through this
    {
        BindUnAssignedEmployeeList();
    }

    protected void BindReportingManager()
    {

        ddlemployee.ClearSelection();
       
        SqlConnection sqlconn = new SqlConnection(CS);
        sqlconn.Open();
        SqlCommand con = new SqlCommand("select * from [dbo].[tblEmployee] where IsReportingManager =" + 1, sqlconn);
        con.CommandType = CommandType.Text;
        ddlemployee.DataSource = con.ExecuteReader();
        ddlemployee.DataTextField = "Employee";
        ddlemployee.DataValueField = "EmployeeId";
        ddlemployee.DataBind();
        ddlemployee.Items.Insert(0, new ListItem("-- Select ReportingManager --", "0"));
        sqlconn.Close();

    }

    protected void BindData()
    {
        clsEmployeeMapped obj = new clsEmployeeMapped();
        obj.EmployeeId = Convert.ToInt32(ddlemployee.SelectedValue);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdRemove")
        {
            clsEmployeeMapped Item = new clsEmployeeMapped();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);

            BindData();
            BindUnAssignedEmployeeList();
        }
    }

}