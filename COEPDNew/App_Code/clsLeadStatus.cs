using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsLeadStatus
    {
        DataAccessLayerHelper.clsLeadStatusData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _LeadStatusId;
        private string _LeadStatus;
        private string _Description;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;

        public int SNo
        {
            get { return _SNo; }
            set { _SNo = value; }
        }
        public string keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }
        public int? LeadStatusId
        {
            get { return _LeadStatusId; }
            set { _LeadStatusId = value; }
        }
        public string LeadStatus
        {
            get { return _LeadStatus; }
            set { _LeadStatus = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public bool IsActive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
        }
        public bool IsDeleted
        {
            get { return _IsDeleted; }
            set { _IsDeleted = value; }
        }
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { _CreatedOn = value; }
        }
        public int? CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }

        public clsLeadStatus()
        {
            DBLayer = new DataAccessLayerHelper.clsLeadStatusData();
        }
        public void AddUpdate(clsLeadStatus obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsLeadStatus Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsLeadStatus> LoadAll(clsLeadStatus obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}