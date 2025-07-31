using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsReceipt
    {
        DataAccessLayerHelper.clsReceiptData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _ReceiptId;
        private string _Receipt;
        private int _ReceiptTypeId;
        private string _ReceiptType;
        private int _ParticipantId;
        private string _Participant;
        private int _PaymentTypeId;
        private string _PaymentType;
        private decimal _Amount;
        private string _Notes;
        private int _CompanyId;
        private string _Company;
        private string _ChequeNo;
        private DateTime? _ChequeDate;
        private int _ChequeStatusId;
        private string _NameOnAccount;
        private string _AccountNumber;
        private string _BankName;
        private string _BankBranch;
        private DateTime? _ReceiptDate;
        private decimal _Tax;
        private decimal _Total;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime? _CreatedOn;
        private int _CreatedBy;
        private int _LocationId;
        private string _Location;
        private string _Fullname;

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
        public int? ReceiptId
        {
            get { return _ReceiptId; }
            set { _ReceiptId = value; }
        }
        public string Receipt
        {
            get { return _Receipt; }
            set { _Receipt = value; }
        }
        public int ReceiptTypeId
        {
            get { return _ReceiptTypeId; }
            set { _ReceiptTypeId = value; }
        }
        public string ReceiptType
        {
            get { return _ReceiptType; }
            set { _ReceiptType = value; }
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
        public int ChequeStatusId
        {
            get { return _ChequeStatusId; }
            set { _ChequeStatusId = value; }
        }
        public string NameOnAccount
        {
            get { return _NameOnAccount; }
            set { _NameOnAccount = value; }
        }
        public string AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }
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
        public DateTime? ReceiptDate
        {
            get { return _ReceiptDate; }
            set { _ReceiptDate = value; }
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

        public int LocationId { get => _LocationId; set => _LocationId = value; }
        public string Location { get => _Location; set => _Location = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }

        public clsReceipt()
        {
            DBLayer = new DataAccessLayerHelper.clsReceiptData();
        }

        public string AddUpdate(clsReceipt obj)
        {
            return DBLayer.AddUpdate(obj);
        }

        public clsReceipt Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsReceipt> LoadAll(clsReceipt obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
