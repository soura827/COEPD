using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Trainer_profile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        clsTrainerProfile obj = new clsTrainerProfile();
        obj.IsFeatured = true;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }

}