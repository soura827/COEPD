using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace BusinessLayer
{
    public class clsHrTask
    {
        DataAccessLayerHelper.clsHrTaskData DBLayer;

        private int _SNo;
        private int? _NurturingTaskId;
        private int _NurturingProcessStageId;
        private int _NurturingProcessStageTaskId;
        private string _SenderImagePath;
        private int _TargetDateInterval;
        private string _TaskInputs;
        private bool _IsRevised;
        private DateTime _RevisedOn;
        private int _RevisedBy;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private int _ModifiedBy;
        private string _Fullname;
        private string _Modifiedname;
        private DateTime? _ModifiedOn;
        private string _NurturingProcessStageName;
        private string _NurturingProcessStageTaskName;


        private int? _HrTaskId;
        private int _HrProcessStageTaskId;
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

        public bool IsRevised
        {
            get
            {
                return _IsRevised;
            }

            set
            {
                _IsRevised = value;
            }
        }

        public DateTime RevisedOn
        {
            get
            {
                return _RevisedOn;
            }

            set
            {
                _RevisedOn = value;
            }
        }

        public int RevisedBy
        {
            get
            {
                return _RevisedBy;
            }

            set
            {
                _RevisedBy = value;
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

        public int TargetDateInterval
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

        public string Modifiedname
        {
            get
            {
                return _Modifiedname;
            }

            set
            {
                _Modifiedname = value;
            }
        }

        public int? HrTaskId { get => _HrTaskId; set => _HrTaskId = value; }
        public int HrProcessStageTaskId { get => _HrProcessStageTaskId; set => _HrProcessStageTaskId = value; }
        public int HrProcessStageId { get => _HrProcessStageId; set => _HrProcessStageId = value; }
        public string HrProcessStageName { get => _HrProcessStageName; set => _HrProcessStageName = value; }
        public string HrProcessStageTaskName { get => _HrProcessStageTaskName; set => _HrProcessStageTaskName = value; }

        public clsHrTask()
        {
            DBLayer = new DataAccessLayerHelper.clsHrTaskData();
        }
        public void AddUpdate(clsHrTask obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsHrTask Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsHrTask> LoadAll(clsHrTask obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

        public int LoadNurturingTaskValidation(clsHrTask obj)
        {
            return DBLayer.LoadNurturingTaskValidation(obj);
        }
    }
}
