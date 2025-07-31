using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class LeaveType : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsLeaveType Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsLeaveType();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                if (Item != null)
                {
                    lblTitle.Text = "Edit Leave Type";
                    Item = Item.Load(ItemId);
                    txtLeaveType.Text = Item.LeaveType;
                    txtDescription.Text = Item.Description;
                }
            }

            else
            {
                lblTitle.Text = "Add New Leave Type";
            }
        }
    }
    
   
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.LeaveTypeId = Convert.ToInt16(ItemId);
        }
        
        Item.LeaveType = Convert.ToString(txtLeaveType.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("LeaveTypeSearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("LeaveTypeSearch.aspx");
    }
}