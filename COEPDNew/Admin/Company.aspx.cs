using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Company : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsCompany Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsCompany();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Company";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtCompany.Text = Item.Company;
                    txtDescription.Text = Item.Description;                    
                }
            }
            else
            {
                lblTitle.Text = "Add Company";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.CompanyId = Convert.ToInt16(ItemId);
        }
        Item.Company = Convert.ToString(txtCompany.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId; 
        Item.AddUpdate(Item);
        Response.Redirect("CompanySearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CompanySearch.aspx");
    }
}