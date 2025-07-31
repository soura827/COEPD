using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class EnrollSearch : System.Web.UI.Page
{
    CurrentUser currentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindData();
    }
    protected void BindData()
    {
        clsEnroll Obj = new clsEnroll();
        gv.DataSource = Obj.LoadAll(Obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Enroll.aspx?ItemId=" + e.CommandArgument);
        }
        if (e.CommandName == "cmdDelete")
        {
            clsEnroll Obj = new clsEnroll();
            Obj.Remove(Convert.ToInt16(e.CommandArgument));
            BindData();
            ErrorMessage.Text = "IoT enroll successfully removed";
            ErrorMessage.Visible = true;
        }
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
}