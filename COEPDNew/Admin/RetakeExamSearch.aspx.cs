using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class RetakeExamSearch : System.Web.UI.Page
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

    protected void BindData()
    {
        clsRetakeExam obj = new clsRetakeExam();
        obj.keywords = txtSearch.Text;
        obj.RetakeStatusId = 0;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();

    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdAccept")
        {
            clsExam Item = new clsExam();
            int ItemId = Convert.ToInt32(e.CommandArgument);
            Item.Remove(ItemId);
            clsUserExam UserExam = new clsUserExam();
            UserExam.RemoveExam(ItemId);
            clsRetakeExam obj = new clsRetakeExam();
            GridViewRow gvrow = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
            obj.RetakeExamID = Convert.ToInt32(gv.DataKeys[gvrow.RowIndex].Value);
            obj.RetakeStatusId = 1;
            obj.ModifiedBy = CurrentUser.CurrentUserId;
            obj.UpdateStatus(obj);
            FormMessage.Text = "Request approved successfully";
            FormMessage.Visible = true;
            BindData();
        }
        if (e.CommandName == "cmdReject")
        {
            hdnRetakeExamId.Value = Convert.ToString(e.CommandArgument);
            Popup(true);
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        clsRetakeExam RetakeExam = new clsRetakeExam();
        RetakeExam.UserComments = txtComments.Text;
        RetakeExam.ModifiedBy = CurrentUser.CurrentUserId;
        RetakeExam.RetakeExamID = Convert.ToInt32(hdnRetakeExamId.Value);
        RetakeExam.RetakeStatusId = 2;
        RetakeExam.UpdateStatus(RetakeExam);
        ErrorMessage.Text = "Request rejected Successfully";
        ErrorMessage.Visible = true;
        BindData();
        Popup(false);
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Popup(false);
    }

    void Popup(bool isDisplay)
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        if (isDisplay)
        {
            builder.Append("<script language=JavaScript> ShowPopup(); </script>\n");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "ShowPopup", builder.ToString());
        }
        else
        {
            builder.Append("<script language=JavaScript> HidePopup(); </script>\n");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "HidePopup", builder.ToString());
        }
    }
}