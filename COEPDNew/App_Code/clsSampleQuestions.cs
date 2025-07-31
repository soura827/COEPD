using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsSampleQuestions
    {
        DataAccessLayerHelper.clsSampleQuestionsData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _SampleQuestionsId;
        private string _SampleQuestionsPath;
        private string _SampleQuestionsName;
        private int? _ParticipantId;
        private string _Participant;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private int _CountSampleQuestions;

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
        public int? SampleQuestionsId
        {
            get { return _SampleQuestionsId; }
            set { _SampleQuestionsId = value; }
        }
        public string SampleQuestionsPath
        {
            get { return _SampleQuestionsPath; }
            set { _SampleQuestionsPath = value; }
        }
        public string SampleQuestionsName
        {
            get { return _SampleQuestionsName; }
            set { _SampleQuestionsName = value; }
        }
        public int? ParticipantId
        {
            get { return _ParticipantId; }
            set { _ParticipantId = value; }
        }
        public string Participant
        {
            get { return _Participant; }
            set { _Participant = value; }
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
        public int CountSampleQuestions
        {
            get { return _CountSampleQuestions; }
            set { _CountSampleQuestions = value; }
        }
        public clsSampleQuestions()
        {
            DBLayer = new DataAccessLayerHelper.clsSampleQuestionsData();
        }

        public void AddUpdate(clsSampleQuestions obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsSampleQuestions Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsSampleQuestions> LoadAll(clsSampleQuestions obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public clsSampleQuestions QuestionsCount(clsSampleQuestions obj)
        {
            return DBLayer.QuestionsCount(obj);
        }
    }
}