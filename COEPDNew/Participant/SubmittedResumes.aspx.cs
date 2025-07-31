using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_SubmittedResumes : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    string InvolvedParticipants = "";
    string Activity = "sending resume for JD of IT Company";
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
        if(CurrentUser.CurrentName !="")
        {
            clsActivityInteractions Obj = new clsActivityInteractions();
            Obj.Activity = Activity;
            Obj.InvolvedParticipants = CurrentUser.CurrentName;
            gv.DataSource = Obj.LoadAllParticipantInteractions(Obj);
            gv.DataBind();
        }
        else
        {
            Response.Redirect("~/Login.html");
        }
        
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();

    }

    protected void gv_PreRender(object sender, EventArgs e)
    {
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;

    }
}