using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsParticipant
    {
        DataAccessLayerHelper.clsParticipantData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _ParticipantId;
        private string _Participant;
        private string _Code;
        private int _BatchId;
        private string _Batch;
        private DateTime? _StartDate;
        private int _BatchTypeId;
        private string _BatchType;
        private int _CourseId;
        private string _Course;
        private int _LocationId;
        private int _BranchId;
        private string _Location;
        private int _EmployeeId;
        private string _Employee;
        private int _DomainId;
        private string _Domain;
        private string _Email;
        private string _Mobile;
        private int _YearsOfExp;
        private int _MonthsOfExp;
        private string _Remarks;
        private string _ReferenceNo;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private int _UserId;
        private string _CertificatePath;
        private int? _StatusId;
        private decimal _Fee;
        private decimal _ReceivedAmount;
        private decimal _Due;
        private bool? _IsIntern;
        private int? _InternBatchId;
        private DateTime? _InternDate;
        private bool? _IsExamPermit;
        private string _Pwd;
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
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private DateTime _SubscriptionExpiredOn;
        private DateTime? _LastSlotStartTime;
        private bool _IsPlacementPermit;
        private string _SpecialNote;
        private int _ProfileOwnerId;
        private string _ProfileOwnerName;
        private bool _IsProfileOwnerAssigned;
        private DateTime? _MovedToPlacementOn;
        private int _MovedToPlacementBy;
        private DateTime? _ProfileOwnerAssignedOn;
        private int _ProfileOwnerAssignedBy;
        private string _MovedToPlacementByName;
        private string _ProfileOwnerAssignedByName;
        private int _LeadSourceId;
        private string _LeadSource;



        private bool _IsGoalSet;
        private string _PurposeOfAttending;
        private DateTime _TargetDate;
        private int _DailyTimeSpend;
        private DateTime _SetGoalOn;

        private int _CommunicationSkillsRating;
        private string _BASkills;
        private int _TotalExperience;
        private int _RelevantExperience;
        private decimal _CurrentCTC;
        private decimal _ExpectedCTC;
        private bool _IsSubscriptionExpired;

        private int _TotalExperienceMonths;
        private int _RelevantExperienceMonths;
        private int? _StatusCode;

        private string _StatusName;
        private string _AlternateMobileNo;
        private string _SkypeId;

        private string _CreatedName;
        private string _ModifiedName;
        private string _Fullname;


        public int LeadId
        {
            set;
            get;

        }

        public int SNo
        {
            get { return _SNo; }
            set { _SNo = value; }
        }
        public string keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }

        public int? ParticipantId
        {
            get { return _ParticipantId; }
            set { _ParticipantId = value; }
        }

        public string Participant
        {
            get { return _Participant; }
            set { _Participant = value; }
        }

        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }

        public int BatchId
        {
            get { return _BatchId; }
            set { _BatchId = value; }
        }

        public DateTime? StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        public int BatchTypeId
        {
            get { return _BatchTypeId; }
            set { _BatchTypeId = value; }
        }
        public string BatchType
        {
            get { return _BatchType; }
            set { _BatchType = value; }
        }
        public int CourseId
        {
            get { return _CourseId; }
            set { _CourseId = value; }
        }
        public string Course
        {
            get { return _Course; }
            set { _Course = value; }
        }
        public int LocationId
        {
            get { return _LocationId; }
            set { _LocationId = value; }
        }
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }
        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }

        public string Employee
        {
            get { return _Employee; }
            set { _Employee = value; }
        }
        public string Batch
        {
            get { return _Batch; }
            set { _Batch = value; }
        }
        public int DomainId
        {
            get { return _DomainId; }
            set { _DomainId = value; }
        }
        public string Domain
        {
            get { return _Domain; }
            set { _Domain = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }
        public int YearsOfExp
        {
            get { return _YearsOfExp; }
            set { _YearsOfExp = value; }
        }
        public int MonthsOfExp
        {
            get { return _MonthsOfExp; }
            set { _MonthsOfExp = value; }
        }

        public string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        public string ReferenceNo
        {
            get { return _ReferenceNo; }
            set { _ReferenceNo = value; }
        }

        public bool IsActive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
        }
        public bool IsDeleted
        {
            get { return _IsDeleted; }
            set { _IsDeleted = value; }
        }
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { _CreatedOn = value; }
        }
        public int? CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }
        public DateTime ModifiedOn
        {
            get { return _ModifiedOn; }
            set { _ModifiedOn = value; }
        }

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public int? StatusId
        {
            get { return _StatusId; }
            set { _StatusId = value; }
        }

        public string CertificatePath
        {
            get { return _CertificatePath; }
            set { _CertificatePath = value; }
        }
        public decimal Fee
        {
            get { return _Fee; }
            set { _Fee = value; }
        }
        public decimal ReceivedAmount
        {
            get { return _ReceivedAmount; }
            set { _ReceivedAmount = value; }
        }
        public decimal Due
        {
            get { return _Due; }
            set { _Due = value; }
        }

        public bool? IsIntern
        {
            get { return _IsIntern; }
            set { _IsIntern = value; }
        }

        public int? InternBatchId
        {
            get { return _InternBatchId; }
            set { _InternBatchId = value; }
        }

        public DateTime? InternDate
        {
            get { return _InternDate; }
            set { _InternDate = value; }
        }

        public bool? IsExamPermit
        {
            get { return _IsExamPermit; }
            set { _IsExamPermit = value; }
        }

        public string Pwd
        {
            get
            {
                return _Pwd;
            }

            set
            {
                _Pwd = value;
            }
        }

        public string Keywords1
        {
            get
            {
                return _keywords1;
            }

            set
            {
                _keywords1 = value;
            }
        }

        public string Keywords2
        {
            get
            {
                return _keywords2;
            }

            set
            {
                _keywords2 = value;
            }
        }

        public string Keywords3
        {
            get
            {
                return _keywords3;
            }

            set
            {
                _keywords3 = value;
            }
        }

        public string Keywords4
        {
            get
            {
                return _keywords4;
            }

            set
            {
                _keywords4 = value;
            }
        }

        public string Keywords5
        {
            get
            {
                return _keywords5;
            }

            set
            {
                _keywords5 = value;
            }
        }

        public int BranchId
        {
            get
            {
                return _BranchId;
            }

            set
            {
                _BranchId = value;
            }
        }

        public string Keywords6
        {
            get
            {
                return _keywords6;
            }

            set
            {
                _keywords6 = value;
            }
        }

        public string Keywords7
        {
            get
            {
                return _keywords7;
            }

            set
            {
                _keywords7 = value;
            }
        }

        public string Keywords8
        {
            get
            {
                return _keywords8;
            }

            set
            {
                _keywords8 = value;
            }
        }

        public string Keywords9
        {
            get
            {
                return _keywords9;
            }

            set
            {
                _keywords9 = value;
            }
        }

        public string Keywords10
        {
            get
            {
                return _keywords10;
            }

            set
            {
                _keywords10 = value;
            }
        }

        public string Keywords11
        {
            get
            {
                return _keywords11;
            }

            set
            {
                _keywords11 = value;
            }
        }

        public string Keywords12
        {
            get
            {
                return _keywords12;
            }

            set
            {
                _keywords12 = value;
            }
        }

        public string Keywords13
        {
            get
            {
                return _keywords13;
            }

            set
            {
                _keywords13 = value;
            }
        }

        public string Keywords14
        {
            get
            {
                return _keywords14;
            }

            set
            {
                _keywords14 = value;
            }
        }

        public string Keywords15
        {
            get
            {
                return _keywords15;
            }

            set
            {
                _keywords15 = value;
            }
        }

        public string Keywords16
        {
            get
            {
                return _keywords16;
            }

            set
            {
                _keywords16 = value;
            }
        }

        public string Keywords17
        {
            get
            {
                return _keywords17;
            }

            set
            {
                _keywords17 = value;
            }
        }

        public string Keywords18
        {
            get
            {
                return _keywords18;
            }

            set
            {
                _keywords18 = value;
            }
        }

        public string Keywords19
        {
            get
            {
                return _keywords19;
            }

            set
            {
                _keywords19 = value;
            }
        }

        public string Keywords20
        {
            get
            {
                return _keywords20;
            }

            set
            {
                _keywords20 = value;
            }
        }

        public string Keywords21
        {
            get
            {
                return _keywords21;
            }

            set
            {
                _keywords21 = value;
            }
        }

        public string Keywords22
        {
            get
            {
                return _keywords22;
            }

            set
            {
                _keywords22 = value;
            }
        }

        public string Keywords23
        {
            get
            {
                return _keywords23;
            }

            set
            {
                _keywords23 = value;
            }
        }

        public string Keywords24
        {
            get
            {
                return _keywords24;
            }

            set
            {
                _keywords24 = value;
            }
        }

        public string Keywords25
        {
            get
            {
                return _keywords25;
            }

            set
            {
                _keywords25 = value;
            }
        }

        public string Keywords26
        {
            get
            {
                return _keywords26;
            }

            set
            {
                _keywords26 = value;
            }
        }

        public string Keywords27
        {
            get
            {
                return _keywords27;
            }

            set
            {
                _keywords27 = value;
            }
        }

        public string Keywords28
        {
            get
            {
                return _keywords28;
            }

            set
            {
                _keywords28 = value;
            }
        }

        public string Keywords29
        {
            get
            {
                return _keywords29;
            }

            set
            {
                _keywords29 = value;
            }
        }

        public string Keywords30
        {
            get
            {
                return _keywords30;
            }

            set
            {
                _keywords30 = value;
            }
        }

        public DateTime? FromDate
        {
            get
            {
                return _FromDate;
            }

            set
            {
                _FromDate = value;
            }
        }

        public DateTime? ToDate
        {
            get
            {
                return _ToDate;
            }

            set
            {
                _ToDate = value;
            }
        }

        public DateTime SubscriptionExpiredOn
        {
            get
            {
                return _SubscriptionExpiredOn;
            }

            set
            {
                _SubscriptionExpiredOn = value;
            }
        }

        public DateTime? LastSlotStartTime
        {
            get
            {
                return _LastSlotStartTime;
            }

            set
            {
                _LastSlotStartTime = value;
            }
        }

        public bool IsPlacementPermit
        {
            get
            {
                return _IsPlacementPermit;
            }

            set
            {
                _IsPlacementPermit = value;
            }
        }

        public string SpecialNote
        {
            get
            {
                return _SpecialNote;
            }

            set
            {
                _SpecialNote = value;
            }
        }

        public int ProfileOwnerId
        {
            get
            {
                return _ProfileOwnerId;
            }

            set
            {
                _ProfileOwnerId = value;
            }
        }

        public string ProfileOwnerName
        {
            get
            {
                return _ProfileOwnerName;
            }

            set
            {
                _ProfileOwnerName = value;
            }
        }

        public bool IsProfileOwnerAssigned
        {
            get
            {
                return _IsProfileOwnerAssigned;
            }

            set
            {
                _IsProfileOwnerAssigned = value;
            }
        }

        public DateTime? MovedToPlacementOn
        {
            get
            {
                return _MovedToPlacementOn;
            }

            set
            {
                _MovedToPlacementOn = value;
            }
        }

        public int MovedToPlacementBy
        {
            get
            {
                return _MovedToPlacementBy;
            }

            set
            {
                _MovedToPlacementBy = value;
            }
        }

        public DateTime? ProfileOwnerAssignedOn
        {
            get
            {
                return _ProfileOwnerAssignedOn;
            }

            set
            {
                _ProfileOwnerAssignedOn = value;
            }
        }

        public int ProfileOwnerAssignedBy
        {
            get
            {
                return _ProfileOwnerAssignedBy;
            }

            set
            {
                _ProfileOwnerAssignedBy = value;
            }
        }

        public string MovedToPlacementByName
        {
            get
            {
                return _MovedToPlacementByName;
            }

            set
            {
                _MovedToPlacementByName = value;
            }
        }

        public string ProfileOwnerAssignedByName
        {
            get
            {
                return _ProfileOwnerAssignedByName;
            }

            set
            {
                _ProfileOwnerAssignedByName = value;
            }
        }

        public bool IsGoalSet
        {
            get
            {
                return _IsGoalSet;
            }

            set
            {
                _IsGoalSet = value;
            }
        }

        public string PurposeOfAttending
        {
            get
            {
                return _PurposeOfAttending;
            }

            set
            {
                _PurposeOfAttending = value;
            }
        }

        public DateTime TargetDate
        {
            get
            {
                return _TargetDate;
            }

            set
            {
                _TargetDate = value;
            }
        }

        public int DailyTimeSpend
        {
            get
            {
                return _DailyTimeSpend;
            }

            set
            {
                _DailyTimeSpend = value;
            }
        }

        public DateTime SetGoalOn
        {
            get
            {
                return _SetGoalOn;
            }

            set
            {
                _SetGoalOn = value;
            }
        }

        public int CommunicationSkillsRating
        {
            get
            {
                return _CommunicationSkillsRating;
            }

            set
            {
                _CommunicationSkillsRating = value;
            }
        }

        public string BASkills
        {
            get
            {
                return _BASkills;
            }

            set
            {
                _BASkills = value;
            }
        }

        public int TotalExperience
        {
            get
            {
                return _TotalExperience;
            }

            set
            {
                _TotalExperience = value;
            }
        }

        public int RelevantExperience
        {
            get
            {
                return _RelevantExperience;
            }

            set
            {
                _RelevantExperience = value;
            }
        }

        public decimal CurrentCTC
        {
            get
            {
                return _CurrentCTC;
            }

            set
            {
                _CurrentCTC = value;
            }
        }

        public decimal ExpectedCTC
        {
            get
            {
                return _ExpectedCTC;
            }

            set
            {
                _ExpectedCTC = value;
            }
        }

        public bool IsSubscriptionExpired
        {
            get
            {
                return _IsSubscriptionExpired;
            }

            set
            {
                _IsSubscriptionExpired = value;
            }
        }

        public int TotalExperienceMonths
        {
            get
            {
                return _TotalExperienceMonths;
            }

            set
            {
                _TotalExperienceMonths = value;
            }
        }

        public int RelevantExperienceMonths
        {
            get
            {
                return _RelevantExperienceMonths;
            }

            set
            {
                _RelevantExperienceMonths = value;
            }
        }

        public int LeadSourceId
        {
            get
            {
                return _LeadSourceId;
            }

            set
            {
                _LeadSourceId = value;
            }
        }

        public string LeadSource
        {
            get
            {
                return _LeadSource;
            }

            set
            {
                _LeadSource = value;
            }
        }

        public int? StatusCode { get => _StatusCode; set => _StatusCode = value; }
        public string StatusName { get => _StatusName; set => _StatusName = value; }
        public string AlternateMobileNo { get => _AlternateMobileNo; set => _AlternateMobileNo = value; }
        public string SkypeId { get => _SkypeId; set => _SkypeId = value; }
        public string CreatedName { get => _CreatedName; set => _CreatedName = value; }
        public string ModifiedName { get => _ModifiedName; set => _ModifiedName = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }

        public clsParticipant()
        {
            DBLayer = new DataAccessLayerHelper.clsParticipantData();
        }
        public void AddUpdate(clsParticipant obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsParticipant Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public clsParticipant LoadByEmailRefNo(string Email, string ReferenceNo)
        {
            return DBLayer.LoadByEmailRefNo(Email, ReferenceNo);
        }



        public List<clsParticipant> LoadAll(clsParticipant obj)
        {
            return DBLayer.LoadAll(obj);
        }




        public List<clsParticipant> LoadAllPlacement(clsParticipant obj)
        {
            return DBLayer.LoadAllPlacement(obj);
        }
        public List<clsParticipant> LoadAllNurturing(clsParticipant obj)
        {
            return DBLayer.LoadAllNurturing(obj);
        }
        public List<clsParticipant> LoadAllMultiple(clsParticipant obj)
        {
            return DBLayer.LoadAllMultiple(obj);
        }
        public List<clsParticipant> LoadAllIntern(clsParticipant obj)
        {
            return DBLayer.LoadAllIntern(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public void DeleteCertificate(int Id)
        {
            DBLayer.DeleteCertificate(Id);
        }
        public List<clsParticipant> LoadDueAmount(clsParticipant obj)
        {
            return DBLayer.LoadDueAmount(obj);
        }

        public List<clsParticipant> LoadAllByBatch(clsParticipant obj)
        {
            return DBLayer.LoadAllByBatch(obj);
        }
        public void AddToIntrnship(clsParticipant obj)
        {
            DBLayer.AddToIntrnship(obj);
        }
        public void AddToPlacement(clsParticipant obj)
        {
            DBLayer.AddToPlacement(obj);
        }
        public void AddProfileOwner(clsParticipant obj)
        {
            DBLayer.AddProfileOwner(obj);
        }

        public List<clsParticipant> LoadAll_CertificationList(clsParticipant obj)
        {
            return DBLayer.LoadAll_CertificationList(obj);
        }
        public int LoadParticipantValidation(clsParticipant obj)
        {
            return DBLayer.LoadParticipantValidation(obj);
        }
        public void GoalSettingAddUpdate(clsParticipant obj)
        {
            DBLayer.GoalSettingAddUpdate(obj);
        }
        public void AddUpdateStatusCode(clsParticipant obj)
        {
            DBLayer.AddUpdateStatusCode(obj);
        }
        public List<clsParticipant> LoadAllStatus(clsParticipant obj)
        {
            return DBLayer.LoadAllStatus(obj);
        }
    }
}