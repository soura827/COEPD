using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsCampaign
    {
        DataAccessLayerHelper.clsCampaignData DBLayer;
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

        public int SNo
        {
            get
            {
                return _SNo;
            }

            set
            {
                _SNo = value;
            }
        }

        public string Keywords
        {
            get
            {
                return _keywords;
            }

            set
            {
                _keywords = value;
            }
        }

        public int? Offer
        {
            get
            {
                return _Offer;
            }

            set
            {
                _Offer = value;
            }
        }

        public string Title
        {
            get
            {
                return _Title;
            }

            set
            {
                _Title = value;
            }
        }

        public string Campaign_Keywords
        {
            get
            {
                return _Campaign_Keywords;
            }

            set
            {
                _Campaign_Keywords = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return _StartDate;
            }

            set
            {
                _StartDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return _EndDate;
            }

            set
            {
                _EndDate = value;
            }
        }

        public string USP1
        {
            get
            {
                return _USP1;
            }

            set
            {
                _USP1 = value;
            }
        }

        public string USP2
        {
            get
            {
                return _USP2;
            }

            set
            {
                _USP2 = value;
            }
        }

        public string USP3
        {
            get
            {
                return _USP3;
            }

            set
            {
                _USP3 = value;
            }
        }

        public string USP4
        {
            get
            {
                return _USP4;
            }

            set
            {
                _USP4 = value;
            }
        }

        public string USP5
        {
            get
            {
                return _USP5;
            }

            set
            {
                _USP5 = value;
            }
        }

        public string USP6
        {
            get
            {
                return _USP6;
            }

            set
            {
                _USP6 = value;
            }
        }

        public string USP7
        {
            get
            {
                return _USP7;
            }

            set
            {
                _USP7 = value;
            }
        }

        public string USP8
        {
            get
            {
                return _USP8;
            }

            set
            {
                _USP8 = value;
            }
        }

        public string USP9
        {
            get
            {
                return _USP9;
            }

            set
            {
                _USP9 = value;
            }
        }

        public string USP10
        {
            get
            {
                return _USP10;
            }

            set
            {
                _USP10 = value;
            }
        }

        public bool MobileNumberRequired
        {
            get
            {
                return _MobileNumberRequired;
            }

            set
            {
                _MobileNumberRequired = value;
            }
        }

        public bool EmailIdRequired
        {
            get
            {
                return _EmailIdRequired;
            }

            set
            {
                _EmailIdRequired = value;
            }
        }

        public bool SpecificEnquiryRequired
        {
            get
            {
                return _SpecificEnquiryRequired;
            }

            set
            {
                _SpecificEnquiryRequired = value;
            }
        }

        public string URL
        {
            get
            {
                return _URL;
            }

            set
            {
                _URL = value;
            }
        }

        public string FollowUpURL
        {
            get
            {
                return _FollowUpURL;
            }

            set
            {
                _FollowUpURL = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return _IsActive;
            }

            set
            {
                _IsActive = value;
            }
        }

        public bool IsDeleted
        {
            get
            {
                return _IsDeleted;
            }

            set
            {
                _IsDeleted = value;
            }
        }

        public DateTime CreatedOn
        {
            get
            {
                return _CreatedOn;
            }

            set
            {
                _CreatedOn = value;
            }
        }

        public int CreatedBy
        {
            get
            {
                return _CreatedBy;
            }

            set
            {
                _CreatedBy = value;
            }
        }

        public DateTime ModifiedOn
        {
            get
            {
                return _ModifiedOn;
            }

            set
            {
                _ModifiedOn = value;
            }
        }

        public int ModifiedBy
        {
            get
            {
                return _ModifiedBy;
            }

            set
            {
                _ModifiedBy = value;
            }
        }

        public string FullName
        {
            get
            {
                return _FullName;
            }

            set
            {
                _FullName = value;
            }
        }

        public string FilePath
        {
            get
            {
                return _FilePath;
            }

            set
            {
                _FilePath = value;
            }
        }

        public clsCampaign()
        {
            DBLayer = new DataAccessLayerHelper.clsCampaignData();
        }
        public void AddUpdate(clsCampaign obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsCampaign Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsCampaign> LoadAll(clsCampaign obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}