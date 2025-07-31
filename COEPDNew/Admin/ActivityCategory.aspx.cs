using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Admin_ActivityCategory : System.Web.UI.Page
{
    int ItemId = 0;
    CurrentUser CurentUser = new CurrentUser();
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    clsActivityCategory Item;
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
      Item = new clsActivityCategory();
        if(!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Activity Category";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtActivityCategory.Text = Item.ActivityCategory.ToString();
                    txtDescription.Text = Item.Description.ToString();
                }
                btnreset.Visible = false;
            }
            else
            {
                lblTitle.Text = "Add Activity Category";
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(txtActivityCategory.Text!="")
        {
        SqlConnection Conn = new SqlConnection(Constr);
        Conn.Open();
        string str = "Select COUNT(*) from tblActivityCategory  where ActivityCategory='" + txtActivityCategory.Text + "'";
        SqlCommand cmd = new SqlCommand(str, Conn);
        int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 1)
            {
                ErrorMessage.Text = "Activity Category already exist in the list.";
                ErrorMessage.Visible = true;

                FormMessage.Visible = false;
                //  txtActivityCategory.Text = "";
            }
            else if (count == 1)
            {
                clsActivityCategory obj = new clsActivityCategory();
                if (ItemId > 0)
                {
                    obj.ActivityCategoryId = Convert.ToInt32(ItemId);
                }
                obj.ActivityCategory = Convert.ToString(txtActivityCategory.Text);
                obj.Description = Convert.ToString(txtDescription.Text);
                obj.CreatedBy = CurentUser.CurrentUserId;
                obj.AddUpdate(obj);
                if (ItemId > 0)
                {
                    FormMessage.Text = "Activity Category successfully updated.";
                    FormMessage.Visible = true;
                    btnSubmit.Enabled = false;
                    ErrorMessage.Visible = false;
                }
                //else
                //{
                //    btnSubmit.Enabled = false;
                //    FormMessage.Text = "ActivityCategory successfully saved";
                //    FormMessage.Visible = true;
                //}
            }
            else if (count == 0)
            {
                clsActivityCategory obj = new clsActivityCategory();
                if (ItemId > 0)
                {
                    obj.ActivityCategoryId = Convert.ToInt32(ItemId);
                }
                obj.ActivityCategory = Convert.ToString(txtActivityCategory.Text);
                obj.Description = Convert.ToString(txtDescription.Text);
                obj.CreatedBy = CurentUser.CurrentUserId;
                obj.AddUpdate(obj);
                //if (ItemId > 0)
                //{
                //    FormMessage.Text = "ActivityCategory successfully updated";
                //    FormMessage.Visible = true;
                //    btnSubmit.Enabled = false;
                //}
                //else
                //{
                btnSubmit.Enabled = false;
                FormMessage.Text = "Activity Category successfully created.";
                FormMessage.Visible = true;
                //}
            }
        }
    }
    protected void txtActivityCategory_TextChanged(object sender, EventArgs e)
    {
        SqlConnection Conn = new SqlConnection(Constr);
        Conn.Open();
        string str = "Select COUNT(*) from tblActivityCategory  where ActivityCategory='" + txtActivityCategory.Text + "'";
        SqlCommand cmd = new SqlCommand(str, Conn);
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        if (count > 0)
        {
            ErrorMessage.Text = "Activity Category already exist in the list.";
            ErrorMessage.Visible = true;
            
            FormMessage.Visible = false;
          // txtActivityCategory.Text = "";
        }
        else
        {
            ErrorMessage.Visible = false;
        }
        Conn.Close();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ActivityCategorySearch.aspx");
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txtActivityCategory.Text = "";
        txtDescription.Text = "";
        btnSubmit.Enabled = true;
        FormMessage.Visible = false;
    }
}