using DataAccessLayerHelper;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsFAQsMaster
    {
        clsFAQsMasterData DBLayer;

        private int _SNo;
        private int? _FAQsId;
        private string _CompanyName;
        private string _Experience;
        private bool _IsSourceParticipant;
        private int _NoOfQuestions;
        private bool _IsRevised;
        private DateTime? _RevisedOn;
        private int? _RevisedBy;
        private string _FAQs;
        private string _keywords;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime _ModifiedOn;
        private string _ModifiedBy;
        private string _SkilSet;
        private string _UniqueId;
        private string _FullName;
        private string _Employee;
        private int _InterviewStatusId;
        private string _InterviewStatus;

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

        public string CompanyName
        {
            get
            {
                return _CompanyName;
            }

            set
            {
                _CompanyName = value;
            }
        }

        public string Experience
        {
            get
            {
                return _Experience;
            }

            set
            {
                _Experience = value;
            }
        }
        public int NoOfQuestions
        {
            get
            {
                return _NoOfQuestions;
            }

            set
            {
                _NoOfQuestions = value;
            }
        }

        public bool IsRevised
        {
            get
            {
                return _IsRevised;
            }

            set
            {
                _IsRevised = value;
            }
        }

        public DateTime? RevisedOn
        {
            get
            {
                return _RevisedOn;
            }

            set
            {
                _RevisedOn = value;
            }
        }

        public string FAQs
        {
            get
            {
                return _FAQs;
            }

            set
            {
                _FAQs = value;
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


        public string SkilSet
        {
            get
            {
                return _SkilSet;
            }

            set
            {
                _SkilSet = value;
            }
        }

        public Boolean IsSourceParticipant
        {
            get
            {
                return _IsSourceParticipant;
            }

            set
            {
                _IsSourceParticipant = value;
            }
        }

        public int? FAQsId
        {
            get
            {
                return _FAQsId;
            }

            set
            {
                _FAQsId = value;
            }
        }


        //public string UniqueId
        //{
        //    get
        //    {
        //        return UniqueId;
        //    }

        //    set
        //    {
        //        UniqueId = value;
        //    }
        //}



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

        public string ModifiedBy
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

        public int? RevisedBy
        {
            get
            {
                return _RevisedBy;
            }

            set
            {
                _RevisedBy = value;
            }
        }

        public string UniqueId
        {
            get
            {
                return _UniqueId;
            }

            set
            {
                _UniqueId = value;
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

        public string Employee
        {
            get
            {
                return _Employee;
            }

            set
            {
                _Employee = value;
            }
        }

        public int InterviewStatusId
        {
            get
            {
                return _InterviewStatusId;
            }

            set
            {
                _InterviewStatusId = value;
            }
        }

        public string InterviewStatus
        {
            get
            {
                return _InterviewStatus;
            }

            set
            {
                _InterviewStatus = value;
            }
        }

        public clsFAQsMaster()
        {

            DBLayer = new DataAccessLayerHelper.clsFAQsMasterData();
        }
        public void AddUpdate(clsFAQsMaster obj)
        {
            DBLayer.AddUpdate(obj);

        }
        public clsFAQsMaster Load(string Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsFAQsMaster> LoadAll(clsFAQsMaster obj)
        {
            return DBLayer.LoadAll(obj);
        }


    }
}

