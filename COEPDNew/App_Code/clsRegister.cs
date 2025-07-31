using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsRegister
    {
        DataAccessLayerHelper.clsRegisterData DBLayer;


        private int _SNo;
        private string _keywords;
        private int? _RegisterId;
        private string _Register;
        private int? _RegisterTypeId;
        private int? _RegisterStatusId;
        private string _PrimaryMobile;
        private string _SecondaryMobile;
        private string _PrimaryEmail;
        private string _SecondaryEmail;
        private string _Address;
        private string _Comments;
        private string _Remarks;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private int? _ParticipantId;
        private string _Participant;
        private int? _EmployeeId;
        private string _Employee;
        private DateTime _Date;
        private DateTime _StartTime;
        private DateTime? _EndTime;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private int _BatchId;
        private int _BatchTypeId;
        private int _LocationId;



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
        public int? RegisterId
        {
            get { return _RegisterId; }
            set { _RegisterId = value; }
        }

        public string Register
        {
            get { return _Register; }
            set { _Register = value; }
        }

        public int? RegisterTypeId
        {
            get { return _RegisterTypeId; }
            set { _RegisterTypeId = value; }
        }

        public int? RegisterStatusId
        {
            get { return _RegisterStatusId; }
            set { _RegisterStatusId = value; }
        }
        public string PrimaryMobile
        {
            get { return _PrimaryMobile; }
            set { _PrimaryMobile = value; }
        }
        public string SecondaryMobile
        {
            get { return _SecondaryMobile; }
            set { _SecondaryMobile = value; }
        }
        public string PrimaryEmail
        {
            get { return _PrimaryEmail; }
            set { _PrimaryEmail = value; }
        }
        public string SecondaryEmail
        {
            get { return _SecondaryEmail; }
            set { _SecondaryEmail = value; }
        }


        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Comments
        {
            get { return _Comments; }
            set { _Comments = value; }
        }
        public string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
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
        public int? ParticipantId
        {
            get { return _ParticipantId; }
            set { _ParticipantId = value; }
        }
        public string Participant
        {
            get { return _Participant; }
            set { _Participant = value; }
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
        public int BatchId
        {
            get { return _BatchId; }
            set { _BatchId = value; }
        }
        public int BatchTypeId
        {
            get { return _BatchTypeId; }
            set { _BatchTypeId = value; }
        }
        public int LocationId
        {
            get { return _LocationId; }
            set { _LocationId = value; }
        }
        public clsRegister()
        {

            DBLayer = new DataAccessLayerHelper.clsRegisterData();
        }
        public void AddUpdate(clsRegister obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsRegister Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsRegister> LoadAll(clsRegister obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public List<clsRegister> LoadAllReports(clsRegister obj)
        {
            return DBLayer.LoadAllReports(obj);
        }
        public List<clsRegister> LoadAllGuestReports(clsRegister obj)
        {
            return DBLayer.LoadAllGuestReports(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

    }
}