using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Enquiry : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsEnquiry Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Item = new clsEnquiry();
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if(!IsPostBack)
        {
            LoadPlan();
            LoadCourse();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Details";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtEmail.Text = Item.Email;
                    txtMobile.Text = Item.Phone;
                    txtName.Text = Item.Name;
                    txtCity.Text = Item.City;
                    txtState.Text = Item.State;
                    txtEnquiry.Text = Item.Message;
                    ddlCourse.SelectedValue = Convert.ToString(Item.CourseId);
                    ddlPlan.SelectedValue = Item.PlanId.ToString();
                }
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.EnquiryId = Convert.ToInt16(ItemId);
        }
        Item.Email = txtEmail.Text;
        Item.Phone = txtMobile.Text;
        Item.Name = txtName.Text;
        Item.City = txtCity.Text;
        Item.State = txtState.Text;
        Item.Message = txtEnquiry.Text;
        Item.CourseId = Convert.ToInt16(ddlCourse.SelectedValue);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.PlanId = Convert.ToInt16(ddlPlan.SelectedValue);
        Item.AddUpdate(Item);
        Response.Redirect("EnquirySearch.aspx");
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
    protected void LoadCourse()
    {
        clsCourse Item = new clsCourse();
        ddlCourse.DataSource = Item.LoadAll(Item);
        ddlCourse.DataTextField = "Course";
        ddlCourse.DataValueField = "CourseId";
        ddlCourse.DataBind();
        ddlCourse.Items.Insert(0, new ListItem("-- Select Course--", ""));
        ddlCourse.Items.Add(new ListItem("others", "0"));
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("EnquirySearch.aspx");
    }
}