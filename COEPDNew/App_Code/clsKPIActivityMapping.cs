using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsKPIActivityMapping
    {
        DataAccessLayerHelper.clsKPIActivityMappingData DBLayer;
        private int _SNO;
        private int? _KPIActivityMappingId;
        private string _KPIName;
        private int _KPIId;
        private int _ActivityId;
        private float _ValueAlloted;
        private string _Activity;
        private string _CreatedName;
        private string _ModifiedName;
        private int? _CreatedBy;
        private int _ModifiedBy;
        private DateTime _CreatedOn;
        private DateTime? _ModifiedOn;
        private bool _IsActive;
        private bool _IsDeleted;
        private string _Employee;
        private int _ActivityCategoryId;
        private int _ActivitySubCategoryId;

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

        public int? KPIActivityMappingId
        {
            get
            {
                return _KPIActivityMappingId;
            }

            set
            {
                _KPIActivityMappingId = value;
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

        public float ValueAlloted
        {
            get
            {
                return _ValueAlloted;
            }

            set
            {
                _ValueAlloted = value;
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

        public clsKPIActivityMapping()
        {
            DBLayer = new DataAccessLayerHelper.clsKPIActivityMappingData();
        }
        public void AddUpdate(clsKPIActivityMapping obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsKPIActivityMapping Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public int LoadKPIActivityValidation(clsKPIActivityMapping obj)
        {
            return DBLayer.LoadKPIActivityValidation(obj);
        }
        public List<clsKPIActivityMapping> LoadAll(clsKPIActivityMapping obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
    }
}
