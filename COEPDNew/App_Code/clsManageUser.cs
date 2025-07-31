using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsManageUser
    {
        DataAccessLayerHelper.clsManageUserData DBLayer;

        private int _EmployeeId;
        private int _ParticipantId;
        private string _Participant;
        private string _Mobile;
        private int _BranchId;
        private string _BranchName;
        private int _SNo;
        private string _keywords;
        private int? _UserId;
        private string _Username;
        private string _Pwd;
        private string _NewPwd;
        private string _Fullname;
        private int _RoleId;
        private string _Rolename;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;

        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
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

        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }

        public int BranchId
        {
            get { return _BranchId; }
            set { _BranchId = value; }
        }

        public string BranchName
        {
            get { return _BranchName; }
            set { _BranchName = value; }
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
        public int? UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        public string Pwd
        {
            get { return _Pwd; }
            set { _Pwd = value; }
        }
        public string NewPwd
        {
            get { return _NewPwd; }
            set { _NewPwd = value; }
        }
        public string Fullname
        {
            get { return _Fullname; }
            set { _Fullname = value; }
        }
        public int RoleId
        {
            get { return _RoleId; }
            set { _RoleId = value; }
        }

        public string Rolename
        {
            get { return _Rolename; }
            set { _Rolename = value; }
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

        public int CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }

        public clsManageUser()
        {
            DBLayer = new DataAccessLayerHelper.clsManageUserData();
        }

        public void AddUpdate(clsManageUser obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsManageUser Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public clsManageUser LoadByParticipantId(int ParticipantId)
        {
            return DBLayer.LoadByParticipantId(ParticipantId);
        }

        public List<clsManageUser> LoadAll(clsManageUser obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

        public clsManageUser CheckExist(string username)
        {
            return DBLayer.CheckExist(username);
        }

        public clsManageUser CheckValidate(clsManageUser obj)
        {
            return DBLayer.CheckValidate(obj);
        }

        public string ChangePassword(clsManageUser obj)
        {
            return DBLayer.ChangePassword(obj);
        }
    }
}