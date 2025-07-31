using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_CampaignWebinarSearch : System.Web.UI.Page
{

    CurrentUser CurrentUser = new CurrentUser();

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("CampaignWebinar.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        clsCampaignWebinar obj = new clsCampaignWebinar();
        obj.Keywords = txtSearch.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
        if (rbActive.Checked == true)
        {
            obj.Keywords = txtSearch.Text;
            obj.IsActive = true;
            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();
        }
        if (rbDeleted.Checked == true)
        {
            obj.Keywords = txtSearch.Text;
            obj.IsDeleted = true;
            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();
        }
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("CampaignWebinar.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsCampaignWebinar Item = new clsCampaignWebinar();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
        }
    }



    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.DataItem != null)
            {
                HiddenField hdnCampaignFile = (HiddenField)e.Row.FindControl("hdnCampaignFile");
                HyperLink hplCampaignFile = (HyperLink)e.Row.FindControl("hplCampaignFile");

                if (hdnCampaignFile.Value == "")
                {
                    hplCampaignFile.Visible = false;
                }
            }
        }
    }
}