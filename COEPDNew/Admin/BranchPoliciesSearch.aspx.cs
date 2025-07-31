using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using BusinessLayer;
public partial class Admin_BranchPoliciesSearch : System.Web.UI.Page
{
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindData();
        }
    }
    protected void BindData()
    {
        clsBranchPolicies obj = new clsBranchPolicies();
        if (txtPageTitle.Text != "")
            obj.PolicyTitle=txtPageTitle.Text;
        if (txtLocation.Text != "")
            obj.Location = txtLocation.Text;
        if (txtBranch.Text != "")
            obj.Branch = txtBranch.Text;
        if (txtFullname.Text != "")
            obj.Fullname = txtFullname.Text;
        if (txtModified.Text != "")
            obj.Modifiedname = txtModified.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void txtLocation_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtBranch_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void txtPageTitle_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void txtFullname_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void txtModified_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("BranchPolicies.aspx");
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {

            Response.Redirect("BranchPolicies.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsBranchPolicies Item = new clsBranchPolicies();
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Branch Policies successfully removed";
            ErrorMessage.Visible = true;
        }
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
}