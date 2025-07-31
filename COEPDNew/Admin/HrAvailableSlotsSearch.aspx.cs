using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_HrAvailableSlotsSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    DateTime DateTime;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            txtFromDate.Text = DateTime.ToString("dd/MM/yyyy");
            txtToDate.Text = DateTime.ToString("dd/MM/yyyy");
            BindData();
        }
    }
    protected void BindData()
    {
        clsHrProcessSlots obj = new clsHrProcessSlots();
        obj.EmployeeId = CurrentUser.CurrentEmployeeId;
        if (txtParticipate.Text != "")
            obj.ParticipantDetails = Convert.ToString(txtParticipate.Text);
        if (txtNurturingProcessStageTaskName.Text != "")
            obj.NurturingProcessStageTaskName = Convert.ToString(txtNurturingProcessStageTaskName.Text);
        if (ddlStatus.SelectedValue != "")
            obj.IsSlotAssigned = Convert.ToBoolean(ddlStatus.SelectedValue);
        if (txtFromDate.Text != "")
        {
            obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.FromDate = null;
        }
        if (txtToDate.Text != "")
        {
            obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.ToDate = null;
        }
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
        ErrorMessage.Visible = false;
    }
    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
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

    protected void txtFromDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtToDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HrAvailableSlots.aspx");
    }

    protected void txtParticipate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtNurturingProcessStageTaskName_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdDelete")
        {
            if (Convert.ToBoolean(ddlStatus.SelectedValue) == false)
            {
                clsHrProcessSlots obj = new clsHrProcessSlots();
                obj.Remove(Convert.ToInt32(e.CommandArgument));
                BindData();
                ErrorMessage.Text = "Slot successfully removed.";
                ErrorMessage.Visible = true;
            }
            else
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Delete not allowed - This slot already booked.";
            }
        }
        else if (e.CommandName == "cmdConduct")
        {
            if (Convert.ToBoolean(ddlStatus.SelectedValue) == true)
            {
                Response.Redirect("HrProcess.aspx?ItemId=" + e.CommandArgument);
            }
            else
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Conduct not allowed - This slot not booked.";
            }
        }
        else if (e.CommandName == "cmdApprove")
        {
            int ItemId = Convert.ToInt32(e.CommandArgument);
            clsHrProcessSlots Item = new clsHrProcessSlots();
            Item.Approve(ItemId);
            BindData();
            FormMessage.Visible = true;
            FormMessage.Text = "Slot Status Changed Sucssfully.";

        }
    }
}