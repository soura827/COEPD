using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsZoomMeeting
    {
        DataAccessLayerHelper.clsZoomMeetigData DBLayer;
        private int _SNo;
        private string _keywords;
        private int _zoomMeetingId;
        private string _ZoomMeetingValueId;
        private string _ZoomMeetingCategory;
        private int _HostEmployeeId;
        private string _URL;
        private DateTime? _ZoomMeetingStartTimeOn;
        private DateTime? _ZoomMeetingEndTimeOn;
        private string _passCode;
        private DateTime? _ZoomMeetingDate;
        private bool _IsZoomMeetingStarted;
        private DateTime? _ZoomMeetingStartedTime;
        private DateTime? _ZoomMeetingEndedTime;
        private bool _IsZoomMeetingEnded;
        private int _BatchId;
        private bool _IsBatchOnly;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime? _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private string _FullName;
        private string _Employee;
        private int? _ZoomMeetingCatagoryId;
        private string _Batch;
        private int _ZoomCategoryId;
        private int _BatchTypeId;
        private int _ZoomMeetingCategoryId;
        private string _JoinURL;
        private string _HostURL;
        private int _ZoomMeetingAttendanceId;
        private string _Username;
        private bool _IsZoomMeetingAttended;
        private DateTime? _ZoomMeetingAttendedOn;
        private DateTime? _ZoomMeetingEndedOn;
        private string _Feedback;
        private DateTime? _FeedbackAddedOn;
        private bool _IsFeedbackAdded;

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

        public string ZoomMeetingValueId
        {
            get
            {
                return _ZoomMeetingValueId;
            }

            set
            {
                _ZoomMeetingValueId = value;
            }
        }

        public string ZoomMeetingCategory
        {
            get
            {
                return _ZoomMeetingCategory;
            }

            set
            {
                _ZoomMeetingCategory = value;
            }
        }

        public int HostEmployeeId
        {
            get
            {
                return _HostEmployeeId;
            }

            set
            {
                _HostEmployeeId = value;
            }
        }

        public string URL
        {
            get
            {
                return _URL;
            }

            set
            {
                _URL = value;
            }
        }


        public string PassCode
        {
            get
            {
                return _passCode;
            }

            set
            {
                _passCode = value;
            }
        }

        public DateTime? ZoomMeetingDate
        {
            get
            {
                return _ZoomMeetingDate;
            }

            set
            {
                _ZoomMeetingDate = value;
            }
        }

        public bool IsZoomMeetingStarted
        {
            get
            {
                return _IsZoomMeetingStarted;
            }

            set
            {
                _IsZoomMeetingStarted = value;
            }
        }

        public DateTime? ZoomMeetingStartedTime
        {
            get
            {
                return _ZoomMeetingStartedTime;
            }

            set
            {
                _ZoomMeetingStartedTime = value;
            }
        }

        public DateTime? ZoomMeetingEndedTime
        {
            get
            {
                return _ZoomMeetingEndedTime;
            }

            set
            {
                _ZoomMeetingEndedTime = value;
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

        public int BatchId
        {
            get
            {
                return _BatchId;
            }

            set
            {
                _BatchId = value;
            }
        }

        public bool IsBatchOnly
        {
            get
            {
                return _IsBatchOnly;
            }

            set
            {
                _IsBatchOnly = value;
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

        public int? ZoomMeetingCatagoryId
        {
            get
            {
                return _ZoomMeetingCatagoryId;
            }

            set
            {
                _ZoomMeetingCatagoryId = value;
            }
        }

        public string Batch
        {
            get
            {
                return _Batch;
            }

            set
            {
                _Batch = value;
            }
        }

        public int ZoomCategoryId
        {
            get
            {
                return _ZoomCategoryId;
            }

            set
            {
                _ZoomCategoryId = value;
            }
        }

        public int BatchTypeId
        {
            get
            {
                return _BatchTypeId;
            }

            set
            {
                _BatchTypeId = value;
            }
        }

        public DateTime? ZoomMeetingStartTimeOn
        {
            get
            {
                return _ZoomMeetingStartTimeOn;
            }

            set
            {
                _ZoomMeetingStartTimeOn = value;
            }
        }

        public DateTime? ZoomMeetingEndTimeOn
        {
            get
            {
                return _ZoomMeetingEndTimeOn;
            }

            set
            {
                _ZoomMeetingEndTimeOn = value;
            }
        }

        public int ZoomMeetingCategoryId
        {
            get
            {
                return _ZoomMeetingCategoryId;
            }

            set
            {
                _ZoomMeetingCategoryId = value;
            }
        }

        public string JoinURL
        {
            get
            {
                return _JoinURL;
            }

            set
            {
                _JoinURL = value;
            }
        }

        public string HostURL
        {
            get
            {
                return _HostURL;
            }

            set
            {
                _HostURL = value;
            }
        }

        public int ZoomMeetingAttendanceId
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

        public clsZoomMeeting()
        {
            DBLayer = new DataAccessLayerHelper.clsZoomMeetigData();
        }
        public void AddUpdate(clsZoomMeeting obj)
        {
            DBLayer.AddUpdate(obj);

        }
        public clsZoomMeeting Load(string Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsZoomMeeting> LoadAll(clsZoomMeeting obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {

        }

        //public clsZoomMeeting LoadZoomMeetingAttendance(string Id)
        //{
        //    return DBLayer.Load(Id);
        //}
    }
}





