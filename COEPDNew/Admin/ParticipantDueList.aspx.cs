using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ParticipantDueList : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindBatch();
            BindData();
        }
    }

    protected void BindData()
    {
        clsParticipant Item = new clsParticipant();
        Item.BatchId = Convert.ToInt32(ddlBatch.SelectedValue);
        gv.DataSource = Item.LoadDueAmount(Item);
        gv.DataBind();
    }

    protected void BindBatch()
    {
        clsBatch Item = new clsBatch();
        ddlBatch.DataSource = Item.LoadAll(Item);
        ddlBatch.DataTextField = "Batch";
        ddlBatch.DataValueField = "BatchId";
        ddlBatch.DataBind();
        ddlBatch.Items.Insert(0, new ListItem("-- All --", "0"));
    }

    protected void ddlBatch_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void btnDownload_Click(object sender, EventArgs e)
    {
        ExportToExcel("DueList.xls", gv);
    }

    protected void ExportToExcel(string strFileName, GridView gv)
    {
        Response.ClearContent();
        Response.AddHeader("content-disposition", "attachemnt; filename= " + strFileName);
        Response.ContentType = "application/Excel";

        System.IO.StringWriter sw = new System.IO.StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        gv.RenderControl(htw);
        Response.Write(sw.ToString());
        Response.End();
    }

    public override void VerifyRenderingInServerForm(Control control)
    {

    }
}