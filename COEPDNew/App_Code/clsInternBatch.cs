using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsInternBatch
    {
        DataAccessLayerHelper.clsInternBatchData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _InternBatchId;
        private string _InternBatch;
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
        private int _StatusId;
        private int? _EmployeeId;
        private string _Employee;
        private int? _BatchTimeId;
        private DateTime _StartTime;
        private DateTime _EndTime;

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

        public int? InternBatchId
        {
            get { return _InternBatchId; }
            set { _InternBatchId = value; }
        }
        public string InternBatch
        {
            get { return _InternBatch; }
            set { _InternBatch = value; }
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
        public int StatusId
        {
            get { return _StatusId; }
            set { _StatusId = value; }
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
        public int? BatchTimeId
        {
            get { return _BatchTimeId; }
            set { _BatchTimeId = value; }
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
        public clsInternBatch()
        {
            DBLayer = new DataAccessLayerHelper.clsInternBatchData();
        }
        public void AddUpdate(clsInternBatch obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsInternBatch Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsInternBatch> LoadAll(clsInternBatch obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        //public clsInternBatch LoadParticipantByBatch(int Id)
        //{
        //    return DBLayer.LoadParticipantByBatch(Id);
        //}
    }
}