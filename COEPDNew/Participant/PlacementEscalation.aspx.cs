using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_PlacementEscalation : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int CountNo = 0;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (ItemId > 0)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }
        else
        {
            Response.Redirect("PlacementServiceRequest.aspx");
        }

    }
    protected void BindCount()
    {
        clsPlacementEscalation obj = new clsPlacementEscalation();
        obj.ParticipantId = CurrentUser.CurrentParticipantId;
        CountNo = obj.LoadPlacementEscalationValidation(obj);

    }

    protected void BindData()
    {
        clsPlacementEscalation Item = new clsPlacementEscalation();
        Item.ParticipantId = CurrentUser.CurrentParticipantId;
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

    protected void txtChat_TextChanged(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtChat.Text = "";
            BindData();
        }
    }


    protected void btnSend_Click(object sender, EventArgs e)
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
            clsPlacementEscalation ParticipantPlacementEscalation = new clsPlacementEscalation();
            ParticipantPlacementEscalation.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            ParticipantPlacementEscalation.ParticipantId = Convert.ToInt16(CurrentUser.CurrentParticipantId);
            ParticipantPlacementEscalation.Escalation = txtChat.Text;
            ParticipantPlacementEscalation.CreatedBy = CurrentUser.CurrentUserId;
            if (flUpload.HasFile)
            {
                clsFileUpload Upload = new clsFileUpload();
                string filePath = Upload.PlacementEscalationFileUpload(flUpload);
                ParticipantPlacementEscalation.SenderImagePath = filePath;
            }
            ParticipantPlacementEscalation.AddUpdate(ParticipantPlacementEscalation);
            txtChat.Text = "";
            flUpload.Enabled = false;
            BindData();
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dashboard.aspx");
    }
}