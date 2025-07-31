using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_Employee : System.Web.UI.UserControl
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
        //List<clsFeatureAccess> items = new List<clsFeatureAccess>();
        //clsFeatureAccess obj = new clsFeatureAccess();
        ////obj.EmployeeId = Convert.ToInt16(ddlEmployee.SelectedValue);
        //items = obj.LoadAll(obj);

        //if (items != null)
        //{
        //    string ltlinks = null;

        //    foreach (clsFeatureAccess item in items)
        //    {
        //        ltlinks = "<li><a href=../" + item.PageName + ">" + item.Feature + "</li>";
        //    }
        //    ltmenu.Text = ltlinks;
        //}
    }
}