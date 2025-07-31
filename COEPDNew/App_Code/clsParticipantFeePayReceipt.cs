using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace BusinessLayer
{
    public class clsParticipantFeePayReceipt
    {
        DataAccessLayerHelper.clsParticipantFeePayReceiptData DBLayer;
        private int _SNo;
        private int? _ReceiptId;
        private int _ReceiptTypeId;
        private int _ParticipantId;
        private int _ServiceId;
        private int _PaymentRecivingCompanyId;
        private int _PaymentTypeId;
        private string _Company;
        private string _ChequeNo;
        private DateTime? _ChequeDate;
        private int _ChequeStatusId;
        private string _BankName;
        private string _BankBranch;
        private string _NameOnAccount;
        private string _AccountNumber;
        private DateTime? _ReceiptDate;
        private string _ReferenceNumber;
        private decimal _AgreedFee;
        private decimal _PreviousAmount;
        private decimal _PayingAmount;
        private string _GSTtype;
        private decimal _WithOutGSTfees;
        private decimal _GSTtax;
        private decimal _PreviousAmountPayingAmountFee;
        private decimal _PendingAmount;
        private string _Notes;
        private int _CreatedBy;
        private DateTime? _CreatedOn;
        private string _Participant;
        private int _LocationId;
        private string _Location;
        private string _PaymentType;
        private string _Fullname;
        private string _ServiceName;
        private int _LeadId;
        private string _Lead;

        public int? ReceiptId { get => _ReceiptId; set => _ReceiptId = value; }
        public int ReceiptTypeId { get => _ReceiptTypeId; set => _ReceiptTypeId = value; }
        public int ParticipantId { get => _ParticipantId; set => _ParticipantId = value; }
        public int ServiceId { get => _ServiceId; set => _ServiceId = value; }
        public int PaymentTypeId { get => _PaymentTypeId; set => _PaymentTypeId = value; }
        public string Company { get => _Company; set => _Company = value; }
        public string ChequeNo { get => _ChequeNo; set => _ChequeNo = value; }
        public DateTime? ChequeDate { get => _ChequeDate; set => _ChequeDate = value; }
        public int ChequeStatusId { get => _ChequeStatusId; set => _ChequeStatusId = value; }
        public string BankName { get => _BankName; set => _BankName = value; }
        public string BankBranch { get => _BankBranch; set => _BankBranch = value; }
        public string NameOnAccount { get => _NameOnAccount; set => _NameOnAccount = value; }
        public string AccountNumber { get => _AccountNumber; set => _AccountNumber = value; }
        public DateTime? ReceiptDate { get => _ReceiptDate; set => _ReceiptDate = value; }
        public string ReferenceNumber { get => _ReferenceNumber; set => _ReferenceNumber = value; }
        public decimal AgreedFee { get => _AgreedFee; set => _AgreedFee = value; }
        public decimal PreviousAmount { get => _PreviousAmount; set => _PreviousAmount = value; }
        public decimal PayingAmount { get => _PayingAmount; set => _PayingAmount = value; }
        public string GSTtype { get => _GSTtype; set => _GSTtype = value; }
        public decimal WithOutGSTfees { get => _WithOutGSTfees; set => _WithOutGSTfees = value; }
        public decimal GSTtax { get => _GSTtax; set => _GSTtax = value; }
        public decimal PreviousAmountPayingAmountFee { get => _PreviousAmountPayingAmountFee; set => _PreviousAmountPayingAmountFee = value; }
        public decimal PendingAmount { get => _PendingAmount; set => _PendingAmount = value; }
        public string Notes { get => _Notes; set => _Notes = value; }
        public int CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public DateTime? CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int SNo { get => _SNo; set => _SNo = value; }
        public string Participant { get => _Participant; set => _Participant = value; }
        public int LocationId { get => _LocationId; set => _LocationId = value; }
        public string Location { get => _Location; set => _Location = value; }
        public string PaymentType { get => _PaymentType; set => _PaymentType = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }
        public string ServiceName { get => _ServiceName; set => _ServiceName = value; }
        public int LeadId { get => _LeadId; set => _LeadId = value; }
        public string Lead { get => _Lead; set => _Lead = value; }
        public int PaymentRecivingCompanyId { get => _PaymentRecivingCompanyId; set => _PaymentRecivingCompanyId = value; }

        public clsParticipantFeePayReceipt()
        {
            DBLayer = new DataAccessLayerHelper.clsParticipantFeePayReceiptData();
        }
        public void AddUpdate(clsParticipantFeePayReceipt obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

        public List<clsParticipantFeePayReceipt> LoadAll(clsParticipantFeePayReceipt obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public clsParticipantFeePayReceipt Load(int Id)
        {
            return DBLayer.Load(Id);
        }

    }
}
