using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Web.Script.Serialization;
using BusinessLayer;
public partial class TrainingCalendar : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();

    List<clsCalender> Calenderlist = new List<clsCalender>();

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
            clsCalender obj = new clsCalender();
            obj.IsActive = true;
            Calenderlist = obj.LoadAll(obj);
    }

    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        foreach (var day in Calenderlist)
        {
            string date = day.StartDate.ToString();
            if (Convert.ToDateTime(day.StartDate) == e.Day.Date)
            {
                e.Cell.CssClass = "bg bg-primary";
                Label b = new Label();
                b.CssClass = "heading";
                b.Text = "<br/>" + day.Course + "<br/> " + day.Location + "<br/> (" + day.BatchType + ") <br/>";
                e.Cell.Controls.Add(b);
            }
        }

    }
}