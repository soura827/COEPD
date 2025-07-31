using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class business_analyst_training_in_pune : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
            BindNewsScroll();
        }
    }
    protected void BindData()
    {
        clsNews obj = new clsNews();
        obj.CMSId = 3;
        dl.DataSource = obj.LoadAll(obj);
        dl.DataBind();
        if (dl.Items.Count == 0)
        {
            divTraningNews.Visible = false;
        }
    }
    protected void BindNewsScroll()
    {
        string strNews = string.Empty;

        List<clsNews> Items = new List<clsNews>();
        clsNews News = new clsNews();
        News.CMSId = 3;
        News.IsFeatured = true;
        News.IsActive = true;
        Items = News.LoadAll(News);

        if (Items != null)
        {
            foreach (clsNews item in Items)
            {
                strNews = strNews + "&nbsp;" + item.NewsDescription + "::&nbsp;&nbsp;";
            }

            strNews = strNews.Replace("<p>", "");
            strNews = strNews.Replace("</p>", "");
            lblNews.Text = strNews;
        }
    }
}