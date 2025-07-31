using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class LeadRegisteredSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void setGridView()
    {
        if (CurrentUser.IsAdmin == false)
        {
            gv.Columns[0].Visible = false;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCourse();
            BindBatchType();
            BindLocation();
            BindTrainer();
            BindData();
        }
    }

    protected void BindTrainer()
    {
        clsEmployee obj = new clsEmployee();
        ddlTrainer.DataSource = obj.LoadAll(obj);
        ddlTrainer.DataTextField = "Employee";
        ddlTrainer.DataValueField = "EmployeeId";
        ddlTrainer.DataBind();
        ddlTrainer.Items.Insert(0, new ListItem("-- Employee --", "0"));
    }

    protected void BindCourse()
    {
        clsCourse obj = new clsCourse();
        ddlCourse.DataSource = obj.LoadAll(obj);
        ddlCourse.DataTextField = "Course";
        ddlCourse.DataValueField = "CourseId";
        ddlCourse.DataBind();
        ddlCourse.Items.Insert(0, new ListItem("-- Course --", "0"));
    }

    protected void BindBatchType()
    {
        clsBatchType obj = new clsBatchType();
        ddlBatchType.DataSource = obj.LoadAll(obj);
        ddlBatchType.DataTextField = "BatchType";
        ddlBatchType.DataValueField = "BatchTypeId";
        ddlBatchType.DataBind();
        ddlBatchType.Items.Insert(0, new ListItem("-- BatchType --", "0"));
    }

    protected void BindLocation()
    {
        if (CurrentUser.IsAdmin == true)
        {
            clsLocation obj = new clsLocation();
            ddlLocation.DataSource = obj.LoadAll(obj);
            ddlLocation.DataTextField = "Location";
            ddlLocation.DataValueField = "LocationId";
            ddlLocation.DataBind();
            ddlLocation.Items.Insert(0, new ListItem("-- All Locations --", "0"));

        }
        else
        {
            clsUserLocation obj = new clsUserLocation();
            obj.UserId = CurrentUser.CurrentUserId;
            ddlLocation.DataSource = obj.LoadAll(obj);
            ddlLocation.DataTextField = "Location";
            ddlLocation.DataValueField = "LocationId";
            ddlLocation.DataBind();
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindData()
    {
        if (ddlLocation.Items.Count > 0)
        {
            clsLead obj = new clsLead();
            obj.CourseId = Convert.ToInt16(ddlCourse.SelectedValue);
            obj.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedValue);
            obj.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
            obj.TrainerId = Convert.ToInt16(ddlTrainer.SelectedValue);
            obj.LeadStatusId = 3;
            obj.keywords = txtSearch.Text.Trim();
            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();
            setGridView();
        }
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdView")
        {
            Response.Redirect("ReceiptHistory.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdReceipt")
        {
            Response.Redirect("ReceiptPay.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsLead Item = new clsLead();
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Lead successfully removed";
            ErrorMessage.Visible = true;
        }
    }

    protected void ddlCourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlBatchType_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlTrainer_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}