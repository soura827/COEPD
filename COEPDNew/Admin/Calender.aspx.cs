using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using BusinessLayer;
public partial class Calender : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsCalender Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsCalender();
        if (!IsPostBack)
        {
            BindCourse();
            BindBatchType();
            BindLocation();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Training Calendar";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    DateTime dtVoucherDate = Convert.ToDateTime(Item.StartDate);
                    txtDay.Text = dtVoucherDate.Day.ToString();
                    txtMonth.Text = dtVoucherDate.Month.ToString();
                    txtYear.Text = dtVoucherDate.Year.ToString();
                    ddlCourse.SelectedValue = Item.CourseId.ToString();
                    ddlBatchType.SelectedValue = Item.BatchTypeId.ToString();
                    ddlLocation.SelectedValue = Item.LocationId.ToString();
                    //if (Item.IsActive == true)
                    //{
                    //    chkIsActive.Checked = true;
                    //}
                    //else
                    //{
                    //    chkIsActive.Checked = false;
                    //}
                }
            }
            else
            {
                lblTitle.Text = "Add New Training Calendar";
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
        ddlCourse.Items.Insert(0, new ListItem("-- Select Course --", ""));
    }
    protected void BindBatchType()
    {
        clsBatchType obj = new clsBatchType();
        ddlBatchType.DataSource = obj.LoadAll(obj);
        ddlBatchType.DataTextField = "BatchType";
        ddlBatchType.DataValueField = "BatchTypeId";
        ddlBatchType.DataBind();
        ddlBatchType.Items.Insert(0, new ListItem("-- Select Batch Type --", ""));
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
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.CalenderId = Convert.ToInt16(ItemId);
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
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.IsActive = true;
        //if (chkIsActive.Checked == true)
        //{
        //    Item.IsActive = true;
        //}
        //else
        //{
        //    Item.IsActive = false;
        //}
        Item.AddUpdate(Item);
        Response.Redirect("CalenderSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CalenderSearch.aspx");
    }
}