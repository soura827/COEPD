using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_SupportType : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsSupportType Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsSupportType();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit SupportType";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtSupportType.Text = Item.SupportType;
                    txtDescription.Text = Item.Description;
                }
            }
            else
            {
                lblTitle.Text = "Add SupportType";
            }
        }

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (ItemId > 0)
        {
            Item.SupportTypeId = Convert.ToInt16(ItemId);
        }

        Item.SupportType = Convert.ToString(txtSupportType.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);

        Response.Redirect("SupportTypeSearch.aspx");
    }
    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupportType.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupportTypeSearch.aspx");
    }
}