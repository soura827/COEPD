using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;




namespace BusinessLayer
{
    public class clsDemo
    {
        DataAccessLayerHelper.clsDemoData DBLayer;
        private int _SNo;
        private int? _DemoId;
        private int _DemoTrainerName;
        private DateTime? _DemoDateTime;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private DateTime? _ModifiedOn;
        private int? _ModifiedBy;
        private string _CreatedByName;
        private string _ModifiedByName;
        private string _DemoTrainerFullName;
        private DateTime? _Date;

        public int SNo { get => _SNo; set => _SNo = value; }
        public int? DemoId { get => _DemoId; set => _DemoId = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
      
        public int? ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public DateTime? DemoDateTime { get => _DemoDateTime; set => _DemoDateTime = value; }
        public int CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public int DemoTrainerName { get => _DemoTrainerName; set => _DemoTrainerName = value; }
        public string CreatedByName { get => _CreatedByName; set => _CreatedByName = value; }
        public string ModifiedByName { get => _ModifiedByName; set => _ModifiedByName = value; }
        public string DemoTrainerFullName { get => _DemoTrainerFullName; set => _DemoTrainerFullName = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public DateTime? Date { get => _Date; set => _Date = value; }

        public clsDemo()
        {
            DBLayer = new DataAccessLayerHelper.clsDemoData();
        }
        public void AddUpdate(clsDemo obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsDemo Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsDemo> LoadAll(clsDemo obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public void AddUpdate1(clsDemo obj)
        {
            DBLayer.AddUpdate(obj);
        }
    }



}