using DataAccessLayerHelper;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsNurturingProcessStageTaskAccess
    {
        clsNurturingProcessStageTaskAccessData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _NurturingProcessStageTaskAccessId;
        private int _EmployeeId;
        private int _NurturingProcessStageTaskId;
        private string _NurturingProcessStageTaskName;
        private int _NurturingProcessStageId;
        private string _NurturingProcessStageName;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private string _SendAssignedFeaturesToEmployee;
        private int _TaskPriority;
        private string _Employee;

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

        public int? NurturingProcessStageTaskAccessId
        {
            get
            {
                return _NurturingProcessStageTaskAccessId;
            }

            set
            {
                _NurturingProcessStageTaskAccessId = value;
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

        public string SendAssignedFeaturesToEmployee
        {
            get
            {
                return _SendAssignedFeaturesToEmployee;
            }

            set
            {
                _SendAssignedFeaturesToEmployee = value;
            }
        }

        public int TaskPriority
        {
            get
            {
                return TaskPriority1;
            }

            set
            {
                TaskPriority1 = value;
            }
        }

        public int TaskPriority1
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

        public clsNurturingProcessStageTaskAccess()
        {
            DBLayer = new DataAccessLayerHelper.clsNurturingProcessStageTaskAccessData();
        }
        public void AddUpdate(clsNurturingProcessStageTaskAccess obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsNurturingProcessStageTaskAccess Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsNurturingProcessStageTaskAccess> LoadAll(clsNurturingProcessStageTaskAccess obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

        //public int FeaturePageValidation(clsNurturingProcessStageTaskAccess obj)
        //{
        //    return DBLayer.FeaturePageValidation(obj);
        //}


    }
}
