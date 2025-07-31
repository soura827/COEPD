using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_NurtureDashboardSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int NurturingProcessStageId = 0;
    int ParticipantId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ParticipantId = Convert.ToInt32(Request.QueryString["ItemId"]);
        NurturingProcessStageId = Convert.ToInt32(Request.QueryString["NPSI"]);
        if (!IsPostBack)
        {
            BindData();
        }
    }
    protected void BindData()
    {
        clsNurturingProcess obj = new clsNurturingProcess();
        if (NurturingProcessStageId != 0)
            obj.NurturingProcessStageId = NurturingProcessStageId;
        if (ParticipantId != 0)
            obj.ParticipantId = ParticipantId;
        //if (txtExam.Text != "")
        //    obj.NurturingProcessStageTaskName = txtExam.Text;
        if (ddlStatus.SelectedValue != "")
            obj.IsApproved = Convert.ToBoolean(ddlStatus.SelectedValue);
        //if (txtEvaluatedBy.Text != "")
        //    obj.ApprovedEmployee = txtEvaluatedBy.Text;
        //if (txtExamScore.Text != "")
        //    obj.ExamScore = Convert.ToDecimal(txtExamScore.Text);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("NurturingProcess.aspx?ItemId=" + e.CommandArgument);
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingProcess.aspx");
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.DataItem != null)
            {
                HiddenField hdnSendFile = (HiddenField)e.Row.FindControl("hdnSendFile");
                HiddenField hdnReplyFile = (HiddenField)e.Row.FindControl("hdnReplyFile");
                HyperLink hplSendFile = (HyperLink)e.Row.FindControl("hplSendFile");
                HyperLink hplReplyFile = (HyperLink)e.Row.FindControl("hplReplyFile");

                if (hdnSendFile.Value == "")
                {
                    hplSendFile.Visible = false;
                }

                if (hdnReplyFile.Value == "")
                {
                    hplReplyFile.Visible = false;
                }
            }
        }
    }

    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void gv_PreRender(object sender, EventArgs e)
    {
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureDashboard.aspx?ItemId=" + ParticipantId);
    }

    //protected void txtParticipate_TextChanged(object sender, EventArgs e)
    //{
    //    BindData();
    //}

    //protected void txtLocation_TextChanged(object sender, EventArgs e)
    //{
    //    BindData();
    //}

    //protected void txtExam_TextChanged(object sender, EventArgs e)
    //{
    //    BindData();
    //}

    //protected void txtEvaluatedBy_TextChanged(object sender, EventArgs e)
    //{
    //    BindData();
    //}

    //protected void txtExamScore_TextChanged(object sender, EventArgs e)
    //{
    //    BindData();
    //}
}