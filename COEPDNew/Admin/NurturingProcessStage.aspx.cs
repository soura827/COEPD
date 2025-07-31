using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_NurturingProcessStage : System.Web.UI.Page
{
    int ItemId = 0;
    int CountNo = 0;
    clsNurturingProcessStage Item;
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
            Item = new clsNurturingProcessStage();
            if (ItemId > 0)
            {

                lblTitle.Text = "Edit Nurturing Process Stage";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtNurturingProcessStageName.Text = Item.NurturingProcessStageName.ToString();
                }
                btnAdd.Visible = false;
            }
            else
            {
                lblTitle.Text = "Add Nurturing Process Stage";
            }

        }

    }
    protected void BindCount()
    {
        clsNurturingProcessStage obj = new clsNurturingProcessStage();
        obj.NurturingProcessStageName = Convert.ToString(txtNurturingProcessStageName.Text);
        CountNo = obj.LoadNurturingProcessStageValidation(obj);
    }
    protected void BindReset()
    {
        txtNurturingProcessStageName.Text = "";
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
            Item = new clsNurturingProcessStage();
            if (ItemId > 0)
            {
                Item.NurturingProcessStageId = Convert.ToInt32(ItemId);
            }
            Item.NurturingProcessStageName = Convert.ToString(txtNurturingProcessStageName.Text);
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
        Response.Redirect("NurturingProcessStageSearch.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        BindReset();
        btnSave.Enabled = true;
    }
    protected void txtNurturingProcessStageName_TextChanged(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            BindReset();
            btnSave.Enabled = true;
        }
    }
}