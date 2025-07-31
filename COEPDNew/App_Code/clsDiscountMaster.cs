using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer;


namespace BusinessLayer
{
    public class clsDiscountMaster
    {
        DataAccessLayerHelper.clsDiscountMasterData DBLayer;
        private int _SNo;
        private int? _DiscountMasterId;
        private string _DiscountGivenTo;
        private string _Description;
        private string _DiscountAmt;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _Fullname;

        public int SNo { get => _SNo; set => _SNo = value; }
        public int? DiscountMasterId { get => _DiscountMasterId; set => _DiscountMasterId = value; }
        public string DiscountGivenTo { get => _DiscountGivenTo; set => _DiscountGivenTo = value; }
        public string Description { get => _Description; set => _Description = value; }
        public string DiscountAmt { get => _DiscountAmt; set => _DiscountAmt = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public int ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }

        public clsDiscountMaster()
        {
            DBLayer = new DataAccessLayerHelper.clsDiscountMasterData();
        }
        public void DIscountMasterAddUpdate(clsDiscountMaster obj)
        {
            DBLayer.DIscountMasterAddUpdate(obj);
        }
        public List<clsDiscountMaster> DiscountMasterLoadAll(clsDiscountMaster obj)
        {
            return DBLayer.DiscountMasterLoadAll(obj);
        }
    }
}

