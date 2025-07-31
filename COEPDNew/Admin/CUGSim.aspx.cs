using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Configuration;
using System.Data.SqlClient;

public partial class Admin_CUGSim : System.Web.UI.Page
{
    int ItemId = 0;
    DateTime ActivationDate;
    CurrentUser CurrentUser = new CurrentUser();
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    clsCUGSim Item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsCUGSim();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit CUG Sim";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtSimNumber.Text = Item.SimNumber.ToString();
                    txtMobile.Text = Item.Mobile.ToString();
                    if(Item.IsActivated ==true)
                    {
                        chkIsActivated.Checked = true;
                        txtActivationDate.Visible = true;
                        lblActivationDate.Visible = true;
                    }
                    else
                    {
                        chkIsActivated.Checked = false;
                    }
                    if(Item.ActivationDate !=null)
                    {
                        ActivationDate = Convert.ToDateTime(Item.ActivationDate);
                        txtActivationDate.Text =ActivationDate.ToString("dd/MM/yyyy");
                    }
                    
                    txtTarifPlan.Text = Item.TarifPlan.ToString();
                }

            }
            else
            {
                lblTitle.Text = "Add CUG Sim";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsCUGSim obj = new clsCUGSim();
        if (ItemId > 0)
        {
            obj.CUGSimId = Convert.ToInt32(ItemId);
        }
        obj.SimNumber = Convert.ToString(txtSimNumber.Text);
        obj.Mobile = Convert.ToString(txtMobile.Text);
        if (chkIsActivated.Checked == true)
        {
            obj.IsActivated = true;
        }
        else
        {
            obj.IsActivated = false;
        }
        if (txtActivationDate.Text != "")
        {
            DateTime Date = DateTime.ParseExact(txtActivationDate.Text, "dd/MM/yyyy", null);
            obj.ActivationDate = Date;

        }
        obj.TarifPlan = Convert.ToString(txtTarifPlan.Text);
        obj.CreatedBy = CurrentUser.CurrentUserId;
        obj.AddUpdate(obj);
        Response.Redirect("CUGSimSearch.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CUGSimSearch.aspx");
    }

    protected void chkIsActivated_CheckedChanged(object sender, EventArgs e)
    {
        if (chkIsActivated.Checked == true)
        {
            txtActivationDate.Visible = true;
            lblActivationDate.Visible = true;
        }
            
        else
        {
            txtActivationDate.Visible = false;
            lblActivationDate.Visible = false;
        }
            
    }
}