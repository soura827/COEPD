using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class CloseExam : System.Web.UI.Page
{
    int ItemId = 0;
  //  clsUserExam item1 = new clsUserExam();
    //CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        clsTopic item = new clsTopic();
        item = item.Load(ItemId);
        lblcategory.Text = Convert.ToString(item.Category);
      
        lblTopic.Text = Convert.ToString(item.Topic);
        if (!IsPostBack)
        {
            BindData();
        }
    }
    protected void BindData()
    {
        clsUserExam obj = new clsUserExam();
        obj.ExamId = Convert.ToInt32(Session["ExamId"]);
        gv.DataSource = obj.LoadAll_History(obj);
        gv.DataBind();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserExamMaster.aspx");
    }
}