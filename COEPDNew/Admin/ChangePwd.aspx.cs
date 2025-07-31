using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ChangePwd : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsUser Item;
    string outmsg = null;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsUser();
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            BindEmployee();
        }
    }
    protected void BindEmployee()
    {

        clsEmployee obj = new clsEmployee();
        ddlLeadOwner.DataSource = obj.LoadAll(obj);
        ddlLeadOwner.DataTextField = "Employee";
        ddlLeadOwner.DataValueField = "EmployeeId";
        ddlLeadOwner.DataBind();
        ddlLeadOwner.Items.Insert(0, new ListItem("Search by Employee", ""));
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsEmployee obj = new clsEmployee();
        if (ItemId > 0)
        {
            obj.EmployeeId = Convert.ToInt32(ItemId);
        }
        obj.EmployeeId = Convert.ToInt32(ddlLeadOwner.SelectedValue);
        //Item.EmployeeId = Convert.ToInt32(ddlLeadOwner.SelectedValue);
        Item.Pwd = Convert.ToString(txtOldPassword.Text);
        Item.NewPwd = Convert.ToString(txtNewPassword.Text);
        Item.Description = txtDescription.Text;
        outmsg = Item.ChangePassword(Item);
        if (outmsg.Contains("Invalid") == true)
        {
        ErrorMessage.Text = "Invalid current password";
            ErrorMessage.Visible = true;
        }
        else
        {
            txtOldPassword.Text = "";
            txtNewPassword.Text = "";
            FormMessage.Text = "Password successfully updated";
            FormMessage.Visible = true;
        }
    }

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        if (txtSearch.Text != "")
        {
            BindEmployee();
        }
    }

    protected void ddlLeadOwner_TextChanged(object sender, EventArgs e)
    {
        
    }
}