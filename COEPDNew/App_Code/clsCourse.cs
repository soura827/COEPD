using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsCourse
    {
        DataAccessLayerHelper.clsCourseData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _CourseId;
        private string _Course;
        private string _Description;
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
        public int? CourseId
        {
            get { return _CourseId; }
            set { _CourseId = value; }
        }
        public string Course
        {
            get { return _Course; }
            set { _Course = value; }
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

        public clsCourse()
        {
            DBLayer = new DataAccessLayerHelper.clsCourseData();
        }
        public void AddUpdate(clsCourse obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsCourse Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsCourse> LoadAll(clsCourse obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}