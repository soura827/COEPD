using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsNews
    {
        DataAccessLayerHelper.clsNewsData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _NewsId;
        private string _NewsDescription;
        private bool? _IsActive;
        private bool _IsDeleted;
        private bool _IsFeatured;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private int _CMSId;

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
        public int? NewsId
        {
            get { return _NewsId; }
            set { _NewsId = value; }
        }
        public string NewsDescription
        {
            get { return _NewsDescription; }
            set { _NewsDescription = value; }
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
        public DateTime ModifiedOn
        {
            get { return _ModifiedOn; }
            set { _ModifiedOn = value; }
        }
        public int CMSId
        {
            get { return _CMSId; }
            set { _CMSId = value; }
        }
        public bool IsFeatured
        {
            get { return _IsFeatured; }
            set { _IsFeatured = value; }
        }

        public clsNews()
        {
            DBLayer = new DataAccessLayerHelper.clsNewsData();
        }
        public void AddUpdate(clsNews obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsNews Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsNews> LoadAll(clsNews obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}