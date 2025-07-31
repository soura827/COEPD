//This Class  is used to Set and Get the values of Employee Fields From Business Layer and Data Acess Layer
using DataAccessLayerHelper;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsFeatureAccess
    {
        clsFeatureAccessData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _FeatureAccessId;
        private int _EmployeeId;
        private int _FeatureId;
        private string _Feature;
        private int _ModuleId;
        private string _Module;
        private string _PageName;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private string _SendAssignedFeaturesToEmployee;
        private string _Employee;
        private int _LocationId;
        private string _Location;
        private string _Designation;
        private int _DesignationId;

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

        public int? FeatureAccessId
        {
            get { return _FeatureAccessId; }
            set { _FeatureAccessId = value; }
        }

        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }

        public int FeatureId
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

        public string SendAssignedFeaturesToEmployee
        {
            get { return _SendAssignedFeaturesToEmployee; }
            set { _SendAssignedFeaturesToEmployee = value; }
        }

        public string Employee { get => _Employee; set => _Employee = value; }
        public int LocationId { get => _LocationId; set => _LocationId = value; }
        public string Location { get => _Location; set => _Location = value; }
        public string Designation { get => _Designation; set => _Designation = value; }
        public int DesignationId { get => _DesignationId; set => _DesignationId = value; }

        public clsFeatureAccess()
        {
            DBLayer = new DataAccessLayerHelper.clsFeatureAccessData();
        }

        public void AddUpdate(clsFeatureAccess obj)
        {
            DBLayer.AddUpdate(obj);
        }

        //This Method is not used now.
        //public clsFeatureAccess Load(int Id)
        //{
        //    return DBLayer.Load(Id);
        //}

        public List<clsFeatureAccess> LoadAll(clsFeatureAccess obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

        public int FeaturePageValidation(clsFeatureAccess obj)
        {
            return DBLayer.FeaturePageValidation(obj);
        }

        public clsFeatureAccess LoadEmployeeAssignedFeatures(int EmployeeId)
        {
            return DBLayer.LoadEmployeeAssignedFeatures(EmployeeId);
        }
    }
}