using BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ParticipantFeeMappingSearch : System.Web.UI.Page
{
    int Total = 0;
    DateTime DateTime;

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
    protected void BindData()
    {
        clsParticipantFeeMapping obj = new clsParticipantFeeMapping();
        if (txtSearch.Text.Length > 0)
        {
            obj.Keywords = txtSearch.Text;
        }
        obj.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
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


        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }
    

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantFeeMapping.aspx");
    }


    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("ParticipantFeeMapping.aspx?ItemId=" + e.CommandArgument);
        }
        //else if (e.CommandName == "cmdFollowup")
        //{
        //    Response.Redirect("FollowUp.aspx?ItemId=" + e.CommandArgument);
        //}
        //else if (e.CommandName == "cmdDelete")
        //{
        //    int ItemId = Convert.ToInt16(e.CommandArgument);
        //    clsLead Item = new clsLead();
        //    Item.Remove(ItemId);
        //    BindData();
        //    //ErrorMessage.Text = "Lead successfully removed";
        //    //ErrorMessage.Visible = true;
        //}
    }

    protected void btnDownload_Click(object sender, EventArgs e)
    {
        string FileNamePrepix = string.Empty;
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        FileNamePrepix = DateTime.ToString("dd-MM-yyyy - hh mm tt");
        ExportToExcel(FileNamePrepix + "-ParticipantFeeMappingSearch.xls", gv);
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
    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
           server control at run time. */
    }
}