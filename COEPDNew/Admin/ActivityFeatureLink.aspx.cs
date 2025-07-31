using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public partial class Admin_ActivityFeatureLink : System.Web.UI.Page
{

    int ItemId = 0;
    CurrentUser CurrentUser = new CurrentUser();
    clsActivityFeatureLink Item;
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        #region
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsActivityFeatureLink();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Activity Category";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtActivityId.Text = Convert.ToString(Item.ActivityId);
                    txtActivityLinkAddress.Text = Item.ActivityAddressName.ToString();
                    txtActivityName.Text = Item.ActivityFeatureName.ToString();
                }

            }
            else
            {
                lblTitle.Text = "Add Activity Feature Links";
            }
        }
        #endregion
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.ActivityFeatureLinkId = Convert.ToInt32(ItemId);
        }
        Item.ActivityId = Convert.ToInt32(txtActivityId.Text);
        Item.ActivityFeatureName = txtActivityName.Text;
        Item.ActivityAddressName = Convert.ToString(txtActivityLinkAddress.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        btnSubmit.Enabled = false;
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
        Response.Redirect("ActivityFeatureLinkSearch.aspx");
    }

}

