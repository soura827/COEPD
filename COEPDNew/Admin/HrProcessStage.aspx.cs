using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_HrProcessStage : System.Web.UI.Page
{

    int ItemId = 0;
    int CountNo = 0;
    clsHrProcessStage Item;
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
            Item = new clsHrProcessStage();
            if (ItemId > 0)
            {

                lblTitle.Text = "Edit Hr Process Stage";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtNurturingProcessStageName.Text = Item.HrProcessStageName.ToString();
                }
                btnAdd.Visible = false;
            }
            else
            {
                lblTitle.Text = "Add Hr Process Stage";
            }

        }


    }
    protected void BindCount()
    {
        clsHrProcessStage obj = new clsHrProcessStage();
        obj.HrProcessStageName = Convert.ToString(txtNurturingProcessStageName.Text);
        CountNo = obj.LoadHrProcessStageValidation(obj);
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
            Item = new clsHrProcessStage();
            if (ItemId > 0)
            {
                Item.HrProcessStageId = Convert.ToInt32(ItemId);
            }
            Item.HrProcessStageName = Convert.ToString(txtNurturingProcessStageName.Text);
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
        Response.Redirect("HrProcessStageSearch.aspx");
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