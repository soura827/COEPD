using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsGallery
    {
        DataAccessLayerHelper.clsGalleryData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _GalleryId;
        private string _Name;
        private string _ImagePath;
        private string _ImageThumbPath;
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

        public int? GalleryId
        {
            get
            {
                return _GalleryId;
            }

            set
            {
                _GalleryId = value;
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

        public clsGallery()
        {
            DBLayer = new DataAccessLayerHelper.clsGalleryData();
        }
        public void AddUpdate(clsGallery obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsGallery Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsGallery> LoadAll(clsGallery obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}