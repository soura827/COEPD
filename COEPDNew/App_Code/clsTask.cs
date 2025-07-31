using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsTask
    {
        DataAccessLayerHelper.clsTaskData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _TaskId;
        private string _Task;
        private string _Description;
        private int _UserId;
        private string _UserName;
        private int _EmployeeId;
        private string _Employee;
        private int _AssignedEmployeeId;
        private int _PriorityId;
        private string _Priority;
        private int _StatusId;
        private string _Status;
        private int _TaskStatusId;
        private string _TaskStatus;
        private bool? _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private string _ModifiedOn;
        private string _AssignedEmployee;
        private string _color;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private string _ModifiedBy;
        private string _FileUploadPath;
       // private string _PassportSizePhotoImagePath;



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
        public int? TaskId
        {
            get { return _TaskId; }
            set { _TaskId = value; }
        }
        public string Task
        {
            get { return _Task; }
            set { _Task = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
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
        public string AssignedEmployee
        {
            get { return _AssignedEmployee; }
            set { _AssignedEmployee = value; }
        }
        public int AssignedEmployeeId
        {
            get { return _AssignedEmployeeId; }
            set { _AssignedEmployeeId = value; }
        }
        public int PriorityId
        {
            get { return _PriorityId; }
            set { _PriorityId = value; }
        }
        public string Priority
        {
            get { return _Priority; }
            set { _Priority = value; }
        }

        public int StatusId
        {
            get { return _StatusId; }
            set { _StatusId = value; }
        }

        public int TaskStatusId
        {
            get { return _TaskStatusId; }
            set { _TaskStatusId = value; }
        }
        public string TaskStatus
        {
            get { return _TaskStatus; }
            set { _TaskStatus = value; }
        }
        public bool? IsActive
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
        public string ModifiedOn
        {
            get { return _ModifiedOn; }
            set { _ModifiedOn = value; }
        }
        public string color
        {
            get { return _color; }
            set { _color = value; }
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

        public string ModifiedBy
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

        public string Status
        {
            get
            {
                return _Status;
            }

            set
            {
                _Status = value;
            }
        }

        public string FileUploadPath { get => _FileUploadPath; set => _FileUploadPath = value; }
     //   public string PassportSizePhotoImagePath { get => _PassportSizePhotoImagePath; set => _PassportSizePhotoImagePath = value; }

        public clsTask()
        {
            DBLayer = new DataAccessLayerHelper.clsTaskData();
        }
        public void AddUpdate(clsTask obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsTask Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsTask> LoadAll(clsTask obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsTask> LoadAllReports(clsTask obj)
        {
            return DBLayer.LoadAllReports(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public void UpdateStatus(clsTask obj)
        {
            DBLayer.UpdateStatus(obj);
        }
    }
}