using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using BusinessLayer;
public partial class Batch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsBatch Item;
    clsUtility utility = new clsUtility();
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsBatch();
        if (!IsPostBack)
        {
            BindCourse();
            BindBatchType();
            BindLocation();
            BindEmployee();
            BindBatchTime();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Batch";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    DateTime dtVoucherDate = Convert.ToDateTime(Item.StartDate);
                    txtDay.Text = dtVoucherDate.Day.ToString();
                    txtMonth.Text = dtVoucherDate.Month.ToString();
                    txtYear.Text = dtVoucherDate.Year.ToString();
                    ddlStatus.SelectedValue = Item.StatusId.ToString();
                    ddlCourse.SelectedValue = Item.CourseId.ToString();
                    ddlBatchType.SelectedValue = Item.BatchTypeId.ToString();
                    ddlLocation.SelectedValue = Item.LocationId.ToString();
                    ddlEmployee.SelectedValue = Item.EmployeeId.ToString();
                    ddlBatchTime.SelectedValue = Item.BatchTimeId.ToString();
                }
            }
            else
            {
                lblTitle.Text = "Add New Batch";
                DateTime dt;
                dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                txtDay.Text = dt.Day.ToString();
                txtMonth.Text = dt.Month.ToString();
                txtYear.Text = dt.Year.ToString();
            }
        }
    }
    protected void BindCourse()
    {
        clsCourse obj = new clsCourse();
        ddlCourse.DataSource = obj.LoadAll(obj);
        ddlCourse.DataTextField = "Course";
        ddlCourse.DataValueField = "CourseId";
        ddlCourse.DataBind();
        ddlCourse.Items.Insert(0, new ListItem("-- Select --", ""));
    }
    protected void BindBatchType()
    {
        clsBatchType obj = new clsBatchType();
        ddlBatchType.DataSource = obj.LoadAll(obj);
        ddlBatchType.DataTextField = "BatchType";
        ddlBatchType.DataValueField = "BatchTypeId";
        ddlBatchType.DataBind();
        ddlBatchType.Items.Insert(0, new ListItem("-- Select --", ""));
    }
    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("-- Select --", ""));
    }
    protected void BindBatchTime()
    {
        clsBatchTime obj = new clsBatchTime();
        ddlBatchTime.DataSource = obj.LoadAll(obj);
        ddlBatchTime.DataTextField = "BatchTime";
        ddlBatchTime.DataValueField = "BatchTimeId";
        ddlBatchTime.DataBind();
        ddlBatchTime.Items.Insert(0, new ListItem("-- Select Batch Time --", ""));
    }
    protected void BindEmployee()
    {
        clsEmployee obj = new clsEmployee();
        obj.DesignationId = 2;
        ddlEmployee.DataSource = obj.LoadAll(obj);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("-- Select --", ""));
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.BatchId = Convert.ToInt16(ItemId);
        }
        if (txtDay.Text.Length > 0 && txtMonth.Text.Length > 0 && txtYear.Text.Length > 0)
        {
            int day = Convert.ToInt16(txtDay.Text);
            int month = Convert.ToInt16(txtMonth.Text);
            int year = Convert.ToInt16(txtYear.Text);
            DateTime dt = new DateTime(year, month, day);
            Item.StartDate = dt;
        }
        Item.CourseId = Convert.ToInt16(ddlCourse.SelectedValue);
        Item.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedValue);
        Item.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        Item.EmployeeId = Convert.ToInt16(ddlEmployee.SelectedValue);
        Item.StatusId = Convert.ToInt16(ddlStatus.SelectedValue);
        Item.BatchTimeId = Convert.ToInt16(ddlBatchTime.SelectedValue);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("BatchSearch.aspx");
    }
    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Batch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("BatchSearch.aspx");
    }
}