using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_SessionJobMarket : System.Web.UI.Page
{
    int Total = 0;
    DateTime DateTime;
    CurrentUser currentUser = new CurrentUser();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtFromDate.Text = DateTime.UtcNow.AddHours(5).AddMinutes(30).ToString("dd/MM/yyyy");
            txtToDate.Text = DateTime.UtcNow.AddHours(5).AddMinutes(30).ToString("dd/MM/yyyy");
            BindData();
            LoadSessionType();
        }

    }
    protected void BindData()
    {
        clsSession obj = new clsSession();
        if (ddlSession.SelectedValue == "")
        {
            // obj.SessionTypeId = Convert.ToInt32(ddlSession.SelectedValue);
            obj.SessionTypeId = 4;

        }
        if(txtTrainer.Text != "")
        {
            obj.Employee = txtTrainer.Text;
        }



        if (txtFromDate.Text != "")
        {
            obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.FromDate = null;
        }
        if (txtToDate.Text != "")
        {
            obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.ToDate = null;
        }
        gv.DataSource = obj.JobMarketLoadAll(obj);
        gv.DataBind();
    }
    protected void LoadSessionType()
    {
        clsSession obj = new clsSession();
        ddlSession.DataSource = obj.LoadForAll(obj);
        ddlSession.DataTextField = "SessionName";
        ddlSession.DataValueField = "SessionTypeId";
        ddlSession.DataBind();
        ddlSession.Items.Insert(0, new ListItem("-- Select Session Type --", ""));
    }


    protected void ddlSession_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtFromDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtToDate_TextChanged(object sender, EventArgs e)
    {
        BindData();

    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Session.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);
            clsSession Item = new clsSession();
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Session Details successfully removed";
            ErrorMessage.Visible = true;
        }
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void txtTrainer_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
}