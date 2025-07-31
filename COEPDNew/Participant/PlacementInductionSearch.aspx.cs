using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_PlacementInductionSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int CountNo = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
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
        if (CurrentUser.CurrentParticipantId > 0)
        {
            clsPlacementInduction obj = new clsPlacementInduction();
            obj.ParticipantId = CurrentUser.CurrentParticipantId;
            if (ddlStatus.SelectedValue != "")
                obj.IsHRMockApproved = Convert.ToBoolean(ddlStatus.SelectedValue);
            gv.DataSource = obj.LoadAll(obj);
            gv.DataBind();
            CountNo = obj.LoadPlacementInductionValidation(obj);
            if (CountNo > 0)
            {
                btnAdd.Visible = false;
            }
            else
            {
                btnAdd.Visible = true;
            }
        }
        else
        {
            Response.Redirect("~/Login.html");
        }

    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")



        {
            Response.Redirect("PlacementInduction.aspx?itemId=" + e.CommandArgument);


        }
       
    }
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    if (e.Row.DataItem != null)
        //    {
        //        HiddenField hdnReplyFile = (HiddenField)e.Row.FindControl("hdnReplyFile");
        //        HyperLink hplReplyFile = (HyperLink)e.Row.FindControl("hplReplyFile");

        //        if (hdnReplyFile.Value == "")
        //        {
        //            hplReplyFile.Visible = false;
        //        }
        //    }
        //}
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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("PlacementInduction.aspx");
    }

    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}