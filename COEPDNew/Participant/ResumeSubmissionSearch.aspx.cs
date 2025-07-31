using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_ResumeSubmissionSearch : System.Web.UI.Page
{
    CurrentUser currentUser = new CurrentUser();
    int Total=0;
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
        if(currentUser.CurrentParticipantId>0)
        {
            clsResumeSubmission obj = new clsResumeSubmission();
            obj.ParticipantId = currentUser.CurrentParticipantId;
            if (txtInterviewStatus.Text != "")
                obj.InterviewStatus = txtInterviewStatus.Text;
            if (txtCompany.Text != "")
                obj.CompanyName = txtCompany.Text;
            
            List<clsResumeSubmission> items = obj.LoadAll(obj);
            if (items != null)
            {
                Total = items.Count;

            }
            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();
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
            Response.Redirect("ResumeSubmission.aspx?ItemId=" + e.CommandArgument);
        }




        else if(e.CommandName == "cmdRequestFAQs")
        {
            Response.Redirect("RequestFAQs.aspx?itemId=0&RSId=" + e.CommandArgument);
        }
        else if(e.CommandName== "cmdViewFAQs")
        {
            Response.Redirect("RequestFAQsSearch.aspx");
        }






        else if (e.CommandName == "cmdInterviewSupport")
        {
            Response.Redirect("InterviewSupport.aspx?ItemId=0&RSId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdViewInterviewSupport")
        {
            Response.Redirect("InterviewSupportSearch.aspx");
        }

        else if (e.CommandName == "cmdRequestOnJobSupport")
        {
            Response.Redirect("OnJobSupport.aspx?ItemId=0&RSId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdViewOnJobSupport")
        {
            Response.Redirect("OnJobSupportSearch.aspx");
        }

        else if (e.CommandName == "cmdAddInterviewExperiance")
        {
            Response.Redirect("FAQsMaster.aspx?ItemId=0&RSId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdViewInterviewExperiance")
        {
            Response.Redirect("FAQsMasterSearch.aspx");
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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ResumeSubmission.aspx");
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

    protected void ddlAppliedThrough_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}