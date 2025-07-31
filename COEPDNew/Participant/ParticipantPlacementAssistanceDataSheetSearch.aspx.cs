using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_ParticipantPlacementAssistanceDataSheetSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int CountNo = 0;
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
        if(CurrentUser.CurrentParticipantId>0)
        {
            clsParticipantPlacementAssistanceDataSheet obj = new clsParticipantPlacementAssistanceDataSheet();
            obj.ParticipantId = CurrentUser.CurrentParticipantId;
            if (ddlStatus.SelectedValue != "")
                obj.IsDataSheetApproved = Convert.ToBoolean(ddlStatus.SelectedValue);
            gv.DataSource = obj.LoadForAll(obj);
            gv.DataBind();
            CountNo=obj.LoadParticipantPlacementAssistanceDataSheetValidation(obj);
            if(CountNo>0)
            {
                btnAdd.Visible = false;
            }
            else
            {
                btnAdd.Visible = true;
            }
        }
        else
        {
            Response.Redirect("~/Login.html");
        }
        
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("ParticipantPlacementAssistanceDataSheet.aspx?itemId=" + e.CommandArgument);
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
                    hdnSalarySlipFile.Visible = false;
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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantPlacementAssistanceDataSheet.aspx");
    }

    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}