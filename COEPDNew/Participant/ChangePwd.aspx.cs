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
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsUser();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Item.UserId = Convert.ToInt32(CurrentUser.CurrentUserId);
        Item.Pwd = Convert.ToString(txtOldPassword.Text);
        Item.NewPwd = Convert.ToString(txtNewPassword.Text);
        outmsg = Item.ChangePassword(Item);

        if (outmsg.Contains("Invalid") == true)
        {
            ErrorMessage.Text = "Invalid password";
            ErrorMessage.Visible = true;
            FormMessage.Visible = false;
        }
        else
        {
            FormMessage.Text = "Password saved successfully";
            FormMessage.Visible = true;
            ErrorMessage.Visible = false;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dashboard.aspx");
    }
}