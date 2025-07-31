using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsPaymentType
    {
        DataAccessLayerHelper.clsPaymentTypeData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _PaymentTypeId;
        private string _PaymentType;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;

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
        public int? PaymentTypeId
        {
            get { return _PaymentTypeId; }
            set { _PaymentTypeId = value; }
        }
        public string PaymentType
        {
            get { return _PaymentType; }
            set { _PaymentType = value; }
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
        public int CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }

        public clsPaymentType()
        {
            DBLayer = new DataAccessLayerHelper.clsPaymentTypeData();
        }

        public void AddUpdate(clsPaymentType obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsPaymentType Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsPaymentType> LoadAll(clsPaymentType obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
