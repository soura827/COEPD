using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsTermsAcceptedParticipants
    {
        DataAccessLayerHelper.clsTermsAcceptedParticipantsData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _TermsAcceptedParticipantsId;
        private int _ParticipantId;
        private bool _IsTermsAccepted;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _Participant;
        private string _Email;
        private string _Mobile;
        private string _Employee;
        private string _Location;
        private string _ReferenceNo;
        private DateTime _StartDate;
        private DateTime? _DataSheeetTermsAcceptedOn;
        private DateTime? _PlacementInductionTermsAcceptedOn;
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

        public int? TermsAcceptedParticipantsId
        {
            get
            {
                return _TermsAcceptedParticipantsId;
            }

            set
            {
                _TermsAcceptedParticipantsId = value;
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

        public DateTime? DataSheeetTermsAcceptedOn
        {
            get
            {
                return _DataSheeetTermsAcceptedOn;
            }

            set
            {
                _DataSheeetTermsAcceptedOn = value;
            }
        }

        public DateTime? PlacementInductionTermsAcceptedOn
        {
            get
            {
                return _PlacementInductionTermsAcceptedOn;
            }

            set
            {
                _PlacementInductionTermsAcceptedOn = value;
            }
        }

        public clsTermsAcceptedParticipants()
        {
            DBLayer = new DataAccessLayerHelper.clsTermsAcceptedParticipantsData();
        }
        public void AddUpdate(clsTermsAcceptedParticipants obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsTermsAcceptedParticipants Load(int id)
        {
            return DBLayer.Load(id);
        }
        public clsTermsAcceptedParticipants LoadByParticipantId(int id)
        {
            return DBLayer.LoadByParticipantId(id);
        }
        public List<clsTermsAcceptedParticipants> LoadAll(clsTermsAcceptedParticipants obj)
        {
            return DBLayer.LoadAll(obj);
        }
    }
}
