using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_PlacementServiceRequest : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int CountNo = 0;
    DateTime CreatedOn;
    DateTime EscalationAfterDate;
    DateTime EscalationClosedDate;
    DateTime DateTime;
    clsPlacementServiceRequest item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
            BindEscalationData();
            BindTopOneServieRequest();

        }
    }
    protected void BindData()
    {
        clsPlacementServiceRequest Item = new clsPlacementServiceRequest();
        Item.ParticipantId = CurrentUser.CurrentParticipantId;
        rp.DataSource = Item.LoadAll(Item);
        rp.DataBind();
    }
    protected void BindTopOneServieRequest()
    {
        item = new clsPlacementServiceRequest();

        if (CurrentUser.CurrentParticipantId > 0)
        {
            item = item.LoadTopOne(CurrentUser.CurrentParticipantId);
            if (item != null)
            {
                btnEscalate.Enabled = true;
                lblLastServiceRequest.Text = item.ServiceRequest;
                hdnPlacementServiceRequestId.Value = Convert.ToString(item.PlacementServiceRequestId);
                hdnCreatedOn.Value = Convert.ToString(item.CreatedOn);
                if (item.SenderImagePath != "")
                    hplSentFile.NavigateUrl = "~/UserDocs/PlacementServiceRequests/" + item.SenderImagePath;
                else
                    hplSentFile.Visible = false;
                if (item.ReceiverImagePath != "")
                    hplReplyFile.NavigateUrl = "~/UserDocs/PlacementServiceRequests/" + item.ReceiverImagePath;
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

    protected void BindCount()
    {
        clsPlacementServiceRequest PlacementServiceRequestCount = new clsPlacementServiceRequest();
        PlacementServiceRequestCount.ParticipantId = CurrentUser.CurrentParticipantId;
        CountNo = PlacementServiceRequestCount.LoadPlacementServiceRequestValidation(PlacementServiceRequestCount);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtChat.Text = "";
            BindData();
            BindEscalationData();
        }
        else
        {
            clsPlacementServiceRequest ParticipantPlacementServiceRequest = new clsPlacementServiceRequest();
            ParticipantPlacementServiceRequest = new clsPlacementServiceRequest();
            ParticipantPlacementServiceRequest.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            ParticipantPlacementServiceRequest.ParticipantId = Convert.ToInt16(CurrentUser.CurrentParticipantId);
            ParticipantPlacementServiceRequest.ServiceRequest = txtChat.Text;
            if (flUpload.HasFile)
            {
                clsFileUpload Upload = new clsFileUpload();
                string filePath = Upload.PlacementServiceRequestFileUpload(flUpload);
                ParticipantPlacementServiceRequest.SenderImagePath = filePath;
            }
            ParticipantPlacementServiceRequest.CreatedBy = CurrentUser.CurrentUserId;
            ParticipantPlacementServiceRequest.AddUpdate(ParticipantPlacementServiceRequest);
            txtChat.Text = "";

            BindData();
            BindTopOneServieRequest();
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }
    }

    protected void txtChat_TextChanged(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtChat.Text = "";
            BindData();
            BindEscalationData();
        }
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
                Response.Redirect("PlacementEscalation.aspx?ItemId=" + hdnPlacementServiceRequestId.Value);
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
    protected void BindEscalationData()
    {
        clsPlacementEscalation Item = new clsPlacementEscalation();
        Item.ParticipantId = CurrentUser.CurrentParticipantId;
        rpEscalation.DataSource = Item.LoadAll(Item);
        rpEscalation.DataBind();
    }

    protected void rpEscalation_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        RepeaterItem item = e.Item;
        if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
        {
            HiddenField hdnRoleId = (HiddenField)item.FindControl("hdnEscalationRoleId");
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