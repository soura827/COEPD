using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class BranchSearch : System.Web.UI.Page
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
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Branch.aspx");
    }
    protected void BindData()
    {
       clsBranch obj = new clsBranch();
        if (txtBranch.Text != "")
            obj.Branch = txtBranch.Text;
        if (txtLocation.Text != "")
            obj.Location = txtLocation.Text;
        if (txtFullname.Text != "")
            obj.Fullname = txtFullname.Text;
        if (textModified.Text != "")
            obj.Modifiedname = textModified.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
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
            Response.Redirect("Branch.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsBranch Item = new clsBranch();
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Branch successfully removed";
            ErrorMessage.Visible = true;
        }
    }
    protected void txtLocation_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void txtBranch_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void txtFullname_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void textModified_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void gv_PreRender(object sender, EventArgs e)
    {
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + (gv.PageCount).ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + (gv.PageCount).ToString();
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }
}