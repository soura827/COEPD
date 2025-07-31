using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_PlacementEscalation : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsPlacementEscalation Item;
    int ItemId = 0;
    int ParticipantId = 0;
    string Message = "";
   // private object txtServiceRequst; 

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsPlacementEscalation();
        if (ItemId > 0)
        {
            Item = Item.Load(ItemId);
            if (Item != null)
            {
                ParticipantId = Item.ParticipantId;
                Message = Item.Escalation;
                if (Item.SenderImagePath != "")
                    hplSentFile.NavigateUrl = "~/UserDocs/PlacementEscalations/" + Item.SenderImagePath;
                else
                    hplSentFile.Visible = false;
                if (Item.ReceiverImagePath != "")
                    hplReplyFile.NavigateUrl = "~/UserDocs/PlacementEscalations/" + Item.ReceiverImagePath;
                else
                    hplReplyFile.Visible = false;
            }
            BindData();
        }
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (txtEscalation.Text.Length > 0) 
        {
            if (ItemId > 0)
            {
                clsPlacementEscalation ParticipantFeedbackUpdate = new clsPlacementEscalation();
                ParticipantFeedbackUpdate.PlacementEscalationId = ItemId;
                ParticipantFeedbackUpdate.EmployeeId = 0;
                ParticipantFeedbackUpdate.ParticipantId = ParticipantId;
                ParticipantFeedbackUpdate.Escalation = Message;
                ParticipantFeedbackUpdate.CreatedBy = CurrentUser.CurrentUserId;
                ParticipantFeedbackUpdate.IsReplied = Convert.ToBoolean(1);
                if (flUpload.HasFile)
                {
                    clsFileUpload Upload = new clsFileUpload();
                    string filePath = Upload.PlacementEscalationFileUpload(flUpload);
                    ParticipantFeedbackUpdate.ReceiverImagePath = filePath;
                }
                ParticipantFeedbackUpdate.AddUpdate(ParticipantFeedbackUpdate);
            }

            clsPlacementEscalation ParticipantFeedback = new clsPlacementEscalation();
            ParticipantFeedback.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            ParticipantFeedback.ParticipantId = ParticipantId;
            ParticipantFeedback.Escalation = txtEscalation.Text;
            ParticipantFeedback.CreatedBy = CurrentUser.CurrentUserId;
            ParticipantFeedback.IsReplied = Convert.ToBoolean(1);
            if (flUpload.HasFile)
            {
                clsFileUpload Upload = new clsFileUpload();
                string filePath = Upload.PlacementEscalationFileUpload(flUpload);
                ParticipantFeedback.ReceiverImagePath = filePath;
            }
            ParticipantFeedback.AddUpdate(ParticipantFeedback);
            txtEscalation.Text = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
            //Response.Redirect("FeedbackChat.aspx?ItemId=" + ItemId);
            BindData();
            flUpload.Enabled = false;
            btnSend.Enabled = false;
            txtEscalation.Enabled = false;
        }
    }
    protected void BindData()
    {
        clsPlacementEscalation Item = new clsPlacementEscalation();
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
        Response.Redirect("PlacementEscalationSearch.aspx");
    }
}