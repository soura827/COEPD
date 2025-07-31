using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class Admin_ChangePassword : System.Web.UI.Page
{
    int ItemId = 0;
    ClsChangePassword Item = new ClsChangePassword();
    CurrentUser CurrentUser = new CurrentUser();
    string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {


            //LoadSessionType();
            ChangePwdEmployee();









            //Item = new clsSession();
            //if (ItemId > 0)
            //{

            //    lblTitle.Text = "Edit Session Details";
            //    Item = Item.Load(ItemId);
            //    if (Item != null)
            //    {
            //        ddlSession.SelectedValue = Item.SessionTypeId.ToString();
            //        txtAwarenessSessionName.Text = Convert.ToString(Item.AwarenessSessionName);
            //        txtDate.Text = Item.Date.ToString("yyyy-MM-dd");
            //        txtStarttime.Text = Convert.ToString(Item.StartTime);
            //        txtEndtime.Text = Convert.ToString(Item.EndTime);
            //        txtZoomMeetingId.Text = Convert.ToString(Item.ZoomMeetingId);
            //        txtPassword.Text = Convert.ToString(Item.Password);
            //        ddlSessionTrainer.SelectedValue = Convert.ToString(Item.SessionEmployeeId);
            //        if (Item.AwarenessSessionName == "")
            //        {
            //            divAwareness.Visible = false;
            //        }
            //        else
            //        {
            //            divAwareness.Visible = true;
            //        }
            //  }

            // }
            // else
            // {
          // lblTitle.Text = "Add Session Details";
            // }
        }
    }
    protected void ChangePwdEmployee()
    {
        ClsChangePassword obj = new ClsChangePassword();
        if (txtSessionTrainer.Text != null)
            obj.Keywords = txtSessionTrainer.Text;

        if (txtSessionTrainer.Text != null)
            obj.Pwd = txtOldPassword.Text;

        ddlSessionTrainer.DataSource = obj.LoadAllChangePwdEmployee(obj);
        ddlSessionTrainer.DataTextField = "Pwd";
        ddlSessionTrainer.DataTextField = "Fullname";
        ddlSessionTrainer.DataValueField = "UserId";
        ddlSessionTrainer.DataBind();
        ddlSessionTrainer.Items.Insert(0, new ListItem("-- Select Employee Type --", ""));
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ClsChangePassword Item = new ClsChangePassword();





        if (ItemId > 0)
        {
            Item.ResetId = Convert.ToInt32(ItemId);
        }
           


       

        Item.UserId = Convert.ToInt32(ddlSessionTrainer.SelectedValue);
        Item.OldPassword = Convert.ToString(txtOldPassword.Text);
        Item.NewPassword = Convert.ToString(txtStarttime.Text);
        Item.ConfirmPassword = Convert.ToString(txtConfirmPassword.Text);
        Item.Description = Convert.ToString(txtEndtime.Text);
       
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        clear();

        if (ItemId > 0)
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        else
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);

    }
    protected void clear()
    {
        txtConfirmPassword.Text = "";
        ddlSessionTrainer.SelectedValue = "";
        txtOldPassword.Text = "";
        txtStarttime.Text = "";
        txtEndtime.Text = "";
        
       
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ChangePasswordSearch.aspx");
    }

    protected void txtSessionTrainer_TextChanged(object sender, EventArgs e)
    {
        ChangePwdEmployee();
    }

    protected void txtOldPassword_TextChanged(object sender, EventArgs e)
    {
        


    }

    protected void ddlSessionTrainer_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

    protected void txtStarttime_TextChanged(object sender, EventArgs e)
    {

    }
}