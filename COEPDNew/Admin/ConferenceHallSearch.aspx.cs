using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLayer;
using System.Web.Services;
public partial class ConferenceHallSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        clsConferenceHall obj = new clsConferenceHall();
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("ConferenceHall.aspx");
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName == "cmdEdit")
        {
            Response.Redirect("ConferenceHall.aspx?ItemId=" + e.CommandArgument);
        }
    }
}