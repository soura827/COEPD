using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_HrChat : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsHrChat Item;
    int ItemId = 0;
    int ParticipantId = 0;
    int HrProcessStageId = 0;
    int HrProcessStageTaskId = 0;
    string Message = "";
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsHrChat();
        if (ItemId > 0)
        {
            Item = Item.Load(ItemId);
            if (Item != null)
            {
                ParticipantId = Item.ParticipantId;
                HrProcessStageId = Convert.ToInt32(Item.HrProcessStageId);
                HrProcessStageTaskId = Convert.ToInt32(Item.HrProcessStageTaskId);
                Message = Item.Chat;
                if (Item.SenderImagePath != "")
                    hplSentFile.NavigateUrl = "~/UserDocs/HrServiceRequests/" + Item.SenderImagePath;
                else
                    hplSentFile.Visible = false;
                if (Item.ReceiverImagePath != "")
                    hplReplyFile.NavigateUrl = "~/UserDocs/HrServiceRequests/" + Item.ReceiverImagePath;
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
                clsHrChat ParticipantHrChatUpdate = new clsHrChat();
                ParticipantHrChatUpdate.HrChatId = ItemId;
                ParticipantHrChatUpdate.EmployeeId = 0;
                ParticipantHrChatUpdate.ParticipantId = ParticipantId;
                ParticipantHrChatUpdate.Chat = Message;
                ParticipantHrChatUpdate.HrProcessStageId = HrProcessStageId;
                ParticipantHrChatUpdate.HrProcessStageTaskId = HrProcessStageTaskId;
                ParticipantHrChatUpdate.CreatedBy = CurrentUser.CurrentUserId;
                ParticipantHrChatUpdate.IsReplied = Convert.ToBoolean(1);
                if (flUpload.HasFile)
                {
                    clsFileUpload Upload = new clsFileUpload();
                    string filePath = Upload.HrServiceRequestFileUpload(flUpload);
                    ParticipantHrChatUpdate.ReceiverImagePath = filePath;
                }
                ParticipantHrChatUpdate.AddUpdate(ParticipantHrChatUpdate);
            }

            clsHrChat ParticipantHrChat = new clsHrChat();
            ParticipantHrChat.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            ParticipantHrChat.ParticipantId = ParticipantId;
            ParticipantHrChat.Chat = txtChat.Text;
            ParticipantHrChat.HrProcessStageId = HrProcessStageId;
            ParticipantHrChat.HrProcessStageTaskId = HrProcessStageTaskId;
            ParticipantHrChat.CreatedBy = CurrentUser.CurrentUserId;
            ParticipantHrChat.IsReplied = Convert.ToBoolean(1);
            if (flUpload.HasFile)
            {
                clsFileUpload Upload = new clsFileUpload();
                string filePath = Upload.HrServiceRequestFileUpload(flUpload);
                ParticipantHrChat.ReceiverImagePath = filePath;
            }
            ParticipantHrChat.AddUpdate(ParticipantHrChat);
            txtChat.Text = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
            //Response.Redirect("HrChatChat.aspx?ItemId=" + ItemId);
            BindData();
            flUpload.Enabled = false;
            btnSend.Enabled = false;
            txtChat.Enabled = false;
            //Response.Redirect("HrChatSearch.aspx");
        }
    }
    protected void BindData()
    {
        clsHrChat Item = new clsHrChat();
        Item.ParticipantId = ParticipantId;
        Item.HrProcessStageTaskId = HrProcessStageTaskId;
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
        Response.Redirect("HrChatSearch.aspx");
    }
}