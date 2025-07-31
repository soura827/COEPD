using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_StatisticsReportSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsStatistics obj = new clsStatistics();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
     {
        if (!IsPostBack)
        {           
            BindStatistics();
        }
    }

    //protected void btnAdd_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("StatisticsReport.aspx");
        
    //}
    protected void BindStatistics()
    {
        clsStatistics obj = new clsStatistics();        
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("StatisticsReport.aspx?ItemId=" + e.CommandArgument);
        }
    }
}