using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class IdeaPostSearch : System.Web.UI.Page
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
           // BindEmployee();
            BindData();

        }
    }

    //protected void BindEmployee()
    //{
    //    clsEmployee obj = new clsEmployee();
    //    ddlEmployee.DataSource = obj.LoadAll(obj);
    //    ddlEmployee.DataTextField = "Employee";
    //    ddlEmployee.DataValueField = "EmployeeId";
    //    ddlEmployee.DataBind();
    //    ddlEmployee.Items.Insert(0, new ListItem("-- Select Employee --", "0"));
    //}
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("IdeaPost.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        clsIdeaPost obj = new clsIdeaPost();
        obj.keywords = txtSearch.Text;
        obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
        List<clsIdeaPost> objList = obj.LoadAll(obj);
        gv.DataSource = objList;
        gv.DataBind();
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
            ErrorMessage.Text = "Psted Idea successfully removed";
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
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }
}