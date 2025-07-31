using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace BusinessLayer
{
    public class clsHrChat
    {
        DataAccessLayerHelper.clsHrChatData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _HrChatId;
        private string _Chat;
        private int _HrProcessStageId;
        private int _HrProcessStageTaskId;
        private string _HrProcessStageTaskName;
        private int _ParticipantId;
        private string _Participant;
        private int _EmployeeId;
        private string _Employee;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private int _RoleId;
        private string _Email;
        private string _Mobile;
        private string _Username;
        private string _Location;
        private bool _IsReplied;
        private DateTime? _ModifiedOn;
        private string _ModifiedName;
        private string _SenderImagePath;
        private string _ReceiverImagePath;

        public int SNo { get => _SNo; set => _SNo = value; }
        public string Keywords { get => _keywords; set => _keywords = value; }
        public int? HrChatId { get => _HrChatId; set => _HrChatId = value; }
        public string Chat { get => _Chat; set => _Chat = value; }
        public int HrProcessStageId { get => _HrProcessStageId; set => _HrProcessStageId = value; }
        public int HrProcessStageTaskId { get => _HrProcessStageTaskId; set => _HrProcessStageTaskId = value; }
        public string HrProcessStageTaskName { get => _HrProcessStageTaskName; set => _HrProcessStageTaskName = value; }
        public int ParticipantId { get => _ParticipantId; set => _ParticipantId = value; }
        public string Participant { get => _Participant; set => _Participant = value; }
        public int EmployeeId { get => _EmployeeId; set => _EmployeeId = value; }
        public string Employee { get => _Employee; set => _Employee = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public int RoleId { get => _RoleId; set => _RoleId = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Mobile { get => _Mobile; set => _Mobile = value; }
        public string Username { get => _Username; set => _Username = value; }
        public string Location { get => _Location; set => _Location = value; }
        public bool IsReplied { get => _IsReplied; set => _IsReplied = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public string ModifiedName { get => _ModifiedName; set => _ModifiedName = value; }
        public string SenderImagePath { get => _SenderImagePath; set => _SenderImagePath = value; }
        public string ReceiverImagePath { get => _ReceiverImagePath; set => _ReceiverImagePath = value; }
        public clsHrChat()
        {
            DBLayer = new DataAccessLayerHelper.clsHrChatData();
        }
        public void AddUpdate(clsHrChat obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsHrChat Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public clsHrChat LoadTopOne(int Id)
        {
            return DBLayer.LoadTopOne(Id);
        }

        public List<clsHrChat> LoadAll(clsHrChat obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsHrChat> LoadAllTasks(clsHrChat obj)
        {
            return DBLayer.LoadAllTasks(obj);
        }
        public List<clsHrChat> LoadParticipantsAll(clsHrChat obj)
        {
            return DBLayer.LoadParticipantsAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public int LoadHrPendingChatCount(clsHrChat obj)
        {
            return DBLayer.HrPendingChatCount(obj);
        }
        public clsHrChat GetByPendingChat(int ParticipantId)
        {
            return DBLayer.GetByPendingChat(ParticipantId);
        }
        public int LoadHrChatValidation(clsHrChat obj)
        {
            return DBLayer.LoadHrChatValidation(obj);
        }
    }
}