using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsAnswer
    {
        DataAccessLayerHelper.clsAnswerData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _AnswerId;
        private int? _QuestionId;
        private string _Question;
        private string _Answer;
        private decimal _AnswerMarks;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private string _Answer1;
        private string _Answer2;
        private string _Answer3;
        private string _Answer4;
        private decimal _AnswerMarks1;
        private decimal _AnswerMarks2;
        private decimal _AnswerMarks3;
        private decimal _AnswerMarks4;
        private int _CategoryId;
        private int _TopicId;
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
        public int? AnswerId
        {
            get { return _AnswerId; }
            set { _AnswerId = value; }
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
        public string Answer
        {
            get { return _Answer; }
            set { _Answer = value; }
        }
        public decimal AnswerMarks
        {
            get { return _AnswerMarks; }
            set { _AnswerMarks = value; }
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

        public string Answer1
        {
            get
            {
                return _Answer1;
            }

            set
            {
                _Answer1 = value;
            }
        }

        public string Answer2
        {
            get
            {
                return _Answer2;
            }

            set
            {
                _Answer2 = value;
            }
        }

        public string Answer3
        {
            get
            {
                return _Answer3;
            }

            set
            {
                _Answer3 = value;
            }
        }

        public string Answer4
        {
            get
            {
                return _Answer4;
            }

            set
            {
                _Answer4 = value;
            }
        }

        public decimal AnswerMarks1
        {
            get
            {
                return _AnswerMarks1;
            }

            set
            {
                _AnswerMarks1 = value;
            }
        }

        public decimal AnswerMarks2
        {
            get
            {
                return _AnswerMarks2;
            }

            set
            {
                _AnswerMarks2 = value;
            }
        }

        public decimal AnswerMarks3
        {
            get
            {
                return _AnswerMarks3;
            }

            set
            {
                _AnswerMarks3 = value;
            }
        }

        public decimal AnswerMarks4
        {
            get
            {
                return _AnswerMarks4;
            }

            set
            {
                _AnswerMarks4 = value;
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

        public string Description { get => _Description; set => _Description = value; }

        public clsAnswer()
        {
            DBLayer = new DataAccessLayerHelper.clsAnswerData();
        }
        public void AddUpdate(clsAnswer obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsAnswer Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsAnswer> LoadAll(clsAnswer obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public List<clsAnswer> QuestionAndAnswers(clsAnswer obj)
        {
            return DBLayer.QuestionAndAnswers(obj);
        }
    }
}