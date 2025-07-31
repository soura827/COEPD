
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Participant_SessionAttendance : System.Web.UI.Page
{

    int Total = 0;
    DateTime DateTime;
    CurrentUser currentUser = new CurrentUser();
    clsSession Item;
    protected void Page_PreInit(object Sender, EventArgs e)
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
        clsSession obj = new clsSession();
        obj.ParticipantId = Convert.ToInt32(currentUser.CurrentParticipantId);
        List<clsSession> Data = obj.Loadfew(obj);
        gv.DataSource = obj.Loadfew(obj);
        gv.DataBind();
    }


    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ViewSession")
        {
            int sessionTypeId = Convert.ToInt32(e.CommandArgument);
            Response.Write($"SessionTypeId in gv_RowCommand: {sessionTypeId}");
            string redirectUrl = $"SessionAttendanceView.aspx?SessionTypeId={sessionTypeId}";
            Response.Redirect(redirectUrl);
        }
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();

    }



    protected void btnView_Click(object sender, EventArgs e)
    {
        int sessionTypeId = Convert.ToInt32((sender as Button).CommandArgument);
        Response.Write($"SessionTypeId in button click: {sessionTypeId}");
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {


            // Get the value from the specific cell (e.g., Cells[3])
            string cellValue = e.Row.Cells[0].Text;

            // Step 1: Create the Database Connection
            string connectionString = ConfigurationManager.ConnectionStrings["cs9"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            // Step 2: Write a Parameterized SQL Query
            string sqlQuery = "DECLARE @ISTDate smalldatetime SET @ISTDate=DATEADD(mi,30,DATEADD(hh,5,GETUTCDATE())) SELECT COUNT(*) FROM tblSession WHERE SessionTypeId = @Param AND IsActive = 1 AND (Date + StartTime) < @ISTDate";


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

