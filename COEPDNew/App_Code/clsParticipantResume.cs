using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsParticipantResume
    {
        DataAccessLayerHelper.clsParticipantResumeData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _ParticipantResumeId;
        private string _ParticipantResume;
        private int _ParticipantId;
        private string _Participant;
        private int _ApprovedBy;
        private string _Approved;
        private bool? _IsApproved;
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

        public int? ParticipantResumeId
        {
            get { return _ParticipantResumeId; }
            set { _ParticipantResumeId = value; }
        }

        public string ParticipantResume
        {
            get { return _ParticipantResume; }
            set { _ParticipantResume = value; }
        }

        public string Participant
        {
            get { return _Participant; }
            set { _Participant = value; }
        }
        public int ParticipantId
        {
            get { return _ParticipantId; }
            set { _ParticipantId = value; }
        }

        public int ApprovedBy
        {
            get { return _ApprovedBy; }
            set { _ApprovedBy = value; }
        }

        public string Approved
        {
            get { return _Approved; }
            set { _Approved = value; }
        }

        public bool? IsApproved
        {
            get { return _IsApproved; }
            set { _IsApproved = value; }
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

        public clsParticipantResume()
        {
            DBLayer = new DataAccessLayerHelper.clsParticipantResumeData();
        }
        public void AddUpdate(clsParticipantResume obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsParticipantResume Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsParticipantResume> LoadAll(clsParticipantResume obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}