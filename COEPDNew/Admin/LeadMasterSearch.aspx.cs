using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_LeadMasterSearch : System.Web.UI.Page
{
    int Total = 0;
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadLocation();
            LoadLeadSourcePage();

            BindData();

        }
    }
    protected void BindData()
    {
        clsLeadMaster obj = new clsLeadMaster();

        if (txtNameMobileEmail.Text != null)
            obj.Keywords = txtNameMobileEmail.Text;

        if (ddlLocation.SelectedIndex != 0)
            obj.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);

        if (ddlLeadSourcePageName.SelectedIndex != 0)
            obj.LeadSourcePageId = Convert.ToInt32(ddlLeadSourcePageName.SelectedValue);


        List<clsLeadMaster> items = obj.LoadAll(obj);
        if (items != null)
            Total = items.Count;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void LoadLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("- Select Location --", ""));

    }

    protected void LoadLeadSourcePage()
    {
        clsLeadMaster obj = new clsLeadMaster();
        ddlLeadSourcePageName.DataSource = obj.LeadSourcePage(obj);
        ddlLeadSourcePageName.DataTextField = "LeadSourcePageName";
        ddlLeadSourcePageName.DataValueField = "LeadSourcePageId";
        ddlLeadSourcePageName.DataBind();
        ddlLeadSourcePageName.Items.Insert(0, new ListItem("- Select LeadSourcePage --", ""));

    }







    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {

        BindData();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Lead.aspx");
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
            Response.Redirect("ActivityCategory.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsLeadMaster Item = new clsLeadMaster();
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Lead Master  successfully removed";
            ErrorMessage.Visible = true;
        }
    }
    protected void txtActivityCategory_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void gv_PreRender(object sender, EventArgs e)
    {
        int TotalRecords = 0;
        string Records = "";
        TotalRecords = (gv.PageSize * (gv.PageIndex + 1));
        if (TotalRecords > Total)
            Records = Total.ToString();
        else
            Records = TotalRecords.ToString();

        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }
}