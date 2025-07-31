using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLayer;
using System.Activities.Expressions;

public partial class Participant : System.Web.UI.Page
{
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    CurrentUser CurrentUser = new CurrentUser();
    clsParticipant Item;
    int ItemId = 0;
    int DesignationId = 0;
    DateTime DateTime;
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
            BindLocation();
            BindLeadSource();
            BindBranch();
            BindJobDomain();
            BindStatus();
            BindInternBatch();
            //DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30).AddYears(1);

            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Participant";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    DesignationId = CurrentUser.CurrentDesignationId;
                   
                    if (DesignationId == 25 || DesignationId == 2 || DesignationId == 20)
                    {
                        ddlStatus.SelectedValue = Item.StatusId.ToString();

                        ddlStatus.Enabled = true;
                    }
                    else
                    {
                        ddlStatus.SelectedValue = Item.StatusId.ToString();
                        ddlStatus.Enabled = false;
                    }
                    ddlBatch.Enabled = false;
                    ddlBatch.SelectedValue = Item.BatchId.ToString();
                    ddlLocation.SelectedValue = Item.LocationId.ToString();
                    ddlLeadSource.SelectedValue = Item.LeadSourceId.ToString();
                    ddlLeadSource.Enabled = false;
                    BindBranch();
                    ddlBranch.SelectedValue = Item.BranchId.ToString();
                    ddlJobDomain.SelectedValue = Item.DomainId.ToString();
                    txtReferenceNo.Text = Item.ReferenceNo;
                    txtParticipant.Text = Item.Participant;
                    txtMobile.Text = Item.Mobile;
                    txtEmail.Text = Item.Email;
                    txtDescription.Text = Item.Remarks;
                    txtFee.Text = Item.Fee.ToString();
                   // DesignationId = CurrentUser.CurrentDesignationId;
                    txtSubscriptionExpiredOn.Text = Item.SubscriptionExpiredOn.ToString("dd/MM/yyyy");
                    if (DesignationId == 25 || DesignationId == 2)
                    {
                        DesignationId = CurrentUser.CurrentEmployeeId;

                        txtSubscriptionExpiredOn.Enabled = true;
                    }
                    else
                    {
                        txtSubscriptionExpiredOn.Enabled = false;

                    }


                    if (Item.YearsOfExp > 0)
                    {
                        txtYears.Text = Item.YearsOfExp.ToString();
                    }



                    if (Item.YearsOfExp > 0)
                    {
                        txtYears.Text = Item.YearsOfExp.ToString();
                    }

