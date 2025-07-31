using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_LocationOfficeSearch : System.Web.UI.Page
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

    protected void BindData()
    {
        clsLocationOffice obj = new clsLocationOffice();
        obj.Keywords = txtSearch.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();   
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
      
            BindData();
            txtSearch.Text = "";
       
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("LocationOffice.aspx");
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName== "cmdEdit")
        {
            Response.Redirect("LocationOffice.aspx?ItemId="+e.CommandArgument);
        }
        else if(e.CommandName== "cmdDelete")
        {
            clsLocationOffice item = new clsLocationOffice();
            int ItemId = Convert.ToInt32(e.CommandArgument);
            item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Office successfully removed";
            ErrorMessage.Visible = true;
        }
    }
}