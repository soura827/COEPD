using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Configuration;

public partial class Admin_ParticipantStageStatusCodeSearch : System.Web.UI.Page
{
    int ItemId = 0;
    int Total=0;
    DateTime DateTime;
    string Constr = ConfigurationManager.ConnectionStrings["cs"].ToString();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            BindData();
            BindlblTitle(); 
        }
    }

    protected void BindlblTitle()
    {

        String myquery = "Select * from tblParticipantStatusCode where StatusCode=" + txtStatusCode.Text;
        SqlConnection con = new SqlConnection(Constr);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = myquery;
        cmd.Connection = con;
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            lblTitle.Text = ds.Tables[0].Rows[0]["StatusName"].ToString();
        }
        con.Close();
    }

    protected void btnDownload_Click(object sender, EventArgs e)
    {
        string FileNamePrepix = string.Empty;
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        FileNamePrepix = DateTime.ToString("dd-MM-yyyy - hh mm tt");
        ExportToExcel(FileNamePrepix + "-RuningparticipantStageList.xls", gv);
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
        txtStatusCode.Text = Request.QueryString["ParticipantStatusCode"].ToString();
        clsParticipant obj = new clsParticipant();
        obj.ParticipantId = ItemId;
        if (txtStatusName.Text != "")
            obj.keywords = txtStatusName.Text;
        if (txtStatusCode.Text != "")
            obj.StatusCode = Convert.ToInt32(txtStatusCode.Text);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();

        /**/


    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Verifies that the control is rendered */
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("ParticipantsStatusDashboardSearch.aspx?ItemId=" + e.CommandArgument);
        }
        //else if (e.CommandName == "cmdDelete")
        //{
        //    int ItemId = Convert.ToInt32(e.CommandArgument);
        //    clsKPI Item = new clsKPI();
        //    Item.Remove(ItemId);
        //    BindData();
        //    ErrorMessage.Text = "KPI successfully removed";
        //    ErrorMessage.Visible = true;
        //}
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
        {
            Records = Total.ToString();

        }
        else
        {
            Records = TotalRecords.ToString();
        }

        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }

    //protected void txtNurturingProcessStageName_TextChanged(object sender, EventArgs e)
    //{
    //    BindData();
    //}

    protected void txtParticipantName_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantsStatusDashboardSearch.aspx");
    }
   

    protected void txtStatusCode_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
}
