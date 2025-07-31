using System;
using System.Collections.Generic;


namespace BusinessLayer
{
    public class clsActivityInstance
    {
        DataAccessLayerHelper.clsActivityInstanceData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _ActivityInstanceId;
        private int _ActivityCategoryId;
        private string _ActivityCategory;
        private int _ActivitySubCategoryId;
        private string _ActivitySubcategory;
        private int _ActivityId;
        private string _Activity;
        private int _NoOfEmployeeId;
        private int _NoOfParticipantId;
        private string _Participant;
        private string _Employee;
        //private int _LocationId;
        //private string _Location;
        private string _UniqueId;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private string _Fullname;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _ModifiedName;
        private DateTime? _DateToWorkOn;
        private string _Description;
        private int? _FollowUpId;
        private string _Status;
        private int _EmployeeId;
        private int _ParticipantId;
        private string _ActivityInstanceStatus;
        private int _NoOfLeads;
        private int _NoOfVendors;
        private string _InvolvedEmployees;
        private string _InvolvedParticipants;
        private string _InvolvedLeads;
        private string _InvolvedVendors;
        private string _ParticipantsPhoneNumbers;
        private string _LeadsPhoneNumbers;
        private string _VendorsPhoneNumbers;
        private string _EmployeesPhoneNumbers;
        private string _JobDescription;
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
        public int? ActivityInstanceId
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
        public int ActivityCategoryId
        {
            get
            {
                return _ActivityCategoryId;
            }

            set
            {
                _ActivityCategoryId = value;
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

        public int ActivitySubCategoryId
        {
            get
            {
                return _ActivitySubCategoryId;
            }

            set
            {
                _ActivitySubCategoryId = value;
            }
        }

        public string ActivitySubcategory
        {
            get
            {
                return _ActivitySubcategory;
            }

            set
            {
                _ActivitySubcategory = value;
            }
        }

        public int ActivityId
        {
            get
            {
                return _ActivityId;
            }

            set
            {
                _ActivityId = value;
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

        public int NoOfEmployeeId
        {
            get
            {
                return _NoOfEmployeeId;
            }

            set
            {
                _NoOfEmployeeId = value;
            }
        }

        public int NoOfParticipantId
        {
            get
            {
                return _NoOfParticipantId;
            }

            set
            {
                _NoOfParticipantId = value;
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

        //public int LocationId
        //{
        //    get
        //    {
        //        return _LocationId;
        //    }

        //    set
        //    {
        //        _LocationId = value;
        //    }
        //}

        //public string Location
        //{
        //    get
        //    {
        //        return _Location;
        //    }

        //    set
        //    {
        //        _Location = value;
        //    }
        //}

        //public string ActivityInputs
        //{
        //    get
        //    {
        //        return _ActivityInputs;
        //    }

        //    set
        //    {
        //        _ActivityInputs = value;
        //    }
        //}

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

        public string UniqueId
        {
            get
            {
                return _UniqueId;
            }

            set
            {
                _UniqueId = value;
            }
        }

        public DateTime? DateToWorkOn
        {
            get
            {
                return _DateToWorkOn;
            }

            set
            {
                _DateToWorkOn = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }

            set
            {
                _Description = value;
            }
        }

        public int? FollowUpId
        {
            get
            {
                return _FollowUpId;
            }

            set
            {
                _FollowUpId = value;
            }
        }

        public string Status
        {
            get
            {
                return _Status;
            }

            set
            {
                _Status = value;
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

        public string ActivityInstanceStatus
        {
            get
            {
                return _ActivityInstanceStatus;
            }

            set
            {
                _ActivityInstanceStatus = value;
            }
        }

        public int NoOfLeads
        {
            get
            {
                return _NoOfLeads;
            }

            set
            {
                _NoOfLeads = value;
            }
        }

        public int NoOfVendors
        {
            get
            {
                return _NoOfVendors;
            }

            set
            {
                _NoOfVendors = value;
            }
        }

        public string InvolvedEmployees
        {
            get
            {
                return _InvolvedEmployees;
            }

            set
            {
                _InvolvedEmployees = value;
            }
        }

        public string InvolvedParticipants
        {
            get
            {
                return _InvolvedParticipants;
            }

            set
            {
                _InvolvedParticipants = value;
            }
        }

        public string InvolvedLeads
        {
            get
            {
                return _InvolvedLeads;
            }

            set
            {
                _InvolvedLeads = value;
            }
        }

        public string InvolvedVendors
        {
            get
            {
                return _InvolvedVendors;
            }

            set
            {
                _InvolvedVendors = value;
            }
        }

        public string ParticipantsPhoneNumbers
        {
            get
            {
                return _ParticipantsPhoneNumbers;
            }

            set
            {
                _ParticipantsPhoneNumbers = value;
            }
        }

        public string LeadsPhoneNumbers
        {
            get
            {
                return _LeadsPhoneNumbers;
            }

            set
            {
                _LeadsPhoneNumbers = value;
            }
        }

        public string VendorsPhoneNumbers
        {
            get
            {
                return _VendorsPhoneNumbers;
            }

            set
            {
                _VendorsPhoneNumbers = value;
            }
        }

        public string EmployeesPhoneNumbers
        {
            get
            {
                return _EmployeesPhoneNumbers;
            }

            set
            {
                _EmployeesPhoneNumbers = value;
            }
        }

        public string JobDescription { get => _JobDescription; set => _JobDescription = value; }

        public clsActivityInstance()
        {
            DBLayer = new DataAccessLayerHelper.clsActivityInstanceData();
        }



        public void AddUpdate(clsActivityInstance obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsActivityInstance Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public clsActivityInstance LoadUniqueId(string id)
        {
            return DBLayer.LoadUniqueId(id);
        }
        public List<clsActivityInstance> LoadAll(clsActivityInstance obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
