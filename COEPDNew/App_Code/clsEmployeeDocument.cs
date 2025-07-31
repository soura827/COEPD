using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsEmployeeDocument
    {
        DataAccessLayerHelper.clsEmployeeDocumentData DBLayer;
        private int _SNo;
        private string _keywords;
        private int _EmployeeId;
        private string _Employee;
        private int _EmployeeDocumentTypeId;
        private string _EmployeeDocumentType;
        private int? _EmployeeDocumentId;
        private string _EmployeeDocument;
        private string _EmployeeDocumentPath;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;

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
        public int EmployeeDocumentTypeId
        {
            get { return _EmployeeDocumentTypeId; }
            set { _EmployeeDocumentTypeId = value; }
        }
        public string EmployeeDocumentType
        {
            get { return _EmployeeDocumentType; }
            set { _EmployeeDocumentType = value; }
        }
        public int? EmployeeDocumentId
        {
            get { return _EmployeeDocumentId; }
            set { _EmployeeDocumentId = value; }
        }
        public string EmployeeDocument
        {
            get { return _EmployeeDocument; }
            set { _EmployeeDocument = value; }
        }
        public string EmployeeDocumentPath
        {
            get { return _EmployeeDocumentPath; }
            set { _EmployeeDocumentPath = value; }
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


        public clsEmployeeDocument()
        {
            DBLayer = new DataAccessLayerHelper.clsEmployeeDocumentData();
        }
        public void AddUpdate(clsEmployeeDocument obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsEmployeeDocument Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsEmployeeDocument> LoadAll(clsEmployeeDocument obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}