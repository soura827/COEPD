using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsDocument
    {
        DataAccessLayerHelper.clsDocumentData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _DocumentId;
        private string _Document;
        private string _DocPath;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private int _CategoryId;
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
        public int? DocumentId
        {
            get { return _DocumentId; }
            set { _DocumentId = value; }
        }
        public string Document
        {
            get { return _Document; }
            set { _Document = value; }
        }
        public string DocPath
        {
            get { return _DocPath; }
            set { _DocPath = value; }
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
        public int CategoryId
        {
            get { return _CategoryId; }
            set { _CategoryId = value; }
        }

        public clsDocument()
        {
            DBLayer = new DataAccessLayerHelper.clsDocumentData();
        }
        public void AddUpdate(clsDocument obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsDocument Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsDocument> LoadAll(clsDocument obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}