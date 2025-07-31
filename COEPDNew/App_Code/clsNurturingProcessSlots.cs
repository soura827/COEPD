using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsNurturingProcessSlots
    {
        DataAccessLayerHelper.clsNurturingProcessSlotsData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _NurturingProcessSlotsId;
        private int _EmployeeId;
        private int _NurturingProcessStageTaskId;
        private int _ParticipantId;
        private DateTime _SlotDate;
        private DateTime? _SlotStartTime;
        private DateTime? _SlotEndTime;
        private bool _IsSlotAssigned;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _Participant;
        private string _Fullname;
        private string _Employee;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private string _Email;
        private string _Mobile;
        private string _StartEndTime;
        private int _TaskPriority;
        private string _ParticipantDetails;
        private string _NurturingProcessStageTaskName;
        private int _NurturingProcessId;
        private int _SlotsStatusId;
        private string _SlotStatus;
        private int _ActionValue;
        private int _NewNurturingProcessSlotsId;
        private int _LocationId;
        private string _Location;

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

        public DateTime SlotDate
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

        public bool IsSlotAssigned
        {
            get
            {
                return _IsSlotAssigned;
            }

            set
            {
                _IsSlotAssigned = value;
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

        public string StartEndTime
        {
            get
            {
                return _StartEndTime;
            }

            set
            {
                _StartEndTime = value;
            }
        }

        public int TaskPriority
        {
            get
            {
                return _TaskPriority;
            }

            set
            {
                _TaskPriority = value;
            }
        }

        public string ParticipantDetails
        {
            get
            {
                return _ParticipantDetails;
            }

            set
            {
                _ParticipantDetails = value;
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

        public int NurturingProcessId
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

        public int SlotsStatusId
        {
            get
            {
                return _SlotsStatusId;
            }

            set
            {
                _SlotsStatusId = value;
            }
        }

        public string SlotStatus
        {
            get
            {
                return _SlotStatus;
            }

            set
            {
                _SlotStatus = value;
            }
        }

        public int ActionValue
        {
            get
            {
                return _ActionValue;
            }

            set
            {
                _ActionValue = value;
            }
        }

        public int NewNurturingProcessSlotsId
        {
            get
            {
                return _NewNurturingProcessSlotsId;
            }

            set
            {
                _NewNurturingProcessSlotsId = value;
            }
        }
       
        public int LocationId { get => _LocationId; set => _LocationId = value; }
        public string Location { get => _Location; set => _Location = value; }

        public clsNurturingProcessSlots()
        {
            DBLayer = new DataAccessLayerHelper.clsNurturingProcessSlotsData();
        }
        public void AddUpdate(clsNurturingProcessSlots obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public void CancelSlot(clsNurturingProcessSlots obj)
        {
            DBLayer.CancelSlot(obj);
        }
        public clsNurturingProcessSlots Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public int LoadNurturingProcessSlotsValidation(clsNurturingProcessSlots obj)
        {
            return DBLayer.LoadNurturingProcessSlotsValidation(obj);
        }
        public int LoadSlotValidation(clsNurturingProcessSlots obj)
        {
            return DBLayer.LoadSlotValidation(obj);
        }
        public List<clsNurturingProcessSlots> LoadAll(clsNurturingProcessSlots obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsNurturingProcessSlots> LoadPriorityAll(clsNurturingProcessSlots obj)
        {
            return DBLayer.LoadPriorityAll(obj);
        }
        public List<clsNurturingProcessSlots> LoadChangeMentorAll(clsNurturingProcessSlots obj)
        {
            return DBLayer.LoadChangeMentorAll(obj);
        }
        public clsNurturingProcessSlots LoadTopOne(clsNurturingProcessSlots obj)
        {
            return DBLayer.LoadTopOne(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public void Approve(int Id)
        {
            DBLayer.Approve(Id);
        }
        public List<clsNurturingProcessSlots> LoadAlLReShedule(clsNurturingProcessSlots obj)
        {
            return DBLayer.LoadAlLReShedule(obj);
        }

        public int LoadSlotStatusValidation(clsNurturingProcessSlots obj)
        {
            return DBLayer.LoadSlotStatusValidation(obj);
        }
    }
}
