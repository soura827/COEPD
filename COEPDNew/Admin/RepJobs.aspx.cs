using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class RepJobs : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    string message;
    DateTime DateTime;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //BindJobCategory();
            BindJobDomain();

            DateTime dateTime;
            dateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            txtFromDate.Text = dateTime.ToString("dd/MM/yyyy");
            txtToDate.Text = dateTime.ToString("dd/MM/yyyy");
        }
    }

    //protected void BindJobCategory()
    //{
    //    clsJobCategory obj = new clsJobCategory();
    //    ddlCategory.DataSource = obj.LoadAll(obj);
    //    ddlCategory.DataTextField = "JobCategory";
    //    ddlCategory.DataValueField = "JobCategoryId";
    //    ddlCategory.DataBind();
    //    //ddlCategory.Items.Insert(0, new ListItem("-- Select Category --", "0"));
    //}

    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindJobDomain()
    {
        clsJobDomain obj = new clsJobDomain();
        ddlJobDomain.DataSource = obj.LoadAll(obj);
        ddlJobDomain.DataTextField = "JobDomain";
        ddlJobDomain.DataValueField = "JobDomainId";
        ddlJobDomain.DataBind();
        ddlJobDomain.Items.Insert(0, new ListItem("-- Select Domain --", "0"));
    }

    protected void ddlJobDomain_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindData()
    {
        clsJob obj = new clsJob();
       
        obj.JobCategory = txtbusiness.Text;
        obj.JobDomainId = Convert.ToInt16(ddlJobDomain.SelectedValue);
        obj.Experience = txtexp.Text;
        //if (txtbusiness.Text != null)
        //{
        //    message += txtbusiness.SelectedItem + " Course ";
        //}
        //if (ddlJobDomain.SelectedIndex != 0)
        //{
        //    message += "In " + ddlJobDomain.SelectedItem + " Domain ";
        //}

        if (txtFromDate.Text != "")
        {
            message += "From : " + txtFromDate.Text + " ";
            obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.FromDate = null;
        }
        if (txtToDate.Text != "")
        {
            message += "To  : " + txtToDate.Text + " ";
            obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.ToDate = null;
        }

        obj.keywords = txtSearch.Text;
        gv.DataSource = obj.LoadAllReports(obj);
        gv.DataBind();
        gv.Caption = message;

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
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


    protected void txtexp_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
}