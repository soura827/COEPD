using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ResumeSubmissionSearch : System.Web.UI.Page
{
    int Total = 0;
    DateTime DateTime;
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

    protected void btnDownload_Click(object sender, EventArgs e)
    {
        string FileNamePrepix = string.Empty;
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        FileNamePrepix = DateTime.ToString("dd-MM-yyyy - hh mm tt");
        ExportToExcel(FileNamePrepix + "-RresumeSubmission.xls", gv);
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
    protected void BindData()
    {
        clsResumeSubmission obj = new clsResumeSubmission();
        if (txtParticipant.Text != "")
            obj.Keywords = txtParticipant.Text;
        if (txtCompany.Text != "")
            obj.CompanyName = txtCompany.Text;
        if (txtInterviewStatus.Text != "")
            obj.InterviewStatus = txtInterviewStatus.Text;

        if (txtCreatedBy.Text != "")
        {
            obj.Fullname = Convert.ToString(txtCreatedBy.Text);
        }


        if (ddlAppliedThrough.SelectedValue != "")                                            /**/
            obj.AppliedThroughId = Convert.ToInt16(ddlAppliedThrough.SelectedValue);
        List<clsResumeSubmission> items = obj.LoadAll(obj);
        if (items !=null)
        {
            Total = items.Count;

        }
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("ResumeSubmission.aspx?ItemId=" + e.CommandArgument);
        }
        //else if (e.CommandName == "cmdDelete")
        //{
        //    int ItemId = Convert.ToInt16(e.CommandArgument);
        //    clsResumeSubmission Item = new clsResumeSubmission();
        //    Item.Remove(ItemId);
        //    BindData();
        //    ErrorMessage.Text = "Submission successfully removed";
        //    ErrorMessage.Visible = true;
        //}
    }
    protected void txtCompany_TextChanged(object sender, EventArgs e)
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
        int TotalRecords = 0;
        string Records = "";
        TotalRecords = (gv.PageSize * (gv.PageIndex + 1));
        if (TotalRecords > Total)
        {
            Records = Total.ToString();

        }
        else
        {
            Records = TotalRecords.ToString();
        }


        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
           server control at run time. */
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ResumeSubmission.aspx");
    }

    protected void ddlAppliedThrough_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }



    protected void txtCreatedBy_TextChanged(object sender, EventArgs e)
    {

        BindData();
    }
}