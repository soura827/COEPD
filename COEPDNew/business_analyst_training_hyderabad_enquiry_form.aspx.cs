using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class business_analyst_training_hyderabad_enquiry_form : System.Web.UI.Page
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
        clsEnquiryHyderabad obj = new clsEnquiryHyderabad();
        obj.Email1 = txtEmail1.Text;
        obj.Email2 = txtEmail2.Text;
        obj.Domain =txtDomains.Text;
        obj.Experience =txtExperience.Text; 
        obj.Qualification =txtQualification.Text;
        obj.Phone1 = txtMobile1.Text;
        obj.Phone2 = txtMobile2.Text;
        obj.SMS = SMS.Checked;
        obj.Friend = Friend.Checked;
        obj.Email = Email.Checked;
        obj.Website =WebSite.Checked;
        obj.SocialNetworking = SocialNetworking.Checked;
        obj.WalkIn = WalkIn.Checked;
        obj.Agree = Agree.Checked;
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
        obj.Message1 = txtgoal1.Text;
        obj.Message2 = txtgoal2.Text;

        obj.CreatedBy = 1;
        obj.AddUpdate(obj);
        txtName.Text = "";

        txtMobile1.Text = "";
        txtMobile2.Text = "";
        txtEmail1.Text = "";
        txtEmail2.Text = "";
        txtExperience.Text = "";
        txtDomains.Text = "";
        txtQualification.Text = "";
        txtState.Text = "";
        txtCity.Text = "";
        txtgoal1.Text = "";
        SMS.Checked = false;

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
        clsEnquiryHyderabad obj = new clsEnquiryHyderabad();
        obj.Email1 = txtEmail1.Text;
       // obj.Email2 = txtEmail2.Text;
        obj.Phone1 = txtMobile1.Text;
       // obj.Phone2 = txtMobile2.Text;
        CountNo = obj.LoadEnquiryValidation(obj);
        if (CountNo > 0)
        {
            txtEmail1.Text = "";
            txtMobile1.Text = "";
        }
    }

    protected void txtEmail_TextChanged(object sender, EventArgs e)
    {
        BindValidation();
    }
}