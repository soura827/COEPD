using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_HRMockQuestionsSearch : System.Web.UI.Page
{
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

    private void BindData()
    {
        clsHRMockQuestions obj = new clsHRMockQuestions();
        if (txtQuestions.Text != "")
            obj.QuestionName = txtQuestions.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }

    protected void txtQuestions_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //if (e.CommandName == "cmdEdit")
        //{
        //    Response.Redirect("HRMockQuestions.aspx?ItemId=" + e.CommandArgument);
        //}
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("HRMockQuestions.aspx");
    }
}

