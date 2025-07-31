using System;
using System.Collections.Generic;


namespace BusinessLayer
{
    public class clsGSuit
    {
        DataAccessLayerHelper.clsGSuitData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _GSuitEmailId;
        private string _GSuitEmail;
        private DateTime? _DateOfCreation;
        private bool _IsCreated;
        private bool _IsEmailAssigned;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _CreatedName;
        private string _ModifiedName;

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


        public DateTime? DateOfCreation
        {
            get
            {
                return _DateOfCreation;
            }

            set
            {
                _DateOfCreation = value;
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

        public string CreatedName
        {
            get
            {
                return _CreatedName;
            }

            set
            {
                _CreatedName = value;
            }
        }

        public string ModifiedName
        {
            get
            {
                return _ModifiedName;
            }

            set
            {
                _ModifiedName = value;
            }
        }

        public int? GSuitEmailId
        {
            get
            {
                return _GSuitEmailId;
            }

            set
            {
                _GSuitEmailId = value;
            }
        }

        public string GSuitEmail
        {
            get
            {
                return _GSuitEmail;
            }

            set
            {
                _GSuitEmail = value;
            }
        }

        public bool IsCreated
        {
            get
            {
                return _IsCreated;
            }

            set
            {
                _IsCreated = value;
            }
        }

        public bool IsEmailAssigned
        {
            get
            {
                return _IsEmailAssigned;
            }

            set
            {
                _IsEmailAssigned = value;
            }
        }

        public clsGSuit()
        {
            DBLayer = new DataAccessLayerHelper.clsGSuitData();
        }
        public void AddUpdate(clsGSuit obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsGSuit Load(int id)
        {
            return DBLayer.Load(id);
        }
        public List<clsGSuit> LoadAll(clsGSuit obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
        public int LoadEmailValidation(clsGSuit obj)
        {
            return DBLayer.LoadEmailValidation(obj);
        }
    }
}

