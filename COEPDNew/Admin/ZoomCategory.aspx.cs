using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data;

public partial class Admin_ZoomCategory : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsZoomCategory Item = new clsZoomCategory();
    int ItemId = 0;
    int CountNo = 0;

    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
            
        {
            BindCategory();
            if (ItemId > 0)
            {
                
                lblTitle.Text = "Edit Zoom Meeting Category";
                Item = Item.Load(ItemId);
                if (Item != null)
                {

                    txtZoomCategory.Text = Convert.ToString(Item.ZoomMeetingCategory);
                    txtDescription.Text = Convert.ToString(Item.Description);


                }

            }
            else
            {
                lblTitle.Text = "Zoom Meeting Category";
            }

        }

    }
    protected void BindCategory()
    {
        clsZoomCategory obj = new clsZoomCategory();
        obj.ZoomMeetingCategory = Convert.ToString(txtZoomCategory.Text);
        CountNo = obj.LoadZoomMeetingCategoryValidation(obj);
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtZoomCategory.Text = "";
           

        }
    }


    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.ZoomMeetingCategoryId = Convert.ToInt32(ItemId);
        }
        Item.ZoomMeetingCategory = txtZoomCategory.Text;
        Item.Description = txtDescription.Text;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        txtZoomCategory.Text = "";
        txtDescription.Text = "";
        btnSave.Enabled = false;
      
        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ZoomCategorySearch.aspx");
    }

    protected void txtZoomCategory_TextChanged(object sender, EventArgs e)
    {
        BindCategory();
    }
}
