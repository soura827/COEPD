using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsNurturingProcessStage
    {
        DataAccessLayerHelper.clsNurturingProcessStageData DBLayer;
        private int _SNo;
        private int? _NurturingProcessStageId;
        private string _NurturingProcessStageName;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime? _ModifiedOn;
        private string _CreatedName;
        private string _ModifiedName;

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

        public int? NurturingProcessStageId
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

        public clsNurturingProcessStage()
        {
            DBLayer = new DataAccessLayerHelper.clsNurturingProcessStageData();
        }
        public void AddUpdate(clsNurturingProcessStage obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsNurturingProcessStage Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsNurturingProcessStage> LoadAll(clsNurturingProcessStage obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public int LoadNurturingProcessStageValidation(clsNurturingProcessStage obj)
        {
            return DBLayer.LoadNurturingProcessStageValidation(obj);
        }
    }
}
