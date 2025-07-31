using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ParticipantPlacementAssistanceDataSheetSearchAdmin : System.Web.UI.Page
{

    int Total = 0;
    DateTime DateTime;


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
        clsParticipantPlacementAssistanceDataSheet obj = new clsParticipantPlacementAssistanceDataSheet();
        if (CurrentUser.CurrentEmployeeId > 0)
        {
            if (txtParticipate.Text.Length > 0)
            {
                obj.Keywords = txtParticipate.Text;
            }
            //if (txtParticipate.Text != "")
            //    obj.Keywords = txtParticipate.Text;
            if (txtProfileOwner.Text != "")
                obj.ProfileOwnerKeywords = txtProfileOwner.Text;

            if (txtTotalExperience.Text != "")
                obj.TotalExperience = Convert.ToInt32(txtTotalExperience.Text);
            if (txtRelevantExperiance.Text != "")
                obj.RelevantExperience = Convert.ToInt32(txtRelevantExperiance.Text);

            if (txtLocation.Text != "")
                obj.PreferredLocations = txtLocation.Text;

            if (txtJobExperienceDomain.Text != "")
                obj.JobExperienceDomain = txtJobExperienceDomain.Text;

            if (txtJobExperienceDomain.Text != "")
                obj.JobExperienceDomain = txtJobExperienceDomain.Text;

            if (ddlStatus.SelectedValue != "")
            {

                obj.IsDataSheetApproved = Convert.ToBoolean(ddlStatus.SelectedValue);
            }
            if (rbActive.Checked)              
            {
                obj.IsSubscriptionExpired = true;
            }
            else
            {
                obj.IsSubscriptionExpired = false;
            }

          
            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();
        }
        else
        {
            Response.Redirect("~/Login.html");
        }

    }
    protected void btnDownload_Click(object sender, EventArgs e)
    {
        string FileNamePrepix = string.Empty;
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        FileNamePrepix = DateTime.ToString("dd-MM-yyyy - hh mm tt");
        ExportToExcel(FileNamePrepix + "-ParticipantPlacementAssistanceDataSheet.xls", gv);
    }
    protected void ExportToExcel(string strFileName, GridView gv)
    {
        Response.ClearContent();
        Response.AddHeader("content-disposition", "attachment; filename=" + strFileName);
        Response.ContentType = "application/excel";
        StringWriter SW = new StringWriter();
        HtmlTextWriter HTW = new HtmlTextWriter(SW);
        //gv.RenderControl(HTW);
        gv.RenderControl(HTW);
        Response.Write(SW.ToString());
        Response.End();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("ParticipantPlacementAssistanceDataSheet.aspx?ItemId=" + e.CommandArgument + "&Admin=1");
        }
        else if (e.CommandName == "cmdProfileOwner")
        {
            Response.Redirect("AssignProfileOwnerToParticipant.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdChangeProfileOwner")
        {
            Response.Redirect("AssignProfileOwnerToParticipant.aspx?ItemId=" + e.CommandArgument);
        }
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.DataItem != null)
            {
                HiddenField hdnPassportSizePhotoFile = (HiddenField)e.Row.FindControl("hdnPassportSizePhotoFile");
                HiddenField hdnAadharFrontFile = (HiddenField)e.Row.FindControl("hdnAadharFrontFile");
                HiddenField hdnAadharBackFile = (HiddenField)e.Row.FindControl("hdnAadharBackFile");
                HiddenField hdnSalarySlipFile = (HiddenField)e.Row.FindControl("hdnSalarySlipFile");
                HiddenField hdnServiceFormFile = (HiddenField)e.Row.FindControl("hdnServiceFormFile");

                HyperLink hplPassportSizePhotoFile = (HyperLink)e.Row.FindControl("hplPassportSizePhotoFile");
                HyperLink hplAadharFrontFile = (HyperLink)e.Row.FindControl("hplAadharFrontFile");
                HyperLink hplAadharBackFile = (HyperLink)e.Row.FindControl("hplAadharBackFile");
                HyperLink hplSalarySlipFile = (HyperLink)e.Row.FindControl("hplSalarySlipFile");
                HyperLink hplServiceFormFile = (HyperLink)e.Row.FindControl("hplServiceFormFile");


                if (hdnPassportSizePhotoFile.Value == "")
                    hplPassportSizePhotoFile.Visible = false;
                if (hdnAadharFrontFile.Value == "")
                    hplAadharFrontFile.Visible = false;
                if (hdnAadharBackFile.Value == "")
                    hplAadharBackFile.Visible = false;
                if (hdnSalarySlipFile.Value == "")
                    hplSalarySlipFile.Visible = false;
                if (hdnServiceFormFile.Value == "")
                    hplServiceFormFile.Visible = false;
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
    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void Unnamed_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void txtTotalExperience_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtRelevantExperiance_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtJobExperienceDomain_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtJobExpectedDomain_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
           server control at run time. */
    }


    protected void txtLocation_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void rbActive_CheckedChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void rbDeleted_CheckedChanged(object sender, EventArgs e)
    {
        BindData();
    }
}