using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_AwardSearch : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindData();
    }

    protected void BindData()
    {
        clsAward obj = new clsAward();
        if (txtSearchByAward.Text != "")
            obj.AwardName =Convert.ToString (txtSearchByAward.Text);
        if (txtCreatedByName.Text != "")
            obj.CreatedByName = txtCreatedByName.Text;
        if (txtModifiedByName.Text != "")
            obj.ModifiedByName = txtModifiedByName.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();

    }



    protected void txtSearchByAward_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Award.aspx");
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Award.aspx?ItemId=" + e.CommandArgument);

        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt32(e.CommandArgument);
            clsAward Item = new clsAward();
            Item.Remove(ItemId);
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDelete()", true);
            BindData();
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