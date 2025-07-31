using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsLeadSource
    {
        DataAccessLayerHelper.clsLeadSourceData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _LeadSourceId;
        private string _LeadSource;
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
        public int? LeadSourceId
        {
            get { return _LeadSourceId; }
            set { _LeadSourceId = value; }
        }
        public string LeadSource
        {
            get { return _LeadSource; }
            set { _LeadSource = value; }
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

        public clsLeadSource()
        {
            DBLayer = new DataAccessLayerHelper.clsLeadSourceData();
        }
        public void AddUpdate(clsLeadSource obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsLeadSource Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsLeadSource> LoadAll(clsLeadSource obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}