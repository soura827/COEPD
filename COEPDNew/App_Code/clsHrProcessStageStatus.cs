using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;




namespace BusinessLayer
{
    public class clsHrProcessStageStatus
    {
        DataAccessLayerHelper.clsHrProcessStageStatusData DBLayer;
        private int _SNo;
        private int? _HrProcessStageStatusId;
        private int _ParticipantId;
        private int _HrProcessStageId;
        private string _HrProcessStageName;
        private int _Weightage;
        private int _TimeFrame;
        private bool _IsHrProcessStageStart;
        private bool _IsHrProcessStageExit;
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

        public int SNo { get => _SNo; set => _SNo = value; }
        public int? HrProcessStageStatusId { get => _HrProcessStageStatusId; set => _HrProcessStageStatusId = value; }
        public int ParticipantId { get => _ParticipantId; set => _ParticipantId = value; }
        public int HrProcessStageId { get => _HrProcessStageId; set => _HrProcessStageId = value; }
        public string HrProcessStageName { get => _HrProcessStageName; set => _HrProcessStageName = value; }
        public int Weightage { get => _Weightage; set => _Weightage = value; }
        public int TimeFrame { get => _TimeFrame; set => _TimeFrame = value; }
        public bool IsHrProcessStageStart { get => _IsHrProcessStageStart; set => _IsHrProcessStageStart = value; }
        public bool IsHrProcessStageExit { get => _IsHrProcessStageExit; set => _IsHrProcessStageExit = value; }
        public DateTime StageStartOn { get => _StageStartOn; set => _StageStartOn = value; }
        public DateTime? StageExitOn { get => _StageExitOn; set => _StageExitOn = value; }
        public string ParticipantName { get => _ParticipantName; set => _ParticipantName = value; }
        public int TotalBAConceptsRevision { get => _TotalBAConceptsRevision; set => _TotalBAConceptsRevision = value; }
        public int TotalCapstoneProjects { get => _TotalCapstoneProjects; set => _TotalCapstoneProjects = value; }
        public int TotalProfileBuilding { get => _TotalProfileBuilding; set => _TotalProfileBuilding = value; }
        public int TotalWaterfallModel { get => _TotalWaterfallModel; set => _TotalWaterfallModel = value; }
        public int TotalAgileScrumModel { get => _TotalAgileScrumModel; set => _TotalAgileScrumModel = value; }
        public int TotalBAExposure { get => _TotalBAExposure; set => _TotalBAExposure = value; }
        public int TotalMocks { get => _TotalMocks; set => _TotalMocks = value; }
        public int TotalResume { get => _TotalResume; set => _TotalResume = value; }
        public int TotalInterviewReady { get => _TotalInterviewReady; set => _TotalInterviewReady = value; }
        public int TotalPreparation { get => _TotalPreparation; set => _TotalPreparation = value; }
        public clsHrProcessStageStatus()
        {
            DBLayer = new DataAccessLayerHelper.clsHrProcessStageStatusData();
        }
        public void AddUpdate(clsHrProcessStageStatus obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsHrProcessStageStatus Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public clsHrProcessStageStatus LoadGetDuration(int Id)
        {
            return DBLayer.LoadGetDuration(Id);
        }
        public clsHrProcessStageStatus LoadHrProcessStageStatusId(int ParticipantId, int HrProcessStageId)
        {
            return DBLayer.LoadHrProcessStageStatusId(ParticipantId, HrProcessStageId);
        }

        public List<clsHrProcessStageStatus> LoadAll(clsHrProcessStageStatus obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Exit(int Id)
        {
            DBLayer.Exit(Id);
        }
        public int LoadHrProcessStageStatusValidation(clsHrProcessStageStatus obj)
        {
            return DBLayer.LoadHrProcessStageStatusValidation(obj);
        }
        //public clsHrProcessStageStatus HrDashboardCount(clsHrProcessStageStatus obj)
        //{
        //    return DBLayer.HrDashboardCount(obj);
        //}
    }
}
