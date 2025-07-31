using System;
using System.Collections.Generic;

namespace BusinessLayer
{

    public class clsInventoryStatus
    {

        DataAccessLayerHelper.clsInventoryStatusData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _InventoryStatusId;
        private string _InventoryStatus;
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

        public int? InventoryStatusId
        {
            get { return _InventoryStatusId; }
            set { _InventoryStatusId = value; }
        }
        public string InventoryStatus
        {
            get { return _InventoryStatus; }
            set { _InventoryStatus = value; }
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
        public clsInventoryStatus()
        {
            DBLayer = new DataAccessLayerHelper.clsInventoryStatusData();
        }

        public void AddUpdate(clsInventoryStatus obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsInventoryStatus Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsInventoryStatus> LoadAll(clsInventoryStatus obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}