using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsBookConferenceHall
    {
        DataAccessLayerHelper.clsBookConferenceHallData DBLayer;

        private int _SNo;
        private string _Keywords;
        private int? _ConferenceHallId;
        private int _HallId;
        private string _ConferenceHall;
        private int _EmployeeId;
        private string _Employee;
        private DateTime _Date;
        private DateTime _StartTime;
        private DateTime _EndTime;
        private string _Purpose;
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

        public int? ConferenceHallId
        {
            get
            {
                return _ConferenceHallId;
            }

            set
            {
                _ConferenceHallId = value;
            }
        }

        public int HallId
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

        public int EmployeeId
        {
            get
            {
                return _EmployeeId;
            }

            set
            {
                _EmployeeId = value;
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

        public DateTime Date
        {
            get
            {
                return _Date;
            }

            set
            {
                _Date = value;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return _StartTime;
            }

            set
            {
                _StartTime = value;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return _EndTime;
            }

            set
            {
                _EndTime = value;
            }
        }

        public string Purpose
        {
            get
            {
                return _Purpose;
            }

            set
            {
                _Purpose = value;
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

        public clsBookConferenceHall()
        {
            DBLayer = new DataAccessLayerHelper.clsBookConferenceHallData();
        }

        public void AddUpdate(clsBookConferenceHall obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsBookConferenceHall Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsBookConferenceHall> LoadAll(clsBookConferenceHall obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}