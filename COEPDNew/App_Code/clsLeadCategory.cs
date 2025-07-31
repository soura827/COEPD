using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsLeadCategory
    {
        DataAccessLayerHelper.clsLeadCategoryData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _LeadCategoryId;
        private string _LeadCategory;
        private string _Description;
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
        public int? LeadCategoryId
        {
            get { return _LeadCategoryId; }
            set { _LeadCategoryId = value; }
        }
        public string LeadCategory
        {
            get { return _LeadCategory; }
            set { _LeadCategory = value; }
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

        public clsLeadCategory()
        {
            DBLayer = new DataAccessLayerHelper.clsLeadCategoryData();
        }
        public void AddUpdate(clsLeadCategory obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsLeadCategory Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsLeadCategory> LoadAll(clsLeadCategory obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}