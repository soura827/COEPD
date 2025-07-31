using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class EmployeeCMS : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsEmployeeCMS Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsEmployeeCMS();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Student CMS Page";
                Item = Item.Load(ItemId);
                txtEmployeeCMSTitle.Text = Item.EmployeeCMSTitle;
                txtEmployeeCMSData.Text = Item.EmployeeCMSContent;
            }
            else
            {
                lblTitle.Text = "Add Student CMS Page";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.EmployeeCMSId = Convert.ToInt16(ItemId);
        }
        Item.EmployeeCMSTitle = txtEmployeeCMSTitle.Text;
        Item.EmployeeCMSContent = txtEmployeeCMSData.Text;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("EmployeeCMSSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("EmployeeCMSSearch.aspx");
    }
}