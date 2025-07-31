using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_ReferFriendSearch : System.Web.UI.Page
{
    CurrentUser currentUser = new CurrentUser();
    int Total = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            BindData();
        }

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReferFriend.aspx");
    }

    protected void BindData()
    {
        if (currentUser.CurrentParticipantId > 0)
        {
            clsReferFriend obj = new clsReferFriend();
            obj.ParticipantId = currentUser.CurrentParticipantId;

            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();

        }
        else
        {
            Response.Redirect("~/Login.html");
        }


    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label lbltext = (Label)e.Row.FindControl("lblstatus");
            string ID = Convert.ToString(lbltext.Text);
            switch (Convert.ToInt32(ID))
            {
                case 0:
                    lbltext.Text = "No Yet Reached";
                    lbltext.ForeColor = System.Drawing.Color.Red;
                    break;
                case 1:
                    lbltext.Text = "Warm";
                    lbltext.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case 2:
                    lbltext.Text = "Cold";
                    lbltext.ForeColor = System.Drawing.Color.Green;
                    break;
                case 3:
                    lbltext.Text = "Hot";
                    lbltext.ForeColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    lbltext.Text = "registered";
                    lbltext.ForeColor = System.Drawing.Color.YellowGreen;
                    break;
                case 5:
                    lbltext.Text = "Joined Training";
                    lbltext.ForeColor = System.Drawing.Color.CadetBlue;
                    break;
                case 6:
                    lbltext.Text = "Joined Internship";
                    lbltext.ForeColor = System.Drawing.Color.BurlyWood;
                    break;
                case 7:
                    lbltext.Text = "Placed";
                    lbltext.ForeColor = System.Drawing.Color.Brown;
                    break;
                case 8:
                    lbltext.Text = "Not Interested";
                    lbltext.ForeColor = System.Drawing.Color.Black;
                    break;
            }





            if (e.Row.DataItem != null)
            {
                HiddenField hdnAadharFrontFile = (HiddenField)e.Row.FindControl("hdnAadharFrontFile");
                HyperLink hplAadharFrontFile = (HyperLink)e.Row.FindControl("hplAadharFrontFile");

                if (hdnAadharFrontFile.Value == "")
                    hplAadharFrontFile.Visible = false;

            }
        }
    }

    protected void gv_PreRender(object sender, EventArgs e)
    {
        //int TotalRecords = 0;
        //string Records = "";
        //TotalRecords = (gv.PageSize * (gv.PageIndex + 1));
        //if (TotalRecords > Total)
        //    Records = Total.ToString();
        //else
        //    Records = TotalRecords.ToString();
        //PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        //PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        //PageNumberHeader.Font.Bold = true;
        //PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString() + " - (" + (gv.PageSize * gv.PageIndex + 1).ToString() + " - " + Records + ") Records " + " of " + Total.ToString() + "Total Records";
        //PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        //PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        //PageNumberFooter.Font.Bold = true;
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }


}