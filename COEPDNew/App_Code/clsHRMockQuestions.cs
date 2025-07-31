using DataAccessLayerHelper;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsHRMockQuestions
    {
        clsHRMockQuestionsData DBLayer;
        private int _SNo;
        private int _HRMockQuestionId;
        private string _QuestionName;
        private string _Answer;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _ModifiedName;
        private int _RemarksId;
        private int _RatingId;
        private string _Remarks;
        private string _Rating;
        private int _ParticipantId;
        private string _Qualification;
        private string _BAExperience;
        private DateTime? _InterviewDate;
        private string _Participant;
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

        public string QuestionName
        {
            get
            {
                return _QuestionName;
            }

            set
            {
                _QuestionName = value;
            }
        }

        public string Answer
        {
            get
            {
                return _Answer;
            }

            set
            {
                _Answer = value;
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

        public string ModifiedName
        {
            get
            {
                return _ModifiedName;
            }

            set
            {
                _ModifiedName = value;
            }
        }

        public int HRMockQuestionId
        {
            get
            {
                return _HRMockQuestionId;
            }

            set
            {
                _HRMockQuestionId = value;
            }
        }

        public string Remarks
        {
            get
            {
                return _Remarks;
            }

            set
            {
                _Remarks = value;
            }
        }

        public string Rating
        {
            get
            {
                return _Rating;
            }

            set
            {
                _Rating = value;
            }
        }

        public int RemarksId
        {
            get
            {
                return _RemarksId;
            }

            set
            {
                _RemarksId = value;
            }
        }

        public int RatingId
        {
            get
            {
                return _RatingId;
            }

            set
            {
                _RatingId = value;
            }
        }

        public int ParticipantId
        {
            get
            {
                return _ParticipantId;
            }

            set
            {
                _ParticipantId = value;
            }
        }

        public string Qualification
        {
            get
            {
                return _Qualification;
            }

            set
            {
                _Qualification = value;
            }
        }

        public string BAExperience
        {
            get
            {
                return _BAExperience;
            }

            set
            {
                _BAExperience = value;
            }
        }

        public DateTime? InterviewDate
        {
            get
            {
                return _InterviewDate;
            }

            set
            {
                _InterviewDate = value;
            }
        }

        public string Participant
        {
            get
            {
                return _Participant;
            }

            set
            {
                _Participant = value;
            }
        }

        public clsHRMockQuestions()

        {
            DBLayer = new DataAccessLayerHelper.clsHRMockQuestionsData();
        }
        public void AddUpdate(clsHRMockQuestions obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsHRMockQuestions Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsHRMockQuestions> LoadAll(clsHRMockQuestions obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public List<clsHRMockQuestions> LoadAllRemarks(clsHRMockQuestions obj)
        {
            return DBLayer.LoadAlLRemarks(obj);
        }
        public List<clsHRMockQuestions> LoadAllRating(clsHRMockQuestions obj)
        {
            return DBLayer.LoadAlLRating(obj);
        }

    }
}

