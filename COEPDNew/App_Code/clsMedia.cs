using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsMedia
    {
        DataAccessLayerHelper.clsMediaData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _MediaId;
        private string _MediaTitle;
        private string _Description;
        private string _ImagePath;
        private string _ImageThumbPath;
        private DateTime _MediaDate;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
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
        public int? MediaId
        {
            get { return _MediaId; }
            set { _MediaId = value; }
        }
        public string MediaTitle
        {
            get { return _MediaTitle; }
            set { _MediaTitle = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }
        public string ImageThumbPath
        {
            get { return _ImageThumbPath; }
            set { _ImageThumbPath = value; }
        }
        public DateTime MediaDate
        {
            get { return _MediaDate; }
            set { _MediaDate = value; }
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

        public clsMedia()
        {
            DBLayer = new DataAccessLayerHelper.clsMediaData();
        }

        public void AddUpdate(clsMedia obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsMedia Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsMedia> LoadAll(clsMedia obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
