using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class LeadRegister : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsLead Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsLead();
        if (!IsPostBack)
        {
            BindBatchType();
            BindCourse();
            BindTrainer();
            BindLocation();
            BindCommunicationType();
            BindLeadCategory();
            if (ItemId > 0)
            {
                lblTitle.Text = "Lead FollowUp";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtLead.Text = Item.Lead;

                    ddlLeadCategory.SelectedValue = Item.LeadCategoryId.ToString();
                    ddlBatchType.SelectedValue = Item.BatchTypeId.ToString();
                    ddlCourse.SelectedValue = Item.CourseId.ToString();
                    ddlLocation.SelectedValue = Item.LocationId.ToString();
                    ddlCommunicationType.SelectedValue = Item.CommunicationTypeId.ToString();
                    txtPrimaryMobile.Text = Item.PrimaryMobile;
                    txtSecondaryMobile.Text = Item.SecondaryMobile;
                    txtPrimaryEmail.Text = Item.PrimaryEmail;
                    txtSecondaryEmail.Text = Item.SecondaryEmail;
                    txtPhone.Text = Item.Phone;
                    txtAddress.Text = Item.Address;
                    clsLeadLink obj = new clsLeadLink();
                    obj.LeadId = ItemId;
                    gv.DataSource = obj.LoadAll(obj);
                    gv.DataBind();
                }
            }
        }
    }

    protected void BindLeadCategory()
    {
        clsLeadCategory obj = new clsLeadCategory();
        ddlLeadCategory.DataSource = obj.LoadAll(obj);
        ddlLeadCategory.DataTextField = "LeadCategory";
        ddlLeadCategory.DataValueField = "LeadCategoryId";
        ddlLeadCategory.DataBind();
        ddlLeadCategory.Items.Insert(0, new ListItem("-- Select LeadCategory --", ""));
    }

    protected void BindBatchType()
    {
        clsBatchType obj = new clsBatchType();
        ddlBatchType.DataSource = obj.LoadAll(obj);
        ddlBatchType.DataTextField = "BatchType";
        ddlBatchType.DataValueField = "BatchTypeId";
        ddlBatchType.DataBind();
        ddlBatchType.Items.Insert(0, new ListItem("-- Select BatchType --", ""));
    }

    protected void BindTrainer()
    {
        clsEmployee obj = new clsEmployee();
        obj.DesignationId = 2;
        ddlTrainer.DataSource = obj.LoadAll(obj);
        ddlTrainer.DataTextField = "Employee";
        ddlTrainer.DataValueField = "EmployeeId";
        ddlTrainer.DataBind();
        ddlTrainer.Items.Insert(0, new ListItem("-- Select Trainer --", ""));
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

    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("-- Select Location --", ""));
    }

    protected void BindCommunicationType()
    {
        clsCommunicationType obj = new clsCommunicationType();
        ddlCommunicationType.DataSource = obj.LoadAll(obj);
        ddlCommunicationType.DataTextField = "CommunicationType";
        ddlCommunicationType.DataValueField = "CommunicationTypeId";
        ddlCommunicationType.DataBind();
        ddlCommunicationType.Items.Insert(0, new ListItem("-- Select CommunicationType --", ""));
    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Lead.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("FollowUpSearch.aspx");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.LeadId = Convert.ToInt16(ItemId);
        }

        Item.Lead = Convert.ToString(txtLead.Text);
        Item.LeadCategoryId = Convert.ToInt16(ddlLeadCategory.SelectedItem.Value);
        Item.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedItem.Value);
        Item.LeadStatusId = Convert.ToInt16(3);
        Item.BranchId = 0;
        Item.CourseId = Convert.ToInt16(ddlCourse.SelectedItem.Value);
        Item.LocationId = Convert.ToInt16(ddlLocation.SelectedItem.Value);
        Item.CommunicationTypeId = Convert.ToInt16(ddlCommunicationType.SelectedItem.Value);
        Item.PrimaryMobile = Convert.ToString(txtPrimaryMobile.Text);
        Item.SecondaryMobile = Convert.ToString(txtSecondaryMobile.Text);
        Item.Phone = Convert.ToString(txtPhone.Text);
        Item.PrimaryEmail = Convert.ToString(txtPrimaryEmail.Text);
        Item.SecondaryEmail = Convert.ToString(txtSecondaryEmail.Text);
        Item.Address = Convert.ToString(txtAddress.Text);
        Item.TrainerId = Convert.ToInt16(ddlTrainer.SelectedItem.Value);
        Item.Fee = Convert.ToDecimal(txtCourseFee.Text);
        if (txtDay.Text.Length > 0 && txtMonth.Text.Length > 0 && txtYear.Text.Length > 0)
        {
            int day = Convert.ToInt16(txtDay.Text);
            int month = Convert.ToInt16(txtMonth.Text);
            int year = Convert.ToInt16(txtYear.Text);
            DateTime dtFDate = new DateTime(year, month, day);
            Item.BatchDate = dtFDate;
        }

        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);

        if (txtNotes.Text.Length > 0)
        {
            clsLeadLink ItemLeadLink = new clsLeadLink();
            ItemLeadLink.LeadId = Convert.ToInt16(ItemId);
            ItemLeadLink.LeadLink = txtNotes.Text;
            ItemLeadLink.CreatedBy = CurrentUser.CurrentUserId;
            ItemLeadLink.AddUpdate(ItemLeadLink);
        }
        if (ItemId > 0)
        {
            FormMessage.Text = "Lead successfully updated";
            FormMessage.Visible = true;
        }
        else
        {
            btnSubmit.Enabled = false;
            FormMessage.Text = "Lead successfully saved";
            FormMessage.Visible = true;
        }
    }

}