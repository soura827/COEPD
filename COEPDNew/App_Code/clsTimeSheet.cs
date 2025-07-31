using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsTimeSheet

    {
        DataAccessLayerHelper.clsTimeSheetData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _TimeSheetId;
        private int _EmployeeId;
        private string _Employee;
        private DateTime _Date;
        private DateTime _StartTime;
        private DateTime? _EndTime;
        private string _Note;
        private int _ProjectId;
        private string _Project;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private int? _ClientId;
        private string _Client;

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
        public int? TimeSheetId
        {
            get { return _TimeSheetId; }
            set { _TimeSheetId = value; }
        }
        public int EmployeeId
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
        public DateTime? EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        }

        public int ProjectId
        {
            get { return _ProjectId; }
            set { _ProjectId = value; }
        }
        public string Project
        {
            get { return _Project; }
            set { _Project = value; }
        }
        public string Note
        {
            get { return _Note; }
            set { _Note = value; }
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
        public int? ClientId
        {
            get { return _ClientId; }
            set { _ClientId = value; }
        }
        public string Client
        {
            get { return _Client; }
            set { _Client = value; }
        }
        public clsTimeSheet()
        {
            DBLayer = new DataAccessLayerHelper.clsTimeSheetData();
        }
        public void AddUpdate(clsTimeSheet obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsTimeSheet Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsTimeSheet> LoadAll(clsTimeSheet obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public List<clsTimeSheet> LoadAllReports(clsTimeSheet obj)
        {
            return DBLayer.LoadAllReports(obj);
        }
    }
}

