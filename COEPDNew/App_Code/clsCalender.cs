using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsCalender
    {
        DataAccessLayerHelper.clsCalenderData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _CalenderId;
        private string _Calender;
        private DateTime? _StartDate;
        private int _BatchTypeId;
        private string _BatchType;
        private int _CourseId;
        private string _Course;
        private int _LocationId;
        private string _Location;
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

        public int? CalenderId
        {
            get { return _CalenderId; }
            set { _CalenderId = value; }
        }
        public string Calender
        {
            get { return _Calender; }
            set { _Calender = value; }
        }
        public DateTime? StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        public int BatchTypeId
        {
            get { return _BatchTypeId; }
            set { _BatchTypeId = value; }
        }
        public string BatchType
        {
            get { return _BatchType; }
            set { _BatchType = value; }
        }
        public int CourseId
        {
            get { return _CourseId; }
            set { _CourseId = value; }
        }
        public string Course
        {
            get { return _Course; }
            set { _Course = value; }
        }
        public int LocationId
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
        public clsCalender()
        {
            DBLayer = new DataAccessLayerHelper.clsCalenderData();
        }
        public void AddUpdate(clsCalender obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsCalender Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsCalender> LoadAll(clsCalender obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public List<clsCalender> LoadAllReports(clsCalender obj)
        {
            return DBLayer.LoadAllReports(obj);
        }
    }
}