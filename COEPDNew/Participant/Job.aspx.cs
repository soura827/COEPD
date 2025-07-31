using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using BusinessLayer;
public partial class Job : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsJob Item;
    int ItemId = 0;

    int ResumeSubmissionId = 0;
    clsResumeSubmission ResumeSubmission = new clsResumeSubmission();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsJob();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "View Job Details";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    lblJobTitle.Text = Item.JobTitle;
                    lblDomain.Text = Item.JobDomain;
                    lblLocation.Text = Item.Location;
                    lblCompany.Text = Item.Company;
                    lblPhone.Text = Item.Phone;
                    lblEmail.Text = Item.Email;
                    lblExperience.Text = Item.Experience;
                    lblFullDescription.Text = Item.FullDescription;
                    if (Item.Weblink.Length > 0)
                    {
                        //hpl.NavigateUrl = Item.Weblink;
                        hdnWebLink.Value = Item.Weblink;
                    }
                    else
                    {
                        //hpl.NavigateUrl = "#";
                        hdnWebLink.Value = "#";
                    }
                }
            }
            else
            {
                lblTitle.Text = "Add New Job";
            }
        }
    }
    protected void BtnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Job.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["latest"] == "1")
        {
            Response.Redirect("LatestJobSearch.aspx");
        }
        else
        {
            Response.Redirect("JobSearch.aspx");
        }
    }

    protected void btnLink_Click(object sender, EventArgs e)
    {
        if (CurrentUser.CurrentParticipantId > 0)
        {
            clsJobApplied obj = new clsJobApplied();
            obj.JobId = Convert.ToInt32(ItemId);
            obj.ParticipantId = CurrentUser.CurrentParticipantId;
            obj.CreatedBy = CurrentUser.CurrentUserId;
            obj.AddUpdate(obj);


            if (ResumeSubmissionId > 0)
                ResumeSubmission.ResumeSubmissionId = Convert.ToInt32(ResumeSubmissionId);
            ResumeSubmission.CompanyName = lblCompany.Text;
            ResumeSubmission.JobDescription = lblFullDescription.Text;
            ResumeSubmission.Location = lblLocation.Text;
            //ResumeSubmission.Experience = Convert.ToInt16(lblExperience.Text);
            ResumeSubmission.Experience = lblExperience.Text;
            ResumeSubmission.Domain = lblDomain.Text;
            DateTime DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            //DateTime AppliedOn = DateTime.ParseExact(DateTime.ToString(), "dd/MM/yyyy", null);
            ResumeSubmission.AppliedOn = DateTime;
            ResumeSubmission.AppliedThroughId = 3;
            ResumeSubmission.InterviewStatusId = 8;
            ResumeSubmission.ParticipantId = CurrentUser.CurrentParticipantId;
            ResumeSubmission.CreatedBy = CurrentUser.CurrentUserId;
            ResumeSubmission.AddUpdate(ResumeSubmission);

            Response.Redirect(hdnWebLink.Value);
        }
        else
        {
            Response.Redirect("~/Login.html");
        }



        
    }
}