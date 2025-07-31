using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_PlacementServiceRequest : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsPlacementServiceRequest Item;
    int ItemId = 0;
    int ParticipantId = 0;
    string Message = "";
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString[ItemId]);
        Item = new clsPlacementServiceRequest();
        if (ItemId > 0)
        {
            Item = Item.Load(ItemId);
            if (Item != null)
            {
                ParticipantId = Item.ParticipantId;
                Message = Item.ServiceRequest;
                if (Item.SenderImagePath != "")
                    hplSentFile.NavigateUrl = "~/UserDocs/PlacementServiceRequests/" + Item.SenderImagePath;
                else
                    hplSentFile.Visible = false;
                if (Item.ReceiverImagePath != "")
                    hplReplyFile.NavigateUrl = "~/UserDocs/PlacementServiceRequests/" + Item.ReceiverImagePath;
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
                clsPlacementServiceRequest ParticipantServiceRequestUpdate = new clsPlacementServiceRequest();
                ParticipantServiceRequestUpdate.PlacementServiceRequestId = ItemId;
                ParticipantServiceRequestUpdate.EmployeeId = 0;
                ParticipantServiceRequestUpdate.ParticipantId = ParticipantId;
                ParticipantServiceRequestUpdate.ServiceRequest = Message;
                ParticipantServiceRequestUpdate.CreatedBy = CurrentUser.CurrentUserId;
                ParticipantServiceRequestUpdate.IsReplied = Convert.ToBoolean(1);
                if (flUpload.HasFile)
                {
                    clsFileUpload Upload = new clsFileUpload();
                    string filePath = Upload.PlacementServiceRequestFileUpload(flUpload);
                    ParticipantServiceRequestUpdate.ReceiverImagePath = filePath;
                }
                ParticipantServiceRequestUpdate.AddUpdate(ParticipantServiceRequestUpdate);
            }

            clsPlacementServiceRequest ParticipantServiceRequest = new clsPlacementServiceRequest();
            ParticipantServiceRequest.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            ParticipantServiceRequest.ParticipantId = ParticipantId;
            ParticipantServiceRequest.ServiceRequest = txtChat.Text;
            ParticipantServiceRequest.CreatedBy = CurrentUser.CurrentUserId;
            ParticipantServiceRequest.ServiceRequest = txtChat.Text;
            ParticipantServiceRequest.IsReplied = Convert.ToBoolean(1);
            if (flUpload.HasFile)
            {
                clsFileUpload Upload = new clsFileUpload();
                string filePath = Upload.PlacementServiceRequestFileUpload(flUpload);
                ParticipantServiceRequest.ReceiverImagePath = filePath;
            }
            ParticipantServiceRequest.AddUpdate(ParticipantServiceRequest);
            txtChat.Text = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
            //Response.Redirect("PlacementServiceRequest.aspx?ItemId=" + ItemId);
            BindData();
            flUpload.Enabled = false;
            btnSend.Enabled = false;
            txtChat.Enabled = false;
            //Response.Redirect("PlacementServiceRequestSearch.aspx");
        }
    }
    protected void BindData()
    {
        clsPlacementServiceRequest Item = new clsPlacementServiceRequest();
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
        Response.Redirect("PlacementServiceRequestSearch.aspx");
    }


}