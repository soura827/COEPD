using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_FAQsMasterSearch : System.Web.UI.Page
{

   
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

    private void BindData()
    {
        clsFAQsMaster obj = new clsFAQsMaster();
        // obj.RevisedBy = CurrentUser.CurrentEmployeeId;
        if (txtCompanyName.Text != "")
            obj.CompanyName = txtCompanyName.Text;
        if (txtExperience.Text != "")
            obj.Experience = txtExperience.Text;
        if (txtSkilSet.Text != "")
            obj.SkilSet = txtSkilSet.Text;
        if (ddlStatus.SelectedValue != null)
            obj.IsRevised = Convert.ToBoolean(ddlStatus.SelectedValue);
        if (ddlSource.SelectedValue != "")
            obj.IsSourceParticipant = Convert.ToBoolean(ddlSource.SelectedValue);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }

    protected void txtCompanyName_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("FAQsMaster.aspx");
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

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("FAQsMaster.aspx?ItemId=" + e.CommandArgument);
        }
    }


}

 

