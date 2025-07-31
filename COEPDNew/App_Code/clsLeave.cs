using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsLeave
    {
        DataAccessLayerHelper.clsLeaveData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _LeaveId;
        private int _EmployeeId;
        private string _Employee;
        private int _LeaveTypeId;
        private string _LeaveType;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private string _Notes;
        private string _ApprovedEmployee;
        private int? _ApprovedBy;
        private bool _IsActive;
        private bool _IsDeleted;
        private int _ReportingEmployeeId;
        private string _ReportingEmployee;
        private int _UserId;
        private int _LocationId;
        private string _Location;
        private string _Username;
        private string _ReportingManager;
        private string _EmployeeName;
        private int _DepartmentId;
        private int _IsApproved;

        public int SNo { get => _SNo; set => _SNo = value; }
        public string Keywords { get => _keywords; set => _keywords = value; }
        public int? LeaveId { get => _LeaveId; set => _LeaveId = value; }
        public int EmployeeId { get => _EmployeeId; set => _EmployeeId = value; }
        public string Employee { get => _Employee; set => _Employee = value; }
        public int LeaveTypeId { get => _LeaveTypeId; set => _LeaveTypeId = value; }
        public string LeaveType { get => _LeaveType; set => _LeaveType = value; }
        public DateTime? FromDate { get => _FromDate; set => _FromDate = value; }
        public DateTime? ToDate { get => _ToDate; set => _ToDate = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public string Notes { get => _Notes; set => _Notes = value; }
        public string ApprovedEmployee { get => _ApprovedEmployee; set => _ApprovedEmployee = value; }
        public int? ApprovedBy { get => _ApprovedBy; set => _ApprovedBy = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public int ReportingEmployeeId { get => _ReportingEmployeeId; set => _ReportingEmployeeId = value; }
        public string ReportingEmployee { get => _ReportingEmployee; set => _ReportingEmployee = value; }
        public int UserId { get => _UserId; set => _UserId = value; }
        public int LocationId { get => _LocationId; set => _LocationId = value; }
        public string Location { get => _Location; set => _Location = value; }
        public string Username { get => _Username; set => _Username = value; }
        public string ReportingManager { get => _ReportingManager; set => _ReportingManager = value; }
        public string EmployeeName { get => _EmployeeName; set => _EmployeeName = value; }
        public int DepartmentId { get => _DepartmentId; set => _DepartmentId=value; }
        public int IsApproved { get => _IsApproved; set => _IsApproved=value; }

        public clsLeave()
        {
            DBLayer = new DataAccessLayerHelper.clsLeaveData();
        }

        public void AddUpdate(clsLeave obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsLeave Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsLeave> LoadAll(clsLeave obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

        public clsLeave Loadfew(int id)
        {
            return DBLayer.Loadfew(id);
        }
    }
}
