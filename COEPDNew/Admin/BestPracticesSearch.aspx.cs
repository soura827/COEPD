using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class BestPracticesSearch : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindData();
        }
    }
    public void BindData()
    {
        clsBestPractices obj = new clsBestPractices();
        obj.keywords = txtSearch.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    //protected void btnAdd_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("BestPractices.aspx");
    //}
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName =="cmdEdit")
        {
             Response.Redirect("BestPractices.aspx?ItemId=" + e.CommandArgument);
        }
    }
}