 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Configuration;

public partial class Admin_CUGSimAssign : System.Web.UI.Page
{
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    CurrentUser CurrentUser = new CurrentUser();
    clsCUGSimAssign obj = new clsCUGSimAssign();
    
    int ItemId = 0;
    clsCUGSimAssign Item = new clsCUGSimAssign();
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
            BindMobile();
            if (ItemId > 0)
            {
                txtCUGSimMobile.Enabled = false;
                txtEmployee.Enabled= false;
                btnUnAssign.Visible = true;
                ddlMobile.Enabled = false;
                ddlEmployee.Enabled = false;
                txtAadharNumber.Enabled = false;
                BindEmployee();
                lblTitle.Text = "Edit Mobile Number Details";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlMobile.SelectedValue = Convert.ToString(Item.CUGSimId);
                    ddlEmployee.SelectedValue = Convert.ToString(Item.EmployeeId);
                    if(ddlEmployee.SelectedValue !="")
                        BindData();
                    txtSimUsedFor.Text = Item.SimUsedFor.ToString();
                    txtAadharNumber.Text = Item.AadharNumber;
                    txtRemarks.Text = Item.Remarks;
                }
                
            }
            else
            {
                lblTitle.Text = "Assign Mobile Number To Employees";
                btnAssign.Visible = true;

            }
        }
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
            //ddlEmployee.Items[0].Attributes.Add("style", "background-color:red");
        }

        else
        {
            ddlEmployee.Items.Insert(0, new ListItem("--- Select Employee ---", ""));

        }
    }
    protected void BindMobile()
    {
        ddlMobile.Items.Clear();
        clsCUGSim obj = new clsCUGSim();
        if (txtCUGSimMobile.Text != "")
            obj.Mobile = txtCUGSimMobile.Text;
        obj.IsActivated = true;
        if (ItemId > 0)
            obj.IsSimAssigned = true;
        else
            obj.IsSimAssigned = false;
        ddlMobile.DataSource = obj.LoadAll(obj);
        ddlMobile.DataTextField = "Mobile";
        ddlMobile.DataValueField = "CUGSimId";
        ddlMobile.DataBind();
        if (ddlMobile.Items.Count == 0)
        {
            ddlMobile.Items.Insert(0, new ListItem("--- Mobile Number not Match - Try Another Number ---", ""));
            //ddlMobile.Items[0].Attributes.Add("style", "background-color:red");
        }

        else
        {
            ddlMobile.Items.Insert(0, new ListItem("--- Select Mobile ---", ""));

        }
    }
    protected void BindData()
    {
        if (ddlEmployee.SelectedValue != "")
            obj.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        obj.IsSimUnAssigned = false;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void txtEmployee_TextChanged(object sender, EventArgs e)
    {
        BindEmployee();
    }


    protected void txtCUGSimMobile_TextChanged(object sender, EventArgs e)
    {
        BindMobile();
    }

    protected void btnAssign_Click(object sender, EventArgs e)
    {
        if(ItemId>0)
            obj.CUGSimAssignId = ItemId;
        obj.CUGSimId = Convert.ToInt32(ddlMobile.SelectedValue);
        obj.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        obj.SimUsedFor = Convert.ToString(txtSimUsedFor.Text);
        obj.AadharNumber = Convert.ToString(txtAadharNumber.Text);
        obj.Remarks = Convert.ToString(txtRemarks.Text);
        obj.CreatedBy = CurrentUser.CurrentUserId;
        obj.AddUpdate(obj);
        Response.Redirect("CUGSimAssignSearch.aspx");
    }
    protected void btnUnAssign_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
            obj.CUGSimAssignId = ItemId;
        obj.SimUsedFor = Convert.ToString(txtSimUsedFor.Text);
        obj.CUGSimId= Convert.ToInt32(ddlMobile.SelectedValue);
        obj.IsSimUnAssigned = true;
        obj.Remarks = Convert.ToString(txtRemarks.Text);
        obj.CreatedBy = CurrentUser.CurrentUserId;
        obj.AddUpdate(obj);
        Response.Redirect("CUGSimAssignSearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CUGSimAssignSearch.aspx");
    }




    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}