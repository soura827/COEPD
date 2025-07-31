using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Session : System.Web.UI.Page
{

    int ItemId = 0;
    clsSession Item = new clsSession();
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {

            LoadSessionType();
            LoadSessionEmployees();
            Item = new clsSession();
            if (ItemId > 0)
            {

                lblTitle.Text = "Edit Session Details";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlSession.SelectedValue = Item.SessionTypeId.ToString();
                    txtAwarenessSessionName.Text = Convert.ToString(Item.AwarenessSessionName);
                    txtDate.Text = Item.Date.ToString("yyyy-MM-dd");
                    txtStarttime.Text = Convert.ToString(Item.StartTime);
                    txtEndtime.Text = Convert.ToString(Item.EndTime);
                    txtZoomMeetingId.Text = Convert.ToString(Item.ZoomMeetingId);
                    txtPassword.Text = Convert.ToString(Item.Password);
                    ddlSessionTrainer.SelectedValue = Convert.ToString(Item.SessionEmployeeId);
                    if (Item.AwarenessSessionName == "")
                    {
                        divAwareness.Visible = false;
                    }
                    else
                    {
                        divAwareness.Visible = true;
                    }

                }

            }
            else
            {
                lblTitle.Text = "Add Session Details";
            }
        }
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


    protected void LoadSessionEmployees()
    {
        clsSession obj = new clsSession();
        if (txtSessionTrainer.Text != null)
            obj.Keywords = txtSessionTrainer.Text;
        ddlSessionTrainer.DataSource = obj.LoadAllSessionEmployee(obj);
        ddlSessionTrainer.DataTextField = "Employee";
        ddlSessionTrainer.DataValueField = "EmployeeId";
        ddlSessionTrainer.DataBind();
        ddlSessionTrainer.Items.Insert(0, new ListItem("-- Select Employee Type --", ""));
    }






    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsSession Item = new clsSession();

        if (ItemId > 0)
            Item.SessionId = Convert.ToInt32(ItemId);


        if (ddlSession.SelectedValue == "2")
            Item.AwarenessSessionName = Convert.ToString(txtAwarenessSessionName.Text);

        Item.SessionTypeId = Convert.ToInt32(ddlSession.SelectedValue);
        Item.Date = Convert.ToDateTime(txtDate.Text);
        Item.StartTime = Convert.ToString(txtStarttime.Text);
        Item.EndTime = Convert.ToString(txtEndtime.Text);
        Item.ZoomMeetingId = Convert.ToString(txtZoomMeetingId.Text);
        Item.Password = Convert.ToString(txtPassword.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.SessionEmployeeId = Convert.ToInt32(ddlSessionTrainer.SelectedValue);
        Item.AddUpdate(Item);

        clear();


        if (ItemId > 0)
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        else
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);

        //Response.Redirect(Request.Url.AbsoluteUri, false);
    }
    protected void clear()
    {
        txtAwarenessSessionName.Text = "";
        ddlSession.SelectedValue = "";
        txtDate.Text = "";
        txtStarttime.Text = "";
        txtEndtime.Text = "";
        txtZoomMeetingId.Text = "";
        txtPassword.Text = "";
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SessionSearch.aspx");
    }
    protected void ddlSession_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (ddlSession.SelectedValue == "2")
        {
            divAwareness.Visible = true;
        }
        else
        {
            divAwareness.Visible = false;
        }

    }


    protected void txtSessionTrainer_TextChanged(object sender, EventArgs e)
    {
        LoadSessionEmployees();
    }
}