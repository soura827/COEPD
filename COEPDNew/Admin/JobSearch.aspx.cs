using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class JobSearch : System.Web.UI.Page
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
    protected void BindJobCategory()
    {
        clsJobCategory obj = new clsJobCategory();
        ddlCategory.DataSource = obj.LoadAll(obj);
        ddlCategory.DataTextField = "JobCategory";
        ddlCategory.DataValueField = "JobCategoryId";
        ddlCategory.DataBind();
        ddlCategory.Items.Insert(0, new ListItem("-- All Categories --", "0"));
    }
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
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
    protected void ddlJobDomain_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Job.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        clsJob obj = new clsJob();
        obj.JobCategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
        obj.JobDomainId = Convert.ToInt16(ddlJobDomain.SelectedValue);
        if (txtSearch.Text.Length > 0)
        {
            obj.keywords = txtSearch.Text;
        }
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Job.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsJob Item = new clsJob();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Job successfully removed";
            ErrorMessage.Visible = true;
        }
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //This Command is used to disable Delete option for associates and enable for only Admin.
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (CurrentUser.CurrentEmployeeId == 2 || CurrentUser.CurrentEmployeeId == 1)
            {
                LinkButton lnk = (LinkButton)e.Row.FindControl("lnkDelete");
                lnk.Visible = true;
            }
            else
            {
                LinkButton lnk = (LinkButton)e.Row.FindControl("lnkDelete");
                lnk.Visible = false;
            }
        }
    }
}