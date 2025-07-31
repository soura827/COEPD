using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ParticipantPlacementAssistanceDataSheet : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int itemId = 0;
    clsParticipantPlacementAssistanceDataSheet item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        itemId = Convert.ToInt32(Request.QueryString["itemId"]);
        item = new clsParticipantPlacementAssistanceDataSheet();
        if (itemId > 0)
        {
            if (!IsPostBack)
            {
                LoadNoticePeriod();
                item = item.Load(itemId);
                if (item != null)
                {
                    txtFullName.Text = item.FullName;
                    hdnParticipantId.Value = item.ParticipantId.ToString();
                    txtDateofBirth.Text = item.DateOfBirth.ToString("dd/MM/yyyy");
                    txtActiveMobile.Text = item.ActiveMobile;
                    txtEmailId.Text = item.Email;
                    txtBatchDate.Text = item.Batch.ToString();
                    txtTrainerName.Text = item.TrainerName;
                    txtTrainingLocation.Text = item.LocationOfTraining;
                    ddlNurturingStatus.Text = item.NurturingStatusId.ToString();
                    txtTotalFeesPaid.Text = Convert.ToString(item.TotalFeePaid);
                    ddlExperienceInYears.Text = item.TotalExperience.ToString();
                    ddlRelevantExperience.Text = item.RelevantExperience.ToString();

                    ddlExperienceInMonths.Text = item.TotalExperienceMonths.ToString();
                    ddlRelevantExperienceMonths.Text = item.RelevantExperienceMonths.ToString();

                    txtJobExperienceDomain.Text = item.JobExperienceDomain;
                    txtJobExpectedDomain.Text = item.JobExpectedDomain;
                    ddlCommunicationRating.Text = item.CommunicationSkillsRating.ToString();
                    txtBASkills.Text = item.BASkills;
                    txtCurrentCTC.Text = item.CurrentCTC.ToString();
                    txtExpectedSalary.Text = Convert.ToString(item.ExpectedCTC);
                    txtCurrentLocation.Text = item.CurrentLocation;
                    txtPreferredLocation.Text = item.PreferredLocations;
                    txtResumeFinalizedOn.Text = item.ResumeFinalizedOn.ToString("dd/MM/yyyy");
                    ddlNoticePeriod.SelectedValue = item.NoticePeriodId.ToString();
                    //txtNoticePeriod.Text = item.NoticePeriod;



                    if (item.IsDataSheetApproved == true)
                        ddlIsDataSheetApproved.Text = item.IsDataSheetApproved.ToString();
                    if (item.PassportSizePhotoImagePath != "")
                    {
                        hplPhotoFile.Visible = true;
                        hplPhotoFile.NavigateUrl = "~/UserDocs/PlacementsDataSheet/" + item.PassportSizePhotoImagePath;
                    }
                    else
                        hplPhotoFile.Visible = false;
                    if (item.AadharCardFrontImagePath != "")
                    {
                        hplAadharFrontFile.Visible = true;
                        hplAadharFrontFile.NavigateUrl = "~/UserDocs/PlacementsDataSheet/" + item.AadharCardFrontImagePath;
                    }
                    else
                        hplAadharFrontFile.Visible = false;
                    if (item.AadharCardBackImagePath != "")
                    {
                        hplAadharBackFile.Visible = true;
                        hplAadharBackFile.NavigateUrl = "~/UserDocs/PlacementsDataSheet/" + item.AadharCardBackImagePath;
                    }
                    else
                        hplAadharBackFile.Visible = false;

                    if (item.SalarySlipImagePath != "")
                    {
                        hplSalarySlipFile.Visible = true;
                        hplSalarySlipFile.NavigateUrl = "~/UserDocs/PlacementsDataSheet/" + item.SalarySlipImagePath;
                    }
                    else
                        hplSalarySlipFile.Visible = false;


                    if (item.ServiceFormImagePath != "")
                    {
                        hplServiceForm.Visible = true;
                        hplServiceForm.NavigateUrl = "~/UserDocs/PlacementsDataSheet/" + item.ServiceFormImagePath;
                    }
                    else
                        hplServiceForm.Visible = false;



                    //chkTermsAccepted.Checked = true;
                }
            }
        }
        else
        {
            Response.Redirect("ParticipantPlacementAssistanceDataSheetSearch.aspx");
        }
    }
    protected void LoadNoticePeriod()
    {
        ddlNoticePeriod.Items.Clear();
        clsParticipantPlacementAssistanceDataSheet obj = new clsParticipantPlacementAssistanceDataSheet();
        //obj.keywords = txtSearch.Text;
        ddlNoticePeriod.DataSource = obj.LoadAllNoticePeriod(obj);
        ddlNoticePeriod.DataTextField = "NoticePeriod";
        ddlNoticePeriod.DataValueField = "NoticePeriodId";
        ddlNoticePeriod.DataBind();
        ddlNoticePeriod.Items.Insert(0, new ListItem("-- Select Notice Period -- ", ""));
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        item = new clsParticipantPlacementAssistanceDataSheet();
        if (itemId > 0)
        {
            item.ParticipantPlacementAssistanceDataSheetId = itemId;
        }
        item.ParticipantId = Convert.ToInt32(hdnParticipantId.Value);
        item.FullName = txtFullName.Text;
        if (txtDateofBirth.Text != "")
        {
            DateTime Date = DateTime.ParseExact(txtDateofBirth.Text, "dd/MM/yyyy", null);
            item.DateOfBirth = Convert.ToDateTime(Date);
        }
        item.ActiveMobile = txtActiveMobile.Text;
        item.Email = txtEmailId.Text;
        item.Batch = Convert.ToDateTime(txtBatchDate.Text);
        item.TrainerName = txtTrainerName.Text;
        item.LocationOfTraining = txtTrainingLocation.Text;
        item.NurturingStatusId = Convert.ToInt16(ddlNurturingStatus.SelectedValue);
        item.TotalFeePaid = Convert.ToDecimal(txtTotalFeesPaid.Text);
        item.TotalExperience = Convert.ToInt16(ddlExperienceInYears.Text);
        item.RelevantExperience = Convert.ToInt16(ddlRelevantExperience.SelectedValue);
        item.TotalExperienceMonths = Convert.ToInt16(ddlExperienceInMonths.SelectedValue);
        item.RelevantExperienceMonths = Convert.ToInt16(ddlRelevantExperienceMonths.SelectedValue);
        item.JobExperienceDomain = txtJobExperienceDomain.Text;
        item.JobExpectedDomain = txtJobExpectedDomain.Text;
        item.CommunicationSkillsRating = Convert.ToInt16(ddlCommunicationRating.SelectedValue);
        item.BASkills = txtBASkills.Text;
        item.CurrentCTC = Convert.ToDecimal(txtCurrentCTC.Text);
        item.ExpectedCTC = Convert.ToDecimal(txtExpectedSalary.Text);
        item.CurrentLocation = txtCurrentLocation.Text;
        item.PreferredLocations = txtPreferredLocation.Text;
        if (txtResumeFinalizedOn.Text != "")
        {
            DateTime Date = DateTime.ParseExact(txtResumeFinalizedOn.Text, "dd/MM/yyyy", null);
            item.ResumeFinalizedOn = Convert.ToDateTime(Date);
        }

        //item.NoticePeriod = txtNoticePeriod.Text;
        item.NoticePeriodId = Convert.ToInt32(ddlNoticePeriod.SelectedValue);
        if (flUploadPhoto.HasFile)
        {
            clsFileUpload Upload = new clsFileUpload();
            string strFilePath = Upload.DataSheetUploadDoc(flUploadPhoto);
            item.PassportSizePhotoImagePath = strFilePath;
        }
        if (flUploadAadharFront.HasFile)
        {
            clsFileUpload Upload = new clsFileUpload();
            string strFilePath = Upload.DataSheetUploadDoc(flUploadAadharFront);
            item.AadharCardFrontImagePath = strFilePath;
        }
        if (flUploadAadharBack.HasFile)
        {
            clsFileUpload Upload = new clsFileUpload();
            string strFilePath = Upload.DataSheetUploadDoc(flUploadAadharBack);
            item.AadharCardBackImagePath = strFilePath;
        }
        if (flUploadSalarySlip.FileName.Length > 0)
        {
            clsFileUpload Upload = new clsFileUpload();
            string strFilePath = Upload.DataSheetUploadDoc(flUploadSalarySlip);
            item.SalarySlipImagePath = strFilePath;
        }

        if (flUploadPlacementWingServiceForm.FileName.Length > 0)
        {
            clsFileUpload Upload = new clsFileUpload();
            string strFilePath = Upload.DataSheetUploadDoc(flUploadPlacementWingServiceForm);
            item.ServiceFormImagePath = strFilePath;
        }






        //if (chkTermsAccepted.Checked == true)
        //{
        //    item.IsTermsAccepted = true;
        //}
        //else
        //{
        //    item.IsTermsAccepted = false;
        //}
        item.IsDataSheetApproved = Convert.ToBoolean(ddlIsDataSheetApproved.SelectedValue);
        item.CreatedBy = CurrentUser.CurrentUserId;
        item.AddUpdate(item);
        if (Convert.ToBoolean(ddlIsDataSheetApproved.SelectedValue) == true)
        {
            clsParticipantFeatureAccess CPFA = new clsParticipantFeatureAccess();
            int[] FeatureIds = { 25, 26 };

            int CountNo = 0;
            foreach (int FeatureId in FeatureIds)
            {
                CPFA.FeatureId = FeatureId;
                CPFA.ParticipantId = Convert.ToInt32(hdnParticipantId.Value);
                CPFA.CreatedBy = CurrentUser.CurrentUserId;
                CountNo = CPFA.ParticipantFeatureValidation(CPFA);
                if (CountNo == 0)
                {
                    CPFA.AddUpdate(CPFA);
                }
            }

        }
        if (Request.QueryString["Admin"] == "1")
        {
            Response.Redirect("ParticipantPlacementAssistanceDataSheetSearchAdmin.aspx");
        }
        else
        {
            Response.Redirect("ParticipantPlacementAssistanceDataSheetSearch.aspx");
        }

    }

    //protected void btnBacktoDashboard_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("ParticipantPlacementAssistanceDataSheetSearch.aspx");
    //}

    protected void btnBack_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["Admin"] == "1")
        {
            Response.Redirect("ParticipantPlacementAssistanceDataSheetSearchAdmin.aspx");
        }
        else
        {
            Response.Redirect("ParticipantPlacementAssistanceDataSheetSearch.aspx");
        }
    }
}