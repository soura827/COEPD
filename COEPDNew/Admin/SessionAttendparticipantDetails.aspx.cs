using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class Admin_SessionAttendparticipantDetails : System.Web.UI.Page
{
    int SessionId = 0;
    int ItemId = 0;
    DateTime DateTime;
    CurrentUser CurrentUser = new CurrentUser();
    int Count = 0;
    string Constr = ConfigurationManager.ConnectionStrings["cs9"].ToString();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        clsSession Item = new clsSession();
        if (!IsPostBack)
        {



            txtFromDate.Text = DateTime.UtcNow.AddHours(5).AddMinutes(30).ToString("dd/MM/yyyy");
            txtToDate.Text = DateTime.UtcNow.AddHours(5).AddMinutes(30).ToString("dd/MM/yyyy");
            BindData();
            LoadSessionType();

        }
    }



    protected void BindData()
    {
        clsSession Item = new clsSession();
        ItemId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);

        Item = Item.SessionReporting(ItemId);

        clsSession obj = new clsSession();


        if (Item.IsReportingManager == false)
        {
            obj.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
        }







        
        if (ddlSession.SelectedValue != "")
        {
            obj.SessionTypeId =Convert.ToInt32( ddlSession.SelectedValue);
        }

       if(txtkeywords.Text != null)
        {
            obj.Keywords = txtkeywords.Text;
        }
       if(txtCreatedby.Text != null)
        {
            obj.Fullname = txtCreatedby.Text;
        }




        if (txtFromDate.Text != "")
        {
            obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.FromDate = null;
        }
        if (txtToDate.Text != "")
        {
            obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            obj.ToDate = null;
        }






        gv.DataSource = obj.AttendParticipant(obj);
        gv.DataBind();
    }


    protected void LoadSessionType()
    {
        clsSession obj = new clsSession();
        ddlSession.DataSource = obj.LoadForAll(obj);
        ddlSession.DataTextField = "SessionName";
        ddlSession.DataValueField = "SessionTypeId";
        ddlSession.DataBind();
        ddlSession.Items.Insert(0, new ListItem("-- Select Session Type --", ""));
    }




    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }




    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("SessionParticipantDetails.aspx?ItemId=" + e.CommandArgument);
        }
      
    }

    protected void txtkeywords_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtCreatedby_TextChanged(object sender, EventArgs e)
    {
        BindData();

    }

    

    protected void ddlSession_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();

    }





    protected void txtFromDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtToDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }



    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            // Get the value from the specific cell (e.g., Cells[3])
            string cellValue = e.Row.Cells[1].Text;

            // Step 1: Create the Database Connection
            string connectionString = ConfigurationManager.ConnectionStrings["cs9"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            // Step 2: Write a Parameterized SQL Query
            string sqlQuery = "SELECT COUNT(*) FROM tblParticipantSessionAttendance WHERE SessionId = @Param";

            // Step 3: Execute the Query with Parameter
            connection.Open();
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@Param", cellValue);
            int count = (int)command.ExecuteScalar();
            connection.Close();

            // Find the Label in the row and update its text with the count
            Label lblCount = e.Row.FindControl("lblCount") as Label;
            if (lblCount != null)
            {
                lblCount.Text = count.ToString();
            }
        }
    }
}



       

    
