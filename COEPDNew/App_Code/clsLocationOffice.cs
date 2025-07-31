using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsLocationOffice
    {
        DataAccessLayerHelper.clsLocationOfficeData DBLayer;

        private int _Sno;
        private string _Keywords;
        private int? _LocationOfficeId;
        private int _LocationId;
        private string _LocationOffice;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime _ModifiedOn;
        private int _ModifiedBy;
        private string _Location;
        private string _Fullname;
        public int Sno
        {
            get
            {
                return _Sno;
            }

            set
            {
                _Sno = value;
            }
        }

        public string Keywords
        {
            get
            {
                return _Keywords;
            }

            set
            {
                _Keywords = value;
            }
        }

        public int? LocationOfficeId
        {
            get
            {
                return _LocationOfficeId;
            }

            set
            {
                _LocationOfficeId = value;
            }
        }
        public int LocationId
        {
            get
            {
                return _LocationId;
            }

            set
            {
                _LocationId = value;
            }
        }
        public string LocationOffice
        {
            get
            {
                return _LocationOffice;
            }

            set
            {
                _LocationOffice = value;
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

        public DateTime ModifiedOn
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

        public string Location
        {
            get
            {
                return _Location;
            }

            set
            {
                _Location = value;
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

        public clsLocationOffice()
        {
            DBLayer = new DataAccessLayerHelper.clsLocationOfficeData();
        }
        public void AddUpdate(clsLocationOffice obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsLocationOffice Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsLocationOffice> LoadAll(clsLocationOffice obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
