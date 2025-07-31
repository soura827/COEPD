using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsPlacementServiceRequest
    {
        DataAccessLayerHelper.clsPlacementServiceRequestData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _PlacementServiceRequestId;
        private string _ServiceRequest;
        private int _ParticipantId;
        private string _Participant;
        private int _EmployeeId;
        private string _Employee;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private int _RoleId;
        private string _Email;
        private string _Mobile;
        private string _Username;
        private string _Location;
        private bool _IsReplied;
        private DateTime? _ModifiedOn;
        private string _ModifiedName;
        private string _SenderImagePath;
        private string _ReceiverImagePath;
        private String _TotalCount;
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

        public int? PlacementServiceRequestId
        {
            get
            {
                return _PlacementServiceRequestId;
            }

            set
            {
                _PlacementServiceRequestId = value;
            }
        }

        public string ServiceRequest
        {
            get
            {
                return _ServiceRequest;
            }

            set
            {
                _ServiceRequest = value;
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
                return _Participant;
            }

            set
            {
                _Participant = value;
            }
        }

        public int EmployeeId
        {
            get
            {
                return _EmployeeId;
            }

            set
            {
                _EmployeeId = value;
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

        public int RoleId
        {
            get
            {
                return _RoleId;
            }

            set
            {
                _RoleId = value;
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

        public string Username
        {
            get
            {
                return _Username;
            }

            set
            {
                _Username = value;
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

        public bool IsReplied
        {
            get
            {
                return _IsReplied;
            }

            set
            {
                _IsReplied = value;
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

        public string SenderImagePath
        {
            get
            {
                return _SenderImagePath;
            }

            set
            {
                _SenderImagePath = value;
            }
        }

        public string ReceiverImagePath
        {
            get
            {
                return _ReceiverImagePath;
            }

            set
            {
                _ReceiverImagePath = value;
            }
        }

        public string TotalCount { get => _TotalCount; set => _TotalCount = value; }

        public clsPlacementServiceRequest()
        {
            DBLayer = new DataAccessLayerHelper.clsPlacementServiceRequestData();
        }
        public void AddUpdate(clsPlacementServiceRequest obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsPlacementServiceRequest Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public clsPlacementServiceRequest LoadTopOne(int Id)
        {
            return DBLayer.LoadTopOne(Id);
        }

        public List<clsPlacementServiceRequest> LoadAll(clsPlacementServiceRequest obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsPlacementServiceRequest> LoadParticipantsAll(clsPlacementServiceRequest obj)
        {
            return DBLayer.LoadParticipantsAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public int LoadPlacementPendingServiceRequestCount(clsPlacementServiceRequest obj)
        {
            return DBLayer.LoadPlacementPendingServiceRequestCount(obj);
        }
        public clsPlacementServiceRequest GetByPendingServiceRequest(int ParticipantId)
        {
            return DBLayer.GetByPendingServiceRequest(ParticipantId);
        }
        public int LoadPlacementServiceRequestValidation(clsPlacementServiceRequest obj)
        {
            return DBLayer.LoadPlacementServiceRequestValidation(obj);
        }


    }
}
