using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsCareer
    {
        DataAccessLayerHelper.clsCareerData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _CareerId;
        private string _EmailId;
        private string _Mobile;
        private string _JobTitle;
        private string _JobDescription;
        private string _KeySkills;
        private string _Experience;
        private DateTime _Date;
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
        public int? CareerId
        {
            get { return _CareerId; }
            set { _CareerId = value; }
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
        public string JobTitle
        {
            get { return _JobTitle; }
            set { _JobTitle = value; }
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

        public string Experience
        {
            get { return _Experience; }
            set { _Experience = value; }
        }
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
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

        public clsCareer()
        {
            DBLayer = new DataAccessLayerHelper.clsCareerData();
        }
        public void AddUpdate(clsCareer obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsCareer Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsCareer> LoadAll(clsCareer obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public void AddUpdate1(clsCareer obj)
        {
            DBLayer.AddUpdate(obj);
        }
    }
}