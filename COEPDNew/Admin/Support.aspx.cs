using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_Support : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsSupport Item;
    int ItemId = 0;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsSupport();
       
        if (!IsPostBack)
        {
            BindSupportType();

            if (ItemId > 0)
            {
              
                lblTitle.Text = "Edit Ticket";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtSubject.Text = Item.Subject;
                    txtDescription.Text = Item.Description;
                    ddlSupportType.SelectedValue = Item.SupportTypeId.ToString();
                    ddlPriority.SelectedValue = Item.PriorityId.ToString();
                  //  Item.ModifiedBy = CurrentUser.CurrentName;
                }
            }
            else
            {
               
                
                lblTitle.Text = "Add New Ticket";
            }
        }
    }
    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Support.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupportSearch.aspx");
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.SupportId = Convert.ToInt16(ItemId);
        }

        
        Item.Subject = Convert.ToString(txtSubject.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.SupportTypeId = Convert.ToInt32(ddlSupportType.SelectedValue);
        Item.PriorityId = Convert.ToInt32(ddlPriority.SelectedValue);
        Item.StatusId = 0;
        Item.CreatedBy = CurrentUser.CurrentEmployeeId;
        Item.ModifiedBy = CurrentUser.CurrentName;
        Item.AddUpdate(Item);
        if (ItemId > 0)
        {
            FormMessage.Text = "Ticket successfully updated";
            FormMessage.Visible = true;
        }
        else
        {
            btnSubmit.Enabled = false;
            FormMessage.Text = "Ticket successfully saved";
            FormMessage.Visible = true;
        }
        // Response.Redirect("SupportSearch.aspx");
    }
    protected void BindSupportType()
    {
        clsSupportType obj = new clsSupportType();
        ddlSupportType.DataSource = obj.LoadAll(obj);
        ddlSupportType.DataTextField = "SupportType";
        ddlSupportType.DataValueField = "SupportTypeId";
        ddlSupportType.DataBind();
        ddlSupportType.Items.Insert(0, new ListItem("-- Select SupportType --", ""));

    }
}