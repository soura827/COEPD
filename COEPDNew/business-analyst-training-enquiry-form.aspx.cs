using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class business_analyst_training_enquiry_form : System.Web.UI.Page
{
    int CountNo = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCourse();
            LoadPlan();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsEnquiry obj = new clsEnquiry();
        obj.Email = txtEmail.Text;
        obj.Phone = txtMobile.Text;
        obj.Name = txtName.Text;
        obj.State = txtState.Text;
        obj.City = txtCity.Text;
        if (ddlCourse.SelectedValue == "0")
        {
            obj.CourseId = Convert.ToInt32(ddlCourse.SelectedValue);
            obj.CourseName = Request.Form["txtCourse"];
        }
        else
        {
            obj.CourseId = Convert.ToInt32(ddlCourse.SelectedValue);
        }
        
        obj.PlanId = Convert.ToInt16(ddlPlan.SelectedValue);
        obj.Message = txtEnquiry.Text;
        obj.CreatedBy = 1;
        obj.AddUpdate(obj);
        txtName.Text = "";
        txtMobile.Text = "";
        txtEmail.Text = "";
        txtState.Text = "";
        txtCity.Text = "";
        txtEnquiry.Text = "";
        ddlCourse.SelectedValue = "";
        ddlPlan.SelectedValue = "";
        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
    }
    protected void LoadCourse()
    {
        //clsCourse Item = new clsCourse();
        //ddlCourse.DataSource = Item.LoadAll(Item);
        //ddlCourse.DataTextField = "Course";
        //ddlCourse.DataValueField = "CourseId";
        //ddlCourse.DataBind();
        ddlCourse.Items.Insert(0, new ListItem("-- Select Course --", ""));
        ddlCourse.Items.Insert(1, new ListItem("Business Analyst", "1"));
        ddlCourse.Items.Add(new ListItem("Others", "0"));
    }
    protected void LoadPlan()
    {
        clsPlan Item = new clsPlan();
        ddlPlan.DataSource = Item.LoadAll(Item);
        ddlPlan.DataTextField = "TimeRequired";
        ddlPlan.DataValueField = "PlanId";
        ddlPlan.DataBind();
        ddlPlan.Items.Insert(0, new ListItem("-- Select --", ""));
    }
    protected void BindValidation()
    {
        clsEnquiry obj = new clsEnquiry();
        obj.Email = txtEmail.Text;
        obj.Phone = txtMobile.Text;
        CountNo = obj.LoadEnquiryValidation(obj);
        if (CountNo > 0)
        {
            txtEmail.Text = "";
            txtMobile.Text = "";
        }
    }

    protected void txtEmail_TextChanged(object sender, EventArgs e)
    {
        BindValidation();
    }
}