using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_KPIActivityMapping : System.Web.UI.Page
{
    int ItemId = 0;
    int CountNo = 0;
    clsKPIActivityMapping Item;
    CurrentUser CurrentUser = new CurrentUser();
    protected void page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            BindActivityCategory();
            BindKPI();
            Item = new clsKPIActivityMapping();
            if (ItemId > 0)
            {

                lblTitle.Text = "Edit KPI Activity Mapping";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlKPI.SelectedValue = Item.KPIId.ToString();
                    ddlActivityCategory.SelectedValue = Item.ActivityCategoryId.ToString();
                    BindActivitySubCategory();
                    ddlActivitySubCategory.SelectedValue = Item.ActivitySubCategoryId.ToString();
                    BindActivity();
                    ddlActivity.SelectedValue = Item.ActivityId.ToString();
                    txtValueAlloted.Text = Item.ValueAlloted.ToString();
                }
                btnAdd.Visible = false;
            }
            else
            {
                lblTitle.Text = "Add KPI Activity Mapping";
            }

        }
    }

        protected void BindActivityCategory()
        {
            clsActivityCategory obj = new clsActivityCategory();
            ddlActivityCategory.DataSource = obj.LoadAll(obj);
            ddlActivityCategory.DataTextField = "ActivityCategory";
            ddlActivityCategory.DataValueField = "ActivityCategoryId";
            ddlActivityCategory.DataBind();
            ddlActivityCategory.Items.Insert(0, new ListItem("-- Select Activity Category --", ""));
        }
        protected void BindActivitySubCategory()
        {
            if (ddlActivityCategory.SelectedValue != "")
            {
                clsActivitySubCategory obj = new clsActivitySubCategory();
                obj.ActivityCategoryId = Convert.ToInt32(ddlActivityCategory.SelectedValue);
                ddlActivitySubCategory.DataSource = obj.LoadAll(obj);
                ddlActivitySubCategory.DataTextField = "ActivitySubCategory";
                ddlActivitySubCategory.DataValueField = "ActivitySubCategoryId";
                ddlActivitySubCategory.DataBind();
                ddlActivitySubCategory.Items.Insert(0, new ListItem("-- Select Activity Sub Category --", ""));

            }

        }
        protected void BindActivity()
        {
            if(ddlActivitySubCategory.SelectedValue != "")
            {
                clsActivity obj = new clsActivity();
                obj.ActivityCategoryId = Convert.ToInt32(ddlActivityCategory.SelectedValue);
                obj.ActivitySubCategoryId = Convert.ToInt32(ddlActivitySubCategory.SelectedValue);
                ddlActivity.DataSource = obj.LoadAll(obj);
                ddlActivity.DataTextField = "Activity";
                ddlActivity.DataValueField = "ActivityId";
                ddlActivity.DataBind();
                ddlActivity.Items.Insert(0, new ListItem("-- Select Activity Name --", "0"));
            }
        }
    
    protected void BindKPI()
    {
        clsKPI obj = new clsKPI();
        ddlKPI.DataSource = obj.LoadAll(obj);
        ddlKPI.DataTextField = "KPIName";
        ddlKPI.DataValueField = "KPIId";
        ddlKPI.DataBind();
       ddlKPI.Items.Insert(0, new ListItem("-- Select KPI Name --", "0"));
    }
    protected void BindReset()
    {
        ddlKPI.SelectedIndex = -1;
        ddlActivityCategory.SelectedIndex = -1;
        ddlActivitySubCategory.SelectedIndex = -1;
        ddlActivity.SelectedIndex = -1;
        txtValueAlloted.Text = "";
    }
    protected void BindCount()
    {
        clsKPIActivityMapping obj = new clsKPIActivityMapping();
        if(ddlActivity.SelectedValue !="")
        { 
        obj.ActivityId = Convert.ToInt32(ddlActivity.SelectedValue);
        obj.KPIId = Convert.ToInt32(ddlKPI.SelectedValue);
        CountNo = obj.LoadKPIActivityValidation(obj);
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }
        else
        {
            Item = new clsKPIActivityMapping();
            if (ItemId > 0)
            {
                Item.KPIActivityMappingId = Convert.ToInt32(ItemId);
            }
            Item.KPIId = Convert.ToInt32(ddlKPI.SelectedValue);
            Item.ActivityCategoryId = Convert.ToInt32(ddlActivityCategory.SelectedValue);
            Item.ActivitySubCategoryId = Convert.ToInt32(ddlActivitySubCategory.SelectedValue);
            Item.ActivityId = Convert.ToInt32(ddlActivity.SelectedValue);
            Item.ValueAlloted = Convert.ToSingle(txtValueAlloted.Text);
            Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
            Item.AddUpdate(Item);
            BindReset();
            btnSave.Enabled = false;
            if (ItemId > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
                btnSave.Enabled = false;
            }
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("KPIActivityMappingSearch.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        BindReset();
        btnSave.Enabled = true;
    }

    protected void ddlActivityCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlActivityCategory.SelectedValue != "")
        {
            BindActivitySubCategory();
        }
    }

    protected void ddlActivitySubCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddlActivitySubCategory.SelectedValue != "")
        {
            BindActivity();
        }
    }
    protected void ddlActivity_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }
    }

    protected void ddlKPI_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }
    }

    protected void txtValueAlloted_TextChanged(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }
    }
}