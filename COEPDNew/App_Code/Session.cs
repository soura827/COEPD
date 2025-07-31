using System;
using System.Web;

namespace BusinessLayer
{
    public partial class SessionData
    {
        public void Clear()
        {
            HttpContext.Current.Session.Clear();
        }

        public void AddToSession(string key, object value)
        {
            HttpContext.Current.Session[key] = value;
        }

        public object GetFromSession(string key)
        {
            return HttpContext.Current.Session[key];
        }

    }

    public class CurrentUser
    {
        private string key_userBranchId = "userBranchId";
        private string key_currentDesignationId = "currentDesignationId";
        private string key_currentDesignation = "currentDesignation";
        private string key_currentUserId = "currentUserId";
        private string key_roleId = "currentRoleId";
        private string key_currentUserrole = "currentUserRole";
        private string key_currentUsername = "currentUserName";
        private string key_currentName = "currentName";
        private string key_currentParticipantId = "currentParticipantId";
        private string key_currentEmployeeId = "currentEmployeeId";
        private string key_isAdmin = "IsAdmin";
        private string key_isIntern = "IsIntern";
        private string key_isLead = "IsLead";
        private string key_currentUserLocationId = "currentUserLocationId";
        //    private string key_isHR = "IsHR";
        private string key_currentUserMobile = "currentUserMobile";
        private string key_CurrentLastSlotStartTime = "CurrentLastSlotStartTime";
        public int UserBranchId
        {
            get
            {
                if (HttpContext.Current.Session[key_userBranchId] != null)
                    return (int)HttpContext.Current.Session[key_userBranchId];
                return 0;
            }
            set
            {
                HttpContext.Current.Session[key_userBranchId] = value;
            }
        }

        public int CurrentUserId
        {
            get
            {
                if (HttpContext.Current.Session[key_currentUserId] != null)
                    return (int)HttpContext.Current.Session[key_currentUserId];
                return 0;
            }
            set
            {
                HttpContext.Current.Session[key_currentUserId] = value;
            }
        }

        public int CurrentDesignationId
        {
            get
            {
                if (HttpContext.Current.Session[key_currentDesignationId] != null)
                    return (int)HttpContext.Current.Session[key_currentDesignationId];
                return 0;
            }
            set
            {
                HttpContext.Current.Session[key_currentDesignationId] = value;
            }
        }

        public string CurrentDesignation
        {
            get
            {
                return (string)HttpContext.Current.Session[key_currentDesignation];
            }
            set
            {
                HttpContext.Current.Session[key_currentDesignation] = value;
            }
        }

        public int CurrentRoleId
        {
            get
            {
                if (HttpContext.Current.Session[key_roleId] != null)
                    return (int)HttpContext.Current.Session[key_roleId];
                return 0;
            }
            set
            {
                HttpContext.Current.Session[key_roleId] = value;
            }
        }

        public string CurrentUserrole
        {
            get
            {
                return (string)HttpContext.Current.Session[key_currentUserrole];
            }
            set
            {
                HttpContext.Current.Session[key_currentUserrole] = value;
            }
        }

        public string CurrentUsername
        {
            get
            {
                return (string)HttpContext.Current.Session[key_currentUsername];
            }
            set
            {
                HttpContext.Current.Session[key_currentUsername] = value;
            }
        }

        public string CurrentName
        {
            get
            {
                return (string)HttpContext.Current.Session[key_currentName];
            }
            set
            {
                HttpContext.Current.Session[key_currentName] = value;
            }
        }

        public int CurrentParticipantId
        {
            get
            {
                if (HttpContext.Current.Session[key_currentParticipantId] != null)
                    return (int)HttpContext.Current.Session[key_currentParticipantId];
                return 0;
            }
            set
            {
                HttpContext.Current.Session[key_currentParticipantId] = value;
            }
        }

        public int CurrentEmployeeId
        {
            get
            {
                if (HttpContext.Current.Session[key_currentEmployeeId] != null)
                    return (int)HttpContext.Current.Session[key_currentEmployeeId];
                return 0;
            }
            set
            {
                HttpContext.Current.Session[key_currentEmployeeId] = value;
            }
        }

        public bool IsAdmin
        {
            get
            {
                if (HttpContext.Current.Session[key_isAdmin] != null)
                    return (bool)HttpContext.Current.Session[key_isAdmin];
                return false;
            }
            set
            {
                HttpContext.Current.Session[key_isAdmin] = value;
            }
        }

        public bool IsIntern
        {
            get
            {
                if (HttpContext.Current.Session[key_isIntern] != null)
                    return (bool)HttpContext.Current.Session[key_isIntern];
                return false;
            }
            set
            {
                HttpContext.Current.Session[key_isIntern] = value;
            }
        }

        public bool IsLead
        {
            get
            {
                if (HttpContext.Current.Session[key_isLead] != null)
                    return (bool)HttpContext.Current.Session[key_isLead];
                return false;
            }
            set
            {
                HttpContext.Current.Session[key_isLead] = value;
            }
        }

        public string CurrentUserLocationId
        {
            get
            {
                if (HttpContext.Current.Session[key_currentUserLocationId] != null)
                    return (string)HttpContext.Current.Session[key_currentUserLocationId];
                return null;
            }
            set
            {
                HttpContext.Current.Session[key_currentUserLocationId] = value;
            }
        }

        public string CurrentUserMobile
        {
            get
            {
                if (HttpContext.Current.Session[key_currentUserMobile] != null)
                    return (string)HttpContext.Current.Session[key_currentUserMobile];
                return null;
            }

            set
            {
                HttpContext.Current.Session[key_currentUserMobile] = value;
            }
        }

        public DateTime? CurrentLastSlotStartTime
        {
            get
            {
                if (HttpContext.Current.Session[key_CurrentLastSlotStartTime] != null)
                    return (DateTime)HttpContext.Current.Session[key_CurrentLastSlotStartTime];
                return null;

            }

            set
            {
                HttpContext.Current.Session[key_CurrentLastSlotStartTime] = value;
            }
        }

        //public bool IsHR
        //{
        //    get
        //    {
        //        if (HttpContext.Current.Session[key_isHR] != null)
        //            return (bool)HttpContext.Current.Session[key_isHR];
        //        return false;
        //    }
        //    set
        //    {
        //        HttpContext.Current.Session[key_isHR] = value;
        //    }
        //}

    }
}
