using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsResumeSubmission
    {
        DataAccessLayerHelper.clsResumeSubmissionData DBLayer;
        private int _SNo;
        private int? _ResumeSubmissionId;
        private int _ParticipantId;
        private string _Trainer;
        private string _CompanyName;
        private string _JobDescription;
        private string _Location;
        private string _Experience;
        private string _Domain;
        private DateTime _AppliedOn;
        private int _AppliedThroughId;
        private int _CreatedBy;
        private string _Participant;
        private DateTime _CreatedOn;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _Keywords;
        private DateTime _StartDate;
        private string _ParticipantLocation;
        private int _InterviewStatusId;
        private string _InterviewStatus;
        private string _Designation;
        private string _PackageOffered;
        private DateTime? _DateofJoining;
        private bool _IsRegisteredOnJobSupport;
        private string _GoogleReviewLink;
        private string _AppliedThrough;
        private DateTime? _InterviewRound1On;
        private DateTime? _InterviewRound2On;
        private DateTime? _InterviewRound3On;
        private DateTime? _OfferReleasedOn;
        private DateTime? _OfferAcceptedOn;
        private bool _IsOfferAccepted;
        private string _ProfileOwner;
        private string _Email;
        private string _Mobile;
        private int _TotalPlacements;
        private int _TotalofferReleased;
        private string _InitialDiscussionRound;
        private string _SelectedorRejected;
        private string _Remarks;
        private string _Fullname;

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

        public int? ResumeSubmissionId
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

        public string JobDescription
        {
            get
            {
                return _JobDescription;
            }

            set
            {
                _JobDescription = value;
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

        public string Experience
        {
            get
            {
                return _Experience;
            }

            set
            {
                _Experience = value;
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

        public DateTime AppliedOn
        {
            get
            {
                return _AppliedOn;
            }

            set
            {
                _AppliedOn = value;
            }
        }

        public int AppliedThroughId
        {
            get
            {
                return _AppliedThroughId;
            }

            set
            {
                _AppliedThroughId = value;
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

        public string Keywords
        {
            get
            {
                return _Keywords;
            }

            set
            {
                _Keywords = value;
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

        public string Trainer
        {
            get
            {
                return _Trainer;
            }

            set
            {
                _Trainer = value;
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

        public string ParticipantLocation
        {
            get
            {
                return _ParticipantLocation;
            }

            set
            {
                _ParticipantLocation = value;
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

        public string Designation
        {
            get
            {
                return _Designation;
            }

            set
            {
                _Designation = value;
            }
        }

        public string PackageOffered
        {
            get
            {
                return _PackageOffered;
            }

            set
            {
                _PackageOffered = value;
            }
        }

        public DateTime? DateofJoining
        {
            get
            {
                return _DateofJoining;
            }

            set
            {
                _DateofJoining = value;
            }
        }

        public bool IsRegisteredOnJobSupport
        {
            get
            {
                return _IsRegisteredOnJobSupport;
            }

            set
            {
                _IsRegisteredOnJobSupport = value;
            }
        }

        public string GoogleReviewLink
        {
            get
            {
                return _GoogleReviewLink;
            }

            set
            {
                _GoogleReviewLink = value;
            }
        }

        public string AppliedThrough
        {
            get
            {
                return _AppliedThrough;
            }

            set
            {
                _AppliedThrough = value;
            }
        }

        public DateTime? InterviewRound1On
        {
            get
            {
                return _InterviewRound1On;
            }

            set
            {
                _InterviewRound1On = value;
            }
        }

        public DateTime? InterviewRound2On
        {
            get
            {
                return _InterviewRound2On;
            }

            set
            {
                _InterviewRound2On = value;
            }
        }

        public DateTime? InterviewRound3On
        {
            get
            {
                return _InterviewRound3On;
            }

            set
            {
                _InterviewRound3On = value;
            }
        }

        public DateTime? OfferReleasedOn
        {
            get
            {
                return _OfferReleasedOn;
            }

            set
            {
                _OfferReleasedOn = value;
            }
        }

        public DateTime? OfferAcceptedOn
        {
            get
            {
                return _OfferAcceptedOn;
            }

            set
            {
                _OfferAcceptedOn = value;
            }
        }

        public bool IsOfferAccepted
        {
            get
            {
                return _IsOfferAccepted;
            }

            set
            {
                _IsOfferAccepted = value;
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

        public int TotalPlacements { get => _TotalPlacements; set => _TotalPlacements = value; }
        public int TotalofferReleased { get => _TotalofferReleased; set => _TotalofferReleased = value; }
        public string InitialDiscussionRound { get => _InitialDiscussionRound; set => _InitialDiscussionRound = value; }
        public string SelectedorRejected { get => _SelectedorRejected; set => _SelectedorRejected = value; }
        public string Remarks { get => _Remarks; set => _Remarks = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }


        //public string InitialDiscussionRound { get => _InitialDiscussionRound; set => _InitialDiscussionRound = value; }
        //public string Rejected { get => _Rejected; set => _Rejected = value; }

        public clsResumeSubmission()
        {
            DBLayer = new DataAccessLayerHelper.clsResumeSubmissionData();
        }
        public void AddUpdate(clsResumeSubmission obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsResumeSubmission Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsResumeSubmission> LoadAll(clsResumeSubmission obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
    }

}