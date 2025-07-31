using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_HrProcessStageTask : System.Web.UI.Page
{
    int ItemId = 0;
    int CountNo = 0;
    clsHrProcessStageTask Item;
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
            Item = new clsHrProcessStageTask();
            if (ItemId > 0)
            {

                lblTitle.Text = "Edit HR Process Stage Task";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtNurturingProcessStageTaskName.Text = Item.HrProcessStageTaskName.ToString();
                    ddlNurturingProcessStage.SelectedValue = Item.HrProcessStageId.ToString();
                    txtWeightage.Text = Item.Weightage.ToString();
                    txtTimeFrame.Text = Item.TimeFrame.ToString();
                }
                btnAdd.Visible = false;
            }
            else
            {
                lblTitle.Text = "Add HR Process Stage Task";
            }

        }

    }
    protected void BindCount()
    {
        clsHrProcessStageTask obj = new clsHrProcessStageTask();
        obj.HrProcessStageTaskName = Convert.ToString(txtNurturingProcessStageTaskName.Text);
        CountNo = obj.LoadHrProcessStageTaskValidation(obj);
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
        clsHrProcessStage obj = new clsHrProcessStage();
        ddlNurturingProcessStage.DataSource = obj.LoadAll(obj);
        ddlNurturingProcessStage.DataTextField = "HrProcessStageName";
        ddlNurturingProcessStage.DataValueField = "HrProcessStageId";
        ddlNurturingProcessStage.DataBind();
        ddlNurturingProcessStage.Items.Insert(0, new ListItem("-- Select Hr Process Stage Name --", "0"));

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
            Item = new clsHrProcessStageTask();
            if (ItemId > 0)
            {
                Item.HrProcessStageTaskId = Convert.ToInt32(ItemId);
            }
            Item.HrProcessStageTaskName = Convert.ToString(txtNurturingProcessStageTaskName.Text);
            Item.HrProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
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
        Response.Redirect("HrProcessStageTaskSearch.aspx");
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