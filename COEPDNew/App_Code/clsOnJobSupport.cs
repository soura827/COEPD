using DataAccessLayerHelper;
using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for clsOnJobSupport
/// </summary>
/// 

namespace BusinessLayer
{
    public class clsOnJobSupport
    {
        clsOnJobSupportData DBLayer;

        private int _SNo;
        private int? _OnJobSupportId;
        private string _Project;
        private string _Domain;
        private string _GoogleReviewPath;
        private string _CaseStudyPath;
        private string _Notes;
        private bool _IsApproved;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime? _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _Fullname;
        private int _ResumeSubmissionId;
        private int _ParticipantId;
        private string _CompanyName;
        private string _CaseStudyReplyPath;

        private string _KeyWords;
        private string _Location;
        private DateTime _StartDate;
        private String _Employee;
        private string _ModifiedName;
        private int _TotalExperience;
        private int _RelevantExperience;
        private string _JobExpectedDomain;
        private string _JobExperienceDomain;
        private string _Participant;
        private string _ProfileOwner;
        private string _Email;
        private string _Mobile;
        private string _InterviewStatus;
        public clsOnJobSupport()
        {
            DBLayer = new DataAccessLayerHelper.clsOnJobSupportData();
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

        public int? OnJobSupportId
        {
            get
            {
                return _OnJobSupportId;
            }

            set
            {
                _OnJobSupportId = value;
            }
        }

        public string Project
        {
            get
            {
                return _Project;
            }

            set
            {
                _Project = value;
            }
        }

        public string Domain
        {
            get
            {
                return _Domain;
            }

            set
            {
                _Domain = value;
            }
        }

        public string GoogleReviewPath
        {
            get
            {
                return _GoogleReviewPath;
            }

            set
            {
                _GoogleReviewPath = value;
            }
        }

        public string CaseStudyPath
        {
            get
            {
                return _CaseStudyPath;
            }

            set
            {
                _CaseStudyPath = value;
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

        public DateTime? CreatedOn
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

        public string Fullname
        {
            get
            {
                return _Fullname;
            }

            set
            {
                _Fullname = value;
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

        public string CaseStudyReplyPath
        {
            get
            {
                return _CaseStudyReplyPath;
            }

            set
            {
                _CaseStudyReplyPath = value;
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

        public string Participant
        {
            get
            {
                return _Participant;
            }

            set
            {
                _Participant = value;
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

        public void AddUpdate(clsOnJobSupport obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsOnJobSupport Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsOnJobSupport> LoadAll(clsOnJobSupport obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int obj)
        {
            DBLayer.Remove(obj);
        }
    }

}

