using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ZoomMeetingAttendanceSearch : System.Web.UI.Page
{
    int Total = 0;
    CurrentUser CurrentUser;
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
        clsZoomMeetingAttendance Item = new clsZoomMeetingAttendance();
        //if (txtUserName.Text != "")
           // Item.UserId = CurrentUser.CurrentUserId;
        //if (ddlZoommeetingCategory.Text != "")
        //    Item.ZoomMeetingCategory = Convert.ToString(ddlZoommeetingCategory.Text);

        List<clsZoomMeetingAttendance> items = Item.LoadAll(Item);
        if (items != null)
        {
            Total = items.Count;

        }
        gv.DataSource = Item.LoadAll(Item);
        gv.DataBind();
    }


    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
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


    protected void gv_PreRender(object sender, EventArgs e)
    {

    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
    protected void txtUserName_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ZoomMeetingSearch.aspx");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

    }
}