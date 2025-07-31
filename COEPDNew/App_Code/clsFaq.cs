using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsFaq
    {
        DataAccessLayerHelper.clsFaqData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _FaqId;
        private string _Faq;
        private string _Description;
        private int _FaqTypeId;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private string _Username;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
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
        public int? FaqId
        {
            get { return _FaqId; }
            set { _FaqId = value; }
        }
        public string Faq
        {
            get { return _Faq; }
            set { _Faq = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public int FaqTypeId
        {
            get { return _FaqTypeId; }
            set { _FaqTypeId = value; }
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

        public clsFaq()
        {
            DBLayer = new DataAccessLayerHelper.clsFaqData();
        }

        public void AddUpdate(clsFaq obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsFaq Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsFaq> LoadAll(clsFaq obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
