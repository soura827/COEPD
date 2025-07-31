using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsSuccessStories
    {
        DataAccessLayerHelper.clsSuccessStoriesData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _SuccessStoriesId;
        private string _SuccessStoriesName;
        private string _ImagePath;
        private string _ImageThumbPath;
        private bool? _IsFeatured;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;

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

        public int? SuccessStoriesId
        {
            get
            {
                return _SuccessStoriesId;
            }

            set
            {
                _SuccessStoriesId = value;
            }
        }

        public string SuccessStoriesName
        {
            get
            {
                return _SuccessStoriesName;
            }

            set
            {
                _SuccessStoriesName = value;
            }
        }

        public string ImagePath
        {
            get
            {
                return _ImagePath;
            }

            set
            {
                _ImagePath = value;
            }
        }

        public string ImageThumbPath
        {
            get
            {
                return _ImageThumbPath;
            }

            set
            {
                _ImageThumbPath = value;
            }
        }

        public bool? IsFeatured
        {
            get
            {
                return _IsFeatured;
            }

            set
            {
                _IsFeatured = value;
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

        public clsSuccessStories()
        {
            DBLayer = new DataAccessLayerHelper.clsSuccessStoriesData();
        }
        public void AddUpdate(clsSuccessStories obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsSuccessStories Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsSuccessStories> LoadAll(clsSuccessStories obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
