//This Codebehind page is used for Details of BindCategory, BindUsers and BindAssignedCategories. 
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ExamCategoryAssignmentSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
            if(ItemId>0)
            {
                BindParticipants();
                ddlParticipant.SelectedValue = Convert.ToString(ItemId);
                lblParticipant.Visible = false;
                txtSearch.Visible = false;
                btnSearch.Visible = false;
            }
            BindCategory();
        BindAssignedCategories();
        BindUnAssignedCategories();
    }

    //This method is used to bind IsExamPermit available Participants only
    protected void BindParticipants()
    {
        ddlParticipant.Items.Clear();
        clsParticipant obj = new clsParticipant();
        obj.IsExamPermit = true;
        obj.keywords = txtSearch.Text;
        if(ItemId>0)
            obj.ParticipantId = ItemId;
        ddlParticipant.DataSource=obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Participant";
        ddlParticipant.DataValueField = "ParticipantId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("--Select--", "0"));
    }
    //This metod is used to Bind All  Exam Categories.
    protected void BindCategory()
    {
        clsCategory obj = new clsCategory();      
        gvUser.DataSource = obj.LoadAll(obj);
        gvUser.DataBind();      
    }
    //This metod is used to bind  ExamCategories  Based on Selected ParticipantId in LeftSide(gvUser) GridView which are not assigned.
    protected void BindUnAssignedCategories()
    {
        if (ddlParticipant.SelectedIndex > 0)
        {
            clsExamCategoryAssignment obj = new clsExamCategoryAssignment();
            obj.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
            gvUser.DataSource = obj.LoadAllAssign(obj);
            gvUser.DataBind();
        }
        else
        {
            gv.Visible = false;
            gvUser.Visible = false;
        }
    }
    //This Method is used for Bind ExamCategories Based on Selected ParticipantId in RightSide(gv) GridView which are already assigned.
    protected void BindAssignedCategories()
    {
       if(ddlParticipant.SelectedIndex>0)
       {
            clsExamCategoryAssignment obj = new clsExamCategoryAssignment();
            obj.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);          
            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();
       }
    }
    //This Row Command is used to assign the ExamCategory to Participant.
    protected void gvUser_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdAdd")
        {
            if (ddlParticipant.SelectedIndex > 0)
            {
                clsExamCategoryAssignment Item = new clsExamCategoryAssignment();
                Item.ParticipantId = Convert.ToInt16(ddlParticipant.SelectedValue);
                Item.CategoryId = Convert.ToInt16(e.CommandArgument);
                Item.CreatedBy = CurrentUser.CurrentUserId;
                Item.AddUpdate(Item);
                BindUnAssignedCategories();
                BindAssignedCategories();
                FormMessage.Text = "Category successfully saved";
                FormMessage.Visible = true;
                ErrorMessage.Visible = false;
            }
            else
            {
                ErrorMessage.Text = "Please Select Participant";
                ErrorMessage.Visible = true;
            }
        }
    }
    //This Row Command is used to un-assign the ExamCategory to Participant.
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdRemove")
        {
            if (ddlParticipant.SelectedIndex > 0)
            {
                clsExamCategoryAssignment Item = new clsExamCategoryAssignment();
                int ItemId = Convert.ToInt16(e.CommandArgument);
                Item.ParticipantId = Convert.ToInt16(ddlParticipant.SelectedValue);
                Item.CategoryId = ItemId;
                Item.Remove(Item);
                BindUnAssignedCategories();
                BindAssignedCategories();
                gv.Visible = true;
                gvUser.Visible = true;
                FormMessage.Visible = false;
                ErrorMessage.Text = "Category successfully removed";
                ErrorMessage.Visible = true;
            }
            else
            {
                ErrorMessage.Text = "Please Select Participant";
                ErrorMessage.Visible = true;
            }
        }        
    }
    //protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    FormMessage.Visible = false;
    //    if(ddlCategory.SelectedIndex>0)
    //    {
    //        BindUsers();
    //        BindAssignedCategories();
    //        gv.Visible = true;
    //        gvUser.Visible = true;
    //    }       
    //}

    //This method is used to Redirect the Participants Page
    protected void btnGoToParticipant_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantSearch.aspx");
    }
    //This method is used to search the Participants based on keywords and display in dropdownlist.
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        ddlParticipant.Items.Clear();
        ErrorMessage.Visible = false;
        if (txtSearch.Text!="")
        {
            BindParticipants();
        }
        else
        {
            FormMessage.Visible = false;
            ErrorMessage.Text = "Please enter Participant Name or Mobile No or Email or ReferenceNo";
            ErrorMessage.Visible = true;
        }
    }
    // This event will fired when selecting the Participant in GridView and Display Not Assigned categories in Lefside GridView ,Assigned Categories in Right Side GridView
    protected void ddlParticipant_SelectedIndexChanged(object sender, EventArgs e)
    {
        FormMessage.Visible = false;
        ErrorMessage.Visible = false;      
        if(ddlParticipant.SelectedIndex>0)
        {
            BindAssignedCategories();
            BindUnAssignedCategories();
            gv.Visible = true;
            gvUser.Visible = true;
        }
        else
        {
            txtSearch.Text = "";
            gv.Visible = false;
            gvUser.Visible = false;
        }
    }
}