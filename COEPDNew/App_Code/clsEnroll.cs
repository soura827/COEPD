using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsEnroll
    {
        DataAccessLayerHelper.clsEnrollData DBLayer;

        private int _SNo;
        private string _Keywords;
        private int? _EnrollId;
        private string _Name;
        private string _EmailId;
        private string _Mobile;
        private int _CourseId;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;

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
                return _Keywords;
            }

            set
            {
                _Keywords = value;
            }
        }

        public int? EnrollId
        {
            get
            {
                return _EnrollId;
            }

            set
            {
                _EnrollId = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public string EmailId
        {
            get
            {
                return _EmailId;
            }

            set
            {
                _EmailId = value;
            }
        }

        public string Mobile
        {
            get
            {
                return _Mobile;
            }

            set
            {
                _Mobile = value;
            }
        }

        public int CourseId
        {
            get
            {
                return _CourseId;
            }

            set
            {
                _CourseId = value;
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

        public clsEnroll()
        {
            DBLayer = new DataAccessLayerHelper.clsEnrollData();
        }

        public void AddUpdate(clsEnroll obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsEnroll Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsEnroll> LoadAll(clsEnroll obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}