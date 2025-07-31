using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Configuration;
using System.Data;

public partial class Admin_TermsAcceptedParticipantsSearch : System.Web.UI.Page
{
    int Total = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            BindData();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        clsTermsAcceptedParticipants obj = new clsTermsAcceptedParticipants();
        if (txtSearch.Text.Length > 0)
            obj.Keywords = txtSearch.Text;
        List<clsTermsAcceptedParticipants> items = obj.LoadAll(obj);
        if (items != null)
            Total = items.Count;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
        //SNO = gv.Rows.Count;
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        FormMessage.Visible = false;
        ErrorMessage.Visible = false;
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

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    (e.Row.FindControl("lblSNO") as Label).Text = (SNO - e.Row.RowIndex).ToString();
        //}

    }

    protected void gv_DataBound(object sender, EventArgs e)
    {
        //SNO = gv.Rows.Count;
    }
}