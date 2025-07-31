using DataAccessLayerHelper;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsInterviewSupport
    {
        clsInterviewSupportData DbLayer;
        private int _SNo;
        private int? _InterviewSupportId;
        private int _ParticipantId;
        private string _participant;
        private string _CaseStudyPath;
        private string _CaseStudyReplyPath;
        private DateTime? _TargetDate;
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
        private int _ResumeSubmissionId;
        private string _InterviewStatus;
        private string _ProfileOwner;
        private string _Email;
        private string _Mobile;
        private int _InterviewStatusId;
        private string _TotalCount;
        private int _PendingInterviewSupport;
        private bool _IsMentorAssigned;
        private int _MentorId;
        private string _MentorName;
        private int _MentorAssignedBy;
        private DateTime? _MentorAssignedOn;

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

        public int? InterviewSupportId
        {
            get
            {
                return _InterviewSupportId;
            }

            set
            {
                _InterviewSupportId = value;
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

        public DateTime? TargetDate
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

        public string TotalCount { get => _TotalCount; set => _TotalCount = value; }
        public int PendingInterviewSupport { get => _PendingInterviewSupport; set => _PendingInterviewSupport = value; }
        public bool IsMentorAssigned { get => _IsMentorAssigned; set => _IsMentorAssigned = value; }
        public int MentorId { get => _MentorId; set => _MentorId = value; }
        public string MentorName { get => _MentorName; set => _MentorName = value; }
        public int MentorAssignedBy { get => _MentorAssignedBy; set => _MentorAssignedBy = value; }
        public DateTime? MentorAssignedOn { get => _MentorAssignedOn; set => _MentorAssignedOn = value; }

        public clsInterviewSupport()
        {
            DbLayer = new clsInterviewSupportData();
        }
        public void AddUpdate(clsInterviewSupport obj)
        {
            DbLayer.AddUpdate(obj);
        }
        public void AddMentor(clsInterviewSupport obj)
        {
            DbLayer.AddMentor(obj);
        }

        public clsInterviewSupport Load(int Id)
        {
            return DbLayer.Load(Id);
        }
        public List<clsInterviewSupport> LoadAll(clsInterviewSupport obj)
        {
            return DbLayer.LoadAll(obj);
        }
        public int LoadInterviewSupportValidation(clsInterviewSupport obj)
        {
            return DbLayer.LoadInterviewSupportValidation(obj);
        }
    }
}
