using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_ParticipantPlacementAssistanceDataSheet : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;
    clsParticipant Item;
    int itemId = 0;
    int CountNo = 0;
    clsParticipantPlacementAssistanceDataSheet item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = CurrentUser.CurrentParticipantId;
        itemId = Convert.ToInt32(Request.QueryString["itemId"]);
        item = new clsParticipantPlacementAssistanceDataSheet();
        Item = new clsParticipant();
            if(!IsPostBack)
            {
             LoadNoticePeriod();
            if (itemId>0)
                {
                item = item.Load(itemId);
                if (item != null)
                {
                    txtFullName.Text = item.FullName;
                    //hdnParticipantId.Value = item.ParticipantId.ToString();
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
                   // txtNoticePeriod.Text = item.NoticePeriod;
                   ddlNoticePeriod.SelectedValue = item.NoticePeriodId.ToString();
                   chkTermsAccepted.Checked = true;


                    if (item.PassportSizePhotoImagePath != "")
                    {
                        hplPhotoFile.Visible = true;
                        hplPhotoFile.NavigateUrl = "~/UserDocs/PlacementsDataSheet/" + item.PassportSizePhotoImagePath;
                    }
                    else
                        hplPhotoFile.Visible = false;



                    if (item.AadharCardFrontImagePath!= "")
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




                    lblPhoto.Visible = false;
                    flUploadPhoto.Visible = false;

                    lblAadharFront.Visible = false;
                    flUploadAadharFront.Visible = false;

                    lblAadharBack.Visible = false;
                    flUploadAadharBack.Visible = false;

                    lblSalarySlip.Visible = false;
                    flUploadSalarySlip.Visible = false;


                    lblServiceForm.Visible = false;
                    flUploadPlacementWingServiceForm.Visible = false;


                    chkTermsAccepted.Visible = false;
                    lblTerms.Visible = false;


                    lblFormDoc.Visible = false;



                    btnSubmit.Visible = false;

                }

            }
                else
                {
                if(ItemId>0)
                {
                    item.ParticipantId = ItemId;
                    CountNo = item.LoadParticipantPlacementAssistanceDataSheetValidation(item);
                    if(CountNo>0)
                    {
                        Response.Redirect("ParticipantPlacementAssistanceDataSheetSearch.aspx");
                    }
                    else
                    {
                        Item = Item.Load(ItemId);
                        if (Item != null)
                        {
                            txtFullName.Text = Item.Participant;
                            txtActiveMobile.Text = Item.Mobile;
                            txtEmailId.Text = Item.Email;
                            txtBatchDate.Text = Item.StartDate.ToString();
                            txtTrainerName.Text = Item.Employee;
                            txtTrainingLocation.Text = Item.Location;
                            txtTotalFeesPaid.Text = Convert.ToString(Item.Fee);
                            ddlExperienceInYears.SelectedValue = Convert.ToString(Item.TotalExperience);
                            ddlRelevantExperience.SelectedValue = Convert.ToString(Item.RelevantExperience);

                            ddlExperienceInMonths.Text = item.TotalExperienceMonths.ToString();
                            ddlRelevantExperienceMonths.Text = item.RelevantExperienceMonths.ToString();

                            ddlCommunicationRating.SelectedValue=Convert.ToString(Item.CommunicationSkillsRating);
                            txtBASkills.Text = Item.BASkills;
                            txtCurrentCTC.Text = Convert.ToString(Item.CurrentCTC);
                            txtExpectedSalary.Text = Convert.ToString(Item.ExpectedCTC);
                            chkTermsAccepted.Checked = true;
                            hplPhotoFile.Visible = false;
                            hplAadharFrontFile.Visible = false;
                            hplAadharBackFile.Visible = false;
                            hplSalarySlipFile.Visible = false;
                            hplServiceForm.Visible = false;

                        }
                    }
                    
                }
                else
                {
                    Response.Redirect("~/Login.html");
                }

            }
                
            }
            //if(chkTermsAccepted.Checked == true)
            //{
            //    btnSubmit.Visible = true;
            //}
            //else
            //{
            //btnSubmit.Visible = false;
            //}


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
        if(CurrentUser.CurrentParticipantId>0)
        {
            item = new clsParticipantPlacementAssistanceDataSheet();
            if (itemId > 0)
                item.ParticipantPlacementAssistanceDataSheetId = ItemId;
            item.ParticipantId = CurrentUser.CurrentParticipantId;
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

            // item.NoticePeriod = txtNoticePeriod.Text;
            item.NoticePeriodId = Convert.ToInt32(ddlNoticePeriod.SelectedValue);
            item.NoticePeriod = Convert.ToString(ddlNoticePeriod.Text);
            if (flUploadPhoto.FileName.Length > 0)
            {
                clsFileUpload Upload = new clsFileUpload();
                string strFilePath = Upload.DataSheetUploadDoc(flUploadPhoto);
                item.PassportSizePhotoImagePath = strFilePath;
            }
            if (flUploadAadharFront.FileName.Length > 0)
            {
                clsFileUpload Upload = new clsFileUpload();
                string strFilePath = Upload.DataSheetUploadDoc(flUploadAadharFront);
                item.AadharCardFrontImagePath = strFilePath;
            }
            if (flUploadAadharBack.FileName.Length > 0)
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
            item.IsDataSheetApproved = false;
            item.CreatedBy = CurrentUser.CurrentUserId;
            item.AddUpdate(item);
            txtFullName.Text = "";
            txtDateofBirth.Text = "";
            txtActiveMobile.Text = "";
            txtEmailId.Text = "";
            txtBatchDate.Text = "";
            txtTrainerName.Text = "";
            txtTrainingLocation.Text = "";
            ddlNurturingStatus.SelectedIndex = -1;
            txtTotalFeesPaid.Text = "";
            ddlExperienceInYears.SelectedIndex = -1;
            ddlRelevantExperience.SelectedIndex = -1;
            txtJobExperienceDomain.Text = "";
            txtJobExpectedDomain.Text = "";
            ddlCommunicationRating.SelectedIndex = -1;
            txtBASkills.Text = "";
            txtCurrentCTC.Text = "";
            txtExpectedSalary.Text = "";
            txtCurrentLocation.Text = "";
            txtPreferredLocation.Text = "";
            txtResumeFinalizedOn.Text = "";
            ddlNoticePeriod.SelectedIndex = -1;
            //txtNoticePeriod.Text = "";
            btnSubmit.Enabled = false;

            if (ItemId > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);

            }
        }
        else
        {
            Response.Redirect("~/Login.html");
        }
       

    }

    protected void btnBacktoDashboard_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantPlacementAssistanceDataSheetSearch.aspx");
    }
}