using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsCUGSim
    {
        DataAccessLayerHelper.clsCUGSimData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _CUGSimId;
        private string _SimNumber;
        private string _Mobile;
        private bool _IsActivated;
        private DateTime? _ActivationDate;
        private string _TarifPlan;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _CreatedName;
        private string _ModifiedName;
        private bool _IsSimAssigned;
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

        public int? CUGSimId
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

        public string SimNumber
        {
            get
            {
                return _SimNumber;
            }

            set
            {
                _SimNumber = value;
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

        public bool IsActivated
        {
            get
            {
                return _IsActivated;
            }

            set
            {
                _IsActivated = value;
            }
        }

        public DateTime? ActivationDate
        {
            get
            {
                return _ActivationDate;
            }

            set
            {
                _ActivationDate = value;
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

        public bool IsSimAssigned
        {
            get
            {
                return _IsSimAssigned;
            }

            set
            {
                _IsSimAssigned = value;
            }
        }

        public clsCUGSim()
        {
            DBLayer = new DataAccessLayerHelper.clsCUGSimData();
        }
        public void AddUpdate(clsCUGSim obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsCUGSim Load(int id)
        {
            return DBLayer.Load(id);
        }
        public List<clsCUGSim> LoadAll(clsCUGSim obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
    }
}