using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_InterviewSupportSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int DesignationId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindData();
        }
    }
    private void BindData()
    {
        DesignationId = CurrentUser.CurrentDesignationId;
        clsInterviewSupport obj = new clsInterviewSupport();
        if (DesignationId == 3)
            obj.MentorId = CurrentUser.CurrentEmployeeId;
        if (txtParticipant.Text != "")
            obj.KeyWords = txtParticipant.Text;
        if (txtLocation.Text != "")
            obj.Location = txtLocation.Text;
        if (ddlStatus.SelectedValue != null)
            obj.IsApproved = Convert.ToBoolean(ddlStatus.SelectedValue);

        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind(); 
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("InterviewSupport.aspx?itemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            //int ItemId = Convert.ToInt16(e.CommandArgument);
            //clsInterviewSupport Item = new clsInterviewSupport();
            //Item.Remove(ItemId);
            //BindData();
            //ErrorMessage.Text = "RequestFAQs successfully removed";
            //ErrorMessage.Visible = true;
        }
        else if(e.CommandName == "cmdAssign")
        {
            Response.Redirect("AssignMentorToInterviewSupport.aspx?itemId=" + e.CommandArgument);
        }
    }
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.DataItem != null)
            {
                HiddenField hdnSendFile = (HiddenField)e.Row.FindControl("hdnSendFile");
                HiddenField hdnReplyFile = (HiddenField)e.Row.FindControl("hdnReplyFile");
                HyperLink hplSendFile = (HyperLink)e.Row.FindControl("hplSendFile");
                HyperLink hplReplyFile = (HyperLink)e.Row.FindControl("hplReplyFile");

                if (hdnSendFile.Value == "")
                {
                    hplSendFile.Visible = false;
                }

                if (hdnReplyFile.Value == "")
                {

                    hplReplyFile.Visible = false;
                }
            }
        }

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

    protected void txtParticipant_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtLocation_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
}