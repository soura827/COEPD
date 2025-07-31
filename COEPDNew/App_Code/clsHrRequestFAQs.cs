using DataAccessLayerHelper;
using System;
using System.Collections.Generic;













namespace BusinessLayer
{
    public class clsHrRequestFAQs
    {

        clsHrRequestFAQsData DBLayer;

        private int _SNo;
        private string _CompanyName;
        private int _ResumeSubmissionId;
        private bool? _IsSent;
        private string _Fullname;
        private string _ModifiedByName;
        private string _Experience;
        private string _Domain;
        private int? _HrRequestFAQsId;
        private int? _IsSentBy;
        private string _JobDescription;
        private DateTime? _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private string _Location;
        private int _InterviewStatusId;

        public string CompanyName { get => _CompanyName; set => _CompanyName = value; }
        public int ResumeSubmissionId { get => _ResumeSubmissionId; set => _ResumeSubmissionId = value; }
        public bool? IsSent { get => _IsSent; set => _IsSent = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }
        public string ModifiedByName { get => _ModifiedByName; set => _ModifiedByName = value; }
        public string Experience { get => _Experience; set => _Experience = value; }
        public string Domain { get => _Domain; set => _Domain = value; }
        public int? HrRequestFAQsId { get => _HrRequestFAQsId; set => _HrRequestFAQsId = value; }
        public int? IsSentBy { get => _IsSentBy; set => _IsSentBy = value; }
        public string JobDescription { get => _JobDescription; set => _JobDescription = value; }
        public DateTime? CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public int ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public int SNo { get => _SNo; set => _SNo = value; }
        public string Location { get => _Location; set => _Location = value; }
        public int InterviewStatusId { get => _InterviewStatusId; set => _InterviewStatusId = value; }

        public clsHrRequestFAQs()
        {
            DBLayer = new DataAccessLayerHelper.clsHrRequestFAQsData();
        }
        public void AddUpdate(clsHrRequestFAQs obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsHrRequestFAQs Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsHrRequestFAQs> LoadAll(clsHrRequestFAQs obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public int LoadHrRequestFAQsResumeSubmission_Validation(clsHrRequestFAQs obj)
        {
            return DBLayer.LoadHrRequestFAQsResumeSubmission_Validation(obj);
        }
    }

}