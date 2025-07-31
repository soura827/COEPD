using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ParticipantExam : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void BindParticipant()
    {
        clsParticipant obj = new clsParticipant();
        ddlParticipant.DataSource = obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Participant";
        ddlParticipant.DataValueField = "ParticipantId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant --", ""));
    }

    protected void BindData()
    {
        clsExam obj = new clsExam();
        obj.ParticipantId = Convert.ToInt16(ddlParticipant.SelectedValue);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdRemove")
        {
            clsExam Item = new clsExam();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Exam successfully removed";
            ErrorMessage.Visible = true;
        }
    }


    protected void btnSearch_Click(object sender, EventArgs e)
    {
        clsParticipant obj = new clsParticipant();
        if (txtSearch.Text.Length > 0)
        {
            obj.keywords = txtSearch.Text;
        }
        ddlParticipant.DataSource = obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Participant";
        ddlParticipant.DataValueField = "ParticipantId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant --", ""));
    }

    protected void ddlParticipant_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlParticipant.SelectedIndex > 0)
        {
            clsParticipant Participant = new clsParticipant();
            Participant = Participant.Load(Convert.ToInt16(ddlParticipant.SelectedValue));

            clsBatch Batch = new clsBatch();
            Batch = Batch.Load(Participant.BatchId);

            //clsTrainer Trainer = new clsTrainer();
            //Trainer = Trainer.Load(Batch.EmployeeId);

            DateTime dtBatchDate = Convert.ToDateTime(Batch.StartDate);

            //lblBatch.Text = dtBatchDate.Day.ToString() + "/" + dtBatchDate.Month.ToString() + "/" + dtBatchDate.Year.ToString() + "&nbsp;&nbsp;&nbsp;<strong> Trainer : " + Trainer.Trainer + "</strong>";

            BindData();
        }

    }
}