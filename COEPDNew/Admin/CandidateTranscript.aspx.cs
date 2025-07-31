using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_CandidateTranscript : System.Web.UI.Page
{
    int ItemId = 0, CountNo = 0;
    clsParticipant Item;
    clsNurturingProcessStageStatus NurturingProcessStageStatus;
    CurrentUser CurrentUser = new CurrentUser();

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

        }
    }

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        ddlParticipant.Items.Clear();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select participant -- ", ""));
        if (txtSearch.Text != "")
        {
            BindParticipant();
        }
    }
    protected void BindParticipant()
    {
        ddlParticipant.Items.Clear();
        clsParticipant obj = new clsParticipant();
        obj.keywords = txtSearch.Text;
        ddlParticipant.DataSource = obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Participant";
        ddlParticipant.DataValueField = "ParticipantId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant -- ", ""));
       
    }
    protected void ddlParticipant_SelectedIndexChanged(object sender, EventArgs e)
    {
        Item = new clsParticipant();
        NurturingProcessStageStatus = new clsNurturingProcessStageStatus();
        ItemId = Convert.ToInt32(ddlParticipant.SelectedValue);

        if (ItemId > 0)
        {

            BindServiceRequestData();
            BindEscalationsData();
            BindNurturingTasksInputsData();
            lblTitle.Text = "Send To Placement";
            Item = Item.Load(ItemId);

            NurturingProcessStageStatus = NurturingProcessStageStatus.LoadGetDuration(ItemId);
            if (NurturingProcessStageStatus != null)
            {
                DateTime DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                DateTime StageStartOn = NurturingProcessStageStatus.StageStartOn;
                String Diff = (DateTime - StageStartOn).Days.ToString();
            }

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