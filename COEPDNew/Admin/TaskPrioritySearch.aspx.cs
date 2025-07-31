using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_TaskPrioritySearch : System.Web.UI.Page
{
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    protected void BindData()
    {
        clsNurturingProcessStageTaskAccess obj = new clsNurturingProcessStageTaskAccess();
        if (txtNurturingProcessStage.Text != "")
            obj.NurturingProcessStageName = txtNurturingProcessStage.Text;
        if (txtNurturingProcessStageTask.Text != "")
            obj.NurturingProcessStageTaskName = txtNurturingProcessStageTask.Text;
        if (txtEmployee.Text != "")
            obj.Employee = txtEmployee.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("TaskPriority.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsActivity Item = new clsActivity();
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "TaskPriority successfully removed";
            ErrorMessage.Visible = true;
        }
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void txtNurturingProcessStage_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtNurturingProcessStageTask_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtEmployee_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void gv_PreRender(object sender, EventArgs e)
    {
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingProcessStageTaskAccessSearh.aspx");
    }
}