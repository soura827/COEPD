using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class MyResumeApproved : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsResumePreparation Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsResumePreparation();
        if (!IsPostBack)
        {
            BindSampleQuestions();
            BindData();
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.ParticipantId = CurrentUser.CurrentParticipantId;
            if (CurrentUser.CurrentUserId > ItemId)
            {
                ItemId = Convert.ToInt32(Item.ParticipantId);
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    hplResumeView.NavigateUrl = "~/UserDocs/ResumePreparation/" + Item.ResumePath;
                    hplResumeDownload.NavigateUrl = "~/UserDocs/ResumePreparation/" + Item.ResumePath;
                    lblJobExpDomain.Text = Item.JobExperienceDomain;
                    lblJobExpectedDomain.Text = Item.JobExpectedDomain;
                    lblExpectedSalary.Text = Convert.ToDecimal(Item.ExpectedSalary).ToString();
                    lblPreferedLocations.Text = Item.PreferedLocations;
                    lblListOfCompetencies.Text = Item.ListOfCompentencies;
                    lblSkills.Text = Item.Skills;
                    lblComments.Text = Item.Comments;
                    lblExpInYears.Text = Item.ExpInYears.ToString();
                    lblApprovedBy.Text = Item.ApprovedBy;
                    lblApprovedDate.Text = Convert.ToDateTime(Item.ApprovedDate).ToString("dd/MM/yyyy");       
                    if (Item.HrStatus == true)
                    {
                        lblHrStatus.Text = "Shortlisted";
                        divSampleQustns.Visible = true;
                    }
                    else
                    {
                        lblHrStatus.Text = "Not Shortlisted";
                        divSampleQustns.Visible = false;
                    }
                    if (Item.InterviewQuestionRequest == true && Item.InterviewQuestionReceive == false)
                    {
                        divGrid.Visible = true;
                        divSampleQustns.Visible = false;
                    }
                    else
                    {
                        divGrid.Visible = false;
                        //divSampleQustns.Visible = true;
                    }
                }
            }
        }
    }
    protected void btnSampleQuestions_Click(object sender, EventArgs e)
    {
        Item.ParticipantId = CurrentUser.CurrentParticipantId;
        ItemId = Convert.ToInt32(Item.ParticipantId);
        Item = Item.Load(ItemId);
        ItemId = Convert.ToInt32(Item.ResumePreparationId);

        if (ItemId > 0)
        {
            Item.InterviewQuestionRequest = true;
            Item.InterviewQuestionReceive = true;
            Item.AddUpdate(Item);
            btnSampleQuestions.Enabled = false;
            lblMsg.Text = "Request sent";
        }
        Response.Write("<script>alert('Your Request Sent Successfully')</script>");
    }
    protected void btnBackToDashboard_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dashboard.aspx");
    }
    public void BindSampleQuestions()
    {
        int ParticipantId = CurrentUser.CurrentParticipantId;
        clsSampleQuestions obj = new clsSampleQuestions();
        obj.keywords = null;
        obj.ParticipantId = ParticipantId;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdDownload")
        {
            clsSampleQuestions obj = new clsSampleQuestions();
            if (e.CommandArgument != null)
            {
                string FilePath = Server.MapPath("~/UserDocs/SampleQuestions/" + e.CommandArgument);
                Response.ContentType = "application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + System.IO.Path.GetFileName(FilePath));
                Response.TransmitFile(FilePath);
            }
        }
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (txtNotes.Text.Length > 0)
        {
            clsResumeChat objResumeChat = new clsResumeChat();
            objResumeChat.ParticipantId = Convert.ToInt16(CurrentUser.CurrentParticipantId);
            objResumeChat.ResumeChat = txtNotes.Text;
            objResumeChat.CreatedBy = CurrentUser.CurrentUserId;
            objResumeChat.AddUpdate(objResumeChat);
            txtNotes.Text = "";
            FormMessage.Text = "Your request is successfully sent.";
            FormMessage.Visible = true;
            Response.Redirect("MyResumeApproved.aspx?ItemId=" + ItemId);
        }
    }
    protected void BindData()
    {
        clsResumeChat objChat = new clsResumeChat();
        objChat.ParticipantId = CurrentUser.CurrentParticipantId;
        rp.DataSource = objChat.LoadAll(objChat);
        rp.DataBind();
    }
    protected void rp_OnItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        RepeaterItem item = e.Item;
        if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
        {
            HiddenField hdnRoleId = (HiddenField)item.FindControl("hdnRoleId");
            int RoleId = Convert.ToInt16(hdnRoleId.Value);
            if (RoleId == 3)
            {
                Panel pnlIn = (Panel)item.FindControl("pnlIn");
                pnlIn.Visible = true;
            }
            else
            {
                Panel PnlOut = (Panel)item.FindControl("PnlOut");
                PnlOut.Visible = true;
            }
        }
    }
}