using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_AssignAward : System.Web.UI.Page
{
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId= 0;
    clsAssignAward Item = new clsAssignAward();
    int Count = 0;

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
            BindAward();           
            if (ItemId > 0)
            {
                BindEmployee();
                BindAward();               
                lblTitle.Text = "Edit Award Details";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlEmployee.SelectedValue = Convert.ToString(Item.EmployeeId);                   
                    ddlAward.SelectedValue = Convert.ToString(Item.AwardId);
                    txtCertificateId.Text = Item.CertificateId;
                    txtDateOfIssued.Text = (Item.DateOfIssued).ToString("dd/MM/yyyy");
                    txtIssuedFortheMonth.Text = (Item.IssuedFortheMonth).ToString("dd/MM/yyyy");
                }
            }
            else
            {
                lblTitle.Text = "Assign Award To Employees";
            }
            
        }
    }

    protected void BindEmployee()
    {        
        clsEmployee obj = new clsEmployee();
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

    protected void BindAward()
    {
        clsAward obj = new clsAward();
        ddlAward.DataSource = obj.LoadAll(obj);
        ddlAward.DataTextField = "AwardName";
        ddlAward.DataValueField = "AwardId";
        ddlAward.DataBind();
        if(ddlAward.Items.Count == 0)
        {
            ddlAward.Items.Insert(0, new ListItem("Not Match", ""));
        }
        else
        {
            ddlAward.Items.Insert(0, new ListItem("Select Award", ""));
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
            Item.AssignAwardId = ItemId;
        if (ddlEmployee.SelectedValue != "")
            Item.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        if (ddlAward.SelectedValue != "")
            Item.AwardId = Convert.ToInt32(ddlAward.SelectedValue);
        Item.CertificateId = txtCertificateId.Text;
        if (txtDateOfIssued.Text != "")
        {
            DateTime Date = DateTime.ParseExact(txtDateOfIssued.Text, "dd/MM/yyyy", null);
            Item.DateOfIssued = Convert.ToDateTime(Date);
        }
        if (txtIssuedFortheMonth.Text != "")
        {
            DateTime Date = DateTime.ParseExact(txtIssuedFortheMonth.Text, "dd/MM/yyyy", null);
            Item.IssuedFortheMonth = Convert.ToDateTime(Date);
        }
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("AssignAwardSearch.aspx");
    }
    

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AssignAwardSearch.aspx");
    }

    protected void BindValidation() 
    {
        Item.CertificateId = Convert.ToString(txtCertificateId.Text);
        Count = Item.LoadAssignAwardValidation(Item); 
    }

    protected void txtCertificateId_TextChanged(object sender, EventArgs e)
    {
        BindValidation();
        if(Count > 0)
        {
            txtCertificateId.Text = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }
    }
}