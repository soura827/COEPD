using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_FAQsMasterSearch : System.Web.UI.Page
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
    private void BindData()
    {
        if(CurrentUser.CurrentParticipantId>0)
        {
            clsFAQsMaster obj = new clsFAQsMaster();
            obj.CreatedBy = CurrentUser.CurrentUserId;
            if (txtCompanyName.Text != "")
                obj.CompanyName = txtCompanyName.Text;
            if(txtExperience.Text !="")
                obj.Experience = txtExperience.Text;
            if (txtSkilSet.Text != "")
                obj.SkilSet = txtSkilSet.Text;
            if (ddlStatus.SelectedValue != "")
                obj.IsRevised = Convert.ToBoolean(ddlStatus.SelectedValue);
            obj.IsSourceParticipant = true;
            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();
        }
        else
        {
            Response.Redirect("~/Login.html");
        }
       
    }
    protected void txtCompanyName_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    //protected void btnAddNew_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("FAQsMaster.aspx");
    //}


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
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ResumeSubmissionSearch.aspx");
    }
}