using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data.SqlClient;
using System.Configuration;
public partial class Branch : System.Web.UI.Page
{
    int ItemId = 0;
    CurrentUser CurrentUser = new CurrentUser();
    clsBranch Item;
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsBranch();
        if (!IsPostBack)
        {
            BindLocation();
            if (ItemId > 0)
            {

                lblTitle.Text = "Edit Branch Name";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlLocation.SelectedValue = Item.LocationId.ToString();
                    txtCode.Text = Item.Code.ToString();
                    txtBranch.Text = Item.Branch.ToString();
                    txtAddress1.Text = Item.Address1.ToString();
                    txtAddress2.Text = Item.Address2.ToString();
                    txtCity.Text = Item.City.ToString();
                    txtStateName.Text = Item.StateName.ToString();
                    txtCountry.Text = Item.Country.ToString();
                    txtZipcode.Text = Item.Zipcode.ToString();
                    txtMobile.Text = Item.Mobile.ToString();
                    txtPhone.Text = Item.Phone.ToString();
                    txtEmail.Text = Item.Email.ToString();
                    txtLangitude.Text = Item.Langitude.ToString();
                    txtLatitude.Text = Item.Latitude.ToString();
                }
            }
            else
            {
                lblTitle.Text = "Add Branch Name";
            }
        }
    }
    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("--Select Location--", ""));
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Item = new clsBranch();
        SqlConnection Conn = new SqlConnection(Constr);
        Conn.Open();
        string str = "Select COUNT(*) from tblBranch  where Branch ='" + txtBranch.Text + "' and LocationId='" + ddlLocation.SelectedValue + "'";
        SqlCommand cmd = new SqlCommand(str, Conn);
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        if (count > 1)
        {
            ErrorMessage.Text = "The Branch Name already exist in the List.";
            ErrorMessage.Visible = true;
            FormMessage.Visible = false;
        }
        else if (count == 1)
        {
            if (ItemId > 0)
            {
                Item.BranchId = Convert.ToInt32(ItemId);
            }
            Item.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
            Item.Code = Convert.ToString(txtCode.Text);
            Item.Branch = Convert.ToString(txtBranch.Text);
            Item.Address1 = Convert.ToString(txtAddress1.Text);
            Item.Address2 = Convert.ToString(txtAddress2.Text);
            Item.City = Convert.ToString(txtCity.Text);
            Item.StateName = Convert.ToString(txtStateName.Text);
            Item.Country = Convert.ToString(txtCountry.Text);
            Item.Zipcode = Convert.ToString(txtZipcode.Text);
            Item.Mobile = Convert.ToString(txtMobile.Text);
            Item.Phone = Convert.ToString(txtPhone.Text);
            Item.Email = Convert.ToString(txtEmail.Text);
            Item.Langitude = Convert.ToString(txtLangitude.Text);
            Item.Latitude = Convert.ToString(txtLatitude.Text);
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.AddUpdate(Item);
            txtCode.Text = "";
            txtBranch.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            txtStateName.Text = "";
            txtCountry.Text = "";
            txtZipcode.Text = "";
            txtMobile.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtLangitude.Text = "";
            txtLatitude.Text = "";
            ddlLocation.SelectedIndex = -1;
            if (ItemId > 0)
            {
                FormMessage.Text = "Branch Name Successfully Updated.";
                FormMessage.Visible = true;
                btnSubmit.Enabled = false;
            }
        }
        else if (count == 0)
        {
            if (ItemId > 0)
            {
                Item.BranchId = Convert.ToInt32(ItemId);
            }
            Item.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
            Item.Code = Convert.ToString(txtCode.Text);
            Item.Branch = Convert.ToString(txtBranch.Text);
            Item.Address1 = Convert.ToString(txtAddress1.Text);
            Item.Address2 = Convert.ToString(txtAddress2.Text);
            Item.City = Convert.ToString(txtCity.Text);
            Item.StateName = Convert.ToString(txtStateName.Text);
            Item.Country = Convert.ToString(txtCountry.Text);
            Item.Zipcode = Convert.ToString(txtZipcode.Text);
            Item.Mobile = Convert.ToString(txtMobile.Text);
            Item.Phone = Convert.ToString(txtPhone.Text);
            Item.Email = Convert.ToString(txtEmail.Text);
            Item.Langitude = Convert.ToString(txtLangitude.Text);
            Item.Latitude = Convert.ToString(txtLatitude.Text);
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.AddUpdate(Item);
            txtCode.Text = "";
            txtBranch.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            txtStateName.Text = "";
            txtCountry.Text = "";
            txtZipcode.Text = "";
            txtMobile.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtLangitude.Text = "";
            txtLatitude.Text = "";
            ddlLocation.SelectedIndex = -1;
            btnSubmit.Enabled = false;
            FormMessage.Text = "Branch Name Successfully Created.";
            FormMessage.Visible = true;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("BranchSearch.aspx");
    }
    protected void txtBranch_TextChanged(object sender, EventArgs e)
    {
        SqlConnection Conn = new SqlConnection(Constr);
        Conn.Open();
        string str = "Select COUNT(*) from tblBranch  where Branch ='" + txtBranch.Text + "' and LocationId='" + ddlLocation.SelectedValue + "'";
        SqlCommand cmd = new SqlCommand(str, Conn);
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        if (count > 0)
        {
            ErrorMessage.Text = "The Branch Name already exist in the List.";
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