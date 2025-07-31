using DataAccessLayerHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace BusinessLayer
{
    public class clsHrProcessStageTaskAccess
    {
        clsHrProcessStageTaskAccessData DBLayer;

      
        private string _keywords; 
        private int? _NurturingProcessStageTaskAccessId;
        private int _NurturingProcessStageTaskId;
        private string _NurturingProcessStageTaskName;
        private int _NurturingProcessStageId;
        private string _NurturingProcessStageName;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private string _SendAssignedFeaturesToEmployee;





        private int _SNo;
        private int? _HrProcessStageTaskAccessId;
        private int _HrProcessStageTaskId;
        private int? _CreatedBy;
        private int? _ModifiedBy;
        private string _CreatedByname;
        private string _ModifiedByname;
        private DateTime? _ModifiedOn;
        private int _TaskPriority;
        private int _EmployeeId;
        private string _Employee;
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

        public int? HrProcessStageTaskAccessId { get => _HrProcessStageTaskAccessId; set => _HrProcessStageTaskAccessId = value; }
        public int HrProcessStageTaskId { get => _HrProcessStageTaskId; set => _HrProcessStageTaskId = value; }
        public int HrProcessStageId { get => _HrProcessStageId; set => _HrProcessStageId = value; }
        public string HrProcessStageName { get => _HrProcessStageName; set => _HrProcessStageName = value; }
        public string HrProcessStageTaskName { get => _HrProcessStageTaskName; set => _HrProcessStageTaskName = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public string CreatedByname { get => _CreatedByname; set => _CreatedByname = value; }
        public string ModifiedByname { get => _ModifiedByname; set => _ModifiedByname = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public int? ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }

        public clsHrProcessStageTaskAccess()
        {
            DBLayer = new DataAccessLayerHelper.clsHrProcessStageTaskAccessData();
        }
        public void AddUpdate(clsHrProcessStageTaskAccess obj)
        {
            DBLayer.AddUpdate(obj);

        }

        public List<clsHrProcessStageTaskAccess> LoadAll(clsHrProcessStageTaskAccess obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public clsHrProcessStageTaskAccess Load(int Id)
        {
            return DBLayer.Load(Id);
        }


        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

        //public int FeaturePageValidation(clsHrProcessStageTaskAccess obj)
        //{
        //    return DBLayer.FeaturePageValidation(obj);
        //}


    }
}
