using BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_SessionAttendendedParticipantDetailsAll : System.Web.UI.Page
{
    int Total = 0;
    DateTime DateTime;
    int SessionId = 0;
    int ItemId = 0;
    CurrentUser currentUser = new CurrentUser();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            DateTime dateTime;
            dateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            txtFromDate.Text = dateTime.ToString("dd/MM/yyyy");
            txtToDate.Text = dateTime.ToString("dd/MM/yyyy");

            BindData();

        }
    }
    protected void BindData()
    {

        clsSession obj = new clsSession();
        if (txtKeywords.Text != null)
        {
            obj.Keywords = txtKeywords.Text;
        }
        if (txtSessionName.Text != null)
        {
            obj.SessionName = txtSessionName.Text;
        }


        if (txtFromDate.Text != "")
            obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        else
            obj.FromDate = null;
        if (txtToDate.Text != "")
            obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        else
            obj.ToDate = null;



        gv.DataSource = obj.SessionParticipantListAll(obj);
        gv.DataBind();

    }


    protected void btnDownload_Click(object sender, EventArgs e)
    {
        string FileNamePrepix = string.Empty;
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        FileNamePrepix = DateTime.ToString("dd-MM-yyyy - hh mm tt");
        ExportToExcel(FileNamePrepix + "-SessionAttendence.xls", gv);
    }
    protected void ExportToExcel(string strFileName, GridView gv)
    {
        Response.ClearContent();
        Response.AddHeader("content-disposition", "attachment; filename=" + strFileName);
        Response.ContentType = "application/excel";
        StringWriter SW = new StringWriter();
        HtmlTextWriter HTW = new HtmlTextWriter(SW);
        //gv.RenderControl(HTW);
        gv.RenderControl(HTW);
        Response.Write(SW.ToString());
        Response.End();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
           server control at run time. */
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("SessionSearch.aspx");

    }

    protected void txtKeywords_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SessionAttendparticipantDetails.aspx");
    }

    protected void txtSessionName_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtFromDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtToDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
}