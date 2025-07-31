using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsCommunicationType
    {
        DataAccessLayerHelper.clsCommunicationTypeData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _CommunicationTypeId;
        private string _CommunicationType;
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
        public int? CommunicationTypeId
        {
            get { return _CommunicationTypeId; }
            set { _CommunicationTypeId = value; }
        }
        public string CommunicationType
        {
            get { return _CommunicationType; }
            set { _CommunicationType = value; }
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

        public clsCommunicationType()
        {
            DBLayer = new DataAccessLayerHelper.clsCommunicationTypeData();
        }
        public void AddUpdate(clsCommunicationType obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsCommunicationType Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsCommunicationType> LoadAll(clsCommunicationType obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}