using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class business_analyst_jobopenings : System.Web.UI.Page
{
    int ItemId = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);

        if (!IsPostBack)
        {
            BindJobCategory();
            BindData();
        }
    }
    protected void BindJobCategory()
    {
        clsJobCategory obj = new clsJobCategory();
        ddlCategory.DataSource = obj.LoadAll(obj);
        ddlCategory.DataTextField = "JobCategory";
        ddlCategory.DataValueField = "JobCategoryId";
        ddlCategory.DataBind();
        ddlCategory.Items.Insert(0, new ListItem("-- All Categories --", "0"));
    }
    protected void BindData()
    {
        clsJob obj = new clsJob();
        obj.JobCategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
        //DateTime dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        //obj.JobDate = dt;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        clsJob obj = new clsJob();
        obj.JobCategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
        DateTime dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        obj.JobDate = dt;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void BtnAll_Click(object sender, EventArgs e)
    {
        clsJob obj = new clsJob();
        obj.JobCategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
}