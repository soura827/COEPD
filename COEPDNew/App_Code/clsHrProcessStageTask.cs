using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace BusinessLayer
{


    public class clsHrProcessStageTask
    {
        
        DataAccessLayerHelper.clsHrProcessStageTaskData DBLayer;
        private int _SNo;
        private int? _HrProcessStageTaskId;
        private string _HrProcessStageTaskName;
        private int _HrProcessStageId;
        private string _HrProcessStageName;
        private int _Weightage;
        private int _TimeFrame;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime? _ModifiedOn;
        private string _CreatedName;
        private string _ModifiedName;
        private int _TotalBAConceptsRevision;
        private int _TotalCapstoneProjects;
        private int _TotalProfileBuilding;
        private int _TotalWaterfallModel;
        private int _TotalAgileScrumModel;
        private int _TotalBAExposure;
        private int _TotalMocks;
        private int _TotalResume;
        private int _TotalInterviewReady;
        private int _CountBAConceptsRevision;
        private int _CountCapstoneProjects;
        private int _CountProfileBuilding;
        private int _CountWaterfallModel;
        private int _CountAgileScrumModel;
        private int _CountBAExposure;
        private int _CountMocks;
        private int _CountResume;
        private int _CountInterviewReady;
        private int _ParticipantId;
        private int _EmployeeId;
        private int _TotalPreparation;
        private int _CountPreparation;
        private int _StatusCode;
        private int _HrMock;
        private int _TotalHrMock;
        private int _StudentInteractions; 
        private int _TotalStudentInteractions;

        public int SNo { get => _SNo; set => _SNo = value; }
        public int? HrProcessStageTaskId { get => _HrProcessStageTaskId; set => _HrProcessStageTaskId = value; }
        public string HrProcessStageTaskName { get => _HrProcessStageTaskName; set => _HrProcessStageTaskName = value; }
        public int HrProcessStageId { get => _HrProcessStageId; set => _HrProcessStageId = value; }
        public string HrProcessStageName { get => _HrProcessStageName; set => _HrProcessStageName = value; }
        public int Weightage { get => _Weightage; set => _Weightage = value; }
        public int TimeFrame { get => _TimeFrame; set => _TimeFrame = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public string CreatedName { get => _CreatedName; set => _CreatedName = value; }
        public string ModifiedName { get => _ModifiedName; set => _ModifiedName = value; }
        public int TotalBAConceptsRevision { get => _TotalBAConceptsRevision; set => _TotalBAConceptsRevision = value; }
        public int TotalCapstoneProjects { get => _TotalCapstoneProjects; set => _TotalCapstoneProjects = value; }
        public int TotalProfileBuilding { get => _TotalProfileBuilding; set => _TotalProfileBuilding = value; }
        public int TotalWaterfallModel { get => _TotalWaterfallModel; set => _TotalWaterfallModel = value; }
        public int TotalAgileScrumModel { get => _TotalAgileScrumModel; set => _TotalAgileScrumModel = value; }
        public int TotalBAExposure { get => _TotalBAExposure; set => _TotalBAExposure = value; }
        public int TotalMocks { get => _TotalMocks; set => _TotalMocks = value; }
        public int TotalResume { get => _TotalResume; set => _TotalResume = value; }
        public int TotalInterviewReady { get => _TotalInterviewReady; set => _TotalInterviewReady = value; }
        public int CountBAConceptsRevision { get => _CountBAConceptsRevision; set => _CountBAConceptsRevision = value; }
        public int CountCapstoneProjects { get => _CountCapstoneProjects; set => _CountCapstoneProjects = value; }
        public int CountProfileBuilding { get => _CountProfileBuilding; set => _CountProfileBuilding = value; }
        public int CountWaterfallModel { get => _CountWaterfallModel; set => _CountWaterfallModel = value; }
        public int CountAgileScrumModel { get => _CountAgileScrumModel; set => _CountAgileScrumModel = value; }
        public int CountBAExposure { get => _CountBAExposure; set => _CountBAExposure = value; }
        public int CountMocks { get => _CountMocks; set => _CountMocks = value; }
        public int CountResume { get => _CountResume; set => _CountResume = value; }
        public int CountInterviewReady { get => _CountInterviewReady; set => _CountInterviewReady = value; }
        public int ParticipantId { get => _ParticipantId; set => _ParticipantId = value; }
        public int EmployeeId { get => _EmployeeId; set => _EmployeeId = value; }
        public int TotalPreparation { get => _TotalPreparation; set => _TotalPreparation = value; }
        public int CountPreparation { get => _CountPreparation; set => _CountPreparation = value; }
        public int StatusCode { get => _StatusCode; set => _StatusCode = value; }
        public int HrMock { get => _HrMock; set => _HrMock = value; }
        public int TotalHrMock { get => _TotalHrMock; set => _TotalHrMock = value; }
        public int StudentInteractions { get => _StudentInteractions; set => _StudentInteractions = value; }
        public int TotalStudentInteractions { get => _TotalStudentInteractions; set => _TotalStudentInteractions = value; }

        public clsHrProcessStageTask()
        {
            DBLayer = new DataAccessLayerHelper.clsHrProcessStageTaskData();
        }
        public void AddUpdate(clsHrProcessStageTask obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public int LoadHrProcessStageTaskValidation(clsHrProcessStageTask obj)
        {
            return DBLayer.LoadHrProcessStageTaskValidation(obj);
        }
        public List<clsHrProcessStageTask> LoadAll(clsHrProcessStageTask obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public clsHrProcessStageTask Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

        public clsHrProcessStageTask HrDashboardCount(clsHrProcessStageTask Obj)
        {
            return DBLayer.HrDashboardCount(Obj);
        }
        public List<clsHrProcessStageTask> LoadAllAvilable(clsHrProcessStageTask obj)
        {
            return DBLayer.LoadAllAvilable(obj);
        }


    }
   
}

