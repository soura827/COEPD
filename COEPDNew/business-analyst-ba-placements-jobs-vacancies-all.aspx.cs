using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class business_analyst_ba_placements_jobs_vacancies_all : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindData();
        }

    }
    protected void BindData()
    {
        clsCorporate obj = new clsCorporate();
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }


    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
}