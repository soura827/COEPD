using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsNurturingProcessStageStatus
    {
        DataAccessLayerHelper.clsNurturingProcessStageStatusData DBLayer;
        private int _SNo;
        private int? _NurturingProcessStageStatusId;
        private int _ParticipantId;
        private int _NurturingProcessStageId;
        private string _NurturingProcessStageName;
        private int _Weightage;
        private int _TimeFrame;
        private bool _IsNurturingProcessStageStart;
        private bool _IsNurturingProcessStageExit;
        private DateTime _StageStartOn;
        private DateTime? _StageExitOn;
        private string _ParticipantName;
        private int _TotalBAConceptsRevision;
        private int _TotalCapstoneProjects;
        private int _TotalProfileBuilding;
        private int _TotalWaterfallModel;
        private int _TotalAgileScrumModel;
        private int _TotalBAExposure;
        private int _TotalMocks;
        private int _TotalResume;
        private int _TotalInterviewReady;
        private int _TotalPreparation;

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

        public int? NurturingProcessStageStatusId
        {
            get
            {
                return _NurturingProcessStageStatusId;
            }

            set
            {
                _NurturingProcessStageStatusId = value;
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

        public bool IsNurturingProcessStageStart
        {
            get
            {
                return _IsNurturingProcessStageStart;
            }

            set
            {
                _IsNurturingProcessStageStart = value;
            }
        }

        public bool IsNurturingProcessStageExit
        {
            get
            {
                return _IsNurturingProcessStageExit;
            }

            set
            {
                _IsNurturingProcessStageExit = value;
            }
        }

        public DateTime StageStartOn
        {
            get
            {
                return _StageStartOn;
            }

            set
            {
                _StageStartOn = value;
            }
        }

        public DateTime? StageExitOn
        {
            get
            {
                return _StageExitOn;
            }

            set
            {
                _StageExitOn = value;
            }
        }

        public string ParticipantName
        {
            get
            {
                return ParticipantName1;
            }

            set
            {
                ParticipantName1 = value;
            }
        }

        public string ParticipantName1
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

        public int TotalBAConceptsRevision
        {
            get
            {
                return _TotalBAConceptsRevision;
            }

            set
            {
                _TotalBAConceptsRevision = value;
            }
        }

        public int TotalCapstoneProjects
        {
            get
            {
                return _TotalCapstoneProjects;
            }

            set
            {
                _TotalCapstoneProjects = value;
            }
        }

        public int TotalProfileBuilding
        {
            get
            {
                return _TotalProfileBuilding;
            }

            set
            {
                _TotalProfileBuilding = value;
            }
        }

        public int TotalWaterfallModel
        {
            get
            {
                return _TotalWaterfallModel;
            }

            set
            {
                _TotalWaterfallModel = value;
            }
        }

        public int TotalAgileScrumModel
        {
            get
            {
                return _TotalAgileScrumModel;
            }

            set
            {
                _TotalAgileScrumModel = value;
            }
        }

        public int TotalBAExposure
        {
            get
            {
                return _TotalBAExposure;
            }

            set
            {
                _TotalBAExposure = value;
            }
        }

        public int TotalMocks
        {
            get
            {
                return _TotalMocks;
            }

            set
            {
                _TotalMocks = value;
            }
        }

        public int TotalResume
        {
            get
            {
                return _TotalResume;
            }

            set
            {
                _TotalResume = value;
            }
        }

        public int TotalInterviewReady
        {
            get
            {
                return _TotalInterviewReady;
            }

            set
            {
                _TotalInterviewReady = value;
            }
        }

        public int TotalPreparation
        {
            get
            {
                return _TotalPreparation;
            }

            set
            {
                _TotalPreparation = value;
            }
        }

        public clsNurturingProcessStageStatus()
        {
            DBLayer = new DataAccessLayerHelper.clsNurturingProcessStageStatusData();
        }
        public void AddUpdate(clsNurturingProcessStageStatus obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsNurturingProcessStageStatus Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public clsNurturingProcessStageStatus LoadGetDuration(int Id)
        {
            return DBLayer.LoadGetDuration(Id);
        }
        public clsNurturingProcessStageStatus LoadNurturingProcessStageStatusId(int ParticipantId, int NurturingProcessStageId)
        {
            return DBLayer.LoadNurturingProcessStageStatusId(ParticipantId, NurturingProcessStageId);
        }

        public List<clsNurturingProcessStageStatus> LoadAll(clsNurturingProcessStageStatus obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Exit(int Id)
        {
            DBLayer.Exit(Id);
        }
        public int LoadNurturingProcessStageStatusValidation(clsNurturingProcessStageStatus obj)
        {
            return DBLayer.LoadNurturingProcessStageStatusValidation(obj);
        }
        public clsNurturingProcessStageStatus NurturingDashboardCount(clsNurturingProcessStageStatus obj)
        {
            return DBLayer.NurturingDashboardCount(obj);
        }
    }
}
