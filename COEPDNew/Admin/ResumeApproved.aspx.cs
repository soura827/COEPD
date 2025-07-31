using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_ResumeApproved : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsResumePreparation Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsResumePreparation();

        if (!IsPostBack)
        {
            BindData();
            if (ItemId > 0)
            {
                Item = Item.LoadById(ItemId);
                if (Item != null)
                {
                    lblJobExpDomain.Text = Item.JobExperienceDomain;
                    lblJobExpectedDomain.Text = Item.JobExpectedDomain;
                    lblExpInYears.Text = Item.ExpInYears.ToString();
                    lblExpectedSalary.Text = Item.ExpectedSalary.ToString();
                    lblListOfCompetencies.Text = Item.ListOfCompentencies;
                    lblPreferedLocations.Text = Item.PreferedLocations;
                    lblSkills.Text = Item.Skills;
                    lblComments.Text = Item.Comments;
                    hplResumeView.NavigateUrl = "~/UserDocs/ResumePreparation/" + Item.ResumePath;
                    hplResumeDownload.NavigateUrl = "~/UserDocs/ResumePreparation/" + Item.ResumePath;
                }
            }
        }
    }


   

    protected void btnBackToList_Click(object sender, EventArgs e)
    {
        Response.Redirect("ResumesApprovedSearch.aspx");
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        Item =Item.LoadById(ItemId);
        
        if (txtChat.Text.Length > 0)
        {
            clsResumeChat objResumeChat = new clsResumeChat();
            objResumeChat.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            objResumeChat.ParticipantId = Convert.ToInt16(Item.ParticipantId);
            objResumeChat.ResumeChat = txtChat.Text;
            objResumeChat.CreatedBy = CurrentUser.CurrentUserId;
            objResumeChat.AddUpdate(objResumeChat);
            txtChat.Text = "";

            FormMessage.Text = "Your request is successfully sent.";
            FormMessage.Visible = true;

            Response.Redirect("ResumeApproved.aspx?ItemId=" + ItemId);
        }
    }


    protected void BindData()
    {
        Item = Item.LoadById(ItemId);
        clsResumeChat objChat = new clsResumeChat();
        objChat.ParticipantId = Convert.ToInt32(Item.ParticipantId);
        rp.DataSource = objChat.LoadAll(objChat);
        rp.DataBind();
    }

    protected void rp_OnItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        RepeaterItem item = e.Item;
        if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
        {
            HiddenField hdnRoleId = (HiddenField)item.FindControl("hdnRoleId");
            int RoleId = Convert.ToInt16(hdnRoleId.Value);

            if (RoleId == 2)
            {
                Panel pnlIn = (Panel)item.FindControl("pnlIn");
                pnlIn.Visible = true;
            }
            else
            {
                Panel PnlOut = (Panel)item.FindControl("PnlOut");
                PnlOut.Visible = true;
            }
        }
    }
}