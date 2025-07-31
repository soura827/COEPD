using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsQuestion
    {
        DataAccessLayerHelper.clsQuestionData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _QuestionId;
        private string _Question;
        private int _TopicId;
        private int _QuestionTypeId;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private string _Description;

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
        public int? QuestionId
        {
            get { return _QuestionId; }
            set { _QuestionId = value; }
        }
        public string Question
        {
            get { return _Question; }
            set { _Question = value; }
        }
        public int TopicId
        {
            get { return _TopicId; }
            set { _TopicId = value; }
        }
        public int QuestionTypeId
        {
            get { return _QuestionTypeId; }
            set { _QuestionTypeId = value; }
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

        public clsQuestion()
        {
            DBLayer = new DataAccessLayerHelper.clsQuestionData();
        }
        public string AddUpdate(clsQuestion obj)
        {
            return DBLayer.AddUpdate(obj);
        }
        public clsQuestion Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsQuestion> LoadAll(clsQuestion obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}