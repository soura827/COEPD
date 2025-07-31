using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class EmployeeSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    DateTime DateTime;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    } 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadDesignation();
            BindData();
        }
        BindData();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Employee.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void LoadDesignation()
    {
        clsDesignation obj = new clsDesignation();
        ddlDesignation.DataSource = obj.LoadAll(obj);
        ddlDesignation.DataTextField = "Designation";
        ddlDesignation.DataValueField = "DesignationId";
        ddlDesignation.DataBind();
        ddlDesignation.Items.Insert(0, new ListItem("-- Select Designation --", "0"));
    }
    protected void BindData()
    {
        clsEmployee obj = new clsEmployee();
        obj.DesignationId = Convert.ToInt32(ddlDesignation.SelectedValue);
        obj.keywords = txtSearch.Text;
        //if (txtLocation.Text != null)
        //{
        //    obj.Location = txtLocation.Text;

        //}
       
        
        obj.IsActive = true;
        gv.DataSource = obj.LoadAll_InActive(obj);
        gv.DataBind();
        if (rbActive.Checked == true)
        {
            obj.keywords = txtSearch.Text;
            obj.IsActive = true;
            gv.DataSource = obj.LoadAll_InActive(obj);
            gv.DataBind();
        }
        if (rbDeleted.Checked == true)
        {
            obj.keywords = txtSearch.Text;
            obj.IsActive = false;
            obj.IsDeleted = false;
            gv.DataSource = obj.LoadAll_InActive(obj);
            gv.DataBind();
        }
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Employee.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsEmployee Item = new clsEmployee();
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Employee successfully removed";
            ErrorMessage.Visible = true;
        }
    }
    protected void ddlDesignation_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.DataItem != null)
            {
                HiddenField hdnResumeFile = (HiddenField)e.Row.FindControl("hdnResumeFile");
                HyperLink hplResumeFile = (HyperLink)e.Row.FindControl("hplResume");
                if (hdnResumeFile.Value == "")
                {
                    hplResumeFile.Visible = false;
                }
                HiddenField hdnBankPassbook = (HiddenField)e.Row.FindControl("hdnBankPassbook");
                HyperLink hplBankPassbook = (HyperLink)e.Row.FindControl("hplBankPassbook");
                if (hdnBankPassbook.Value == "")
                {
                    hplBankPassbook.Visible = false;
                }
                HiddenField hdnPancardFilePath = (HiddenField)e.Row.FindControl("hdnPancardFilePath");
                HyperLink hplPancardFilePath = (HyperLink)e.Row.FindControl("hplPancardFilePath");
                if (hdnPancardFilePath.Value == "")
                {
                    hplPancardFilePath.Visible = false;
                }
                HiddenField hdnAadharFrontFilePath = (HiddenField)e.Row.FindControl("hdnAadharFrontFilePath");
                HyperLink hplAadharFrontFilePath = (HyperLink)e.Row.FindControl("hplAadharFrontFilePath");
                if (hdnAadharFrontFilePath.Value == "")
                {
                    hplAadharFrontFilePath.Visible = false;
                }
                HiddenField hdnAadharBackFilePath = (HiddenField)e.Row.FindControl("hdnAadharBackFilePath");
                HyperLink hplAadharBackFilePath = (HyperLink)e.Row.FindControl("hplAadharBackFilePath");
                if (hdnAadharBackFilePath.Value == "")
                {
                    hplAadharBackFilePath.Visible = false;
                }
                if (CurrentUser.CurrentEmployeeId==1 || CurrentUser.CurrentEmployeeId==2)
                {
                    LinkButton lnk = (LinkButton)e.Row.FindControl("lnkDelete");
                    lnk.Visible = true;
                }
               else
                {
                    LinkButton lnk = (LinkButton)e.Row.FindControl("lnkDelete");
                    lnk.Visible = false;
                }
            }
        }
    }

    //protected void txtLocation_TextChanged(object sender, EventArgs e)
    //{
    //    BindData();
    //}

    protected void btnDownload_Click(object sender, EventArgs e)
    {

    

   
        string FileNamePrepix = string.Empty;
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        FileNamePrepix = DateTime.ToString("dd-MM-yyyy - hh mm tt");
        ExportToExcel(FileNamePrepix + "-EMPLoginLogoutReport.xls", gv);
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