using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class RepEnquiries : System.Web.UI.Page
{
    CurrentUser currentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindCourse();
            BindPlan();
            DateTime dt = DateTime.Now.AddHours(5).AddMinutes(30);
            txtFromDate.Text = dt.ToString("dd/MM/yyyy");
            txtToDate.Text = dt.ToString("dd/MM/yyyy");
        }
    }

    protected void BindCourse()
    {
        clsCourse obj = new clsCourse();
        ddlCourse.DataSource = obj.LoadAll(obj);
        ddlCourse.DataTextField = "Course";
        ddlCourse.DataValueField = "CourseId";
        ddlCourse.DataBind();
        ddlCourse.Items.Insert(0, new ListItem("-- All --", ""));
        ddlCourse.Items.Add(new ListItem("others", "0"));
    }
    protected void BindPlan()
    {
        clsPlan obj = new clsPlan();
        ddlPlan.DataSource = obj.LoadAll(obj);
        ddlPlan.DataTextField = "TimeRequired";
        ddlPlan.DataValueField = "PlanId";
        ddlPlan.DataBind();
        ddlPlan.Items.Insert(0, new ListItem("-- All --", "0"));
    }

    protected void BindData()
    {
        clsEnquiry Obj = new clsEnquiry();
        if (ddlCourse.SelectedValue == "")
        {
            Obj.CourseId = null;
        }
        else
        {
            Obj.CourseId = Convert.ToInt16(ddlCourse.SelectedValue);
        }
        if (txtFromDate.Text != "")
        {
            Obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        if (txtToDate.Text != "")
        {
            Obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        Obj.PlanId = Convert.ToInt16(ddlPlan.SelectedValue);
        gv.DataSource = Obj.LoadAllReports(Obj);
        gv.DataBind();
    }


    protected void ddlCourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlPlan_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BindData();
    }
}