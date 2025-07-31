using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLayer
{
    //This BusinessLayer is used to Wrapping the Data into  PresentationLayer to DataAccessLayer using get and set Properties.
    public class clsParticipantFeePayment
    {
        DataAccessLayerHelper.clsParticipantFeePaymentData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _ActivityId;
        private int _ActivityCategoryId;
        private int _ActivitySubCategoryId;
        private string _ActivityCategory;
        private string _ActivitySubCategory;
        private string _Activity;
        //private int _ActivityModeofSelection;
        private string _Description;
        private string _Fullname;
        private string _Employee;
        private string _Modifiedname;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _Location;
        private string _AgreedFee;
        private int? _ServiceId;


        public int SNo { get => _SNo; set => _SNo = value; }
        public string Keywords { get => _keywords; set => _keywords = value; }
        public int? ActivityId { get => _ActivityId; set => _ActivityId = value; }
        public int ActivityCategoryId { get => _ActivityCategoryId; set => _ActivityCategoryId = value; }
        public int ActivitySubCategoryId { get => _ActivitySubCategoryId; set => _ActivitySubCategoryId = value; }
        public string ActivityCategory { get => _ActivityCategory; set => _ActivityCategory = value; }
        public string ActivitySubCategory { get => _ActivitySubCategory; set => _ActivitySubCategory = value; }
        public string Activity { get => _Activity; set => _Activity = value; }
        public string Description { get => _Description; set => _Description = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }
        public string Employee { get => _Employee; set => _Employee = value; }
        public string Modifiedname { get => _Modifiedname; set => _Modifiedname = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public int ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public string Location { get => _Location; set => _Location = value; }
        public string AgreedFee { get => _AgreedFee; set => _AgreedFee = value; }
        public int? ServiceId { get => _ServiceId; set => _ServiceId = value; }

        public clsParticipantFeePayment()
        {
            DBLayer = new DataAccessLayerHelper.clsParticipantFeePaymentData();
        }


        public void AddUpdate(clsParticipantFeePayment obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsParticipantFeePayment Load(int id)
        {
            return DBLayer.Load(id);
        }
        public List<clsParticipantFeePayment> LoadAll(clsParticipantFeePayment obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
        //public List<clsParticipantFeePayment> LoadAllActivityActivityModeofSelection(clsParticipantFeePayment obj)
        //{
        //    return DBLayer.LoadAllActivityActivityModeofSelection(obj);
        //}
    }
}
