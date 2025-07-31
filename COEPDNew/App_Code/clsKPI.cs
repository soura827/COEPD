using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsKPI
    {
        DataAccessLayerHelper.clsKPIData DBLayer;
        private int _SNO;
        private int? _KPIId;
        private string _KPIName;
        private int _KPIApplicableToId;
        private string _CreatedName;
        private string _ModifiedName;
        private int? _CreatedBy;
        private int _ModifiedBy;
        private DateTime _CreatedOn;
        private DateTime? _ModifiedOn;
        private bool _IsActive;
        private bool _IsDeleted;
        private string _KPIApplicableTo;
        private int _MonthlyTarget;

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

        public int? KPIId
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

        public int KPIApplicableToId
        {
            get
            {
                return _KPIApplicableToId;
            }

            set
            {
                _KPIApplicableToId = value;
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

        public string KPIApplicableTo
        {
            get
            {
                return _KPIApplicableTo;
            }

            set
            {
                _KPIApplicableTo = value;
            }
        }

        public int MonthlyTarget { get => _MonthlyTarget; set => _MonthlyTarget = value; }

        public clsKPI()
        {
            DBLayer = new DataAccessLayerHelper.clsKPIData();
        }
        public void AddUpdate(clsKPI obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsKPI Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public int LoadKPIValidation(clsKPI obj)
        {
            return DBLayer.LoadKPIValidation(obj);
        }
        public List<clsKPI> LoadAll(clsKPI obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
        public List<clsKPI> LoadAllKPIApplicableTo(clsKPI obj)
        {
            return DBLayer.LoadAllKPIApplicableTo(obj);
        }
        public int RoleNameValidation(clsKPI obj)
        {
            return DBLayer.RoleNameValidation(obj);
        }

        public List<clsKPI> KPINames(clsKPI obj)
        {
            return DBLayer.KPINames(obj);
        }
      
    }
}
