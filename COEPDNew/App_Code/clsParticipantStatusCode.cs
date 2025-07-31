using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsParticipantStatusCode
    {
        DataAccessLayerHelper.clsParticipantStatusCodeData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _ParticipantStatusCodeId;
        //private string _ParticipantStatus;

        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private string _Fullname;
        private string _Employee;
        private string _Modifiedname;
        private DateTime? _ModifiedOn;
        private int _StatusCode;
        private string _StatusName;

        private string _Description;
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

        public int? ParticipantStatusCodeId
        {
            get
            {
                return _ParticipantStatusCodeId;
            }

            set
            {
                _ParticipantStatusCodeId = value;
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

        public int? CreatedBy
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





        public DateTime? ModifiedOn
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



        public string Fullname
        {
            get
            {
                return _Fullname;
            }

            set
            {
                _Fullname = value;
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

        public string Modifiedname
        {
            get
            {
                return _Modifiedname;
            }

            set
            {
                _Modifiedname = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }

            set
            {
                _Description = value;
            }
        }

        public int StatusCode
        {
            get
            {
                return _StatusCode;
            }

            set
            {
                _StatusCode = value;
            }
        }

        public string StatusName
        {
            get
            {
                return _StatusName;
            }

            set
            {
                _StatusName = value;
            }
        }

        public clsParticipantStatusCode()
        {
            DBLayer = new DataAccessLayerHelper.clsParticipantStatusCodeData();
        }
        public void AddUpdate(clsParticipantStatusCode obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsParticipantStatusCode Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsParticipantStatusCode> LoadAll(clsParticipantStatusCode obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

        public int LoadParticipantStatusCodeValidation(clsParticipantStatusCode obj)
        {
            return DBLayer.LoadParticipantStatusCodeValidation(obj);
        }
        public int LoadParticipantCodeValidation(clsParticipantStatusCode obj)
        {
            return DBLayer.LoadParticipantCodeValidation(obj);
        }

    }

}