using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsKPIEmployeeMapping
    {

        DataAccessLayerHelper.clsKPIEmployeeMappingData DBLayer;
        private int _SNO;
        private int? _KPIEmployeeMappingId;
        private string _KPIName;
        private int _KPIId;
        private int _TargetForMonth;
        private string _CreatedName;
        private string _ModifiedName;
        private int? _CreatedBy;
        private int _ModifiedBy;
        private DateTime _CreatedOn;
        private DateTime? _ModifiedOn;
        private bool _IsActive;
        private bool _IsDeleted;
        private string _Employee;
        private int _EmployeeId;

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

        public int? KPIEmployeeMappingId
        {
            get
            {
                return _KPIEmployeeMappingId;
            }

            set
            {
                _KPIEmployeeMappingId = value;
            }
        }

        public string KPIName
        {
            get
            {
                return _KPIName;
            }

            set
            {
                _KPIName = value;
            }
        }

        public int KPIId
        {
            get
            {
                return _KPIId;
            }

            set
            {
                _KPIId = value;
            }
        }

        public int TargetForMonth
        {
            get
            {
                return _TargetForMonth;
            }

            set
            {
                _TargetForMonth = value;
            }
        }

        public string CreatedName
        {
            get
            {
                return _CreatedName;
            }

            set
            {
                _CreatedName = value;
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

        public clsKPIEmployeeMapping()
        {
            DBLayer = new DataAccessLayerHelper.clsKPIEmployeeMappingData();
        }
        public void AddUpdate(clsKPIEmployeeMapping obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsKPIEmployeeMapping Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public int LoadKPIEmployeeValidation(clsKPIEmployeeMapping obj)
        {
            return DBLayer.LoadKPIEmployeeValidation(obj);
        }
        public List<clsKPIEmployeeMapping> LoadAll(clsKPIEmployeeMapping obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
    }
}

