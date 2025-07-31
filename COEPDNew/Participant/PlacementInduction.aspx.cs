using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Participant_PlacementInduction : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;
    clsParticipant Item;
    int itemId = 0;
    int CountNo = 0;
    clsPlacementInduction item;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = CurrentUser.CurrentParticipantId;
        itemId = Convert.ToInt32(Request.QueryString["itemId"]);
        item = new clsPlacementInduction();
        Item = new clsParticipant();
        if (!IsPostBack)
        {
            if (itemId > 0)
            {
                item = item.Load(itemId);
                if (item != null)
                {
                    txtAttendedOn.Text = item.AttendedOn.ToString("dd/MM/yyyy");
                    chkTermsAccepted.Checked = true;
                    chkTermsAccepted.Enabled = false;
                    btnSubmit.Visible = false;
                   // chkTermsAccepted.Visible = false;
                   // lblTerms.Visible = false;
                }

            }
            else
            {
                if (ItemId > 0)
                {
                    item.ParticipantId = ItemId;
                    CountNo = item.LoadPlacementInductionValidation(item);
                    if (CountNo > 0)
                    {
                        Response.Redirect("PlacementInductionSearch.aspx");
                    }
                    else
                    {
                        
                       
                    }

                }
                else
                {
                    Response.Redirect("~/Login.html");
                }
               

            }

        }
        if (chkTermsAccepted.Checked == true)
        {
            btnSubmit.Enabled = true;
        }
        else
        {
            btnSubmit.Enabled = false;
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        item = new clsPlacementInduction();
        if (itemId > 0)
        {
            item.PlacementInductionId = ItemId;
        }
        item.ParticipantId = CurrentUser.CurrentParticipantId;
        if (txtAttendedOn.Text != "")
        {
            DateTime Date = DateTime.ParseExact(txtAttendedOn.Text, "dd/MM/yyyy", null);
            item.AttendedOn = Convert.ToDateTime(Date);
        }
        if (chkTermsAccepted.Checked == true)
            item.IsTermsAccepted = true;
        else
            item.IsTermsAccepted = false;
        item.CreatedBy = CurrentUser.CurrentUserId;
        item.AddUpdate(item);
        txtAttendedOn.Text = "";
        btnSubmit.Enabled = false;

        if (ItemId > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);

        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("PlacementInductionSearch.aspx");
    }
}