using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_AdminMentorPlacement : System.Web.UI.Page
{
    int ItemId = 0;

    CurrentUser CurrentUser = new CurrentUser();
    clsKPIMentorPlacement Item;

    public string Constr = ConfigurationManager.ConnectionStrings["cs10"].ConnectionString.ToString();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);

        if (!IsPostBack)
        {
            BindDesignation();
            BindKPIApplicableTo();
            Item = new clsKPIMentorPlacement();
            if (ItemId > 0)
            {

                lblTitle.Text = "Edit ";
                Item = Item.Load(ItemId);
                if (Item != null)
                {

                    ddlKPIApplicableTo.SelectedValue = Item.KPIApplicableToId.ToString();
                    ddlDesignations.SelectedValue=Item.DesignationId.ToString();
                }
                //btnSave.Visible = false;
            }
            else
            {
                lblTitle.Text = "Add";
            }
        }
    }
    protected void BindReset()
    {
        ddlDesignations.SelectedIndex = -1;
        ddlKPIApplicableTo.SelectedIndex = -1;
    }

        protected void BindKPIApplicableTo()
    {
        clsKPI obj = new clsKPI();
        ddlKPIApplicableTo.DataSource = obj.LoadAllKPIApplicableTo(obj);
        ddlKPIApplicableTo.DataTextField = "KPIApplicableTo";
        ddlKPIApplicableTo.DataValueField = "KPIApplicableToId";
        ddlKPIApplicableTo.DataBind();
        ddlKPIApplicableTo.Items.Insert(0, new ListItem("-- Select KPI Applicable To --", "0"));

    }

    protected void BinKPIGridView()
    {
        clsKPI obj = new clsKPI();
        if (ddlKPIApplicableTo.SelectedValue != null)
            obj.KPIApplicableToId = Convert.ToInt32(ddlKPIApplicableTo.SelectedValue);
        GridView1.DataSource = obj.KPINames(obj);
        GridView1.DataBind();

    }

    protected void BindData()
    {

        clsEmployee obj = new clsEmployee();
        if (txtEmployeename.Text != null)
            obj.Employee = txtEmployeename.Text;
        if (ddlDesignations.SelectedValue != null)
            obj.DesignationId = Convert.ToInt32(ddlDesignations.SelectedValue);
        gv.DataSource = obj.DisplayEmployee(obj);
        gv.DataBind();
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


    protected void btnSave_Click(object sender, EventArgs e)
    {

        clsKPIMentorPlacement Item = new clsKPIMentorPlacement();
        if (ItemId > 0)
        {
            Item.EmployeeKPIId = Convert.ToInt32(ItemId);
        }
        Item.DesignationId = Convert.ToInt32(ddlDesignations.SelectedValue);
        Item.KPIApplicableToId = Convert.ToInt32(ddlKPIApplicableTo.SelectedValue);     
        Item.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);

        foreach (GridViewRow employeeRow in gv.Rows)   //First GridView Employeename
        {
            CheckBox chkSelectEmployee = (CheckBox)employeeRow.FindControl("chkSelectEmployee");
            if (chkSelectEmployee.Checked)
            {
                string Employee = Convert.ToString(employeeRow.Cells[2].Text);


                foreach (GridViewRow kpiRow in GridView1.Rows)
                {
                  
                    CheckBox chkSelectKPI = (CheckBox)kpiRow.FindControl("chkst");
                    if (chkSelectKPI.Checked)
                    {
                        string KPIName = Convert.ToString(kpiRow.Cells[2].Text);

                        if (!CombinationExistsInDatabase(Employee, KPIName))
                        { 
                            Item.EmployeeId=Convert.ToInt32(employeeRow.Cells[1].Text);
                            Item.Employee = Convert.ToString(employeeRow.Cells[2].Text);
                            Item.KPIName = Convert.ToString(kpiRow.Cells[2].Text);
                            Item.MonthlyTarget = Convert.ToInt32(kpiRow.Cells[3].Text);
                            Item.AddUpdate(Item);
                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
                        }
                        if (ItemId > 0)
                        {
                            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
                            btnSave.Enabled = false;
                        }

                    }
                }

            }

        }
        BindReset();
       // btnSave.Enabled = false;


    }
    protected bool CombinationExistsInDatabase(string Employee, string KPIName)
    {
        SqlConnection con = new SqlConnection(Constr);
        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tblKPISMonthlyTarget WHERE Employee = @Employee AND KPIName= @KPIName", con);
        cmd.Parameters.AddWithValue("@Employee", Employee);
        cmd.Parameters.AddWithValue("@KPIName", KPIName);
        con.Open();
        int count = (int)cmd.ExecuteScalar();
        con.Close();
        return count > 0;
    }


    protected void ddlDesignations_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtEmployeename_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void chkselectedall_CheckedChanged(object sender, EventArgs e)
    {
        bool isselect = ((CheckBox)gv.HeaderRow.FindControl("chkselectedall")).Checked;
        for (int i = 0; i < gv.Rows.Count; i++)
        {
            if (isselect == true)
            {
                ((CheckBox)gv.Rows[i].FindControl("chkSelectEmployee")).Checked = true;
            }
            else if (isselect == false)
            {
                ((CheckBox)gv.Rows[i].FindControl("chkSelectEmployee")).Checked = false;
            }

        }
    }



    protected void ddlKPIApplicableTo_SelectedIndexChanged1(object sender, EventArgs e)
    {
        BinKPIGridView();
    }

    protected void chkall_CheckedChanged(object sender, EventArgs e)
    {

        bool isselect = ((CheckBox)GridView1.HeaderRow.FindControl("chkall")).Checked;
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            if (isselect == true)
            {
                ((CheckBox)GridView1.Rows[i].FindControl("chkst")).Checked = true;
            }
            else if (isselect == false)
            {
                ((CheckBox)GridView1.Rows[i].FindControl("chkst")).Checked = false;
            }

        }
    }

    protected void btnAddTarget_Click(object sender, EventArgs e)
    {

        foreach (GridViewRow row in GridView1.Rows)
        {
            CheckBox checkBox = (CheckBox)row.FindControl("chkst");

            if (checkBox.Checked)
            {
                int KPIId = Convert.ToInt32(row.Cells[1].Text);

                string Constr2= ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
                using (SqlConnection con = new SqlConnection(Constr2))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update tblKPI SET MonthlyTarget = '"+ txttarget.Text+ "' where KPIId='"+KPIId+"'", con);

                    cmd.ExecuteNonQuery();
                }

            }
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminMentorPlacementSearch.aspx");
    }
}
