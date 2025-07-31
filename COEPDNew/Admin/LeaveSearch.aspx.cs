using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class LeaveSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    DateTime DateTime;
    clsLeave Item;
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
        Item = new clsLeave();
        Item = Item.Loadfew (CurrentUser.CurrentUserId);
        DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Leave.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindData()
    {
        clsLeave obj = new clsLeave();
        obj.UserId = Convert.ToInt32(CurrentUser.CurrentUserId);
        if (CurrentUser.CurrentUserId == obj.UserId)
        {
            obj.UserId = Convert.ToInt32(CurrentUser.CurrentUserId);
        }


        obj.Keywords = txtSearch.Text;
        obj.EmployeeId = CurrentUser.CurrentEmployeeId;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();

    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Leave.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsLeave Item = new clsLeave();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Leave successfully removed";
            ErrorMessage.Visible = true;
        }
    }

    

   
}