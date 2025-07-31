using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsLocation
    {
        DataAccessLayerHelper.clsLocationData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _LocationId;
        private string _Location;
        private string _LocationDescription;
        private string _Fullname;
        private string _Employee;
        private string _Modifiedname;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _GoogleReviewLink;

        public int SNo
        {
            get { return _SNo; }
            set { _SNo = value; }
        }
        public string keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }
        public int? LocationId
        {
            get { return _LocationId; }
            set { _LocationId = value; }
        }
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }
        public bool IsActive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
        }
        public bool IsDeleted
        {
            get { return _IsDeleted; }
            set { _IsDeleted = value; }
        }
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { _CreatedOn = value; }
        }
        public int? CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }
        public DateTime? ModifiedOn
        {
            get { return _ModifiedOn; }
            set { _ModifiedOn = value; }
        }

        public string LocationDescription
        {
            get
            {
                return _LocationDescription;
            }

            set
            {
                _LocationDescription = value;
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

        public string Modifiedname
        {
            get
            {
                return _Modifiedname;
            }

            set
            {
                _Modifiedname = value;
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

        public string GoogleReviewLink
        {
            get
            {
                return _GoogleReviewLink;
            }

            set
            {
                _GoogleReviewLink = value;
            }
        }

        public clsLocation()
        {
            DBLayer = new DataAccessLayerHelper.clsLocationData();
        }
        public void AddUpdate(clsLocation obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsLocation Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsLocation> LoadAll(clsLocation obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}