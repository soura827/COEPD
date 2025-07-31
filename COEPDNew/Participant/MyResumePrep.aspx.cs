using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class MyResumePrep : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsResumePreparation Item =new clsResumePreparation();
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData();
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.ResumePreparationId = ItemId;
        }
        Item.JobExpectedDomain = Convert.ToString(txtJobExpectedDomain.Text);
        Item.JobExperienceDomain = Convert.ToString(txtExpDomain.Text);
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
        Item.HrNotShortlist = false;
        Item.ParticipantId = CurrentUser.CurrentParticipantId;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        btnSubmit.Enabled = false;
        Response.Redirect("MyResume.aspx");
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtComments.Text = "";
        txtJobExpectedDomain.Text = "";
        txtExpDomain.Text = "";
        txtExpectedSalary.Text = "";
        txtListOfCompetencies.Text = "";
        txtPreferedLocation.Text = "";
        txtSkills.Text = "";
        ddlExpInYears.SelectedValue = "";
        //FormMessage.Text = "";
    }
    protected void btnBacktoDashboard_Click(object sender, EventArgs e)
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
            Response.Redirect("MyResumePrep.aspx?ItemId=" + ItemId);
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