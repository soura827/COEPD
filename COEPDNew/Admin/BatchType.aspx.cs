using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class BatchType : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsBatchType Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsBatchType();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit BatchType";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtBatchType.Text = Item.BatchType;
                    txtDescription.Text = Item.Description; 
                }
            }
            else
            {
                lblTitle.Text = "Add BatchType";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.BatchTypeId = Convert.ToInt16(ItemId);
        }

        Item.BatchType = Convert.ToString(txtBatchType.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId; 
        Item.AddUpdate(Item);
        Response.Redirect("BatchTypeSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("BatchTypeSearch.aspx");
    }
}