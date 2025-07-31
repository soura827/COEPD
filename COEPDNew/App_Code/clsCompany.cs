using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsCompany
    {
        DataAccessLayerHelper.clsCompanyData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _CompanyId;
        private string _Company;
        private string _Description;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;

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
        public int? CompanyId
        {
            get { return _CompanyId; }
            set { _CompanyId = value; }
        }
        public string Company
        {
            get { return _Company; }
            set { _Company = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
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

        public clsCompany()
        {
            DBLayer = new DataAccessLayerHelper.clsCompanyData();
        }
        public void AddUpdate(clsCompany obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsCompany Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsCompany> LoadAll(clsCompany obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}