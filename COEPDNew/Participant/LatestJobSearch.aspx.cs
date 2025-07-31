using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class LatestJobSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindJobCategory();
            BindJobDomain();
            BindData();
        }
    }

    protected void BindData()
    {
        clsJob obj = new clsJob();
        obj.JobCategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
        obj.JobDomainId = Convert.ToInt16(ddlJobDomain.SelectedValue);
        List<clsJob> items = obj.LoadLatestJobs(obj);
        if (items != null)
            lblCount.Text = "Latest Jobs:" + items.Count.ToString();
        gv.DataSource = items;
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdView")
        {
            Response.Redirect("Job.aspx?ItemId=" + e.CommandArgument + "&latest=1");
        }
    }
    protected void btnAllJobs_Click(object sender, EventArgs e)
    {
        Response.Redirect("JobSearch.aspx");
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
    protected void BindJobDomain()
    {
        clsJobDomain obj = new clsJobDomain();
        ddlJobDomain.DataSource = obj.LoadAll(obj);
        ddlJobDomain.DataTextField = "JobDomain";
        ddlJobDomain.DataValueField = "JobDomainId";
        ddlJobDomain.DataBind();
        ddlJobDomain.Items.Insert(0, new ListItem("-- Job Domain --", "0"));
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
}