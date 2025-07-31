using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class UserSearch : System.Web.UI.Page
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
        BindData();
    }

    protected void ddlRole_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }

    protected void BindData()
    {
        clsManageUser obj = new clsManageUser();
        obj.keywords = txtSearch.Text;
        obj.RoleId = 2;
        obj.IsActive = true;
        obj.IsDeleted = false;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();

        if (rbActive.Checked == true)
        {
            obj.keywords = txtSearch.Text;
            obj.RoleId = 2;
            obj.IsActive = true;
            obj.IsDeleted = false;
            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();
        }
        if (rbDeleted.Checked == true)
        {
            obj.keywords = txtSearch.Text;
            obj.RoleId = 2;
            obj.IsActive = false;
            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();
        }
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("User.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsManageUser Item = new clsManageUser();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
        }
        else if (e.CommandName == "cmdSend")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);

            clsManageUser ItemUser = new clsManageUser();
            ItemUser = ItemUser.Load(ItemId);
            
            clsFeatureAccess objFeature = new clsFeatureAccess();
            int EmployeeId = ItemUser.EmployeeId; ;
            objFeature = objFeature.LoadEmployeeAssignedFeatures(EmployeeId);
            if (objFeature != null)
            {
                objFeature.SendAssignedFeaturesToEmployee = objFeature.Feature.Replace("<TM>", "").Replace("</TM>", "").Replace("<Module>", "").Replace("</Module>", "").Replace("<T>", "").Replace("</T>", "").Replace("Feature", "li");
            }

            if (ItemUser != null)
            {

                #region "Send Email"

                string strMessage = string.Empty;

                strMessage = "Dear Mr./Ms. " + ItemUser.Fullname + ",<br /><br /><br />";
                strMessage = strMessage + "Greetings from COEPD !!!<br /><br />";
                strMessage = strMessage + "Please find the below COEPD User credentials.<br />";
                strMessage = strMessage + "Login : <a href=https://www.coepd.com/Login.html>https://www.coepd.com</a><br />";
                strMessage = strMessage + "Username : " + ItemUser.Username + "<br />";
                strMessage = strMessage + "Password : " + ItemUser.Pwd + "<br /><br /><br />";

                if (objFeature != null)
                {
                    strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'><strong><em><u>Assigned Features:</u></em></strong></p>";
                    strMessage = strMessage + objFeature.SendAssignedFeaturesToEmployee + "<br/>";

                }
                strMessage = strMessage + "Please check and revert back if any assistance required.<br /><br /><br />";
                strMessage = strMessage + "Thanks & Regards<br />";
                strMessage = strMessage + "COEPD Tech Support<br />";
                strMessage = strMessage + "+91 99635 55322<br />";
                strMessage = strMessage + "+91 40 66612216 Ext 29<br />";
                strMessage = strMessage + "<a href=mailto:NurtureBA@coepd.com>NurtureBA@coepd.com</a><br />";
                strMessage = strMessage + "<a href=https://www.coepd.com>www.coepd.com</a><br />";

                strMessage = strMessage + "<a href=https://www.coepd.com><img src='https://www.coepd.com/img/logo.png'></a><br />";
                string strSubject = "COEPD User Credentials - Mr./Ms. " + ItemUser.Fullname;

                Alerts.SendEmail(ItemUser.Username.Trim(), strSubject, strMessage);


                string script = "window.onload = function(){ alert('Account details sent to registered email.'); window.location = '" + Request.Url.AbsoluteUri + "'; }";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

                #endregion
            }
        }

    }



}