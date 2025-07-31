using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsLead
    {
        DataAccessLayerHelper.clsLeadData DBLayer;

        private string _Username;
        private int? _TrainerId;
        private string _Trainer;
        private DateTime? _BatchDate;
        private decimal _Fee;
        private decimal _ReceiptAmount;

        private int _SNo;
        private int? _LeadId;
        private string _Lead;
        private int _BatchId;
        private string _Batch;
        private int _BatchTypeId;
        private string _BatchType;
        private int _LeadSourceId;
        private string _LeadSource;
        private int _LeadCategoryId;
        private string _LeadCategory;
        private int _LeadStatusId;
        private string _LeadStatus;
        private DateTime? _LeadDate;
        private DateTime? _FollowUpDate;
        private int _BranchId;
        private string _Branch;
        private int _CourseId;
        private string _Course;
        private int _LocationId;
        private string _Location;
        private int _CommunicationTypeId;
        private string _CommunicationType;
        private string _PrimaryMobile;
        private string _SecondaryMobile;
        private string _PrimaryEmail;
        private string _SecondaryEmail;
        private string _Phone;
        private string _City;
        private string _Address;
        private string _Comments;
        private string _Remarks;
        private string _Qualification;
        private string _Experience;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private int? _ParticipantId;
        private string _Participant;
        private DateTime? _FromTime;
        private DateTime? _ToTime;
        private int? _EmployeeId;
        private string _Employee;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private string _keywords1;
        private string _keywords2;
        private string _keywords3;
        private string _keywords4;
        private string _keywords5;
        private string _keywords6;
        private string _keywords7;
        private string _keywords8;
        private string _keywords9;
        private string _keywords10;
        private string _keywords11;
        private string _keywords12;
        private string _keywords13;
        private string _keywords14;
        private string _keywords15;
        private string _keywords16;
        private string _keywords17;
        private string _keywords18;
        private string _keywords19;
        private string _keywords20;
        private string _keywords21;
        private string _keywords22;
        private string _keywords23;
        private string _keywords24;
        private string _keywords25;
        private string _keywords26;
        private string _keywords27;
        private string _keywords28;
        private string _keywords29;
        private string _keywords30;
        private string _keywords;
        private int _ReferFriendId;
        private string _ProofPaymentPath;
        private string _ReferAmount;
        private int _LeadOwner;
        private string _AspirantName;

        private bool _BetterPay;
        private bool _IJM;
        private bool _Certification;
        private bool _KnowledgeEnhancement;
        private bool _WantToShiftToIT;
        private bool _Marriage;
        private bool _MoveToDifferentCity;
        private bool _StableJob;
        private bool _NoTensionJob;
        private bool _JobLess;
        private bool _NoMoney;
        private bool _Presentlyworking;
        private bool _WeekendsAvailable;
        private bool _WeekDaysDailyOneHour;
        private bool _PutDownPapers;
        private bool _InThreeMonthsWantANewJob;
        private bool _DontWantToKeepPseudoExperience;
        private bool _KeenToRetainPreviousExperience;
        private bool _SlowLearner;
        private bool _NewToThisSubjectBA;
        private bool _FriendsAdvise;
        private bool _FamilyMemberGuidance;
        private bool _COEPDPreviousPlacements;
        private bool _COEPDGoodReviews;
        private bool _Fees;
        private bool _Discounts;
        private bool _SelfSponsored;
        private bool _SponsoredByAFriendFamilyMember;
        private bool _TimeSlotsAvailability;
        private bool _ClassroomPreferences;
        private bool _ConfidenceOfDoingThisCourseAndGettingAJob;

        private bool _IsDemoAttended;
        private bool _IsInterested;
        private string _Domain;
        private string _Experiance;
        private string _ServiceOwnerId;
        private string _Fullname;
        private string _ServiceOwnerMobile;
        private string _ServiceOwnerEmail;
        public string keywords { get => _keywords; set => _keywords = value; }

        public string Username { get => _Username; set => _Username = value; }
        public int? TrainerId { get => _TrainerId; set => _TrainerId = value; }
        public string Trainer { get => _Trainer; set => _Trainer = value; }
        public DateTime? BatchDate { get => _BatchDate; set => _BatchDate = value; }
        public decimal Fee { get => _Fee; set => _Fee = value; }
        public decimal ReceiptAmount { get => _ReceiptAmount; set => _ReceiptAmount = value; }
        public int SNo { get => _SNo; set => _SNo = value; }
        public int? LeadId { get => _LeadId; set => _LeadId = value; }
        public string Lead { get => _Lead; set => _Lead = value; }
        public int BatchId { get => _BatchId; set => _BatchId = value; }
        public string Batch { get => _Batch; set => _Batch = value; }
        public int BatchTypeId { get => _BatchTypeId; set => _BatchTypeId = value; }
        public string BatchType { get => _BatchType; set => _BatchType = value; }
        public int LeadSourceId { get => _LeadSourceId; set => _LeadSourceId = value; }
        public string LeadSource { get => _LeadSource; set => _LeadSource = value; }
        public int LeadCategoryId { get => _LeadCategoryId; set => _LeadCategoryId = value; }
        public string LeadCategory { get => _LeadCategory; set => _LeadCategory = value; }
        public int LeadStatusId { get => _LeadStatusId; set => _LeadStatusId = value; }
        public string LeadStatus { get => _LeadStatus; set => _LeadStatus = value; }
        public DateTime? LeadDate { get => _LeadDate; set => _LeadDate = value; }
        public DateTime? FollowUpDate { get => _FollowUpDate; set => _FollowUpDate = value; }
        public int BranchId { get => _BranchId; set => _BranchId = value; }
        public string Branch { get => _Branch; set => _Branch = value; }
        public int CourseId { get => _CourseId; set => _CourseId = value; }
        public string Course { get => _Course; set => _Course = value; }
        public int LocationId { get => _LocationId; set => _LocationId = value; }
        public string Location { get => _Location; set => _Location = value; }
        public int CommunicationTypeId { get => _CommunicationTypeId; set => _CommunicationTypeId = value; }
        public string CommunicationType { get => _CommunicationType; set => _CommunicationType = value; }
        public string PrimaryMobile { get => _PrimaryMobile; set => _PrimaryMobile = value; }
        public string SecondaryMobile { get => _SecondaryMobile; set => _SecondaryMobile = value; }
        public string PrimaryEmail { get => _PrimaryEmail; set => _PrimaryEmail = value; }
        public string SecondaryEmail { get => _SecondaryEmail; set => _SecondaryEmail = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public string City { get => _City; set => _City = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Comments { get => _Comments; set => _Comments = value; }
        public string Remarks { get => _Remarks; set => _Remarks = value; }
        public string Qualification { get => _Qualification; set => _Qualification = value; }
        public string Experience { get => _Experience; set => _Experience = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public int? ParticipantId { get => _ParticipantId; set => _ParticipantId = value; }
        public string Participant { get => _Participant; set => _Participant = value; }
        public DateTime? FromTime { get => _FromTime; set => _FromTime = value; }
        public DateTime? ToTime { get => _ToTime; set => _ToTime = value; }
        public int? EmployeeId { get => _EmployeeId; set => _EmployeeId = value; }
        public string Employee { get => _Employee; set => _Employee = value; }
        public DateTime? FromDate { get => _FromDate; set => _FromDate = value; }
        public DateTime? ToDate { get => _ToDate; set => _ToDate = value; }
        public string Keywords1 { get => _keywords1; set => _keywords1 = value; }
        public string Keywords2 { get => _keywords2; set => _keywords2 = value; }
        public string Keywords3 { get => _keywords3; set => _keywords3 = value; }
        public string Keywords4 { get => _keywords4; set => _keywords4 = value; }
        public string Keywords5 { get => _keywords5; set => _keywords5 = value; }
        public string Keywords6 { get => _keywords6; set => _keywords6 = value; }
        public string Keywords7 { get => _keywords7; set => _keywords7 = value; }
        public string Keywords8 { get => _keywords8; set => _keywords8 = value; }
        public string Keywords9 { get => _keywords9; set => _keywords9 = value; }
        public string Keywords10 { get => _keywords10; set => _keywords10 = value; }
        public string Keywords11 { get => _keywords11; set => _keywords11 = value; }
        public string Keywords12 { get => _keywords12; set => _keywords12 = value; }
        public string Keywords13 { get => _keywords13; set => _keywords13 = value; }
        public string Keywords14 { get => _keywords14; set => _keywords14 = value; }
        public string Keywords15 { get => _keywords15; set => _keywords15 = value; }
        public string Keywords16 { get => _keywords16; set => _keywords16 = value; }
        public string Keywords17 { get => _keywords17; set => _keywords17 = value; }
        public string Keywords18 { get => _keywords18; set => _keywords18 = value; }
        public string Keywords19 { get => _keywords19; set => _keywords19 = value; }
        public string Keywords20 { get => _keywords20; set => _keywords20 = value; }
        public string Keywords21 { get => _keywords21; set => _keywords21 = value; }
        public string Keywords22 { get => _keywords22; set => _keywords22 = value; }
        public string Keywords23 { get => _keywords23; set => _keywords23 = value; }
        public string Keywords24 { get => _keywords24; set => _keywords24 = value; }
        public string Keywords25 { get => _keywords25; set => _keywords25 = value; }
        public string Keywords26 { get => _keywords26; set => _keywords26 = value; }
        public string Keywords27 { get => _keywords27; set => _keywords27 = value; }
        public string Keywords28 { get => _keywords28; set => _keywords28 = value; }
        public string Keywords29 { get => _keywords29; set => _keywords29 = value; }
        public string Keywords30 { get => _keywords30; set => _keywords30 = value; }
        public int ReferFriendId { get => _ReferFriendId; set => _ReferFriendId = value; }
        public string ProofPaymentPath { get => _ProofPaymentPath; set => _ProofPaymentPath = value; }
        public string ReferAmount { get => _ReferAmount; set => _ReferAmount = value; }
        public int LeadOwner { get => _LeadOwner; set => _LeadOwner = value; }
        public string AspirantName { get => _AspirantName; set => _AspirantName = value; }
        public bool BetterPay { get => _BetterPay; set => _BetterPay = value; }
        public bool IJM { get => _IJM; set => _IJM = value; }
        public bool Certification { get => _Certification; set => _Certification = value; }
        public bool KnowledgeEnhancement { get => _KnowledgeEnhancement; set => _KnowledgeEnhancement = value; }
        public bool WantToShiftToIT { get => _WantToShiftToIT; set => _WantToShiftToIT = value; }
        public bool Marriage { get => _Marriage; set => _Marriage = value; }
        public bool MoveToDifferentCity { get => _MoveToDifferentCity; set => _MoveToDifferentCity = value; }
        public bool StableJob { get => _StableJob; set => _StableJob = value; }
        public bool NoTensionJob { get => _NoTensionJob; set => _NoTensionJob = value; }
        public bool JobLess { get => _JobLess; set => _JobLess = value; }
        public bool NoMoney { get => _NoMoney; set => _NoMoney = value; }
        public bool Presentlyworking { get => _Presentlyworking; set => _Presentlyworking = value; }
        public bool WeekendsAvailable { get => _WeekendsAvailable; set => _WeekendsAvailable = value; }
        public bool WeekDaysDailyOneHour { get => _WeekDaysDailyOneHour; set => _WeekDaysDailyOneHour = value; }
        public bool PutDownPapers { get => _PutDownPapers; set => _PutDownPapers = value; }
        public bool InThreeMonthsWantANewJob { get => _InThreeMonthsWantANewJob; set => _InThreeMonthsWantANewJob = value; }
        public bool DontWantToKeepPseudoExperience { get => _DontWantToKeepPseudoExperience; set => _DontWantToKeepPseudoExperience = value; }
        public bool KeenToRetainPreviousExperience { get => _KeenToRetainPreviousExperience; set => _KeenToRetainPreviousExperience = value; }
        public bool SlowLearner { get => _SlowLearner; set => _SlowLearner = value; }
        public bool NewToThisSubjectBA { get => _NewToThisSubjectBA; set => _NewToThisSubjectBA = value; }
        public bool FriendsAdvise { get => _FriendsAdvise; set => _FriendsAdvise = value; }
        public bool FamilyMemberGuidance { get => _FamilyMemberGuidance; set => _FamilyMemberGuidance = value; }
        public bool COEPDPreviousPlacements { get => _COEPDPreviousPlacements; set => _COEPDPreviousPlacements = value; }
        public bool COEPDGoodReviews { get => _COEPDGoodReviews; set => _COEPDGoodReviews = value; }
        public bool Fees { get => _Fees; set => _Fees = value; }
        public bool Discounts { get => _Discounts; set => _Discounts = value; }
        public bool SelfSponsored { get => _SelfSponsored; set => _SelfSponsored = value; }
        public bool SponsoredByAFriendFamilyMember { get => _SponsoredByAFriendFamilyMember; set => _SponsoredByAFriendFamilyMember = value; }
        public bool TimeSlotsAvailability { get => _TimeSlotsAvailability; set => _TimeSlotsAvailability = value; }
        public bool ClassroomPreferences { get => _ClassroomPreferences; set => _ClassroomPreferences = value; }
        public bool ConfidenceOfDoingThisCourseAndGettingAJob { get => _ConfidenceOfDoingThisCourseAndGettingAJob; set => _ConfidenceOfDoingThisCourseAndGettingAJob = value; }
        public bool IsDemoAttended { get => _IsDemoAttended; set => _IsDemoAttended = value; }
        public bool IsInterested { get => _IsInterested; set => _IsInterested = value; }
        public string Domain { get => _Domain; set => _Domain = value; }
        public string Experiance { get => _Experiance; set => _Experiance = value; }
        public string ServiceOwnerId { get => _ServiceOwnerId; set => _ServiceOwnerId = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }
        public string ServiceOwnerMobile { get => _ServiceOwnerMobile; set => _ServiceOwnerMobile = value; }
        public string ServiceOwnerEmail { get => _ServiceOwnerEmail; set => _ServiceOwnerEmail = value; }

        public clsLead()
        {

            DBLayer = new DataAccessLayerHelper.clsLeadData();
        }
        public void AddUpdate(clsLead obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsLead Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsLead> LoadAll(clsLead obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public List<clsLead> LoadAllReport(clsLead obj)
        {
            return DBLayer.LoadAllReport(obj);
        }

        public List<clsLead> LoadAllFollowups(clsLead obj)
        {
            return DBLayer.LoadAllFollowups(obj);
        }
        public List<clsLead> LoadAllRegistrationReport(clsLead obj)
        {
            return DBLayer.LoadAllRegistrationReport(obj);
        }
        public void Remove(int Id)
        {

            DBLayer.Remove(Id);
        }
        public List<clsLead> LoadAllMultiple(clsLead obj)
        {
            return DBLayer.LoadAllMultiple(obj);
        }
        public List<clsLead> LoadforAll(clsLead obj)
        {
            return DBLayer.LoadforAll(obj);
            ;
        }
        public int LoadLeadMobileValidation(clsLead obj)
        {
            return DBLayer.LoadLeadMobileValidation(obj);
        }
        public int LoadLeadEmailValidation(clsLead obj)
        {
            return DBLayer.LoadLeadEmailValidation(obj);
        }
        public List<clsLead> LoadAll_ServiceOwner(clsLead obj)
        {
            return DBLayer.LoadAll_ServiceOwner(obj);
        }


    }
}