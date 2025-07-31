using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class EmployeeDocumentSearch : System.Web.UI.Page
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
            BindData();
            BindSharedData();
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("EmployeeDocument.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        clsEmployeeDocument obj = new clsEmployeeDocument();
        obj.EmployeeId = CurrentUser.CurrentEmployeeId;
        obj.keywords = txtSearch.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();       
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("EmployeeDocument.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsEmployeeDocument Item = new clsEmployeeDocument();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Employee Document successfully removed";
            ErrorMessage.Visible = true;
        }
        else if (e.CommandName == "cmdDownload")
        {
            clsDocument obj = new clsDocument();
            if (e.CommandArgument != null)
            {
                string FilePath = Server.MapPath("~/UserDocs/EmployeeDocument/" + e.CommandArgument);
                Response.ContentType = "application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + System.IO.Path.GetFileName(FilePath));
                Response.TransmitFile(FilePath);
            }
        }
    }
    protected void BindSharedData()
    {
        clsEmployeeDocumentAssign obj = new clsEmployeeDocumentAssign();
        obj.AssignedEmployeeId = CurrentUser.CurrentEmployeeId;
        gvShared.DataSource = obj.LoadAll(obj);
        gvShared.DataBind();
    }
    protected void gvShared_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdDownload")
        {
            clsDocument obj = new clsDocument();
            if (e.CommandArgument != null)
            {
                string FilePath = Server.MapPath("~/UserDocs/EmployeeDocument/" + e.CommandArgument);
                Response.ContentType = "application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + System.IO.Path.GetFileName(FilePath));
                Response.TransmitFile(FilePath);
            }
        }
    }
}