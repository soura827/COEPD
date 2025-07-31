using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsCOEPDClients
    {

        DataAccessLayerHelper.clsCOEPDClientsData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _COEPDClientsId;
        private string _COEPDClientsName;
        private string _ImagePath;
        private string _ImageThumbPath;
        private string _Website;
        private bool? _IsFeatured;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private int _TotalCOEPDClients;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private string _Fullname;

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

        public int? COEPDClientsId
        {
            get
            {
                return _COEPDClientsId;
            }

            set
            {
                _COEPDClientsId = value;
            }
        }

        public string COEPDClientsName
        {
            get
            {
                return _COEPDClientsName;
            }

            set
            {
                _COEPDClientsName = value;
            }
        }

        public string ImagePath
        {
            get
            {
                return _ImagePath;
            }

            set
            {
                _ImagePath = value;
            }
        }

        public string ImageThumbPath
        {
            get
            {
                return _ImageThumbPath;
            }

            set
            {
                _ImageThumbPath = value;
            }
        }

        public string Website
        {
            get
            {
                return _Website;
            }

            set
            {
                _Website = value;
            }
        }

        public bool? IsFeatured
        {
            get
            {
                return _IsFeatured;
            }

            set
            {
                _IsFeatured = value;
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

        public int TotalCOEPDClients
        {
            get
            {
                return _TotalCOEPDClients;
            }

            set
            {
                _TotalCOEPDClients = value;
            }
        }

        public DateTime? FromDate { get => _FromDate; set => _FromDate = value; }
        public DateTime? ToDate { get => _ToDate; set => _ToDate = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }

        public clsCOEPDClients()
        {
            DBLayer = new DataAccessLayerHelper.clsCOEPDClientsData();
        }
        public void AddUpdate(clsCOEPDClients obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsCOEPDClients Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsCOEPDClients> LoadAll(clsCOEPDClients obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsCOEPDClients> LoadAllClients(clsCOEPDClients obj)
        {
            return DBLayer.LoadAllClients(obj);
        }
        public clsCOEPDClients LoadTotalCOEPDClients(clsCOEPDClients Obj)
        {
            return DBLayer.LoadTotalCOEPDClients(Obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
