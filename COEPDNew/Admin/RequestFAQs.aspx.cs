using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_RequestFAQs : System.Web.UI.Page
{
    int itemId = 0;
    int RSId = 0;
    int CountNo;
    clsRequestFAQs item;
    clsParticipant Item = new clsParticipant();
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;

    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {


        itemId = Convert.ToInt32(Request.QueryString["itemId"]);
        if (!IsPostBack)
        {
            item = new clsRequestFAQs();
            if (itemId > 0)
            {
                //divParticipant.Visible = false;

                lblTitle.Text = "Send Requested FAQs";
                item = item.Load(itemId);

                if (item != null)
                {
                    ItemId = item.ParticipantId;
                    if(ItemId>0)
                    {
                        //hdnParticipantId.Value = Convert.ToString(ItemId);
                        Item = Item.Load(ItemId);
                        if(Item !=null)
                        {
                            lblParticipant.Text = Item.Participant;
                        }

                    }
                    hdnRSId.Value = Convert.ToString(item.ResumeSubmissionId);
                    txtCompanyName.Enabled = false;
                    txtParticipantInputs.Enabled = false;
                    txtCompanyName.Text = item.CompanyName;
                    txtParticipantInputs.Text = item.Notes;
                    txtFAQs.Text = item.FAQs;
                    if (item.IsApproved == true)
                    {
                        divGrid.Visible = false;
                        divCKEditor.Visible = true;
                    }
                    else
                    {
                        BindData();
                        divGrid.Visible = true;
                        divCKEditor.Visible = false;
                    }
                        
                    if (item.ProofOfInterviewPath != "")
                    {
                        hplSentFile.Visible = true;
                        hplSentFile.NavigateUrl = "~/UserDocs/PlacementFAQs/" + item.ProofOfInterviewPath;
                    }
                    else
                    {
                        hplSentFile.Visible = false;
                    }
                }
            }
        }
    }
    private void BindData()
    {
        clsFAQsMaster obj = new clsFAQsMaster();
        //obj.RevisedBy = CurrentUser.CurrentEmployeeId;
        if (txtcompany.Text != "")
            obj.CompanyName = txtcompany.Text;
        if (txtSkilSet.Text != "")
            obj.SkilSet = txtSkilSet.Text;
            obj.IsRevised = true;
        if (ddlSource.SelectedValue != "")
            obj.IsSourceParticipant = Convert.ToBoolean(ddlSource.SelectedValue);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    #region
    //protected void btnSubmit_Click(object sender, EventArgs e)
    //{
    //    item = new clsRequestFAQs();
    //    if (itemId > 0)
    //    {
    //        item.RequestFAQsId = itemId;
    //    }
    //    item.ParticipantId = Convert.ToInt32(hdnParticipantId.Value);
    //    item.CompanyName = txtCompanyName.Text;
    //    item.Notes = txtNotes.Text;
    //    item.IsApproved = true;
    //    item.CreatedBy = CurrentUser.CurrentUserId;
    //    item.AddUpdate(item);
    //    btnSubmit.Enabled = false;

    //    if (itemId > 0)
    //    {
    //        ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeUpdate()", true);
    //    }
    //    else
    //    {
    //        ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);

    //    }
    //}
    #endregion
    protected void gv_PreRender(object sender, EventArgs e)
    {
        #region

        //PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        //PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        //PageNumberHeader.Font.Bold = true;
        //PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        //PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        //PageNumberFooter.Font.Bold = true;
        #endregion
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdAssign")
        {
            
            clsRequestFAQs obj = new clsRequestFAQs();
            obj.RequestFAQsId = itemId;
            obj.IsApproved = true;
            obj.FAQsId = Convert.ToInt32(e.CommandArgument);
           // obj.ParticipantId = Convert.ToInt32(hdnParticipantId.Value);
            obj.CreatedBy = CurrentUser.CurrentUserId;
            obj.AddUpdate(obj);
            Response.Redirect("RequestFAQsSearch.aspx");
        }

    }

    protected void txtcompany_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("RequestFAQsSearch.aspx");
    }

    protected void BindValidation()
    {
       
        clsHrRequestFAQs obj = new clsHrRequestFAQs();
        obj.ResumeSubmissionId = Convert.ToInt32(hdnRSId.Value);
        CountNo = obj.LoadHrRequestFAQsResumeSubmission_Validation(obj);
        if (CountNo > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeResumeSubMission()", true);
        }

    }




    protected void btnRequestToMentor_Click(object sender, EventArgs e)
    {
        BindValidation();
        btnRequestToMentor.Enabled = false;

        if (CountNo == 0)
        {
            clsHrRequestFAQs obj = new clsHrRequestFAQs();
            obj.ResumeSubmissionId = Convert.ToInt32(hdnRSId.Value);
            obj.CreatedBy = CurrentUser.CurrentUserId;
            obj.AddUpdate(obj);

            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeMentorUpdate()", true);
        }
       

    }
}

  

