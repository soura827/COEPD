using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsSupport
    {
        DataAccessLayerHelper.clsSupportData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _SupportId;
        private int _SupportTypeId;
        private string _SupportType;
        private string _Subject;
        private string _Description;
        private int _EmployeeId;
        private string _Employee;
        private int _PriorityId;
        private string _Priority;
        private int _StatusId;
        private string _Status;
        private bool? _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private string _ModifiedBy;
        private int _ModifiedBy1;
        private string _color;
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
        public int? SupportId
        {
            get { return _SupportId; }
            set { _SupportId = value; }
        }
        public string Subject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public int SupportTypeId
        {
            get { return _SupportTypeId; }
            set { _SupportTypeId = value; }
        }
        public string SupportType
        {
            get { return _SupportType; }
            set { _SupportType = value; }
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

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
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
        public string color
        {
            get { return _color; }
            set { _color = value; }
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

        public int ModifiedBy1
        {
            get
            {
                return _ModifiedBy1;
            }

            set
            {
                _ModifiedBy1 = value;
            }
        }

        public DateTime? ModifiedOn
        {
            get
            {
                return _ModifiedOn;
            }

            set
            {
                _ModifiedOn = value;
            }
        }

        public clsSupport()
        {
            DBLayer = new DataAccessLayerHelper.clsSupportData();
        }
        public void AddUpdate(clsSupport obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsSupport Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsSupport> LoadAll(clsSupport obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsSupport> LoadAllList(clsSupport obj)
        {
            return DBLayer.LoadAllList(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

        public void UpdateStatus(clsSupport obj)
        {
            DBLayer.UpdateStatus(obj);
        }
    }
}