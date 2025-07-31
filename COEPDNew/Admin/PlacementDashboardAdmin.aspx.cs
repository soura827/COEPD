using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_PlacementDashboardAdmin : System.Web.UI.Page
{
     int ItemId= 0;
     int TotalJobsApplied = 0;
    int TotalJobAppliedStatus = 0;
    int TotalInterviewRound1 = 0;
     int TotalInterviewRound2 = 0;
     int TotalInterviewRound3 = 0;
     int TotalOffersReleased = 0;
     int TotalOffersAccepted = 0;
     int TotalJobsPosted = 0;



    int TotalJobsAppliedAll = 0;
    int TotalJobAppliedStatusAll = 0;
    int TotalInterviewRound1All = 0;
    int TotalInterviewRound2All = 0;
    int TotalInterviewRound3All = 0;
    int TotalOffersReleasedAll = 0;
    int TotalOffersAcceptedAll = 0;
    int TotalJobsPostedAll = 0;


    int ThroughJobStatus = 0;
    int ReferenceStatus = 0;
    int CoepdPortalStatus = 0;
    int CoepdPlacementWingStatus = 0;


    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        clsParticipant Item= new clsParticipant();
        Item = Item.Load(ItemId);
        if(Item!=null)
        {
            lblSpecialNote.Text = Item.SpecialNote;
            lblName.Text = Item.Participant;
        }
        BindPlacementDashboardAdmin();
        
        ltlTotalJobsApplied.Text = Convert.ToString(TotalJobsApplied);
        ltlJobApplied.Text = Convert.ToString(TotalJobAppliedStatus);
        ltlInterviewRound1.Text = Convert.ToString(TotalInterviewRound1);
        ltlInterviewRound2.Text = Convert.ToString(TotalInterviewRound2);
        ltlInterviewRound3.Text = Convert.ToString(TotalInterviewRound3);
        ltlOffersReleased.Text = Convert.ToString(TotalOffersReleased);
        ltlOffersAccepted.Text = Convert.ToString(TotalOffersAccepted);
        ltlJobsPosted.Text = Convert.ToString(TotalJobsPosted);



        BindPlacementDashboardAdminAll();
        ltlTotalJobsAppliedAll.Text = Convert.ToString(TotalJobsAppliedAll);
        ltlJobAppliedAll.Text = Convert.ToString(TotalJobAppliedStatusAll);
        ltlInterviewRound1All.Text = Convert.ToString(TotalInterviewRound1All);
        ltlInterviewRound2All.Text = Convert.ToString(TotalInterviewRound2All);
        ltlInterviewRound3All.Text = Convert.ToString(TotalInterviewRound3All);
        ltlOffersReleasedAll.Text = Convert.ToString(TotalOffersReleasedAll);
        ltlOffersAcceptedAll.Text = Convert.ToString(TotalOffersAcceptedAll);
        ltlJobsPostedAll.Text = Convert.ToString(TotalJobsPostedAll);


        BindPlacementDashboardAppliedThrough();
        ltlThroughJobStatus.Text = Convert.ToString(ThroughJobStatus);
        ltlReferenceStatus.Text = Convert.ToString(ReferenceStatus);
        ltlCoepdPortalStatus.Text = Convert.ToString(CoepdPortalStatus);
        ltlCoepdPlacementWingStatus.Text = Convert.ToString(CoepdPlacementWingStatus);


    }
    protected void BindPlacementDashboardAdmin()
    {
        clsPlacementDashboard PDB = new clsPlacementDashboard();
        PDB.ParticipantId = ItemId;
        PDB = PDB.PlacementDashboardAdminCount(PDB);
        TotalJobsApplied = PDB.TotalJobsApplied;
        TotalJobAppliedStatus = PDB.TotalJobsAppliedStatus;
        TotalInterviewRound1 = PDB.TotalInterviewRound1;
        TotalInterviewRound2 = PDB.TotalInterviewRound2;
        TotalInterviewRound3 = PDB.TotalInterviewRound3;
        TotalOffersReleased = PDB.TotalOffersReleased;
        TotalOffersAccepted = PDB.TotalOffersAccepted;
        TotalJobsPosted = PDB.TotalJobsPosted;

    }


    protected void BindPlacementDashboardAdminAll()
    {
        clsPlacementDashboard PDBS = new clsPlacementDashboard();
        PDBS.ParticipantId = ItemId;
        PDBS = PDBS.PlacementDashboardAdminCountAll(PDBS);
        TotalJobsAppliedAll = PDBS.TotalJobsAppliedAll;
        TotalJobAppliedStatusAll = PDBS.TotalJobsAppliedStatusAll;
        TotalInterviewRound1All =  PDBS.TotalInterviewRound1All;
        TotalInterviewRound2All =  PDBS.TotalInterviewRound2All;
        TotalInterviewRound3All =  PDBS.TotalInterviewRound3All;
        TotalOffersReleasedAll =   PDBS.TotalOffersReleasedAll;
        TotalOffersAcceptedAll =   PDBS.TotalOffersAcceptedAll;
        TotalJobsPostedAll =    PDBS.TotalJobsPostedAll;

    }


    protected void BindPlacementDashboardAppliedThrough()
    {
        clsPlacementDashboard PDBAT = new clsPlacementDashboard();
        PDBAT.ParticipantId = ItemId;
        PDBAT = PDBAT.PlacementDashboardAppliedThrough(PDBAT);
        ThroughJobStatus = PDBAT.ThoughJobPortal;
        ReferenceStatus = PDBAT.Reference;
        CoepdPortalStatus = PDBAT.CoepdPortal;
        CoepdPlacementWingStatus = PDBAT.CoepdPlacementWing;


    }   }