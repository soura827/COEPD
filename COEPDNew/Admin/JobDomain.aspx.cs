using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class JobDomain : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsJobDomain Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsJobDomain();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Domain";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtJobDomain.Text = Item.JobDomain;
                    txtDescription.Text = Item.Description;
                }
            }
            else
            {
                lblTitle.Text = "Add New Domain";
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.JobDomainId = Convert.ToInt16(ItemId);
        }

        Item.JobDomain = Convert.ToString(txtJobDomain.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("JobDomainSearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("JobDomainSearch.aspx");
    }
}