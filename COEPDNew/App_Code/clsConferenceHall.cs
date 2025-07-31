using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsConferenceHall
    {
        DataAccessLayerHelper.clsConferenceHallData DBLayer;

        private int _SNo;
        private string _Keywords;
        private int? _HallId;
        private string _ConferenceHall;
        private string _ImagePath;
        private int _Capacity;
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

        public int? HallId
        {
            get
            {
                return _HallId;
            }

            set
            {
                _HallId = value;
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

        public int Capacity
        {
            get
            {
                return _Capacity;
            }

            set
            {
                _Capacity = value;
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

        public string ConferenceHall
        {
            get
            {
                return _ConferenceHall;
            }

            set
            {
                _ConferenceHall = value;
            }
        }

        public clsConferenceHall()
        {
            DBLayer = new DataAccessLayerHelper.clsConferenceHallData();
        }

        public void AddUpdate(clsConferenceHall obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsConferenceHall Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsConferenceHall> LoadAll(clsConferenceHall obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}