using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Default : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsUser obj = new clsUser();
        obj.Username = Convert.ToString(txtUserName.Text);
        obj.Pwd = Convert.ToString(txtPassword.Text);
        obj = obj.CheckValidate(obj);
        if (obj != null)
        {
            if (obj.RoleId == 3)
            {
                CurrentUser.CurrentUserId = Convert.ToInt16(obj.UserId);
                CurrentUser.UserBranchId = Convert.ToInt16(obj.BranchId);
                CurrentUser.CurrentUsername = obj.Username;
                CurrentUser.CurrentName = obj.Fullname;
                CurrentUser.CurrentParticipantId = Convert.ToInt16(obj.ParticipantId);
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid Username/password";
            }
        }
        else
        {
            lblMessage.Text = "Invalid Username/password";
        }
    }
}