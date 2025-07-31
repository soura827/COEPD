using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsVoucher
    {
        DataAccessLayerHelper.clsVoucherData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _VoucherId;
        private string _Voucher;
        private string _VoucherType;
        private int _VoucherTypeId;
        private int _VendorId;
        private string _Vendor;
        private int _PaymentTypeId;
        private string _PaymentType;
        private int _CompanyId;
        private string _Company;
        private string _ChequeNo;
        private DateTime? _ChequeDate;
        private int _ChequeStatusId;
        private string _NameOnAccount;
        private string _AccountNumber;
        private string _BankName;
        private string _BankBranch;
        private decimal _Amount;
        private string _Notes;
        private DateTime? _VoucherDate;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime? _CreatedOn;
        private int _CreatedBy;
        private decimal _Tax;
        private decimal _Total;

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
        public string Voucher
        {
            get { return _Voucher; }
            set { _Voucher = value; }
        }
        public int? VoucherId
        {
            get { return _VoucherId; }
            set { _VoucherId = value; }
        }
        public string VoucherType
        {
            get { return _VoucherType; }
            set { _VoucherType = value; }
        }
        public int VoucherTypeId
        {
            get { return _VoucherTypeId; }
            set { _VoucherTypeId = value; }
        }
        public int VendorId
        {
            get { return _VendorId; }
            set { _VendorId = value; }
        }
        public string Vendor
        {
            get { return _Vendor; }
            set { _Vendor = value; }
        }
        public int PaymentTypeId
        {
            get { return _PaymentTypeId; }
            set { _PaymentTypeId = value; }
        }
        public string PaymentType
        {
            get { return _PaymentType; }
            set { _PaymentType = value; }
        }
        public int CompanyId
        {
            get { return _CompanyId; }
            set { _CompanyId = value; }
        }
        public string Company
        {
            get { return _Company; }
            set { _Company = value; }
        }
        public string ChequeNo
        {
            get { return _ChequeNo; }
            set { _ChequeNo = value; }
        }

        public DateTime? ChequeDate
        {
            get { return _ChequeDate; }
            set { _ChequeDate = value; }
        }

        public string NameOnAccount
        {
            get { return _NameOnAccount; }
            set { _NameOnAccount = value; }
        }
        public int ChequeStatusId
        {
            get { return _ChequeStatusId; }
            set { _ChequeStatusId = value; }
        }
        public string AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }
        }
        public DateTime? VoucherDate
        {
            get { return _VoucherDate; }
            set { _VoucherDate = value; }
        }
        public string BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
        }

        public string BankBranch
        {
            get { return _BankBranch; }
            set { _BankBranch = value; }
        }

        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
        public string Notes
        {
            get { return _Notes; }
            set { _Notes = value; }
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
        public DateTime? CreatedOn
        {
            get { return _CreatedOn; }
            set { _CreatedOn = value; }
        }
        public int CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }
        public decimal Tax
        {
            get { return _Tax; }
            set { _Tax = value; }
        }
        public decimal Total
        {
            get { return _Total; }
            set { _Total = value; }
        }
        public clsVoucher()
        {
            DBLayer = new DataAccessLayerHelper.clsVoucherData();
        }

        public string AddUpdate(clsVoucher obj)
        {
            return DBLayer.AddUpdate(obj);
        }

        public clsVoucher Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsVoucher> LoadAll(clsVoucher obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }

}