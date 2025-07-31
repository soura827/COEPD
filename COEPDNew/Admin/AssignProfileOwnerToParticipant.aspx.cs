using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_AssignProfileOwnerToParticipant : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;
    clsParticipant Item;
    
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsParticipant();

        if (ItemId>0)
        {
            if(!IsPostBack)
            {
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    lblParticipant.Text = Item.Participant;
                    if(Item.ProfileOwnerId >0)
                    {
                        clsEmployee objEmployee = new clsEmployee();
                        objEmployee.EmployeeId = Item.ProfileOwnerId;
                        objEmployee = objEmployee.Load(Item.ProfileOwnerId);
                        if(objEmployee !=null)
                        {
                            if(objEmployee.IsActive == true)
                                ddlProfileOwner.SelectedValue = Convert.ToString(Item.ProfileOwnerId);
                        }
                    }
                }
                BindProfileOwner();
            }
        }
        else
        {
            Response.Redirect("ParticipantPlacementAssistanceDataSheetSearchAdmin.aspx");
        }
        

    }
    protected void BindProfileOwner()
    {
        clsEmployee obj = new clsEmployee();
        obj.DesignationId = 20;
        ddlProfileOwner.DataSource = obj.LoadForAll(obj);
        ddlProfileOwner.DataTextField = "Employee";
        ddlProfileOwner.DataValueField = "EmployeeId";
        ddlProfileOwner.DataBind();
        ddlProfileOwner.Items.Insert(0, new ListItem("--Select Profile Owner( HR Executive - Placement Wing)--", "0"));
    }

    protected void btnAssignProfileOwner_Click(object sender, EventArgs e)
    {
        clsParticipant Item = new clsParticipant();
        if(ItemId>0)
        {
            Item.ParticipantId = Convert.ToInt32(ItemId);
        }
        Item.IsProfileOwnerAssigned = true;
        Item.ProfileOwnerId = Convert.ToInt32(ddlProfileOwner.SelectedValue);
        Item.ProfileOwnerAssignedBy = CurrentUser.CurrentUserId;
        Item.AddProfileOwner(Item);
        Response.Redirect("ParticipantPlacementAssistanceDataSheetSearchAdmin.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantPlacementAssistanceDataSheetSearchAdmin.aspx");
    }
}