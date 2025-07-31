using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_HrShortlistedResumes : System.Web.UI.Page
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
        obj.HrStatus = true;
        gv.DataSource = obj.LoadAllHR(obj);
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
            Response.Redirect("HrViewShortlistResume.aspx?ItemId=" + e.CommandArgument);
        }
        if (e.CommandName == "cmdSendQustn")
        {
            Response.Redirect("HrViewShortlistResume.aspx?ItemId=" + e.CommandArgument);
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
        if (e.CommandName == "cmdSent")
        {
            Response.Redirect("HrShortlistedResumes.aspx" + "#");
        }
    }
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        int ItemId = 0;
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.DataItem != null)
            {
                HiddenField hdnShortlist = (HiddenField)e.Row.FindControl("hdnShortlist");
                HiddenField hdnResumePrepId = (HiddenField)e.Row.FindControl("HdnResumePrepId");
                ItemId = Convert.ToInt32(hdnResumePrepId.Value.Trim());
                LinkButton lnkSendQuestions = (LinkButton)e.Row.FindControl("lnkSendQuestions");
                LinkButton lnkSentQuestions = (LinkButton)e.Row.FindControl("lnkSentQuestions");
                clsResumePreparation obj = new clsResumePreparation();
                obj = obj.LoadById(ItemId);
                if (obj.InterviewQuestionRequest == true && obj.InterviewQuestionReceive == true)
                {
                    lnkSendQuestions.Visible = true;
                    lnkSentQuestions.Visible = false;
                }
                else
                {
                    lnkSendQuestions.Visible = false;
                    lnkSentQuestions.Visible = true;
                    lnkSentQuestions.Text = "Not Required";
                    lnkSentQuestions.BackColor = System.Drawing.Color.Red;
                }
                if (obj.InterviewQuestionRequest == true && obj.InterviewQuestionReceive == false)
                {
                    lnkSendQuestions.Visible = false;
                    lnkSentQuestions.Visible = true;
                    lnkSentQuestions.Text = "Sent";
                    lnkSentQuestions.BackColor = System.Drawing.Color.DeepSkyBlue;
                }               
            }
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
}