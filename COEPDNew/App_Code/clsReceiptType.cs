using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsReceiptType
    {
        DataAccessLayerHelper.clsReceiptTypeData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _ReceiptTypeId;
        private string _ReceiptType;
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
        public int? ReceiptTypeId
        {
            get { return _ReceiptTypeId; }
            set { _ReceiptTypeId = value; }
        }
        public string ReceiptType
        {
            get { return _ReceiptType; }
            set { _ReceiptType = value; }
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

        public clsReceiptType()
        {
            DBLayer = new DataAccessLayerHelper.clsReceiptTypeData();
        }
        public void AddUpdate(clsReceiptType obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsReceiptType Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsReceiptType> LoadAll(clsReceiptType obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}