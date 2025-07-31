using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_Award : System.Web.UI.Page
{
    int ItemId = 0;
    int Count = 0;
    clsAward Item = new clsAward();
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Award  Details";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtAwardName.Text = Item.AwardName;
                    txtDescription.Text = Convert.ToString(Item.Description);
                }

            }
            else
            {
                lblTitle.Text = "Add Award Details";
            }
        }

    }
    protected void Validation()
    {
        Item.AwardName = Convert.ToString(txtAwardName.Text);
        Count = Item.LoadAwardValidation(Item);
        if (Count > 0)
        {
            txtAwardName.Text = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }
    }

    protected void txtAwardName_TextChanged(object sender, EventArgs e)
    {
        Validation();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
            Item.AwardId = ItemId;
        Item.AwardName = txtAwardName.Text;
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
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

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("AwardSearch.aspx");
    }
}