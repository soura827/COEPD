using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data.SqlClient;
using System.Configuration;

public partial class Admin_KPI : System.Web.UI.Page
{
    int ItemId = 0;
    int CountNo = 0;
    clsKPI Item;
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if(!IsPostBack)
        {
            BindKPIApplicableTo();
            Item = new clsKPI();
            if(ItemId>0)
            {
                
                lblTitle.Text = "Edit KPI";
                Item = Item.Load(ItemId);
                if(Item !=null)
                {
                    txtKPIName.Text = Item.KPIName.ToString();
                    ddlKPIApplicableTo.SelectedValue = Item.KPIApplicableToId.ToString();
                }
                btnAdd.Visible = false;
            }
            else
            {
                lblTitle.Text = "Add KPI";
            }

        }
    }

    protected void BindCount()
    {
        clsKPI obj = new clsKPI();
        obj.KPIName = Convert.ToString(txtKPIName.Text);
        CountNo = obj.LoadKPIValidation(obj);
    }
    protected void BindReset()
    {
        txtKPIName.Text = "";
        ddlKPIApplicableTo.SelectedIndex = -1;
    }

    protected void BindKPIApplicableTo()
    {
        clsKPI obj = new clsKPI();
        ddlKPIApplicableTo.DataSource = obj.LoadAllKPIApplicableTo(obj);
        ddlKPIApplicableTo.DataTextField = "KPIApplicableTo";
        ddlKPIApplicableTo.DataValueField = "KPIApplicableToId";
        ddlKPIApplicableTo.DataBind();
        ddlKPIApplicableTo.Items.Insert(0, new ListItem("-- Select KPI Applicable To --", "0"));
        
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
            Item = new clsKPI();
            if (ItemId > 0)
            {
                Item.KPIId = Convert.ToInt32(ItemId);
            }
            Item.KPIName = Convert.ToString(txtKPIName.Text);
            Item.KPIApplicableToId = Convert.ToInt32(ddlKPIApplicableTo.SelectedValue);
            Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
            Item.AddUpdate(Item);
            BindReset();
            btnSave.Enabled = false;
        }
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("KPISearch.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        BindReset();
        btnSave.Enabled = true;
    }

    protected void ddlKPIApplicableTo_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }
        btnSave.Enabled = true;
    }

    protected void txtKPIName_TextChanged(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }
        btnSave.Enabled = true;
    }
}