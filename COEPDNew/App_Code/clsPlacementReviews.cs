using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsPlacementReviews
    {
        DataAccessLayerHelper.clsPlacementReviewsData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _PlacementReviewsId;
        private string _PlacementReviewsName;
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

        public int? PlacementReviewsId
        {
            get
            {
                return _PlacementReviewsId;
            }

            set
            {
                _PlacementReviewsId = value;
            }
        }

        public string PlacementReviewsName
        {
            get
            {
                return _PlacementReviewsName;
            }

            set
            {
                _PlacementReviewsName = value;
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

        public clsPlacementReviews()
        {
            DBLayer = new DataAccessLayerHelper.clsPlacementReviewsData();
        }
        public void AddUpdate(clsPlacementReviews obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsPlacementReviews Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsPlacementReviews> LoadAll(clsPlacementReviews obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
