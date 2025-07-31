using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_NurturingProcessStageTask : System.Web.UI.Page
{
    int ItemId = 0;
    int CountNo = 0;
    clsNurturingProcessStageTask Item;
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
            BindNurturingProcessStage();
            Item = new clsNurturingProcessStageTask();
            if (ItemId > 0)
            {

                lblTitle.Text = "Edit Nurturing Process Stage Task";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtNurturingProcessStageTaskName.Text = Item.NurturingProcessStageTaskName.ToString();
                    ddlNurturingProcessStage.SelectedValue = Item.NurturingProcessStageId.ToString();
                    txtWeightage.Text = Item.Weightage.ToString();
                    txtTimeFrame.Text = Item.TimeFrame.ToString();
                }
                btnAdd.Visible = false;
            }
            else
            {
                lblTitle.Text = "Add Nurturing Process Stage Task";
            }

        }

    }
    protected void BindCount()
    {
        clsNurturingProcessStageTask obj = new clsNurturingProcessStageTask();
        obj.NurturingProcessStageTaskName = Convert.ToString(txtNurturingProcessStageTaskName.Text);
        CountNo = obj.LoadNurturingProcessStageTaskValidation(obj);
    }
    protected void BindReset()
    {
        txtNurturingProcessStageTaskName.Text = "";
        ddlNurturingProcessStage.SelectedIndex = -1;
        txtWeightage.Text = "";
        txtTimeFrame.Text = "";
    }
    protected void BindNurturingProcessStage()
    {
        clsNurturingProcessStage obj = new clsNurturingProcessStage();
        ddlNurturingProcessStage.DataSource = obj.LoadAll(obj);
        ddlNurturingProcessStage.DataTextField = "NurturingProcessStageName";
        ddlNurturingProcessStage.DataValueField = "NurturingProcessStageId";
        ddlNurturingProcessStage.DataBind();
        ddlNurturingProcessStage.Items.Insert(0, new ListItem("-- Select Nurturing Process Stage Name --", "0"));

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
            Item = new clsNurturingProcessStageTask();
            if (ItemId > 0)
            {
                Item.NurturingProcessStageTaskId = Convert.ToInt32(ItemId);
            }
            Item.NurturingProcessStageTaskName = Convert.ToString(txtNurturingProcessStageTaskName.Text);
            Item.NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
            Item.Weightage = Convert.ToInt16(txtWeightage.Text);
            Item.TimeFrame = Convert.ToInt16(txtTimeFrame.Text);
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
        Response.Redirect("NurturingProcessStageTaskSearch.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        BindReset();
        btnSave.Enabled = true;
    }
    protected void txtNurturingProcessStageTaskName_TextChanged(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtNurturingProcessStageTaskName.Text = "";
            btnSave.Enabled = true;
        }
    }

    protected void ddlNurturingProcessStage_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindCount();
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
            txtNurturingProcessStageTaskName.Text = "";
            btnSave.Enabled = true;
        }
    }
}