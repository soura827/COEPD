using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_InstallmentEdits : System.Web.UI.Page
{
    int ItemId = 0;
    int UserId = 0;
    int EmployeeId = 0;
    int Total = 0;
    int ItemNumber = 0;

    DateTime DateTime;
    CurrentUser CurrentUser = new CurrentUser();
    clsFeeInstallment Item = new clsFeeInstallment();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {


      



        ItemNumber = Convert.ToInt32(Request.QueryString["ItemNumber"]);
        clsFeeInstallment Item = new clsFeeInstallment();


        if (!IsPostBack)
        {
            BindLead();
           // BindBatch();


            if (ItemNumber > 0)
            {



                Item = Item.LoadEdit(ItemNumber);
                if (Item != null)
                {






                    ddlParticipant.SelectedValue = Convert.ToString(Item.LeadId);
                    txtServiceOwner.Text = Convert.ToString(Item.ServiceOwner);
                    //ddlBatch.SelectedValue = Convert.ToString(Item.BatchDate);
                    ddlInstallments.SelectedValue = Convert.ToString(Item.Installments);

       
                    txtInstallDate.Text = Item.InstallmentDate.ToString("yyyy-MM-dd");



                    //= Convert.ToString(Item.InstallmentDate);
                    txtAgree.Text = Convert.ToString(Item.AgreedFee);
                    txtPayAmt.Text = Convert.ToString(Item.Amount);
                    txtDueAmt.Text = Convert.ToString(Item.Due);

                    ddlStatus.SelectedValue = Convert.ToString(Item.IsInstallmentStatus);
                   
                   
                 








                }
            }




        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {



        clsFeeInstallment Item = new clsFeeInstallment();
        if (ItemNumber > 0)
        {
            Item.FeeInstallmentId = Convert.ToInt32(ItemNumber);
        }
        Item.LeadId = Convert.ToInt32(ddlParticipant.SelectedValue);
        Item.Installments = Convert.ToString(ddlInstallments.SelectedValue);
        Item.InstallmentDate = Convert.ToDateTime(txtInstallDate.Text);
        Item.AgreedFee = Convert.ToDecimal(txtAgree.Text);
        Item.Amount = Convert.ToDecimal(txtPayAmt.Text);
        Item.IsInstallmentStatus = Convert.ToBoolean(ddlStatus.SelectedValue);

        Item.ParticipantFeeMapId = Convert.ToInt32(ddlParticipant.SelectedValue);

        Item.Due = txtDueAmt.Text;
        Item.ServiceOwner = txtServiceOwner.Text;
        Item.CreatedBy = CurrentUser.CurrentUserId;

        Item.AddUpdate(Item);
        if (ItemNumber > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }

    




     }
    protected void BindLead()
    {

        clsLead obj = new clsLead();
        ddlParticipant.DataSource = obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Lead";
        ddlParticipant.DataValueField = "LeadId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant -- ", ""));

    }
    //protected void BindBatch()
    //{
    //    clsBatch obj = new clsBatch();
    //    ddlBatch.DataSource = obj.LoadAll(obj);
    //    ddlBatch.DataTextField = "Batch";
    //    ddlBatch.DataValueField = "BatchId";
    //    ddlBatch.DataBind();
    //    ddlBatch.Items.Add(new ListItem("Select", "0", true));
    //    // ddlBatch.Items.Insert(0, new ListItem("-- Select Batch --", ""));
    //}
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("InstallmentFollowUp.aspx");
    }

    protected void ddlInstallments_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    //protected void ddlBatch_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //}
}