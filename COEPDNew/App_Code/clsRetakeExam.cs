using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsRetakeExam
    {
        DataAccessLayerHelper.clsRetakeExamtData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _RetakeExamID;
        private int _ExamID;
        private string _Description;
        private string _Topic;
        private string _Participant;
        private int _ParticipantId;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private int _ModifiedBy;
        private string _UserComments;
        private int? _RetakeStatusId;
        private DateTime _BatchDate;
        private string _Location;
        private string _Employee;
        private float _MarksPercentage;
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
        public int? RetakeExamID
        {
            get { return _RetakeExamID; }
            set { _RetakeExamID = value; }
        }
        public int ExamID
        {
            get { return _ExamID; }
            set { _ExamID = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
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
        public string Topic
        {
            get { return _Topic; }
            set { _Topic = value; }
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
        public int ModifiedBy
        {
            get { return _ModifiedBy; }
            set { _ModifiedBy = value; }
        }
        public string UserComments
        {
            get { return _UserComments; }
            set { _UserComments = value; }
        }
        public int? RetakeStatusId
        {
            get { return _RetakeStatusId; }
            set { _RetakeStatusId = value; }
        }
        public DateTime BatchDate
        {
            get { return _BatchDate; }
            set { _BatchDate = value; }
        }
        public string Employee
        {
            get { return _Employee; }
            set { _Employee = value; }
        }
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        public float MarksPercentage
        {
            get
            {
                return _MarksPercentage;
            }

            set
            {
                _MarksPercentage = value;
            }
        }

        public clsRetakeExam()
        {
            DBLayer = new DataAccessLayerHelper.clsRetakeExamtData();
        }
        public void AddUpdate(clsRetakeExam obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsRetakeExam Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsRetakeExam> LoadAll(clsRetakeExam obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public void UpdateStatus(clsRetakeExam obj)
        {
            DBLayer.UpdateStatus(obj);
        }
        public int RetakeExamCount()
        {
            return DBLayer.RetakeExamCount();
        }
    }
}