                    if (Item.MonthsOfExp > 0)
                    {
                        txtMonths.Text = Item.MonthsOfExp.ToString();
                    }
                    if (Item.IsIntern != false)
                    {
                        ChkIntern.Checked = true;
                      
                    }
                    if (ChkIntern.Checked == true)
                    {
                        divinternBatch.Visible = true;
                        ddlInternbatch.SelectedValue = Item.InternBatchId.ToString();
                    }
                    else
                    {
                        divinternBatch.Visible = false;
                    }
                }

                if (Item.IsExamPermit == true)
                {
                    chkIsExamPermit.Checked = true;
                }
                else
                {
                    chkIsExamPermit.Checked = false;
                }
            }
            else
            {
                lblTitle.Text = "Add New Participant";
               
                txtSubscriptionExpiredOn.Enabled= false;

                divinternBatch.Visible = false;
                


            }
        }

        if (ChkIntern.Checked == true)
        {
            divinternBatch.Visible = true;
        }
        else
        {
            divinternBatch.Visible = false;
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
    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("--Select Location--", ""));
    }

    protected void BindLeadSource()
    {
        clsLeadSource obj = new clsLeadSource();
        ddlLeadSource.DataSource = obj.LoadAll(obj);
        ddlLeadSource.DataTextField = "LeadSource";
        ddlLeadSource.DataValueField = "LeadSourceId";
        ddlLeadSource.DataBind();
        ddlLeadSource.Items.Insert(0, new ListItem("-- Select Lead Source --", ""));
    }
    protected void BindBranch()
    {
        //clsBranch obj = new clsBranch();
        //ddlBranch.DataSource = obj.LoadAll(obj);
        //ddlBranch.DataTextField = "Branch";
        //ddlBranch.DataValueField = "BranchId";
        //ddlBranch.DataBind();
        //ddlBranch.Items.Insert(0, new ListItem("--Select Branch--", ""));
        ddlBranch.Items.Clear();
        if (ddlLocation.SelectedValue != "")
        {
            clsBranch obj = new clsBranch();
            obj.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
            ddlBranch.DataSource = obj.LoadAll(obj);
            ddlBranch.DataTextField = "Branch";
            ddlBranch.DataValueField = "BranchId";
            ddlBranch.DataBind();
            ddlBranch.Items.Insert(0, new ListItem("--Select Branch--", ""));
        }
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

    protected void BindInternBatch()
    {
        clsInternBatch obj = new clsInternBatch();
        ddlInternbatch.DataSource = obj.LoadAll(obj);
        ddlInternbatch.DataTextField = "InternBatch";
        ddlInternbatch.DataValueField = "InternBatchId";
        ddlInternbatch.DataBind();
        ddlInternbatch.Items.Insert(0, new ListItem("-- Select Intern Batch --", "0"));
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.ParticipantId = Convert.ToInt16(ItemId);
        }
        Item.ReferenceNo = Convert.ToString(txtReferenceNo.Text);
        Item.Participant = Convert.ToString(txtParticipant.Text);
        Item.BatchId = Convert.ToInt32(ddlBatch.SelectedValue);
        Item.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
        Item.LeadSourceId = Convert.ToInt32(ddlLeadSource.SelectedItem.Value);
        Item.BranchId = Convert.ToInt32(ddlBranch.SelectedValue);
        Item.DomainId = Convert.ToInt16(ddlJobDomain.Text);
        Item.Email = Convert.ToString(txtEmail.Text);
        Item.Mobile = Convert.ToString(txtMobile.Text);
        Item.Fee = Convert.ToDecimal(txtFee.Text);
        if (txtSubscriptionExpiredOn.Text != "")
        {
            DateTime Date = DateTime.ParseExact(txtSubscriptionExpiredOn.Text, "dd/MM/yyyy", null);
            Item.SubscriptionExpiredOn = Convert.ToDateTime(Date);
        }
        
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
            //string strFilePath = objFile.UploadDoc(fl);
            string strFilePath = objFile.ParticipantUploadDoc(fl);
            Item.CertificatePath = strFilePath;
        }
        Item.Remarks = Convert.ToString(txtDescription.Text);
         Item.StatusId = Convert.ToInt32(ddlStatus.SelectedValue);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        if (ChkIntern.Checked)
        {
            Item.IsIntern = true;
            Item.InternBatchId = Convert.ToInt32(ddlInternbatch.SelectedValue);
        }
        else
        {
            Item.IsIntern = false;
            Item.InternBatchId = 0;
        }

        if(chkIsExamPermit.Checked==true)
        {
            Item.IsExamPermit = true;
        }
        else
        {
            Item.IsExamPermit = false;
        }
        Item.AddUpdate(Item);
        btnSubmit.Enabled = false;
        if(ItemId>0)
        {
            FormMessage.Text = "Participant details Successfully Updated.";
            FormMessage.Visible = true;
            ErrorMessage.Visible = false;
            btnAssignDefaultFeatures.Visible = true;
            btnAssignFeatures.Visible = true;

        }
        else
        {
            Response.Redirect("ParticipantSearch.aspx");
        }

        //Response.Redirect("ParticipantSearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantSearch.aspx");
        //Server.Transfer("ParticipantSearch.aspx");
    }

    protected void txtReferenceNo_TextChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(Constr);
        con.Open();
        string str = "select COUNT(*)from tblParticipant where ReferenceNo ='" + txtReferenceNo.Text + "'";
        SqlCommand com = new SqlCommand(str, con);
        int count = Convert.ToInt32(com.ExecuteScalar());
        if (count > 0)
        {

            divReferNo.Visible = true;
            lblRefeno.Visible = true;
            lblRefeno.ForeColor = System.Drawing.Color.Red;
            lblRefeno.Text = "Someone already has that Reference Number";
            txtReferenceNo.Text = "";
        }
        else
        {
            divReferNo.Visible = false;
            lblRefeno.Visible = false;
        }
        con.Close();
    }

    protected void txtMobile_TextChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(Constr);
        con.Open();
        string str = "select COUNT(*)from tblParticipant where Mobile ='" + txtMobile.Text + "'";
        SqlCommand com = new SqlCommand(str, con);
        int count = Convert.ToInt32(com.ExecuteScalar());
        if (count > 0)
        {
            divMobile.Visible = true;          
            lblmobile.Visible = true;
            lblmobile.ForeColor = System.Drawing.Color.Red;
            lblmobile.Text = "Someone already has that Mobile Number";
            txtMobile.Text = "";
        }
        else
        {

            divMobile.Visible = false;
            lblmobile.Visible = false;
        }
        con.Close();
    }

    protected void txtEmail_TextChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(Constr);
        con.Open();
        string str = "select COUNT(*)from tblParticipant where Email ='" + txtEmail.Text + "'";
        SqlCommand com = new SqlCommand(str, con);
        int count = Convert.ToInt32(com.ExecuteScalar());
        if (count > 0)
        {
            divEmail.Visible = true;
            lblEmail.Visible = true;
            lblEmail.ForeColor = System.Drawing.Color.Red;
            lblEmail.Text = "Someone already has that EmailID";
            txtEmail.Text = "";
        }
        else
        {
            divEmail.Visible = false;
            lblEmail.Visible = false;
        }
        con.Close();
    }

    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlLocation.SelectedValue != null)
        {
            BindBranch();
        }
    }

    protected void btnAssignDefaultFeatures_Click(object sender, EventArgs e)
    {
        if(ItemId>0)
        {
            int[] FeatureIds = { 10, 12, 13, 14, 17, 18, 24,32 };
            int PartcipantId = ItemId;
            int CountNo = 0;
            clsParticipantFeatureAccess Obj = new clsParticipantFeatureAccess();
            foreach (int i in FeatureIds)
            {
                Obj.ParticipantId = PartcipantId;
                Obj.FeatureId = i;
                Obj.CreatedBy = CurrentUser.CurrentUserId;
                CountNo = Obj.ParticipantFeatureValidation(Obj);
                if (CountNo == 0)
                {
                    Obj.AddUpdate(Obj);
                }

            }
            Obj.ParticipantId = PartcipantId;
            Obj.FeatureId = 23;
            Obj.RemoveByParticipant(Obj);
            clsExamCategoryAssignment ObjECA = new clsExamCategoryAssignment();
            ObjECA.ParticipantId = PartcipantId;
            ObjECA.CategoryId = 1;
            ObjECA.CreatedBy = CurrentUser.CurrentUserId;
            int CategoryCountNO = 0;
            CategoryCountNO = ObjECA.Validation(ObjECA);
            if (CategoryCountNO == 0)
            {
                ObjECA.AddUpdate(ObjECA);
            }

            FormMessage.Visible = true;
            FormMessage.Text = "Default Features Successfully Assigned.";
            btnAssignDefaultFeatures.Enabled = false;
        }

    }

    protected void btnAssignFeatures_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
            Response.Redirect("ParticipantFeatureAccessSearch.aspx?ItemId=" + ItemId);
        else
            Response.Redirect("ParticipantFeatureAccessSearch.aspx");

    }

    protected void ddlBatch_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlBatch.SelectedIndex > 0)
        {
            string Batch = ddlBatch.SelectedItem.ToString();
            string BatchDate = Batch.Substring(0, 10);
            DateTime BatchDateDate = Convert.ToDateTime(BatchDate);
            DateTime = BatchDateDate.AddYears(1);
            txtSubscriptionExpiredOn.Text = DateTime.ToString("dd/MM/yyyy");
        }
        else
        {
            txtSubscriptionExpiredOn.Text = "";
        }
    }
}