using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsNurturingRevision
    {
        DataAccessLayerHelper.clsNurturingRevisionData DBLayer;
        private int _Sno;
        private string _Keywords;
        private int? _NurturingRevisionId;
        private int _ParticipantId;
        private int _ExamId;
        private int _TopicId;
        private int _TotalQuestions;
        private int _CorrectAnswers;
        private float _MarksPersontage;
        private bool _IsActive;
        private bool _IsDeleted;
        private int _CreatedBy;
        private DateTime _CreatedOn;
        private int _ModifiedBy;
        private DateTime _ModifiedOn;
        private int _Count;
        private string _Fullname;
        private string _Participant;
        private string _Topic;
        private string _Category;
        private int _NurturingProcessStageId;
        private string _NurturingProcessStageName;
        private int _NurturingProcessStageTaskId;
        private string _NurturingProcessStageTaskName;
        private bool _IsApproved;

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

        public int? NurturingRevisionId
        {
            get
            {
                return _NurturingRevisionId;
            }

            set
            {
                _NurturingRevisionId = value;
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

        public int NurturingProcessStageId
        {
            get
            {
                return _NurturingProcessStageId;
            }

            set
            {
                _NurturingProcessStageId = value;
            }
        }

        public string NurturingProcessStageName
        {
            get
            {
                return _NurturingProcessStageName;
            }

            set
            {
                _NurturingProcessStageName = value;
            }
        }

        public int NurturingProcessStageTaskId
        {
            get
            {
                return _NurturingProcessStageTaskId;
            }

            set
            {
                _NurturingProcessStageTaskId = value;
            }
        }

        public string NurturingProcessStageTaskName
        {
            get
            {
                return _NurturingProcessStageTaskName;
            }

            set
            {
                _NurturingProcessStageTaskName = value;
            }
        }

        public bool IsApproved
        {
            get
            {
                return _IsApproved;
            }

            set
            {
                _IsApproved = value;
            }
        }

        public clsNurturingRevision()
        {
            DBLayer = new DataAccessLayerHelper.clsNurturingRevisionData();
        }
        public void AddUpdate(clsNurturingRevision obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsNurturingRevision Load(clsNurturingRevision obj)
        {
            return DBLayer.Load(obj);
        }
        public List<clsNurturingRevision> LoadAll(clsNurturingRevision obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public int LoadNurturingRevisionValidation(clsNurturingRevision obj)
        {
            return DBLayer.LoadNurturingRevisionValidation(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }
    }
}
