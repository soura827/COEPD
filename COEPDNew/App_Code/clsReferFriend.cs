using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsReferFriend
    {
        DataAccessLayerHelper.clsReferFriendData DBLayer;

        private int _SNo;

        private int? _ReferFriendId;

        private String _ReferralName;

        private String _ReferralContact;

        private String _ReferralEmail;

        private int _ReferralLocationPreference;

        private String _Domain;

        private String _PlanningToJoinTheCourse;

        private DateTime _ReferralAvailableTimeSchedule;

        private Boolean _IsReferralBonus;

        private String _ParticipantUPIID;

        private int _ParticipantId;

        private int _EmployeeId;

        private int? _CreatedBy;

        private DateTime _CreatedOn;

        private string _Location;

        private DateTime? _ModifiedOn;

        private int? _ModifiedBy;

        private string _CreatedByName;

        private string _ModifiedByName;

        private int _ProcessExecutiveLocationId;

        private string _ProofPaymentPath;

        private string _ReferAmount;

        private string _Keywords;

        private string _Participant;

        private string _Employee;

        private int _LeadCategoryId;

        public int SNo { get => _SNo; set => _SNo = value; }
        public int? ReferFriendId { get => _ReferFriendId; set => _ReferFriendId = value; }
        public string ReferralName { get => _ReferralName; set => _ReferralName = value; }
        public string ReferralContact { get => _ReferralContact; set => _ReferralContact = value; }
        public string ReferralEmail { get => _ReferralEmail; set => _ReferralEmail = value; }
        public int ReferralLocationPreference { get => _ReferralLocationPreference; set => _ReferralLocationPreference = value; }
        public string Domain { get => _Domain; set => _Domain = value; }
        public DateTime ReferralAvailableTimeSchedule { get => _ReferralAvailableTimeSchedule; set => _ReferralAvailableTimeSchedule = value; }
        public string ParticipantUPIID { get => _ParticipantUPIID; set => _ParticipantUPIID = value; }
        public int ParticipantId { get => _ParticipantId; set => _ParticipantId = value; }
        public int EmployeeId { get => _EmployeeId; set => _EmployeeId = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public string Location { get => _Location; set => _Location = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public string CreatedByName { get => _CreatedByName; set => _CreatedByName = value; }
        public string ModifiedByName { get => _ModifiedByName; set => _ModifiedByName = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public int? ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public bool IsReferralBonus { get => _IsReferralBonus; set => _IsReferralBonus = value; }
        public string PlanningToJoinTheCourse { get => _PlanningToJoinTheCourse; set => _PlanningToJoinTheCourse = value; }
        public int ProcessExecutiveLocationId { get => _ProcessExecutiveLocationId; set => _ProcessExecutiveLocationId = value; }
        public string ProofPaymentPath { get => _ProofPaymentPath; set => _ProofPaymentPath = value; }
        public string ReferAmount { get => _ReferAmount; set => _ReferAmount = value; }
        public string Keywords { get => _Keywords; set => _Keywords = value; }
        public string Participant { get => _Participant; set => _Participant = value; }
        public string Employee { get => _Employee; set => _Employee = value; }
        public int LeadCategoryId { get => _LeadCategoryId; set => _LeadCategoryId = value; }

        public clsReferFriend()
        {
            DBLayer = new DataAccessLayerHelper.clsReferFriendData();
        }

        public void AddUpdate(clsReferFriend obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsReferFriend Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsReferFriend> LoadAll(clsReferFriend obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

        public int LoadReferFriendNameValidation(clsReferFriend obj)
        {
            return DBLayer.LoadReferFriendNameValidation(obj);
        }
        public int LoadReferFriendEmailValidation(clsReferFriend obj)
        {
            return DBLayer.LoadReferFriendEmailValidation(obj);
        }

    }



}