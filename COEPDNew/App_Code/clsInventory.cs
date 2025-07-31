using System;
using System.Collections.Generic;

namespace BusinessLayer
{

    public class clsInventory
    {
        DataAccessLayerHelper.clsInventoryData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _InventoryId;
        private string _InventoryName;
        private int _InventoryTypeId;
        private string _InventoryType;
        private int _InventoryClassificationId;
        private string _InventoryClassification;
        private int _InventoryStatusId;
        private string _InventoryStatus;
        private DateTime _PurchaseDate;
        // private string _PurchaseFrom;
        private int _VendorId;
        private string _Vendor;
        private decimal _PurchaseCost;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private int? _NoOfItems;
        private DateTime? _ExpirationDate;
        private int? _OrderAlert;
        private string _ShelfLocation;
        private string _Color;
        private int _LocationId;
        private int _LocationOfficeId;
        private string _Location;
        private string _LocationOffice;
        private string _FullName;
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

        public int? InventoryId
        {
            get { return _InventoryId; }
            set { _InventoryId = value; }
        }
        public string InventoryName
        {
            get { return _InventoryName; }
            set { _InventoryName = value; }
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
        public int InventoryClassificationId
        {
            get { return _InventoryClassificationId; }
            set { _InventoryClassificationId = value; }
        }
        public string InventoryClassification
        {
            get { return _InventoryClassification; }
            set { _InventoryClassification = value; }
        }

        public int InventoryStatusId
        {
            get { return _InventoryStatusId; }
            set { _InventoryStatusId = value; }
        }
        public string InventoryStatus
        {
            get { return _InventoryStatus; }
            set { _InventoryStatus = value; }
        }
        public DateTime PurchaseDate
        {
            get { return _PurchaseDate; }
            set { _PurchaseDate = value; }
        }

        //public string PurchaseFrom
        //{
        //    get { return _PurchaseFrom; }
        //    set { _PurchaseFrom = value; }
        //}

        public decimal PurchaseCost
        {
            get { return _PurchaseCost; }
            set { _PurchaseCost = value; }

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

        public int? NoOfItems
        {
            get { return _NoOfItems; }
            set { _NoOfItems = value; }
        }
        public DateTime? ExpirationDate
        {
            get { return _ExpirationDate; }
            set { _ExpirationDate = value; }
        }
        public int? OrderAlert
        {
            get { return _OrderAlert; }
            set { _OrderAlert = value; }
        }
        public string ShelfLocation
        {
            get { return _ShelfLocation; }
            set { _ShelfLocation = value; }
        }

        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        public string Location
        {
            get
            {
                return _Location;
            }

            set
            {
                _Location = value;
            }
        }



        public int LocationId
        {
            get
            {
                return _LocationId;
            }

            set
            {
                _LocationId = value;
            }
        }



        public string FullName
        {
            get
            {
                return _FullName;
            }

            set
            {
                _FullName = value;
            }
        }

        public int LocationOfficeId
        {
            get
            {
                return _LocationOfficeId;
            }

            set
            {
                _LocationOfficeId = value;
            }
        }

        public string LocationOffice
        {
            get
            {
                return _LocationOffice;
            }

            set
            {
                _LocationOffice = value;
            }
        }

        public int VendorId
        {
            get
            {
                return _VendorId;
            }

            set
            {
                _VendorId = value;
            }
        }

        public string Vendor
        {
            get
            {
                return _Vendor;
            }

            set
            {
                _Vendor = value;
            }
        }

        public clsInventory()
        {
            DBLayer = new DataAccessLayerHelper.clsInventoryData();
        }

        public void AddUpdate(clsInventory obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsInventory Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsInventory> LoadAll(clsInventory obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}