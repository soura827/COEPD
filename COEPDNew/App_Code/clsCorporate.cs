using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsCorporate
    {
        DataAccessLayerHelper.clsCorporateData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _CorporateId;
        private string _Corporate;
        private string _ImagePath;
        private string _ImageThumbPath;
        private string _Website;
        private bool? _IsFeatured;
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
        public int? CorporateId
        {
            get { return _CorporateId; }
            set { _CorporateId = value; }
        }
        public string Corporate
        {
            get { return _Corporate; }
            set { _Corporate = value; }
        }
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }
        public string ImageThumbPath
        {
            get { return _ImageThumbPath; }
            set { _ImageThumbPath = value; }
        }
        public string Website
        {
            get { return _Website; }
            set { _Website = value; }
        }
        public bool? IsFeatured
        {
            get { return _IsFeatured; }
            set { _IsFeatured = value; }
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


        public clsCorporate()
        {
            DBLayer = new DataAccessLayerHelper.clsCorporateData();
        }
        public void AddUpdate(clsCorporate obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsCorporate Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsCorporate> LoadAll(clsCorporate obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}