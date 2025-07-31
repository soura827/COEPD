using BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_HrAvilableSlotsSearchAll : System.Web.UI.Page
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
            //BindSlotStatus();
        }
    }
    protected void BindData()
    {
        clsHrProcessSlots obj = new clsHrProcessSlots();
        // obj.EmployeeId = CurrentUser.CurrentEmployeeId;
        if (txtEmployee.Text != "")
            obj.Keywords = Convert.ToString(txtEmployee.Text);
        if (txtParticipate.Text != "")
            obj.ParticipantDetails = Convert.ToString(txtParticipate.Text);
        if (txtNurturingProcessStageTaskName.Text != "")
            obj.NurturingProcessStageTaskName = Convert.ToString(txtNurturingProcessStageTaskName.Text);
        if (ddlStatus.SelectedValue != "")
            obj.IsSlotAssigned = Convert.ToBoolean(ddlStatus.SelectedValue);
        //if (ddlSlotStatus.SelectedValue != "")                                            /**/
        //    obj.SlotsStatusId = Convert.ToInt16(ddlSlotStatus.SelectedValue);
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
    protected void txtParticipate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtNurturingProcessStageTaskName_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtEmployee_TextChanged(object sender, EventArgs e)
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
                // Response.Redirect("RequestFAQs.aspx?itemId=0&RSId=" + e.CommandArgument);
            }
            else
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Conduct not allowed - This slot not booked.";
            }
        }




        //else if (e.CommandName == "cmdChangeSlot")
        //{
        //    if (Convert.ToBoolean(ddlStatus.SelectedValue) == true)
        //    {
        //        Response.Redirect("ChangeSlot.aspx?ItemId=" + e.CommandArgument);
        //    }
        //}
    }



    protected void btnDownload_Click(object sender, EventArgs e)
    {
        string FileNamePrepix = string.Empty;
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        FileNamePrepix = DateTime.ToString("dd-MMM-yyyy-hh-mm-tt");
        ExportToExcel(FileNamePrepix + "-Slots.xls", gv);
    }
    protected void ExportToExcel(string strFileName, GridView gv)
    {
        Response.ClearContent();
        Response.AddHeader("content-disposition", "attachment; filename=" + strFileName);
        Response.ContentType = "application/excel";
        StringWriter SW = new StringWriter();
        HtmlTextWriter HTM = new HtmlTextWriter(SW);
        gv.RenderControl(HTM);
        Response.Write(SW.ToString());
        Response.End();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        //base.VerifyRenderingInServerForm(control);
    }

    protected void ddlSlotStatus_SelectedIndexChanged(object sender, EventArgs e)
    {

        BindData();
    }
    //protected void BindSlotStatus()
    //{
    //    clsHrProcessSlots obj = new clsHrProcessSlots();
    //    ddlSlotStatus.DataSource = obj.LoadAlLReShedule(obj);
    //    ddlSlotStatus.DataTextField = "HrSlotStatus";
    //    ddlSlotStatus.DataValueField = "HrSlotsStatusId";
    //    ddlSlotStatus.DataBind();
    //    ddlSlotStatus.Items.Insert(0, new ListItem("Search by Hr SlotStatus", "0"));
    //}
}