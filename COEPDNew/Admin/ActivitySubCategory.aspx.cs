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
public partial class Admin_ActivitySubCategory : System.Web.UI.Page
{
    int ItemId = 0;
    CurrentUser CurrentUser = new CurrentUser();
    clsActivitySubCategory Item;
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsActivitySubCategory();
        if(!IsPostBack)
        {
            BindActivityCategory();
            if (ItemId > 0)
            {

                lblTitle.Text = "Edit Activity Subcategory";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlActivityCategory.SelectedValue = Item.ActivityCategoryId.ToString();
                    txtActivitysubCategory.Text = Item.ActivitySubCategory.ToString();
                    txtDescription.Text = Item.Description.ToString();

                }
                btnreset.Visible = false;
            }
            else
            {
                lblTitle.Text = "Add Activity Subcategory";

            }
        }
    }
    protected void BindActivityCategory()
    {
        clsActivityCategory obj = new clsActivityCategory();
        //obj.ActivityCategory = Convert.ToString(txtActivityCategorySearch.Text);
        ddlActivityCategory.DataSource = obj.LoadAll(obj);
        ddlActivityCategory.DataTextField = "ActivityCategory";
        ddlActivityCategory.DataValueField = "ActivityCategoryId"; 
        ddlActivityCategory.DataBind();
        ddlActivityCategory.Items.Insert(0, new ListItem("---Select ActivityCatgory---", ""));
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Item = new clsActivitySubCategory();
         SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();
        string str = "Select COUNT(*) from tblActivitySubCategory  where ActivitysubCategory ='" + txtActivitysubCategory.Text + "' and ActivityCategoryId='" + ddlActivityCategory.SelectedValue + "'";
        SqlCommand cmd = new SqlCommand(str, Conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 1)
            {
                ErrorMessage.Text = "The Activity Subcategory already exist in the List.";
                ErrorMessage.Visible = true;
                FormMessage.Visible = false;
            }
            else if(count==1)
            {
                if (ItemId > 0)
                {
                    Item.ActivitySubCategoryId = Convert.ToInt32(ItemId);
                }
                Item.ActivityCategoryId = Convert.ToInt32(ddlActivityCategory.SelectedValue);
                Item.ActivitySubCategory = Convert.ToString(txtActivitysubCategory.Text);
                Item.Description = Convert.ToString(txtDescription.Text);
                Item.CreatedBy = CurrentUser.CurrentUserId;
                Item.AddUpdate(Item);
                txtActivitysubCategory.Text = "";
                txtDescription.Text = "";
                ddlActivityCategory.SelectedIndex = -1;
                if (ItemId > 0)
                {
                    FormMessage.Text = "Activity Subcategory Successfully Updated.";
                    FormMessage.Visible = true;
                    btnSubmit.Enabled = false;
                }
                //else
                //{
                //    btnSubmit.Enabled = false;
                //    FormMessage.Text = "ActivitySubCategory Successfully Created";
                //    FormMessage.Visible = true;

                //}
            }
        else if(count == 0)
            {
                if (ItemId > 0)
                {
                    Item.ActivitySubCategoryId = Convert.ToInt32(ItemId);
                }
                Item.ActivityCategoryId = Convert.ToInt32(ddlActivityCategory.SelectedValue);
                Item.ActivitySubCategory = Convert.ToString(txtActivitysubCategory.Text);
                Item.Description = Convert.ToString(txtDescription.Text);
                Item.CreatedBy = CurrentUser.CurrentUserId;
                Item.AddUpdate(Item);
                txtActivitysubCategory.Text = "";
                txtDescription.Text = "";
                ddlActivityCategory.SelectedIndex = -1;  
                    btnSubmit.Enabled = false;
                    FormMessage.Text = "Activity Subcategory Successfully Created.";
                    FormMessage.Visible = true;              
            }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ActivitySubCategorySearch.aspx");
    }
    protected void txtActivitysubCategory_TextChanged(object sender, EventArgs e)
    {
        SqlConnection Conn = new SqlConnection(Constr);
        Conn.Open();
        string str = "Select COUNT(*) from tblActivitySubCategory  where ActivitysubCategory ='" + txtActivitysubCategory.Text + "' and ActivityCategoryId='" + ddlActivityCategory.SelectedValue + "'";
        SqlCommand cmd = new SqlCommand(str, Conn);
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        if (count > 0)
        {
            ErrorMessage.Text = "The Activity Subcategory already exist in the List.";
            ErrorMessage.Visible = true;      
            FormMessage.Visible = false;
        }
        else
        {
            ErrorMessage.Visible = false;
        }
        Conn.Close();
    }
    //protected void txtActivityCategorySearch_TextChanged(object sender, EventArgs e)
    //{
    //    if(txtActivityCategorySearch.Text!=null)
    //    {
    //        BindActivityCategory();
    //    }
    //   else
    //    {
    //        ErrorMessage.Text = "Please Enter for Search fields";
    //        ErrorMessage.Visible = true;
    //    }
    //}
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txtActivitysubCategory.Text = "";
        txtDescription.Text = "";
        btnSubmit.Enabled = true;
        ddlActivityCategory.SelectedIndex = -1;
        FormMessage.Visible = false;
    }
}