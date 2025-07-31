using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_ResumesApprovedSearch : System.Web.UI.Page
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
            BindData();
        }
    }
    protected void BindData()
    {
        clsResumePreparation obj = new clsResumePreparation();
        obj.keywords = txtSearch.Text;
        obj.ResumeStatus = true;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();

    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdView")
        {
            Response.Redirect("ResumeApproved.aspx?ItemId=" + e.CommandArgument);
        }
       
        else if (e.CommandName == "cmdDownload")
        {
            clsResumePreparation obj = new clsResumePreparation();
            if (e.CommandArgument != null)
            {
                string FilePath = Server.MapPath("~/UserDocs/ResumePreparation/" + e.CommandArgument);
                Response.ContentType = "application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + System.IO.Path.GetFileName(FilePath));
                Response.TransmitFile(FilePath);
            }

        }

       
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
}