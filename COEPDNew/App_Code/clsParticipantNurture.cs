using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsParticipantNurture
    {
        DataAccessLayerHelper.clsParticipantNurtureData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _ParticipantNurtureId;
        private string _ParticipantNurture;
        private int _ParticipantId;
        private string _Participant;
        private string _Email;
        private string _Mobile;
        private string _Location;
        private DateTime _StartDate;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private string _Username;
        private int? _EmployeeId;
        private string _Employee;
        private int _ParentParticipantNurtureId;
        private int _StatusId;

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
        public int? ParticipantNurtureId
        {
            get { return _ParticipantNurtureId; }
            set { _ParticipantNurtureId = value; }
        }
        public string ParticipantNurture
        {
            get { return _ParticipantNurture; }
            set { _ParticipantNurture = value; }
        }
        public int ParticipantId
        {
            get { return _ParticipantId; }
            set { _ParticipantId = value; }
        }

        public string Participant
        {
            get { return _Participant; }
            set { _Participant = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
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
        public int? EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }

        public string Employee
        {
            get { return _Employee; }
            set { _Employee = value; }
        }
        public int ParentParticipantNurtureId
        {
            get { return _ParentParticipantNurtureId; }
            set { _ParentParticipantNurtureId = value; }
        }
        public int StatusId
        {
            get { return _StatusId; }
            set { _StatusId = value; }
        }

        public clsParticipantNurture()
        {
            DBLayer = new DataAccessLayerHelper.clsParticipantNurtureData();
        }

        public void AddUpdate(clsParticipantNurture obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsParticipantNurture Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsParticipantNurture> LoadAll(clsParticipantNurture obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public void UpdateEmpId(clsParticipantNurture obj)
        {
            DBLayer.UpdateEmpId(obj);
        }

        public List<clsParticipantNurture> GetLatestRecord(clsParticipantNurture obj)
        {
            return DBLayer.GetLatestRecord(obj);
        }
    }
}
