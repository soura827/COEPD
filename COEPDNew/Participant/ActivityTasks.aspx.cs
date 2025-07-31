using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_ActivityTasks : System.Web.UI.Page
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
    //protected void BindData()
    //{
    //    clsActivityInteractions obj = new clsActivityInteractions();
    //    //obj.EmployeeId = CurrentUser.CurrentEmployeeId;
    //    gv.DataSource = obj.LoadAll(obj);
    //    gv.DataBind();
    //}
    protected void BindData()
    {
        clsActivityInstance obj = new clsActivityInstance();
        obj.ParticipantId = Convert.ToInt32(CurrentUser.CurrentParticipantId);
        if (txtCreatedBy.Text != "")
            obj.Fullname = txtCreatedBy.Text;
        //if (txtInvolvedEmployees.Text != "")
        //    obj.InvolvedEmployees = txtInvolvedEmployees.Text;
        //if (txtInvolvedParticipants.Text != "")
        //    obj.InvolvedParticipants = txtInvolvedParticipants.Text;
        if (txtStatus.Text != "")
            obj.Status = txtStatus.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void BindActivityInstance()
    {
        clsActivityInstance obj = new clsActivityInstance();
        obj.ParticipantId = Convert.ToInt32(CurrentUser.CurrentParticipantId);
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

    protected void txtCreatedBy_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtStatus_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    //protected void txtInvolvedEmployees_TextChanged(object sender, EventArgs e)
    //{
    //    BindData();
    //}

    //protected void txtInvolvedParticipants_TextChanged(object sender, EventArgs e)
    //{
    //    BindData();
    //}
}