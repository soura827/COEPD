using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_Feedback : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsFeedback Item;
    int ItemId = 0;
    int ParticipantId = 0;
    string Message = "";
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsFeedback();
        if (ItemId > 0)
        {
            Item = Item.Load(ItemId);
            if (Item != null)
            {
                ParticipantId = Item.ParticipantId;
                Message = Item.Chat;
                if (Item.SenderImagePath != "")
                    hplSentFile.NavigateUrl = "~/UserDocs/NurturingEscalations/" + Item.SenderImagePath;
                else
                    hplSentFile.Visible = false;
                if (Item.ReceiverImagePath != "")
                    hplReplyFile.NavigateUrl = "~/UserDocs/NurturingEscalations/" + Item.ReceiverImagePath;
                else
                    hplReplyFile.Visible = false;
            }
            BindData();
        }
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (txtChat.Text.Length > 0)
        {
            if (ItemId > 0)
            {
                clsFeedback ParticipantFeedbackUpdate = new clsFeedback();
                ParticipantFeedbackUpdate.FeedbackId = ItemId;
                ParticipantFeedbackUpdate.EmployeeId = 0;
                ParticipantFeedbackUpdate.ParticipantId = ParticipantId;
                ParticipantFeedbackUpdate.Chat = Message;
                ParticipantFeedbackUpdate.CreatedBy = CurrentUser.CurrentUserId;
                ParticipantFeedbackUpdate.IsReplied = Convert.ToBoolean(1);
                if (flUpload.HasFile)
                {
                    clsFileUpload Upload = new clsFileUpload();
                    string filePath = Upload.NurturingEscalationFileUpload(flUpload);
                    ParticipantFeedbackUpdate.ReceiverImagePath = filePath;
                }
                ParticipantFeedbackUpdate.AddUpdate(ParticipantFeedbackUpdate);
            }

            clsFeedback ParticipantFeedback = new clsFeedback();
            ParticipantFeedback.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            ParticipantFeedback.ParticipantId = ParticipantId;
            ParticipantFeedback.Chat = txtChat.Text;
            ParticipantFeedback.CreatedBy = CurrentUser.CurrentUserId;
            if (flUpload.HasFile)
            {
                clsFileUpload Upload = new clsFileUpload();
                string filePath = Upload.NurturingEscalationFileUpload(flUpload);
                ParticipantFeedback.ReceiverImagePath = filePath;
            }
            ParticipantFeedback.IsReplied = Convert.ToBoolean(1);
            ParticipantFeedback.AddUpdate(ParticipantFeedback);
            txtChat.Text = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
            //Response.Redirect("FeedbackChat.aspx?ItemId=" + ItemId);
            BindData();
            flUpload.Enabled = false;
            btnSend.Enabled = false;
            txtChat.Enabled = false;
        }
    }
    protected void BindData()
    {
        clsFeedback Item = new clsFeedback();
        Item.ParticipantId = ParticipantId;
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

            if (RoleId == 2)
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
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("FeedbackSearch.aspx");
    }
}