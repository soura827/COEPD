using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class RepTasks : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    public string color;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void setGridView()
    {
        if (CurrentUser.IsAdmin == false)
        {
            //gv.Columns[0].Visible = false;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindEmployee();
            DateTime dt;
            dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            txtFromDate.Text = dt.ToString("dd/MM/yyyy");
            txtToDate.Text = dt.ToString("dd/MM/yyyy");
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindEmployee()
    {
        clsEmployeeMapped obj = new clsEmployeeMapped();
        obj.EmployeeId = CurrentUser.CurrentEmployeeId;
        ddlEmployee.DataSource = obj.Hierarchy(obj);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("-- Select Employees--", ""));

    }
    protected void BindData()
    {
        clsTask obj = new clsTask();
        obj.AssignedEmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        obj.PriorityId = Convert.ToInt32(ddlPriority.SelectedValue);
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

        List<clsTask> objList = obj.LoadAllReports(obj);
        if (objList != null)
        {
            for (int i = 0; i < objList.Count; i++)
            {
                if (objList[i].PriorityId == 1)
                {
                    objList[i].Priority = "High";
                   
                }
                else if (objList[i].PriorityId == 2)
                {
                    objList[i].Priority = "Medium";
                   
                }
                else
                {
                    objList[i].Priority = "Low";
                    
                }
            }
            for (int i = 0; i < objList.Count; i++)
            {
                if (objList[i].TaskStatusId == 1)
                {
                    objList[i].TaskStatus = "In Progress";
                    
                }
                else if (objList[i].TaskStatusId == 2)
                {
                    objList[i].TaskStatus = "Completed";
                   
                }
            }
        }
        gv.DataSource = objList;
        gv.DataBind();
        setGridView();
        gv.Caption = ddlEmployee.SelectedItem + " : Task Reports From " + txtFromDate.Text + " To " + txtToDate.Text;
    }

    protected void ddlPriority_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlPriority.SelectedIndex != 0)
        {
            BindData();
        }
        if (IsPostBack)
        {
            if (ddlPriority.SelectedIndex == 0)
            {
                BindData();
            }
        }
    }

    protected void btnDownload_Click(object sender, EventArgs e)
    {
        ExportToExcel("Task.xls", gv);
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

    public override void VerifyRenderingInServerForm(Control control)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BindData();
    }
}