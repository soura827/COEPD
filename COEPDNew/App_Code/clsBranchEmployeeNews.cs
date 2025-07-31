using System;
using System.Collections.Generic;

namespace BusinessLayer
{


    public class clsBranchEmployeeNews
    {
        DataAccessLayerHelper.clsBranchEmployeeNewsData DBLayer;
        private int _SNO;
        private string _Keywords;
        private int? _BranchEmployeeNewsId;
        private int _LocationId;
        private int _BranchId;
        private string _NewsDescription;
        private string _Location;
        private string _Branch;
        private string _Fullname;
        //private string _Employee;
        private string _Modifiedname;
        private bool _IsActive;
        private bool _IsDeleted;
        private int? _CreatedBy;
        private DateTime _CreatedOn;
        private int _ModifiedBy;
        private DateTime? _ModifiedOn;

        public int SNO
        {
            get
            {
                return _SNO;
            }

            set
            {
                _SNO = value;
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

        public int? BranchEmployeeNewsId
        {
            get
            {
                return _BranchEmployeeNewsId;
            }

            set
            {
                _BranchEmployeeNewsId = value;
            }
        }

        public int LocationId
        {
            get
            {
                return _LocationId;
            }

            set
            {
                _LocationId = value;
            }
        }

        public int BranchId
        {
            get
            {
                return _BranchId;
            }

            set
            {
                _BranchId = value;
            }
        }

        public string NewsDescription
        {
            get
            {
                return _NewsDescription;
            }

            set
            {
                _NewsDescription = value;
            }
        }

        public string Location
        {
            get
            {
                return _Location;
            }

            set
            {
                _Location = value;
            }
        }

        public string Branch
        {
            get
            {
                return _Branch;
            }

            set
            {
                _Branch = value;
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

        //public string Employee
        //{
        //    get
        //    {
        //        return _Employee;
        //    }

        //    set
        //    {
        //        _Employee = value;
        //    }
        //}

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

        public clsBranchEmployeeNews()
        {
            DBLayer = new DataAccessLayerHelper.clsBranchEmployeeNewsData();
        }
        public void AddUpdate(clsBranchEmployeeNews obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsBranchEmployeeNews Load(int id)
        {
            return DBLayer.Load(id);
        }
        public List<clsBranchEmployeeNews> LoadAll(clsBranchEmployeeNews obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
        public List<clsBranchEmployeeNews> LoadAll_By_BranchId(clsBranchEmployeeNews obj)
        {
            return DBLayer.LoadAll_By_Branch(obj);
        }

    }
}