using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsCampaignWebinar
    {

        DataAccessLayerHelper.clsCampaignWebinarData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _Offer;
        private string _Title;
        private string _Campaign_Keywords;
        private DateTime _StartDate;
        private DateTime _EndDate;
        private string _USP1;
        private string _USP2;
        private string _USP3;
        private string _USP4;
        private string _USP5;
        private string _USP6;
        private string _USP7;
        private string _USP8;
        private string _USP9;
        private string _USP10;
        private bool _MobileNumberRequired;
        private bool _EmailIdRequired;
        private bool _SpecificEnquiryRequired;
        private string _URL;
        private string _FollowUpURL;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime _ModifiedOn;
        private int _ModifiedBy;
        private string _FullName;
        private string _FilePath;

        public int SNo { get => _SNo; set => _SNo = value; }
        public string Keywords { get => _keywords; set => _keywords = value; }
        public int? Offer { get => _Offer; set => _Offer = value; }
        public string Title { get => _Title; set => _Title = value; }
        public string Campaign_Keywords { get => _Campaign_Keywords; set => _Campaign_Keywords = value; }
        public DateTime StartDate { get => _StartDate; set => _StartDate = value; }
        public DateTime EndDate { get => _EndDate; set => _EndDate = value; }
        public string USP1 { get => _USP1; set => _USP1 = value; }
        public string USP2 { get => _USP2; set => _USP2 = value; }
        public string USP3 { get => _USP3; set => _USP3 = value; }
        public string USP4 { get => _USP4; set => _USP4 = value; }
        public string USP5 { get => _USP5; set => _USP5 = value; }
        public string USP6 { get => _USP6; set => _USP6 = value; }
        public string USP7 { get => _USP7; set => _USP7 = value; }
        public string USP8 { get => _USP8; set => _USP8 = value; }
        public string USP9 { get => _USP9; set => _USP9 = value; }
        public string USP10 { get => _USP10; set => _USP10 = value; }
        public bool MobileNumberRequired { get => _MobileNumberRequired; set => _MobileNumberRequired = value; }
        public bool EmailIdRequired { get => _EmailIdRequired; set => _EmailIdRequired = value; }
        public bool SpecificEnquiryRequired { get => _SpecificEnquiryRequired; set => _SpecificEnquiryRequired = value; }
        public string URL { get => _URL; set => _URL = value; }
        public string FollowUpURL { get => _FollowUpURL; set => _FollowUpURL = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public DateTime ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public int ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public string FullName { get => _FullName; set => _FullName = value; }
        public string FilePath { get => _FilePath; set => _FilePath = value; }
        public clsCampaignWebinar()
        {
            DBLayer = new DataAccessLayerHelper.clsCampaignWebinarData();
        }
        public void AddUpdate(clsCampaignWebinar obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsCampaignWebinar Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsCampaignWebinar> LoadAll(clsCampaignWebinar obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }




}
