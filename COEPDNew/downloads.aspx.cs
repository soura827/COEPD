using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class downloads : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    protected void BindData()
    {
        clsDownload obj = new clsDownload();
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdDownload")
        {
            string ImagePath = Convert.ToString(e.CommandArgument);
            string thePath = "UserDocs/Download/" + ImagePath;
            Response.ContentType = "application/octet-stream";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + ImagePath);
            Response.TransmitFile(thePath);
            Response.End();
        }
    }
}