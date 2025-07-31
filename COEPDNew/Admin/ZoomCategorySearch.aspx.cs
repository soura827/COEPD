using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;
using BusinessLayer;

public partial class Admin_ZoomCategorySearch : System.Web.UI.Page
{
    int Total = 0;
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
    
    protected void BindData()
    {
        clsZoomCategory obj = new clsZoomCategory();
        if (txtZoomCategory.Text != "")
            obj.ZoomMeetingCategory = txtZoomCategory.Text;
        if (txtFullname.Text != "")
            obj.Fullname = txtFullname.Text;
        if (textModified.Text != "")
            obj.Modifiedname = textModified.Text;

        List<clsZoomCategory> items = obj.LoadAll(obj);
        if (items != null)
        {
            Total = items.Count;

        }
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("ZoomCategory.aspx?ItemId=" + e.CommandArgument);
        }
       
              else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsZoomCategory Item = new clsZoomCategory();
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Activity Category successfully removed";
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
        int TotalRecords = 0;
        string Records = "";
        TotalRecords = (gv.PageSize * (gv.PageIndex + 1));
        if (TotalRecords > Total)
        {
            Records = Total.ToString();

        }
        else
        {
            Records = TotalRecords.ToString();
        }
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + (gv.PageSize * (gv.PageIndex + 1)).ToString() + ") Records " + " of " + Total.ToString() + " Total Records";
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " of " + gv.PageCount.ToString() + " - (" + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }

   
    protected void txtFullname_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void textModified_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtZoomCategory_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ZoomCategory.aspx");
    }
}