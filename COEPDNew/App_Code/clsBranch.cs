using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsBranch
    {
        DataAccessLayerHelper.clsBranchData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _BranchId;
        private int _LocationId;
        private string _Location;
        private string _Code;
        private string _Branch;
        private string _Address1;
        private string _Address2;
        private string _City;
        private string _StateName;
        private string _Country;
        private string _Zipcode;
        private string _Mobile;
        private string _Email;
        private string _Langitude;
        private string _Latitude;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private String _Phone;
        private String _Modifiedname;
        private string _Fullname;
        private string _Employee;


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
        public int? BranchId
        {
            get { return _BranchId; }
            set { _BranchId = value; }
        }
        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }
        public string Branch
        {
            get { return _Branch; }
            set { _Branch = value; }
        }
        public string Address1
        {
            get { return _Address1; }
            set { _Address1 = value; }
        }
        public string Address2
        {
            get { return _Address2; }
            set { _Address2 = value; }
        }
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        public string StateName
        {
            get { return _StateName; }
            set { _StateName = value; }
        }
        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }
        public string Zipcode
        {
            get { return _Zipcode; }
            set { _Zipcode = value; }
        }
        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string Langitude
        {
            get { return _Langitude; }
            set { _Langitude = value; }
        }
        public string Latitude
        {
            get { return _Latitude; }
            set { _Latitude = value; }
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

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
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

        public clsBranch()
        {
            DBLayer = new DataAccessLayerHelper.clsBranchData();
        }
        public void AddUpdate(clsBranch obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsBranch Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsBranch> LoadAll(clsBranch obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}