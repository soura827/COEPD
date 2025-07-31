using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsZoomCategory
    {

        DataAccessLayerHelper.clsZoomCategoryData DBLayer;
        private int _SNO;
        private int? _ZoomMeetingCategoryId;
        private string _ZoomMeetingCategory;
        private string _Description;
        private string _Fullname;
        private string _Modifiedname;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _Keywords;
        private string _ModifiedByName;
        private string _CreatedByName;
        private string _Employee;


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

        public int? ZoomMeetingCategoryId
        {
            get
            {
                return _ZoomMeetingCategoryId;
            }

            set
            {
                _ZoomMeetingCategoryId = value;
            }
        }

        public string ZoomMeetingCategory
        {
            get
            {
                return _ZoomMeetingCategory;
            }

            set
            {
                _ZoomMeetingCategory = value;
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

        public clsZoomCategory()
        {
            DBLayer = new DataAccessLayerHelper.clsZoomCategoryData();
        }


        public void AddUpdate(clsZoomCategory obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsZoomCategory Load(int id)
        {
            return DBLayer.Load(id);
        }
        public List<clsZoomCategory> LoadAll(clsZoomCategory obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
        public int LoadZoomMeetingCategoryValidation(clsZoomCategory obj)
        {
            return DBLayer.LoadZoomMeetingCategoryValidation(obj);
        }
    }
}