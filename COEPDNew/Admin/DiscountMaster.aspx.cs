using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_DiscountMaster : System.Web.UI.Page
{
    int ItemId = 0;
    int UserId = 0;
    int EmployeeId = 0;
    CurrentUser CurrentUser = new CurrentUser();
    clsDiscountMaster   Item = new clsDiscountMaster();
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

            if (ItemId > 0)
            {
               // lblTitle.Text = "";

            }

            else
            {
                lblTitle.Text = "Employee  Discount Master  Details";
            }
         
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DiscountMasterSearch.aspx");
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsDiscountMaster Item = new clsDiscountMaster();
        if (ItemId > 0)
        {
            Item.DiscountMasterId = Convert.ToInt32(ItemId);
        }
        Item.DiscountGivenTo = txtSearch.Text;
        Item.DiscountAmt = txtDiscountAmt.Text;
        Item.Description = txtDescription.Text;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.DIscountMasterAddUpdate(Item);
        txtSearch.Text = "";
        txtDiscountAmt.Text = "";
        txtDescription.Text = "";
        


        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }
    }
}