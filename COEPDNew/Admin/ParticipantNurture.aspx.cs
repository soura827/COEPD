using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ParticipantNurture : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsParticipantNurture Item = null;

    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsParticipantNurture();

        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Nurturing Request";
                Item = Item.Load(ItemId);

                clsParticipant ParticipantItem = new clsParticipant();
                ParticipantItem = ParticipantItem.Load(Item.ParticipantId);
                lblParticipant.Text = ParticipantItem.Participant;
                hdnPartcipantId.Value = Convert.ToString(ParticipantItem.ParticipantId);


                clsBatch BatchItem = new clsBatch();
                BatchItem = BatchItem.LoadParticipantByBatch(ParticipantItem.BatchId);
                lblLocation.Text = BatchItem.Location;
                lblTrainer.Text = BatchItem.Employee;
                lblBatchType.Text = BatchItem.BatchType;
                lblDate.Text = BatchItem.StartDate.ToString();
                BindData();
            }
            else
            {
                lblTitle.Text = "Add New Nurturing Request";
            }
        }
    }

    protected void BindData()
    {
        clsParticipantNurture ParticipantNurture = new clsParticipantNurture();
        ParticipantNurture.ParticipantId = Convert.ToInt16(Item.ParticipantId);
        rp.DataSource = ParticipantNurture.LoadAll(ParticipantNurture);
        rp.DataBind();
    }

    protected void rp_OnItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        RepeaterItem item = e.Item; if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
        {
            HiddenField hdnUserId = (HiddenField)item.FindControl("hdnUserId");
            int UserId = Convert.ToInt16(hdnUserId.Value);

            if (UserId == CurrentUser.CurrentUserId)
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

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsParticipantNurture ParticipantNurture = new clsParticipantNurture();
        ParticipantNurture.ParticipantId = Convert.ToInt16(hdnPartcipantId.Value);
        ParticipantNurture.ParticipantNurture = txtNotes.Text;
        ParticipantNurture.CreatedBy = CurrentUser.CurrentUserId;
        ParticipantNurture.EmployeeId =CurrentUser.CurrentEmployeeId;
        ParticipantNurture.StatusId = 1;
        ParticipantNurture.ParentParticipantNurtureId = ItemId;
        ParticipantNurture.AddUpdate(ParticipantNurture);
        BindData();
        FormMessage.Text = "New Item successfully saved";
        FormMessage.Visible = true;
        btnSubmit.Enabled = false;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantNurtureSearch.aspx");
    }

}