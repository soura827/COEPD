using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsResumePreparation
    {
        DataAccessLayerHelper.clsResumePreparationData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _ResumePreparationId;
        private string _JobExperienceDomain;
        private string _JobExpectedDomain;
        private int? _ExpInYears;
        private decimal _ExpectedSalary;
        private string _PreferedLocations;
        private string _ListOfCompentencies;
        private string _Skills;
        private string _ResumePath;
        private string _Comments;
        private int? _PartcicipantId;
        private string _Participant;
        private bool? _ResumeStatus;
        private bool? _HrStatus;
        private bool _HrNotShortlist;
        private bool _SampleResumeRequest;
        private bool _InterviewQuestionRequest;
        private bool _SampleResumeReceive;
        private bool _InterviewQuestionReceive;
        private int? _EmployeeId;
        private string _Employee;
        private string _ApprovedBy;
        private DateTime? _ApprovedDate;
        private string _Batch;
        private DateTime _StartDate;
        private string _Location;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private int _ShortlistedResumes;
        private int _ResumesProcessCount;
        private int _ResumesApprovedCount;
        private int _SampleResumesRequests;
        private int _InterviewQuestionRequests;
        private int _NotShortlistedResumes;
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

        public int? ResumePreparationId
        {
            get { return _ResumePreparationId; }
            set { _ResumePreparationId = value; }
        }

        public string JobExpectedDomain
        {
            get { return _JobExpectedDomain; }
            set { _JobExpectedDomain = value; }
        }

        public string JobExperienceDomain
        {
            get { return _JobExperienceDomain; }
            set { _JobExperienceDomain = value; }
        }

        public int? ExpInYears
        {
            get { return _ExpInYears; }
            set { _ExpInYears = value; }
        }

        public decimal ExpectedSalary
        {
            get { return _ExpectedSalary; }
            set { _ExpectedSalary = value; }
        }

        public string PreferedLocations
        {
            get { return _PreferedLocations; }
            set { _PreferedLocations = value; }
        }

        public string ListOfCompentencies
        {
            get { return _ListOfCompentencies; }
            set { _ListOfCompentencies = value; }
        }
        public string Skills
        {
            get { return _Skills; }
            set { _Skills = value; }
        }

        public string ResumePath
        {
            get { return _ResumePath; }
            set { _ResumePath = value; }
        }

        public string Comments
        {
            get { return _Comments; }
            set { _Comments = value; }
        }

        public int? ParticipantId
        {
            get { return _PartcicipantId; }
            set { _PartcicipantId = value; }
        }
        public string Participant
        {
            get { return _Participant; }
            set { _Participant = value; }
        }
        public bool? ResumeStatus
        {
            get { return _ResumeStatus; }
            set { _ResumeStatus = value; }
        }
        public bool? HrStatus
        {
            get { return _HrStatus; }
            set { _HrStatus = value; }
        }

        public bool HrNotShortlist
        {
            get { return _HrNotShortlist; }
            set { _HrNotShortlist = value; }
        }
        public bool SampleResumeRequest
        {
            get { return _SampleResumeRequest; }
            set { _SampleResumeRequest = value; }
        }

        public bool InterviewQuestionRequest
        {
            get { return _InterviewQuestionReceive; }
            set { _InterviewQuestionReceive = value; }
        }

        public int? EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }
        public string Employee
        {
            get { return _Employee; }
            set { _Employee = value; }
        }
        public string ApprovedBy
        {
            get { return _ApprovedBy; }
            set { _ApprovedBy = value; }
        }
        public DateTime? ApprovedDate
        {
            get { return _ApprovedDate; }
            set { _ApprovedDate = value; }
        }
        public string Batch
        {
            get { return _Batch; }
            set { _Batch = value; }
        }
        public bool SampleResumeReceive
        {
            get { return _SampleResumeReceive; }
            set { _SampleResumeReceive = value; }
        }

        public bool InterviewQuestionReceive
        {
            get { return _InterviewQuestionRequest; }
            set { _InterviewQuestionRequest = value; }
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
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        public int ResumesProcessCount
        {
            get { return _ResumesProcessCount; }
            set { _ResumesProcessCount = value; }
        }
        public int ResumesApprovedCount
        {
            get { return _ResumesApprovedCount; }
            set { _ResumesApprovedCount = value; }
        }
        public int SampleResumesRequests
        {
            get { return _SampleResumesRequests; }
            set { _SampleResumesRequests = value; }
        }
        public int InterviewQuestionRequests
        {
            get { return _InterviewQuestionRequests; }
            set { _InterviewQuestionRequests = value; }
        }

        public int ShortlistedResumes
        {
            get { return _ShortlistedResumes; }
            set { _ShortlistedResumes = value; }
        }
        public int NotShortlistedResumes
        {
            get { return _NotShortlistedResumes; }
            set { _NotShortlistedResumes = value; }
        }
        public clsResumePreparation()
        {
            DBLayer = new DataAccessLayerHelper.clsResumePreparationData();
        }

        public void AddUpdate(clsResumePreparation obj)
        {
            DBLayer.AddUpdate(obj);
        }
        //Load Id based on ParticipantId//
        public clsResumePreparation Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        //Load Id based on ResumePreparationId //
        public clsResumePreparation LoadById(int Id)
        {
            return DBLayer.LoadById(Id);
        }
        public List<clsResumePreparation> LoadAll(clsResumePreparation obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public List<clsResumePreparation> LoadAllHR(clsResumePreparation obj)
        {
            return DBLayer.LoadAllHR(obj);
        }
        public clsResumePreparation MentorRequestsCount(clsResumePreparation obj)
        {
            return DBLayer.MentorRequestsCount(obj);
        }
    }
}