using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Public : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            // BindData();
            BindStatistics();
        }
    }
    protected void BindStatistics()
    {
        //clsNews obj = new clsNews();
        //obj.IsActive = true;
        //dl.DataSource = obj.LoadAll(obj);
        //dl.DataBind();

        string strStatistics = string.Empty;
        List<clsStatistics> Items = new List<clsStatistics>();
        clsStatistics Statistics = new clsStatistics();
        Statistics.IsActive = true;
        Items = Statistics.LoadAll(Statistics);

        if (Items != null)
        {
            foreach (clsStatistics item in Items)
            {

                strStatistics = "Our Endeavours " + item.BatchesCompleted + " Batches |&nbsp;" + item.StudentsTrained + " Participants |&nbsp;" + item.Placements + " Placements |&nbsp;" + item.Corporates + " Corporates |&nbsp;" + item.BSchools + " B-Schools";
            }

            strStatistics = strStatistics.Replace("<p>", "");
            strStatistics = strStatistics.Replace("</p>", "");
            lblStatistics.Text = strStatistics;

        }
    }
    //protected void BindData()
    //{
    //clsNews obj = new clsNews();
    //obj.IsActive = true;
    //dl.DataSource = obj.LoadAll(obj);
    //dl.DataBind();

    //}
}
