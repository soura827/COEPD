using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class Admin_Demo : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsDemo Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsDemo();
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            BindEmployee();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Demo";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlEmployee.Text = Convert.ToString(Item.DemoTrainerName);
                    txtDateTime.Text = Convert.ToString(Item.DemoDateTime);
                 
                }
            }
            else
            {
                lblTitle.Text = "Add Demo";
            }
        }
    }
    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        ddlEmployee.Items.Clear();
        ddlEmployee.Items.Insert(0, new ListItem("-- Select Trainer -- ", ""));
        if (txtSearch.Text != "")
        {
            BindEmployee();
        }
    }
    protected void BindEmployee()
    {
        ddlEmployee.Items.Clear();
        clsEmployee obj = new clsEmployee();
        if (txtSearch.Text != null)
            obj.keywords = txtSearch.Text;
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



    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.DemoId = Convert.ToInt16(ItemId);
        }
        Item.DemoTrainerName = Convert.ToInt32(ddlEmployee.SelectedValue);
        Item.DemoDateTime = Convert.ToDateTime(txtDateTime.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        txtSearch.Text = "";
        ddlEmployee.Items.Clear();
        txtDateTime.Text = "";



        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DemoSearch.aspx");
    }
}