using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data.SqlClient;
using System.Configuration;
public partial class Admin_BranchEmployeeNews : System.Web.UI.Page
{
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    int ItemId = 0;
    clsBranchEmployeeNews Item;
    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        if (!IsPostBack)
        {
            BindLocation();
            Item = new clsBranchEmployeeNews();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Branch Employee News";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlLocation.SelectedValue = Item.LocationId.ToString();
                    BindBranch();
                    ddlBranch.SelectedValue = Item.BranchId.ToString();
                    clsBranch bra = new clsBranch();
                    bra = bra.Load(Item.BranchId);
                    clsLocation loc = new clsLocation();
                    loc = loc.Load(bra.LocationId);
                    ddlLocation.Items.Clear();
                    ddlBranch.Items.Clear();
                    ddlLocation.Items.Insert(0, new ListItem(loc.Location.ToString(), loc.LocationId.ToString()));
                    ddlBranch.Items.Insert(0, new ListItem(bra.Branch.ToString(), bra.BranchId.ToString()));
                    txtNewsDescription.Text = Item.NewsDescription.ToString();
                }
            }
            else
            {
                lblTitle.Text = "Add Branch Employee News";
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
    protected void BindBranch()
    {
        ddlBranch.Items.Clear();
        if (ddlLocation.SelectedValue != "")
        {
            clsBranch obj = new clsBranch();
            obj.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
            ddlBranch.DataSource = obj.LoadAll(obj);
            ddlBranch.DataTextField = "Branch";
            ddlBranch.DataValueField = "BranchId";
            ddlBranch.DataBind();
            ddlBranch.Items.Insert(0, new ListItem("--Select Branch--", ""));
        }
    }
    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlLocation.SelectedValue != null)
        {
            BindBranch();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Item = new clsBranchEmployeeNews();

        SqlConnection conn = new SqlConnection(Constr);
        conn.Open();
        string str = "Select COUNT(*) from tblBranchEmployeeNews  where LocationId='" + ddlLocation.SelectedValue + "' and BranchId='" + ddlBranch.SelectedValue + "' and NewsDescription='" + txtNewsDescription.Text + "'";
        SqlCommand cmd = new SqlCommand(str, conn);
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        if (ItemId == 0)
        {
            if (count > 0)
            {
                ErrorMessage.Text = "The Branch Employee News already Exist in the List";
                ErrorMessage.Visible = true;
                FormMessage.Visible = false;
            }
            else if (count == 0)
            {
                Item.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
                Item.BranchId = Convert.ToInt32(ddlBranch.SelectedValue);
                Item.NewsDescription = Convert.ToString(txtNewsDescription.Text);
                Item.CreatedBy = CurrentUser.CurrentUserId;
                Item.AddUpdate(Item);
                txtNewsDescription.Text = "";
                ddlLocation.SelectedIndex = -1;
                ddlBranch.SelectedIndex = -1;
                btnSubmit.Enabled = false;
                FormMessage.Text = "Branch Employee News Created.";
                FormMessage.Visible = true;
                ErrorMessage.Visible = false;
            }
        }
        else
        {
            Item.BranchEmployeeNewsId = Convert.ToInt32(ItemId);
            Item.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
            Item.BranchId = Convert.ToInt32(ddlBranch.SelectedValue);
            Item.NewsDescription = Convert.ToString(txtNewsDescription.Text);
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.AddUpdate(Item);
            txtNewsDescription.Text = "";
            ddlLocation.SelectedIndex = -1;
            ddlBranch.SelectedIndex = -1;
            FormMessage.Text = "Branch Employee News Updated.";
            FormMessage.Visible = true;
            ErrorMessage.Visible = false;
            btnSubmit.Enabled = false;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("BranchEmployeeNewsSearch.aspx");
    }
}