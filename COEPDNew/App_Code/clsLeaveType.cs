using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsLeaveType
    {
        DataAccessLayerHelper.clsLeaveTypeData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _LeaveTypeId;
        private string _LeaveType;
        private string _Description;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private string _Username;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
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
        public int? LeaveTypeId
        {
            get { return _LeaveTypeId; }
            set { _LeaveTypeId = value; }
        }
        public string LeaveType
        {
            get { return _LeaveType; }
            set { _LeaveType = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
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

        public clsLeaveType()
        {
            DBLayer = new DataAccessLayerHelper.clsLeaveTypeData();
        }

        public void AddUpdate(clsLeaveType obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsLeaveType Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsLeaveType> LoadAll(clsLeaveType obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
