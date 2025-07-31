using System;
using System.Collections.Generic;
namespace BusinessLayer
{

    public class clsUserLocation
    {
        DataAccessLayerHelper.clsUserLocationData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _UserLocationId;
        private int _UserId;
        private string _Username;
        private int _LocationId;
        private string _Location;
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
        public int? UserLocationId
        {
            get { return _UserLocationId; }
            set { _UserLocationId = value; }
        }
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        public int LocationId
        {
            get { return _LocationId; }
            set { _LocationId = value; }
        }
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
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

        public clsUserLocation()
        {
            DBLayer = new DataAccessLayerHelper.clsUserLocationData();
        }
        public void AddUpdate(clsUserLocation obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsUserLocation Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsUserLocation> LoadAll(clsUserLocation obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public List<clsUserLocation> LoadAllAssigned(clsUserLocation obj)
        {
            return DBLayer.LoadAllAssigned(obj);
        }

    }
}