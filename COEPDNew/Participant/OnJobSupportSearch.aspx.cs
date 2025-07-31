using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_OnJobSupportSearch : System.Web.UI.Page
{
    int Total = 0;
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
    private void BindData()
    {
        clsOnJobSupport obj = new clsOnJobSupport();

        if (txtLocation.Text != "")
            obj.Location = txtLocation.Text;
        if (ddlStatus.SelectedValue != null)
            obj.IsApproved = Convert.ToBoolean(ddlStatus.SelectedValue);
        if (txtProject.Text != "")
            obj.Project = txtProject.Text;
        List<clsOnJobSupport> items = obj.LoadAll(obj);
        if (items != null)
            Total = items.Count;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void txtLocation_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
            Response.Redirect("OnJobSupport.aspx?itemId=" + e.CommandArgument);

        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsOnJobSupport Item = new clsOnJobSupport();
            Item.Remove(ItemId);
            BindData();
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
                HiddenField hdnInputsReplyFile = (HiddenField)e.Row.FindControl("hdnInputsReplyFile");
                HyperLink hplSendFile = (HyperLink)e.Row.FindControl("hplSendFile");
                HyperLink hplReplyFile = (HyperLink)e.Row.FindControl("hplReplyFile");
                HyperLink hplInputsReplyFile = (HyperLink)e.Row.FindControl("hplInputsReplyFile");

                if (hdnSendFile.Value == "")
                    hplSendFile.Visible = true;

                if (hdnReplyFile.Value == "")
                    hplReplyFile.Visible = false;
                if (hdnInputsReplyFile.Value == "")
                    hplInputsReplyFile.Visible = false;
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

    protected void txtProject_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ResumeSubmissionSearch.aspx");
    }

   
}