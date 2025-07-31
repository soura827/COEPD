using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsEmpClientAccess
    {
        DataAccessLayerHelper.clsEmpClientAccessData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _ClientAccessId;
        private int _EmployeeId;
        private int _ClientId;
        private string _Client;
        private int _ProjectId;
        private string _Project;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;

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

        public int? ClientAccessId
        {
            get { return _ClientAccessId; }
            set { _ClientAccessId = value; }
        }

        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }

        public int ClientId
        {
            get { return _ClientId; }
            set { _ClientId = value; }
        }

        public string Client
        {
            get { return _Client; }
            set { _Client = value; }
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
        public int CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }

        public clsEmpClientAccess()
        {
            DBLayer = new DataAccessLayerHelper.clsEmpClientAccessData();
        }

        public void AddUpdate(clsEmpClientAccess obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsEmpClientAccess Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsEmpClientAccess> LoadAll(clsEmpClientAccess obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}