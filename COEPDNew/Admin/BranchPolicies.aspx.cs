using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data.SqlClient;
using System.Configuration;
public partial class Admin_BranchPolicies : System.Web.UI.Page
{
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    int ItemId = 0;
    clsBranchPolicies Item;
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
            Item = new clsBranchPolicies();
            if (ItemId>0)
            {
                lblTitle.Text = "Edit Branch Policies";
                Item = Item.Load(ItemId);
                if(Item!=null)
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
                    txtPageTitle.Text = Item.PolicyTitle.ToString();
                    txtBranchPolicies.Text = Item.PolicyContent.ToString();
                }
            }
            else
            {
                lblTitle.Text = "Add Branch Policies";
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
        if(ddlLocation.SelectedValue!="")
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
        if (ddlLocation.SelectedValue!=null)
        {
            BindBranch();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Item = new clsBranchPolicies();

        SqlConnection conn = new SqlConnection(Constr);
        conn.Open();

        string str = "Select COUNT(*) from tblBranchPolicies  where LocationId='" + ddlLocation.SelectedValue + "' and BranchId='" + ddlBranch.SelectedValue + "'";
        SqlCommand cmd = new SqlCommand(str, conn);
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        if (ItemId == 0)
        {
            if (count > 0)
            {
                ErrorMessage.Text = "The Branch Policies already Exist in the List";
                ErrorMessage.Visible = true;
                FormMessage.Visible = false;
            }
            else if (count == 0)
            {
                Item.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
                Item.BranchId = Convert.ToInt32(ddlBranch.SelectedValue);
                Item.PolicyTitle = Convert.ToString(txtPageTitle.Text);
                Item.PolicyContent = Convert.ToString(txtBranchPolicies.Text);
                Item.CreatedBy = CurrentUser.CurrentUserId;
                Item.AddUpdate(Item);
                txtPageTitle.Text = "";
                txtBranchPolicies.Text = "";
                ddlLocation.SelectedIndex = -1;
                ddlBranch.SelectedIndex = -1;
                btnSubmit.Enabled = false;
                FormMessage.Text = "Branch Policies Created.";
                FormMessage.Visible = true;
                ErrorMessage.Visible = false;
            }
        }
        else
        {
            Item.PolicyId = Convert.ToInt32(ItemId);
            Item.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
            Item.BranchId = Convert.ToInt32(ddlBranch.SelectedValue);
            Item.PolicyTitle = Convert.ToString(txtPageTitle.Text);
            Item.PolicyContent = Convert.ToString(txtBranchPolicies.Text);
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.AddUpdate(Item);
            txtPageTitle.Text = "";
            txtBranchPolicies.Text = "";
            ddlLocation.SelectedIndex = -1;
            ddlBranch.SelectedIndex = -1;
            FormMessage.Text = "Branch Policies Updated.";
            FormMessage.Visible = true;
            ErrorMessage.Visible = false;
            btnSubmit.Enabled = false;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("BranchPoliciesSearch.aspx");
    }
}