using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsEmployeeMapped
    {
        DataAccessLayerHelper.clsEmployeeMappedData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _EmployeeMappedId;
        private int _EmployeeId;
        private int _ParentEmployeeId;
        private bool _IsAssigned;
        private string _Employee;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private int _DesignationId;
        private bool _IsRecordLatest;
        private string _ReportingTeam;
        private string _ReportingManager;
        private string _AssignedBy;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private bool _IsVerticalHead;
        private bool _IsReportingManager;
        private bool _IsReportingTo;
        private int? _ReportingEmployeeMappedId;
        private int _ReportingManagerEmployeeId;
        private int _VerticalHeadEmployeeId;
        private string _CUGMobile;
        private string _OfficeEmail;
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
        public int? EmployeeMappedId
        {
            get { return _EmployeeMappedId; }
            set { _EmployeeMappedId = value; }
        }
        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }
        public int ParentEmployeeId
        {
            get { return _ParentEmployeeId; }
            set { _ParentEmployeeId = value; }
        }

        public int DesignationId
        {
            get { return _DesignationId; }
            set { _DesignationId = value; }
        }
        public bool IsAssigned
        {
            get { return _IsAssigned; }
            set { _IsAssigned = value; }
        }
        public string Employee
        {
            get { return _Employee; }
            set { _Employee = value; }
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

        public bool IsRecordLatest { get => _IsRecordLatest; set => _IsRecordLatest = value; }
        public string ReportingTeam { get => _ReportingTeam; set => _ReportingTeam = value; }
        public string ReportingManager { get => _ReportingManager; set => _ReportingManager = value; }
        public string AssignedBy { get => _AssignedBy; set => _AssignedBy = value; }
        public DateTime? FromDate { get => _FromDate; set => _FromDate = value; }
        public DateTime? ToDate { get => _ToDate; set => _ToDate = value; }
        public bool IsVerticalHead { get => _IsVerticalHead; set => _IsVerticalHead = value; }
        public bool IsReportingManager { get => _IsReportingManager; set => _IsReportingManager = value; }
        public bool IsReportingTo { get => _IsReportingTo; set => _IsReportingTo = value; }
        public int? ReportingEmployeeMappedId { get => _ReportingEmployeeMappedId; set => _ReportingEmployeeMappedId = value; }
        public int ReportingManagerEmployeeId { get => _ReportingManagerEmployeeId; set => _ReportingManagerEmployeeId = value; }
        public int VerticalHeadEmployeeId { get => _VerticalHeadEmployeeId; set => _VerticalHeadEmployeeId = value; }
        public string CUGMobile { get => _CUGMobile; set => _CUGMobile = value; }
        public string OfficeEmail { get => _OfficeEmail; set => _OfficeEmail = value; }

        public clsEmployeeMapped()
        {
            DBLayer = new DataAccessLayerHelper.clsEmployeeMappedData();
        }

        public clsEmployeeMapped Load(int Id)
        {
            return DBLayer.Load(Id);
        }



        public List<clsEmployeeMapped> Hierarchy(clsEmployeeMapped obj)
        {
            return DBLayer.Hierarchy(obj);
        }
        public List<clsEmployeeMapped> UnAssignedList(clsEmployeeMapped obj)
        {
            return DBLayer.UnAssignedList(obj);
        }
        ///////////////////////////////////////////////////////////////////////////////
        public void AddUpdate(clsEmployeeMapped obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public List<clsEmployeeMapped> UnAssignedEmployeeList(clsEmployeeMapped obj)
        {
            return DBLayer.UnAssignedEmployeeList(obj);
        }


        public List<clsEmployeeMapped> ReportingManagerHistoryLoadAll(clsEmployeeMapped obj)
        {
            return DBLayer.ReportingManagerHistoryLoadAll(obj);
        }



        public void AddUpdates(clsEmployeeMapped obj)
        {
            DBLayer.AddUpdates(obj);
        }
        public List<clsEmployeeMapped> LoadAll(clsEmployeeMapped obj)
        {
            return DBLayer.LoadAll(obj);
        }


        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public void ReportingRemove(int Id)
        {
            DBLayer.ReportingRemove(Id);
        }
        public List<clsEmployeeMapped> ReportingLoadAll(clsEmployeeMapped obj)
        {
            return DBLayer.ReportingLoadAll(obj);
        }
    }
}

