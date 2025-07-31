using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsPlacement
    {
        DataAccessLayerHelper.clsPlacementData DBLayer;

        private int _SNo;
        private string _Keywords;
        private int? _PlacementId;
        private int _ParticipantId;
        private string _Participant;
        private string _Company;
        private string _Description;
        private bool _IsFeatured;
        private string _ImagePath;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
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
                return _Keywords;
            }

            set
            {
                _Keywords = value;
            }
        }

        public int? PlacementId
        {
            get
            {
                return _PlacementId;
            }

            set
            {
                _PlacementId = value;
            }
        }

        public int ParticipantId
        {
            get
            {
                return _ParticipantId;
            }

            set
            {
                _ParticipantId = value;
            }
        }

        public string Company
        {
            get
            {
                return _Company;
            }

            set
            {
                _Company = value;
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

        public bool IsFeatured
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
            get { return _IsDeleted; }
            set { _IsDeleted = value; }
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

        public string Participant
        {
            get
            {
                return _Participant;
            }

            set
            {
                _Participant = value;
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

        public clsPlacement()
        {
            DBLayer = new DataAccessLayerHelper.clsPlacementData();
        }

        public void AddUpdate(clsPlacement obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsPlacement Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsPlacement> LoadAll(clsPlacement obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}