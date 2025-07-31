using System;
using System.Collections.Generic;


namespace BusinessLayer
{
    public class clsPlacementInduction
    {

        DataAccessLayerHelper.clsPlacementInductionData DBLayer;

        private int? _PlacementInductionId;
        private int _ParticipantId;
        private DateTime _AttendedOn;
        private bool _IsTermsAccepted;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private int _ModifiedBy;
        private DateTime? _ModifiedOn;
        private string _participant;
        private string _Email;
        private string _Mobile;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private string _KeyWords;
        private int _SNo;
        private string _HRMockFeebackImagePath;
        private decimal _Score;
        private string _HRMockInputs;
        private bool _IsHRMockApproved;
        private string _ReferenceNo;
        private DateTime _SubscriptionExpiredOn;
        private DateTime _StartDate;
        private string _Location;
        private string _Employee;
        private string _ProfileOwner;
        private string _TotalExperience;
        private string _Qualification;
        private int _ConductHRMcokFeedBackFormId;
        private int _HRMockQuestionId;
        private string _QuestionName;
        private int _RemarksId;
        private int _RatingId;
        private int _TotalScore;




        public int? PlacementInductionId
        {
            get
            {
                return _PlacementInductionId;
            }

            set
            {
                _PlacementInductionId = value;
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

        public DateTime AttendedOn
        {
            get
            {
                return _AttendedOn;
            }

            set
            {
                _AttendedOn = value;
            }
        }

        public bool IsTermsAccepted
        {
            get
            {
                return _IsTermsAccepted;
            }

            set
            {
                _IsTermsAccepted = value;
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

        public string Participant
        {
            get
            {
                return _participant;
            }

            set
            {
                _participant = value;
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

        public string Mobile
        {
            get
            {
                return _Mobile;
            }

            set
            {
                _Mobile = value;
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

        public string KeyWords
        {
            get
            {
                return _KeyWords;
            }

            set
            {
                _KeyWords = value;
            }
        }

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

        public string HRMockFeebackImagePath
        {
            get
            {
                return _HRMockFeebackImagePath;
            }

            set
            {
                _HRMockFeebackImagePath = value;
            }
        }

        public decimal Score
        {
            get
            {
                return _Score;
            }

            set
            {
                _Score = value;
            }
        }

        public string HRMockInputs
        {
            get
            {
                return _HRMockInputs;
            }

            set
            {
                _HRMockInputs = value;
            }
        }

        public bool IsHRMockApproved
        {
            get
            {
                return _IsHRMockApproved;
            }

            set
            {
                _IsHRMockApproved = value;
            }
        }

        public string ReferenceNo
        {
            get
            {
                return _ReferenceNo;
            }

            set
            {
                _ReferenceNo = value;
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

        public DateTime StartDate
        {
            get
            {
                return _StartDate;
            }

            set
            {
                _StartDate = value;
            }
        }

        public string Location
        {
            get
            {
                return _Location;
            }

            set
            {
                _Location = value;
            }
        }

        public string Employee
        {
            get
            {
                return _Employee;
            }

            set
            {
                _Employee = value;
            }
        }

        public string ProfileOwner
        {
            get
            {
                return _ProfileOwner;
            }

            set
            {
                _ProfileOwner = value;
            }
        }

        public string TotalExperience
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

        public string Qualification
        {
            get
            {
                return _Qualification;
            }

            set
            {
                _Qualification = value;
            }
        }

        public int ConductHRMcokFeedBackFormId { get => _ConductHRMcokFeedBackFormId; set => _ConductHRMcokFeedBackFormId = value; }
        public int HRMockQuestionId { get => _HRMockQuestionId; set => _HRMockQuestionId = value; }
        public string QuestionName { get => _QuestionName; set => _QuestionName = value; }
        public int RemarksId { get => _RemarksId; set => _RemarksId = value; }
        public int RatingId { get => _RatingId; set => _RatingId = value; }
        public int TotalScore { get => _TotalScore; set => _TotalScore = value; }

        public clsPlacementInduction()
        {
            DBLayer = new DataAccessLayerHelper.clsPlacementInductionData();
        }
        public void AddUpdate(clsPlacementInduction obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsPlacementInduction Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsPlacementInduction> LoadAll(clsPlacementInduction obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public int LoadPlacementInductionValidation(clsPlacementInduction obj)
        {
            return DBLayer.LoadPlacementInductionValidation(obj);
        }
        public void AddUpdateHRMock(clsPlacementInduction obj)
        {
            DBLayer.AddUpdateHRMock(obj);
        }
        public int LoadInductionValidation(clsHRMockFeedBack obj)
        {
            return DBLayer.LoadInductionValidation(obj);
        }

    }


}
