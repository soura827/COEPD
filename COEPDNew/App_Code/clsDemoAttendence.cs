using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace BusinessLayer
{
    public class clsDemoAttendence
    {
        DataAccessLayerHelper.clsDemoAttendenceData DBLayer;
        private int _SNo;
        private int? _DemoAttendenceId;
        private int _DemoId;
        private int _LeadId;
        private Boolean _IsInterested;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime? _ModifiedOn;
        private int? _ModifiedBy;
        private string _CreatedByName;
        private string _ModifiedByName;
        private Boolean _IsDemoAttended;
        private DateTime _DemoDateTime;
        private int _DemoTrainerName;
        private string _Employee;
        private string _LeadName;
        public int SNo { get => _SNo; set => _SNo = value; }
        public int? DemoAttendenceId { get => _DemoAttendenceId; set => _DemoAttendenceId = value; }
        public int DemoId { get => _DemoId; set => _DemoId = value; }
        public int LeadId { get => _LeadId; set => _LeadId = value; }
        public bool IsInterested { get => _IsInterested; set => _IsInterested = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public int? ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public string CreatedByName { get => _CreatedByName; set => _CreatedByName = value; }
        public string ModifiedByName { get => _ModifiedByName; set => _ModifiedByName = value; }
        public bool IsDemoAttended { get => _IsDemoAttended; set => _IsDemoAttended = value; }
        public DateTime DemoDateTime { get => _DemoDateTime; set => _DemoDateTime = value; }
        public int DemoTrainerName { get => _DemoTrainerName; set => _DemoTrainerName = value; }
        public string Employee { get => _Employee; set => _Employee = value; }
        public string LeadName { get => _LeadName; set => _LeadName = value; }

        public clsDemoAttendence()
        {
            DBLayer = new DataAccessLayerHelper.clsDemoAttendenceData();
        }
        public void AddUpdate(clsDemoAttendence obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public List<clsDemoAttendence> LoadAll(clsDemoAttendence obj)
        {
            return DBLayer.LoadAll(obj);
        }


        //public clsDemoAttendence Load(int Id)
        //{
        //    return DBLayer.Load(Id);
        //}

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }



}