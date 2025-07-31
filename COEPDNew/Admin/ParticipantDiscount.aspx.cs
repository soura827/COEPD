using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ParticipantDiscount : System.Web.UI.Page
{
    int ItemId = 0;
    int UserId = 0;
    int EmployeeId = 0;
    CurrentUser CurrentUser = new CurrentUser();
    clsParticipantDiscount Item = new clsParticipantDiscount();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        UserId = CurrentUser.CurrentUserId;
        EmployeeId = CurrentUser.CurrentEmployeeId;
        if (!IsPostBack)
        {

            BindParticipant();
            ServiceTaken();
            Associates();
          }
    }
    protected void BindParticipant()
    {
        ddlParticipant.Items.Clear();
        clsLead obj = new clsLead();
        obj.keywords = txtSearch.Text;
        ddlParticipant.DataSource = obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Lead";
        ddlParticipant.DataValueField = "LeadId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant -- ", ""));
    }

    protected void ServiceTaken()
    {
        clsService obj = new clsService();
        ddlService.DataSource = obj.LoadAll(obj);
        ddlService.DataTextField = "ServiceName";
        ddlService.DataValueField = "ServiceId";
        ddlService.DataBind();
        ddlService.Items.Insert(0, new ListItem("-- Select Service --", ""));
    }
    protected void Associates()
    {
        clsEmployee obj = new clsEmployee();
        ddlAssociates.DataSource = obj.LoadAll(obj);
        ddlAssociates.DataTextField = "Employee";
        ddlAssociates.DataValueField = "EmployeeId";
        ddlAssociates.DataBind();
        ddlAssociates.Items.Insert(0, new ListItem("-- Select Associates  --", ""));
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
            Item.DiscountId= Convert.ToInt32(ItemId);
        Item.LeadId =Convert.ToInt32(ddlParticipant.Text);
        Item.ServiceId = Convert.ToInt32(ddlService.Text);
        Item.AssociateId = Convert.ToInt32(ddlAssociates.Text);
        Item.DiscountAmt = txtDiscount.Text;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        //ddlService.DataBind();
        
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
        Response.Redirect("ParticipantDiscountSearch.aspx");
    }

   
    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        ddlParticipant.Items.Clear();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select participant -- ", ""));

        if (txtSearch.Text != "")
        {
          BindParticipant();

        }
    }

    protected void ddlParticipant_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
    protected void ddlService_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
    protected void ddlAssociates_SelectedIndexChanged(object sender, EventArgs e)
    {


    }



}
