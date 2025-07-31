using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class enrollnow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsEnroll obj = new clsEnroll();
        obj.EmailId = txtEmail.Text;
        obj.Mobile = txtMobile.Text;
        obj.Name = txtName.Text;
        obj.CourseId = 0;
        obj.CreatedBy = 1;
        obj.AddUpdate(obj);

        txtName.Text = "";
        txtMobile.Text = "";
        txtEmail.Text = "";
        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
    }
}