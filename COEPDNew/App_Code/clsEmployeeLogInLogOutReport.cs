using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsEmployeeLogInLogOutReport
    {
        DataAccessLayerHelper.clsEmployeeLogInLogOutReportData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _EmployeeLogInLogOutReportId;
        private int _EmployeeId;
        private string _Employee;
        private DateTime _Date;
        private DateTime _StartTime;
        private DateTime? _EndTime;
        private string _LoginIPAddress;
        private string _LogoutIPAddress;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private string _Branch;
        private string _Code;
        private string _Designation;
        private string _Duration;
        private int _UserId;
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

        public int? EmployeeLogInLogOutReportId
        {
            get
            {
                return _EmployeeLogInLogOutReportId;
            }

            set
            {
                _EmployeeLogInLogOutReportId = value;
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

        public DateTime? EndTime
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

        public string LoginIPAddress
        {
            get
            {
                return _LoginIPAddress;
            }

            set
            {
                _LoginIPAddress = value;
            }
        }

        public string LogoutIPAddress
        {
            get
            {
                return _LogoutIPAddress;
            }

            set
            {
                _LogoutIPAddress = value;
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

        public DateTime? FromDate
        {
            get
            {
                return _FromDate;
            }

            set
            {
                _FromDate = value;
            }
        }

        public DateTime? ToDate
        {
            get
            {
                return _ToDate;
            }

            set
            {
                _ToDate = value;
            }
        }

        public string Branch
        {
            get
            {
                return _Branch;
            }

            set
            {
                _Branch = value;
            }
        }

        public string Code
        {
            get
            {
                return _Code;
            }

            set
            {
                _Code = value;
            }
        }

        public string Designation
        {
            get
            {
                return _Designation;
            }

            set
            {
                _Designation = value;
            }
        }

        public string Duration
        {
            get
            {
                return _Duration;
            }

            set
            {
                _Duration = value;
            }
        }

        public int UserId { get => _UserId; set => _UserId = value; }

        public clsEmployeeLogInLogOutReport()
        {
            DBLayer = new DataAccessLayerHelper.clsEmployeeLogInLogOutReportData();
        }
        public void AddUpdate(clsEmployeeLogInLogOutReport obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsEmployeeLogInLogOutReport Load(clsEmployeeLogInLogOutReport obj)
        {
            return DBLayer.Load(obj);
        }
        public List<clsEmployeeLogInLogOutReport> LoadAll(clsEmployeeLogInLogOutReport obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public clsEmployeeLogInLogOutReport Loadfew(int id)
        {
            return DBLayer.Loadfew(id);
        }

    }
}
