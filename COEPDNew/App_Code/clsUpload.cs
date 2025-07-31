using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsUpload
    {
        DataAccessLayerHelper.clsUploadData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _UploadId;
        private string _Upload;
        private string _DocPath;
        private int _UserId;
        private int _DocCategoryId;
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
        public int? UploadId
        {
            get { return _UploadId; }
            set { _UploadId = value; }
        }
        public string Upload
        {
            get { return _Upload; }
            set { _Upload = value; }
        }
        public string DocPath
        {
            get { return _DocPath; }
            set { _DocPath = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public int DocCategoryId
        {
            get { return _DocCategoryId; }
            set { _DocCategoryId = value; }
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

        public clsUpload()
        {
            DBLayer = new DataAccessLayerHelper.clsUploadData();
        }
        public void AddUpdate(clsUpload obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsUpload Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsUpload> LoadAll(clsUpload obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}