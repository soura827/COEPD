using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_Campaign : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsCampaign Item = new clsCampaign();
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsCampaign();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                if (Item != null)
                {
                    lblTitle.Text = "Edit Campaign";
                    Item = Item.Load(ItemId);
                    txtTitle.Text = Item.Title;
                    txtCampaign_Keywords.Text = Item.Campaign_Keywords;
                    DateTime dt = Convert.ToDateTime(Item.StartDate);
                    txtStartDay.Text = dt.Day.ToString();
                    txtStartMonth.Text = dt.Month.ToString();
                    txtStartYear.Text = dt.Year.ToString();
                    DateTime dt1 = Convert.ToDateTime(Item.EndDate);
                    txtEndDay.Text = dt.Day.ToString();
                    txtEndMonth.Text = dt.Month.ToString();
                    txtEndYear.Text = dt.Year.ToString();
                    ReqFileUpload.Enabled = false;
                    divAttachemnts.Visible = true;
                    if (Item.FilePath != "")
                    {
                        hplSentFile.NavigateUrl = "~/UserDocs/CampaignDocs/" + Item.FilePath;
                    }
                    else
                    {
                        hplSentFile.Visible = false;
                    }
                    txtUSP1.Text = Item.USP1;
                    txtUSP2.Text = Item.USP2;
                    txtUSP3.Text = Item.USP3;
                    txtUSP4.Text = Item.USP4;
                    txtUSP5.Text = Item.USP5;
                    txtUSP6.Text = Item.USP6;
                    txtUSP7.Text = Item.USP7;
                    txtUSP8.Text = Item.USP8;
                    txtUSP9.Text = Item.USP9;
                    txtUSP10.Text = Item.USP10;
                    if (Item.MobileNumberRequired == true)
                    {
                        chkMobileNumberRequired.Checked = true;
                    }
                    else
                    {
                        chkMobileNumberRequired.Checked = false;
                    }
                    if (Item.EmailIdRequired == true)
                    {
                        chkEmailIdRequired.Checked = true;
                    }
                    else
                    {
                        chkEmailIdRequired.Checked = false;
                    }
                    if (Item.SpecificEnquiryRequired == true)
                    {
                        chkSpecificEnquiryRequired.Checked = true;
                    }
                    else
                    {
                        chkSpecificEnquiryRequired.Checked = false;
                    }
                    if (Item.IsActive == true)
                    {
                        chkActive.Checked = true;
                    }
                    else
                    {
                        chkActive.Checked = false;
                    }

                    txtFollowUpURL.Text = Item.FollowUpURL;
                }
            }

            else
            {
                lblTitle.Text = "Add New Campaign";
                chkActive.Checked = true;
                divAttachemnts.Visible = false;
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.Offer = Convert.ToInt16(ItemId);
        }
        if (txtStartDay.Text.Length > 0 && txtStartMonth.Text.Length > 0 && txtStartYear.Text.Length > 0)
        {
            int day = Convert.ToInt16(txtStartDay.Text);
            int month = Convert.ToInt16(txtStartMonth.Text);
            int year = Convert.ToInt16(txtStartYear.Text);
            DateTime dt = new DateTime(year, month, day);
            Item.StartDate = dt;
        }
        if (txtEndDay.Text.Length > 0 && txtEndMonth.Text.Length > 0 && txtEndYear.Text.Length > 0)
        {
            int day = Convert.ToInt16(txtEndDay.Text);
            int month = Convert.ToInt16(txtEndMonth.Text);
            int year = Convert.ToInt16(txtEndYear.Text);
            DateTime dt1 = new DateTime(year, month, day);
            Item.EndDate = dt1;
        }
        Item.Title = Convert.ToString(txtTitle.Text);
        Item.Campaign_Keywords = Convert.ToString(txtCampaign_Keywords.Text);
        if (flUpload.HasFile)
        {
            clsFileUpload Upload = new clsFileUpload();
            string FilePath = Upload.CampainDocsUploadFile(flUpload);
            Item.FilePath = FilePath;
        }
        Item.USP1 = Convert.ToString(txtUSP1.Text);
        Item.USP2 = Convert.ToString(txtUSP2.Text);
        Item.USP3 = Convert.ToString(txtUSP3.Text);
        Item.USP4 = Convert.ToString(txtUSP4.Text);
        Item.USP5 = Convert.ToString(txtUSP5.Text);
        Item.USP6 = Convert.ToString(txtUSP6.Text);
        Item.USP7 = Convert.ToString(txtUSP7.Text);
        Item.USP8 = Convert.ToString(txtUSP8.Text);
        Item.USP9 = Convert.ToString(txtUSP9.Text);
        Item.USP10 = Convert.ToString(txtUSP10.Text);
        if (chkMobileNumberRequired.Checked == true)
        {
            Item.MobileNumberRequired = true;
        }
        else
        {
            Item.MobileNumberRequired = false;
        }
        if (chkEmailIdRequired.Checked == true)
        {
            Item.EmailIdRequired = true;
        }
        else
        {
            Item.EmailIdRequired = false;
        }
        if (chkSpecificEnquiryRequired.Checked == true)
        {
            Item.SpecificEnquiryRequired = true;
        }
        else
        {
            Item.SpecificEnquiryRequired = false;
        }
        if (chkActive.Checked == true)
        {
            Item.IsActive = true;
        }
        else
        {
            Item.IsActive = false;
        }

        if (chkDeleted.Checked == true)
        {
            Item.IsDeleted = true;
        }
        else
        {
            Item.IsDeleted = false;
        }
        Item.FollowUpURL = Convert.ToString(txtFollowUpURL.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("CampaignSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CampaignSearch.aspx");
    }
}