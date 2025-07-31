using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsSupportType
    {
        DataAccessLayerHelper.clsSupportTypeData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _SupportTypeId;
        private string _SupportType;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private string _Description;


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
        public int? SupportTypeId
        {
            get { return _SupportTypeId; }
            set { _SupportTypeId = value; }
        }
        public string SupportType
        {
            get { return _SupportType; }
            set { _SupportType = value; }
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
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public clsSupportType()
        {
            DBLayer = new DataAccessLayerHelper.clsSupportTypeData();
        }

        public void AddUpdate(clsSupportType obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsSupportType Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsSupportType> LoadAll(clsSupportType obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}