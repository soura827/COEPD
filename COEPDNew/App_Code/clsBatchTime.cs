using System;
using System.Collections.Generic;

namespace BusinessLayer
{

    public class clsBatchTime
    {
        DataAccessLayerHelper.clsBatchTimeData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _BatchTimeId;
        private DateTime _StartTime;
        private DateTime _EndTime;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private string _BatchTime;

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
        public int? BatchTimeId
        {
            get { return _BatchTimeId; }
            set { _BatchTimeId = value; }
        }

        public DateTime StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }
        public DateTime EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
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
        public DateTime ModifiedOn
        {
            get { return _ModifiedOn; }
            set { _ModifiedOn = value; }
        }
        public string BatchTime
        {
            get { return _BatchTime; }
            set { _BatchTime = value; }
        }
        public clsBatchTime()
        {
            DBLayer = new DataAccessLayerHelper.clsBatchTimeData();
        }
        public void AddUpdate(clsBatchTime obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsBatchTime Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsBatchTime> LoadAll(clsBatchTime obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}