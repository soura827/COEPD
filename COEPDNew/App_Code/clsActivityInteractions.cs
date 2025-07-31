using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsActivityInteractions
    {
        DataAccessLayerHelper.clsActivityInteractionsData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _ActivityInteractionsId;
        private int _ActivityInstanceId;
        private int _EmployeeId;
        private int _ParticipantId;
        private string _Participant;
        private string _Fullname;
        private string _Employee;
        private string _ActivityInteractionInputs;
        private DateTime _StartDate;
        private DateTime _EndDate;
        private DateTime _SystemStartTime;
        private DateTime _SystemEndTime;
        private DateTime? _DateToWorkOn;
        private string _Description;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _Activity;
        private string _ActivityCategory;
        private string _ActivitySubcategory;
        private string _ModifiedName;
        //private string _Location;
        private string _Lead;
        private string _Vendor;
        private int _ActivityCategoryId;
        private int _ActivitySubCategoryId;
        private int _ActivityId;
        private int _NoOfEmployeeId;
        private int _NoOfParticipantId;
        private int _NoOfLeads;
        private int _NoOfVendors;
        private int _FollowUpId;
        private string _Status;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private string _InputsEnteredBy;
        private string _Branch;
        private int _BranchId;
        private string _InvolvedEmployees;
        private string _InvolvedParticipants;
        private string _InvolvedLeads;
        private string _InvolvedVendros;
        private int _SystemHours;
        private int _SystemMinutes;
        private DateTime _EnteredStartTime;
        private DateTime _EnteredEndTime;
        private int _EnteredMinutes;
        private DateTime _Date;

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

        public int? ActivityInteractionsId
        {
            get
            {
                return _ActivityInteractionsId;
            }

            set
            {
                _ActivityInteractionsId = value;
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

        public DateTime SystemStartTime
        {
            get
            {
                return _SystemStartTime;
            }

            set
            {
                _SystemStartTime = value;
            }
        }

        public DateTime SystemEndTime
        {
            get
            {
                return _SystemEndTime;
            }

            set
            {
                _SystemEndTime = value;
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

        public string Lead
        {
            get
            {
                return _Lead;
            }

            set
            {
                _Lead = value;
            }
        }

        public string Vendor
        {
            get
            {
                return _Vendor;
            }

            set
            {
                _Vendor = value;
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

        public int FollowUpId
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

        public string InputsEnteredBy
        {
            get
            {
                return _InputsEnteredBy;
            }

            set
            {
                _InputsEnteredBy = value;
            }
        }

        public string Branch
        {
            get
            {
                return _Branch;
            }

            set
            {
                _Branch = value;
            }
        }

        public int BranchId
        {
            get
            {
                return _BranchId;
            }

            set
            {
                _BranchId = value;
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

        public string InvolvedVendros
        {
            get
            {
                return _InvolvedVendros;
            }

            set
            {
                _InvolvedVendros = value;
            }
        }

        public int SystemHours
        {
            get
            {
                return _SystemHours;
            }

            set
            {
                _SystemHours = value;
            }
        }

        public int SystemMinutes
        {
            get
            {
                return _SystemMinutes;
            }

            set
            {
                _SystemMinutes = value;
            }
        }

        public DateTime EnteredStartTime
        {
            get
            {
                return _EnteredStartTime;
            }

            set
            {
                _EnteredStartTime = value;
            }
        }

        public DateTime EnteredEndTime
        {
            get
            {
                return _EnteredEndTime;
            }

            set
            {
                _EnteredEndTime = value;
            }
        }

        public int EnteredMinutes
        {
            get
            {
                return _EnteredMinutes;
            }

            set
            {
                _EnteredMinutes = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _Date;
            }

            set
            {
                _Date = value;
            }
        }

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

        public clsActivityInteractions()
        {
            DBLayer = new DataAccessLayerHelper.clsActivityInteractionsData();
        }
        public void AddUpdate(clsActivityInteractions obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsActivityInteractions Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        //public clsActivityInteractions LoadActivityInstanceId(int Id)
        //{
        //    return DBLayer.LoadActivityInstanceId(Id);
        //}
        public List<clsActivityInteractions> LoadAll(clsActivityInteractions obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsActivityInteractions> LoadAllTasks(clsActivityInteractions obj)
        {
            return DBLayer.LoadAllTasks(obj);
        }
        public List<clsActivityInteractions> LoadAllParticipantInteractions(clsActivityInteractions obj)
        {
            return DBLayer.LoadAllParticipantInteractions(obj);
        }
        public List<clsActivityInteractions> LoadDailyReportByEmployee(clsActivityInteractions obj)
        {
            return DBLayer.LoadDailyReportByEmployee(obj);
        }

        public List<string> LoadDailySummaryByEmployee(clsActivityInteractions obj)
        {
            return DBLayer.LoadDailySummaryByEmployee(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
