using System;
using System.Collections.Generic;


namespace BusinessLayer
{
    public class clsAward
    {
        DataAccessLayerHelper.ClsAwardData DBLayer;

        private int? _AwardId;
        private string _AwardName;
        private string _Description;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _CreatedByName;
        private string _ModifiedByName;
        private int _sno;

        public int? AwardId
        {
            get
            {
                return _AwardId;
            }

            set
            {
                _AwardId = value;
            }
        }

        public string AwardName
        {
            get
            {
                return _AwardName;
            }

            set
            {
                _AwardName = value;
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
        public clsAward()
        {
            DBLayer = new DataAccessLayerHelper.ClsAwardData();
        }

        public void AddUpdate(clsAward obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsAward Load(int id)
        {
            return DBLayer.Load(id);
        }

        public List<clsAward> LoadAll(clsAward obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
        public int LoadAwardValidation(clsAward obj)
        {
            return DBLayer.LoadAwardValidation(obj);
        }

    }
}
