using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsParticipantDiscount
    {
        DataAccessLayerHelper.clsParticipantDiscountData DBLayer;
        private int _SNo;
        private int? _DiscountId;
        private int _ParticipantId;
        private string _Participant;
        private int _ServiceId;
        private int _AssociateId;
        private string _AssociateName;
        private string _DiscountAmt;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _Employee;
        private string _ServiceName;
        private string _Fullname;
        private string _keywords;
        private int _ParticipantFeeMapId;
        private int? _LeadId;
        private string _Lead;
        private string _ServicesName;

        private string _DiscountUser;
        public int? DiscountId { get => _DiscountId; set => _DiscountId = value; }
        public int ParticipantId { get => _ParticipantId; set => _ParticipantId = value; }
        public string Participant { get => _Participant; set => _Participant = value; }
        public int ServiceId { get => _ServiceId; set => _ServiceId = value; }
        public int AssociateId { get => _AssociateId; set => _AssociateId = value; }
        public string DiscountAmt { get => _DiscountAmt; set => _DiscountAmt = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public int ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public string AssociateName { get => _AssociateName; set => _AssociateName = value; }
        public int SNo { get => _SNo; set => _SNo = value; }
        public string Employee { get => _Employee; set => _Employee = value; }
        public string ServiceName { get => _ServiceName; set => _ServiceName = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }
        public string Keywords { get => _keywords; set => _keywords = value; }
        public int ParticipantFeeMapId { get => _ParticipantFeeMapId; set => _ParticipantFeeMapId = value; }
        public int? LeadId { get => _LeadId; set => _LeadId = value; }
        public string Lead { get => _Lead; set => _Lead = value; }
        public string DiscountUser { get => _DiscountUser; set => _DiscountUser = value; }
        public string ServicesName { get => _ServicesName; set => _ServicesName = value; }

        public clsParticipantDiscount()
        {

            DBLayer = new DataAccessLayerHelper.clsParticipantDiscountData();
        }
        public void AddUpdate(clsParticipantDiscount obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public List<clsParticipantDiscount> DiscountLoadAll(clsParticipantDiscount obj)
        {
            return DBLayer.DiscountLoadAll(obj);
        }


    }
}