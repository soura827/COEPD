using System;
using System.Collections.Generic;


namespace BusinessLayer
{
    public class clsAssignAward
    {
        DataAccessLayerHelper.clsAssignAwardData DBLayer;
        private int _SNo;
        private string _Keywords;
        private int? _AssignAwardId;
        private int _AwardId;
        private int? _EmployeeId;
        private string _Employee;
        private string _CertificateId;
        private DateTime _DateOfIssued;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private DateTime? _ModifiedOn;
        private int _CreatedBy;
        private int _ModifiedBy;
        private string _CreatedByName;
        private string _ModifiedByName;
        private string _AwardName;
        private DateTime _IssuedFortheMonth;
        private int _UserId;

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



        public int? AssignAwardId
        {
            get
            {
                return _AssignAwardId;
            }

            set
            {
                _AssignAwardId = value;
            }
        }

        public int AwardId
        {
            get
            {
                return _AwardId;
            }

            set
            {
                _AwardId = value;
            }
        }

        public int? EmployeeId
        {
            get
            {
                return _EmployeeId;
            }

            set
            {
                _EmployeeId = value;
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

        public string CertificateId
        {
            get
            {
                return _CertificateId;
            }

            set
            {
                _CertificateId = value;
            }
        }

        public DateTime DateOfIssued
        {
            get
            {
                return _DateOfIssued;
            }

            set
            {
                _DateOfIssued = value;
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

        public string CreatedByName
        {
            get
            {
                return _CreatedByName;
            }

            set
            {
                _CreatedByName = value;
            }
        }

        public string ModifiedByName
        {
            get
            {
                return _ModifiedByName;
            }

            set
            {
                _ModifiedByName = value;
            }
        }

        public string AwardName
        {
            get
            {
                return _AwardName;
            }

            set
            {
                _AwardName = value;
            }
        }

        public string Keywords
        {
            get
            {
                return _Keywords;
            }

            set
            {
                _Keywords = value;
            }
        }

        public DateTime IssuedFortheMonth
        {
            get
            {
                return _IssuedFortheMonth;
            }

            set
            {
                _IssuedFortheMonth = value;
            }
        }

        public int UserId { get => _UserId; set => _UserId = value; }

        public clsAssignAward()
        {
            DBLayer = new DataAccessLayerHelper.clsAssignAwardData();
        }
        public void AddUpdate(clsAssignAward obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsAssignAward Load(int id)
        {
            return DBLayer.Load(id);
        }
        public List<clsAssignAward> LoadAll(clsAssignAward obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
        public int LoadAssignAwardValidation(clsAssignAward obj)
        {
            return DBLayer.AssignAwardValidation(obj);
        }

        public clsAssignAward LoadAllAward(int id)
        {
            return DBLayer.LoadAllAward(id);
        }
    }
}
