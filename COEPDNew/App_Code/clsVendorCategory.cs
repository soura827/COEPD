using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsVendorCategory
    {
        DataAccessLayerHelper.clsVendorCategoryData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _VendorCategoryId;
        private string _VendorCategory;
        private int _ParentCategoryId;

        private bool? _IsActive;
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
        public int? VendorCategoryId
        {
            get { return _VendorCategoryId; }
            set { _VendorCategoryId = value; }
        }
        public int ParentCategoryId
        {
            get { return _ParentCategoryId; }
            set { _ParentCategoryId = value; }
        }
        public string VendorCategory
        {
            get { return _VendorCategory; }
            set { _VendorCategory = value; }
        }


        public bool? IsActive
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

        public clsVendorCategory()
        {
            DBLayer = new DataAccessLayerHelper.clsVendorCategoryData();
        }
        public void AddUpdate(clsVendorCategory obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsVendorCategory Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsVendorCategory> LoadAll(clsVendorCategory obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsVendorCategory> LoadAllSubCategory(clsVendorCategory obj)
        {
            return DBLayer.LoadAllSubCategory(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}