using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsActivityFeatureLink
    {
        DataAccessLayerHelper.clsActivityFeatureLinkData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _ActivityFeatureLinkId;
        private string _ActivityFeatureName;
        private string _ActivityAddressName;
        private string _Fullname;
        private string _Employee;
        private string _Modifiedname;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;
        private int? _ActivityId;

        public int SNo { get => _SNo; set => _SNo = value; }
        public string Keywords { get => _keywords; set => _keywords = value; }
        public int? ActivityFeatureLinkId { get => _ActivityFeatureLinkId; set => _ActivityFeatureLinkId = value; }
        public string ActivityFeatureName { get => _ActivityFeatureName; set => _ActivityFeatureName = value; }
        public string ActivityAddressName { get => _ActivityAddressName; set => _ActivityAddressName = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }
        public string Employee { get => _Employee; set => _Employee = value; }
        public string Modifiedname { get => _Modifiedname; set => _Modifiedname = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public DateTime? ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public int ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public int? ActivityId { get => _ActivityId; set => _ActivityId = value; }

        public clsActivityFeatureLink()
        {
            DBLayer = new DataAccessLayerHelper.clsActivityFeatureLinkData();
        }

        public void AddUpdate(clsActivityFeatureLink obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsActivityFeatureLink Load(int id)
        {
            return DBLayer.Load(id);
        }
        public List<clsActivityFeatureLink> LoadAll(clsActivityFeatureLink obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int id)
        {
            DBLayer.Remove(id);
        }


    }
}