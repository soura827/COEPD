using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLayer
{
    public class clsKPIMentorPlacement
    {
        DataAccessLayerHelper.clsKPIMentorPlacementData DBLayer;

        private int _Sno;
        private int? _EmployeeKPIId;
        private string _Employee;
        private int _DesignationId;
        private int _KPIApplicableToId;
        private string _KPIName;
        private int _MonthlyTarget;
        private int _Achieved;
        private int? _CreatedBy;
        private int _ModifiedBy;
        private DateTime _CreatedOn;
        private DateTime? _ModifiedOn;
        private bool _IsActive;
        private bool _IsDeleted;
        private string _CreatedName;
        private string _ModifiedName;
        private string _Fullname;
        private string _Designation;
        private int _KPIId;
        private string _KPIApplicableTo;
        private int _UserId;
        private int _EmployeeId;



        public int Sno { get => _Sno; set => _Sno = value; }
        public int? EmployeeKPIId { get => _EmployeeKPIId; set => _EmployeeKPIId = value; }
        public string Employee { get => _Employee; set => _Employee = value; }
        public int DesignationId { get => _DesignationId; set => _DesignationId = value; }
        public int KPIApplicableToId { get => _KPIApplicableToId; set => _KPIApplicableToId = value; }
        public string KPIName { get => _KPIName; set => _KPIName = value; }
        public int MonthlyTarget { get => _MonthlyTarget; set => _MonthlyTarget = value; }
        public int Achieved { get => _Achieved; set => _Achieved = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public int ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public string CreatedName { get => _CreatedName; set => _CreatedName = value; }
        public string ModifiedName { get => _ModifiedName; set => _ModifiedName = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }
        public string Designation { get => _Designation; set => _Designation = value; }
        public int KPIId { get => _KPIId; set => _KPIId = value; }
        public string KPIApplicableTo { get => _KPIApplicableTo; set => _KPIApplicableTo = value; }
        public int UserId { get => _UserId; set => _UserId = value; }
        public int EmployeeId { get => _EmployeeId; set => _EmployeeId = value; }

        public clsKPIMentorPlacement()
        {
            DBLayer = new DataAccessLayerHelper.clsKPIMentorPlacementData();
        }
        public void AddUpdate(clsKPIMentorPlacement obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsKPIMentorPlacement Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsKPIMentorPlacement> LoadAll(clsKPIMentorPlacement obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public clsKPIMentorPlacement LoadUsers(int Id)
        {
            return DBLayer.LoadUsers(Id);
        }
        public List<clsKPIMentorPlacement> LoadAllUsers(clsKPIMentorPlacement obj)
        {
            return DBLayer.LoadAllUsers(obj);
        }
            public void Remove(int id)
        {
            DBLayer.Remove(id);
        }

    }
}