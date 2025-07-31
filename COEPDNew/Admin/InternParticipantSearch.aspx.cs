using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_InternParticipantSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            BindInternBatch();
            BindData();
        }
    }

     protected void  BindInternBatch()
    {
        clsInternBatch obj = new clsInternBatch();
        ddlInternbatch.DataSource = obj.LoadAll(obj);
        ddlInternbatch.DataTextField = "InternBatch";
        ddlInternbatch.DataValueField = "InternBatchId";
        ddlInternbatch.DataBind();
        ddlInternbatch.Items.Insert(0, new ListItem("-- Select InternShip Batch --", "0"));
    }   
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("InternParticipant.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindData()
    {
        clsParticipant obj = new clsParticipant();
        if (txtSearch.Text.Length > 0)
        {
            obj.keywords = txtSearch.Text;
        }
       
        obj.InternBatchId = Convert.ToInt32(ddlInternbatch.SelectedValue);
        obj.IsIntern = true;
        gv.DataSource = obj.LoadAllIntern(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("InternParticipant.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdRequest")
        {
            Response.Redirect("PlacementRequest.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsParticipant Item = new clsParticipant();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Participant successfully removed";
            ErrorMessage.Visible = true;
        }
        else if (e.CommandName == "cmdSend")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);

            clsUser ItemUser = new clsUser();
            ItemUser = ItemUser.LoadByParticipantId(ItemId);

            if (ItemUser != null)
            {
                #region "Send Email"

                string strMessage = string.Empty;

                strMessage = "Dear Mr./Ms. " + ItemUser.Fullname + ",<br /><br /><br />";
                strMessage = strMessage + "Greetings from COEPD !!!<br /><br />";
                strMessage = strMessage + "Please find the below COEPD Participant credentials.<br />";
                strMessage = strMessage + "Here you can get daily Job Openings, Documents and daily updates on trainings.<br /><br />";

                strMessage = strMessage + "Login : <a href=https://www.coepd.com/login.html>www.coepd.com/login.html</a><br />";
                strMessage = strMessage + "Username : " + ItemUser.Username + "<br />";
                strMessage = strMessage + "Password : " + ItemUser.Pwd + "<br /><br /><br />";

                strMessage = strMessage + "Please check and revert back if any assistance required.<br /><br /><br />";
                strMessage = strMessage + "Thanks & Regards<br />";
                strMessage = strMessage + "COEPD Team<br />";
                strMessage = strMessage + "+91 99635 55711<br />";
                strMessage = strMessage + "+91 40 66612216<br />";
                strMessage = strMessage + "dhileep.coepd@gmail.com<br />";
                strMessage = strMessage + "<a href=https://www.coepd.com>www.coepd.com</a><br />";

                strMessage = strMessage + "<a href=https://www.coepd.com><img src='https://www.coepd.com/img/logo.png'></a><br />";
                string strSubject = "COEPD Participant Registration - Mr./Ms. " + ItemUser.Fullname;

                Alerts.SendEmail(ItemUser.Username.Trim(), strSubject, strMessage);
                Alerts.SendEmail("dhileep.coepd@gmail.com", strSubject, strMessage);

                lblMessage.Text = ItemUser.Username + " credentials successfully sent";

                #endregion
            }
        }
        else if (e.CommandName == "cmdDownload")
        {
            string FilePath = Server.MapPath("~/UserDocs/Participant/" + e.CommandArgument);
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(FilePath));
            Response.WriteFile(FilePath);
        }
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton lnkDownload = (LinkButton)e.Row.FindControl("lnkDownload");
            HiddenField hdnCertificatePath = (HiddenField)e.Row.FindControl("hdnCertificatePath");

            if (hdnCertificatePath.Value.Length > 0)
            {
                lnkDownload.Visible = true;
            }
        }
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
    protected void ddlInternBatch_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}