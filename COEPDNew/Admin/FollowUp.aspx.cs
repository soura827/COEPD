using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using BusinessLayer;
using Label = System.Web.UI.WebControls.Label;

public partial class FollowUp : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsLead Item;
    int ItemId = 0;
    DateTime DateTime;
    int LeadCategoryId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsLead();
        // DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30).AddYears(1);
        //StringDate = DateTime.ToString("dd/MM/yyyy");
        if (!IsPostBack)
        {
            BindBatchType();
            BindCourse();
            BindLocation();
            BindCommunicationType();
            BindLeadSource();
            BindLeadCategory();
            BindDemoData();
            BindDemoAttendence();
            if (ItemId > 0)
            {
                lblTitle.Text = "Lead FollowUp";
                Item = Item.Load(ItemId);
                if (Item != null)
                {


                    chkBetterPay.Checked = Item.BetterPay;
                    chkJobLess.Checked = Item.JobLess;
                    chkFriendsAdvise.Checked = Item.FriendsAdvise;
                    chkIJM.Checked = Item.IJM;
                    chkNoMoney.Checked = Item.NoMoney;
                    chkFamilyMemberGuidence.Checked = Item.FamilyMemberGuidance;
                    chkCertifications.Checked = Item.Certification;
                    chkPresentWorking.Checked = Item.Presentlyworking;
                    chkCoepdPreviousPlacement.Checked = Item.COEPDPreviousPlacements;
                    chkKnowledgeEnhancement.Checked = Item.KnowledgeEnhancement;
                    chkweekendsAvailable.Checked = Item.WeekendsAvailable;
                    chkCOEPDgoodreviews.Checked = Item.COEPDGoodReviews;
                    chkWantToShiftToIT.Checked = Item.WantToShiftToIT;
                    chkWeekDaysDailyOnehour.Checked = Item.WeekDaysDailyOneHour;
                    chkFees.Checked = Item.Fees;
                    chkMarriage.Checked = Item.Marriage;
                    chkPutDownPapers.Checked = Item.PutDownPapers;
                    chkDiscounts.Checked = Item.Discounts;
                    chkMoveToDifferentCity.Checked = Item.MoveToDifferentCity;
                    chkInThreeMonthsWantANewJob.Checked = Item.InThreeMonthsWantANewJob;
                    chkSelfSponsored.Checked = Item.SelfSponsored;
                    chkStableJob.Checked = Item.StableJob;
                    chkDontWantToKeepPseudoExperience.Checked = Item.DontWantToKeepPseudoExperience;
                    chkSponsoredByAFriendAndFamilyMember.Checked = Item.SponsoredByAFriendFamilyMember;
                    chkNoTensionJob.Checked = Item.NoTensionJob;
                    chkKeenToRetainPreviousExperience.Checked = Item.KeenToRetainPreviousExperience;
                    chkTimeSlotsAvailability.Checked = Item.TimeSlotsAvailability;
                    chkSlowLearner.Checked = Item.SlowLearner;
                    chkClassRoomPreferences.Checked = Item.ClassroomPreferences = chkClassRoomPreferences.Checked;
                    chkNewToThisSubjectBA.Checked = Item.NewToThisSubjectBA;
                    chkConfiedenceOfDoingThisCourseAndGettingAJob.Checked = Item.ConfidenceOfDoingThisCourseAndGettingAJob;


                    txtLead.Text = Item.Lead;
                    ddlLeadCategory.SelectedValue = Item.LeadCategoryId.ToString();
                    ddlBatchType.SelectedValue = Item.BatchTypeId.ToString();
                    ddlCourse.SelectedValue = Item.CourseId.ToString();
                    ddlLocation.SelectedValue = Item.LocationId.ToString();
                    ddlCommunicationType.SelectedValue = Item.CommunicationTypeId.ToString();
                    txtPrimaryMobile.Text = Item.PrimaryMobile;
                    txtSecondaryMobile.Text = Item.SecondaryMobile;
                    txtPrimaryEmail.Text = Item.PrimaryEmail;
                    txtSecondaryEmail.Text = Item.SecondaryEmail;
                    txtPhone.Text = Item.Phone;
                    txtAddress.Text = Item.Address;
                    ddlLeadSource.SelectedValue = Item.LeadSourceId.ToString();
                    ddlLeadSource.Enabled = false;
                    DateTime dtFDate = Convert.ToDateTime(Item.FollowUpDate);
                    DateTime dtSTime = Convert.ToDateTime(Item.FromTime);
                    DateTime dtETime = Convert.ToDateTime(Item.ToTime);
                    lblFollowupDate.Text = dtFDate.Day.ToString() + " - " + dtFDate.Month.ToString() + " - " + dtFDate.Year.ToString() + " " + dtSTime.Hour.ToString("00.##") + " : " + dtSTime.Minute.ToString("00.##") + " To " + dtETime.Hour.ToString("00.##") + " : " + dtETime.Minute.ToString("00.##");

                    clsLeadLink obj = new clsLeadLink();
                    obj.LeadId = ItemId;
                    gv.DataSource = obj.LoadAll(obj);
                    gv.DataBind();
                    BindBatch();

                    //ReferFriend Code
                    if (Item.ReferFriendId > 0)
                    {

                        txtReferalAmount.Text = Item.ReferAmount;
                        if (Item.ProofPaymentPath != "")
                        {
                            lblInfo.Visible = false;

                            Label2.Visible = false;
                            flUpload.Visible = false;

                            Label1.Visible = true;
                            hplProof.Visible = true;
                            hplProof.NavigateUrl = "~/UserDocs/ReferFriend/" + Item.ProofPaymentPath;
                        }
                        else
                        {
                            hplProof.Visible = false;
                        }
                    }
                    else
                    {
                        lblInfo.Visible = false;


                        Label3.Visible = false;
                        txtReferalAmount.Visible = false;
                        Label2.Visible = false;
                        flUpload.Visible = false;
                        Label1.Visible = false;
                        hplProof.Visible = false;
                    }


                }
            }
        }
    }


    protected void BindBatch()
    {
        clsBatch obj = new clsBatch();
        //  obj.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedItem.Value);
        obj.CourseId = Convert.ToInt16(ddlCourse.SelectedItem.Value);
        //  obj.LocationId = Convert.ToInt16(ddlLocation.SelectedItem.Value);
        obj.StatusId = 1;
        ddlBatch.DataSource = obj.LoadAll(obj);
        ddlBatch.DataTextField = "Batch";
        ddlBatch.DataValueField = "BatchId";
        ddlBatch.DataBind();
        ddlBatch.Items.Insert(0, new ListItem("-- Select Batch --", ""));
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
    protected void BindLeadCategory()
    {
        clsLeadCategory obj = new clsLeadCategory();
        ddlLeadCategory.DataSource = obj.LoadAll(obj);
        ddlLeadCategory.DataTextField = "LeadCategory";
        ddlLeadCategory.DataValueField = "LeadCategoryId";
        ddlLeadCategory.DataBind();
        ddlLeadCategory.Items.Insert(0, new ListItem("-- Select Lead Status --", ""));
    }
    protected void BindBatchType()
    {
        clsBatchType obj = new clsBatchType();
        ddlBatchType.DataSource = obj.LoadAll(obj);
        ddlBatchType.DataTextField = "BatchType";
        ddlBatchType.DataValueField = "BatchTypeId";
        ddlBatchType.DataBind();
        ddlBatchType.Items.Insert(0, new ListItem("-- Select BatchType --", ""));
    }
    protected void BindCourse()
    {
        clsCourse obj = new clsCourse();
        ddlCourse.DataSource = obj.LoadAll(obj);
        ddlCourse.DataTextField = "Course";
        ddlCourse.DataValueField = "CourseId";
        ddlCourse.DataBind();
        ddlCourse.Items.Insert(0, new ListItem("-- Select Course --", ""));
    }
    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("-- Select Location --", ""));
    }
    protected void BindCommunicationType()
    {
        clsCommunicationType obj = new clsCommunicationType();
        ddlCommunicationType.DataSource = obj.LoadAll(obj);
        ddlCommunicationType.DataTextField = "CommunicationType";
        ddlCommunicationType.DataValueField = "CommunicationTypeId";
        ddlCommunicationType.DataBind();
        ddlCommunicationType.Items.Insert(0, new ListItem("-- Select CommunicationType --", ""));
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.LeadId = Convert.ToInt32(ItemId);
        }
        Item.Lead = Convert.ToString(txtLead.Text);
        
        Item.LeadSourceId = Convert.ToInt16(ddlLeadSource.SelectedItem.Value);
        Item.LeadCategoryId = Convert.ToInt16(ddlLeadCategory.SelectedItem.Value);
        Item.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedItem.Value);
        Item.LeadStatusId = Convert.ToInt16(2);
        Item.BranchId = 0;

        Item.CourseId = Convert.ToInt16(ddlCourse.SelectedItem.Value);
        Item.LocationId = Convert.ToInt16(ddlLocation.SelectedItem.Value);
        Item.CommunicationTypeId = Convert.ToInt16(ddlCommunicationType.SelectedItem.Value);
        Item.PrimaryMobile = Convert.ToString(txtPrimaryMobile.Text);
        Item.SecondaryMobile = Convert.ToString(txtSecondaryMobile.Text);
        Item.Phone = Convert.ToString(txtPhone.Text);
        Item.PrimaryEmail = Convert.ToString(txtPrimaryEmail.Text);
        Item.SecondaryEmail = Convert.ToString(txtSecondaryEmail.Text);
        Item.Address = Convert.ToString(txtAddress.Text);
        if (txtFDay.Text.Length > 0 && txtFMonth.Text.Length > 0 && txtFYear.Text.Length > 0)
        {
            int day = Convert.ToInt16(txtFDay.Text);
            int month = Convert.ToInt16(txtFMonth.Text);
            int year = Convert.ToInt16(txtFYear.Text);
            DateTime dtFDate = new DateTime(year, month, day);
            Item.FollowUpDate = dtFDate;
            int SHour = Convert.ToInt16(txtFromHTime.Text);
            int SMin = Convert.ToInt16(txtFromMTime.Text);
            DateTime dtSTime = new DateTime(year, month, day, SHour, SMin, 00);
            Item.FromTime = dtSTime;
            int EHour = Convert.ToInt16(txtToHTime.Text);
            int EMin = Convert.ToInt16(txtToMTime.Text);
            DateTime dtETime = new DateTime(year, month, day, EHour, EMin, 00);
            Item.ToTime = dtETime;
        }
        Item.CreatedBy = CurrentUser.CurrentUserId;


        if (flUpload.HasFile)
        {
            clsFileUpload Upload = new clsFileUpload();
            string filePath = Upload.ReferFriendPaymentPath(flUpload);
            Item.ProofPaymentPath = filePath;
        }
        Item.ReferAmount = txtReferalAmount.Text;











        Item.BetterPay = chkBetterPay.Checked;
        Item.JobLess = chkJobLess.Checked;
        Item.FriendsAdvise = chkFriendsAdvise.Checked;
        Item.IJM = chkIJM.Checked;
        Item.NoMoney = chkNoMoney.Checked;
        Item.FamilyMemberGuidance = chkFamilyMemberGuidence.Checked;
        Item.Certification = chkCertifications.Checked;
        Item.Presentlyworking = chkPresentWorking.Checked;
        Item.COEPDPreviousPlacements = chkCoepdPreviousPlacement.Checked;
        Item.KnowledgeEnhancement = chkKnowledgeEnhancement.Checked;
        Item.WeekendsAvailable = chkweekendsAvailable.Checked;
        Item.COEPDGoodReviews = chkCOEPDgoodreviews.Checked;
        Item.WantToShiftToIT = chkWantToShiftToIT.Checked;
        Item.WeekDaysDailyOneHour = chkWeekDaysDailyOnehour.Checked;
        Item.Fees = chkFees.Checked;
        Item.Marriage = chkMarriage.Checked;
        Item.PutDownPapers = chkPutDownPapers.Checked;
        Item.Discounts = chkDiscounts.Checked;
        Item.MoveToDifferentCity = chkMoveToDifferentCity.Checked;
        Item.InThreeMonthsWantANewJob = chkInThreeMonthsWantANewJob.Checked;
        Item.SelfSponsored = chkSelfSponsored.Checked;
        Item.StableJob = chkStableJob.Checked;
        Item.DontWantToKeepPseudoExperience = chkDontWantToKeepPseudoExperience.Checked;
        Item.SponsoredByAFriendFamilyMember = chkSponsoredByAFriendAndFamilyMember.Checked;
        Item.NoTensionJob = chkNoTensionJob.Checked;
        Item.KeenToRetainPreviousExperience = chkKeenToRetainPreviousExperience.Checked;
        Item.TimeSlotsAvailability = chkTimeSlotsAvailability.Checked;
        Item.SlowLearner = chkSlowLearner.Checked;
        Item.ClassroomPreferences = chkClassRoomPreferences.Checked;
        Item.NewToThisSubjectBA = chkNewToThisSubjectBA.Checked;
        Item.ConfidenceOfDoingThisCourseAndGettingAJob = chkConfiedenceOfDoingThisCourseAndGettingAJob.Checked;



































        Item.AddUpdate(Item);
        clsLeadLink ItemLeadLink = new clsLeadLink();
        ItemLeadLink.LeadId = Convert.ToInt32(ItemId);
        ItemLeadLink.LeadLink = txtNotes.Text;
        ItemLeadLink.CreatedBy = CurrentUser.CurrentUserId;
        ItemLeadLink.AddUpdate(ItemLeadLink);
        clsLeadLink obj = new clsLeadLink();
        obj.LeadId = ItemId;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
        Response.Redirect("FollowUpSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("FollowUpSearch.aspx");
    }
    protected void btnNoFollowup_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            clsLead obj = Item.Load(ItemId);
            obj.LeadStatusId = 4;
            Item.AddUpdate(obj);
            Response.Redirect("FollowUpSearch.aspx");
        }
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (ddlBatchType.SelectedIndex > 0)
        {
            if (ddlBatch.SelectedIndex > 0)
            {
                if (txtCourseFee.Text.Length > 0)
                {
                    Item.LeadId = Convert.ToInt32(ItemId);
                    Item.Lead = Convert.ToString(txtLead.Text);
                    Item.LeadCategoryId = 0;
                    //Item.LeadCategoryId = Convert.ToInt32(ddlLeadCategory.SelectedItem.Value);
                    Item.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedItem.Value);
                    Item.BatchId = Convert.ToInt16(ddlBatch.SelectedItem.Value);
                    Item.LeadSourceId = Convert.ToInt16(ddlLeadSource.SelectedItem.Value);
                    Item.LeadStatusId = Convert.ToInt16(3);
                    Item.BranchId = 0;
                    Item.CourseId = Convert.ToInt16(ddlCourse.SelectedItem.Value);
                    Item.LocationId = Convert.ToInt16(ddlLocation.SelectedItem.Value);
                    Item.CommunicationTypeId = 0;
                    Item.PrimaryMobile = Convert.ToString(txtPrimaryMobile.Text);
                    Item.SecondaryMobile = Convert.ToString(txtSecondaryMobile.Text);
                    Item.Phone = Convert.ToString(txtPhone.Text);
                    Item.PrimaryEmail = Convert.ToString(txtPrimaryEmail.Text);
                    Item.SecondaryEmail = Convert.ToString(txtSecondaryEmail.Text);
                    Item.Address = Convert.ToString(txtAddress.Text);
                    Item.Fee = Convert.ToDecimal(txtCourseFee.Text);
                    Item.CreatedBy = CurrentUser.CurrentUserId;
                    if (flUpload.HasFile)                    /**/
                    {
                        clsFileUpload Upload = new clsFileUpload();
                        string filePath = Upload.ReferFriendPaymentPath(flUpload);
                        Item.ProofPaymentPath = filePath;
                    }
                    Item.ReferAmount = txtReferalAmount.Text;




                    Item.BetterPay = chkBetterPay.Checked;
                    Item.JobLess = chkJobLess.Checked;
                    Item.FriendsAdvise = chkFriendsAdvise.Checked;
                    Item.IJM = chkIJM.Checked;
                    Item.NoMoney = chkNoMoney.Checked;
                    Item.FamilyMemberGuidance = chkFamilyMemberGuidence.Checked;
                    Item.Certification = chkCertifications.Checked;
                    Item.Presentlyworking = chkPresentWorking.Checked;
                    Item.COEPDPreviousPlacements = chkCoepdPreviousPlacement.Checked;
                    Item.KnowledgeEnhancement = chkKnowledgeEnhancement.Checked;
                    Item.WeekendsAvailable = chkweekendsAvailable.Checked;
                    Item.COEPDGoodReviews = chkCOEPDgoodreviews.Checked;
                    Item.WantToShiftToIT = chkWantToShiftToIT.Checked;
                    Item.WeekDaysDailyOneHour = chkWeekDaysDailyOnehour.Checked;
                    Item.Fees = chkFees.Checked;
                    Item.Marriage = chkMarriage.Checked;
                    Item.PutDownPapers = chkPutDownPapers.Checked;
                    Item.Discounts = chkDiscounts.Checked;
                    Item.MoveToDifferentCity = chkMoveToDifferentCity.Checked;
                    Item.InThreeMonthsWantANewJob = chkInThreeMonthsWantANewJob.Checked;
                    Item.SelfSponsored = chkSelfSponsored.Checked;
                    Item.StableJob = chkStableJob.Checked;
                    Item.DontWantToKeepPseudoExperience = chkDontWantToKeepPseudoExperience.Checked;
                    Item.SponsoredByAFriendFamilyMember = chkSponsoredByAFriendAndFamilyMember.Checked;
                    Item.NoTensionJob = chkNoTensionJob.Checked;
                    Item.KeenToRetainPreviousExperience = chkKeenToRetainPreviousExperience.Checked;
                    Item.TimeSlotsAvailability = chkTimeSlotsAvailability.Checked;
                    Item.SlowLearner = chkSlowLearner.Checked;
                    Item.ClassroomPreferences = chkClassRoomPreferences.Checked;
                    Item.NewToThisSubjectBA = chkNewToThisSubjectBA.Checked;
                    Item.ConfidenceOfDoingThisCourseAndGettingAJob = chkConfiedenceOfDoingThisCourseAndGettingAJob.Checked;








                    Item.AddUpdate(Item);


                    clsLeadLink ItemLeadLink = new clsLeadLink();
                    ItemLeadLink.LeadId = Convert.ToInt32(ItemId);
                    ItemLeadLink.LeadLink = txtNotes.Text;
                    ItemLeadLink.CreatedBy = CurrentUser.CurrentUserId;
                    ItemLeadLink.AddUpdate(ItemLeadLink);
                    #region "Save Participant"
                    int CountNo = 0;
                    clsParticipant Participant = new clsParticipant();
                    Participant.Mobile = txtPrimaryMobile.Text;
                    CountNo = Participant.LoadParticipantValidation(Participant);
                    if (CountNo == 0)
                    {
                        Participant.Participant = Convert.ToString(txtLead.Text);
                        Participant.BatchId = Convert.ToInt16(ddlBatch.SelectedValue);
                        Participant.LocationId = Convert.ToInt16(ddlLocation.SelectedItem.Value);
                        Participant.LeadSourceId = Convert.ToInt16(ddlLeadSource.SelectedItem.Value);
                        Participant.BranchId = 0;
                        Participant.DomainId = Convert.ToInt16(0);
                        Participant.Email = Convert.ToString(txtPrimaryEmail.Text);
                        Participant.Mobile = Convert.ToString(txtPrimaryMobile.Text);
                        Participant.CreatedBy = CurrentUser.CurrentUserId;
                        Participant.StatusId = Convert.ToInt32(1);
                        Participant.Fee = Convert.ToDecimal(txtCourseFee.Text);
                        Participant.IsIntern = Convert.ToBoolean(0);
                        Participant.LeadId = Convert.ToInt32(ItemId);
                        Participant.InternBatchId = 0;
                        Participant.IsExamPermit = Convert.ToBoolean(0);
                        DateTime Date = DateTime.ParseExact(hdnSubscriptionExpiryDate.Value, "dd/MM/yyyy", null);
                        Participant.SubscriptionExpiredOn = Convert.ToDateTime(Date);
                        Participant.AddUpdate(Participant);
                    }

                    #endregion
                    btnSubmit.Enabled = false;
                    btnRegister.Enabled = false;
                    FormMessage.Text = "Item successfully saved";
                    FormMessage.Visible = true;
                    ErrorMessage.Visible = false;
                }
                else
                {
                    ErrorMessage.Text = "Course Fee Required";
                    ErrorMessage.Visible = true;
                }
            }
            else
            {
                ErrorMessage.Text = "Batch Selection Required";
                ErrorMessage.Visible = true;
            }
        }
        else
        {
            ErrorMessage.Text = "Batch Type Selection Required";
            ErrorMessage.Visible = true;
        }

    }

    protected void ddlBatch_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlBatch.SelectedIndex > 0)
        {
            string Batch = ddlBatch.SelectedItem.ToString();
            string BatchDate = Batch.Substring(0, 10);
            DateTime BatchDateDate = DateTime.ParseExact(BatchDate, "dd/MM/yyyy", null);
            //DateTime BatchDateDate = Convert.ToDateTime(BatchDate);
            DateTime = BatchDateDate.AddYears(1);
            hdnSubscriptionExpiryDate.Value = DateTime.ToString("dd/MM/yyyy", null);
            //hdnSubscriptionExpiryDate.Value = DateTime.ToString("dd / MM / yyyy", null);
        }
        else
        {
            hdnSubscriptionExpiryDate.Value = "";
        }
    }
    protected void BindDemoData()
    {

        DateTime dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        clsDemo obj = new clsDemo();
        obj.Date = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null));

        gv1.DataSource = obj.LoadAll(obj);
        gv1.DataBind();
    }

    protected void btnDemoParticipant_Click(object sender, EventArgs e)
    {
        int SNo = Convert.ToInt32(Request.Form["RadioButton1"]);
        String DemoId = gv1.Rows[SNo - 1].Cells[2].Text;
        clsDemoAttendence obj = new clsDemoAttendence();
        obj.DemoId = Convert.ToInt32(DemoId);
        obj.LeadId = Convert.ToInt32(ItemId);
        if (SNo >= 1)
        {
            obj.IsInterested = true;
        }
        else
        {
            obj.IsInterested = false;
        }
        obj.CreatedBy = CurrentUser.CurrentUserId;
        obj.AddUpdate(obj);

    }
    protected void BindDemoAttendence()
    {
        clsDemoAttendence obj = new clsDemoAttendence();

        if (ddlAttendence.SelectedValue != "")
            obj.IsDemoAttended = Convert.ToBoolean(ddlAttendence.SelectedValue);
        obj.LeadId = ItemId;
        gv2.DataSource = obj.LoadAll(obj);
        gv2.DataBind();
    }
    protected void ddlAttendence_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDemoAttendence();
    }
    protected void btnAttendence_Click(object sender, EventArgs e)
    {

        int SNo = Convert.ToInt32(Request.Form["RadioButton1"]);
        String DemoAttendenceId = gv2.Rows[SNo - 1].Cells[2].Text;

        clsDemoAttendence obj = new clsDemoAttendence();
        obj.DemoAttendenceId = Convert.ToInt32(DemoAttendenceId);
        if (SNo >= 1)
        {
            obj.IsDemoAttended = true;
        }
        else
        {
            obj.IsDemoAttended = false;
        }
        obj.AddUpdate(obj);

    }







 
        protected void gv2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                Label lbltext = (Label)e.Row.FindControl("lblstatus");
                string ID = Convert.ToString(lbltext.Text);







                switch (Convert.ToBoolean(ID))
                {
                    case false:
                        lbltext.Text = "Not Attended";
                        lbltext.ForeColor = System.Drawing.Color.Red;
                        break;

                    case true:
                        lbltext.Text = "Attended";
                        lbltext.ForeColor = System.Drawing.Color.Green;
                        break;

                }


            }
        }
    }
