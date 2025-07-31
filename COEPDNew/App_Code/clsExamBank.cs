using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsExamBank
    {
        DataAccessLayerHelper.clsExamBankData DBLayer;

        private string _ExamTime;
        private int _SNo;
        private string _keywords;
        private int? _ExamBankId;
        private int _ExamId;
        private string _Exam;
        private int _UserId;
        private DateTime? _StartDate;
        private DateTime? _EndDate;
        private int _StatusId;
        private string _Status;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;

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
        public int? ExamBankId
        {
            get { return _ExamBankId; }
            set { _ExamBankId = value; }
        }
        public int ExamId
        {
            get { return _ExamId; }
            set { _ExamId = value; }
        }
        public string Exam
        {
            get { return _Exam; }
            set { _Exam = value; }
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

        public clsExamBank()
        {
            DBLayer = new DataAccessLayerHelper.clsExamBankData();
        }
        public int AddUpdate(clsExamBank obj)
        {
            return DBLayer.AddUpdate(obj);
        }
        public clsExamBank Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsExamBank> LoadAll(clsExamBank obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}