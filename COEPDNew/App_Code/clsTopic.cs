using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsTopic
    {
        DataAccessLayerHelper.clsTopicData DBLayer;

        private int _StatusId;
        private int _UserId;
        private int _SNo;
        private string _keywords;
        private int? _TopicId;
        private string _Topic;
        private string _Description;
        private int _CategoryId;
        private string _Category;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private int _NurturingProcessStageTaskId;
        private int _StatusCode;

        public int StatusId
        {
            get { return _StatusId; }
            set { _StatusId = value; }
        }

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
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
        public int? TopicId
        {
            get { return _TopicId; }
            set { _TopicId = value; }
        }
        public string Topic
        {
            get { return _Topic; }
            set { _Topic = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public int CategoryId
        {
            get { return _CategoryId; }
            set { _CategoryId = value; }
        }
        public string Category
        {
            get { return _Category; }
            set { _Category = value; }
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

        public int NurturingProcessStageTaskId
        {
            get
            {
                return _NurturingProcessStageTaskId;
            }

            set
            {
                _NurturingProcessStageTaskId = value;
            }
        }

        public int StatusCode { get => _StatusCode; set => _StatusCode = value; }

        public clsTopic()
        {
            DBLayer = new DataAccessLayerHelper.clsTopicData();
        }
        public void AddUpdate(clsTopic obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsTopic Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public clsTopic LoadNurturingProcessStageTaskId(int Id)
        {
            return DBLayer.LoadNurturingProcessStageTaskId(Id);
        }
        public List<clsTopic> LoadAll(clsTopic obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}