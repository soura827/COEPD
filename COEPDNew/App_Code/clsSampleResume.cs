using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsSampleResume
    {


        DataAccessLayerHelper.clsSampleResumeData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _SampleResumeId;
        private string _SampleResumePath;
        private string _SampleResumeName;
        private int? _ParticipantId;
        private string _Participant;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private int _CountSampleResumes;

        public int SNo
        {
            get { return _SNo; }
            set { _SNo = value; }
        }
        public int CountSampleResumes
        {
            get { return _CountSampleResumes; }
            set { _CountSampleResumes = value; }
        }
        public string keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }
        public int? SampleResumeId
        {
            get { return _SampleResumeId; }
            set { _SampleResumeId = value; }
        }
        public string SampleResumePath
        {
            get { return _SampleResumePath; }
            set { _SampleResumePath = value; }
        }
        public string SampleResumeName
        {
            get { return _SampleResumeName; }
            set { _SampleResumeName = value; }
        }
        public int? ParticipantId
        {
            get { return _ParticipantId; }
            set { _ParticipantId = value; }
        }
        public string Participant
        {
            get { return _Participant; }
            set { _Participant = value; }
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
        public clsSampleResume()
        {
            DBLayer = new DataAccessLayerHelper.clsSampleResumeData();
        }

        public void AddUpdate(clsSampleResume obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsSampleResume Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public clsSampleResume ResumesCount(clsSampleResume obj)
        {
            return DBLayer.ResumesCount(obj);
        }
        public List<clsSampleResume> LoadAll(clsSampleResume obj)
        {
            return DBLayer.LoadAll(obj);
        }
    }
}