using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLayer
{
    public class clsEmployeeStructure
    {
        DataAccessLayerHelper.clsEmployeeStructureData DBLayer;
        private int _SNo;
        private string _Employee;
        private int _EmployeeId;
        private bool? _IsAssigned;
        private int? _ReportingManagerEmployeeId;
        private int _DesignationId;

        public int EmployeeId { get => _EmployeeId; set => _EmployeeId = value; }
        public int SNo { get => _SNo; set => _SNo = value; }
        public string Employee { get => _Employee; set => _Employee = value; }
        public int? ReportingManagerEmployeeId { get => _ReportingManagerEmployeeId; set => _ReportingManagerEmployeeId = value; }
        public bool? IsAssigned { get => _IsAssigned; set => _IsAssigned = value; }
        public int DesignationId { get => _DesignationId; set => _DesignationId = value; }

        public clsEmployeeStructure()
        {
            DBLayer = new DataAccessLayerHelper.clsEmployeeStructureData();
        }
        public void AddUpdate(clsEmployeeStructure obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public List<clsEmployeeStructure> LoadAll(clsEmployeeStructure obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public List<clsEmployeeStructure> LoadAllRE(clsEmployeeStructure obj)
        {
            return DBLayer.LoadAllRE(obj);
        }

        public List<clsEmployeeStructure> LoadAllIsAssigned(clsEmployeeStructure obj)
        {
            return DBLayer.LoadAllIsAssigned(obj);
        }


        //public clsEmployeeStructure Load(int Id)
        //{
        //    return DBLayer.Load(Id);
        //}


        //public List<clsEmployeeStructure> UnAssignedList(clsEmployeeStructure obj)
        //{
        //    return DBLayer.UnAssignedList(obj);
        //}
        //public List<clsEmployeeStructure> Hierarchy(clsEmployeeStructure obj)
        //{
        //    return DBLayer.Hierarchy(obj);
        //}
        //public void Remove(int Id)
        //{
        //    DBLayer.Remove(Id);
        //}
    }
}
