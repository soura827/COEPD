using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.IO;
using System.Net.Mail;
public partial class Admin_ActivityTasks : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
            BindActivityInstance();
        }
    }
    protected void BindData()
    {
        clsActivityInstance obj = new clsActivityInstance();
        obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
        if (txtActivityCategory.Text != "")
            obj.ActivityCategory = txtActivityCategory.Text;
        if (txtActivitySubCategory.Text != "")
            obj.ActivitySubcategory = txtActivitySubCategory.Text;
        if (txtActivity.Text != "")
            obj.Activity = txtActivity.Text;
        if (txtCreatedBy.Text != "")
            obj.Fullname = txtCreatedBy.Text;
        if (txtInvolvedEmployees.Text != "")
            obj.InvolvedEmployees = txtInvolvedEmployees.Text;
        if (txtInvolvedParticipants.Text != "")
            obj.InvolvedParticipants = txtInvolvedParticipants.Text;
        if (txtParticipantsPhone.Text != "")
            obj.ParticipantsPhoneNumbers = txtParticipantsPhone.Text;
        if (txtInvolvedLeads.Text != "")
            obj.InvolvedLeads = txtInvolvedLeads.Text;
        if (txtLeadsPhone.Text != "")
            obj.LeadsPhoneNumbers = txtLeadsPhone.Text;
        if (txtInvolvedVendors.Text != "")
            obj.InvolvedVendors = txtInvolvedVendors.Text;
        if (txtStatus.Text != "")
            obj.Status = txtStatus.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void BindActivityInstance()
    {
        clsActivityInstance obj = new clsActivityInstance();
        obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("ActivityTaskInputs.aspx?ItemId=" + e.CommandArgument);
        }
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label lbltext = (Label)e.Row.FindControl("lblstatus");
            string ID = Convert.ToString(lbltext.Text);
            if (ID == "New")
            {
                //gv.Columns[0].Visible = true;
                lbltext.ForeColor = System.Drawing.Color.Green;
            }
            else if (ID == "InProgress")
            {
                //gv.Columns[0].Visible = true;
                lbltext.ForeColor = System.Drawing.Color.Orange;
            }

            else if (ID == "Completed")
            {
                //gv.Columns[0].Visible = false;
                lbltext.ForeColor = System.Drawing.Color.Red;
            }
            //TableCell statusCell = e.Row.Cells[0];
            //if (statusCell.Text=="Completed")
            //{
            //    gv.Rows[0].Visible = false;
            //}
            //else if (statusCell.Text == "2")
            //{
            //    statusCell.Text = "InProgress";
            //}
            //else if (statusCell.Text == "3")
            //{
            //    statusCell.Text = "Completed";
            //}
        }
    }
    protected void gv_PreRender(object sender, EventArgs e)
    {
        PageNumberHeader.Text = "Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = "Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }

    protected void txtActivityCategory_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtActivitySubCategory_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtActivity_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtCreatedBy_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtStatus_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtInvolvedEmployees_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtInvolvedParticipants_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtInvolvedLeads_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtInvolvedVendors_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("ActivityTaskCreation.aspx");
    }

    protected void txtParticipantsPhone_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtLeadsPhone_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void btnGoTODailyReport_Click(object sender, EventArgs e)
    {
        Response.Redirect("EmployeeInteractionsDailyReport.aspx");
    }
}