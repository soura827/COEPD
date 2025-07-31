using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsPhoto
    {
        DataAccessLayerHelper.clsPhotoData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _PhotoId;
        private string _ImageThumbPath;
        private string _ImagePath;
        private int? _GalleryId;
        private string _Gallery;
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
        public int? PhotoId
        {
            get { return _PhotoId; }
            set { _PhotoId = value; }
        }
        public string ImageThumbPath
        {
            get { return _ImageThumbPath; }
            set { _ImageThumbPath = value; }
        }
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }
        public int? GalleryId
        {
            get { return _GalleryId; }
            set { _GalleryId = value; }
        }
        public string Gallery
        {
            get { return _Gallery; }
            set { _Gallery = value; }
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

        public clsPhoto()
        {
            DBLayer = new DataAccessLayerHelper.clsPhotoData();
        }

        public void AddUpdate(clsPhoto obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsPhoto Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsPhoto> LoadAll(clsPhoto obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
