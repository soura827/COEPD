using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_ResumesReviewSearch : System.Web.UI.Page
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
        if (e.CommandName == "cmdApprove")
        {
            Response.Redirect("ResumeReview.aspx?ItemId=" + e.CommandArgument);
        }
        if (e.CommandName == "cmdSendResumes")
        {
            Response.Redirect("ResumeReview.aspx?ItemId=" + e.CommandArgument);
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

        if (e.CommandName == "cmdSentResume")
        {
            Response.Redirect("ResumesReviewSearch.aspx" + "#");
        }
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        int ItemId = 0;
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.DataItem != null)
            {
                HiddenField hdnApprove = (HiddenField)e.Row.FindControl("hdnApprove");
                HiddenField hdnResumePrepId = (HiddenField)e.Row.FindControl("HdnResumePrepId");
                ItemId = Convert.ToInt32(hdnResumePrepId.Value.Trim());
                LinkButton lnkApproveFile = (LinkButton)e.Row.FindControl("lnkApprove");
                LinkButton lnkSendResume = (LinkButton)e.Row.FindControl("lnkSendResumes");
                LinkButton lnkSentResume = (LinkButton)e.Row.FindControl("lnkSentResumes");

                clsResumePreparation obj = new clsResumePreparation();
                obj = obj.LoadById(ItemId);
                if (obj.ResumeStatus == true)
                {
                    lnkApproveFile.Visible = false;
                }
                if (obj.SampleResumeReceive == true && obj.SampleResumeRequest == true)
                {

                    lnkSendResume.Visible = true;
                    lnkSentResume.Visible = false;

                }
                else
                {
                    lnkSendResume.Visible = false;
                    lnkSentResume.Visible = true;
                    lnkSentResume.Text = "Not Required";
                    lnkSentResume.BackColor = System.Drawing.Color.Red;
                }

                if (obj.SampleResumeReceive == false && obj.SampleResumeRequest == true)
                {
                    lnkSendResume.Visible = false;
                    lnkSentResume.Visible = true;
                    lnkSentResume.Text = "Sent";
                    lnkSentResume.BackColor = System.Drawing.Color.DeepSkyBlue;
                }
            }
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
}