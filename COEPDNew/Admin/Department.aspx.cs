using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Department : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsDepartment Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsDepartment();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Department";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtDepartment.Text = Item.Department;
                }
            }
            else
            {
                lblTitle.Text = "Add Department";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.DepartmentId = Convert.ToInt16(ItemId);
        }
        Item.Department = Convert.ToString(txtDepartment.Text);
        Item.CreatedBy = 1;
        Item.AddUpdate(Item);
        if (ItemId > 0)
        {
            FormMessage.Text = "Department successfully updated";
            FormMessage.Visible = true;
        }
        else
        {
            btnSubmit.Enabled = false;
            FormMessage.Text = "Department successfully saved";
            FormMessage.Visible = true;
        }
    }
    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Department.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DepartmentSearch.aspx");
    }
}