using BusinessLayer;
using DataAccessLayerHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Participant_SessionAttendanceView : System.Web.UI.Page
{
    CurrentUser currentUser = new CurrentUser();
    clsSession Item = new clsSession();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (int.TryParse(Request.QueryString["SessionTypeId"], out int sessionTypeId))
            {
                clsSession obj = new clsSession();
                obj.ParticipantId = Convert.ToInt32(currentUser.CurrentParticipantId);
                obj.SessionTypeId = sessionTypeId;
                List<clsSession> sessionList = obj.LoadLess(obj);// Use your LoadLess method to retrieve data
                if (sessionList != null)
                {
                    gv.DataSource = sessionList;
                    gv.DataBind();
                }
                
            }
        }
    }




    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }





    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        Response.Redirect("SessionAttendance.aspx");
    }
}
