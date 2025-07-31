using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class CMS : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsCMS Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsCMS();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Web Page";
                Item = Item.Load(ItemId);
                txtCannonicalLink.Text = Item.CannonicalLink;
                txtCMSTitle.Text = Item.CMSTitle;
                txtMetaTitle.Text = Item.MetaTitle;
                txtMetaContent.Text = Item.MetaContent;
                txtMetaDescription.Text = Item.MetaDescription;
                txtCMSData.Text = Item.CMSContent;
            }
            else
            {
                lblTitle.Text = "Add Web Page";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.CMSId = Convert.ToInt16(ItemId);
        }
        Item.CannonicalLink = Convert.ToString(txtCannonicalLink.Text);
        Item.CMSTitle = Convert.ToString(txtCMSTitle.Text);
        Item.MetaTitle = Convert.ToString(txtMetaTitle.Text);
        Item.MetaContent = Convert.ToString(txtMetaContent.Text);
        Item.MetaDescription = Convert.ToString(txtMetaDescription.Text);
        Item.CMSContent = Convert.ToString(txtCMSData.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("CMSSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CMSSearch.aspx");
    }
}