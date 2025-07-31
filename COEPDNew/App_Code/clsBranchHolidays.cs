using System;
using System.Collections.Generic;

namespace BusinessLayer
{

    public class clsBranchHolidays
    {
        DataAccessLayerHelper.clsBranchHolidaysData DBLayer;
        private int _SNO;
        private string _Keywords;
        private int? _BranchHolidaysId;
        private int _LocationId;
        private int _BranchId;
        private string _BranchHolidaysTitle;
        private string _BranchHolidaysContent;
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

        public int? BranchHolidaysId
        {
            get
            {
                return _BranchHolidaysId;
            }

            set
            {
                _BranchHolidaysId = value;
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

        public string BranchHolidaysTitle
        {
            get
            {
                return _BranchHolidaysTitle;
            }

            set
            {
                _BranchHolidaysTitle = value;
            }
        }

        public string BranchHolidaysContent
        {
            get
            {
                return _BranchHolidaysContent;
            }

            set
            {
                _BranchHolidaysContent = value;
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

        public clsBranchHolidays()
        {
            DBLayer = new DataAccessLayerHelper.clsBranchHolidaysData();
        }
        public void AddUpdate(clsBranchHolidays obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsBranchHolidays Load(int id)
        {
            return DBLayer.Load(id);
        }
        public List<clsBranchHolidays> LoadAll(clsBranchHolidays obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
        public clsBranchHolidays Load_By_Branch(int BranchId)
        {
            return DBLayer.Load_By_Branch(BranchId);
        }
    }
}
