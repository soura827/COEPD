using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsBestPractices
    {
        DataAccessLayerHelper.clsBestPracticesData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _BestPracticesId;
        private string _Stream;
        private string _Practices;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private string _ModifiedOn;
        //  private int _ModifiedBy;

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
        public int? BestPracticesId
        {
            get { return _BestPracticesId; }
            set { _BestPracticesId = value; }

        }
        public string Stream
        {
            get { return _Stream; }
            set { _Stream = value; }
        }
        public string Practices
        {
            get { return _Practices; }
            set { _Practices = value; }
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
        public int CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }
        public string ModifiedOn
        {
            get { return _ModifiedOn; }
            set { _ModifiedOn = value; }
        }
        // public int ModifiedBy
        //{
        //     get { return _ModifiedBy; }
        //     set { _ModifiedBy = value; }
        // }
        public clsBestPractices()
        {
            DBLayer = new DataAccessLayerHelper.clsBestPracticesData();
        }
        public void AddUpdate(clsBestPractices obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsBestPractices Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsBestPractices> LoadAll(clsBestPractices obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

    }
}


