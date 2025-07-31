using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class NormalParticipantTimeSheetSearch : System.Web.UI.Page
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
    protected void BindData()
    {
        DateTime dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        clsNormalParticipantTimeSheet obj = new clsNormalParticipantTimeSheet();
        obj.Date = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null));
        obj.keywords = txtSearch.Text;
        obj.ParticipantId = CurrentUser.CurrentParticipantId;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    //protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    //{
    //    if (e.CommandName == "cmdEdit")
    //    {
    //        Response.Redirect("ParticipantTimeSheet.aspx?ItemId=" + e.CommandArgument);
    //    }
    //    else if (e.CommandName == "cmdDelete")
    //    {
    //        clsNormalParticipantTimeSheet Item = new clsNormalParticipantTimeSheet();
    //        int ItemId = Convert.ToInt16(e.CommandArgument);
    //        Item.Remove(ItemId);
    //        BindData();

    //        string script = "window.onload = function(){ alert('Details removed successfully');  }";
    //        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
    //    }
    //}

    //protected void btnAdd_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("ParticipantTimeSheet.aspx");
    //}
    //protected void btnSearch_Click1(object sender, EventArgs e)
    //{
    //    BindData();
    //}
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("NormalParticipantTimeSheet.aspx");
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("NormalParticipantTimeSheet.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsNormalParticipantTimeSheet Item = new clsNormalParticipantTimeSheet();
            int ItemId = Convert.ToInt32(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            string script = "window.onload = function(){ alert('Details removed successfully');  }";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
        }
    }
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.RowIndex == 0)
            {
                e.Row.Cells[0].Text = "";
            }
        }
    }
}