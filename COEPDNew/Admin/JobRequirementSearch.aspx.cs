using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class JobRequirementSearch : System.Web.UI.Page
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

    public void BindData()
    {
        clsJobRequirement obj = new clsJobRequirement();
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("JobRequirement.aspx");
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("JobRequirement.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsJobRequirement Item = new clsJobRequirement();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Job requirement successfully removed";
            ErrorMessage.Visible = true;
        }
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //This Command is used to disable Delete option for associates and enable for only Admin.
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (CurrentUser.CurrentEmployeeId == 2 || CurrentUser.CurrentEmployeeId == 1)
            {
                LinkButton lnk = (LinkButton)e.Row.FindControl("lnkDelete");
                lnk.Visible = true;
            }
            else
            {
                LinkButton lnk = (LinkButton)e.Row.FindControl("lnkDelete");
                lnk.Visible = false;
            }
        }
    }
}