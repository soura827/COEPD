using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsTrainerProfile
    {
        DataAccessLayerHelper.clsTrainerProfileData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _TrainerProfileId;
        private string _Name;
        private string _Description;
        private string _Profile;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private string _ImageThumbPath;
        private bool? _IsFeatured;

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

        public int? TrainerProfileId
        {
            get
            {
                return _TrainerProfileId;
            }

            set
            {
                _TrainerProfileId = value;
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

        public string Profile
        {
            get
            {
                return _Profile;
            }

            set
            {
                _Profile = value;
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

        public clsTrainerProfile()
        {
            DBLayer = new DataAccessLayerHelper.clsTrainerProfileData();
        }
        public void AddUpdate(clsTrainerProfile obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsTrainerProfile Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsTrainerProfile> LoadAll(clsTrainerProfile obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

    }
}

