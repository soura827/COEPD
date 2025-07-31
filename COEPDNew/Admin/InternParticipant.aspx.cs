using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_InternParticipant : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsParticipant Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsParticipant();
        if (!IsPostBack)
        {
            BindBatch();
            BindJobDomain();
            BindStatus();

            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Intern";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlStatus.SelectedValue = Item.StatusId.ToString();
                    ddlBatch.SelectedValue = Item.BatchId.ToString();
                    ddlJobDomain.SelectedValue = Item.DomainId.ToString();
                    txtReferenceNo.Text = Item.ReferenceNo;
                    txtParticipant.Text = Item.Participant;
                    txtMobile.Text = Item.Mobile;
                    txtEmail.Text = Item.Email;
                    txtDescription.Text = Item.Remarks;
                    txtFee.Text = Item.Fee.ToString();
                    if (Item.YearsOfExp > 0)
                    {
                        txtYears.Text = Item.YearsOfExp.ToString();
                    }

                    if (Item.MonthsOfExp > 0)
                    {
                        txtMonths.Text = Item.MonthsOfExp.ToString();
                    }
                  
                }
            }
            else
            {
                lblTitle.Text = "Add New Intern ";
            }
        }
    }

          protected void BindBatch()
    {
        clsBatch obj = new clsBatch();
        ddlBatch.DataSource = obj.LoadAll(obj);
        ddlBatch.DataTextField = "Batch";
        ddlBatch.DataValueField = "BatchId";
        ddlBatch.DataBind();
        ddlBatch.Items.Insert(0, new ListItem("-- Select Batch --", ""));
    }
    protected void BindJobDomain()
    {
        clsJobDomain obj = new clsJobDomain();
        ddlJobDomain.DataSource = obj.LoadAll(obj);
        ddlJobDomain.DataTextField = "JobDomain";
        ddlJobDomain.DataValueField = "JobDomainId";
        ddlJobDomain.DataBind();
        ddlJobDomain.Items.Insert(0, new ListItem("-- Select Domain --", "0"));
    }

    protected void BindStatus()
    {
        clsParticipantStatus obj = new clsParticipantStatus();
        ddlStatus.DataSource = obj.LoadAll(obj);
        ddlStatus.DataTextField = "ParticipantStatus";
        ddlStatus.DataValueField = "ParticipantStatusId";
        ddlStatus.DataBind();
        ddlStatus.Items.Insert(0, new ListItem("-- Select Status --", ""));
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.ParticipantId = Convert.ToInt16(ItemId);
        }

        Item.ReferenceNo = Convert.ToString(txtReferenceNo.Text);
        Item.Participant = Convert.ToString(txtParticipant.Text);
        Item.BatchId = Convert.ToInt16(ddlBatch.SelectedValue);
        Item.LocationId = 0;
        Item.DomainId = Convert.ToInt16(ddlJobDomain.Text);
        Item.Email = Convert.ToString(txtEmail.Text);
        Item.Mobile = Convert.ToString(txtMobile.Text);
        Item.Fee = Convert.ToDecimal(txtFee.Text);
        if (txtYears.Text.Length > 0)
        {
            Item.YearsOfExp = Convert.ToInt16(txtYears.Text);
        }

        if (txtMonths.Text.Length > 0)
        {
            Item.MonthsOfExp = Convert.ToInt16(txtMonths.Text);
        }

        if (fl.FileName.Length > 0)
        {
            clsFileUpload objFile = new clsFileUpload();
            string strFilePath = objFile.ParticipantUploadDoc(fl);
            Item.CertificatePath = strFilePath;
        }
        Item.Remarks = Convert.ToString(txtDescription.Text);
        Item.StatusId = Convert.ToInt32(ddlStatus.SelectedValue);
        Item.CreatedBy = CurrentUser.CurrentUserId;
       
        Item.IsIntern = true;
       
        Item.AddUpdate(Item);
        Response.Redirect("InternParticipantSearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("InternParticipantSearch.aspx");
    }
}