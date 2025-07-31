using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsCounselling
    {
        DataAccessLayerHelper.clsCounsellingData DBLayer;


        private int _SNo;
        private string _keywords;
        private int? _CounsellingId;
        private string _Counselling;
        private int? _CounsellingStatusId;
        private int? _LeadId;
        private DateTime _Date;
        private DateTime _StartTime;
        private DateTime _EndTime;
        private string _PrimaryMobile;
        private string _SecondaryMobile;
        private string _PrimaryEmail;
        private string _SecondaryEmail;
        private string _Address;
        private string _Comments;
        private string _Remarks;
        private int? _EmployeeId;
        private string _Employee;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
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
        public int? CounsellingId
        {
            get { return _CounsellingId; }
            set { _CounsellingId = value; }
        }

        public string Counselling
        {
            get { return _Counselling; }
            set { _Counselling = value; }
        }

        public int? CounsellingStatusId
        {
            get { return _CounsellingStatusId; }
            set { _CounsellingStatusId = value; }
        }
        public string PrimaryMobile
        {
            get { return _PrimaryMobile; }
            set { _PrimaryMobile = value; }
        }
        public string SecondaryMobile
        {
            get { return _SecondaryMobile; }
            set { _SecondaryMobile = value; }
        }
        public string PrimaryEmail
        {
            get { return _PrimaryEmail; }
            set { _PrimaryEmail = value; }
        }
        public string SecondaryEmail
        {
            get { return _SecondaryEmail; }
            set { _SecondaryEmail = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Comments
        {
            get { return _Comments; }
            set { _Comments = value; }
        }
        public string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
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
        public int? LeadId
        {
            get { return _LeadId; }
            set { _LeadId = value; }
        }
        public int? EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }
        public string Employee
        {
            get { return _Employee; }
            set { _Employee = value; }
        }

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public DateTime StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }

        public DateTime EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
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
        public clsCounselling()
        {

            DBLayer = new DataAccessLayerHelper.clsCounsellingData();
        }
        public void AddUpdate(clsCounselling obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsCounselling Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsCounselling> LoadAll(clsCounselling obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public List<clsCounselling> LoadAllReports(clsCounselling obj)
        {
            return DBLayer.LoadAllReports(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

    }
}