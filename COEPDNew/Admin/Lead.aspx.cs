using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public partial class Lead : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsLead Item;
    int ItemId = 0;
    int CountNo = 0;
    string strMessage = string.Empty;
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
            BindLeadSource();
            BindCourse();
            BindLocation();

            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Lead";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtLead.Text = Item.Lead;
                    ddlBatchType.SelectedValue = Item.BatchTypeId.ToString();
                    ddlLeadSource.SelectedValue = Item.LeadSourceId.ToString();
                    ddlCourse.SelectedValue = Item.CourseId.ToString();
                    ddlLocation.SelectedValue = Item.LocationId.ToString();
                    txtPrimaryMobile.Text = Item.PrimaryMobile;
                    txtSeondaryMobile.Text = Item.SecondaryMobile;
                    txtPrimaryEmail.Text = Item.PrimaryEmail;
                    txtSeondaryEmail.Text = Item.SecondaryEmail;
                    txtPhone.Text = Item.Phone;
                    txtAddress.Text = Item.Address;
                    txtdomain.Text = Item.Domain;
                    txtexp.Text = Item.Experience;
                }
            }
            else
            {
                lblTitle.Text = "Add New Lead";

            }
        }
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

    protected void BindLeadSource()
    {
        clsLeadSource obj = new clsLeadSource();
        ddlLeadSource.DataSource = obj.LoadAll(obj);
        ddlLeadSource.DataTextField = "LeadSource";
        ddlLeadSource.DataValueField = "LeadSourceId";
        ddlLeadSource.DataBind();
        ddlLeadSource.Items.Insert(0, new ListItem("-- Select Lead Source --", ""));
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
        ddlLocation.Items.Insert(0, new ListItem("-- Select Location --", "0"));
    }

    protected void BindLeadOwner()
    {
        clsEmployee obj = new clsEmployee();
        obj.keywords = txtLeadSource.Text;
        ddlLeadOwner.DataSource = obj.LoadAll(obj);
        ddlLeadOwner.DataTextField = "Employee";
        ddlLeadOwner.DataValueField = "EmployeeId";
        ddlLeadOwner.DataBind();
        ddlLeadOwner.Items.Insert(0, new ListItem("-- Select Lead Owner --", "0"));
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.LeadId = Convert.ToInt16(ItemId);
        }
        Item.Lead = Convert.ToString(txtLead.Text);
        Item.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedItem.Value);
        Item.LeadSourceId = Convert.ToInt16(ddlLeadSource.SelectedItem.Value);
        Item.LeadStatusId = Convert.ToInt16(1);
        Item.BranchId = 0;
        Item.CourseId = Convert.ToInt16(ddlCourse.SelectedItem.Value);
        Item.LocationId = Convert.ToInt16(ddlLocation.SelectedItem.Value);
        Item.CommunicationTypeId = Convert.ToInt16(0);
        Item.PrimaryMobile = Convert.ToString(txtPrimaryMobile.Text);
        Item.SecondaryMobile = Convert.ToString(txtSeondaryMobile.Text);
        Item.PrimaryEmail = Convert.ToString(txtPrimaryEmail.Text);
        Item.SecondaryEmail = Convert.ToString(txtSeondaryEmail.Text);
        Item.Phone = Convert.ToString(txtPhone.Text);
        Item.Address = Convert.ToString(txtAddress.Text);
        Item.LeadDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        Item.FollowUpDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.LeadOwner = Convert.ToInt32(ddlLeadOwner.SelectedValue);
        Item.Domain = Convert.ToString(txtdomain.Text);
        Item.Experience = Convert.ToString(txtexp.Text);
        Item.ServiceOwnerId = Convert.ToString(CurrentUser.CurrentUserId);
        Item.AddUpdate(Item);
        Response.Redirect("LeadSearch.aspx", false);
        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("LeadSearch.aspx");
    }

    protected void txtLeadSource_TextChanged(object sender, EventArgs e)
    {
        if (txtLeadSource.Text != null)
        {
            BindLeadOwner();
        }
    }



    protected void BindMobile()
    {
        clsLead obj = new clsLead();
        obj.PrimaryMobile = Convert.ToString(txtPrimaryMobile.Text);
        CountNo = obj.LoadLeadMobileValidation(obj);
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicateMobile()", true);
            txtPrimaryMobile.Text = "";
        }
    }

    protected void BindEmail()
    {
        clsLead obj = new clsLead();
        obj.PrimaryEmail = Convert.ToString(txtPrimaryEmail.Text);
        CountNo = obj.LoadLeadEmailValidation(obj);
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicateEmail()", true);
            txtPrimaryEmail.Text = "";
        }
    }
    protected void txtPrimaryMobile_TextChanged(object sender, EventArgs e)
    {
        BindServiceOwner();
       // BindMobile();
    }

    protected void txtPrimaryEmail_TextChanged(object sender, EventArgs e)
    {
        BindServiceOwner();
        //BindEmail();
    }

    protected void BindServiceOwner()
    {

        string strAwards = string.Empty;
        List<clsLead> Items = new List<clsLead>();
        clsLead obj = new clsLead();
        if (txtPrimaryMobile.Text != string.Empty)
            obj.PrimaryMobile = txtPrimaryMobile.Text;
        if (txtPrimaryEmail.Text != string.Empty)
            obj.PrimaryEmail = txtPrimaryMobile.Text;
        Items = obj.LoadAll_ServiceOwner(obj);

        if (Items != null)
        {

            foreach (clsLead item in Items)
            {
                //strAwards = strAwards + "&nbsp;" + item.CertificateId + "::&nbsp;&nbsp;";
                strAwards = strAwards + "Lead Assigned to  : " + item.Fullname + "      " + "  Location:" + item.Location ;
                break;
            }
            strAwards = strAwards.Replace("<p>", "");
            strAwards = strAwards.Replace("</p>", "");
            strMessage = strAwards;
        }


        if (strMessage.Length > 0)
        {
            ErrorMessage.Visible = false;
            
            //ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + strMessage + "');", true);

            string script = $"alert('{strMessage.Replace("'", "\\'")}');";
            ClientScript.RegisterStartupScript(this.GetType(), "PopupScript", script, true);




        }
        else
        {
            FormMessage.Visible = false;
            ErrorMessage.Visible = true;
            ErrorMessage.Text = "<span class=color:red>Email / Certificate Id  invalid. Please try again with correct Email / Certificate Id.</span>";
        }



    }










}