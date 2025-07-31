using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsZoomMeetingAttendance
    {
        DataAccessLayerHelper.clsZoomMeetingAttendanceData DBLayer;
        private int _SNo;
        private string _keywords;
        private int _zoomMeetingId;
        private int? _ZoomMeetingAttendanceId;
        private string _Username;
        private bool _IsZoomMeetingAttended;
        private DateTime? _ZoomMeetingAttendedOn;
        private bool _IsZoomMeetingEnded;
        private DateTime? _ZoomMeetingEndedOn;
        private string _Feedback;
        private DateTime? _FeedbackAddedOn;
        private bool _IsFeedbackAdded;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime? _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private string _FullName;
        private int _UserId;


        public int SNo
        {
            get
            {
                return _SNo;
            }

            set
            {
                _SNo = value;
            }
        }

        public string Keywords
        {
            get
            {
                return _keywords;
            }

            set
            {
                _keywords = value;
            }
        }

        public int ZoomMeetingId
        {
            get
            {
                return _zoomMeetingId;
            }

            set
            {
                _zoomMeetingId = value;
            }
        }

        public int? ZoomMeetingAttendanceId
        {
            get
            {
                return _ZoomMeetingAttendanceId;
            }

            set
            {
                _ZoomMeetingAttendanceId = value;
            }
        }

        public string Username
        {
            get
            {
                return _Username;
            }

            set
            {
                _Username = value;
            }
        }

        public bool IsZoomMeetingAttended
        {
            get
            {
                return _IsZoomMeetingAttended;
            }

            set
            {
                _IsZoomMeetingAttended = value;
            }
        }

        public DateTime? ZoomMeetingAttendedOn
        {
            get
            {
                return _ZoomMeetingAttendedOn;
            }

            set
            {
                _ZoomMeetingAttendedOn = value;
            }
        }

        public bool IsZoomMeetingEnded
        {
            get
            {
                return _IsZoomMeetingEnded;
            }

            set
            {
                _IsZoomMeetingEnded = value;
            }
        }

        public DateTime? ZoomMeetingEndedOn
        {
            get
            {
                return _ZoomMeetingEndedOn;
            }

            set
            {
                _ZoomMeetingEndedOn = value;
            }
        }

        public string Feedback
        {
            get
            {
                return _Feedback;
            }

            set
            {
                _Feedback = value;
            }
        }

        public DateTime? FeedbackAddedOn
        {
            get
            {
                return _FeedbackAddedOn;
            }

            set
            {
                _FeedbackAddedOn = value;
            }
        }

        public bool IsFeedbackAdded
        {
            get
            {
                return _IsFeedbackAdded;
            }

            set
            {
                _IsFeedbackAdded = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return _IsActive;
            }

            set
            {
                _IsActive = value;
            }
        }

        public bool IsDeleted
        {
            get
            {
                return _IsDeleted;
            }

            set
            {
                _IsDeleted = value;
            }
        }

        public DateTime? CreatedOn
        {
            get
            {
                return _CreatedOn;
            }

            set
            {
                _CreatedOn = value;
            }
        }

        public int? CreatedBy
        {
            get
            {
                return _CreatedBy;
            }

            set
            {
                _CreatedBy = value;
            }
        }

        public DateTime? ModifiedOn
        {
            get
            {
                return _ModifiedOn;
            }

            set
            {
                _ModifiedOn = value;
            }
        }

        public string FullName
        {
            get
            {
                return _FullName;
            }

            set
            {
                _FullName = value;
            }
        }

        public int UserId
        {
            get
            {
                return _UserId;
            }

            set
            {
                _UserId = value;
            }
        }

        public clsZoomMeetingAttendance()
        {
            DBLayer = new DataAccessLayerHelper.clsZoomMeetingAttendanceData();
        }

        public void AddUpdate(clsZoomMeetingAttendance obj)
        {
            DBLayer.AddUpdate(obj);

        }
        public clsZoomMeetingAttendance Load(string Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsZoomMeetingAttendance> LoadAll(clsZoomMeetingAttendance obj)
        {
            return DBLayer.LoadAll(obj);
        }

    }
}



