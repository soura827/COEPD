using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ParticipantDocShareSearch : System.Web.UI.Page
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
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantDocShare.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        clsInternDocument obj = new clsInternDocument();
        obj.ParticipantId = CurrentUser.CurrentParticipantId;
        obj.keywords = txtSearch.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //if (e.CommandName == "cmdEdit")
        //{
        //    Response.Redirect("EmployeeDocument.aspx?ItemId=" + e.CommandArgument);
        //}
        //else if (e.CommandName == "cmdDelete")
        //{
        //    clsInternDocument Item = new clsInternDocument();
        //    int ItemId = Convert.ToInt16(e.CommandArgument);
        //    Item.Remove(ItemId);
        //    BindData();
        //    ErrorMessage.Text = "Item successfully removed";
        //    ErrorMessage.Visible = true;
        //}
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