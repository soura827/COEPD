using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsCUGSimAssign
    {
        DataAccessLayerHelper.clsCUGSimAssignData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _CUGSimAssignId;
        private int _CUGSimId;
        private int _EmployeeId;
        private string _Employee;
        private string _Mobile;
        private string _SimUsedFor;
        private DateTime _SimAssignedDate;
        private DateTime? _SimUnAssignedDate;
        private string _AadharNumber;
        private string _Remarks;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _Fullname;
        private bool _IsSimUnAssigned;
        private string _ModifiedByName;
        private string _TarifPlan;
        private string _Code;

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

        public int? CUGSimAssignId
        {
            get
            {
                return _CUGSimAssignId;
            }

            set
            {
                _CUGSimAssignId = value;
            }
        }

        public int CUGSimId
        {
            get
            {
                return _CUGSimId;
            }

            set
            {
                _CUGSimId = value;
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



        public string SimUsedFor
        {
            get
            {
                return _SimUsedFor;
            }

            set
            {
                _SimUsedFor = value;
            }
        }

        public DateTime SimAssignedDate
        {
            get
            {
                return _SimAssignedDate;
            }

            set
            {
                _SimAssignedDate = value;
            }
        }

        public DateTime? SimUnAssignedDate
        {
            get
            {
                return _SimUnAssignedDate;
            }

            set
            {
                _SimUnAssignedDate = value;
            }
        }

        public string AadharNumber
        {
            get
            {
                return _AadharNumber;
            }

            set
            {
                _AadharNumber = value;
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

        public bool IsSimUnAssigned
        {
            get
            {
                return _IsSimUnAssigned;
            }

            set
            {
                _IsSimUnAssigned = value;
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

        public string TarifPlan
        {
            get
            {
                return _TarifPlan;
            }

            set
            {
                _TarifPlan = value;
            }
        }

        public string Code { get => _Code; set => _Code = value; }

        public clsCUGSimAssign()
        {
            DBLayer = new DataAccessLayerHelper.clsCUGSimAssignData();
        }
        public void AddUpdate(clsCUGSimAssign obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsCUGSimAssign Load(int id)
        {
            return DBLayer.Load(id);
        }
        public List<clsCUGSimAssign> LoadAll(clsCUGSimAssign obj)
        {
            return DBLayer.LoadAll(obj);
        }
    }
}
