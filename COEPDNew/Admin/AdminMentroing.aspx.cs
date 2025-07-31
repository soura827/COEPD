using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data.SqlClient;


public partial class Admin_IndividualMentoring : System.Web.UI.Page
{

    int ItemId = 0;
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

    CurrentUser CurrentUser = new CurrentUser();
    clsMentoringKPIS Item=new clsMentoringKPIS();
    int CountNo = 0;
  
  
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);

        if (!IsPostBack)
        {
            BindLocation();
            BindDesignation();
            BindKPIS();
            Item = new clsMentoringKPIS();  
            if (ItemId > 0)
            {
                Item = Item.Load(ItemId);

                if (Item != null)
                {

                    ddlBranch.Text = Item.BranchId.ToString();
                    ddlDesignations.SelectedValue = Item.DesignationId.ToString();
                    ddlMentroingnames.SelectedValue = Item.EmployeeId.ToString();
                    ddlKpis.SelectedValue = Item.KPIId.ToString();
                    txtTargets.Text = Convert.ToString(Item.Tragets);

                }
            }

        }
    }
    protected void BindCount()
    {
        clsMentoringKPIS obj = new clsMentoringKPIS();
        obj.BranchId = Convert.ToInt32(ddlBranch.SelectedValue);
        obj.DesignationId = Convert.ToInt32(ddlDesignations.SelectedValue);
        obj.EmployeeId = Convert.ToInt32(ddlMentroingnames.SelectedValue);
        obj.KPIId = Convert.ToInt32(ddlKpis.SelectedValue);
       // CountNo = obj.LoadKPIEmployeeValidation(obj);
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
    //clsDesignationData



    protected void BindBranch()
    {
        // ddlBranch.Items.Clear();
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

    protected void BindDesignation()
    {
        clsDesignation obj = new clsDesignation();

        ddlDesignations.DataSource = obj.LoadAll(obj);
        ddlDesignations.DataTextField = "Designation";
        ddlDesignations.DataValueField = "DesignationId";
        ddlDesignations.DataBind();
        ddlDesignations.Items.Insert(0, new ListItem("--Select Designation--", ""));
    }
    protected void BindEmployeeNames()
    {

        clsEmployee obj = new clsEmployee();
        if (ddlDesignations.SelectedValue != "")
            obj.DesignationId = Convert.ToInt32(ddlDesignations.SelectedValue);
        ddlMentroingnames.DataSource = obj.LoadAll(obj);
        ddlMentroingnames.DataTextField = "Employee";
        ddlMentroingnames.DataValueField = "EmployeeId";
        ddlMentroingnames.DataBind();
        ddlMentroingnames.Items.Insert(0, new ListItem("--Select Employee --", "0"));

    }

    //protected void BindKPIApplicableTo()
    //{
    //    clsKPI obj = new clsKPI();
    //    ddlKPIApplicableTo.DataSource = obj.LoadAllKPIApplicableTo(obj);
    //    ddlKPIApplicableTo.DataTextField = "KPIApplicableTo";
    //    ddlKPIApplicableTo.DataValueField = "KPIApplicableToId";
    //    ddlKPIApplicableTo.DataBind();
    //    ddlKPIApplicableTo.Items.Insert(0, new ListItem("-- Select KPI Applicable To --", "0"));

    //}
    protected void BindKPIS()
    {
        clsKPI obj = new clsKPI();
        ddlKpis.DataSource = obj.LoadAll(obj);
        ddlKpis.DataTextField = "KPIName";
        ddlKpis.DataValueField = "KPIId";
        ddlKpis.DataBind();
        ddlKpis.Items.Insert(0, new ListItem("-- Select KPI Applicable To --", "0"));

    }


    protected void ddlDesignations_SelectedIndexChanged(object sender, EventArgs e)
    {

        BindEmployeeNames();

    }

    protected void BindReset()
    {
        ddlLocation.SelectedIndex = -1;
        ddlMentroingnames.SelectedIndex = -1;
        ddlBranch.SelectedIndex = -1;
        txtTargets.Text = "";
    }


    protected void ddlLocation_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (ddlLocation.SelectedValue != null)
        {
            BindBranch();
        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       
       // System.Threading.Thread.Sleep(3000);

        clsMentoringKPIS Item = new clsMentoringKPIS();

        if (ItemId > 0)
        {
            Item.MentorId = Convert.ToInt32(ItemId);
        }

        Item.EmployeeId = Convert.ToInt32(ddlMentroingnames.SelectedValue);
        Item.BranchId = Convert.ToInt32(ddlBranch.SelectedValue);
        Item.DesignationId = Convert.ToInt32(ddlDesignations.SelectedValue);
        Item.KPIId = Convert.ToInt32(ddlKpis.SelectedValue);
        Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
        Item.Tragets = Convert.ToInt32(txtTargets.Text);

        Item.AddUpdate(Item);
        btnSubmit.Enabled = false;
        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }

    }



    protected void ddlKPIApplicableTo_SelectedIndexChanged(object sender, EventArgs e)
    {
        //  BindKPIS();
    }

 

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("MentorSearchPage.aspx");
    }
}