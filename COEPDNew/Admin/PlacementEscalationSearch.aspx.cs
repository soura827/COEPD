using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_PlacementEscalationSearch : System.Web.UI.Page
{
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
        clsPlacementEscalation Item = new clsPlacementEscalation();
        if (txtParticipant.Text != "")
            Item.Keywords = txtParticipant.Text;
        if (txtLocation.Text != "")
            Item.Location = txtLocation.Text;
        if (ddlStatus.SelectedValue != "")
            Item.IsReplied = Convert.ToBoolean(ddlStatus.SelectedValue);
        gv.DataSource = Item.LoadParticipantsAll(Item);
        gv.DataBind();
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)   
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("PlacementEscalation.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            //int ItemId = Convert.ToInt16(e.CommandArgument);
            //clsActivity Item = new clsActivity();
            //Item.Remove(ItemId);
            //BindData();
            //ErrorMessage.Text = "Activity successfully removed";
            //ErrorMessage.Visible = true;
        }
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
    protected void txtParticipant_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtLocation_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.DataItem != null)
            {
                HiddenField hdnSendFile = (HiddenField)e.Row.FindControl("hdnSendFile");
                HiddenField hdnReplyFile = (HiddenField)e.Row.FindControl("hdnReplyFile");
                HyperLink hplSendFile = (HyperLink)e.Row.FindControl("hplSendFile");
                HyperLink hplReplyFile = (HyperLink)e.Row.FindControl("hplReplyFile");

                if (hdnSendFile.Value == "")
                {
                    hplSendFile.Visible = false;
                }

                if (hdnReplyFile.Value == "")
                {
                    hplReplyFile.Visible = false;
                }
            }
        }
    }
}