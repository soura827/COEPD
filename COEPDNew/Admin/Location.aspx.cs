using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data.SqlClient;
using System.Configuration;


public partial class Location : System.Web.UI.Page
{
    int ItemId = 0;
    CurrentUser CurentUser = new CurrentUser();
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    clsLocation Item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsLocation();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Location";
                Item = Item.Load(ItemId);
                txtLocation.Text = Item.Location;
                txtGoogleReviewLink.Text = Item.GoogleReviewLink;
                txtDescription.Text = Item.LocationDescription;

            }
            else
            {
                lblTitle.Text = "Add New Location";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (txtLocation.Text != "")
        {
            SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();
            string str = "Select COUNT(*) from tblLocation  where Location='" + txtLocation.Text + "'";
            SqlCommand cmd = new SqlCommand(str, Conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 1)
            {
                ErrorMessage.Text = "Location already exist in the list.";
                ErrorMessage.Visible = true;

                FormMessage.Visible = false;
            }
            else if (count == 1)
            {

               clsLocation obj = new clsLocation();
                if (ItemId > 0)
                {
                    obj.LocationId = Convert.ToInt32(ItemId);
                }
                obj.Location = Convert.ToString(txtLocation.Text);
                obj.GoogleReviewLink = txtGoogleReviewLink.Text;
                obj.LocationDescription = Convert.ToString(txtDescription.Text);
                obj.CreatedBy = CurentUser.CurrentUserId;
                obj.AddUpdate(obj);

                if (ItemId > 0)
                {
                    FormMessage.Text = "Location successfully updated.";
                    FormMessage.Visible = true;
                    btnSubmit.Enabled = false;
                    ErrorMessage.Visible = false;

                }
            }
            else if (count == 0)
            {
                clsLocation obj = new clsLocation();
                if (ItemId > 0)
                {
                    obj.LocationId = Convert.ToInt32(ItemId);
                }
                obj.Location = Convert.ToString(txtLocation.Text);
                obj.GoogleReviewLink = txtGoogleReviewLink.Text;
                obj.LocationDescription = Convert.ToString(txtDescription.Text);
                obj.CreatedBy = CurentUser.CurrentUserId;
                obj.AddUpdate(obj);
                btnSubmit.Enabled = false;
                FormMessage.Text = "Location successfully created.";
                FormMessage.Visible = true;
            }
        }

    }    

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("LocationSearch.aspx");
    }

    protected void txtLocation_TextChanged(object sender, EventArgs e)
    {
        SqlConnection Conn = new SqlConnection(Constr);
        Conn.Open();
        string str = "Select COUNT(*) from tblLocation  where Location='" + txtLocation.Text + "'";
        SqlCommand cmd = new SqlCommand(str, Conn);
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        if (count > 0)
        {
            ErrorMessage.Text = "Location already exist in the list.";
            ErrorMessage.Visible = true;

            FormMessage.Visible = false;
        }
        else
        {
            ErrorMessage.Visible = false;
        }
        Conn.Close();

    }
}