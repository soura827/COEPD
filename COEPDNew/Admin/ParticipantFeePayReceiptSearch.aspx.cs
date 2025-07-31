using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ParticipantFeePayReceiptSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void setGridView()
    {
        if (CurrentUser.IsAdmin == false)
        {
            //gv.Columns[0].Visible = false;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            BindData();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantFeePayReceipt.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindData()
    {
        clsParticipantFeePayReceipt obj = new clsParticipantFeePayReceipt();
       // obj.ParticipantId = 0;
        //obj.PaymentTypeId = Convert.ToInt16(0);
       // obj.CompanyId = 0;
       // obj.keywords = txtSearch.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
       // setGridView();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("ParticipantFeePayReceipt.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdReceipt")
        {
            Response.Redirect("ReceiptPrints.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsParticipantFeePayReceipt Item = new clsParticipantFeePayReceipt();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            //ErrorMessage.Text = "Receipt successfully removed";
            //ErrorMessage.Visible = true;
        }

    }





}