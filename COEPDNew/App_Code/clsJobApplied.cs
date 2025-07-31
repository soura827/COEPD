using DataAccessLayerHelper;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsJobApplied
    {
        clsJobAppliedData DBLayer;
        private int _SNO;
        private string _Keywords;
        private int? _JobAppliedId;
        private int _JobId;
        private int _ParticipantId;
        private bool _IsActive;
        private bool _IsDeleted;
        private int _CreatedBy;
        private DateTime _CreatedOn;
        private string _Location;
        private string _Company;
        private string _Participant;
        private string _Email;
        private string _Mobile;
        private string _JobTitle;
        private int _InterviewStatusId;
        private string _InterviewStatus;



        public int SNO
        {
            get
            {
                return _SNO;
            }

            set
            {
                _SNO = value;
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

        public int? JobAppliedId
        {
            get
            {
                return _JobAppliedId;
            }

            set
            {
                _JobAppliedId = value;
            }
        }

        public int JobId
        {
            get
            {
                return _JobId;
            }

            set
            {
                _JobId = value;
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

        public string Company
        {
            get
            {
                return _Company;
            }

            set
            {
                _Company = value;
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

        public string JobTitle
        {
            get
            {
                return _JobTitle;
            }

            set
            {
                _JobTitle = value;
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

        public clsJobApplied()
        {
            DBLayer = new clsJobAppliedData();
        }
        public void AddUpdate(clsJobApplied obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public List<clsJobApplied> LoadAll(clsJobApplied obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsJobApplied> LoadAllInterviewStatus(clsJobApplied obj)
        {
            return DBLayer.LoadAllInterviewStatus(obj);
        }
    }
}
