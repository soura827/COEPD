using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ActivityFeatureLinkSearch : System.Web.UI.Page
{
    int Total = 0;
    protected void Page_PreInit(object sender, EventArgs e)
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
        clsActivityFeatureLink obj = new clsActivityFeatureLink();
        if (txtSearch.Text != "")
            obj.ActivityFeatureName = txtSearch.Text;
        
        List<clsActivityFeatureLink> items = obj.LoadAll(obj);
        if (items != null)
        {
            Total = items.Count;
        }
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();

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
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "-" + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "-" + "Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
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
            Response.Redirect("ActivityFeatureLink.aspx?ItemId=" + e.CommandArgument);
        }
        //else if (e.CommandName == "cmdDelete")
        //{
        //    int ItemId = Convert.ToInt32(e.CommandArgument);
        //    clsKPI Item = new clsKPI();
        //    Item.Remove(ItemId);

        //    ErrorMessage.Text = "Activity Feature successfully removed";
        //    ErrorMessage.Visible = true;
        //}
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ActivityFeatureLink.aspx");
    }

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    
}
