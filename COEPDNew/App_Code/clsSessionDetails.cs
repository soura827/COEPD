using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLayer
{


    public class clsSessionDetails
    {

        
        DataAccessLayerHelper.clsSessionDetailsData DBLayer;
        private int _SNo;
        private string _Fullname;
        private int? _SessionTypeId;
        private string _SessionName;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;



       

        public int? SessionTypeId { get => _SessionTypeId; set => _SessionTypeId = value; }
        public string SessionName { get => _SessionName; set => _SessionName = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public int ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public int SNo { get => _SNo; set => _SNo = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }

        public clsSessionDetails()
        {
            DBLayer = new DataAccessLayerHelper.clsSessionDetailsData();
        }
        public void AddUpdate(clsSessionDetails obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public List<clsSessionDetails> LoadAll(clsSessionDetails obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public clsSessionDetails Load(int id)
        {
            return DBLayer.Load(id);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }

    }
}