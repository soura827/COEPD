using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class RepParticipantTimeSheet : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtFromDate.Text = DateTime.UtcNow.AddHours(5).AddMinutes(30).ToString("dd/MM/yyyy");
            txtToDate.Text = DateTime.UtcNow.AddHours(5).AddMinutes(30).ToString("dd/MM/yyyy");
            BindData();
        }
    }

    protected void BindBatch()
    {
        //clsBatch Item = new clsBatch();
        //ddlBatch.DataSource = Item.LoadAll(Item);
        //ddlBatch.DataTextField = "Batch";
        //ddlBatch.DataValueField = "BatchId";
        //ddlBatch.DataBind();
        //ddlBatch.Items.Insert(0, new ListItem("-- Select Batch -- ", "0"));
    }

    protected void ddlBatch_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
        //if (ddlBatch.SelectedIndex > 0)
        //{
        //    ddlParticipant.Items.Clear();
        //    ddlParticipant.Enabled = true;
        //    BindParticipant();
        //}
        //else
        //{
        //    ddlParticipant.Enabled = false;
        //}
    }

    //protected void BindParticipant()
    //{
    //    clsParticipant Item = new clsParticipant();
    //    Item.BatchId = Convert.ToInt32(ddlBatch.SelectedValue);
    //    ddlParticipant.DataSource = Item.LoadAllByBatch(Item);
    //    ddlParticipant.DataTextField = "Participant";
    //    ddlParticipant.DataValueField = "ParticipantId";
    //    ddlParticipant.DataBind();
    //    ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant -- ", "0"));
    //}

    protected void BindData()
    {
        clsParticipantTimeSheet obj = new clsParticipantTimeSheet();
        //obj.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
        if (txtFromDate.Text != "")
        {
            obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.FromDate = null;
        }
        if (txtToDate.Text != "")
        {
            obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.ToDate = null;
        }
        gv.DataSource = obj.LoadAllReports(obj);
        gv.DataBind();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BindData();
    }



}



