using System;
using System.Collections.Generic;

namespace BusinessLayer
{

    public class clsService
    {
        DataAccessLayerHelper.clsServiceData DBLayer;
        private int? _ServiceId;
        private string _ServiceName;
        private int? _Fees;
        private string _Description;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _CreatedByName;
        private string _ModifiedByName;
        private int _sno;

        public int? ServiceId
        {
            get
            {
                return _ServiceId;
            }

            set
            {
                _ServiceId = value;
            }
        }

        public string ServiceName
        {
            get
            {
                return _ServiceName;
            }

            set
            {
                _ServiceName = value;
            }
        }

        public int? Fees
        {
            get
            {
                return _Fees;
            }

            set
            {
                _Fees = value;
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

        public string CreatedByName
        {
            get
            {
                return _CreatedByName;
            }

            set
            {
                _CreatedByName = value;
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

        public int Sno
        {
            get
            {
                return _sno;
            }

            set
            {
                _sno = value;
            }
        }
        public clsService()
        {
            DBLayer = new DataAccessLayerHelper.clsServiceData();
        }

        public void AddUpdate(clsService obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsService Load(int id)
        {
            return DBLayer.Load(id);
        }

        public List<clsService> LoadAll(clsService obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
        public int LoadServiceValidation(clsService obj)
        {
            return DBLayer.LoadServiceValidation(obj);
        }

    }
}

