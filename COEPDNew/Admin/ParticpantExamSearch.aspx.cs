using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ParticpantExamSearch : System.Web.UI.Page
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
            BindTopic();
            BindBatch();
            BindLocation();
            BindData();
            DateTime dateTime;
            dateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            txtFromDate.Text = dateTime.ToString("dd/MM/yyyy");
            txtToDate.Text = dateTime.ToString("dd/MM/yyyy");
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindBatch()
    {
        clsBatch obj = new clsBatch();
        ddlBatch.DataSource = obj.LoadAll(obj);
        ddlBatch.DataTextField = "Batch";
        ddlBatch.DataValueField = "BatchId";
        ddlBatch.DataBind();
        ddlBatch.Items.Insert(0, new ListItem("-- Select Batch --", "0"));
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

    protected void BindTopic()
    {
        clsTopic obj = new clsTopic();
        obj.CategoryId = 1;
        ddlTopic.DataSource = obj.LoadAll(obj);
        ddlTopic.DataTextField = "Topic";
        ddlTopic.DataValueField = "TopicId";
        ddlTopic.DataBind();
        ddlTopic.Items.Insert(0, new ListItem("-- Select Topic --", "0"));
    }

    protected void BindData()
    {
        clsExam obj = new clsExam();
        obj.keywords = txtSearch.Text;
        
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
        obj.TopicId = Convert.ToInt16(ddlTopic.SelectedValue);
        obj.BatchId = Convert.ToInt16(ddlBatch.SelectedValue);
        obj.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        gv.DataSource = obj.LoadAllReports(obj);
        gv.DataBind();
    }

    protected void ddlBatch_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlTopic_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}