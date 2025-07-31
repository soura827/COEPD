using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsParticipantTimeSheet

    {
        DataAccessLayerHelper.clsParticipantTimeSheetData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _TimeSheetId;
        private int _ParticipantId;
        private string _Participant;
        private DateTime _Date;
        private DateTime _StartTime;
        private DateTime? _EndTime;
        private string _Note;
        private int _NurturingId;
        private string _Nurture;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private string _Location;
        private string _Employee;
        private DateTime _StartDate;
        private DateTime? _InternBatchDate;
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
        public int? TimeSheetId
        {
            get { return _TimeSheetId; }
            set { _TimeSheetId = value; }
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
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public DateTime StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }
        public DateTime? EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        }

        public int NurturingId
        {
            get { return _NurturingId; }
            set { _NurturingId = value; }
        }
        public string Nurture
        {
            get { return _Nurture; }
            set { _Nurture = value; }
        }
        public string Note
        {
            get { return _Note; }
            set { _Note = value; }
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

        public string Location
        {
            get
            {
                return _Location;
            }

            set
            {
                _Location = value;
            }
        }

        public string Employee
        {
            get
            {
                return _Employee;
            }

            set
            {
                _Employee = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return _StartDate;
            }

            set
            {
                _StartDate = value;
            }
        }



        public DateTime? InternBatchDate
        {
            get
            {
                return _InternBatchDate;
            }

            set
            {
                _InternBatchDate = value;
            }
        }
        public clsParticipantTimeSheet()
        {
            DBLayer = new DataAccessLayerHelper.clsParticipantTimeSheetData();
        }
        public void AddUpdate(clsParticipantTimeSheet obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsParticipantTimeSheet Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsParticipantTimeSheet> LoadAll(clsParticipantTimeSheet obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public List<clsParticipantTimeSheet> LoadAllReports(clsParticipantTimeSheet obj)
        {
            return DBLayer.LoadAllReports(obj);
        }
    }
}

