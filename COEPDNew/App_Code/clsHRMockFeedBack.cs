using DataAccessLayerHelper;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsHRMockFeedBack
    {
        clsHRMockFeedBackData DBLayer;
        private int _SNo;
        private int _HRMockQuestionId;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private int? _ConductHRMockFeedBackFormId;
        private int _PlacementInductionId;
        private int _RemarksId;
        private int _ParticipantId;
        private string _QuestionName;
        private string _ModifiedName;
        private string _Remarks;
        private string _Rating;

        public int SNo { get => _SNo; set => _SNo = value; }
        public int HRMockQuestionId { get => _HRMockQuestionId; set => _HRMockQuestionId = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public int ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public int PlacementInductionId { get => _PlacementInductionId; set => _PlacementInductionId = value; }
        public int RemarksId { get => _RemarksId; set => _RemarksId = value; }
        public int ParticipantId { get => _ParticipantId; set => _ParticipantId = value; }
        public int? ConductHRMockFeedBackFormId { get => _ConductHRMockFeedBackFormId; set => _ConductHRMockFeedBackFormId = value; }
        public string QuestionName { get => _QuestionName; set => _QuestionName = value; }
        public string ModifiedName { get => _ModifiedName; set => _ModifiedName = value; }
        public string Remarks { get => _Remarks; set => _Remarks = value; }
        public string Rating { get => _Rating; set => _Rating = value; }

        public clsHRMockFeedBack() => DBLayer = new DataAccessLayerHelper.clsHRMockFeedBackData();
        public void AddUpdate(clsHRMockFeedBack obj) => DBLayer.AddUpdate(obj);

        public List<clsHRMockFeedBack> LoadAll(clsHRMockFeedBack obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public int LoadInductionValidation(clsHRMockFeedBack obj)
        {
            return DBLayer.LoadInductionValidation(obj);
        }

    }
}



