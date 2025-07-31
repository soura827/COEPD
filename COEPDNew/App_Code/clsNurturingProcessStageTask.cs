using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsNurturingProcessStageTask
    {
        DataAccessLayerHelper.clsNurturingProcessStageTaskData DBLayer;
        private int _SNo;
        private int? _NurturingProcessStageTaskId;
        private string _NurturingProcessStageTaskName;
        private int _NurturingProcessStageId;
        private string _NurturingProcessStageName;
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

        public string CreatedName
        {
            get
            {
                return _CreatedName;
            }

            set
            {
                _CreatedName = value;
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

        public int CountBAConceptsRevision
        {
            get
            {
                return _CountBAConceptsRevision;
            }

            set
            {
                _CountBAConceptsRevision = value;
            }
        }

        public int CountCapstoneProjects
        {
            get
            {
                return _CountCapstoneProjects;
            }

            set
            {
                _CountCapstoneProjects = value;
            }
        }

        public int CountProfileBuilding
        {
            get
            {
                return _CountProfileBuilding;
            }

            set
            {
                _CountProfileBuilding = value;
            }
        }

        public int CountWaterfallModel
        {
            get
            {
                return _CountWaterfallModel;
            }

            set
            {
                _CountWaterfallModel = value;
            }
        }

        public int CountAgileScrumModel
        {
            get
            {
                return _CountAgileScrumModel;
            }

            set
            {
                _CountAgileScrumModel = value;
            }
        }

        public int CountBAExposure
        {
            get
            {
                return _CountBAExposure;
            }

            set
            {
                _CountBAExposure = value;
            }
        }

        public int CountMocks
        {
            get
            {
                return _CountMocks;
            }

            set
            {
                _CountMocks = value;
            }
        }

        public int CountResume
        {
            get
            {
                return _CountResume;
            }

            set
            {
                _CountResume = value;
            }
        }

        public int CountInterviewReady
        {
            get
            {
                return _CountInterviewReady;
            }

            set
            {
                _CountInterviewReady = value;
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

        public int CountPreparation
        {
            get
            {
                return _CountPreparation;
            }

            set
            {
                _CountPreparation = value;
            }
        }

        public int StatusCode { get => _StatusCode; set => _StatusCode = value; }

        public clsNurturingProcessStageTask()
        {
            DBLayer = new DataAccessLayerHelper.clsNurturingProcessStageTaskData();
        }
        public void AddUpdate(clsNurturingProcessStageTask obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsNurturingProcessStageTask Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsNurturingProcessStageTask> LoadAll(clsNurturingProcessStageTask obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public int LoadNurturingProcessStageTaskValidation(clsNurturingProcessStageTask obj)
        {
            return DBLayer.LoadNurturingProcessStageTaskValidation(obj);
        }
        public clsNurturingProcessStageTask NurturingDashboardCount(clsNurturingProcessStageTask Obj)
        {
            return DBLayer.NurturingDashboardCount(Obj);
        }
        public List<clsNurturingProcessStageTask> LoadAllAvilable(clsNurturingProcessStageTask obj)
        {
            return DBLayer.LoadAllAvilable(obj);
        }
    }
}
