using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_RepVisitors : System.Web.UI.Page
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

            BindBatchType();
            BindLocation();
            BindData();
            DateTime dateTime;
            dateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            txtFromDate.Text = dateTime.ToString("dd/MM/yyyy");
            txtToDate.Text = dateTime.ToString("dd/MM/yyyy");
            gv.Caption = "Participant Visitors Reports on " + txtFromDate.Text;
        }

    }
    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("-- Select Location --", "0"));

    }
    protected void BindBatchType()
    {
        clsBatchType obj = new clsBatchType();
        ddlBatchType.DataSource = obj.LoadAll(obj);
        ddlBatchType.DataTextField = "BatchType";
        ddlBatchType.DataValueField = "BatchtypeId";
        ddlBatchType.DataBind();
        ddlBatchType.Items.Insert(0, new ListItem("-- Select BatchType --", "0"));
        ddlBatch.Items.Insert(0, new ListItem("-- Select Batch --", "0"));
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant --", "0"));
    }
    protected void BindBatch()
    {
        clsBatch obj = new clsBatch();
        obj.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedValue);
        obj.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        ddlBatch.DataSource = obj.LoadAll(obj);
        ddlBatch.DataTextField = "StartDate";
        ddlBatch.DataTextFormatString = "{0:dd/MM/yyyy}";
        ddlBatch.DataValueField = "BatchId";
        ddlBatch.DataBind();
        ddlBatch.Items.Insert(0, new ListItem("-- Select Batch --", "0"));


    }


    protected void BindParticipant()
    {
        clsParticipant obj = new clsParticipant();
        obj.BatchId = Convert.ToInt16(ddlBatch.SelectedValue);
        obj.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        ddlParticipant.DataSource = obj.LoadAllByBatch(obj);
        ddlParticipant.DataTextField = "Participant";
        ddlParticipant.DataValueField = "ParticipantId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant --", "0"));

    }

    protected void BindData()
    {
        clsRegister obj = new clsRegister();
        obj.RegisterTypeId = 2;
        obj.BatchId = Convert.ToInt16(ddlBatch.SelectedValue);
        obj.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedValue);
        obj.ParticipantId = Convert.ToInt16(ddlParticipant.SelectedValue);
        obj.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
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
        if (ddlBatchType.SelectedValue != "0")
        {
            gv.Caption = ddlParticipant.SelectedItem + " : Visited Reports From " + txtFromDate.Text + " To " + txtToDate.Text;
            gv.DataSource = obj.LoadAllReports(obj);
            gv.DataBind();
        }
        else
        {
            gv.Caption = "Participant Visitors Reports From " + txtFromDate.Text+ " To " + txtToDate.Text ;
            gv.DataSource = obj.LoadAllReports(obj);
            gv.DataBind();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }

    protected void ddlBatch_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlBatch.SelectedValue != "0")
        {

            ddlParticipant.Items.Clear();
            ddlParticipant.Enabled = true;
            BindParticipant();
        }
        else
        {
            ddlParticipant.Enabled = false;
        }
    }

    protected void ddlBatchType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlBatchType.SelectedValue != "0")
        {
            ddlLocation.Items.Clear();
            ddlLocation.Enabled = true;
            BindLocation();
        }
        else
        {
            ddlLocation.SelectedIndex = -1;
            ddlLocation.Enabled = false;
            ddlBatch.SelectedIndex = -1;
            ddlBatch.Enabled = false;
            ddlParticipant.SelectedIndex = -1;
            ddlParticipant.Enabled = false;
        }

    }
    protected void ddlParticipant_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (ddlLocation.SelectedValue != "0" && ddlBatchType.SelectedValue != "0")
        {
            ddlBatch.Items.Clear();
            ddlBatch.Enabled = true;
            BindBatch();
        }
        else
        {
            ddlBatch.SelectedIndex = -1;
            ddlBatch.Enabled = false;
            ddlParticipant.SelectedIndex = -1;
            ddlParticipant.Enabled = false;
        }

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BindData();
    }
}