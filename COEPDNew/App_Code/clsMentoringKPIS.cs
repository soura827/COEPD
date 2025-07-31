using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace BusinessLayer
{
    public class clsMentoringKPIS
    {
        DataAccessLayerHelper.clsMentoringKPISData DBLayer;

        private int _Sno;
        private int _KPIsId;
        private int? _MentorId;
        private int _EmployeeId;
        private int _BranchId;
        private int _DesignationId;
        private string _KPIName;
        private int _Tragets;
        private int? _CreatedBy;
        private int _ModifiedBy;
        private DateTime _CreatedOn;
        private DateTime? _ModifiedOn;
        private bool _IsActive;
        private bool _IsDeleted;
        private string _CreatedName;
        private string _ModifiedName;
        private int _KPIId;
        private string _Employee;
        private string _Branch;
        private string _Designation;
        private int _UserId;

        public int KPIsId { get => _KPIsId; set => _KPIsId = value; }
        public int Sno { get => _Sno; set => _Sno = value; }
        public int EmployeeId { get => _EmployeeId; set => _EmployeeId = value; }
        public int BranchId { get => _BranchId; set => _BranchId = value; }
        public string KPIName { get => _KPIName; set => _KPIName = value; }
        public int Tragets { get => _Tragets; set => _Tragets = value; }
    
        public int DesignationId { get => _DesignationId; set => _DesignationId = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public int ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public string CreatedName { get => _CreatedName; set => _CreatedName = value; }
        public string ModifiedName { get => _ModifiedName; set => _ModifiedName = value; }
        public int KPIId { get => _KPIId; set => _KPIId = value; }
        public string Employee { get => _Employee; set => _Employee = value; }
        public string Branch { get => _Branch; set => _Branch = value; }
        public string Designation { get => _Designation; set => _Designation = value; }
        public int? MentorId { get => _MentorId; set => _MentorId = value; }
        public int UserId { get => _UserId; set => _UserId = value; }

        public clsMentoringKPIS()
        {
            DBLayer = new DataAccessLayerHelper.clsMentoringKPISData();
        }
        public void AddUpdate(clsMentoringKPIS obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public List<clsMentoringKPIS> LoadALL(clsMentoringKPIS obj)
        {
            return DBLayer.LoadALL(obj);
        }

        public clsMentoringKPIS Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public clsMentoringKPIS  LoadMentor(int Id)
        {
            return DBLayer.LoadMentor(Id);
        }
        public List<clsMentoringKPIS> LoadAllMentor(clsMentoringKPIS obj)
        {
            return DBLayer.LoadAllMentor(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

    }
}