using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Text.RegularExpressions;
public partial class IdeaPost : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsIdeaPost Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsIdeaPost();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Your Feedback";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtSubject.Text = Item.Subject;
                    txtDescription.Text = Item.Description;          
                }
            }
            else
            {
                lblTitle.Text = "Add Your Feedback";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.IdeaPostId = Convert.ToInt16(ItemId);
        }
        Item.Subject = Convert.ToString(txtSubject.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        if (CurrentUser.CurrentRoleId == 2)
        {
            Item.EmployeeId = CurrentUser.CurrentEmployeeId;
            Item.CreatedBy = CurrentUser.CurrentEmployeeId;
            Item.BranchId = CurrentUser.UserBranchId;
        }
        else
        {
            Item.ParticipantId = CurrentUser.CurrentParticipantId;
            Item.CreatedBy = CurrentUser.CurrentParticipantId;
            Item.BranchId = CurrentUser.UserBranchId;
        }
        Item.AddUpdate(Item);
        Response.Redirect("IdeaPostSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("IdeaPostSearch.aspx");
    }
}