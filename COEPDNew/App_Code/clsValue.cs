using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace BusinessLayer
{
    public class clsValue
    {
        DataAccessLayerHelper.clsValueData DBLayer;

        private int _LeadId;
        private int _Offer;
        //private string _Title;
        private string _Name;
        private string _EmailId;
        private string _MobileNo;
        private string _SpecificEnquiry;
        private int _IsActive;
        private int _IsDeleted;
        private string _Location;
        private DateTime _Date;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private int _SNO;
        private DateTime _CreatedOn;
        private String _FullName;

        public int LeadId
        {
            get
            {
                return _LeadId;
            }

            set
            {
                _LeadId = value;
            }
        }

        public int Offer
        {
            get
            {
                return _Offer;
            }

            set
            {
                _Offer = value;
            }
        }



        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public string EmailId
        {
            get
            {
                return _EmailId;
            }

            set
            {
                _EmailId = value;
            }
        }

        public string MobileNo
        {
            get
            {
                return _MobileNo;
            }

            set
            {
                _MobileNo = value;
            }
        }



        public int IsActive
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

        public int IsDeleted
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

        public DateTime Date
        {
            get
            {
                return _Date;
            }

            set
            {
                _Date = value;
            }
        }

        public DateTime? FromDate
        {
            get
            {
                return _FromDate;
            }

            set
            {
                _FromDate = value;
            }
        }

        public DateTime? ToDate
        {
            get
            {
                return _ToDate;
            }

            set
            {
                _ToDate = value;
            }
        }

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

        public string FullName
        {
            get
            {
                return _FullName;
            }

            set
            {
                _FullName = value;
            }
        }

        public string SpecificEnquiry { get => _SpecificEnquiry; set => _SpecificEnquiry = value; }

        public clsValue()
        {
            DBLayer = new DataAccessLayerHelper.clsValueData();
        }
        public void AddUpdate(clsValue obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsValue Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsValue> LoadAll(clsValue obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public int LoadCoepdValueMobileValidation(clsValue obj)
        {
            return DBLayer.LoadCoepdValueMobileValidation(obj);
        }
        public int LoadCoepdValueEmailValidation(clsValue obj)
        {
            return DBLayer.LoadCoepdValueEmailValidation(obj);
        }

    }
}
