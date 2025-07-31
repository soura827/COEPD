using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_AssignNurturingTaskSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;
    int Total = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        BindData();
        if (!IsPostBack)
        {
            BindNurturingProcessStage();
            BindNurturingProcessStageTask();
            BindData();
        }
    }
    protected void BindData()
    {
        clsAssignNurturingTask obj = new clsAssignNurturingTask();
        if (txtParticipant.Text != "")
            obj.keywords = txtParticipant.Text;
        if (txtLocation.Text != "")
            obj.Location = txtLocation.Text;
        if (ddlNurturingProcessStage.SelectedValue != "")
            obj.NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.Text);
        if (ddlNurturingProcessStageTask.SelectedValue != "")
            obj.NurturingProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.Text);
        //if (txtExam.Text != "")
        //    obj.NurturingProcessStageTaskName = txtExam.Text;
        if (ddlStatus.SelectedValue != "")
            obj.IsApproved = Convert.ToBoolean(ddlStatus.SelectedValue);
        //if (txtEvaluatedBy.Text != "")
            //obj.ApprovedBy = Convert.ToInt32(txtEvaluatedBy.Text);
        if (txtExamScore.Text != "")
            obj.ExamScore = Convert.ToDecimal(txtExamScore.Text);
        if (txtAssignedByName.Text != "")
            obj.Fullname = txtAssignedByName.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }

    protected void BindNurturingProcessStage()
    {
        ddlNurturingProcessStage.Items.Clear();
        clsNurturingProcessStage obj = new clsNurturingProcessStage();
        ddlNurturingProcessStage.DataSource = obj.LoadAll(obj);
        ddlNurturingProcessStage.DataTextField = "NurturingProcessStageName";
        ddlNurturingProcessStage.DataValueField = "NurturingProcessStageId";
        ddlNurturingProcessStage.DataBind();
        ddlNurturingProcessStage.Items.Insert(0, new ListItem("---Select Nurturing Process Stage---", ""));
    }
    protected void BindNurturingProcessStageTask()
    {
        ddlNurturingProcessStageTask.Items.Clear();
        if (ddlNurturingProcessStage.SelectedValue != "")
        {
            clsNurturingProcessStageTask obj = new clsNurturingProcessStageTask();
            obj.NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
            ddlNurturingProcessStageTask.DataSource = obj.LoadAll(obj);
            ddlNurturingProcessStageTask.DataTextField = "NurturingProcessStageTaskName";
            ddlNurturingProcessStageTask.DataValueField = "NurturingProcessStageTaskId";
            ddlNurturingProcessStageTask.DataBind();
        }
        ddlNurturingProcessStageTask.Items.Insert(0, new ListItem("-- Select Nurturing Process Stage Task --", ""));
        gv.DataBind();

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AssignNurturingTask.aspx");
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("AssignNurturingTask.aspx?ItemId=" + e.CommandArgument);
        }
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
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
    protected void gv_PreRender(object sender, EventArgs e)
    {
        int TotalRecords = 0;
        string Records = "";
        TotalRecords = (gv.PageSize * (gv.PageIndex + 1));
        if (TotalRecords > Total)
            Records = Total.ToString();
        else
            Records = TotalRecords.ToString();
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }
    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void txtParticipant_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void txtLocation_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    //protected void txtExam_TextChanged(object sender, EventArgs e)
    //{
    //    BindData();
    //}
    protected void txtEvaluatedBy_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void txtExamScore_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtAssignedByName_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlNurturingProcessStage_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlNurturingProcessStage.SelectedValue != null)
        BindNurturingProcessStageTask();
        BindData();
    }

    protected void ddlNurturingProcessStageTask_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}