using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsDepartment
    {
        DataAccessLayerHelper.clsDepartmentData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _DepartmentId;
        private string _Department;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;

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
        public int? DepartmentId
        {
            get { return _DepartmentId; }
            set { _DepartmentId = value; }
        }
        public string Department
        {
            get { return _Department; }
            set { _Department = value; }
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

        public clsDepartment()
        {
            DBLayer = new DataAccessLayerHelper.clsDepartmentData();
        }
        public void AddUpdate(clsDepartment obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsDepartment Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsDepartment> LoadAll(clsDepartment obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}