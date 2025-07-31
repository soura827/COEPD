using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;




namespace BusinessLayer
{
    public class clsHrProcess
    {
        DataAccessLayerHelper.clsHrProcessData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _HrProcessId;
        private int _HrProcessStageId;
        private int _HrProcessStageTaskId;
        private int _ParticipantId;
        private string _Participant;
        private int? _EmployeeId;
        private string _Employee;
        private int _AssignedEmployeeId;
        private string _AssignedEmployee;
        private int _ApprovedBy;

        private DateTime? _ExamDate;
        private DateTime? _ApprovedDate;
        private decimal? _ExamScore;
        private string _SenderImagePath;
        private string _ReceiverImagePath;
        private string _Notes;

        private bool _IsApproved;
        private string _ApprovedEmployee;

        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private string _HrProcessStageTaskName;
        private string _Email;
        private string _Mobile;
        private string _Username;
        private string _Location;
        private int? _EvaluatedBy;
        private DateTime? _EvaluatedOn;
        private string _EvaluatedEmployee;
        private DateTime _TargetDate;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private int _HrProcessSlotsId;
        private DateTime? _SlotDate;
        private DateTime? _SlotStartTime;
        private DateTime? _SlotEndTime;
        private string _TaskAssignedTo;
        private int _SlotsStatusId;
        private int _PlacementInductionId;
        private string _Qualification;
        private string _CoOrdinator;


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

        public string Keywords
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

        public int? HrProcessId
        {
            get
            {
                return _HrProcessId;
            }

            set
            {
                _HrProcessId = value;
            }
        }

        public int HrProcessStageId
        {
            get
            {
                return _HrProcessStageId;
            }

            set
            {
                _HrProcessStageId = value;
            }
        }

        public int HrProcessStageTaskId
        {
            get
            {
                return _HrProcessStageTaskId;
            }

            set
            {
                _HrProcessStageTaskId = value;
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

        public int? EmployeeId
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

        public int AssignedEmployeeId
        {
            get
            {
                return _AssignedEmployeeId;
            }

            set
            {
                _AssignedEmployeeId = value;
            }
        }

        public string AssignedEmployee
        {
            get
            {
                return _AssignedEmployee;
            }

            set
            {
                _AssignedEmployee = value;
            }
        }

        public int ApprovedBy
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

        public string ApprovedEmployee
        {
            get
            {
                return _ApprovedEmployee;
            }

            set
            {
                _ApprovedEmployee = value;
            }
        }

        public DateTime? ExamDate
        {
            get
            {
                return _ExamDate;
            }

            set
            {
                _ExamDate = value;
            }
        }

        public DateTime? ApprovedDate
        {
            get
            {
                return _ApprovedDate;
            }

            set
            {
                _ApprovedDate = value;
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

        public string Notes
        {
            get
            {
                return _Notes;
            }

            set
            {
                _Notes = value;
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

        public string HrProcessStageTaskName
        {
            get
            {
                return _HrProcessStageTaskName;
            }

            set
            {
                _HrProcessStageTaskName = value;
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

        public string EvaluatedEmployee
        {
            get
            {
                return _EvaluatedEmployee;
            }

            set
            {
                _EvaluatedEmployee = value;
            }
        }

        public DateTime TargetDate
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

        public DateTime? ToDate
        {
            get
            {
                return _ToDate;
            }

            set
            {
                _ToDate = value;
            }
        }

        public DateTime? FromDate
        {
            get
            {
                return _FromDate;
            }

            set
            {
                _FromDate = value;
            }
        }

        public int HrProcessSlotsId
        {
            get
            {
                return _HrProcessSlotsId;
            }

            set
            {
                _HrProcessSlotsId = value;
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

        public string TaskAssignedTo
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

        public int SlotsStatusId { get => _SlotsStatusId; set => _SlotsStatusId = value; }
        public int PlacementInductionId { get => _PlacementInductionId; set => _PlacementInductionId = value; }
        public string Qualification { get => _Qualification; set => _Qualification = value; }
        public string CoOrdinator { get => _CoOrdinator; set => _CoOrdinator = value; }

        public clsHrProcess()
        {
            DBLayer = new DataAccessLayerHelper.clsHrProcessData();
        }
        public void AddUpdate(clsHrProcess obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsHrProcess Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public clsHrProcess LoadFinalizedResume(int Id)
        {
            return DBLayer.LoadFinalizedResume(Id);
        }

        public List<clsHrProcess> LoadAll(clsHrProcess obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public clsHrProcess LoadNextStageTask(int Id)
        {
            return DBLayer.LoadNextStageTask(Id);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public int LoadHrProcessValidation(clsHrProcess obj)
        {
            return DBLayer.LoadHrProcessValidation(obj);
        }

        public void UpdateExamFile(clsHrProcess obj)
        {
            DBLayer.UpdateExamFile(obj);
        }
    }
}
