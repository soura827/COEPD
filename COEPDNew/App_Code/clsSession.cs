using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLayer
{


    public class clsSession
    {

      DataAccessLayerHelper.clsSessionData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _SessionId;
        private int _SessionTypeId;
        private string _SessionName;
        private string _AwarenessSessionName;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private DateTime? _UpComingFromDate;
        private DateTime? _UpComingToDate;
        private DateTime _Date;
        private string _StartTime;
        private string _EndTime;
        private string _Fullname;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _ZoomMeetingId;
        private string _Password;
        private bool _IsAttended;
        private int  _AttendId;
        private int _ParticipantId;
        private string _Participant;
        private int? _ParticipantSessionAttendanceId;
        private string _Mobile ;
        private string _Email;

        private string _TotalSession;
        private int _Attendance;

        private int _EmployeeId;
        private string _Employee;
        private int _SessionEmployeeId;
        private int? _SessionJobMarketId;
        private bool _IsReportingManager;


        public int SNo { get => _SNo; set => _SNo = value; }
        public string Keywords { get => _keywords; set => _keywords = value; }
        public int? SessionId { get => _SessionId; set => _SessionId = value; }
        public string StartTime { get => _StartTime; set => _StartTime = value; }
        public string EndTime { get => _EndTime; set => _EndTime = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public int ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public string SessionName { get => _SessionName; set => _SessionName = value; }
        public string ZoomMeetingId { get => _ZoomMeetingId; set => _ZoomMeetingId = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string AwarenessSessionName { get => _AwarenessSessionName; set => _AwarenessSessionName = value; }
        public bool IsAttended { get => _IsAttended; set => _IsAttended = value; }
        public string HeaderText { get; set; }
        public string DataField { get; set; }
        public bool Visible { get; set; }
        public int AttendId { get => _AttendId; set => _AttendId = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public DateTime? FromDate { get => _FromDate; set => _FromDate = value; }
        public DateTime? ToDate { get => _ToDate; set => _ToDate = value; }
        public int ParticipantId { get => _ParticipantId; set => _ParticipantId = value; }
        public int SessionTypeId { get => _SessionTypeId; set => _SessionTypeId = value; }
        public string Participant { get => _Participant; set => _Participant = value; }
        public int? ParticipantSessionAttendanceId { get => _ParticipantSessionAttendanceId; set => _ParticipantSessionAttendanceId = value; }
        public string Mobile { get => _Mobile; set => _Mobile = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string TotalSession { get => _TotalSession; set => _TotalSession = value; }
        public int Attendance { get => _Attendance; set => _Attendance = value; }
        public int EmployeeId { get => _EmployeeId; set => _EmployeeId = value; }
        public string Employee { get => _Employee; set => _Employee = value; }
        public int SessionEmployeeId { get => _SessionEmployeeId; set => _SessionEmployeeId = value; }
        public int? SessionJobMarketId { get => _SessionJobMarketId; set => _SessionJobMarketId = value; }
        public DateTime? UpComingFromDate { get => _UpComingFromDate; set => _UpComingFromDate = value; }
        public DateTime? UpComingToDate { get => _UpComingToDate; set => _UpComingToDate = value; }
        public bool IsReportingManager { get => _IsReportingManager; set => _IsReportingManager = value; }

        public clsSession()
        {
            DBLayer = new DataAccessLayerHelper.clsSessionData();
        }



        public void AddUpdate(clsSession obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsSession Load(int id)
        {
            return DBLayer.Load(id);
        }
        public List<clsSession> LoadAll(clsSession obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsSession> LoadAllSessionEmployee(clsSession obj)
        {
            return DBLayer.LoadAllSessionEmployee(obj);
        }






        public List<clsSession> LoadForAll(clsSession obj)
        {
            return DBLayer.LoadForAll(obj);
        }



        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }

        public void UpdateAttend(clsSession obj)
        {
            DBLayer.UpdateAttend(obj);
        }

        public void AddUpdateRow(clsSession obj)
        {
            DBLayer.AddUpdateRow(obj);
        }
        public List<clsSession> AttendParticipant(clsSession obj)
        {
            return DBLayer.AttendParticipant(obj);
        }
        public void Add(clsSession obj)      //participant adding to session
        {
            DBLayer.Add(obj);
        }

        public void AddJobMarket(clsSession obj)      //participant adding to session
        {
            DBLayer.AddJobMarket(obj);
        }
        public List<clsSession> SessionParticipantList(clsSession obj)
        {
            return DBLayer.SessionParticipantList(obj);
        }
        public List<clsSession> SessionParticipantListAll(clsSession obj)
        {
            return DBLayer.SessionParticipantListAll(obj);
        }

        public int LoadSessionValidation(clsSession obj)
        {
            return DBLayer.LoadSessionValidation(obj);
        }

        public List<clsSession> Loadfew(clsSession obj)
        {
            return DBLayer.Loadfew(obj);
        }

        public List<clsSession> LoadLess(clsSession obj)
        {
            return DBLayer.LoadLess(obj);
        }

        public List<clsSession> LoadAllParticipant(clsSession obj)
        {
            return DBLayer.LoadAllParticipant(obj);
        }


        public List<clsSession> LoadAllUpComingSession(clsSession obj)
        {
            return DBLayer.LoadAllUpComingSession(obj);
        }



        public List<clsSession> LoadAllJobMarket(clsSession obj)
        {
            return DBLayer.LoadAllJobMarket(obj);
        }
        public List<clsSession> JobMarketLoadAll(clsSession obj)
        {
            return DBLayer.JobMarketLoadAll(obj);
        }

        public clsSession SessionReporting(int Id)
        {
            return DBLayer.SessionReporting(Id);
        }















    }
}
