using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using BusinessLayer;
public partial class Job : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsJob Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsJob();
        if (!IsPostBack)
        {
            BindJobCategory();
            BindJobDomain();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Job";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlJobCategory.SelectedValue = Item.JobCategoryId.ToString();
                    ddlJobDomain.SelectedValue = Item.JobDomainId.ToString();
                    txtJobTitle.Text = Item.JobTitle;
                    txtLocation.Text = Item.Location;
                    txtCompany.Text = Item.Company;
                    txtPhone.Text = Item.Phone;
                    txtEmail.Text = Item.Email;
                    txtExperience.Text = Item.Experience;
                    txtWeblink.Text = Item.Weblink;
                    txtFullDescription.Text = Item.FullDescription;
                    DateTime dtVoucherDate = Convert.ToDateTime(Item.JobDate);
                    txtDay.Text = dtVoucherDate.Day.ToString();
                    txtMonth.Text = dtVoucherDate.Month.ToString();
                    txtYear.Text = dtVoucherDate.Year.ToString();
                }
            }
            else
            {
                lblTitle.Text = "Add New Job";
                DateTime dt;
                dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                txtDay.Text = dt.Day.ToString();
                txtMonth.Text = dt.Month.ToString();
                txtYear.Text = dt.Year.ToString();
            }
        }
    }
    protected void BindJobCategory()
    {
        clsJobCategory obj = new clsJobCategory();
        ddlJobCategory.DataSource = obj.LoadAll(obj);
        ddlJobCategory.DataTextField = "JobCategory";
        ddlJobCategory.DataValueField = "JobCategoryId";
        ddlJobCategory.DataBind();
        ddlJobCategory.Items.Insert(0, new ListItem("-- Select Category --", ""));
    }

    protected void BindJobDomain()
    {
        clsJobDomain obj = new clsJobDomain();
        ddlJobDomain.DataSource = obj.LoadAll(obj);
        ddlJobDomain.DataTextField = "JobDomain";
        ddlJobDomain.DataValueField = "JobDomainId";
        ddlJobDomain.DataBind();
        ddlJobDomain.Items.Insert(0, new ListItem("-- Select Domain --", "0"));
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (ItemId > 0)
        {
            Item.JobId = Convert.ToInt32(ItemId);
        }

        Item.JobCategoryId = Convert.ToInt32(ddlJobCategory.SelectedItem.Value);
        Item.JobDomainId = Convert.ToInt32(ddlJobDomain.SelectedItem.Value);
        Item.JobTitle = Convert.ToString(txtJobTitle.Text);
        Item.Location = Convert.ToString(txtLocation.Text);
        Item.Company = Convert.ToString(txtCompany.Text);
        Item.Phone = Convert.ToString(txtPhone.Text);
        Item.Email = Convert.ToString(txtEmail.Text);
        Item.Experience = Convert.ToString(txtExperience.Text);
        Item.Weblink = Convert.ToString(txtWeblink.Text);
        Item.Company = Convert.ToString(txtCompany.Text);

        if (txtDay.Text.Length > 0 && txtMonth.Text.Length > 0 && txtYear.Text.Length > 0)
        {
            int day = Convert.ToInt32(txtDay.Text);
            int month = Convert.ToInt32(txtMonth.Text);
            int year = Convert.ToInt32(txtYear.Text);
            DateTime dt = new DateTime(year, month, day);
            Item.JobDate = dt;
        }
        Item.FullDescription = Convert.ToString(txtFullDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);

        Response.Redirect("JobSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("JobSearch.aspx");
    }
}