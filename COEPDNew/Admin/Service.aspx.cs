using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_Service : System.Web.UI.Page
{
    int ItemId = 0;
    int Count = 0;
    clsService Item = new clsService();
    CurrentUser CurrentUser = new CurrentUser();
    private object txtDescription;

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
                lblTitle.Text = "Edit Service  Details";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtServiceName.Text = Item.ServiceName;
                    txtFees.Text = Convert.ToString(Item.Fees);
                    txtDes.Text = Convert.ToString(Item.Description);
                    
                }

            }
            else
            {
                lblTitle.Text = "Add Service Details";
            }
        }

    }
    protected void Validation()
    {
        Item.ServiceName = Convert.ToString(txtServiceName.Text);
        Count = Item.LoadServiceValidation(Item);
        if (Count > 0)
        {
            txtServiceName.Text = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }
    }


    protected void txtServiceName_TextChanged(object sender, EventArgs e)
    {
        Validation();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {

        if (ItemId > 0)
            Item.ServiceId = ItemId;
        Item.ServiceName = txtServiceName.Text;
        Item.Fees = Convert.ToInt32(txtFees.Text);
        Item.Description = txtDes.Text;
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
        Response.Redirect("ServiceSearch.aspx");
    }
}