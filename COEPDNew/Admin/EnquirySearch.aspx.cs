using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class EnquirySearch : System.Web.UI.Page
{
    int Total = 0;
    CurrentUser currentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            BindData();
    }

    protected void BindData()
    {
        clsEnquiry Obj = new clsEnquiry();
        List<clsEnquiry> items = Obj.LoadAll(Obj);
        if (items != null)
        {
            Total = items.Count;

        }
        gv.DataSource = Obj.LoadAll(Obj);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName == "cmdEdit")
        {
            Response.Redirect("Enquiry.aspx?ItemId=" + e.CommandArgument);
        }
        if(e.CommandName == "cmdDelete")
        {
            clsEnquiry Item = new clsEnquiry();
            Item.Remove(Convert.ToInt16(e.CommandArgument));
            BindData();
            ErrorMessage.Text = "Enquiry successfully removed";
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
}