using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Participant_PlacementDashboard : System.Web.UI.Page
{
    int ItemId = 0;
    int TotalJobsApplied = 0;
    int TotalJobAppliedStatus = 0;
    int TotalInterviewRound1 = 0;
    int TotalInterviewRound2 = 0;
    int TotalInterviewRound3 = 0;
    int TotalOffersReleased = 0;
    int TotalOffersAccepted = 0;
    int TotalJobsPosted = 0;
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(CurrentUser.CurrentParticipantId>0)
        {
            ItemId = CurrentUser.CurrentParticipantId;
            lblName.Text = CurrentUser.CurrentName;

            //clsParticipant Item = new clsParticipant();
            //Item = Item.Load(ItemId);
            //if (Item != null)
            //{
            //    lblSpecialNote.Text = Item.SpecialNote;
            //    lblName.Text = Item.Participant;
            //}
            BindPlacementDashboardAdmin();
            ltlTotalJobsApplied.Text = Convert.ToString(TotalJobsApplied);
            ltlJobApplied.Text = Convert.ToString(TotalJobAppliedStatus);
            ltlInterviewRound1.Text = Convert.ToString(TotalInterviewRound1);
            ltlInterviewRound2.Text = Convert.ToString(TotalInterviewRound2);
            ltlInterviewRound3.Text = Convert.ToString(TotalInterviewRound3);
            ltlOffersReleased.Text = Convert.ToString(TotalOffersReleased);
            ltlOffersAccepted.Text = Convert.ToString(TotalOffersAccepted);
            ltlJobsPosted.Text = Convert.ToString(TotalJobsPosted);
        }
        else
        {
            Response.Redirect("~/login.html");
        }
       
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

    //protected void btnJobsApplied_Click(object sender, EventArgs e)
    //{

    //}

    //protected void btnInterviewRound1_Click(object sender, EventArgs e)
    //{

    //}

    //protected void btnInterviewRound2_Click(object sender, EventArgs e)
    //{

    //}

    //protected void btnInterviewRound3_Click(object sender, EventArgs e)
    //{

    //}

    //protected void btnOffersReleased_Click(object sender, EventArgs e)
    //{

    //}

    //protected void btnOffersAccepted_Click(object sender, EventArgs e)
    //{

    //}

    //protected void btnJobsPosted_Click(object sender, EventArgs e)
    //{

    //}

    //protected void btnTotalJobsApplied_Click(object sender, EventArgs e)
    //{

    //}

    //protected void btnjobApplied_Click(object sender, EventArgs e)
    //{

    //}
}