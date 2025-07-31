using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_IdeaPostedAll : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
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
  
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void btnEmployee_Click(object sender, EventArgs e)
    {
        gv1.Visible = false;
        gv.Visible = true;
        BindData();
    }
    protected void btnParticipant_Click(object sender, EventArgs e)
    {
        CurrentUser CU = new CurrentUser();
        Int32 userbranchid = CU.UserBranchId;

        if (userbranchid == 19)
        {
            gv.Visible = false;
            gv1.Visible = true;
            CurrentUser cu = new CurrentUser();
            Int32 UserBranchId = cu.UserBranchId;
            clsIdeaPost obj = new clsIdeaPost();
            obj.keywords = txtSearch.Text;
            obj.BranchId = UserBranchId;
            List<clsIdeaPost> objList = obj.LoadAllParticpants(obj);
            gv1.Caption = "Participants Posted Feedback";
            gv1.DataSource = objList;
            gv1.DataBind();
        }
        else
        {
            gv.Visible = false;
            gv1.Visible = true;
            clsIdeaPost obj = new clsIdeaPost();
            obj.keywords = txtSearch.Text;
            List<clsIdeaPost> objList = obj.LoadAllIdeaPost_List_ByBranchIdParticipants(obj);
            gv1.Caption = "Participants Posted Feedback";
            gv1.DataSource = objList;
            gv1.DataBind();
        }
    }
    protected void BindData()
    {
        CurrentUser CU = new CurrentUser();
        Int32 userbranchid = CU.UserBranchId;
        if (userbranchid == 19)
        {
            clsIdeaPost obj = new clsIdeaPost();
            obj.keywords = txtSearch.Text;
            List<clsIdeaPost> objList = obj.LoadAllEmployees(obj);
            gv.Caption = "Employee Posted Ideas";
            gv.DataSource = objList;
            gv.DataBind();
        }
        else {
            CurrentUser cu = new CurrentUser();
            Int32 UserBranchId = cu.UserBranchId;
            clsIdeaPost obj = new clsIdeaPost();
            obj.keywords = txtSearch.Text;
            obj.BranchId = UserBranchId;
            //List<clsIdeaPost> objList = obj.LoadAllEmployees(obj);
            List<clsIdeaPost> objList = obj.LoadallIdeaPost_List_ByBranchIdEmployees(obj);
            gv.Caption = "Employee Posted Ideas";
            gv.DataSource = objList;
            gv.DataBind();
        }
    }

    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("IdeaPost.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsIdeaPost Item = new clsIdeaPost();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Posted Idea successfully removed";
            ErrorMessage.Visible = true;
        }
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }

    protected void gv_PreRender(object sender, EventArgs e)
    {

    }
}