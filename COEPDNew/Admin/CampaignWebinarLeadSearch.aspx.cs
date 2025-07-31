using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_CampaignWebinarLeadSearch : System.Web.UI.Page
{

    DateTime DateTime;

    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            txtFromDate.Text = DateTime.ToString("dd/MM/yyyy");
            txtToDate.Text = DateTime.ToString("dd/MM/yyyy");
            BindData();
        }
    }
    protected void BindData()
    {
        clsCoepdWebinarValue Obj = new clsCoepdWebinarValue();
        if (txtTitle.Text != "")
            Obj.Title = txtTitle.Text;
        if (txtLocation.Text != "")
            Obj.Location = txtLocation.Text;
        if (txtFromDate.Text != "")
        {
            Obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            Obj.FromDate = null;
        }
        if (txtToDate.Text != "")
        {
            Obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            Obj.ToDate = null;
        }
        gv.Caption = "Campaign Leads From " + txtFromDate.Text + " To " + txtToDate.Text;
        gv.DataSource = Obj.LoadAll(Obj);
        gv.DataBind();
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void gv_PreRender(object sender, EventArgs e)
    {
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }

    protected void txtFromDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtToDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtTitle_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtLocation_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
}



    