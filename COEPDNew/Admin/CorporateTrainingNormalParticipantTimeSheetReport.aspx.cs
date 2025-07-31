using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_CorporateTrainingNormalParticipantTimeSheetReport : System.Web.UI.Page
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
            txtFromDate.Text = DateTime.UtcNow.AddHours(5).AddMinutes(30).ToString("dd/MM/yyyy");
            txtToDate.Text = DateTime.UtcNow.AddHours(5).AddMinutes(30).ToString("dd/MM/yyyy");
            BindData();
        }
    }

    protected void BindData()
    {
        //clsParticipantTimeSheet obj = new clsParticipantTimeSheet();
        clsNormalParticipantTimeSheet obj = new clsNormalParticipantTimeSheet();
        //obj.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
        obj.BranchId = CurrentUser.UserBranchId;
        obj.keywords = txtSearch.Text;
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
        gv.DataSource = obj.LoadAllReports(obj);
        gv.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        BindData();
    }
}