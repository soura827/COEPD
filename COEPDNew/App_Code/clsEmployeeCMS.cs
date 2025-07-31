using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsEmployeeCMS
    {

        DataAccessLayerHelper.clsEmployeeCMSData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _EmployeeCMSId;
        private string _EmployeeCMSTitle;
        private string _EmployeeCMSContent;
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
        public int? EmployeeCMSId
        {
            get { return _EmployeeCMSId; }
            set { _EmployeeCMSId = value; }
        }
        public string EmployeeCMSTitle
        {
            get { return _EmployeeCMSTitle; }
            set { _EmployeeCMSTitle = value; }
        }

        public string EmployeeCMSContent
        {
            get { return _EmployeeCMSContent; }
            set { _EmployeeCMSContent = value; }
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

        public clsEmployeeCMS()
        {
            DBLayer = new DataAccessLayerHelper.clsEmployeeCMSData();
        }
        public void AddUpdate(clsEmployeeCMS obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsEmployeeCMS Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsEmployeeCMS> LoadAll(clsEmployeeCMS obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}