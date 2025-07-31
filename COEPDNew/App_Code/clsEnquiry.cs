using System;
using System.Collections.Generic;


namespace BusinessLayer
{
    public class clsEnquiry
    {

        DataAccessLayerHelper.clsEnquiryData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _EnquiryId;
        private string _Name;
        private string _Email;
        private string _Phone;
        private string _City;
        private string _State;
        private int? _CourseId;
        private string _Course;
        private string _CourseName;
        private string _Message;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private int _PlanId;
        private string _TimeRequired;
        private DateTime? _FromDate;
        private DateTime? _ToDate;

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
        public int? EnquiryId
        {
            get { return _EnquiryId; }
            set { _EnquiryId = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        public string State
        {
            get { return _State; }
            set { _State = value; }
        }
        public string CourseName
        {
            get { return _CourseName; }
            set { _CourseName = value; }
        }

        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
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
        public DateTime ModifiedOn
        {
            get { return _ModifiedOn; }
            set { _ModifiedOn = value; }
        }
        public int PlanId
        {
            get
            {
                return _PlanId;
            }


            set
            {
                _PlanId = value;
            }
        }

        public string TimeRequired
        {
            get
            {
                return _TimeRequired;
            }

            set
            {
                _TimeRequired = value;
            }
        }

        public int? CourseId
        {
            get
            {
                return _CourseId;
            }

            set
            {
                _CourseId = value;
            }
        }

        public string Course
        {
            get
            {
                return _Course;
            }

            set
            {
                _Course = value;
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

        public clsEnquiry()
        {
            DBLayer = new DataAccessLayerHelper.clsEnquiryData();
        }

        public void AddUpdate(clsEnquiry obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsEnquiry Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsEnquiry> LoadAll(clsEnquiry obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public List<clsEnquiry> LoadAllReports(clsEnquiry obj)
        {
            return DBLayer.LoadAllReports(obj);
        }
        public int LoadEnquiryValidation(clsEnquiry obj)
        {
            return DBLayer.LoadEnquiryValidation(obj);
        }
    }
}