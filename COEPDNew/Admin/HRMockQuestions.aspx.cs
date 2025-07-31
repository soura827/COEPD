using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_HRMockQuestions : System.Web.UI.Page
{
    int ItemId = 0;
    CurrentUser CurrentUser = new CurrentUser();
    clsHRMockQuestions Item = new clsHRMockQuestions();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            //LoadRemarks();
            //LoadRating();

            if (ItemId > 0)
            {
                lblTitle.Text = "view the Questions";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    //txtQuestionName.Enabled = false;
                    //txtAnswer.Enabled = false;

                    txtQuestionName.Text = Item.QuestionName.ToString();
                   // txtAnswer.Text = Item.Answer.ToString();
                    //ddlRating.Visible = true;
                    //ddlRating.Text=Item.Rating;
                    //ddlRemarks.Text = Item.Remarks;
                    //ddlRemarks.Visible = true;
                    //ddlRemarks.SelectedValue = Convert.ToString(Item.RemarksId);
                    //ddlRating.SelectedValue = Convert.ToString(Item.RatingId);
                    
                }
            }
            else
            {
                lblTitle.Text = "Add HRMockQuestions";
            }
        }
    }

    //protected void LoadRating()
    //{
    //    clsHRMockQuestions obj = new clsHRMockQuestions();
    //    ddlRating.DataSource = obj.LoadAllRating(obj);
    //    ddlRating.DataTextField = "Rating";
    //    ddlRating.DataValueField = "RatingId";
    //    ddlRating.DataBind();
    //    ddlRating.Items.Insert(0, new ListItem("-- Rating --", ""));
    //}
    //protected void LoadRemarks()
    //{
    //    clsHRMockQuestions obj = new clsHRMockQuestions();
    //    ddlRemarks.DataSource = obj.LoadAllRemarks(obj);
    //    ddlRemarks.DataTextField = "Remarks";
    //    ddlRemarks.DataValueField = "RemarksId";
    //    ddlRemarks.DataBind();
    //    ddlRemarks.Items.Insert(0, new ListItem("-- Remarks --", ""));
    //}

   

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        Item.HRMockQuestionId = Convert.ToInt32(ItemId);
        Item.QuestionName = txtQuestionName.Text;
       // Item.Answer = txtAnswer.Text;
        //Item.RemarksId = Convert.ToInt32(ddlRemarks.SelectedValue);
        //Item.RatingId=Convert.ToInt32(ddlRating.SelectedValue);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        txtQuestionName.Text = "";
       // txtAnswer.Text = "";
        //ddlRemarks.Text = "";
        //ddlRating.Text = "";

        btnSubmit.Enabled = false;
        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);

        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("HRMockQuestionsSearch.aspx");
    }

   }

