using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsNurturingProcessStageTaskStatus
    {
        DataAccessLayerHelper.clsNurturingProcessStageTaskStatusData DBLayer;
        private int _SNo;
        private int? _NurturingProcessStageTaskStatusId;
        private int _ParticipantId;
        private int _NurturingProcessStageTaskId;
        private string _NurturingProcessStageTaskName;
        private int _NurturingProcessStageId;
        private string _NurturingProcessStageName;
        private int _Weightage;
        private int _TimeFrame;
        private bool _IsNurturingProcessStageTaskStart;
        private bool _IsNurturingProcessStageTaskExit;
        private DateTime _StageTaskStartOn;
        private DateTime? _StageTaskExitOn;
        private string _ParticipantName;

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

        public int? NurturingProcessStageTaskStatusId
        {
            get
            {
                return _NurturingProcessStageTaskStatusId;
            }

            set
            {
                _NurturingProcessStageTaskStatusId = value;
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

        public int Weightage
        {
            get
            {
                return _Weightage;
            }

            set
            {
                _Weightage = value;
            }
        }

        public int TimeFrame
        {
            get
            {
                return _TimeFrame;
            }

            set
            {
                _TimeFrame = value;
            }
        }

        public bool IsNurturingProcessStageTaskStart
        {
            get
            {
                return _IsNurturingProcessStageTaskStart;
            }

            set
            {
                _IsNurturingProcessStageTaskStart = value;
            }
        }

        public bool IsNurturingProcessStageTaskExit
        {
            get
            {
                return _IsNurturingProcessStageTaskExit;
            }

            set
            {
                _IsNurturingProcessStageTaskExit = value;
            }
        }

        public DateTime StageTaskStartOn
        {
            get
            {
                return _StageTaskStartOn;
            }

            set
            {
                _StageTaskStartOn = value;
            }
        }

        public DateTime? StageTaskExitOn
        {
            get
            {
                return _StageTaskExitOn;
            }

            set
            {
                _StageTaskExitOn = value;
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

        public clsNurturingProcessStageTaskStatus()
        {
            DBLayer = new DataAccessLayerHelper.clsNurturingProcessStageTaskStatusData();
        }
        public void AddUpdate(clsNurturingProcessStageTaskStatus obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsNurturingProcessStageTaskStatus Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public clsNurturingProcessStageTaskStatus LoadNurturingProcessStageTaskStatusId(int ParticipantId, int NurturingProcessStageTaskId)
        {
            return DBLayer.LoadNurturingProcessStageTaskStatusId(ParticipantId, NurturingProcessStageTaskId);
        }

        public List<clsNurturingProcessStageTaskStatus> LoadAll(clsNurturingProcessStageTaskStatus obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Exit(int Id)
        {
            DBLayer.Exit(Id);
        }
        public int LoadNurturingProcessStageTaskStatusValidation(clsNurturingProcessStageTaskStatus obj)
        {
            return DBLayer.LoadNurturingProcessStageTaskStatusValidation(obj);
        }
        public int LoadNurturingProcessStageTaskStatusCount(clsNurturingProcessStageTaskStatus obj)
        {
            return DBLayer.LoadNurturingProcessStageTaskStatusCount(obj);
        }
    }
}
