using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class business_analyst_training_testimonials : System.Web.UI.Page
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
        clsTestimonial obj = new clsTestimonial();
        obj.IsFeatured = true;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
}