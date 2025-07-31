using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsParticipantFeeMapping
    {
        DataAccessLayerHelper.clsParticipantFeeMappingData DBLayer;
        private int? _ParticipantFeeMapId;
        private string _Participant;
        private string _Services;
        private decimal _ActualFee;
        private decimal _AgreedFee;
        private decimal _Discount;
        private int _ModifiedBy;
        private string _ServiceOwner;
        private string _LeadOwner;
        private string _Batch;
        private string _keywords;
        private string _Location;
        private int _SNo;
        private int _ParticipantId;
        private int _CreatedBy;
        private int _ServiceOwnerId;
        private int _LeadOwnerId;
        private int _LocationId;
        private int? _BatchId;
        private int? _ServiceId;
        private DateTime? _StartDate;
        private string _ServiceName;
        private Decimal _DiscountFee;
        private string _Employee;
        private string _Employees;
        private DateTime _CreatedOn;
        private string _Fullname;
        private int _LeadId;
        private string _Lead;
        private int _associateid;
        private decimal _discountamt;
        private decimal _Amount;
        private int _AssociateId;
        private string _AssociateName;
        private DateTime? _InstallmentDate;
        private string _Due;
        private string _Description;
        private string _InstallmentStatus;
        private string _Course;
        private string _ModifiedName;
        private string _ServiceOwnerName;
        private string _PrimaryMobile;
        private string _ServicesName;
        private string _DiscountAssociate;
        private int _FeeInstallmentId;

        public int? ParticipantFeeMapId { get => _ParticipantFeeMapId; set => _ParticipantFeeMapId = value; }
        public string Participant { get => _Participant; set => _Participant = value; }

        public string Services { get => _Services; set => _Services = value; }
        public decimal ActualFee { get => _ActualFee; set => _ActualFee = value; }
        public decimal Discount { get => _Discount; set => _Discount = value; }
        public int ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public string ServiceOwner { get => _ServiceOwner; set => _ServiceOwner = value; }
        public string LeadOwner { get => _LeadOwner; set => _LeadOwner = value; }
        public string Batch { get => _Batch; set => _Batch = value; }
        public string Location { get => _Location; set => _Location = value; }
        public decimal AgreedFee { get => _AgreedFee; set => _AgreedFee = value; }
        public string Keywords { get => _keywords; set => _keywords = value; }
        public int SNo { get => _SNo; set => _SNo = value; }
        public int ParticipantId { get => _ParticipantId; set => _ParticipantId = value; }
        public int CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public int ServiceOwnerId { get => _ServiceOwnerId; set => _ServiceOwnerId = value; }
        public int LeadOwnerId { get => _LeadOwnerId; set => _LeadOwnerId = value; }
        public int LocationId { get => _LocationId; set => _LocationId = value; }
        public int? BatchId { get => _BatchId; set => _BatchId = value; }
        public int? ServiceId { get => _ServiceId; set => _ServiceId = value; }
        public DateTime? StartDate { get => _StartDate; set => _StartDate = value; }
        public string ServiceName { get => _ServiceName; set => _ServiceName = value; }
        public decimal DiscountFee { get => _DiscountFee; set => _DiscountFee = value; }
     
        public string Employee { get => _Employee; set => _Employee = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public string Employees { get => _Employees; set => _Employees = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }
        public int LeadId { get => _LeadId; set => _LeadId = value; }
        public string Lead { get => _Lead; set => _Lead = value; }
        public int Associateid { get => _associateid; set => _associateid = value; }
        public decimal Discountamt { get => _discountamt; set => _discountamt = value; }
        public decimal Amount { get => _Amount; set => _Amount = value; }
        public int AssociateId { get => _AssociateId; set => _AssociateId = value; }
        public string AssociateName { get => _AssociateName; set => _AssociateName = value; }
        public DateTime? InstallmentDate { get => _InstallmentDate; set => _InstallmentDate = value; }
        public string Due { get => _Due; set => _Due = value; }
        public string Description { get => _Description; set => _Description = value; }
        public string InstallmentStatus { get => _InstallmentStatus; set => _InstallmentStatus = value; }
        public string Course { get => _Course; set => _Course = value; }
        public string ModifiedName { get => _ModifiedName; set => _ModifiedName = value; }
        public string PrimaryMobile { get => _PrimaryMobile; set => _PrimaryMobile = value; }
        public string ServiceOwnerName { get => _ServiceOwnerName; set => _ServiceOwnerName = value; }
        public string ServicesName { get => _ServicesName; set => _ServicesName = value; }
        public string DiscountAssociate { get => _DiscountAssociate; set => _DiscountAssociate = value; }
        public int FeeInstallmentId { get => _FeeInstallmentId; set => _FeeInstallmentId = value; }

        public clsParticipantFeeMapping()
        {
            DBLayer = new DataAccessLayerHelper.clsParticipantFeeMappingData();
        }

        public void AddUpdate(clsParticipantFeeMapping obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsParticipantFeeMapping Load(int id)
        {
            return DBLayer.Load(id);
        }

        public clsParticipantFeeMapping LoadLead(int Id)
        {
            return DBLayer.LoadLead(Id);
        }

        public List<clsParticipantFeeMapping> LoadAll(clsParticipantFeeMapping obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public int LoadLeadValidation(clsParticipantFeeMapping obj)
        {
            return DBLayer.LoadLeadValidation(obj);
        }
    }
}