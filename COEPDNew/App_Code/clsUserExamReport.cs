using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsUserExamReport
    {
        DataAccessLayerHelper.clsUserExamReportData DBLayer;

        private int _Sno;
        private string _Keywords;
        private int? _UserExamReportId;
        private int _UserId;
        private int _ExamId;
        private string _Category;
        private string _Topic;
        private int _TotalQuestions;
        private int _CorrectAnswers;
        private string _StartDate;
        private DateTime _StartTime;
        private DateTime _EndTime;
        private string _Duration;
        private int _RetakeExamCount;
        private bool _IsActive;
        private bool _IsDeleted;
        private int _CreatedBy;
        private DateTime _CreatedOn;
        private int _ModifiedBy;
        private DateTime _ModifiedOn;
        private int _Count;
        private string _Fullname;
        private int _BranchId;
        private float _MarksPersontage;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private int _LocationId;
        private int _EmployeeId;
        private int _CategoryId;
        private int _TopicId;
        private string _Location;
        private string _Employee;
        private DateTime _BatchDate;
        public int Sno
        {
            get
            {
                return _Sno;
            }

            set
            {
                _Sno = value;
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
        public int? UserExamReportId
        {
            get
            {
                return _UserExamReportId;
            }

            set
            {
                _UserExamReportId = value;
            }
        }

        public int UserId
        {
            get
            {
                return _UserId;
            }

            set
            {
                _UserId = value;
            }
        }

        public int ExamId
        {
            get
            {
                return _ExamId;
            }

            set
            {
                _ExamId = value;
            }
        }

        public string Category
        {
            get
            {
                return _Category;
            }

            set
            {
                _Category = value;
            }
        }

        public string Topic
        {
            get
            {
                return _Topic;
            }

            set
            {
                _Topic = value;
            }
        }

        public int TotalQuestions
        {
            get
            {
                return _TotalQuestions;
            }

            set
            {
                _TotalQuestions = value;
            }
        }

        public int CorrectAnswers
        {
            get
            {
                return _CorrectAnswers;
            }

            set
            {
                _CorrectAnswers = value;
            }
        }

        public string StartDate
        {
            get
            {
                return _StartDate;
            }

            set
            {
                _StartDate = value;
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

        public int RetakeExamCount
        {
            get
            {
                return _RetakeExamCount;
            }

            set
            {
                _RetakeExamCount = value;
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

        public int Count
        {
            get
            {
                return _Count;
            }

            set
            {
                _Count = value;
            }
        }

        public string Fullname
        {
            get
            {
                return _Fullname;
            }

            set
            {
                _Fullname = value;
            }
        }

        public int BranchId
        {
            get
            {
                return _BranchId;
            }

            set
            {
                _BranchId = value;
            }
        }

        public float MarksPersontage
        {
            get
            {
                return _MarksPersontage;
            }

            set
            {
                _MarksPersontage = value;
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

        public int LocationId
        {
            get
            {
                return _LocationId;
            }

            set
            {
                _LocationId = value;
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

        public int CategoryId
        {
            get
            {
                return _CategoryId;
            }

            set
            {
                _CategoryId = value;
            }
        }

        public int TopicId
        {
            get
            {
                return _TopicId;
            }

            set
            {
                _TopicId = value;
            }
        }

        public string Location
        {
            get
            {
                return _Location;
            }

            set
            {
                _Location = value;
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

        public DateTime BatchDate
        {
            get
            {
                return _BatchDate;
            }

            set
            {
                _BatchDate = value;
            }
        }

        public clsUserExamReport()
        {
            DBLayer = new DataAccessLayerHelper.clsUserExamReportData();
        }
        public void AddUpdate(clsUserExamReport obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsUserExamReport Load(int id)
        {
            return DBLayer.Load(id);
        }
        public List<clsUserExamReport> LoadAll(clsUserExamReport obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsUserExamReport> LoadAllEmployee(clsUserExamReport obj)
        {
            return DBLayer.LoadAllEmployee(obj);
        }
        public int UserExamReportCount()
        {
            return DBLayer.UserExamReportCount();
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
    }
}
