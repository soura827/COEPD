using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_AssignMentorToInterviewSupport : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int itemId = 0;
    clsInterviewSupport item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        itemId = Convert.ToInt32(Request.QueryString["itemId"]);
        item= new clsInterviewSupport();

        if (itemId > 0)
        {
            if (!IsPostBack)
            {
                //item = item.Load(itemId);
                //if (item != null)
                //{
                //    if (Item.ProfileOwnerId > 0)
                //    {
                //        clsEmployee objEmployee = new clsEmployee();
                //        objEmployee.EmployeeId = Item.ProfileOwnerId;
                //        objEmployee = objEmployee.Load(Item.ProfileOwnerId);
                //        if (objEmployee != null)
                //        {
                //            if (objEmployee.IsActive == true)
                //                ddlProfileOwner.SelectedValue = Convert.ToString(Item.ProfileOwnerId);
                //        }
                //    }
                //}
                BindMentor();
            }
        }
        else
        {
            Response.Redirect("InterviewSupportSearch.aspx");
        }
    }
    protected void BindMentor()
    {
        clsEmployee obj = new clsEmployee();
        obj.DesignationId = 3;
        ddlMentor.DataSource = obj.LoadAll(obj);
        ddlMentor.DataTextField = "Employee";
        ddlMentor.DataValueField = "EmployeeId";
        ddlMentor.DataBind();
        ddlMentor.Items.Insert(0, new ListItem("--Select Mentor--", "0"));
    }

    protected void btnAssignMentor_Click(object sender, EventArgs e)
    {
        if (itemId > 0)
        {
            item.InterviewSupportId = Convert.ToInt32(itemId);
        }
        item.IsMentorAssigned = true;
        item.MentorId = Convert.ToInt32(ddlMentor.SelectedValue);
        item.MentorAssignedBy = CurrentUser.CurrentUserId;
        item.AddMentor(item);
        Response.Redirect("InterviewSupportSearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("InterviewSupportSearch.aspx");
    }
}