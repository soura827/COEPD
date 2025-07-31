using System;
using System.Collections.Generic;
//using System.Data.SqlTypes;

namespace BusinessLayer
{
    public class clsJobRequirement
    {
        DataAccessLayerHelper.clsJobRequirementData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _JobRequirementId;
        private string _CompanyName;
        private string _ContactPerson;
        private string _EmailId;
        private string _Mobile;
        private string _JobDescription;
        private string _KeySkills;
        private string _AvailableTimings;
        private string _Location;
        private string _JobRole;
        private string _YearsOfExp;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private string _ExpiryDate;

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
        public int? JobRequirementId
        {
            get { return _JobRequirementId; }
            set { _JobRequirementId = value; }
        }
        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }
        public string ContactPerson
        {
            get { return _ContactPerson; }
            set { _ContactPerson = value; }
        }
        public string EmailId
        {
            get { return _EmailId; }
            set { _EmailId = value; }
        }
        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }
        public string JobDescription
        {
            get { return _JobDescription; }
            set { _JobDescription = value; }
        }
        public string KeySkills
        {
            get { return _KeySkills; }
            set { _KeySkills = value; }
        }
        public string AvailableTimings
        {
            get { return _AvailableTimings; }
            set { _AvailableTimings = value; }
        }
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }
        public string JobRole
        {
            get { return _JobRole; }
            set { _JobRole = value; }
        }
        public string YearsOfExp
        {
            get { return _YearsOfExp; }
            set { _YearsOfExp = value; }
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

        public string ExpiryDate
        {
            get { return _ExpiryDate; }
            set { _ExpiryDate = value; }
        }

        public clsJobRequirement()
        {
            DBLayer = new DataAccessLayerHelper.clsJobRequirementData();
        }
        public void AddUpdate(clsJobRequirement obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsJobRequirement Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsJobRequirement> LoadAll(clsJobRequirement obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}