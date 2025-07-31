using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class News : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsNews Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsNews();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Training News";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlCMS.SelectedValue = Convert.ToString(Item.CMSId);
                    txtNewsDescription.Text = Item.NewsDescription;
                    //if (Item.IsActive == true)
                    //{
                    //    chkActive.Checked = true;
                    //}
                    //else
                    //{
                    //    chkActive.Checked = false;
                    //}
                }
            }
            else
            {
                lblTitle.Text = "Add New Training News";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (ItemId > 0)
        {
            Item.NewsId = Convert.ToInt16(ItemId);
        }

        string newscontent = Convert.ToString(txtNewsDescription.Text);
        newscontent = newscontent.Replace("<p>", "");
        newscontent = newscontent.Replace("</p>", "");
        Item.NewsDescription = Convert.ToString(newscontent);
        Item.CMSId = Convert.ToInt32(ddlCMS.SelectedValue);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.IsFeatured = false;
        Item.IsActive = true;

        //if (chkActive.Checked == true)
        //{
        //    Item.IsActive = true;
        //}
        //else
        //{
        //    Item.IsActive = false;
        //}
        Item.AddUpdate(Item);
        Response.Redirect("NewsSearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewsSearch.aspx");
    }
}