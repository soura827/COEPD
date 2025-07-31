using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;



namespace BusinessLayer
{
    public class clsLeadMaster
    {

        DataAccessLayerHelper.clsLeadMasterData DBLayer;

        private int _SNo;
        private int _LeadMasterId;
        private string _LeadName;
        private string _Mobile;
        private string _Email;
        private int _LocationId;
        private int _LeadSourcePageId;
        private string _Location;
        private string _LeadSourcePageName;
        private string _Keywords;


        public int SNo { get => _SNo; set => _SNo = value; }
        public int LeadMasterId { get => _LeadMasterId; set => _LeadMasterId = value; }
        public string LeadName { get => _LeadName; set => _LeadName = value; }
        public string Mobile { get => _Mobile; set => _Mobile = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int LocationId { get => _LocationId; set => _LocationId = value; }
        public int LeadSourcePageId { get => _LeadSourcePageId; set => _LeadSourcePageId = value; }
        public string Location { get => _Location; set => _Location = value; }
        public string LeadSourcePageName { get => _LeadSourcePageName; set => _LeadSourcePageName = value; }
        public string Keywords { get => _Keywords; set => _Keywords = value; }

        public clsLeadMaster()
        {
            DBLayer = new DataAccessLayerHelper.clsLeadMasterData();
        }


        public List<clsLeadMaster> LoadAll(clsLeadMaster obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
        public List<clsLeadMaster> LeadSourcePage(clsLeadMaster obj)
        {
            return DBLayer.LeadSourcePage(obj);
        }

    }
}
