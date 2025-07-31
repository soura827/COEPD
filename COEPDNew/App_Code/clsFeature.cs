//This Class  is used to Set and Get the values of Employee Fields From Business Layer and Data Acess Layer
using DataAccessLayerHelper;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsFeature
    {
        clsFeatureData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _FeatureId;
        private int _ModuleId;
        private string _Module;
        private string _Feature;
        private string _PageName;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private string _Username;
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

        public int? FeatureId
        {
            get { return _FeatureId; }
            set { _FeatureId = value; }
        }

        public string Feature
        {
            get { return _Feature; }
            set { _Feature = value; }
        }

        public int ModuleId
        {
            get { return _ModuleId; }
            set { _ModuleId = value; }
        }

        public string Module
        {
            get { return _Module; }
            set { _Module = value; }
        }

        public string PageName
        {
            get { return _PageName; }
            set { _PageName = value; }
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

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }

        public clsFeature()
        {
            DBLayer = new DataAccessLayerHelper.clsFeatureData();
        }

        public void AddUpdate(clsFeature obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsFeature Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsFeature> LoadAll(clsFeature obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsFeature> LoadAllAvilable(clsFeature obj)
        {
            return DBLayer.LoadAllAvilable(obj);
        }
        //This remove method is not used now.
        //public void Remove(int Id)
        //{
        //    DBLayer.Remove(Id);
        //}
    }
}