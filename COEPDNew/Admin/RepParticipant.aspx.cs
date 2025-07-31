using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class RepParticipant : System.Web.UI.Page
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
            BindCourse();
            BindBatchType();
            BindLocation();
            BindTrainer();
        }
    }

    protected void BindCourse()
    {
        clsCourse obj = new clsCourse();
        ddlCourse.DataSource = obj.LoadAll(obj);
        ddlCourse.DataTextField = "Course";
        ddlCourse.DataValueField = "CourseId";
        ddlCourse.DataBind();
        ddlCourse.Items.Insert(0, new ListItem("-- Select Course --", ""));
    }

    protected void BindBatchType()
    {
        clsBatchType obj = new clsBatchType();
        ddlBatchType.DataSource = obj.LoadAll(obj);
        ddlBatchType.DataTextField = "BatchType";
        ddlBatchType.DataValueField = "BatchTypeId";
        ddlBatchType.DataBind();
        ddlBatchType.Items.Insert(0, new ListItem("-- Select BatchType --", ""));

    }

    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("-- Select Location --", ""));
    }

    protected void BindTrainer()
    {
        clsEmployee obj = new clsEmployee();
        obj.DesignationId = 2;
        ddlTrainer.DataSource = obj.LoadAll(obj);
        ddlTrainer.DataTextField = "Employee";
        ddlTrainer.DataValueField = "EmployeeId";
        ddlTrainer.DataBind();
        ddlTrainer.Items.Insert(0, new ListItem("-- Select Trainer --", ""));
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindData()
    {
        clsParticipant obj = new clsParticipant();
        obj.CourseId = Convert.ToInt16(ddlCourse.SelectedValue);
        obj.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedValue);
        obj.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        obj.EmployeeId = Convert.ToInt16(ddlTrainer.SelectedValue);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
        gv.Caption = ddlCourse.SelectedItem + " - " + ddlBatchType.SelectedItem + " - " + ddlLocation.SelectedItem + " - " + ddlTrainer.SelectedItem;
    }
    
    protected void btnDownload_Click(object sender, EventArgs e)
    {
        ExportToExcel("ParticipantList.xls", gv);
    }

    public override void VerifyRenderingInServerForm(Control control)
    {

    }

    protected void ExportToExcel(string strFileName, GridView gv)
    {
        Response.ClearContent();
        Response.AddHeader("content-disposition", "attachment; filename=" + strFileName);
        Response.ContentType = "application/excel";

        System.IO.StringWriter sw = new System.IO.StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        gv.RenderControl(htw);
        Response.Write(sw.ToString());
        Response.End();
    }
}