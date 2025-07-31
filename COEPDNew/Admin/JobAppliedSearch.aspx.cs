using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_JobAppliedSearch : System.Web.UI.Page
{
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
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
        clsJobApplied obj = new clsJobApplied();
        if (txtParticipant.Text != "")
            obj.Keywords = txtParticipant.Text;
        if (txtLocation.Text != "")
            obj.Location = txtLocation.Text;
        if (txtCompany.Text != "")
            obj.Company = txtCompany.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void txtParticipant_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtLocation_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtCompany_TextChanged(object sender, EventArgs e)
    {
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
}