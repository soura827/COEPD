using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_HrProcessSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    //DateTime DateTime;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            //txtFromDate.Text = DateTime.ToString("dd/MM/yyyy");
            //txtToDate.Text = DateTime.ToString("dd/MM/yyyy");
            BindData();
        }
    }
    protected void BindData()
    {
        clsHrProcess obj = new clsHrProcess();
        if (txtParticipate.Text != "")
            obj.Keywords = txtParticipate.Text;
        if (txtLocation.Text != "")
            obj.Location = txtLocation.Text;
        if (txtExam.Text != "")
            obj.HrProcessStageTaskName = txtExam.Text;
        if (ddlStatus.SelectedValue != "")
            obj.IsApproved = Convert.ToBoolean(ddlStatus.SelectedValue);
        if (txtEvaluatedBy.Text != "")
            obj.ApprovedEmployee = txtEvaluatedBy.Text;
        if (txtExamScore.Text != "")
            obj.ExamScore = Convert.ToDecimal(txtExamScore.Text);
        if (txtFromDate.Text != "")
        {
            obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.FromDate = null;
        }
        if (txtToDate.Text != "")
        {
            obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.ToDate = null;
        }
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("HrProcess.aspx?ItemId=" + e.CommandArgument);
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("HrProcess.aspx");
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

                //Removing question and answer column 

                //if (hdnSendFile.Value == "")
                //{
                //    hplSendFile.Visible = false;
                //}

                //if (hdnReplyFile.Value == "")
                //{
                //    hplReplyFile.Visible = false;

                //}
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

    protected void txtParticipate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtLocation_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtExam_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtEvaluatedBy_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtExamScore_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtFromDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtToDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
}