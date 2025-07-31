using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsJobCategory
    {
        DataAccessLayerHelper.clsJobCategoryData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _JobCategoryId;
        private string _JobCategory;
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
        public int? JobCategoryId
        {
            get { return _JobCategoryId; }
            set { _JobCategoryId = value; }
        }
        public string JobCategory
        {
            get { return _JobCategory; }
            set { _JobCategory = value; }
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

        public clsJobCategory()
        {
            DBLayer = new DataAccessLayerHelper.clsJobCategoryData();
        }
        public void AddUpdate(clsJobCategory obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsJobCategory Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsJobCategory> LoadAll(clsJobCategory obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}