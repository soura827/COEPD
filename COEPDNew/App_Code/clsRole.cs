using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsRole
    {
        DataAccessLayerHelper.clsRoleData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _RoleId;
        private string _RoleName;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
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
        public int? RoleId
        {
            get { return _RoleId; }
            set { _RoleId = value; }
        }
        public string RoleName
        {
            get { return _RoleName; }
            set { _RoleName = value; }
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
        public int CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }

        public clsRole()
        {
            DBLayer = new DataAccessLayerHelper.clsRoleData();
        }

        public void AddUpdate(clsRole obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsRole Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsRole> LoadAll(clsRole obj)
        {
            return DBLayer.LoadAll(obj);
        }

        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}
