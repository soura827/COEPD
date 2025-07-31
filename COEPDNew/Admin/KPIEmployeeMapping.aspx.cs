using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_KPIEmployeeMapping : System.Web.UI.Page
{
    int ItemId = 0;
    int CountNo = 0;
    clsKPIEmployeeMapping Item;
    CurrentUser CurrentUser = new CurrentUser();
    protected void page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            BindKPI();
            BindEmployee();
            Item = new clsKPIEmployeeMapping();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit KPI Employee Mapping";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlEmployee.SelectedValue = Item.EmployeeId.ToString();
                    ddlKPI.SelectedValue = Item.KPIId.ToString();
                    txtTargetForMonth.Text = Convert.ToString(Item.TargetForMonth);

                }
                btnAdd.Visible = false;
            }
            else
            {
                lblTitle.Text = "Add KPI Employee Mapping";
            }
        }
    }
     protected void BindKPI()
    {
        clsKPI obj = new clsKPI();
        ddlKPI.DataSource = obj.LoadAll(obj);
        ddlKPI.DataTextField = "KPIName";
        ddlKPI.DataValueField = "KPIId";
        ddlKPI.DataBind();
        ddlKPI.Items.Insert(0, new ListItem("-- Select KPI Name --", "0"));
    }
    protected void BindEmployee()
    {
        clsEmployee obj = new clsEmployee();
        ddlEmployee.DataSource = obj.LoadAll(obj);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("--Select Employee --", "0"));
    }
    protected void BindReset()
    {
        ddlEmployee.SelectedIndex = -1;
        ddlKPI.SelectedIndex = -1;
        txtTargetForMonth.Text = "";
    }
    protected void BindCount()
    {
        clsKPIEmployeeMapping obj = new clsKPIEmployeeMapping();
            obj.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
            obj.KPIId = Convert.ToInt32(ddlKPI.SelectedValue);
            CountNo = obj.LoadKPIEmployeeValidation(obj);
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }
        else
        {
            Item = new clsKPIEmployeeMapping();
            if(ItemId>0)
            {
                Item.KPIEmployeeMappingId = Convert.ToInt32(ItemId);
            }
            Item.KPIId = Convert.ToInt32(ddlKPI.SelectedValue);
            Item.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
            Item.TargetForMonth = Convert.ToInt32(txtTargetForMonth.Text);
            Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
            Item.AddUpdate(Item);
            BindReset();
            btnSave.Enabled = false;
            if (ItemId > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
                btnSave.Enabled = false;
            }
        }
       
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("KPIEmployeeMappingSearch.aspx");

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        BindReset();
        btnSave.Enabled = true;
    }

    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }
    }

    protected void ddlKPI_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }
    }
}