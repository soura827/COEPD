using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsPopUpImages
    {
        DataAccessLayerHelper.clsPopUpImagesData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _PopUpImageId;
        private string _PopUpImageName;
        private string _PopUpImagePath;
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

        public int? PopUpImageId
        {
            get
            {
                return _PopUpImageId;
            }

            set
            {
                _PopUpImageId = value;
            }
        }

        public string PopUpImageName
        {
            get
            {
                return _PopUpImageName;
            }

            set
            {
                _PopUpImageName = value;
            }
        }

        public string PopUpImagePath
        {
            get
            {
                return _PopUpImagePath;
            }

            set
            {
                _PopUpImagePath = value;
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

        public clsPopUpImages()
        {
            DBLayer = new DataAccessLayerHelper.clsPopUpImagesData();
        }
        public void AddUpdate(clsPopUpImages obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsPopUpImages Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsPopUpImages> LoadAll(clsPopUpImages obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
