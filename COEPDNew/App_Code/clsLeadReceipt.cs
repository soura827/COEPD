using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLayer
{
    public class clsLeadReceipt
    {
        DataAccessLayerHelper.clsLeadReceiptData DBLayer;
        private int _SNo;

        private int? _ReceiptId;

        private int _GSTTypeCompany;
        private string _CompanyName;
        private string _GSTNumber;
        private string _Address;
        private DateTime? _PayingDate;
        private Decimal _PayingAmount;
        private Decimal _FeeAmount;
        private Decimal _GST;
        private Decimal _PendingAmount;
        private int _InputCompany;
        private int _PaymentGateway;
        private string _ReferenceNumber;
        private string _AccountName;
        private string _AccountNumber;
        private string _BankName;
        private string _BankBranch;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private int _LeadId;
        private string _CreatedByName;

        private string _LeadName;
        private DateTime? _StartDate;
        private string _Location;
        private string _ServiceOwnerName;
        private string _PaymentType;

        private int _LocationId;
        private string _PrimaryMobile;
        private Decimal _AgreedFee;
        private int _ServiceOwnerId;
        private int _ServiceId;
        private string _ServiceName;

        private string _ConfirmationReferenceNo;
     
        private int _ConfirmationBy;
        private bool? _IsConfirmation;
        private string _Lead;
        private string _ServicesName;





        public int SNo { get => _SNo; set => _SNo = value; }
        public int? ReceiptId { get => _ReceiptId; set => _ReceiptId = value; }
        public int GSTTypeCompany { get => _GSTTypeCompany; set => _GSTTypeCompany = value; }
        public string CompanyName { get => _CompanyName; set => _CompanyName = value; }
        public string GSTNumber { get => _GSTNumber; set => _GSTNumber = value; }
        public string Address { get => _Address; set => _Address = value; }
        public DateTime? PayingDate { get => _PayingDate; set => _PayingDate = value; }
        public decimal PayingAmount { get => _PayingAmount; set => _PayingAmount = value; }
        public decimal FeeAmount { get => _FeeAmount; set => _FeeAmount = value; }
        public decimal GST { get => _GST; set => _GST = value; }
        public decimal PendingAmount { get => _PendingAmount; set => _PendingAmount = value; }
        public int InputCompany { get => _InputCompany; set => _InputCompany = value; }
        public int PaymentGateway { get => _PaymentGateway; set => _PaymentGateway = value; }
        public string ReferenceNumber { get => _ReferenceNumber; set => _ReferenceNumber = value; }
        public string AccountName { get => _AccountName; set => _AccountName = value; }
        public string AccountNumber { get => _AccountNumber; set => _AccountNumber = value; }
        public string BankName { get => _BankName; set => _BankName = value; }
        public string BankBranch { get => _BankBranch; set => _BankBranch = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public int LeadId { get => _LeadId; set => _LeadId = value; }
        public string CreatedByName { get => _CreatedByName; set => _CreatedByName = value; }
        public string LeadName { get => _LeadName; set => _LeadName = value; }
        public DateTime? StartDate { get => _StartDate; set => _StartDate = value; }
        public string Location { get => _Location; set => _Location = value; }
        public string ServiceOwnerName { get => _ServiceOwnerName; set => _ServiceOwnerName = value; }
        public string PaymentType { get => _PaymentType; set => _PaymentType = value; }
        public int LocationId { get => _LocationId; set => _LocationId = value; }
        public string PrimaryMobile { get => _PrimaryMobile; set => _PrimaryMobile = value; }
        public decimal AgreedFee { get => _AgreedFee; set => _AgreedFee = value; }
        public int ServiceOwnerId { get => _ServiceOwnerId; set => _ServiceOwnerId = value; }
        public int ServiceId { get => _ServiceId; set => _ServiceId = value; }
        public string ServiceName { get => _ServiceName; set => _ServiceName = value; }
        public string ConfirmationReferenceNo { get => _ConfirmationReferenceNo; set => _ConfirmationReferenceNo = value; }
        
        public int ConfirmationBy { get => _ConfirmationBy; set => _ConfirmationBy = value; }
        public bool? IsConfirmation { get => _IsConfirmation; set => _IsConfirmation = value; }
        public string Lead { get => _Lead; set => _Lead = value; }
        public string ServicesName { get => _ServicesName; set => _ServicesName = value; }

        public clsLeadReceipt()
        {
            DBLayer = new DataAccessLayerHelper.clsLeadReceiptData();
        }


        public void AddUpdate(clsLeadReceipt obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public List<clsLeadReceipt> LoadAll(clsLeadReceipt obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsLeadReceipt> LoadForAll(clsLeadReceipt obj)
        {
            return DBLayer.LoadForAll(obj);
        }
        public clsLeadReceipt Load(int Id)
        {
            return DBLayer.Load(Id);
        }


        public void Update(clsLeadReceipt obj)
        {
            DBLayer.Update(obj);
        }
        public clsLeadReceipt LoadReceipt(int Id)
        {
            return DBLayer.LoadReceipt(Id);
        }
        //public void Remove(int Id)
        //{
        //    DBLayer.Remove(Id);
        //}
        //public void AddUpdate1(clsLeadReceipt obj)
        //{
        //    DBLayer.AddUpdate(obj);
        //}
    }
}