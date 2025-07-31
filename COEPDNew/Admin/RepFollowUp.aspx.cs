using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_RepFollowUp : System.Web.UI.Page
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
            DateTime dateTime;
            dateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            // txtFromDate.Text = dateTime.ToString("dd/MM/yyyy");
            txtToDate.Text = dateTime.ToString("dd/MM/yyyy");
            BindCourse();
            BindBatchType();
            BindLocation();
           
            BindEmployee();
            // BindData();

            gv.Caption = "FollowUp Reports Of " + txtFromDate.Text;
        }
    }

    protected void BindCourse()
    {
        clsCourse obj = new clsCourse();
        ddlCourse.DataSource = obj.LoadAll(obj);
        ddlCourse.DataTextField = "Course";
        ddlCourse.DataValueField = "CourseId";
        ddlCourse.DataBind();
        ddlCourse.Items.Insert(0, new ListItem("-- Select Course --", "0"));
    }

    protected void BindBatchType()
    {
        clsBatchType obj = new clsBatchType();
        ddlBatchType.DataSource = obj.LoadAll(obj);
        ddlBatchType.DataTextField = "BatchType";
        ddlBatchType.DataValueField = "BatchTypeId";
        ddlBatchType.DataBind();
        ddlBatchType.Items.Insert(0, new ListItem("-- Select BatchType --", "0"));
    }

    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("-- Select Locations --", "0"));
    }

  

    protected void BindEmployee()
    {
        clsEmployee obj = new clsEmployee();
        ddlEmployee.DataSource = obj.LoadAll(obj);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("-- Select Employee --", "0"));
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
            obj.LeadStatusId = Convert.ToInt16(2);
            obj.EmployeeId = Convert.ToInt16(ddlEmployee.SelectedValue);
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

            if (ddlEmployee.SelectedValue != "0")
            {
                gv.Caption = " FollowUp Reports Of " + ddlEmployee.SelectedItem + " From " + txtFromDate.Text + " To " + txtToDate.Text;
                gv.DataSource = obj.LoadAllReport(obj);
                gv.DataBind();
            }
            else
            {
                gv.Caption = "FollowUp Reports From " + txtFromDate.Text + " To " + txtToDate.Text;
                gv.DataSource = obj.LoadAllReport(obj);
                gv.DataBind();
            }
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

   

    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}