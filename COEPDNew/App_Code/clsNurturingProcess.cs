using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsNurturingProcess
    {
        DataAccessLayerHelper.clsNurturingProcessData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _NurturingProcessId;
        private int _NurturingProcessStageId;
        private int _NurturingProcessStageTaskId;
        private int _ParticipantId;
        private string _Participant;
        private int? _EmployeeId;
        private string _Employee;
        private int _AssignedEmployeeId;
        private string _AssignedEmployee;
        private int _ApprovedBy;
        private string _ApprovedEmployee;
        private DateTime? _ExamDate;
        private DateTime? _ApprovedDate;
        private decimal? _ExamScore;
        private string _SenderImagePath;
        private string _ReceiverImagePath;
        private string _Notes;
        private bool _IsApproved;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private string _NurturingProcessStageTaskName;
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
        private int _NurturingProcessSlotsId;
        private DateTime? _SlotDate;
        private DateTime? _SlotStartTime;
        private DateTime? _SlotEndTime;
        private string _TaskAssignedTo;
        private int _SlotsStatusId;

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

        public int? NurturingProcessId
        {
            get
            {
                return _NurturingProcessId;
            }

            set
            {
                _NurturingProcessId = value;
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

        public int NurturingProcessSlotsId
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

        public clsNurturingProcess()
        {
            DBLayer = new DataAccessLayerHelper.clsNurturingProcessData();
        }
        public void AddUpdate(clsNurturingProcess obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsNurturingProcess Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public clsNurturingProcess LoadFinalizedResume(int Id)
        {
            return DBLayer.LoadFinalizedResume(Id);
        }

        public List<clsNurturingProcess> LoadAll(clsNurturingProcess obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public clsNurturingProcess LoadNextStageTask(int Id)
        {
            return DBLayer.LoadNextStageTask(Id);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public int LoadNurturingProcessValidation(clsNurturingProcess obj)
        {
            return DBLayer.LoadNurturingProcessValidation(obj);
        }

        public void UpdateExamFile(clsNurturingProcess obj)
        {
            DBLayer.UpdateExamFile(obj);
        }
    }
}
