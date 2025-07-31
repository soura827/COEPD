using BusinessLayer;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Admin_Activity : System.Web.UI.Page
{
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    int ItemId = 0;
    clsActivity Item;
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            BindActivityCategory();
            Item = new clsActivity();
            if (ItemId > 0)
            {

                lblTitle.Text = "Edit Activity";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlActivityCategory.SelectedValue = Item.ActivityCategoryId.ToString();
                    BindActivitySubCategory();
                    ddlActivitySubCategory.Text = Item.ActivitySubCategoryId.ToString();
                    txtActivity.Text = Item.Activity.ToString();
                    // ddlmodeofselection.SelectedValue = Item.ActivityModeofSelection.ToString();
                    txtDescription.Text = Item.Description.ToString();

                }
                btnreset.Visible = false;
            }

            else
            {
                lblTitle.Text = "Add Activity";

            }
        }
    }

    protected void BindActivityCategory()
    {
        clsActivityCategory obj = new clsActivityCategory();
        ddlActivityCategory.DataSource = obj.LoadAll(obj);
        ddlActivityCategory.DataTextField = "ActivityCategory";
        ddlActivityCategory.DataValueField = "ActivityCategoryId";
        ddlActivityCategory.DataBind();
        ddlActivityCategory.Items.Insert(0, new ListItem("---Select Activity Category---", ""));
    }
    protected void BindActivitySubCategory()
    {
        ddlActivitySubCategory.Items.Clear();
        if (ddlActivityCategory.SelectedValue != "")
        {
            clsActivitySubCategory obj = new clsActivitySubCategory();
            obj.ActivityCategoryId = Convert.ToInt32(ddlActivityCategory.SelectedValue);
            ddlActivitySubCategory.DataSource = obj.LoadAll(obj);
            ddlActivitySubCategory.DataTextField = "ActivitySubCategory";
            ddlActivitySubCategory.DataValueField = "ActivitySubCategoryId";
            ddlActivitySubCategory.DataBind();
            ddlActivitySubCategory.Items.Insert(0, new ListItem("---Select Activity Subcategory---", ""));
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Item = new clsActivity();
        SqlConnection Conn = new SqlConnection(Constr);
        Conn.Open();
        string str = "Select COUNT(*) from tblActivity  where Activity='" + txtActivity.Text + "'and ActivityCategoryId='" + ddlActivityCategory.SelectedValue + "' and ActivitySubCategoryId='" + ddlActivitySubCategory.SelectedValue + "'";
        SqlCommand cmd = new SqlCommand(str, Conn);
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        if (count > 0)
        {
            ErrorMessage.Text = "The Activity already exist in the List ";
            ErrorMessage.Visible = true;
            FormMessage.Visible = false;
        }
        else if (count == 1)
        {
            if (ItemId > 0)
            {
                Item.ActivityId = Convert.ToInt32(ItemId);
            }
            Item.ActivityCategoryId = Convert.ToInt32(ddlActivityCategory.SelectedValue);
            Item.ActivitySubCategoryId = Convert.ToInt32(ddlActivitySubCategory.SelectedValue);
            Item.Activity = Convert.ToString(txtActivity.Text);
            //Item.ActivityModeofSelection = Convert.ToInt32(ddlmodeofselection.SelectedValue);
            Item.Description = Convert.ToString(txtDescription.Text);
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.AddUpdate(Item);
            txtActivity.Text = "";
            txtDescription.Text = "";
            ddlActivityCategory.SelectedIndex = -1;
            ddlActivitySubCategory.SelectedIndex = -1;
            //ddlmodeofselection.SelectedIndex = -1;
            if (ItemId > 0)
            {
                FormMessage.Text = "Activity Successfully Updated.";
                FormMessage.Visible = true;
                btnSubmit.Enabled = false;
            }
            //else
            //{
            //    btnSubmit.Enabled = false;
            //    FormMessage.Text = "Activity Successfully Created.";
            //    FormMessage.Visible = true;
            //}
        }
        else if (count == 0)
        {
            if (ItemId > 0)
            {
                Item.ActivityId = Convert.ToInt32(ItemId);
            }
            Item.ActivityCategoryId = Convert.ToInt32(ddlActivityCategory.SelectedValue);
            Item.ActivitySubCategoryId = Convert.ToInt32(ddlActivitySubCategory.SelectedValue);
            Item.Activity = Convert.ToString(txtActivity.Text);
            //Item.ActivityModeofSelection = Convert.ToInt32(ddlmodeofselection.SelectedValue);
            Item.Description = Convert.ToString(txtDescription.Text);
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.AddUpdate(Item);
            txtActivity.Text = "";
            txtDescription.Text = "";
            ddlActivityCategory.SelectedIndex = -1;
            ddlActivitySubCategory.SelectedIndex = -1;
            //ddlmodeofselection.SelectedIndex = -1;
            //if (ItemId > 0)
            //{
            //    FormMessage.Text = "Activity Successfully Updated";
            //    FormMessage.Visible = true;
            //    btnSubmit.Enabled = false;
            //}
            btnSubmit.Enabled = false;
            FormMessage.Text = "Activity Successfully Created";
            FormMessage.Visible = true;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ActivitySearch.aspx");
    }
    protected void txtActivity_TextChanged(object sender, EventArgs e)
    {
        SqlConnection Conn = new SqlConnection(Constr);
        Conn.Open();
        string str = "Select COUNT(*) from tblActivity  where Activity='" + txtActivity.Text + "'and ActivityCategoryId='" + ddlActivityCategory.SelectedValue + "' and ActivitySubCategoryId='" + ddlActivitySubCategory.SelectedValue + "'";
        SqlCommand cmd = new SqlCommand(str, Conn);
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        if (count > 0)
        {
            ErrorMessage.Text = "The Activity already exist in the List. ";
            ErrorMessage.Visible = true;

            FormMessage.Visible = false;

        }
        else
        {
            ErrorMessage.Visible = false;

        }
        Conn.Close();
    }

    protected void ddlActivityCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlActivityCategory.SelectedValue != null)
        {
            BindActivitySubCategory();
        }
    }
    protected void btreset_Click(object sender, EventArgs e)
    {
        txtActivity.Text = "";
        txtDescription.Text = "";
        btnSubmit.Enabled = true;
        FormMessage.Visible = false;
        ddlActivitySubCategory.SelectedIndex = -1;
        ddlActivityCategory.SelectedIndex = -1;
    }
}