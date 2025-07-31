using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_AdminMentorPlacementSearch : System.Web.UI.Page
{

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    protected void BindData()
    {
        clsKPIMentorPlacement obj = new clsKPIMentorPlacement();
        if (txtEmployeeNames.Text != "")
            obj.Employee = txtEmployeeNames.Text;
        if (txtKPIname.Text != "")
            obj.KPIName = txtKPIname.Text;
        if (txtkpiapplicalbeto.Text != "")
            obj.KPIApplicableTo = txtkpiapplicalbeto.Text;

        GridView1.DataSource = obj.LoadAll(obj);
        GridView1.DataBind();
    }
    protected void chkall_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void txtEmployeeNames_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminMentorPlacement.aspx");
    }

    protected void txtkpiapplicalbeto_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtKPIname_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("AdminMentorPlacement.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            int ItemId = Convert.ToInt32(e.CommandArgument);
            clsKPIMentorPlacement Item = new clsKPIMentorPlacement();
            Item.Remove(ItemId);
            BindData();
            //ErrorMessage.Text = "KPI Employee  successfully removed.";
            //ErrorMessage.Visible = true;
        }
    }

    protected void GridView1_PreRender(object sender, EventArgs e)
    {
        PageNumberHeader.Text = " Displaying Page " + (GridView1.PageIndex + 1).ToString() + " of " + GridView1.PageCount.ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (GridView1.PageIndex + 1).ToString() + " of " + GridView1.PageCount.ToString();
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        BindData();
    }

    //protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    //{
    //    GridView1.EditIndex = e.NewEditIndex;
    //    BindData();
    //}

    //protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
    //{
    //    GridViewRow row = GridView1.Rows[e.RowIndex];


    //     int EmployeeKPIId = Convert.ToInt32(row.Cells[1].Text); // Assuming EmployeeKPIId is in the second column
    //    string Employee = Convert.ToString(((TextBox)row.FindControl("Employee")).Text);
    //    string Designation = Convert.ToString(((TextBox)row.FindControl("Designation")).Text);
    //    string KPIName = Convert.ToString(((TextBox)row.FindControl("KPIName")).Text);
    //    int MonthlyTarget = Convert.ToInt32(((TextBox)row.FindControl("MonthlyTarget")).Text);


    //    GridView1.EditIndex = -1;

    //    BindData();
    //}
}