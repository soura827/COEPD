using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsUserExam
    {
        DataAccessLayerHelper.clsUserExamData DBLayer;

        private int _SNo;
        private string _keywords;
        private int _TopicId;
        private string _Topic;
        private Int64? _UserExamId;
        private Int32 _QuestionId;
        private Int32 _AnswerId;
        private string _Question;
        private string _Answer;
        private string _CorrentAnswer;
        private decimal _Marks;
        private bool _IsChecked;
        private Int32 _ExamId;
        private string _Exam;
        private int _StatusId;
        private string _Status;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private int _TotalQuestions;
        private int _CorrectAnswers;
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
        public Int64? UserExamId
        {
            get { return _UserExamId; }
            set { _UserExamId = value; }
        }
        public Int32 QuestionId
        {
            get { return _QuestionId; }
            set { _QuestionId = value; }
        }
        public string Question
        {
            get { return _Question; }
            set { _Question = value; }
        }
        public Int32 AnswerId
        {
            get { return _AnswerId; }
            set { _AnswerId = value; }
        }

        public string Answer
        {
            get { return _Answer; }
            set { _Answer = value; }
        }

        public string CorrentAnswer
        {
            get { return _CorrentAnswer; }
            set { _CorrentAnswer = value; }
        }
        public decimal Marks
        {
            get { return _Marks; }
            set { _Marks = value; }
        }
        public bool IsChecked
        {
            get { return _IsChecked; }
            set { _IsChecked = value; }
        }

        public Int32 ExamId
        {
            get { return _ExamId; }
            set { _ExamId = value; }
        }
        public string Exam
        {
            get { return _Exam; }
            set { _Exam = value; }
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

        public clsUserExam()
        {
            DBLayer = new DataAccessLayerHelper.clsUserExamData();
        }



        public void AddUpdate(clsUserExam obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsUserExam Load(Int64 Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsUserExam> LoadAll(clsUserExam obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsUserExam> LoadAllWrong(clsUserExam obj)
        {
            return DBLayer.LoadAllWrong(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public void RemoveExam(int Id)
        {
            DBLayer.RemoveExam(Id);
        }
        public List<clsUserExam> LoadAll_History(clsUserExam obj)
        {
            return DBLayer.LoadAll_History(obj);
        }
        public clsUserExam LoadAllQuestions_History(clsUserExam obj)
        {
            return DBLayer.LoadAllQuestions_History(obj);
        }



    }
}