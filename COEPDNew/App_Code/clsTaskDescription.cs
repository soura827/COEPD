using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsTaskDescription
    {
        DataAccessLayerHelper.clsTaskDescriptionData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _TaskDescriptionId;
        private int _TaskId;
        private string _Task;
        private string _Description;
        private int _EmployeeId;
        private string _Employee;
        private int _AssignedEmployeeId;
        private int _InsertedBy;
        private bool? _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private string _AssignedEmployee;

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



        public string Description
        {
            get
            {
                return _Description;
            }

            set
            {
                _Description = value;
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

        public int AssignedEmployeeId
        {
            get
            {
                return _AssignedEmployeeId;
            }

            set
            {
                _AssignedEmployeeId = value;
            }
        }

        public bool? IsActive
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

        public string AssignedEmployee
        {
            get
            {
                return _AssignedEmployee;
            }

            set
            {
                _AssignedEmployee = value;
            }
        }

        public int? TaskDescriptionId
        {
            get
            {
                return _TaskDescriptionId;
            }

            set
            {
                _TaskDescriptionId = value;
            }
        }

        public int TaskId
        {
            get
            {
                return _TaskId;
            }

            set
            {
                _TaskId = value;
            }
        }

        public string Task
        {
            get
            {
                return _Task;
            }

            set
            {
                _Task = value;
            }
        }

        public int InsertedBy
        {
            get
            {
                return _InsertedBy;
            }

            set
            {
                _InsertedBy = value;
            }
        }

        public clsTaskDescription()
        {
            DBLayer = new DataAccessLayerHelper.clsTaskDescriptionData();
        }

        public void AddUpdate(clsTaskDescription obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsTaskDescription Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsTaskDescription> LoadAll(clsTaskDescription obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}


