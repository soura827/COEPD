using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsCareerReply
    {
        DataAccessLayerHelper.clsCareerReplyData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _CareerReplyId;
        private string _Name;
        private string _FatherName;
        private DateTime _DateOfBirth;
        private string _Qualification;
        private string _AppliedFor;
        private string _TotalExp;
        private string _RelaventExperience;
        private string _Skills;
        private string _Strenghts;
        private string _CurrentDesignation;
        private string _CompanyAddress;
        private string _PresentCTC;
        private string _ExpectedCTC;
        private string _NoticePeriod;
        private string _ReasonForChange;
        private string _ResidentialAddress;
        private string _ImagePath;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;

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
        public int? CareerReplyId
        {
            get { return _CareerReplyId; }
            set { _CareerReplyId = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string FatherName
        {
            get { return _FatherName; }
            set { _FatherName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }
        public string Qualification
        {
            get { return _Qualification; }
            set { _Qualification = value; }
        }
        public string AppliedFor
        {
            get { return _AppliedFor; }
            set { _AppliedFor = value; }
        }
        public string TotalExp
        {
            get { return _TotalExp; }
            set { _TotalExp = value; }
        }

        public string RelavantExperience
        {
            get { return _RelaventExperience; }
            set { _RelaventExperience = value; }
        }
        public string Skills
        {
            get { return _Skills; }
            set { _Skills = value; }
        }
        public string Strengths
        {
            get { return _Strenghts; }
            set { _Strenghts = value; }
        }
        public string CurrentDesignation
        {
            get { return _CurrentDesignation; }
            set { _CurrentDesignation = value; }
        }
        public string CompanyAddress
        {
            get { return _CompanyAddress; }
            set { _CompanyAddress = value; }
        }
        public string PresentCTC
        {
            get { return _PresentCTC; }
            set { _PresentCTC = value; }

        }
        public string ExpectedCTC
        {
            get { return _ExpectedCTC; }
            set { _ExpectedCTC = value; }
        }
        public string NoticePeriod
        {
            get { return _NoticePeriod; }
            set { _NoticePeriod = value; }
        }
        public string ReasonForChange
        {
            get { return _ReasonForChange; }
            set { _ReasonForChange = value; }
        }
        public string ResidentialAddress
        {
            get { return _ResidentialAddress; }
            set { _ResidentialAddress = value; }
        }
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
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

        public clsCareerReply()
        {
            DBLayer = new DataAccessLayerHelper.clsCareerReplyData();
        }
        public void AddUpdate(clsCareerReply obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsCareerReply Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsCareerReply> LoadAll(clsCareerReply obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

    }
}