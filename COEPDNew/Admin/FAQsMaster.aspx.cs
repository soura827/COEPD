using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_FAQsMaster : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsFAQsMaster Item = new clsFAQsMaster();
    clsHrRequestFAQs Items = new clsHrRequestFAQs(); 

    string ItemId = "";
    string HRFId = "";   


    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Request.QueryString["ItemId"];
        Item.RevisedBy = CurrentUser.CurrentUserId;

        HRFId = Request.QueryString["HRFId"];
       

        Item = new clsFAQsMaster();
        Items = new clsHrRequestFAQs();

        if (!IsPostBack)
        {
            LoadInterviewStatus();   


            Item = Item.Load(ItemId);

            Items = Items.Load(Convert.ToInt32(HRFId));
            if (Item != null)
            {
               

                lblTitle.Text = "Edit FAQs";

                lblIsRevised.Visible = true;
                chkIsReviesed.Visible = true;
                txtCompany.Enabled = false;
                txtExperience.Enabled = false;
                txtSkilSet.Enabled = false;
                ddlInterviewStatus.Enabled = false;

                hdnFAQsId.Value = Convert.ToString(Item.FAQsId);

                ddlInterviewStatus.SelectedValue = Convert.ToString(Item.InterviewStatusId);
                txtCompany.Text = Item.CompanyName;
                txtExperience.Text = Item.Experience;
                txtSkilSet.Text = Item.SkilSet;
                txtNoOfQuestions.Text = Item.NoOfQuestions.ToString();
                if (Item.IsRevised == true)
                {
                    chkIsReviesed.Checked = true;
                    chkIsReviesed.Enabled = false;
                }
                else
                {
                    chkIsReviesed.Checked = false;
                }

                txtFAQNote.Text = Item.FAQs.ToString();

            }
            else if (HRFId != null)
            {

                lblTitle.Text = "Add FAQs";
                lblIsRevised.Visible = false;
                chkIsReviesed.Visible = false;

                ddlInterviewStatus.SelectedValue = Convert.ToString(Items.InterviewStatusId);
                hdnRSId.Value = Convert.ToString(Items.ResumeSubmissionId);
                txtCompany.Text = Items.CompanyName;
                txtExperience.Text = Items.Experience;
                txtSkilSet.Text = Items.JobDescription;
                hdnHrRequestFAQsId.Value = Items.HrRequestFAQsId.ToString();



            }
            else
            {
                lblTitle.Text = "Add FAQs";
            }

        }

    }
    protected void LoadInterviewStatus()
    {
        clsJobApplied obj = new clsJobApplied();
        ddlInterviewStatus.DataSource = obj.LoadAllInterviewStatus(obj);
        ddlInterviewStatus.DataTextField = "InterviewStatus";
        ddlInterviewStatus.DataValueField = "InterviewStatusId";
        ddlInterviewStatus.DataBind();
        ddlInterviewStatus.Items.Insert(0, new ListItem("-- Select Interview Round --", ""));


    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(hdnFAQsId.Value) > 0)
        {
            Item.FAQsId = Convert.ToInt32(hdnFAQsId.Value);
        }
        Item.InterviewStatusId = Convert.ToInt32(ddlInterviewStatus.SelectedValue);
        Item.CompanyName = Convert.ToString(txtCompany.Text);
        Item.SkilSet = Convert.ToString(txtSkilSet.Text);
        Item.Experience = txtExperience.Text;
        Item.NoOfQuestions = Convert.ToInt32(txtNoOfQuestions.Text);
        string id = Guid.NewGuid().ToString();
        Item.UniqueId = Convert.ToString(id);
        Item.FAQs = txtFAQNote.Text;
        Item.IsSourceParticipant = false;
        if (HRFId == null)
        {
            if (chkIsReviesed.Checked == true)
            {
                Item.IsRevised = true;
                Item.RevisedBy = CurrentUser.CurrentEmployeeId;
                DateTime Date = DateTime.UtcNow;
                Date = Date.AddHours(5).AddMinutes(30);
                Item.RevisedOn = Date;

            }
            else
            {
                Item.IsRevised = false;
            }
        }
           
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);


        if (HRFId != null)
        {
            clsHrRequestFAQs Items = new clsHrRequestFAQs();
            if (Convert.ToInt32(hdnHrRequestFAQsId.Value) > 0)
            {
                Items.HrRequestFAQsId = Convert.ToInt32(hdnHrRequestFAQsId.Value);
            }
            Items.CreatedBy = CurrentUser.CurrentUserId;
            Items.ResumeSubmissionId = Convert.ToInt32(hdnRSId.Value);
            Items.IsSent = true;
            Items.AddUpdate(Items);
            Response.Redirect("HrRequestFAQsSearch.aspx");
        }
        else
        {
            Response.Redirect("FAQsMasterSearch.aspx");

        }


    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        if (HRFId != null)
        {
            Response.Redirect("HrRequestFAQsSearch.aspx");
        }
        else
        {
            Response.Redirect("FAQsMasterSearch.aspx");
        }
    
    }
}





