using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsActivityInstanceGroup
    {
        DataAccessLayerHelper.clsActivityInstanceGroupData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _ActivityInstanceGroupId;
        private int _ActivityInstanceId;
        private int _EmployeeId;
        private int _ParticipantId;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _ActivityInteractionInputs;
        private string _Employee;
        private string _Participant;
        private string _Activity;
        private string _ActivitySubCategory;
        private string _ActivityCategory;
        private string _FullName;
        private string _ModifiedByName;
        private DateTime _StartDate;
        private DateTime _EndDate;
        private DateTime _StartTime;
        private DateTime _EndTime;
        private int _LeadId;
        private int _VendorId;
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

        public int? ActivityInstanceGroupId
        {
            get
            {
                return _ActivityInstanceGroupId;
            }

            set
            {
                _ActivityInstanceGroupId = value;
            }
        }

        public int ActivityInstanceId
        {
            get
            {
                return _ActivityInstanceId;
            }

            set
            {
                _ActivityInstanceId = value;
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

        public string ActivityInteractionInputs
        {
            get
            {
                return _ActivityInteractionInputs;
            }

            set
            {
                _ActivityInteractionInputs = value;
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

        public string Activity
        {
            get
            {
                return _Activity;
            }

            set
            {
                _Activity = value;
            }
        }

        public string ActivitySubCategory
        {
            get
            {
                return _ActivitySubCategory;
            }

            set
            {
                _ActivitySubCategory = value;
            }
        }

        public string ActivityCategory
        {
            get
            {
                return _ActivityCategory;
            }

            set
            {
                _ActivityCategory = value;
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

        public string ModifiedByName
        {
            get
            {
                return _ModifiedByName;
            }

            set
            {
                _ModifiedByName = value;
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

        public DateTime EndDate
        {
            get
            {
                return _EndDate;
            }

            set
            {
                _EndDate = value;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return _StartTime;
            }

            set
            {
                _StartTime = value;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return _EndTime;
            }

            set
            {
                _EndTime = value;
            }
        }

        public int LeadId
        {
            get
            {
                return _LeadId;
            }

            set
            {
                _LeadId = value;
            }
        }

        public int VendorId
        {
            get
            {
                return _VendorId;
            }

            set
            {
                _VendorId = value;
            }
        }

        public clsActivityInstanceGroup()
        {
            DBLayer = new DataAccessLayerHelper.clsActivityInstanceGroupData();
        }
        public void AddUpdate(clsActivityInstanceGroup obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsActivityInstanceGroup Load(int id)
        {
            return DBLayer.Load(id);
        }
        public List<clsActivityInstanceGroup> LoadAll(clsActivityInstanceGroup obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
    }
}