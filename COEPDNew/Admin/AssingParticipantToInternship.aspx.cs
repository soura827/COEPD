using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class AssingParticipantToInternship : System.Web.UI.Page
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
            BindInternBatch();
        }
    }
    protected void BindBatchType()
    {
        clsBatchType obj = new clsBatchType();
        ddlBatchType.DataSource = obj.LoadAll(obj);
        ddlBatchType.DataTextField = "BatchType";
        ddlBatchType.DataValueField = "BatchTypeId";
        ddlBatchType.DataBind();
        ddlBatchType.Items.Insert(0, new ListItem("-- Select Batch Type -- ", ""));
        ddlLocation.Items.Insert(0, new ListItem("-- Select Location -- ", ""));
        ddlTrainer.Items.Insert(0, new ListItem("-- Select Trainer -- ", ""));
        ddlBatch.Items.Insert(0, new ListItem("-- Select Batch -- ", ""));
    }
    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("-- Select Location --", ""));
    }
    protected void BindTrainer()
    {
        clsEmployee obj = new clsEmployee();
        obj.DesignationId = 2;
        ddlTrainer.DataSource = obj.LoadAll(obj);
        ddlTrainer.DataTextField = "Employee";
        ddlTrainer.DataValueField = "EmployeeId";
        ddlTrainer.DataBind();
        ddlTrainer.Items.Insert(0, new ListItem("-- Select Trainer --", ""));
    }
    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindgvAssign();
        BindData();
    }
    protected void BindData()
    {
        clsParticipant obj = new clsParticipant();
        obj.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedValue);
        obj.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        obj.EmployeeId = Convert.ToInt16(ddlTrainer.SelectedValue);
        obj.BatchId = Convert.ToInt16(ddlBatch.SelectedValue);
        obj.IsIntern = false;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void BindInternBatch()
    {
        ddlInternBatch.Items.Clear();
        clsInternBatch obj = new clsInternBatch();
        ddlInternBatch.DataSource = obj.LoadAll(obj);
        ddlInternBatch.DataTextField = "InternBatch";
        ddlInternBatch.DataValueField = "InternBatchId";
        ddlInternBatch.DataBind();
        ddlInternBatch.Items.Insert(0, new ListItem("-- Select Internship Batch --", "0"));
    }
    protected void BindgvAssign()
    {
        clsParticipant obj = new clsParticipant();
        obj.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedValue);
        obj.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        obj.EmployeeId = Convert.ToInt16(ddlTrainer.SelectedValue);
        obj.BatchId = Convert.ToInt16(ddlBatch.SelectedValue);
        obj.IsIntern = true;
        gvAssign.DataSource = obj.LoadAll(obj);
        gvAssign.DataBind();        
    }
    protected void BindBatch()
    {
        clsBatch Item = new clsBatch();
        Item.BatchTypeId = Convert.ToInt32(ddlBatchType.SelectedValue);
        Item.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
        Item.EmployeeId = Convert.ToInt32(ddlTrainer.SelectedValue);
        ddlBatch.DataSource = Item.LoadAll(Item);
        ddlBatch.DataTextFormatString = "{0: dd/MM/yyyy}";
        ddlBatch.DataTextField = "StartDate";
        ddlBatch.DataValueField = "BatchId";
        ddlBatch.DataBind();
        ddlBatch.Items.Insert(0, new ListItem("-- Select Batch -- ", ""));
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (ddlInternBatch.SelectedIndex != 0)
        {
            if (e.CommandName == "cmdAdd")
            {
                clsParticipant obj = new clsParticipant();
                obj.ParticipantId = Convert.ToInt32(e.CommandArgument);
                obj.IsIntern = true;
                obj.InternBatchId = Convert.ToInt32(ddlInternBatch.SelectedValue);
                obj.AddToIntrnship(obj);
                BindgvAssign();
                BindData();
                lblIntern.Text = "";
                BindInternBatch();
            }
        }
        else
        {
            ddlInternBatch.Focus();
            lblIntern.Text = "Please Select Internship Batch";
        }
    }
    protected void gvAssign_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdRemove")
        {
            clsParticipant obj = new clsParticipant();
            obj.ParticipantId = Convert.ToInt32(e.CommandArgument);
            obj.IsIntern = false;
            obj.InternBatchId = 0;
            obj.AddToIntrnship(obj);
            BindgvAssign();
            BindData();
        }
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        BindgvAssign();
        BindData();
    }
    protected void ddlBatchType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlBatchType.SelectedIndex != 0)
        {
            ddlLocation.Items.Clear();
            ddlLocation.Enabled = true;
            BindLocation();
        }
        else
        {
            ddlLocation.Enabled = false;
            ddlTrainer.Enabled = false;
            ddlBatch.Enabled = false;
        }
    }
    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlLocation.SelectedIndex != 0)
        {
            ddlTrainer.Items.Clear();
            ddlTrainer.Enabled = true;
            BindTrainer();
        }
        else
        {
            ddlTrainer.Enabled = false;
            ddlBatch.Enabled = false;
        }
    }
    protected void ddlTrainer_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlTrainer.SelectedIndex != 0)
        {
            ddlBatch.Items.Clear();
            ddlBatch.Enabled = true;
            BindBatch();
        }
        else
        {
            ddlBatch.Enabled = false;
        }
    }
}