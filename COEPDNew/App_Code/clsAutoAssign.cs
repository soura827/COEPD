using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsAutoAssign
    {
        DataAccessLayerHelper.clsAutoAssignData DBLayer;

        private int _SNo;
        private int? _NurturingAutoAssignId;
        private int _NurturingProcessStageId;
        private int _NurturingProcessStageTaskId;
        private string _SenderImagePath;
        private int _TargetDateInterval;
        private string _Notes;
        private bool _IsRevised;
        private DateTime _RevisedOn;
        private int _RevisedBy;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private string _NurturingProcessStageName;
        private string _NurturingProcessStageTaskName;

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

        public DateTime ModifiedOn
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
        public int? NurturingAutoAssignId
        {
            get
            {
                return _NurturingAutoAssignId;
            }

            set
            {
                _NurturingAutoAssignId = value;
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

        public clsAutoAssign()
        {
            DBLayer = new DataAccessLayerHelper.clsAutoAssignData();
        }
        public void AddUpdate(clsAutoAssign obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsAutoAssign Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsAutoAssign> LoadAll(clsAutoAssign obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}