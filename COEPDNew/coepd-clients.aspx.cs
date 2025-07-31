using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class coepd_clients : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
            BindTotalCOEPDClients();
        }
    }
    protected void BindTotalCOEPDClients()
    {
        clsCOEPDClients obj = new clsCOEPDClients();
        obj = obj.LoadTotalCOEPDClients(obj);
        lblTotalCOEPDClients.Text = obj.TotalCOEPDClients.ToString();

    }
    protected void BindData()
    {
        clsCOEPDClients obj = new clsCOEPDClients();
        obj.IsFeatured = true;
        dl.DataSource = obj.LoadAllClients(obj);
        dl.DataBind();
    }
}