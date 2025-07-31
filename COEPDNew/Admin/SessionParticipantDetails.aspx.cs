using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_SessionParticipantDetails : System.Web.UI.Page
{
    int Total = 0;
    DateTime DateTime;
    int SessionId = 0;
    int ItemId = 0;
    CurrentUser currentUser = new CurrentUser();
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
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (ItemId > 0)
        {
            clsSession obj = new clsSession();
            obj.SessionId = ItemId;
            if(txtKeywords.Text != null)
            {
                obj.Keywords = txtKeywords.Text;
            }

            gv.DataSource = obj.SessionParticipantList(obj);
            gv.DataBind();

        }

    }

  

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();

    }

    protected void gv_PreRender(object sender, EventArgs e)
    {
        
    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("SessionSearch.aspx");

    }



    protected void txtKeywords_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SessionAttendparticipantDetails.aspx");
    }
}