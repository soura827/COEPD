using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_GSuitAssign : System.Web.UI.Page
{
    public string Constr = ConfigurationManager.ConnectionStrings["Inventory"].ConnectionString.ToString();
    CurrentUser CurrentUser = new CurrentUser();
    clsGSuitAssign obj = new clsGSuitAssign();
    int ItemId = 0;
    clsGSuitAssign Item = new clsGSuitAssign();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            BindEmployee();
            BindEmail();
            if(ItemId > 0)
            {
                txtEmail.Enabled = false;
                txtEmployee.Enabled = false;
                btnUnAssign.Visible = true;
                ddlEmail.Enabled = false;
                ddlEmployee.Enabled = false;
                BindEmployee();
                lblTitle.Text = "Edit GSuit Email Details";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlEmail.SelectedValue = Convert.ToString(Item.GSuitEmailId);
                    ddlEmployee.SelectedValue = Convert.ToString(Item.EmployeeId);
                    if (ddlEmployee.SelectedValue != "")
                        BindData();
                    txtPurpose.Text = Item.Purpose.ToString();
                    txtRemarks.Text = Item.Remarks;
                }
            }
            else
            {
                lblTitle.Text = "Assign Email To Employees";
                btnAssign.Visible = true;
            }
        }
    }

    protected void BindData()
    {
        if (ddlEmployee.SelectedValue != "")
            obj.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        obj.IsEmailUnAssigned = false;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void BindEmployee()
    {
        ddlEmployee.Items.Clear();
        clsEmployee obj = new clsEmployee();
        if (txtEmployee.Text != "")
            obj.keywords = txtEmployee.Text;
        ddlEmployee.DataSource = obj.LoadAll(obj);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        if (ddlEmployee.Items.Count == 0)
        {
            ddlEmployee.Items.Insert(0, new ListItem("--- Employee not Match - Try Another Employee ---", ""));
        }

        else
        {
            ddlEmployee.Items.Insert(0, new ListItem("--- Select Employee ---", ""));

        }
    }
    protected void BindEmail()
    {
        ddlEmail.Items.Clear();
        clsGSuit obj = new clsGSuit();
        if (txtEmail.Text != "")
            obj.GSuitEmail = txtEmail.Text;
        obj.IsCreated = true;
        if (ItemId > 0)
            obj.IsEmailAssigned = true;
        else
            obj.IsEmailAssigned = false;
        ddlEmail.DataSource = obj.LoadAll(obj);
        ddlEmail.DataTextField = "GSuitEmail";
        ddlEmail.DataValueField = "GSuitEmailId";
        ddlEmail.DataBind();
        if (ddlEmail.Items.Count == 0)
        {
            ddlEmail.Items.Insert(0, new ListItem("--- EmailId not Match - Try Another EmailId ---", ""));
        }

        else
        {
            ddlEmail.Items.Insert(0, new ListItem("--- Select Email ---", ""));

        }
    }
    protected void txtEmail_TextChanged(object sender, EventArgs e)
    {
        BindEmail();
    }

    protected void txtEmployee_TextChanged(object sender, EventArgs e)
    {
        BindEmployee();
    }

    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void btnAssign_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
            obj.GSuitEmailAssignId = ItemId;
        obj.GSuitEmailId = Convert.ToInt32(ddlEmail.SelectedValue);
        obj.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        obj.Purpose = Convert.ToString(txtPurpose.Text);
        obj.Remarks = Convert.ToString(txtRemarks.Text);
        obj.CreatedBy = CurrentUser.CurrentUserId;
        obj.AddUpdate(obj);
        Response.Redirect("GSuitAssignSearch.aspx");
    }

    protected void btnUnAssign_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
            obj.GSuitEmailAssignId = ItemId;
        obj.Purpose = Convert.ToString(txtPurpose.Text);
        obj.GSuitEmailId = Convert.ToInt32(ddlEmail.SelectedValue);
        obj.IsEmailUnAssigned = true;
        obj.Remarks = Convert.ToString(txtRemarks.Text);
        obj.CreatedBy = CurrentUser.CurrentUserId;
        obj.AddUpdate(obj);
        Response.Redirect("GSuitAssignSearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("GSuitAssignSearch.aspx");
    }
}