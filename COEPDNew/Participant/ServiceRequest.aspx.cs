using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_ServiceRequest : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int CountNo = 0;
    DateTime CreatedOn;
    DateTime EscalationAfterDate;
    DateTime EscalationClosedDate;
    DateTime DateTime;
    clsNurturingChat item;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindData();
            BindTopOneServieRequest();
            
        }
    }
    protected void BindData()
    {
        //clsParticipantNurture ParticipantNurture = new clsParticipantNurture();
        //ParticipantNurture.ParticipantId = CurrentUser.CurrentParticipantId;
        //rp.DataSource = ParticipantNurture.LoadAll(ParticipantNurture);
        //rp.DataBind();

        clsNurturingChat Item = new clsNurturingChat();
        Item.ParticipantId = CurrentUser.CurrentParticipantId;
        Item.NurturingProcessStageTaskId = 53;
        rp.DataSource = Item.LoadAll(Item);
        rp.DataBind();
    }

    protected void BindTopOneServieRequest()
    {
        item = new clsNurturingChat();

        if (CurrentUser.CurrentParticipantId > 0)
        {
            item = item.LoadTopOne(CurrentUser.CurrentParticipantId);
            if (item != null)
            {
                btnEscalate.Enabled = true;
                lblLastServiceRequest.Text = item.Chat;
                hdnNurturingChatId.Value = Convert.ToString(item.NurturingChatId);
                hdnCreatedOn.Value = Convert.ToString(item.CreatedOn);
                if (item.SenderImagePath != "")
                    hplSentFile.NavigateUrl = "~/UserDocs/NurturingServiceRequests/" + item.SenderImagePath;
                else
                    hplSentFile.Visible = false;
                if (item.ReceiverImagePath != "")
                    hplReplyFile.NavigateUrl = "~/UserDocs/NurturingServiceRequests/" + item.ReceiverImagePath;
                else
                    hplReplyFile.Visible = false;
            }
            else
                btnEscalate.Enabled = false;
        }
        else
        {
            Response.Redirect("~/Login.html");
        }
    }
    //protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    //{
    //    CreatedOn = Convert.ToDateTime(e.CommandArgument);
    //    Escalation = CreatedOn.ToString("dd/MM/yyyy");
    //    EscalationAfterDate = Convert.ToDateTime(Escalation);
    //    EscalationAfterDate = EscalationAfterDate.AddDays(1).AddHours(17);
    //    EscalationClosedDate = EscalationAfterDate.AddDays(3);
    //    DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);

    //    if (e.CommandName == "cmdEscalate")
    //    {
    //        if (EscalationAfterDate < DateTime)
    //        {
    //            if (DateTime < EscalationClosedDate)
    //            {
    //                Response.Redirect("Feedback.aspx?ItemId=" + e.CommandArgument);
    //            }
    //            else
    //            {
    //                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeAfterEscalation()", true);
    //            }

    //        }
    //        else
    //        {
    //            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeBeforeEscalation()", true);
    //        }

    //    }
    //}

    protected void rp_OnItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        //RepeaterItem item = e.Item; if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
        //{
        //    HiddenField hdnUserId = (HiddenField)item.FindControl("hdnUserId");
        //    int UserId = Convert.ToInt16(hdnUserId.Value);
        //    if (UserId == CurrentUser.CurrentUserId)
        //    {
        //        Panel pnlIn = (Panel)item.FindControl("pnlIn");
        //        pnlIn.Visible = true;
        //    }
        //    else
        //    {
        //        Panel PnlOut = (Panel)item.FindControl("PnlOut");
        //        PnlOut.Visible = true;
        //    }
        // }
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

    protected void BindCount()
    {
        clsNurturingChat NurturingChatCount = new clsNurturingChat();
        NurturingChatCount.ParticipantId = CurrentUser.CurrentParticipantId;
        CountNo = NurturingChatCount.LoadNurturingChatValidation(NurturingChatCount);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtChat.Text = "";
            BindData();
        }
        else
        {
            clsNurturingChat ParticipantNurturingChat = new clsNurturingChat();
            ParticipantNurturingChat.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            ParticipantNurturingChat.ParticipantId = Convert.ToInt16(CurrentUser.CurrentParticipantId);
            ParticipantNurturingChat.Chat = txtChat.Text;
            if (flUpload.HasFile)
            {
                clsFileUpload Upload = new clsFileUpload();
                string filePath = Upload.NurturingServiceRequestFileUpload(flUpload);
                ParticipantNurturingChat.SenderImagePath = filePath;
            }
            ParticipantNurturingChat.NurturingProcessStageId = 10;
            ParticipantNurturingChat.NurturingProcessStageTaskId = 53;
            ParticipantNurturingChat.CreatedBy = CurrentUser.CurrentUserId;
            ParticipantNurturingChat.AddUpdate(ParticipantNurturingChat);
            txtChat.Text = "";
            flUpload.Enabled = false;
            BindData();
            BindTopOneServieRequest();
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }
        //Response.Redirect("Dashboard.aspx");
        //Response.Redirect("NurtureChat.aspx?ItemId=" + ItemId);
        //txtChat.Enabled = false;
        //clsParticipantNurture ParticipantNurture = new clsParticipantNurture();
        //ParticipantNurture.ParticipantId = Convert.ToInt16(CurrentUser.CurrentParticipantId);
        //ParticipantNurture.ParticipantNurture = txtNotes.Text;
        //ParticipantNurture.CreatedBy = CurrentUser.CurrentUserId;
        //ParticipantNurture.AddUpdate(ParticipantNurture);
        //txtNotes.Text = "";
        //BindData();
        //FormMessage.Text = "Your request is successfully sent.";
        //FormMessage.Visible = true;
        //Response.Redirect("Dashboard.aspx");
    }

    protected void txtChat_TextChanged(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtChat.Text = "";
            BindData();
        }
        //else
        //{

        //}
    }

    protected void btnEscalate_Click(object sender, EventArgs e)
    {
        CreatedOn = Convert.ToDateTime(hdnCreatedOn.Value);
        EscalationAfterDate = CreatedOn.AddDays(1).AddHours(4);
        EscalationClosedDate = CreatedOn.AddDays(3);
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        if (EscalationAfterDate < DateTime)
        {
            if (DateTime < EscalationClosedDate)
            {
                Response.Redirect("Feedback.aspx?ItemId=" + hdnNurturingChatId.Value);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeAfterEscalation()", true);
            }

        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeBeforeEscalation()", true);
        }
    }
}