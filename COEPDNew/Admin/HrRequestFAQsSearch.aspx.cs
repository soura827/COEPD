using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_HrRequestFAQsSearch : System.Web.UI.Page
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

        clsHrRequestFAQs obj = new clsHrRequestFAQs();
        if (txtCompanyName.Text != "")
        {
            obj.CompanyName = txtCompanyName.Text;
        }
        if (txtDomain.Text != "")
        {
            obj.Domain = txtDomain.Text;
        }
        if (txtLocation.Text != "")
        {
            obj.Location = txtLocation.Text;
        }

        if (ddlIsSent.SelectedValue != "")
        {
            obj.IsSent = Convert.ToBoolean(ddlIsSent.SelectedValue);
        }
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();

    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "cmdAssign")
        {
            Response.Redirect("FAQsMaster.aspx?HRFId=" + e.CommandArgument);
        }
        //else if (e.CommandName == "cmdView")
        //{
        //    Response.Redirect("FAQsMaster.aspx?HRFId=" + e.CommandArgument);
        //}

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

    protected void txtDomain_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtCompanyName_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void ddlIsSent_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtLocation_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }




}