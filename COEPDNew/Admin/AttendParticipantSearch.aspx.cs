using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_AttendParticipantSearch : System.Web.UI.Page
{
    int Total = 0;
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindData();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AttendParticipant.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        DateTime dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        clsAttendParticipant obj = new clsAttendParticipant();
        obj.keywords = txtSearch.Text;
        obj.Date = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null));
        List<clsAttendParticipant> items = obj.LoadAll(obj);
        if (items != null)
            Total = items.Count;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("AttendParticipant.aspx?ItemId=" + e.CommandArgument);
        }  
    }
}