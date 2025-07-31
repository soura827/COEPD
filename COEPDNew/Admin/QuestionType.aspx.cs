using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class QuestionType : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();

    clsQuestionType Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsQuestionType();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {

                lblTitle.Text = "Edit QuestionType";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtQuestionType.Text = Item.QuestionType;

                }
            }
            else
            {
                lblTitle.Text = "Add QuestionType";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (ItemId > 0)
        {
            Item.QuestionTypeId = Convert.ToInt16(ItemId);
        }

        Item.QuestionType = Convert.ToString(txtQuestionType.Text);
        Item.CreatedBy = 1;
        Item.AddUpdate(Item);
        if (ItemId > 0)
        {
            FormMessage.Text = "Question Type successfully updated";
            FormMessage.Visible = true;
        }
        else
        {
            btnSubmit.Enabled = false;
            FormMessage.Text = "Question Type successfully saved";
            FormMessage.Visible = true;
        }

    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("QuestionType.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("QuestionTypeSearch.aspx");
    }
}