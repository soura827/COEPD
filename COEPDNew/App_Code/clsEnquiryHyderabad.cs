using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer;
namespace BusinessLayer
{
    public class clsEnquiryHyderabad
    {

        DataAccessLayerHelper.clsEnquiryDataHyderabad DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _EnquiryId;
        private string _Name;
        private string _Email1;
        private string _Email2;
        private string _Phone1;
        private string _Phone2;
        private string _City;
        private string _State;
        private int? _CourseId;
        private string _Course;
        private string _CourseName;
        private string _Message1;
        private string _Message2;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private int _PlanId;
        private string _TimeRequired;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private string _Domain;
        private string _Experience;
        private string _Qualification;
        private bool _SMS;
        private bool _Friend;
        private bool _Email;
        private bool _Website;
        private bool _SocialNetworking;
        private bool _WalkIn;
        private bool _Agree;
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
        public string Phone1
        {
            get { return _Phone1; }
            set { _Phone1 = value; }
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

        public string Email2 { get => _Email2; set => _Email2 = value; }
        public string Email1 { get => _Email1; set => _Email1 = value; }
        public string Phone2 { get => _Phone2; set => _Phone2 = value; }
        public string Message1 { get => _Message1; set => _Message1 = value; }
        public string Message2 { get => _Message2; set => _Message2 = value; }
        public string Domain { get => _Domain; set => _Domain = value; }
        public string Experience { get => _Experience; set => _Experience = value; }
        public string Qualification { get => _Qualification; set => _Qualification = value; }
        public bool SMS { get => _SMS; set => _SMS = value; }
        public bool Friend { get => _Friend; set => _Friend = value; }
        public bool Email { get => _Email; set => _Email = value; }
        public bool Website { get => _Website; set => _Website = value; }
        public bool SocialNetworking { get => _SocialNetworking; set => _SocialNetworking = value; }
        public bool WalkIn { get => _WalkIn; set => _WalkIn = value; }
        public bool Agree { get => _Agree; set => _Agree = value; }

        public clsEnquiryHyderabad()
        {
            DBLayer = new DataAccessLayerHelper.clsEnquiryDataHyderabad();
        }

        public void AddUpdate(clsEnquiryHyderabad obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsEnquiryHyderabad Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsEnquiryHyderabad> LoadAll(clsEnquiryHyderabad obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public List<clsEnquiryHyderabad> LoadAllReports(clsEnquiryHyderabad obj)
        {
            return DBLayer.LoadAllReports(obj);
        }
        public int LoadEnquiryValidation(clsEnquiryHyderabad obj)
        {
            return DBLayer.LoadEnquiryValidation(obj);
        }
    }

}