using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ParticipantStatusCode : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    public string Constr = ConfigurationManager.ConnectionStrings["cs3"].ConnectionString.ToString();
    clsParticipantStatusCode Item = new clsParticipantStatusCode();
    int ItemId = 0;
    int CountNo = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit participant Status ";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtStatus.Text = Convert.ToString(Item.StatusName);
                    txtCode.Text = Convert.ToString(Item.StatusCode);
                    txtDescription.Text = Convert.ToString(Item.Description);
                }
                txtCode.Enabled = false;
                
            }
            else
            {
                lblTitle.Text = "Add participant Status ";
            }

        }

    }
    protected void BindCount()
    {
        clsParticipantStatusCode obj = new clsParticipantStatusCode();
        obj.StatusName = Convert.ToString(txtStatus.Text);
        CountNo = obj.LoadParticipantStatusCodeValidation(obj);
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtStatus.Text = "";
            //txtStatus.Enabled = false;
           
        }
    }
    protected void BindCode()
    {
        clsParticipantStatusCode obj = new clsParticipantStatusCode();
        obj.StatusCode = Convert.ToInt32(txtCode.Text);
        CountNo = obj.LoadParticipantCodeValidation(obj);
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtCode.Text = "";
            //txtCode.Enabled = false;

        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantStatusCodeSearch.aspx");
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.ParticipantStatusCodeId = Convert.ToInt32(ItemId);
        }
        Item.StatusName = txtStatus.Text;
        Item.StatusCode = Convert.ToInt32(txtCode.Text);
        Item.Description = Convert.ToString(txtDescription.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        txtStatus.Text = "";
        txtCode.Text = "";
        txtDescription.Text = "";
        btnSubmit.Enabled =false;

        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }

    }
    protected void txtStatus_TextChanged(object sender, EventArgs e)
    {
        BindCount();
    }
    protected void txtCode_TextChanged(object sender, EventArgs e)
    {
        BindCode();
    }

}



