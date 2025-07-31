using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


//public class clsAssignHrTask
//{
//    public clsAssignHrTask()
//    {

//    }
//}

namespace BusinessLayer
{
    public class clsAssignHrTask
    {
        DataAccessLayerHelper.clsAssignHrTaskData DBLayer;

        private int _SNo;
        private int? _AssignNurturingTaskId;
        private int? _NurturingTaskId;
        private int _ParticipantId;
        private string _ParticipantName;
        private int _NurturingProcessStageId;
        private int? _NurturingProcessStageTaskId;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime? _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private string _NurturingProcessStageName;
        private string _NurturingProcessStageTaskName;
        private string _keywords;
        private string _Location;
        private bool _IsApproved;
        private int? _ApprovedBy;
        private decimal? _ExamScore;
        private string _Participant;
        private DateTime? _ApprovedOn;
        private string _SenderImagePath;
        private string _Email;
        private string _Mobile;
        private string _Username;
        private int? _EvaluatedBy;
        private DateTime? _EvaluatedOn;
        private string _Employee;
        private DateTime? _TargetDate;
        private int? _NurturingProcessSlotsId;
        private DateTime? _SlotDate;
        private DateTime? _SlotStartTime;
        private DateTime? _SlotEndTime;
        private int _TaskAssignedTo;
        private int _EmployeeId;
        private DateTime? _TaskCompletedOn;
        private string _MentorInputs;
        private string _TaskInputs;
        private string _ParticipantInputs;
        private string _ReceiverImagePath;
        private int? _TargetDateInterval;
        private string _Fullname;



        private int? _AssignHrTaskId;
        private int _HrProcessStageTaskId;
        private int _HrProcessSlotsId;
        private int _HrTaskId;
        private int _HrProcessStageId;

        private string _HrProcessStageName;
        private string _HrProcessStageTaskName;
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
        public int? AssignNurturingTaskId
        {
            get
            {
                return _AssignNurturingTaskId;
            }

            set
            {
                _AssignNurturingTaskId = value;
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
        public string ParticipantName
        {
            get
            {
                return _ParticipantName;
            }

            set
            {
                _ParticipantName = value;
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
        public int? NurturingProcessStageTaskId
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
        public DateTime? CreatedOn
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

        public string keywords
        {
            get
            {
                return _keywords;
            }

            set
            {
                _keywords = value;
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

        public int? ApprovedBy
        {
            get
            {
                return _ApprovedBy;
            }

            set
            {
                _ApprovedBy = value;
            }
        }

        public decimal? ExamScore
        {
            get
            {
                return _ExamScore;
            }

            set
            {
                _ExamScore = value;
            }
        }


        public int? NurturingTaskId
        {
            get
            {
                return _NurturingTaskId;
            }

            set
            {
                _NurturingTaskId = value;
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

        public DateTime? ApprovedOn
        {
            get
            {
                return _ApprovedOn;
            }

            set
            {
                _ApprovedOn = value;
            }
        }

        public string SenderImagePath
        {
            get
            {
                return _SenderImagePath;
            }

            set
            {
                _SenderImagePath = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string Mobile
        {
            get
            {
                return _Mobile;
            }

            set
            {
                _Mobile = value;
            }
        }

        public string Username
        {
            get
            {
                return _Username;
            }

            set
            {
                _Username = value;
            }
        }

        public int? EvaluatedBy
        {
            get
            {
                return _EvaluatedBy;
            }

            set
            {
                _EvaluatedBy = value;
            }
        }

        public DateTime? EvaluatedOn
        {
            get
            {
                return _EvaluatedOn;
            }

            set
            {
                _EvaluatedOn = value;
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

        public DateTime? TargetDate
        {
            get
            {
                return _TargetDate;
            }

            set
            {
                _TargetDate = value;
            }
        }

        public int? NurturingProcessSlotsId
        {
            get
            {
                return _NurturingProcessSlotsId;
            }

            set
            {
                _NurturingProcessSlotsId = value;
            }
        }

        public DateTime? SlotDate
        {
            get
            {
                return _SlotDate;
            }

            set
            {
                _SlotDate = value;
            }
        }

        public DateTime? SlotStartTime
        {
            get
            {
                return _SlotStartTime;
            }

            set
            {
                _SlotStartTime = value;
            }
        }

        public DateTime? SlotEndTime
        {
            get
            {
                return _SlotEndTime;
            }

            set
            {
                _SlotEndTime = value;
            }
        }

        public int TaskAssignedTo
        {
            get
            {
                return _TaskAssignedTo;
            }

            set
            {
                _TaskAssignedTo = value;
            }
        }

        public DateTime? TaskCompletedOn
        {
            get
            {
                return _TaskCompletedOn;
            }

            set
            {
                _TaskCompletedOn = value;
            }
        }

        public string MentorInputs
        {
            get
            {
                return _MentorInputs;
            }

            set
            {
                _MentorInputs = value;
            }
        }

        public string ReceiverImagePath
        {
            get
            {
                return _ReceiverImagePath;
            }

            set
            {
                _ReceiverImagePath = value;
            }
        }

        public string TaskInputs
        {
            get
            {
                return _TaskInputs;
            }

            set
            {
                _TaskInputs = value;
            }
        }

        public int? TargetDateInterval
        {
            get
            {
                return _TargetDateInterval;
            }

            set
            {
                _TargetDateInterval = value;
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

        public string ParticipantInputs
        {
            get
            {
                return _ParticipantInputs;
            }

            set
            {
                _ParticipantInputs = value;
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

        public int? AssignHrTaskId { get => _AssignHrTaskId; set => _AssignHrTaskId = value; }
        public int HrProcessStageTaskId { get => _HrProcessStageTaskId; set => _HrProcessStageTaskId = value; }
        public int HrProcessSlotsId { get => _HrProcessSlotsId; set => _HrProcessSlotsId = value; }
        public int HrTaskId { get => _HrTaskId; set => _HrTaskId = value; }
        public int HrProcessStageId { get => _HrProcessStageId; set => _HrProcessStageId = value; }
        public string HrProcessStageName { get => _HrProcessStageName; set => _HrProcessStageName = value; }
        public string HrProcessStageTaskName { get => _HrProcessStageTaskName; set => _HrProcessStageTaskName = value; }

        public clsAssignHrTask()
        {
            DBLayer = new DataAccessLayerHelper.clsAssignHrTaskData();
        }
        public void AddUpdate(clsAssignHrTask obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsAssignHrTask Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsAssignHrTask> LoadAll(clsAssignHrTask obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public int LoadAssignNurturingTaskValidation(clsAssignHrTask obj)
        {
            return DBLayer.LoadAssignNurturingTaskValidation(obj);
        }

        public void UpdateExamFile(clsAssignHrTask obj)
        {
            DBLayer.UpdateExamFile(obj);
        }
    }
}


