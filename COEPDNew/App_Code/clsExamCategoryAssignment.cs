//This class is used to set and get values of Participant Examcategory fields  from BusinessLayer and DataAccessLayer. 
using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsExamCategoryAssignment
    {

        DataAccessLayerHelper.clsExamCategoryAssignmentData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _ExamCategoryAssignmentId;
        private string _Participant;
        private int _CategoryId;
        private string _Category;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private int _ParticipantId;
        private string _SendAssignedExamCategoriesToParticipant;
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

        public int? ExamCategoryAssignmentId
        {
            get { return _ExamCategoryAssignmentId; }
            set { _ExamCategoryAssignmentId = value; }
        }

        public string Participant
        {
            get { return _Participant; }
            set { _Participant = value; }
        }

        public int CategoryId
        {
            get { return _CategoryId; }
            set { _CategoryId = value; }
        }

        public string Category
        {
            get { return _Category; }
            set { _Category = value; }
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

        public int ParticipantId
        {
            get { return _ParticipantId; }
            set { _ParticipantId = value; }
        }

        public string SendAssignedExamCategoriesToParticipant
        {
            get { return _SendAssignedExamCategoriesToParticipant; }
            set { _SendAssignedExamCategoriesToParticipant = value; }
        }

        public clsExamCategoryAssignment()
        {
            DBLayer = new DataAccessLayerHelper.clsExamCategoryAssignmentData();
        }
        public void AddUpdate(clsExamCategoryAssignment obj)
        {
            DBLayer.AddUpdate(obj);
        }
        //This Method is not used now.
        //public clsExamCategoryAssignment Load(int Id)
        //{
        //    return DBLayer.Load(Id);
        //}
        public List<clsExamCategoryAssignment> LoadAll(clsExamCategoryAssignment obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(clsExamCategoryAssignment obj)
        {
            DBLayer.Remove(obj);
        }
        public List<clsExamCategoryAssignment> LoadAllAssign(clsExamCategoryAssignment obj)
        {
            return DBLayer.LoadAllAssign(obj);
        }

        public clsExamCategoryAssignment LoadByParticipantAssignedCategories(int ParticipantId1)
        {
            return DBLayer.LoadByParticipantAssignedCategories(ParticipantId1);
        }
        public int Validation(clsExamCategoryAssignment obj)
        {
            return DBLayer.Validation(obj);
        }



    }
}
