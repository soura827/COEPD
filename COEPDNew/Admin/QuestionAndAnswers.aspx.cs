using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class QuestionAndAnswers : System.Web.UI.Page
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
            BindCategory();
            BindTopic();
            BindQuestion();
        }
        
    }

    protected void BindData()
    {
        clsAnswer Item = new clsAnswer();
        if (ddlCategory.Text != "")
            Item.CategoryId = Convert.ToInt32(ddlCategory.Text);
        if (ddlTopic.Text != "")
            Item.TopicId = Convert.ToInt32(ddlTopic.Text);
        if (ddlQuestion.Text != "")
            Item.QuestionId = Convert.ToInt32(ddlQuestion.Text);
        gv.DataSource = Item.QuestionAndAnswers(Item);
        gv.DataBind();
    }

    protected void btnDownload_Click(object sender, EventArgs e)
    {
        ExportToExcel("QuestionAndAnswers.xls", gv);
    }

    protected void ExportToExcel(string FileName, GridView gv)
    {
        Response.ClearContent();
        Response.AddHeader("content-disposition", "attachemnt; filename= " + FileName);
        Response.ContentType = "application/excel";

        System.IO.StringWriter sw = new System.IO.StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        gv.RenderControl(htw);
        Response.Write(sw.ToString());
        Response.End();
    }

    public override void VerifyRenderingInServerForm(Control control)
    {

    }
    protected void BindCategory()
    {
        ddlCategory.Items.Clear();
        clsCategory obj = new clsCategory();
        ddlCategory.DataSource = obj.LoadAll(obj);
        ddlCategory.DataTextField = "Category";
        ddlCategory.DataValueField = "CategoryId";
        ddlCategory.DataBind();
        ddlCategory.Items.Insert(0, new ListItem("-- Select Category --", "0"));
    }
    protected void BindTopic()
    {
        ddlTopic.Items.Clear();
        if (ddlCategory.SelectedIndex > 0)
        {
            clsTopic obj = new clsTopic();
            obj.CategoryId = Convert.ToInt16(ddlCategory.SelectedValue);
            ddlTopic.DataSource = obj.LoadAll(obj);
            ddlTopic.DataTextField = "Topic";
            ddlTopic.DataValueField = "TopicId";
            ddlTopic.DataBind();
        }
        ddlTopic.Items.Insert(0, new ListItem("-- Select Topic --", "0"));
        ddlQuestion.Items.Clear();
        ddlQuestion.Items.Insert(0, new ListItem("-- Select Question --", "0"));
        gv.DataBind();
    }
    protected void BindQuestion()
    {
        ddlQuestion.Items.Clear();
        if (ddlTopic.SelectedIndex > 0)
        {
            clsAnswer obj = new clsAnswer();
            obj.TopicId = Convert.ToInt16(ddlTopic.SelectedValue);
            ddlQuestion.DataSource = obj.QuestionAndAnswers(obj);
            ddlQuestion.DataTextField = "Question";
            ddlQuestion.DataValueField = "QuestionId";
            ddlQuestion.DataBind();
        }
        ddlQuestion.Items.Insert(0, new ListItem("-- Select Question --", "0"));
        gv.DataBind();
    }

    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindTopic();
        BindData();
        //BindQuestion();
    }

    protected void ddlTopic_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindQuestion();
        BindData();
    }

    protected void ddlQuestion_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}