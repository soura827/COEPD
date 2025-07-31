using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.IO;
public partial class Admin_EmployeeLogInLogOutReport : System.Web.UI.Page
{
    DateTime DateTime;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            txtFromDate.Text = DateTime.ToString("dd/MM/yyyy");
            txtToDate.Text = DateTime.ToString("dd/MM/yyyy");
            BindData();
        }

    }
    protected void BindData()
    {
        clsEmployeeLogInLogOutReport Obj = new clsEmployeeLogInLogOutReport();
        if (txtEmployeeDetails.Text != "")
            Obj.Keywords = txtEmployeeDetails.Text;
        if (txtBranch.Text != "")
            Obj.Branch = txtBranch.Text;
        if (txtFromDate.Text != "")
        {
            Obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            Obj.FromDate = null;
        }
        if (txtToDate.Text != "")
        {
            Obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            Obj.ToDate = null;
        }
        gv.Caption = "Report From " + txtFromDate.Text + " To " + txtToDate.Text;
        gv.DataSource = Obj.LoadAll(Obj);
        gv.DataBind();
    }
    protected void txtEmployeeDetails_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtBranch_TextChanged(object sender, EventArgs e)
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

    protected void btnDownload_Click(object sender, EventArgs e)
    {
        string FileNamePrepix = string.Empty;
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        FileNamePrepix = DateTime.ToString("dd-MM-yyyy - hh mm tt");
        ExportToExcel(FileNamePrepix+"-EMPLoginLogoutReport.xls", gv);
    }
    protected void ExportToExcel(string strFileName, GridView gv)
    {
        Response.ClearContent();
        Response.AddHeader("content-disposition", "attachment; filename=" + strFileName);
        Response.ContentType = "application/excel";
        StringWriter SW = new StringWriter();
        HtmlTextWriter HTW = new HtmlTextWriter(SW);
        gv.RenderControl(HTW);
        Response.Write(SW.ToString());
        Response.End();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {

    }
}