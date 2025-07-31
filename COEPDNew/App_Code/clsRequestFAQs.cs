using DataAccessLayerHelper;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsRequestFAQs
    {
        clsRequestFAQsData DBLayer;

        private int _SNo;
        private int? _RequestFAQsId;
        private int _ParticipantId;
        private string _participant;
        private string _ProofOfInterviewPath;
        private string _Notes;
        private bool _IsApproved;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _KeyWords;
        private string _Location;
        private DateTime _StartDate;
        private String _Employee;
        private string _ModifiedName;
        private string _CompanyName;
        private int _TotalExperience;
        private int _RelevantExperience;
        private string _JobExpectedDomain;
        private string _JobExperienceDomain;
        private int _FAQsId;
        private string _FAQs;
        private int _ResumeSubmissionId;
        private string _InterviewStatus;
        private DateTime? _InterviewDate;
        private string _ProfileOwner;
        private string _Email;
        private string _Mobile;
        private int _InterviewStatusId;
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

        public string Notes
        {
            get
            {
                return _Notes;
            }

            set
            {
                _Notes = value;
            }
        }

        public bool IsApproved
        {
            get
            {
                return _IsApproved;
            }

            set
            {
                _IsApproved = value;
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

        public int? CreatedBy
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

        public int? RequestFAQsId
        {
            get
            {
                return _RequestFAQsId;
            }

            set
            {
                _RequestFAQsId = value;
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

        public string ProofOfInterviewPath
        {
            get
            {
                return _ProofOfInterviewPath;
            }

            set
            {
                _ProofOfInterviewPath = value;
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

        public string ModifiedName
        {
            get
            {
                return _ModifiedName;
            }

            set
            {
                _ModifiedName = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return _CompanyName;
            }

            set
            {
                _CompanyName = value;
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

        public int FAQsId
        {
            get
            {
                return _FAQsId;
            }

            set
            {
                _FAQsId = value;
            }
        }

        public string FAQs
        {
            get
            {
                return _FAQs;
            }

            set
            {
                _FAQs = value;
            }
        }

        public int ResumeSubmissionId
        {
            get
            {
                return _ResumeSubmissionId;
            }

            set
            {
                _ResumeSubmissionId = value;
            }
        }

        public string InterviewStatus
        {
            get
            {
                return _InterviewStatus;
            }

            set
            {
                _InterviewStatus = value;
            }
        }

        public DateTime? InterviewDate
        {
            get
            {
                return _InterviewDate;
            }

            set
            {
                _InterviewDate = value;
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

        public int InterviewStatusId
        {
            get
            {
                return _InterviewStatusId;
            }

            set
            {
                _InterviewStatusId = value;
            }
        }

        public clsRequestFAQs()

        {
            DBLayer = new DataAccessLayerHelper.clsRequestFAQsData();
        }
        public void AddUpdate(clsRequestFAQs obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsRequestFAQs Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsRequestFAQs> LoadAll(clsRequestFAQs obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public int LoadRequestFAQsValidation(clsRequestFAQs obj)
        {
            return DBLayer.LoadRequestFAQsValidation(obj);
        }
        public void Remove(int obj)
        {
            DBLayer.Remove(obj);
        }
        public int LoadRequestFAQsMultiValidation(clsRequestFAQs obj)
        {
            return DBLayer.LoadRequestFAQsMultiValidation(obj);
        }


    }


}
