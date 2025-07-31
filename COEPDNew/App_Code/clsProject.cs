using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsProject
    {
        DataAccessLayerHelper.clsProjectData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _ProjectId;
        private int _ClientId;
        private string _Project;
        private string _Client;
        private string _Description;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private int _EmployeeId;

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
        public int? ProjectId
        {
            get { return _ProjectId; }
            set { _ProjectId = value; }
        }
        public int ClientId
        {
            get { return _ClientId; }
            set { _ClientId = value; }
        }
        public string Project
        {
            get { return _Project; }
            set { _Project = value; }
        }
        public string Client
        {
            get { return _Client; }
            set { _Client = value; }
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
        public DateTime ModifiedOn
        {
            get { return _ModifiedOn; }
            set { _ModifiedOn = value; }
        }
        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }

        public clsProject()
        {
            DBLayer = new DataAccessLayerHelper.clsProjectData();
        }
        public void AddUpdate(clsProject obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsProject Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsProject> LoadAll(clsProject obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

    }
}

