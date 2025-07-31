using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsEmployeeDocumentAssign
    {
        DataAccessLayerHelper.clsEmployeeDocumentAssignData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _EmployeeDocumentAssignId;
        private int _EmployeeDocumentId;
        private string _DocumentName;
        private string _EmployeeDocument;
        private int _EmployeeId;
        public string Employee { get; set; }
        private int _AssignedEmployeeId;
        public string AssignedEmployee { get; set; }
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private string _EmployeeDocumentPath;
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
        public int? EmployeeDocumentAssignId
        {
            get { return _EmployeeDocumentAssignId; }
            set { _EmployeeDocumentAssignId = value; }
        }

        public int EmployeeDocumentId
        {
            get { return _EmployeeDocumentId; }
            set { _EmployeeDocumentId = value; }
        }

        public int AssignedEmployeeId
        {
            get { return _AssignedEmployeeId; }
            set { _AssignedEmployeeId = value; }
        }

        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
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
        public string DocumentName
        {
            get { return _DocumentName; }
            set { _DocumentName = value; }
        }
        public string EmployeeDocumentPath
        {
            get { return _EmployeeDocumentPath; }
            set { _EmployeeDocumentPath = value; }
        }

        public string EmployeeDocument { get => _EmployeeDocument; set => _EmployeeDocument = value; }

        public clsEmployeeDocumentAssign()
        {
            DBLayer = new DataAccessLayerHelper.clsEmployeeDocumentAssignData();
        }
        public void AddUpdate(clsEmployeeDocumentAssign obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsEmployeeDocumentAssign Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsEmployeeDocumentAssign> LoadAll(clsEmployeeDocumentAssign obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsEmployeeDocumentAssign> LoadAllAssigned(clsEmployeeDocumentAssign obj)
        {
            return DBLayer.LoadAllAssigned(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}