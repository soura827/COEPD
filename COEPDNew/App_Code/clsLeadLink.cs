using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsLeadLink
    {
        DataAccessLayerHelper.clsLeadLinkData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _LeadLinkId;
        private string _LeadLink;
        private int _LeadId;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private string _Username;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
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
        public int? LeadLinkId
        {
            get { return _LeadLinkId; }
            set { _LeadLinkId = value; }
        }
        public string LeadLink
        {
            get { return _LeadLink; }
            set { _LeadLink = value; }
        }
        public int LeadId
        {
            get { return _LeadId; }
            set { _LeadId = value; }
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

        public clsLeadLink()
        {
            DBLayer = new DataAccessLayerHelper.clsLeadLinkData();
        }

        public void AddUpdate(clsLeadLink obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsLeadLink Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsLeadLink> LoadAll(clsLeadLink obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
