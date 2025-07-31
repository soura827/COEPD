using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    //This BusinessLayer is used to Wrapping the Data into  PresentationLayer to DataAccessLayer using get and set Properties.
    public class clsActivity
    {
        DataAccessLayerHelper.clsActivityData DBLayer;
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

        public int? ActivityId
        {
            get
            {
                return _ActivityId;
            }

            set
            {
                _ActivityId = value;
            }
        }

        public int ActivityCategoryId
        {
            get
            {
                return _ActivityCategoryId;
            }

            set
            {
                _ActivityCategoryId = value;
            }
        }

        public string ActivityCategory
        {
            get
            {
                return _ActivityCategory;
            }

            set
            {
                _ActivityCategory = value;
            }
        }

        public string ActivitySubCategory
        {
            get
            {
                return _ActivitySubCategory;
            }

            set
            {
                _ActivitySubCategory = value;
            }
        }

        public string Activity
        {
            get
            {
                return _Activity;
            }

            set
            {
                _Activity = value;
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

        public int ActivitySubCategoryId
        {
            get
            {
                return _ActivitySubCategoryId;
            }

            set
            {
                _ActivitySubCategoryId = value;
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

        //public int ActivityModeofSelection
        //{
        //    get
        //    {
        //        return _ActivityModeofSelection;
        //    }

        //    set
        //    {
        //        _ActivityModeofSelection = value;
        //    }
        //}

        public clsActivity()
        {
            DBLayer = new DataAccessLayerHelper.clsActivityData();
        }


        public void AddUpdate(clsActivity obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsActivity Load(int id)
        {
            return DBLayer.Load(id);
        }
        public List<clsActivity> LoadAll(clsActivity obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
        //public List<clsActivity> LoadAllActivityActivityModeofSelection(clsActivity obj)
        //{
        //    return DBLayer.LoadAllActivityActivityModeofSelection(obj);
        //}
    }
}
