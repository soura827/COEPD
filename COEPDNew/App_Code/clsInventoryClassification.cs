using System;
using System.Collections.Generic;

namespace BusinessLayer
{

    public class clsInventoryClassification
    {

        DataAccessLayerHelper.clsInventoryClassificationData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _InventoryClassificationId;
        private string _InventoryClassification;
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

        public int? InventoryClassificationId
        {
            get { return _InventoryClassificationId; }
            set { _InventoryClassificationId = value; }
        }
        public string InventoryClassification
        {
            get { return _InventoryClassification; }
            set { _InventoryClassification = value; }
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
        public clsInventoryClassification()
        {
            DBLayer = new DataAccessLayerHelper.clsInventoryClassificationData();
        }

        public void AddUpdate(clsInventoryClassification obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsInventoryClassification Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsInventoryClassification> LoadAll(clsInventoryClassification obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}