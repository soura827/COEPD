using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsInternDocument
    {
        DataAccessLayerHelper.clsInternDocumentData DBLayer;
        private int _SNo;
        private string _keywords;
        private int _ParticipantId;
        private string _Participant;
        private int _ParticipantDocumentTypeId;
        private string _ParticipantDocumentType;
        private int? _ParticipantDocumentId;
        private string _ParticipantDocument;
        private int _EmployeeDocumentId;
        private string _DocPath;
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
        public int ParticipantId
        {
            get { return _ParticipantId; }
            set { _ParticipantId = value; }
        }
        public string Participant
        {
            get { return _Participant; }
            set { _Participant = value; }
        }
        public int ParticipantDocumentTypeId
        {
            get { return _ParticipantDocumentTypeId; }
            set { _ParticipantDocumentTypeId = value; }
        }
        public string ParticipantDocumentType
        {
            get { return _ParticipantDocumentType; }
            set { _ParticipantDocumentType = value; }
        }
        public int? ParticipantDocumentId
        {
            get { return _ParticipantDocumentId; }
            set { _ParticipantDocumentId = value; }
        }
        public string ParticipantDocument
        {
            get { return _ParticipantDocument; }
            set { _ParticipantDocument = value; }
        }
        public string DocPath
        {
            get { return _DocPath; }
            set { _DocPath = value; }
        }
        public int EmployeeDocumentId
        {
            get { return _EmployeeDocumentId; }
            set { _EmployeeDocumentId = value; }
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


        public clsInternDocument()
        {
            DBLayer = new DataAccessLayerHelper.clsInternDocumentData();
        }
        public void AddUpdate(clsInternDocument obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsInternDocument Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsInternDocument> LoadAll(clsInternDocument obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}