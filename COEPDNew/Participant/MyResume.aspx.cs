using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class MyResume : System.Web.UI.Page
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
        BindSampleResumes();
        if (!IsPostBack)
        {
            BindData();
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.ParticipantId = CurrentUser.CurrentParticipantId;

            if (CurrentUser.CurrentUserId > ItemId)
            {
                ItemId = Convert.ToInt32(Item.ParticipantId);
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    if (Item.ResumeStatus == false)
                    {
                        lblStatus.InnerText = "Pending";
                    }
                    else
                    {
                        lblStatus.InnerText = "Approved";
                    }
                    hp1ViewResumeFile.NavigateUrl = "~/UserDocs/ResumePreparation/" + Item.ResumePath;
                    hplDownLoadFile.NavigateUrl = "~/UserDocs/ResumePreparation/" + Item.ResumePath;
                    txtExperienceDomain.Text = Item.JobExperienceDomain;
                    txtJobExpectedDomain.Text = Item.JobExpectedDomain;
                    txtExpectedSalary.Text = Convert.ToDecimal(Item.ExpectedSalary).ToString();
                    txtPreferedLocation.Text = Item.PreferedLocations;
                    txtListOfCompetencies.Text = Item.ListOfCompentencies;
                    txtSkills.Text = Item.Skills;
                    txtComments.Text = Item.Comments;
                    ddlExpInYears.SelectedValue = Item.ExpInYears.ToString();
                }
            }
            if (Item.SampleResumeRequest == true)
            {
                btnSampleResumes.Enabled = false;
                lblMsg.Text = "Request Sent";
                divGrid.Visible = true;
            }
            else
            {
                divGrid.Visible = false;
            }

            if (divGrid.Visible == true)
            {
                divResumeRequest.Visible = false;
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Item.ParticipantId = CurrentUser.CurrentParticipantId;
        ItemId = Convert.ToInt32(Item.ParticipantId);
        Item = Item.Load(ItemId);
        ItemId = Convert.ToInt32(Item.ResumePreparationId);
        if (ItemId > 0)
        {
            Item.JobExpectedDomain = Convert.ToString(txtJobExpectedDomain.Text);
            Item.JobExperienceDomain = Convert.ToString(txtExperienceDomain.Text);
            Item.ExpInYears = Convert.ToInt32(ddlExpInYears.SelectedItem.ToString());
            Item.ExpectedSalary = Convert.ToDecimal(txtExpectedSalary.Text);
            Item.PreferedLocations = Convert.ToString(txtPreferedLocation.Text);
            Item.ListOfCompentencies = Convert.ToString(txtListOfCompetencies.Text);
            Item.Skills = Convert.ToString(txtSkills.Text);
            if (flUpload.FileName.Length > 0)
            {
                clsFileUpload Upload = new clsFileUpload();
                string strFilePath = Upload.ResumePreparationUploadDoc(flUpload);
                Item.ResumePath = strFilePath;
            }
            Item.Comments = Convert.ToString(txtComments.Text);
            Item.ResumeStatus = false;
            Item.HrStatus = false;
            Item.ParticipantId = CurrentUser.CurrentParticipantId;
            Item.CreatedBy = CurrentUser.CurrentUserId;
            if (Item.SampleResumeRequest == true && Item.SampleResumeReceive==true)
            {
                Item.SampleResumeReceive = true;
            }
            else
            {
                Item.SampleResumeReceive = false;
            }

            Item.AddUpdate(Item);
            Response.Write("<script>alert('Your Profile Submitted Successfully')</script>");
        }
    }
    protected void btnSampleResumes_Click(object sender, EventArgs e)
    {
        Item.ParticipantId = CurrentUser.CurrentParticipantId;
        ItemId = Convert.ToInt32(Item.ParticipantId);
        Item = Item.Load(ItemId);
        ItemId = Convert.ToInt32(Item.ResumePreparationId);
        if (ItemId > 0)
        {
            Item.SampleResumeRequest = true;
            Item.SampleResumeReceive = true;
            Item.AddUpdate(Item);
            btnSampleResumes.Enabled = false;
            lblMsg.Text = "Request sent";
        }
        Response.Write("<script>alert('Your Request Sent Successfully')</script>");
    }
    public void BindSampleResumes()
    {
        int ParticipantId = CurrentUser.CurrentParticipantId;
        clsSampleResume obj = new clsSampleResume();
        obj.keywords = null;
        obj.ParticipantId = ParticipantId;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdDownload")
        {
            clsResumePreparation obj = new clsResumePreparation();
            if (e.CommandArgument != null)
            {
                string FilePath = Server.MapPath("~/UserDocs/SampleResume/" + e.CommandArgument);
                Response.ContentType = "application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + System.IO.Path.GetFileName(FilePath));
                Response.TransmitFile(FilePath);
            }
        }
    }
    protected void btnBackToDashboard_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dashboard.aspx");
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
            Response.Redirect("MyResume.aspx");
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