using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsAttendParticipant
    {

        DataAccessLayerHelper.clsAttendParticipantData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _AttendParticipantId;
        private int _ParticipantId;
        private string _Participant;
        private int _ReferenceNo;
        private int _BatchId;
        private DateTime _StartDate;
        private DateTime _Date;
        private DateTime _EnterTime;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private DateTime? _FromDate;
        private DateTime? _ToDate;

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
        public int? AttendParticipantId
        {
            get { return _AttendParticipantId; }
            set { _AttendParticipantId = value; }
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

        public int BatchId
        {
            get { return _BatchId; }
            set { _BatchId = value; }
        }

        public int ReferenceNo
        {
            get { return _ReferenceNo; }
            set { _ReferenceNo = value; }
        }
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        public DateTime EnterTime
        {
            get { return _EnterTime; }
            set { _EnterTime = value; }
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
        public DateTime? ModifiedOn
        {
            get { return _ModifiedOn; }
            set { _ModifiedOn = value; }
        }
        public DateTime? FromDate
        {
            get { return _FromDate; }
            set { _FromDate = value; }
        }
        public DateTime? ToDate
        {
            get { return _ToDate; }
            set { _ToDate = value; }
        }


        public clsAttendParticipant()
        {
            DBLayer = new DataAccessLayerHelper.clsAttendParticipantData();
        }

        public void AddUpdate(clsAttendParticipant obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsAttendParticipant Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsAttendParticipant> LoadAll(clsAttendParticipant obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        //public List<clsTimeSheet> LoadAllReports(clsAttendParticipant obj)
        //{
        //    return DBLayer.LoadAllReports(obj);
        //}
    }
}