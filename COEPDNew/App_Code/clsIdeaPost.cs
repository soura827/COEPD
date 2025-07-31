using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsIdeaPost
    {
        DataAccessLayerHelper.clsIdeaPostData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _IdeaPostId;
        private string _Subject;
        private string _Description;
        private string _Employee;
        private int _EmployeeId;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private string _Participant;
        private int _ParticipantId;
        private int _LocationId;
        private int _BranchId;
        private string _Branch;

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
        public int? IdeaPostId
        {
            get { return _IdeaPostId; }
            set { _IdeaPostId = value; }
        }

        public string Subject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public string Employee
        {
            get { return _Employee; }
            set { _Employee = value; }
        }
        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }
        public string Participant
        {
            get { return _Participant; }
            set { _Participant = value; }
        }
        public int ParticipantId
        {
            get { return _ParticipantId; }
            set { _ParticipantId = value; }
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

        public int LocationId
        {
            get
            {
                return _LocationId;
            }

            set
            {
                _LocationId = value;
            }
        }

        public int BranchId
        {
            get
            {
                return _BranchId;
            }

            set
            {
                _BranchId = value;
            }
        }

        public string Branch
        {
            get
            {
                return _Branch;
            }

            set
            {
                _Branch = value;
            }
        }

        public clsIdeaPost()
        {
            DBLayer = new DataAccessLayerHelper.clsIdeaPostData();
        }

        public void AddUpdate(clsIdeaPost obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsIdeaPost Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsIdeaPost> LoadAll(clsIdeaPost obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public List<clsIdeaPost> LoadAllEmployees(clsIdeaPost obj)
        {
            return DBLayer.LoadAllEmployees(obj);
        }

        public List<clsIdeaPost> LoadParticpant(clsIdeaPost obj)
        {
            return DBLayer.LoadParticpant(obj);
        }

        public List<clsIdeaPost> LoadAllParticpants(clsIdeaPost obj)
        {
            return DBLayer.LoadAllParticpants(obj);
        }
        public List<clsIdeaPost> LoadallIdeaPost_List_ByBranchIdEmployees(clsIdeaPost obj)
        {
            return DBLayer.LoadAllByBranchIdEmployees(obj);
        }
        public List<clsIdeaPost> LoadAllIdeaPost_List_ByBranchIdParticipants(clsIdeaPost obj)
        {
            return DBLayer.LoadAllIdeaPost_List_ByBranchIdParticipantsAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}