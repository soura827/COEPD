using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_HrTaskSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsHrTask Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsHrTask();
        BindData();

        if (!IsPostBack)
        {
            BindNurturingProcessStage();
            BindNurturingProcessStageTask();
            BindData();
        }
    }
    protected void BindData()
    {
        clsHrTask obj = new clsHrTask();
        if (ddlNurturingProcessStage.SelectedValue != "")
            obj.HrProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.Text);
        if (ddlNurturingProcessStageTask.SelectedValue != "")
            obj.HrProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.Text);
        if (txtCreatedByName.Text != "")
            obj.Fullname = txtCreatedByName.Text;
        if (txtModifiedByName.Text != "")
            obj.Modifiedname = txtModifiedByName.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void BindNurturingProcessStage()
    {
        ddlNurturingProcessStage.Items.Clear();
        clsHrProcessStage obj = new clsHrProcessStage();
        ddlNurturingProcessStage.DataSource = obj.LoadAll(obj);
        ddlNurturingProcessStage.DataTextField = "HrProcessStageName";
        ddlNurturingProcessStage.DataValueField = "HrProcessStageId";
        ddlNurturingProcessStage.DataBind();
        ddlNurturingProcessStage.Items.Insert(0, new ListItem("---Select Hr Process Stage---", ""));
    }
    protected void BindNurturingProcessStageTask()
    {
        ddlNurturingProcessStageTask.Items.Clear();
        if (ddlNurturingProcessStage.SelectedValue != "")
        {
            clsHrProcessStageTask obj = new clsHrProcessStageTask();
            obj.HrProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
            ddlNurturingProcessStageTask.DataSource = obj.LoadAll(obj);
            ddlNurturingProcessStageTask.DataTextField = "HrProcessStageTaskName";
            ddlNurturingProcessStageTask.DataValueField = "HrProcessStageTaskId";
            ddlNurturingProcessStageTask.DataBind();
            //ddlNurturingProcessStageTask.Items.Insert(0, new ListItem("--Select Hr Process Stage Task-- ", ""));
        }
        ddlNurturingProcessStageTask.Items.Insert(0, new ListItem("-- Select Hr Process Stage Task --", ""));
        //ddlNurturingProcessStage.Items.Insert(0, new ListItem("-- Select Nurturing Process Stage --", "0"));
        gv.DataBind();

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("HrTask.aspx");
    }

    protected void ddlNurturingProcessStage_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlNurturingProcessStage.SelectedValue != null)
            BindNurturingProcessStageTask();
        BindData();
    }

    protected void ddlNurturingProcessStageTask_SelectedIndexChanged(object sender, EventArgs e)
    {
        //BindNurturingProcessStageTask();
        BindData();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        {
            if (e.CommandName == "cmdEdit")
            {
                Response.Redirect("HrTask.aspx?ItemId=" + e.CommandArgument);
            }
            else if (e.CommandName == "cmdDelete")
            {
                int ItemId = Convert.ToInt32(e.CommandArgument);
                clsHrTask Item = new clsHrTask();
                Item.Remove(ItemId);
                BindData();
                //ErrorMessage.Text = "Task successfully removed";
                //ErrorMessage.Visible = true;
            }
        }
    }

    protected void gv_PreRender(object sender, EventArgs e)
    {
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.DataItem != null)
                {
                    HiddenField hdnSendFile = (HiddenField)e.Row.FindControl("hdnSendFile");
                    HyperLink hplSendFile = (HyperLink)e.Row.FindControl("hplSendFile");
                    if (hdnSendFile.Value == "")
                    {
                        hplSendFile.Visible = false;
                    }
                }
            }
        }
    }

    protected void txtCreatedByName_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtModifiedByName_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }


}