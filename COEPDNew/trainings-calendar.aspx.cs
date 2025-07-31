using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class trainings_calendar : System.Web.UI.Page
{
    clsCalender obj = new clsCalender();
    List<clsCalender> Calenderlist = new List<clsCalender>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }
        BindCalendar();
    }


    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        foreach (var day in Calenderlist)
        {
            if(day.StartDate.Equals(e.Day.Date))
            {
                e.Cell.CssClass = "bg bg-primary";

                HyperLink lnkEvent = new HyperLink();
                lnkEvent.Text = "<h6>" + day.Course + " <br/>" + day.Location + "<br/> (" + day.BatchType + ") <br/></h6>";
                lnkEvent.Font.Size = FontUnit.Parse("10");
                lnkEvent.Font.Bold = true;
                lnkEvent.Font.Name = "Arial";
                lnkEvent.Target = "Blank";
                lnkEvent.NavigateUrl = "https://www.coepd.com/coepd-payments.aspx";
                lnkEvent.ForeColor = System.Drawing.Color.White;
                lnkEvent.Font.Underline = false;
                lnkEvent.Visible = true;

                e.Cell.Controls.Add(lnkEvent);

            }
        }
    }

    protected void BindCalendar()
    {
        obj.IsActive = true;
        if(obj.LoadAll(obj) != null)
        {
            Calenderlist = obj.LoadAll(obj);
        }
    }

    protected void ddlCourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindCalendar();
    }
}