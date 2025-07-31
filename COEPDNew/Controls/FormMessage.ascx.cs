using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_FormMessage : System.Web.UI.UserControl
{
    public string Text
    {
        get
        {
            return this.lblFormMessage.Text;
        }
        set
        {
            this.lblFormMessage.Text = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
