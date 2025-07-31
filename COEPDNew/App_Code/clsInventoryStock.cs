using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsInventoryStock
    {
        DataAccessLayerHelper.clsInventoryStockData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _InventoryStockId;
        private int _InventoryTypeId;
        private string _InventoryType;
        private int _InventoryId;
        private string _InventoryName;
        private int _Quantity;
        private int _EmployeeId;
        private string _Employee;
        private int _ParticipantId;
        private string _Participant;
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

        public int? InventoryStockId
        {
            get { return _InventoryStockId; }
            set { _InventoryStockId = value; }
        }

        public int InventoryTypeId
        {
            get { return _InventoryTypeId; }
            set { _InventoryTypeId = value; }
        }
        public string InventoryType
        {
            get { return _InventoryType; }
            set { _InventoryType = value; }
        }
        public int InventoryId
        {
            get { return _InventoryId; }
            set { _InventoryId = value; }
        }
        public string InventoryName
        {
            get { return _InventoryName; }
            set { _InventoryName = value; }
        }
        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }
        public string Employee
        {
            get { return _Employee; }
            set { _Employee = value; }
        }
        public int ParticipantId
        {
            get { return _ParticipantId; }
            set { _ParticipantId = value; }
        }
        public string Participant
        {
            get { return _Participant; }
            set { _Participant = value; }
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
        public clsInventoryStock()
        {
            DBLayer = new DataAccessLayerHelper.clsInventoryStockData();
        }
        public string AddUpdate(clsInventoryStock obj)
        {
            return DBLayer.AddUpdate(obj);
        }

        public clsInventoryStock Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsInventoryStock> LoadAll(clsInventoryStock obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}