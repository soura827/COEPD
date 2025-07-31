using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsParticipantStatus
    {
        DataAccessLayerHelper.clsParticipantStatusData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _ParticipantStatusId;
        private string _ParticipantStatus;
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
        public int? ParticipantStatusId
        {
            get { return _ParticipantStatusId; }
            set { _ParticipantStatusId = value; }
        }
        public string ParticipantStatus
        {
            get { return _ParticipantStatus; }
            set { _ParticipantStatus = value; }
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

        public clsParticipantStatus()
        {
            DBLayer = new DataAccessLayerHelper.clsParticipantStatusData();
        }
        public void AddUpdate(clsParticipantStatus obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsParticipantStatus Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsParticipantStatus> LoadAll(clsParticipantStatus obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}