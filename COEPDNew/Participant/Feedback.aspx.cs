using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Participant_Feedback : System.Web.UI.Page
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
        if(ItemId>0)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }
        else
        {
            Response.Redirect("ServiceRequest.aspx");
        }
            
        
    }
    protected void BindCount()
    {
        clsFeedback obj = new clsFeedback();
        obj.ParticipantId = CurrentUser.CurrentParticipantId;
        CountNo = obj.LoadFeedbackValidation(obj);

    }
    protected void BindData()
    {
        clsFeedback Item = new clsFeedback();
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
            clsFeedback ParticipantFeedback = new clsFeedback();
            ParticipantFeedback.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            ParticipantFeedback.ParticipantId = Convert.ToInt16(CurrentUser.CurrentParticipantId);
            ParticipantFeedback.Chat = txtChat.Text;
            if (flUpload.HasFile)
            {
                clsFileUpload Upload = new clsFileUpload();
                string filePath = Upload.NurturingEscalationFileUpload(flUpload);
                ParticipantFeedback.SenderImagePath = filePath;
            }
            ParticipantFeedback.CreatedBy = CurrentUser.CurrentUserId;
            ParticipantFeedback.AddUpdate(ParticipantFeedback);
            txtChat.Text = "";
            flUpload.Enabled= false;
            BindData();
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }
        
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dashboard.aspx");
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
}