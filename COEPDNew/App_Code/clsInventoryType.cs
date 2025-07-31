using System;
using System.Collections.Generic;

namespace BusinessLayer
{

    public class clsInventoryType
    {
        DataAccessLayerHelper.clsInventoryTypeData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _InventoryTypeId;
        private string _InventoryType;
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

        public int? InventoryTypeId
        {
            get { return _InventoryTypeId; }
            set { _InventoryTypeId = value; }
        }
        public string InventoryType
        {
            get { return _InventoryType; }
            set { _InventoryType = value; }
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
        public clsInventoryType()
        {
            DBLayer = new DataAccessLayerHelper.clsInventoryTypeData();
        }

        public void AddUpdate(clsInventoryType obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsInventoryType Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsInventoryType> LoadAll(clsInventoryType obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}