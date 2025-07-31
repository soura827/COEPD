using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsDownload
    {
        DataAccessLayerHelper.clsDownloadData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _DownloadId;
        private string _Download;
        private string _DownloadPath;
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
        public int? DownloadId
        {
            get { return _DownloadId; }
            set { _DownloadId = value; }
        }
        public string Download
        {
            get { return _Download; }
            set { _Download = value; }
        }
        public string DownloadPath
        {
            get { return _DownloadPath; }
            set { _DownloadPath = value; }
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

        public clsDownload()
        {
            DBLayer = new DataAccessLayerHelper.clsDownloadData();
        }
        public void AddUpdate(clsDownload obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsDownload Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsDownload> LoadAll(clsDownload obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}