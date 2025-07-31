//This class  is used to set and get values of  the Participant Fields BusinessLayer to DataLayer.
using DataAccessLayerHelper;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsParticipantModule
    {
        clsParticipantModuleData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _ModuleId;
        private string _Module;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int _CreatedBy;
        private string _Username;

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

        public int? ModuleId
        {
            get { return _ModuleId; }
            set { _ModuleId = value; }
        }

        public string Module
        {
            get { return _Module; }
            set { _Module = value; }
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

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public clsParticipantModule()
        {
            DBLayer = new DataAccessLayerHelper.clsParticipantModuleData();
        }

        public void AddUpdate(clsParticipantModule obj)
        {
            DBLayer.AddUpdate(obj);
        }

        public clsParticipantModule Load(int Id)
        {
            return DBLayer.Load(Id);
        }

        public List<clsParticipantModule> LoadAll(clsParticipantModule obj)
        {
            return DBLayer.LoadAll(obj);
        }
        //This Remove method is not used now.
        //public void Remove(int Id)
        //{
        //    DBLayer.Remove(Id);
        //}
    }
}

