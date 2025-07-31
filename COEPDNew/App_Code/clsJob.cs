using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsJob
    {
        DataAccessLayerHelper.clsJobData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _JobId;
        private int _JobCategoryId;
        private string _JobCategory;
        private int _JobDomainId;
        private string _JobDomain;
        private string _JobTitle;
        private string _Location;
        private DateTime? _JobDate;
        private string _Company;
        private string _Experience;
        private string _Phone;
        private string _Email;
        private string _Weblink;
        private string _FullDescription;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private string _FullName;
        
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
        public int? JobId
        {
            get { return _JobId; }
            set { _JobId = value; }
        }
        public int JobCategoryId
        {
            get { return _JobCategoryId; }
            set { _JobCategoryId = value; }
        }
        public string JobCategory
        {
            get { return _JobCategory; }
            set { _JobCategory = value; }
        }

        public int JobDomainId
        {
            get { return _JobDomainId; }
            set { _JobDomainId = value; }
        }
        public string JobDomain
        {
            get { return _JobDomain; }
            set { _JobDomain = value; }
        }
        public string JobTitle
        {
            get { return _JobTitle; }
            set { _JobTitle = value; }
        }
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        public DateTime? JobDate
        {
            get { return _JobDate; }
            set { _JobDate = value; }
        }
        public string Company
        {
            get { return _Company; }
            set { _Company = value; }
        }

        public string Experience
        {
            get { return _Experience; }
            set { _Experience = value; }
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

        public string Weblink
        {
            get { return _Weblink; }
            set { _Weblink = value; }
        }
        public string FullDescription
        {
            get { return _FullDescription; }
            set { _FullDescription = value; }
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
        public DateTime? FromDate
        {
            get { return _FromDate; }
            set { _FromDate = value; }
        }
        public DateTime? ToDate
        {
            get { return _ToDate; }
            set { _ToDate = value; }
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

        public clsJob()
        {
            DBLayer = new DataAccessLayerHelper.clsJobData();
        }
        public void AddUpdate(clsJob obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsJob Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsJob> LoadAll(clsJob obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsJob> LoadAllReports(clsJob obj)
        {
            return DBLayer.LoadAllReports(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public List<clsJob> LoadLatestJobs(clsJob obj)
        {
            return DBLayer.LoadLatestJobs(obj);
        }
    }
}