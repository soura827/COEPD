using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_GSuit : System.Web.UI.Page
{
    int ItemId = 0, Count = 0;
    clsGSuit Item;
    DateTime DateOfCreation; 
    CurrentUser CurrentUser = new CurrentUser();
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsGSuit();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit GSuit";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtGSuitEmail.Text=Item.GSuitEmail.ToString();
                    if (Item.IsCreated == true)
                    {
                        chkIsCreated.Checked = true;
                        divDate.Visible = true;
                    }
                    else
                    {
                        chkIsCreated.Checked = false;
                    }
                    if (Item.DateOfCreation != null)
                    {
                        DateOfCreation = Convert.ToDateTime(Item.DateOfCreation);
                        txtDateOfCreation.Text = DateOfCreation.ToString("dd/MM/yyyy");
                    }
                }
            }
            else
            {
                lblTitle.Text = "Add Email";
            }
        }       
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsGSuit obj = new clsGSuit();
        if (ItemId > 0)
        {
            obj.GSuitEmailId = Convert.ToInt32(ItemId);
        }
        obj.GSuitEmail = Convert.ToString(txtGSuitEmail.Text);
        if (chkIsCreated.Checked == true)
        {
            obj.IsCreated = true;
        }
        else
        {
            obj.IsCreated = false;
        }
        if (txtDateOfCreation.Text != "")
        {
            DateTime Date = DateTime.ParseExact(txtDateOfCreation.Text, "dd/MM/yyyy", null);
            obj.DateOfCreation = Date;

        }
        obj.CreatedBy = CurrentUser.CurrentUserId;
        obj.AddUpdate(obj);
        btnSubmit.Enabled = false;
        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }
        //Response.Redirect("GSuitSearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("GsuitSearch.aspx");
    }
    protected void EmailValidation() 
    {
        Item.GSuitEmail = Convert.ToString(txtGSuitEmail.Text);
        Count = Item.LoadEmailValidation(Item);
        if (Count > 0)
        {
            txtGSuitEmail.Text = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        }
    }

    protected void txtGSuitEmail_TextChanged(object sender, EventArgs e)
    {
        EmailValidation();
    }

    protected void chkIsCreated_CheckedChanged(object sender, EventArgs e)
    {
        if (chkIsCreated.Checked == true)
        {
            divDate.Visible = true;
        }

        else
        {
            divDate.Visible = false;
            txtDateOfCreation.Text = "";
        }
    }
}