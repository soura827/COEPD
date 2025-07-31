using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Configuration;

public partial class Admin_InstallmentDiscount : System.Web.UI.Page
{
    int ItemId = 0;
    int UserId = 0;
    int EmployeeId = 0;
    int Total = 0;

    DateTime DateTime;
    CurrentUser CurrentUser = new CurrentUser();
    clsFeeInstallment Item = new clsFeeInstallment();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        UserId = CurrentUser.CurrentUserId;
        EmployeeId = CurrentUser.CurrentEmployeeId;
        ItemId = Convert.ToInt32(Request.QueryString["ddllead"]);
        txtServiceOwner.Text = CurrentUser.CurrentName;
        if (!IsPostBack)
        {
            BindLead();
            ddlParticipant.SelectedValue = Convert.ToString(ItemId);

            BindData();
        
            if (ItemId > 0)
            {
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtServiceOwner.Enabled = false;
                    lblTitle.Text = "Edit InstallMent  Details";
                    ddlParticipant.Enabled = false;
                 
                    txtAgree.Text = Item.AgreedFee.ToString();
                 
                }

            }
            else
            {
                lblTitle.Text = "Lead InstallMent  Details";
            }

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
    protected void BindData()
    {
        clsFeeInstallment obj = new clsFeeInstallment();
        obj.LeadId = Convert.ToInt32(ddlParticipant.SelectedValue);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
   

    protected void btnSubmit_Click(object sender, EventArgs e)
    {


        System.Threading.Thread.Sleep(50);
        clsFeeInstallment Item = new clsFeeInstallment();
        Item.LeadId = Convert.ToInt32(ddlParticipant.SelectedValue);       
        Item.Installments = Convert.ToString(ddlInstallments.SelectedValue);
        Item.InstallmentDate = Convert.ToDateTime(txtInstallDate.Text);
        Item.AgreedFee = Convert.ToDecimal(txtAgree.Text);
        Item.Amount = Convert.ToDecimal(txtPayAmt.Text);


        Item.IsInstallmentStatus = Convert.ToBoolean(ddlStatus.SelectedValue);
        Item.ParticipantFeeMapId = Convert.ToInt32(ItemId);
        Item.Due = txtDueAmt.Text;
        Item.ServiceOwner = txtServiceOwner.Text;
        Item.CreatedBy = CurrentUser.CurrentUserId;

        Item.AddUpdate(Item);
        //btnSubmit.Enabled = false;  
        txtDueAmt.Text = "";
        txtInstallDate.Text = "";
        txtPayAmt.Text = "";
        ddlInstallments.SelectedValue = "0";
        //txtAgree.Text = "";
        ddlStatus.SelectedValue = "";
        txtServiceOwner.Text = "";
        BindData();
        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }

    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
    protected void gv_PreRender(object sender, EventArgs e)
    {
        int TotalRecords = 0;
        string Records = "";
        TotalRecords = (gv.PageSize * (gv.PageIndex + 1));
        if (TotalRecords > Total)
        {
            Records = Total.ToString();
        }
        else
        {
            Records = TotalRecords.ToString();
        }
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("InstallmentFollowUp.aspx");
    }


    protected void ddlInstallments_SelectedIndexChanged(object sender, EventArgs e)
    {
      

    }
}