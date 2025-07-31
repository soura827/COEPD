using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLayer
{
    public class clsFeeInstallment
    {
        DataAccessLayerHelper.clsFeeInstallmentData DBLayer;

        private int _SNo;
        private int? _FeeInstallmentId;
        private string _Participant;
        private DateTime _InstallmentDate;
        private decimal _Amount;
        private string _Due;
        private string _Installments;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime _ModifiedOn;
        private int _ModifiedBy;
        private bool  _IsActive;
        private bool _IsDeleted;
        private string _Fullname;
        private int _ParticipantId;
        private int _LeadId;
        private int _ParticipantFeeMapId;
        private bool _IsInstallmentStatus;
        private string _Lead;
        private string _Keywords;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private decimal? _AgreedFee;
        private int? _ServiceOwnerId;
        private string _ServiceOwner;
        private DateTime? _StartDate;
        private bool _IsPaid;
        private string _Description;

        private string _Mobile;




        public int SNo { get => _SNo; set => _SNo = value; }
        public int? FeeInstallmentId { get => _FeeInstallmentId; set => _FeeInstallmentId = value; }
        public string Participant { get => _Participant; set => _Participant = value; }
        public DateTime InstallmentDate { get => _InstallmentDate; set => _InstallmentDate = value; }
        public decimal Amount { get => _Amount; set => _Amount = value; }
        public string Due { get => _Due; set => _Due = value; }
      
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public DateTime ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public int ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }
        public int ParticipantId { get => _ParticipantId; set => _ParticipantId = value; }
  
       
        public int LeadId { get => _LeadId; set => _LeadId = value; }
        public int ParticipantFeeMapId { get => _ParticipantFeeMapId; set => _ParticipantFeeMapId = value; }
        public string Lead { get => _Lead; set => _Lead = value; }
        public string Installments { get => _Installments; set => _Installments = value; }
        public string Keywords { get => _Keywords; set => _Keywords = value; }
        public DateTime? FromDate { get => _FromDate; set => _FromDate = value; }
        public DateTime? ToDate { get => _ToDate; set => _ToDate = value; }
     
        public int? ServiceOwnerId { get => _ServiceOwnerId; set => _ServiceOwnerId = value; }
        public decimal? AgreedFee { get => _AgreedFee; set => _AgreedFee = value; }
        public string ServiceOwner { get => _ServiceOwner; set => _ServiceOwner = value; }

        public bool IsPaid { get => _IsPaid; set => _IsPaid = value; }
        public bool IsInstallmentStatus { get => _IsInstallmentStatus; set => _IsInstallmentStatus = value; }
        public DateTime? StartDate { get => _StartDate; set => _StartDate = value; }
        public string Description { get => _Description; set => _Description = value; }
        public string Mobile { get => _Mobile; set => _Mobile = value; }

        public clsFeeInstallment()
        {

            DBLayer = new DataAccessLayerHelper.clsFeeInstallmentData();
        }
        public void AddUpdate(clsFeeInstallment obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public List<clsFeeInstallment> LoadAll(clsFeeInstallment obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public clsFeeInstallment Load(int id)
        {
            return DBLayer.Load(id);
        }

        public List<clsFeeInstallment> LoadFeeAll(clsFeeInstallment obj)
        {
            return DBLayer.LoadFeeAll(obj);
        }
        public clsFeeInstallment LoadEdit(int id)
        {
            return DBLayer.LoadEdit(id);
        }
        public List<clsFeeInstallment> LoadForALL(clsFeeInstallment obj)
        {
            return DBLayer.LoadForALL(obj);
        }

        public List<clsFeeInstallment> FeeRevenue(clsFeeInstallment obj)
        {
            return DBLayer.FeeRevenue(obj);
        }

        public List<clsFeeInstallment> ParticipantBadDebts(clsFeeInstallment obj)
        {
            return DBLayer.ParticipantBadDebts(obj);
        }



        public List<clsFeeInstallment> ParticipantFeeLost(clsFeeInstallment obj)
        {
            return DBLayer.ParticipantFeeLost(obj);
        }


        public List<clsFeeInstallment> LoadALLPendings(clsFeeInstallment obj)
        {
            return DBLayer.LoadALLPendings(obj);
        }
    }
}