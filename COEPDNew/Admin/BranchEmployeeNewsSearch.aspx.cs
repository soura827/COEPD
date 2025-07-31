using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_BranchEmployeeNewsSearch : System.Web.UI.Page
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
        clsBranchEmployeeNews obj = new clsBranchEmployeeNews();
        if (txtNewsDescription.Text != "")
            obj.NewsDescription = txtNewsDescription.Text;
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
    protected void txtNewsDescription_TextChanged(object sender, EventArgs e)
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

    protected void Add_Click(object sender, EventArgs e)
    {
        Response.Redirect("BranchEmployeeNews.aspx");
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("BranchEmployeeNews.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsBranchEmployeeNews Item = new clsBranchEmployeeNews();
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Branch Employee News successfully removed";
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