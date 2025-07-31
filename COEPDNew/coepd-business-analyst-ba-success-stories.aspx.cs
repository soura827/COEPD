using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class coepd_business_analyst_ba_success_stories : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    protected void BindData()
    {
        clsSuccessStories obj = new clsSuccessStories();
        obj.IsFeatured = true;
        dl.DataSource = obj.LoadAll(obj);
        dl.DataBind();
    }
}