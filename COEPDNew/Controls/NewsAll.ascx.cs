using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Controls_NewsAll : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    protected void BindData()
    {
        string strNews = string.Empty;

        List<clsNews> Items = new List<clsNews>();
        clsNews News = new clsNews();
        News.CMSId = 0;
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