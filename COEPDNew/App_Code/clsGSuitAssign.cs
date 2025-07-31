using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsGSuitAssign
    {
        DataAccessLayerHelper.clsGSuitAssignData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _GSuitEmailAssignId;
        private int _GSuitEmailId;
        private string _GSuitEmail;
        private int _EmployeeId;
        private string _Employee;
        private string _Purpose;
        private DateTime _EmailAssignedDate;
        private DateTime? _EmailUnAssignedDate;
        private bool _IsEmailUnAssigned;
        private string _Remarks;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime? _ModifiedOn;
        private string _Fullname;
        private string _ModifiedByName;


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

        public string Purpose
        {
            get
            {
                return _Purpose;
            }

            set
            {
                _Purpose = value;
            }
        }

        public DateTime EmailAssignedDate
        {
            get
            {
                return _EmailAssignedDate;
            }

            set
            {
                _EmailAssignedDate = value;
            }
        }

        public DateTime? EmailUnAssignedDate
        {
            get
            {
                return _EmailUnAssignedDate;
            }

            set
            {
                _EmailUnAssignedDate = value;
            }
        }

        public bool IsEmailUnAssigned
        {
            get
            {
                return _IsEmailUnAssigned;
            }

            set
            {
                _IsEmailUnAssigned = value;
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
        public int? GSuitEmailAssignId
        {
            get
            {
                return _GSuitEmailAssignId;
            }

            set
            {
                _GSuitEmailAssignId = value;
            }
        }

        public int GSuitEmailId
        {
            get
            {
                return _GSuitEmailId;
            }

            set
            {
                _GSuitEmailId = value;
            }
        }

        public string Remarks
        {
            get
            {
                return _Remarks;
            }

            set
            {
                _Remarks = value;
            }
        }

        public string GSuitEmail
        {
            get
            {
                return _GSuitEmail;
            }

            set
            {
                _GSuitEmail = value;
            }
        }

        public clsGSuitAssign()
        {
            DBLayer = new DataAccessLayerHelper.clsGSuitAssignData();
        }
        public void AddUpdate(clsGSuitAssign obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsGSuitAssign Load(int id)
        {
            return DBLayer.Load(id);
        }
        public List<clsGSuitAssign> LoadAll(clsGSuitAssign obj)
        {
            return DBLayer.LoadAll(obj);
        }
    }
}
