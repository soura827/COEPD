using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsCMS
    {

        DataAccessLayerHelper.clsCMSData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _CMSId;
        private string _CMSTitle;
        private string _MetaTitle;
        private string _MetaContent;
        private string _MetaDescription;
        private string _CMSContent;
        private string _CannonicalLink;
        private string _CMSLink;
        private string _RemapLink;
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
        public int? CMSId
        {
            get { return _CMSId; }
            set { _CMSId = value; }
        }
        public string CMSTitle
        {
            get { return _CMSTitle; }
            set { _CMSTitle = value; }
        }
        public string MetaTitle
        {
            get { return _MetaTitle; }
            set { _MetaTitle = value; }
        }
        public string MetaContent
        {
            get { return _MetaContent; }
            set { _MetaContent = value; }
        }
        public string MetaDescription
        {
            get { return _MetaDescription; }
            set { _MetaDescription = value; }
        }
        public string CMSContent
        {
            get { return _CMSContent; }
            set { _CMSContent = value; }
        }
        public string CannonicalLink
        {
            get { return _CannonicalLink; }
            set { _CannonicalLink = value; }
        }
        public string CMSLink
        {
            get { return _CMSLink; }
            set { _CMSLink = value; }
        }
        public string RemapLink
        {
            get { return _RemapLink; }
            set { _RemapLink = value; }
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

        public clsCMS()
        {
            DBLayer = new DataAccessLayerHelper.clsCMSData();
        }
        public void AddUpdate(clsCMS obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsCMS Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public clsCMS Load_CMSLink(string Link)
        {
            return DBLayer.Load_CMSLink(Link);
        }
        public List<clsCMS> LoadAll(clsCMS obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}