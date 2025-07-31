using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class VendorSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();

    DateTime DateTime;

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
            BindVendorCategory();
            BindData();

        }
    }
    protected void btnDownload_Click(object sender, EventArgs e)
    {
        string FileNamePrepix = string.Empty;
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        FileNamePrepix = DateTime.ToString("dd-MM-yyyy - hh mm tt");
        ExportToExcel(FileNamePrepix + "-RresumeSubmission.xls", gv);
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



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Vendor.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();


    }
    protected void BindData()
    {
        clsVendor obj = new clsVendor();
        obj.keywords = txtsearch.Text;
        obj.VendorCategoryId = Convert.ToInt32(ddlVendorCategory.SelectedValue);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
        setGridView();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Vendor.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsVendor Item = new clsVendor();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Vendor successfully removed";
            ErrorMessage.Visible = true;
        }
    }
    protected void ddlVendorCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindVendorCategory()
    {
        clsVendorCategory obj = new clsVendorCategory();
        ddlVendorCategory.DataSource = obj.LoadAll(obj);
        ddlVendorCategory.DataTextField = "VendorCategory";
        ddlVendorCategory.DataValueField = "VendorCategoryId";
        ddlVendorCategory.DataBind();
        ddlVendorCategory.Items.Insert(0, new ListItem("-- All Categories --", "0"));

    }



    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
           server control at run time. */
    }
}