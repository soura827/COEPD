using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_SendToPlacement : System.Web.UI.Page
{
    int ItemId = 0, CountNo = 0, CurrentCTC, ExpectedCTC;
    clsParticipant Item;
    clsNurturingProcessStageStatus NurturingProcessStageStatus;
    CurrentUser CurrentUser = new CurrentUser();

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if(!IsPostBack)
        {
            Item = new clsParticipant();
            NurturingProcessStageStatus = new clsNurturingProcessStageStatus();
            if(ItemId>0)
            {
                BindServiceRequestData();
                BindEscalationsData();
                BindNurturingTasksInputsData();
                lblTitle.Text = "Send To BA Job market ";
                Item = Item.Load(ItemId);
                if(Item !=null)
                {
                    lblParticipant.Text = Item.Participant;
                    lblSubscriptionExpiry.Text = "LMS Subscription Expires on " + Item.SubscriptionExpiredOn.ToString("dd MMM yyyy");
                    if (Item.IsPlacementPermit == true)
                        chkIsPlacementPermit.Checked = true;
                    else
                        chkIsPlacementPermit.Checked = false;
                    if (Item.CommunicationSkillsRating >=0)
                        ddlCommunicationRating.SelectedValue = Item.CommunicationSkillsRating.ToString();
                    txtBASkills.Text = Item.BASkills;
                    if (Item.TotalExperience >= 0)
                        ddlExperienceInYears.SelectedValue = Item.TotalExperience.ToString();
                    if(Item.TotalExperience == 0)
                    {
                       // ddlRelevantExperienceMonths.Enabled = false;
                        ddlRelevantExperience.Enabled = false;
                        txtCurrentCTC.Enabled = false;
                    }
                    else
                    {
                       // ddlRelevantExperienceMonths.Enabled = true;
                        ddlRelevantExperience.Enabled = true;
                        txtCurrentCTC.Enabled = true;
                    }
                    if (Item.RelevantExperience >= 0)
                        ddlRelevantExperience.SelectedValue = Item.RelevantExperience.ToString();
                    ddlExperienceInMonths.SelectedValue = Item.TotalExperienceMonths.ToString();
                    ddlRelevantExperienceMonths.SelectedValue = Item.RelevantExperienceMonths.ToString();
                    txtCurrentCTC.Text = Convert.ToString(Item.CurrentCTC);
                    txtExpectedCTC.Text = Convert.ToString(Item.ExpectedCTC);
                    txtSpecialNotes.Text = Item.SpecialNote;
                }
                NurturingProcessStageStatus = NurturingProcessStageStatus.LoadGetDuration(ItemId);
                if(NurturingProcessStageStatus !=null)
                {
                    DateTime DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                    DateTime StageStartOn = NurturingProcessStageStatus.StageStartOn;
                    String Diff = (DateTime - StageStartOn).Days.ToString();
                    lblNurturingProcessDuration.Text = Diff + " Days";
                }
                else
                    lblNurturingProcessDuration.Text = "Nurturing Process not yet Started.";
            }
            else
                Response.Redirect("NurtureStatus.aspx");
        }

    }
    protected void BindServiceRequestData()
    {
        clsNurturingChat Item = new clsNurturingChat();
        Item.ParticipantId = ItemId;
        Item.NurturingProcessStageTaskId = 53;
        rp.DataSource = Item.LoadAll(Item);
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
    protected void BindEscalationsData()
    {
        clsFeedback Item = new clsFeedback();
        Item.ParticipantId = ItemId;
        rpEscalations.DataSource = Item.LoadAll(Item);
        rpEscalations.DataBind();
    }

    protected void btnPlacementPermit_Click(object sender, EventArgs e)
    {
        Item = new clsParticipant();
        if(ItemId>0)
        {
            Item.ParticipantId = Convert.ToInt32(ItemId);
           if(chkIsPlacementPermit.Checked == true)
                Item.IsPlacementPermit = true;
           else
                Item.IsPlacementPermit = false;
            Item.CommunicationSkillsRating = Convert.ToInt32(ddlCommunicationRating.SelectedValue);
            Item.BASkills = Convert.ToString(txtBASkills.Text);
            Item.TotalExperience = Convert.ToInt16(ddlExperienceInYears.SelectedValue);
            Item.RelevantExperience = Convert.ToInt16(ddlRelevantExperience.SelectedValue);

            Item.TotalExperienceMonths = Convert.ToInt16(ddlExperienceInMonths.SelectedValue);
            Item.RelevantExperienceMonths = Convert.ToInt16(ddlRelevantExperienceMonths.SelectedValue);

            Item.CurrentCTC = Convert.ToDecimal(txtCurrentCTC.Text);
            Item.ExpectedCTC = Convert.ToDecimal(txtExpectedCTC.Text);
            Item.SpecialNote = txtSpecialNotes.Text;
            Item.MovedToPlacementBy = CurrentUser.CurrentUserId;
            Item.AddToPlacement(Item);

            int[] FeatureIds = { 20, 21, 22, 23, 30, 31 };
            int PartcipantId = ItemId;

            clsParticipantFeatureAccess obj = new clsParticipantFeatureAccess();
            foreach (int i in FeatureIds)
            {
                obj.ParticipantId = PartcipantId;
                obj.FeatureId = i;
                obj.CreatedBy = CurrentUser.CurrentUserId;
                CountNo = obj.ParticipantFeatureValidation(obj);
                if (CountNo == 0)
                {
                    obj.AddUpdate(obj);
                }
            }
            obj.ParticipantId = PartcipantId;
            obj.FeatureId = 24;
            obj.RemoveByParticipant(obj);
            
            btnPlacementPermit.Enabled = false;
            if (ItemId > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
            }
        }
        else
        {
            Response.Redirect("NurtureStatus.aspx");
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurtureStatus.aspx");
    }

    protected void rpEscalations_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        RepeaterItem item = e.Item;
        if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
        {
            HiddenField hdnRoleId = (HiddenField)item.FindControl("hdnRoleIdEscalation");
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
    protected void ddlExperienceInYears_SelectedIndexChanged(object sender, EventArgs e)
    {
        ErrorMessage.Visible = false;
        if (ddlExperienceInYears.SelectedValue == "0")
        {

            ddlRelevantExperience.Enabled = false;
            txtCurrentCTC.Enabled = false;
            ddlRelevantExperience.SelectedValue = "0";
            ddlRelevantExperienceMonths.SelectedValue= "0";
            ddlExperienceInMonths.SelectedValue= "0";
            txtCurrentCTC.Text = "0";
            txtExpectedCTC.Text = "180000";

        }
        else
        {
            ddlRelevantExperience.Enabled = true;
            txtCurrentCTC.Enabled = true;
            ddlRelevantExperience.SelectedValue = "";
            ddlRelevantExperienceMonths.SelectedValue = "";
            ddlExperienceInMonths.SelectedValue = "";
            txtCurrentCTC.Text = "";
            txtExpectedCTC.Text = "";

        }
    }

    protected void txtCurrentCTC_TextChanged(object sender, EventArgs e)
    {
        if (txtCurrentCTC.Text != "")
        {
            CurrentCTC = Convert.ToInt32(txtCurrentCTC.Text);
            ExpectedCTC = CurrentCTC + (CurrentCTC * 30 / 100);
            txtExpectedCTC.Text = Convert.ToString(ExpectedCTC);
        }
    }

    protected void ddlRelevantExperience_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Relevant, Experience;

        Relevant = Convert.ToInt32(ddlRelevantExperience.SelectedValue);
        Experience = Convert.ToInt32(ddlExperienceInYears.SelectedValue);
        if (Relevant > Experience)
        {
            ErrorMessage.Text = "Please Select Valid Relevant Experience. Less than or equel to " + Experience;
            ErrorMessage.Visible = true;
            FormMessage.Visible = false;
            btnPlacementPermit.Enabled = false;
        }
        else if (Relevant <= Experience)
        {
            btnPlacementPermit.Enabled = true;
            ErrorMessage.Visible = false;
        }
    }

    protected void BindNurturingTasksInputsData()
    {
        clsNurturingChat Item = new clsNurturingChat();
        Item.ParticipantId = ItemId;
        rpNurturingTeamInputs.DataSource = Item.LoadAllTasks(Item);
        rpNurturingTeamInputs.DataBind();
    }

    protected void rpNurturingTeamInputs_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        RepeaterItem item = e.Item;
        if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
        {
            HiddenField hdnRoleId = (HiddenField)item.FindControl("hdnNurturingTeamInputsRoleId");
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