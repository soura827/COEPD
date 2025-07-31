using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_NurturingRevisionSearch : System.Web.UI.Page
{
   int ItemId = 0;
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object Sender, EventArgs e)
    {

        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
       ItemId = Convert.ToInt32(CurrentUser.CurrentParticipantId);
        if (!IsPostBack)
        {
            BindData();
        }
    }
    protected void BindData()
    {
        clsNurturingRevision item = new clsNurturingRevision();
        if (ItemId != 0)
            item.ParticipantId = ItemId;
        if (ddlStatus.SelectedValue != "")
            item.IsApproved = Convert.ToBoolean(ddlStatus.SelectedValue);
        gv.DataSource = item.LoadAll(item);
        gv.DataBind();
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dashboard.aspx");
    }
    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void GoToExams_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserExamMaster.aspx");
    }
}