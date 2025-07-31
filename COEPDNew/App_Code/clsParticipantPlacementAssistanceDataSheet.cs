using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLayer
{
    public class clsParticipantPlacementAssistanceDataSheet
    {
        DataAccessLayerHelper.clsParticipantPlacementAssistanceDataSheetData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _ParticipantPlacementAssistanceDataSheetId;
        private string _FullName;
        private DateTime _DateOfBirth;
        private string _ActiveMobile;
        private string _Email;
        private DateTime? _Batch;
        private string _TrainerName;
        private string _LocationOfTraining;
        private int _NurturingStatusId;
        private decimal _TotalFeePaid;
        private int? _TotalExperience;
        private int? _RelevantExperience;
        private string _JobExperienceDomain;
        private string _JobExpectedDomain;
        private int _CommunicationSkillsRating;
        private string _BASkills;
        private decimal _CurrentCTC;
        private decimal _ExpectedCTC;
        private string _CurrentLocation;
        private string _PreferredLocations;
        private DateTime _ResumeFinalizedOn;
        private string _PassportSizePhotoImagePath;
        private string _AadharCardFrontImagePath;
        private string _AadharCardBackImagePath;

        private DateTime _TermsAcceptedOn;
        private bool _IsDataSheetApproved;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _NoticePeriod;
        private int _ParticipantId;
        private int _ProfileOwnerId;
        private string _ProfileOwnerName;
        private DateTime? _SubscriptionExpiredOn;
        private bool _IsProfileOwnerAssigned;
        private string _ProfileOwnerKeywords;
        private string _SalarySlipImagePath;
        private int _NoticePeriodId;
        private int _TotalExperienceMonths;
        private int _RelevantExperienceMonths;

        private string _TotalExperiencess;
        private string _RelevantExperiencess;
        private string _ServiceFormImagePath;

        private bool _IsSubscriptionExpired;

        public int SNo
        {
            get
            {
                return _SNo;
            }

            set
            {
                _SNo = value;
            }
        }

        public string Keywords
        {
            get
            {
                return _keywords;
            }

            set
            {
                _keywords = value;
            }
        }

        public int? ParticipantPlacementAssistanceDataSheetId
        {
            get
            {
                return _ParticipantPlacementAssistanceDataSheetId;
            }

            set
            {
                _ParticipantPlacementAssistanceDataSheetId = value;
            }
        }

        public string FullName
        {
            get
            {
                return _FullName;
            }

            set
            {
                _FullName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }

            set
            {
                _DateOfBirth = value;
            }
        }

        public string ActiveMobile
        {
            get
            {
                return _ActiveMobile;
            }

            set
            {
                _ActiveMobile = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public DateTime? Batch
        {
            get
            {
                return _Batch;
            }

            set
            {
                _Batch = value;
            }
        }

        public string TrainerName
        {
            get
            {
                return _TrainerName;
            }

            set
            {
                _TrainerName = value;
            }
        }

        public string LocationOfTraining
        {
            get
            {
                return _LocationOfTraining;
            }

            set
            {
                _LocationOfTraining = value;
            }
        }

        public int NurturingStatusId
        {
            get
            {
                return _NurturingStatusId;
            }

            set
            {
                _NurturingStatusId = value;
            }
        }

        public decimal TotalFeePaid
        {
            get
            {
                return _TotalFeePaid;
            }

            set
            {
                _TotalFeePaid = value;
            }
        }

        public int? TotalExperience
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

        public int? RelevantExperience
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

        public string JobExperienceDomain
        {
            get
            {
                return _JobExperienceDomain;
            }

            set
            {
                _JobExperienceDomain = value;
            }
        }

        public string JobExpectedDomain
        {
            get
            {
                return _JobExpectedDomain;
            }

            set
            {
                _JobExpectedDomain = value;
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

        public string CurrentLocation
        {
            get
            {
                return _CurrentLocation;
            }

            set
            {
                _CurrentLocation = value;
            }
        }

        public string PreferredLocations
        {
            get
            {
                return _PreferredLocations;
            }

            set
            {
                _PreferredLocations = value;
            }
        }

        public DateTime ResumeFinalizedOn
        {
            get
            {
                return _ResumeFinalizedOn;
            }

            set
            {
                _ResumeFinalizedOn = value;
            }
        }

        public string PassportSizePhotoImagePath
        {
            get
            {
                return _PassportSizePhotoImagePath;
            }

            set
            {
                _PassportSizePhotoImagePath = value;
            }
        }

        public string AadharCardFrontImagePath
        {
            get
            {
                return _AadharCardFrontImagePath;
            }

            set
            {
                _AadharCardFrontImagePath = value;
            }
        }

        public string AadharCardBackImagePath
        {
            get
            {
                return _AadharCardBackImagePath;
            }

            set
            {
                _AadharCardBackImagePath = value;
            }
        }

        public DateTime TermsAcceptedOn
        {
            get
            {
                return _TermsAcceptedOn;
            }

            set
            {
                _TermsAcceptedOn = value;
            }
        }

        public bool IsDataSheetApproved
        {
            get
            {
                return _IsDataSheetApproved;
            }

            set
            {
                _IsDataSheetApproved = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return _IsActive;
            }

            set
            {
                _IsActive = value;
            }
        }

        public bool IsDeleted
        {
            get
            {
                return _IsDeleted;
            }

            set
            {
                _IsDeleted = value;
            }
        }

        public DateTime CreatedOn
        {
            get
            {
                return _CreatedOn;
            }

            set
            {
                _CreatedOn = value;
            }
        }

        public int CreatedBy
        {
            get
            {
                return _CreatedBy;
            }

            set
            {
                _CreatedBy = value;
            }
        }

        public DateTime? ModifiedOn
        {
            get
            {
                return _ModifiedOn;
            }

            set
            {
                _ModifiedOn = value;
            }
        }

        public int ModifiedBy
        {
            get
            {
                return _ModifiedBy;
            }

            set
            {
                _ModifiedBy = value;
            }
        }

        public string NoticePeriod
        {
            get
            {
                return _NoticePeriod;
            }

            set
            {
                _NoticePeriod = value;
            }
        }

        public int ParticipantId
        {
            get
            {
                return _ParticipantId;
            }

            set
            {
                _ParticipantId = value;
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

        public DateTime? SubscriptionExpiredOn
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
        public string ProfileOwnerKeywords
        {
            get
            {
                return _ProfileOwnerKeywords;
            }
            set
            {
                _ProfileOwnerKeywords = value;
            }
        }

        public string SalarySlipImagePath
        {
            get
            {
                return _SalarySlipImagePath;
            }

            set
            {
                _SalarySlipImagePath = value;
            }
        }

        public int NoticePeriodId
        {
            get
            {
                return _NoticePeriodId;
            }

            set
            {
                _NoticePeriodId = value;
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

        public string TotalExperiencess
        {
            get
            {
                return _TotalExperiencess;
            }

            set
            {
                _TotalExperiencess = value;
            }
        }

        public string RelevantExperiencess
        {
            get
            {
                return _RelevantExperiencess;
            }

            set
            {
                _RelevantExperiencess = value;
            }
        }

        public string ServiceFormImagePath { get => _ServiceFormImagePath; set => _ServiceFormImagePath = value; }
        public bool IsSubscriptionExpired { get => _IsSubscriptionExpired; set => _IsSubscriptionExpired = value; }

        public clsParticipantPlacementAssistanceDataSheet()
        {
            DBLayer = new DataAccessLayerHelper.clsParticipantPlacementAssistanceDataSheetData();
        }
        public void AddUpdate(clsParticipantPlacementAssistanceDataSheet obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsParticipantPlacementAssistanceDataSheet Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsParticipantPlacementAssistanceDataSheet> LoadAll(clsParticipantPlacementAssistanceDataSheet obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsParticipantPlacementAssistanceDataSheet> LoadForAll(clsParticipantPlacementAssistanceDataSheet obj)
        {
            return DBLayer.LoadForAll(obj);
        }
        public int LoadParticipantPlacementAssistanceDataSheetValidation(clsParticipantPlacementAssistanceDataSheet obj)
        {
            return DBLayer.LoadParticipantPlacementAssistanceDataSheetValidation(obj);
        }

        public List<clsParticipantPlacementAssistanceDataSheet> LoadAllNoticePeriod(clsParticipantPlacementAssistanceDataSheet obj)
        {
            return DBLayer.LoadAllNoticePeriod(obj);
        }
    }
}
