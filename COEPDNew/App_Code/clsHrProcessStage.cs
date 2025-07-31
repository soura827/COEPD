using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;




namespace BusinessLayer
{
    public class clsHrProcessStage
    {
        DataAccessLayerHelper.clsHrProcessStageData DBLayer;
       
        private int? _NurturingProcessStageId;
        private string _NurturingProcessStageName;
        private bool _IsActive;
        private bool _IsDeleted;





        private int _SNo;
        private int? _HrProcessStageId;
        private string _HrProcessStageName;
        private int _CreatedBy;
        private string _CreatedName;
        private string _ModifiedName;
        private DateTime _CreatedOn;
        private DateTime? _ModifiedOn;




        //private int _HrProcessStageTaskId;
        //private string _HrProcessStage;
        //private DateTime _TargetDate;
        //private string _Notes;
        //private int _HrProcessSlotsId;
        //private bool _IsApproved;
        //private string _SenderImagePath;
        //private string _ReceiverImagePath;
        //private int? _HrProcessId;
        //private int _ParticipantId;
        //private DateTime? _ExamDate;
        //private int _ApprovedBy;







        public int SNo
        {
            get
            {
                return _SNo;
            }

            set
            {
                _SNo = value;
            }
        }

        public int? NurturingProcessStageId
        {
            get
            {
                return _NurturingProcessStageId;
            }

            set
            {
                _NurturingProcessStageId = value;
            }
        }

        public string NurturingProcessStageName
        {
            get
            {
                return _NurturingProcessStageName;
            }

            set
            {
                _NurturingProcessStageName = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return _IsActive;
            }

            set
            {
                _IsActive = value;
            }
        }

        public bool IsDeleted
        {
            get
            {
                return _IsDeleted;
            }

            set
            {
                _IsDeleted = value;
            }
        }

        public DateTime CreatedOn
        {
            get
            {
                return _CreatedOn;
            }

            set
            {
                _CreatedOn = value;
            }
        }

        public int CreatedBy
        {
            get
            {
                return _CreatedBy;
            }

            set
            {
                _CreatedBy = value;
            }
        }

        public DateTime? ModifiedOn
        {
            get
            {
                return _ModifiedOn;
            }

            set
            {
                _ModifiedOn = value;
            }
        }

        public string CreatedName
        {
            get
            {
                return _CreatedName;
            }

            set
            {
                _CreatedName = value;
            }
        }

        public string ModifiedName
        {
            get
            {
                return _ModifiedName;
            }

            set
            {
                _ModifiedName = value;
            }
        }

        public int? HrProcessStageId { get => _HrProcessStageId; set => _HrProcessStageId = value; }
        public string HrProcessStageName { get => _HrProcessStageName; set => _HrProcessStageName = value; }
        //public int HrProcessStageTaskId { get => _HrProcessStageTaskId; set => _HrProcessStageTaskId = value; }
        //public string HrProcessStage { get => _HrProcessStage; set => _HrProcessStage = value; }
        //public DateTime TargetDate { get => _TargetDate; set => _TargetDate = value; }
        //public string Notes { get => _Notes; set => _Notes = value; }
        //public int HrProcessSlotsId { get => _HrProcessSlotsId; set => _HrProcessSlotsId = value; }
        //public bool IsApproved { get => _IsApproved; set => _IsApproved = value; }
        //public string SenderImagePath { get => _SenderImagePath; set => _SenderImagePath = value; }
        //public string ReceiverImagePath { get => _ReceiverImagePath; set => _ReceiverImagePath = value; }
        //public int? HrProcessId { get => _HrProcessId; set => _HrProcessId = value; }
        //public int ParticipantId { get => _ParticipantId; set => _ParticipantId = value; }
        //public DateTime? ExamDate { get => _ExamDate; set => _ExamDate = value; }
        //public int ApprovedBy { get => _ApprovedBy; set => _ApprovedBy = value; }

        public clsHrProcessStage()
        {
            DBLayer = new DataAccessLayerHelper.clsHrProcessStageData();
        }
        public void AddUpdate(clsHrProcessStage obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public int LoadHrProcessStageValidation(clsHrProcessStage obj)
        {
            return DBLayer.LoadHrProcessStageValidation(obj);
        }
        public List<clsHrProcessStage> LoadAll(clsHrProcessStage obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public clsHrProcessStage Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }






        //public clsNurturingProcess LoadFinalizedResume(int Id)
        //{
        //    return DBLayer.LoadFinalizedResume(Id);
        //}
        //public clsNurturingProcess LoadNextStageTask(int Id)
        //{
        //    return DBLayer.LoadNextStageTask(Id);
        //}



        //public int LoadNurturingProcessValidation(clsNurturingProcess obj)
        //{
        //    return DBLayer.LoadNurturingProcessValidation(obj);
        //}

        //public void UpdateExamFile(clsNurturingProcess obj)
        //{
        //    DBLayer.UpdateExamFile(obj);
        //}





    }
}
