using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_COEPDClientsSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    DateTime DateTime;
    string message;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
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
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("COEPDClients.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        clsCOEPDClients obj = new clsCOEPDClients();
        obj.Keywords = Convert.ToString(txtSearch.Text);
        if (txtFromDate.Text != "")
        {
            message += "From : " + txtFromDate.Text + " ";
            obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
            obj.FromDate = null;

        if (txtToDate.Text != "")
        {
            message += "To  : " + txtToDate.Text + " ";
            obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else 
            obj.ToDate = null;
       


        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("COEPDClients.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsCOEPDClients Item = new clsCOEPDClients();
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "COEPD Client successfully removed";
            ErrorMessage.Visible = true;
        }
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void txtToDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtFromDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void btnDownload_Click(object sender, EventArgs e)
    {
        //ExportToExcel("Jobs.xls", gv);
        string FileNamePrepix = string.Empty;
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        FileNamePrepix = DateTime.ToString("dd-MM-yyyy - hh mm tt");
        ExportToExcel(FileNamePrepix + "-Jobs.xls", gv);
    }

    protected void ExportToExcel(string strFileName, GridView gv)
    {
        Response.ClearContent();
        Response.AddHeader("content-disposition", "attachment; filename=" + strFileName);
        Response.ContentType = "application/excel";

        StringWriter sw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        gv.RenderControl(htw);
        Response.Write(sw.ToString());
        Response.End();
    }

    public override void VerifyRenderingInServerForm(Control control)
    {

    }
}