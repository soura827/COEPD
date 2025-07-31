using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ChangeServiceOwner : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString());
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtPreviousEmployee_TextChanged(object sender, EventArgs e)
    {
        ddlPreviousEmployee.Items.Clear();
        ddlPreviousEmployee.Items.Insert(0, new ListItem("-- Select Service Owner -- ", ""));
        if (txtPreviousEmployee.Text != "")
        {
            BindPrevousUser();
        }
    }
    protected void BindPrevousUser()
    {
        ddlPreviousEmployee.Items.Clear();
        clsUser obj = new clsUser();
        obj.keywords = txtPreviousEmployee.Text;
        ddlPreviousEmployee.DataSource = obj.LoadAllEmployees(obj);
        ddlPreviousEmployee.DataTextField = "Fullname";
        ddlPreviousEmployee.DataValueField = "UserId";
        ddlPreviousEmployee.DataBind();
        ddlPreviousEmployee.Items.Insert(0, new ListItem("Select Service Owner", "0"));

    }

    protected void ddlPreviousEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        clsLead obj = new clsLead();
        if (txtLeadSearch.Text != "")
            obj.keywords = txtLeadSearch.Text;
        if (txtPreviousEmployee.Text != "")
            obj.CreatedBy = Convert.ToInt32(ddlPreviousEmployee.SelectedValue);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }

    protected void txtAssiningEmployee_TextChanged(object sender, EventArgs e)
    {
        BindAssigningEmployee();
    }

    protected void BindAssigningEmployee()
    {

        ddlAssigning.Items.Clear();
        clsUser obj = new clsUser();
        obj.keywords = txtAssiningEmployee.Text;
        ddlAssigning.DataSource = obj.LoadAllEmployees(obj);
        ddlAssigning.DataTextField = "Fullname";
        ddlAssigning.DataValueField = "UserId";
        ddlAssigning.DataBind();
        ddlAssigning.Items.Insert(0, new ListItem("Select Service Owner", "0"));

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ddlAssigning.SelectedValue == "" || ddlPreviousEmployee.SelectedValue == "")
        {
            if(ddlAssigning.SelectedValue == "")
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeAssignSelect()", true);
            }
            else if (ddlPreviousEmployee.SelectedValue == "")
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmePrevSelect()", true);
            }
        }
        else
        {
            int LeadId = 0;
            for (int i = 0; i < gv.Rows.Count; i++)
            {
                CheckBox chkselect = (CheckBox)gv.Rows[i].FindControl("chkselect");
                if (chkselect.Checked == true)
                {
                    LeadId = Convert.ToInt32(gv.Rows[i].Cells[2].Text);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update tblLead SET CreatedBy= '" + ddlAssigning.SelectedValue + "' where LeadId='" + LeadId + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            BindData();

        }

    }

    protected void chkselectedall_CheckedChanged(object sender, EventArgs e)
    {
        bool isselect = ((CheckBox)gv.HeaderRow.FindControl("chkselectedall")).Checked;
        for (int i = 0; i < gv.Rows.Count; i++)
        {
            if (isselect == true)
            {
                ((CheckBox)gv.Rows[i].FindControl("chkselect")).Checked = true;
            }
            else if (isselect == false)
            {
                ((CheckBox)gv.Rows[i].FindControl("chkselect")).Checked = false;
            }

        }

    }

    protected void txtLeadSearch_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

}