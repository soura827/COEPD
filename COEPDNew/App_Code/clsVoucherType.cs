using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsVoucherType
    {
        DataAccessLayerHelper.clsVoucherTypeData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _VoucherTypeId;
        private string _VoucherType;
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
        public int? VoucherTypeId
        {
            get { return _VoucherTypeId; }
            set { _VoucherTypeId = value; }
        }
        public string VoucherType
        {
            get { return _VoucherType; }
            set { _VoucherType = value; }
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

        public clsVoucherType()
        {
            DBLayer = new DataAccessLayerHelper.clsVoucherTypeData();
        }
        public void AddUpdate(clsVoucherType obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsVoucherType Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsVoucherType> LoadAll(clsVoucherType obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

    }

}