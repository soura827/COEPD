using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsExam
    {
        DataAccessLayerHelper.clsExamData DBLayer;

        private int _LocationId;
        private string _Location;
        private int _ParticipantId;
        private string _Participant;
        private string _ExamTime;
        private int _SNo;
        private string _keywords;
        private int? _ExamId;
        private int _TopicId;
        private string _Topic;
        private int _UserId;
        private int _BatchId;
        private DateTime? _BatchDate;
        private DateTime? _StartDate;
        private DateTime? _EndDate;
        private int _StatusId;
        private string _Status;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private string _TotalExams;
        private string _CompletedExams;
        private string _Activites;
        private string _Documents;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private int _CategoryId;
        private string _Category;
        private float _MarksPersontage;




        public int LocationId
        {
            get { return _LocationId; }
            set { _LocationId = value; }
        }
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }
        public int ParticipantId
        {
            get { return _ParticipantId; }
            set { _ParticipantId = value; }
        }
        public string Participant
        {
            get { return _Participant; }
            set { _Participant = value; }
        }
        public string ExamTime
        {
            get { return _ExamTime; }
            set { _ExamTime = value; }
        }
        public int SNo
        {
            get { return _SNo; }
            set { _SNo = value; }
        }
        public string keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }
        public int? ExamId
        {
            get { return _ExamId; }
            set { _ExamId = value; }
        }
        public int TopicId
        {
            get { return _TopicId; }
            set { _TopicId = value; }
        }
        public string Topic
        {
            get { return _Topic; }
            set { _Topic = value; }
        }
        public int BatchId
        {
            get { return _BatchId; }
            set { _BatchId = value; }
        }
        public DateTime? BatchDate
        {
            get { return _BatchDate; }
            set { _BatchDate = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public DateTime? StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        public DateTime? EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }
        public int StatusId
        {
            get { return _StatusId; }
            set { _StatusId = value; }
        }
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public bool IsActive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
        }
        public bool IsDeleted
        {
            get { return _IsDeleted; }
            set { _IsDeleted = value; }
        }
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { _CreatedOn = value; }
        }
        public int? CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }
        public DateTime ModifiedOn
        {
            get { return _ModifiedOn; }
            set { _ModifiedOn = value; }
        }
        public string TotalExams
        {
            get { return _TotalExams; }
            set { _TotalExams = value; }
        }
        public string CompletedExams
        {
            get { return _CompletedExams; }
            set { _CompletedExams = value; }
        }
        public string Activites
        {
            get { return _Activites; }
            set { _Activites = value; }
        }
        public string Documents
        {
            get { return _Documents; }
            set { _Documents = value; }
        }
        public DateTime? FromDate
        {
            get { return _FromDate; }
            set { _FromDate = value; }
        }
        public DateTime? ToDate
        {
            get { return _ToDate; }
            set { _ToDate = value; }
        }
        public int CategoryId
        {
            get { return _CategoryId; }
            set { _CategoryId = value; }
        }
        public string Category
        {
            get { return _Category; }
            set { _Category = value; }
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

        public clsExam()
        {
            DBLayer = new DataAccessLayerHelper.clsExamData();
        }

        public int AddUpdate(clsExam obj)
        {
            return DBLayer.AddUpdate(obj);
        }

        public clsExam Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsExam> LoadAll(clsExam obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

        public clsExam ExamCount(clsExam obj)
        {
            return DBLayer.ExamCount(obj);
        }
        public List<clsExam> LoadAllReports(clsExam obj)
        {
            return DBLayer.LoadAllReports(obj);
        }
    }
}