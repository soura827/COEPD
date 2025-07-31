using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsResumeChat
    {
        DataAccessLayerHelper.clsResumeChatData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _ResumeChatId;
        private string _ResumeChat;
        private int? _ResumePreparationId;
        private string _ResumePreapartion;
        private int _ParticipantId;
        private string _Participant;
        private int _EmployeeId;
        private string _Employee;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private int _RoleId;
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
        public int? ResumeChatId
        {
            get { return _ResumeChatId; }
            set { _ResumeChatId = value; }
        }
        public string ResumeChat
        {
            get { return _ResumeChat; }
            set { _ResumeChat = value; }
        }
        public int? ResumePreparationId
        {
            get { return _ResumePreparationId; }
            set { _ResumePreparationId = value; }
        }
        public string ResumePreapartion
        {
            get { return _ResumePreapartion; }
            set { _ResumePreapartion = value; }
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
        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }
        public string Employee
        {
            get { return _Employee; }
            set { _Employee = value; }
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
        public int RoleId
        {
            get { return _RoleId; }
            set { _RoleId = value; }
        }
        public clsResumeChat()
        {
            DBLayer = new DataAccessLayerHelper.clsResumeChatData();
        }

        public void AddUpdate(clsResumeChat obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsResumeChat Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsResumeChat> LoadAll(clsResumeChat obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

    }
}