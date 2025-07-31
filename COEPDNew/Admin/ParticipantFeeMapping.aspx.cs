using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using BusinessLayer;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public partial class Admin_ParticipantFeeMapping : System.Web.UI.Page
{
    int ItemId = 0;
    clsParticipantFeeMapping Item = new clsParticipantFeeMapping();
    CurrentUser CurrentUser = new CurrentUser();
    decimal AgreeFee;
    Decimal dueamt;
    decimal payingfee;
    decimal disc;
    decimal Actualfee;
    DateTime DateTime;
    int FMSId = 0;
    int CountNo = 0;



    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);



        txtServiceOwner.Text = CurrentUser.CurrentName;
        txtServiceOwner.Enabled = false;
        txtAssociates.Text = Convert.ToString( CurrentUser.CurrentName);
        txtAssociates.Enabled = false;
        

        if (!IsPostBack)
        {
          
            BindBatch();
            BindLeadOwner();
            BindServices();
            BindLocation();
            Bindlead();

            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Fee Maaping Details";
                Item = Item.Load(Convert.ToInt32(ItemId));
                if (Item != null)
                {
                  
                    txtSearch.Enabled = false;
                    ddllead.SelectedValue = Convert.ToString(Item.LeadId);
                    ddllead.Enabled = false;
                   
                    ddlLeadOwner.SelectedValue = Convert.ToString(Item.LeadOwnerId);
                    ddlLeadOwner.Enabled = false;
                    ddlBatch.SelectedValue = Convert.ToString(Item.BatchId);
                    // ddlBatch.Enabled = false;
                    ddlServices.SelectedValue = Convert.ToString(Item.ServiceId);
                    ddlServices.Enabled = false;
                    ddlLocation.SelectedValue = Convert.ToString(Item.LocationId);
                    ddlLocation.Enabled = false;
                    ddlServices.Enabled = false;
                    txtDiscounts.Text = Item.Discount.ToString();
                    txtDiscounts.Enabled = false;
                    txtActualFee.Text = Item.ActualFee.ToString();
                    txtActualFee.Enabled = false;
                    txtAgreedFee.Text = Item.AgreedFee.ToString();
                    txtAgreedFee.Enabled = false;

                }

            }
            else
            {
                lblTitle.Text = "Add Participant Fee Mapping Details";
            }

        }
    }

  
    protected void BindBatch()
    {
        clsBatch obj = new clsBatch();
        ddlBatch.DataSource = obj.LoadAll(obj);
        ddlBatch.DataTextField = "Batch";
        ddlBatch.DataValueField = "BatchId";
        ddlBatch.DataBind();
        ddlBatch.Items.Add(new ListItem("Select", "0", true));
        // ddlBatch.Items.Insert(0, new ListItem("-- Select Batch --", ""));
    }
    protected void BindLeadOwner()
    {

        clsEmployee obj = new clsEmployee();
        ddlLeadOwner.DataSource = obj.LoadAll(obj);
        ddlLeadOwner.DataTextField = "Employee";
        ddlLeadOwner.DataValueField = "EmployeeId";
        ddlLeadOwner.DataBind();
        ddlLeadOwner.Items.Insert(0, new ListItem("Search by LeadOwner", ""));
    }
    protected void Bindlead()
    {

        clsLead obj = new clsLead();
        obj.keywords = txtSearch.Text;
        ddllead.DataSource = obj.LoadAll(obj);
        ddllead.DataTextField = "Lead";
        ddllead.DataValueField = "LeadId";
        ddllead.DataBind();
        ddllead.Items.Insert(0, new ListItem("-- Select Lead -- ", ""));
    }

    #region
    //protected void Associates()
    //{
    //    clsEmployee obj = new clsEmployee();
    //    ddlAssociates.DataSource = obj.LoadAll(obj);
    //    ddlAssociates.DataTextField = "Employee";
    //    ddlAssociates.DataValueField = "EmployeeId";
    //    ddlAssociates.DataBind();
    //    ddlAssociates.Items.Insert(0, new ListItem("-- Select Associates  --", ""));
    //}



    //protected void LoadEmployee()
    //{
    //   / clsEmployee item = new clsEmployee();
    //    int itemId = CurrentUser.CurrentEmployeeId;
    //    item = item.Load(itemId);

    //   // txtLocationId.Text = item.LocationId.ToString();

    //}


    #endregion






    protected void BindServices()
    {
        clsService obj = new clsService();
        ddlServices.DataSource = obj.LoadAll(obj);
        ddlServices.DataTextField = "ServiceName";
        ddlServices.DataValueField = "ServiceId";
        ddlServices.DataBind();
        ddlServices.Items.Insert(0, new ListItem("-- Select Services -- ", ""));
    }
    protected void BindLocation()
    {
        clsUser obj = new clsUser();
        obj.UserId = CurrentUser.CurrentUserId;
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        //ddlLocation.Items.Insert(0, new ListItem("-- Select Location -- ", ""));

    }

    protected void BindCode()
    {
        clsParticipantFeeMapping obj = new clsParticipantFeeMapping();
        obj.Lead = Convert.ToString(txtSearch.Text);
        CountNo = obj.LoadLeadValidation(obj);
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtSearch.Text = "";
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        

        clsParticipantFeeMapping obj = new clsParticipantFeeMapping();
        if (ItemId > 0)
        {
            obj.ParticipantFeeMapId = Convert.ToInt32(ItemId);
        }
        obj.LeadId = Convert.ToInt32(ddllead.SelectedValue);
        obj.ServiceId = Convert.ToInt32(ddlServices.SelectedValue);
        obj.ActualFee = Convert.ToDecimal(txtActualFee.Text);
        obj.AgreedFee = Convert.ToDecimal(txtAgreedFee.Text);

        obj.Discount = Convert.ToDecimal(txtDiscounts.Text);

        obj.ServicesName = Convert.ToString(txtAssociates.Text);
        obj.DiscountAssociate = Convert.ToString(txtServiceOwner.Text);


        obj.LeadOwnerId = Convert.ToInt32(ddlLeadOwner.SelectedValue);

       
        obj.BatchId = Convert.ToInt32(ddlBatch.SelectedValue);
        
        obj.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
        obj.CreatedBy = CurrentUser.CurrentUserId;






        Item.AddUpdate(obj);
        ErrorMessage.Text = "Lead Details is sucessfully Added.";
        ErrorMessage.Visible = true;
        //if (ItemId > 0)
        //{
        //    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        //}
        //else
        //{
        //    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        //}
        System.Threading.Thread.Sleep(3000);
        Response.Redirect("InstallmentDiscount.aspx?ddllead=" + ddllead.SelectedValue , false);
        btnSubmit.Enabled = false;





    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantFeeMappingSearch.aspx");
    }

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        if (txtSearch.Text != "")
        {
            Bindlead();
        }
        BindCode();
    }

    protected void ddlServices_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlServices.SelectedIndex > 0)
        {
            switch (Convert.ToInt32(ddlServices.SelectedValue))
            {

                case 0:
                    txtActualFee.Text = "select";
                    break;
                case 1:
                    txtActualFee.Text = "20886";

                    break;
                case 2:
                    txtActualFee.Text = "35000";

                    break;
                case 3:
                    txtActualFee.Text = "41300";

                    break;

            }

        }

    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        divdiscount.Visible = true;
        if (btndiscount.Enabled)
        {
            btnView.Visible = false;
        }

    }

    protected void btndiscount_Click(object sender, EventArgs e)
    {

        if (txtDiscount.Text != "")
        {
            Actualfee = Convert.ToDecimal(txtActualFee.Text);
            disc = Convert.ToDecimal(txtDiscount.Text);

            AgreeFee = (Convert.ToInt32(Actualfee) - Convert.ToInt32(disc));
            txtAgreedFee.Text = Convert.ToString(AgreeFee);
            txtDiscounts.Text = Convert.ToString(disc);
        }
        clsParticipantDiscount Item = new clsParticipantDiscount();
        Item.LeadId = Convert.ToInt32(ddllead.SelectedValue);
        Item.ServiceId = Convert.ToInt32(ddlServices.SelectedValue);

       // Item.services

        ///txtAssociates.Text = CurrentUser.CurrentName;
       // Item.AssociateId = Convert.ToInt32(txtAssociates.Text);
        Item.DiscountAmt = Convert.ToString(txtDiscount.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.ParticipantFeeMapId = Convert.ToInt32(ItemId);
        Item.AddUpdate(Item);
        btndiscount.Visible = false;
        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdating()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", " alertmeSaving()", true);
        }
    }
    protected void txtDueAmt_TextChanged(object sender, EventArgs e)
    {
        if (txtAgreedFee.Text != "")
        {
            AgreeFee = Convert.ToDecimal(txtAgreedFee.Text);
            dueamt = (Convert.ToInt32(AgreeFee) - Convert.ToInt32(payingfee));
        }

    }

    protected void ddllead_TextChanged(object sender, EventArgs e)
    {
        BindCode();
    }

    protected void ddlBatch_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindBatch();
    }
}