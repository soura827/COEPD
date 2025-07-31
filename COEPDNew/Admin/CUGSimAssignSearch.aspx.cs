using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using static System.Net.Mime.MediaTypeNames;


public partial class Admin_CUGSimAssignSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int Total = 0;
    DateTime DateTime;
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    protected void btnDownload_Click(object sender, EventArgs e)
    {
        string FileNamePrepix = string.Empty;
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        FileNamePrepix = DateTime.ToString("dd-MM-yyyy - hh mm tt");
        ExportToExcel(FileNamePrepix + "-CUG.xls", gv);
    }
    protected void ExportToExcel(string strFileName, GridView gv)
    {
        Response.ClearContent();
        Response.AddHeader("content-disposition", "attachment; filename=" + strFileName);
        Response.ContentType = "application/excel";
        StringWriter SW = new StringWriter();
        HtmlTextWriter HTW = new HtmlTextWriter(SW);
        gv.AllowPaging = false;
        //gv.RenderControl(HTW);
        gv.RenderControl(HTW);
        Response.Write(SW.ToString());
        Response.End();
    }



    protected void BindData()
    {
        clsCUGSimAssign obj = new clsCUGSimAssign();
        if (txtEmployeeName.Text != "")
            obj.Keywords = txtEmployeeName.Text;
        if (txtMobile.Text != "")
            obj.Mobile = txtMobile.Text;
        if(txtSimUsedFor.Text != "")
            obj.SimUsedFor = txtSimUsedFor.Text;
        if (ddlStatus.SelectedValue != "")
            obj.IsSimUnAssigned = Convert.ToBoolean(ddlStatus.SelectedValue);
            obj.Code = Convert.ToString(txtCode.Text);
        List<clsCUGSimAssign> items = obj.LoadAll(obj);
        if (items != null)
            Total = items.Count;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void txtEmployeeName_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName == "cmdUnAssign")
        {
            Response.Redirect("CUGSimAssign.aspx?ItemId=" + e.CommandArgument);
        }
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void gv_PreRender(object sender, EventArgs e)
    {
        int TotalRecords = 0;
        string Records = "";
        TotalRecords = (gv.PageSize * (gv.PageIndex + 1));
        if (TotalRecords > Total)
            Records = Total.ToString();
        else
            Records = TotalRecords.ToString();


        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }

    protected void btnAssign_Click(object sender, EventArgs e)
    {
        Response.Redirect("CUGSimAssign.aspx");
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Verifies that the control is rendered */
    }

    protected void txtSimUsedFor_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtCode_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
}