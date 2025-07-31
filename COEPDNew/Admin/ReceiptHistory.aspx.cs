using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ReceiptHistory : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void setGridView()
    {
        if (CurrentUser.IsAdmin == false)
        {
            //  gv.Columns[0].Visible = false;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);

        if (!IsPostBack)
        {
            BindData();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("LeadRegisteredSearch.aspx");
    }


    protected void BindData()
    {
        clsReceipt obj = new clsReceipt();
        //   obj.LeadId = Convert.ToInt16(ItemId);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
        setGridView();
    }


}