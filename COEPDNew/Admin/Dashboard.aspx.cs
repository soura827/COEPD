using System;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;
using BusinessLayer;
public partial class Dashboard : System.Web.UI.Page
{

    CurrentUser CurrentUser = new CurrentUser();
    DateTime DateTime;
    clsEmployeeLogInLogOutReport Item;
    clsAssignAward Items;


    List<clsCalender> Calenderlist = new List<clsCalender>();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        teams();

        clsCalender obj = new clsCalender();
        obj.IsActive = true;
        Calenderlist = obj.LoadAll(obj);
        if (!IsPostBack)
        {
            BindAward();
            DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            txtFromDate.Text = DateTime.ToString("dd/MM/yyyy");
            txtToDate.Text = DateTime.ToString("dd/MM/yyyy");

            if (!CurrentUser.IsLead)
            {
                followup.Visible = false;
            }
            else
            {
                BindLocation();
                BindData();
            }
            if (CurrentUser.CurrentDesignation == "Manager - HR")
            {
                divHr.Visible = true;
            }
            else
            {
                divHr.Visible = false;
            }
          
            clsFeatureAccess Item = new clsFeatureAccess();
            Item.EmployeeId = CurrentUser.CurrentEmployeeId;
            Item.PageName = "RetakeExamSearch.aspx";
            int Id = Item.FeaturePageValidation(Item);
            if (Id == 0)
            {
                divRetakeExams.Visible = false;
                divPlacement.Visible = false;


            }
            else
            {
                BindRetakeExamData();
                divPlacement.Visible = false;  /**/
               
            }
            BindRole();
            BindNews();
            ResumesCounts();
            ShortlistedResumes();
           


            
        }


        Item = new clsEmployeeLogInLogOutReport();
        Item = Item.Loadfew(CurrentUser.CurrentUserId);
        Items = new clsAssignAward();
        Items = Items.LoadAllAward(CurrentUser.CurrentUserId);
        BindAward();
        DataBind();
       
    }
    protected void DataBind()

    {
        clsEmployeeLogInLogOutReport Obj = new clsEmployeeLogInLogOutReport();
        Obj.UserId = Convert.ToInt32(CurrentUser.CurrentUserId);
        List<clsEmployeeLogInLogOutReport> Data = Obj.LoadAll(Obj);
        if (txtEmployeeDetails.Text != "")
            Obj.Keywords = txtEmployeeDetails.Text;

        if (txtBranch.Text != "")
            Obj.Branch = txtBranch.Text;
        if (txtFromDate.Text != "")
        {
            Obj.FromDate = DateTime.ParseExact(txtFromDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            Obj.FromDate = null;
        }
        if (txtToDate.Text != "")
        {
            Obj.ToDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy", null);
        }
        else
        {
            Obj.ToDate = null;
        }
        Griddata.Caption = "Report From " + txtFromDate.Text + " To " + txtToDate.Text;
        Griddata.DataSource = Obj.LoadAll(Obj);
        Griddata.DataBind();
    }
    protected void txtEmployeeDetails_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtBranch_TextChanged(object sender, EventArgs e)
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

    protected void btnDownload_Click(object sender, EventArgs e)
    {
        string FileNamePrepix = string.Empty;
        DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        FileNamePrepix = DateTime.ToString("dd-MM-yyyy - hh mm tt");
        ExportToExcel(FileNamePrepix + "-EMPLoginLogoutReport.xls", gv);
    }
    protected void ExportToExcel(string strFileName, GridView gv)
    {
        Response.ClearContent();
        Response.AddHeader("content-disposition", "attachment; filename=" + strFileName);
        Response.ContentType = "application/excel";
        StringWriter SW = new StringWriter();
        HtmlTextWriter HTW = new HtmlTextWriter(SW);
        gv.RenderControl(HTW);
        Response.Write(SW.ToString());
        Response.End();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {

    }

    protected void teams()
    {
        clsEmployee employee = new clsEmployee();


        if (CurrentUser.CurrentEmployeeId == 2 || CurrentUser.CurrentEmployeeId == 27
            || CurrentUser.CurrentEmployeeId == 6349)
        {

            BtnProcessTeam.Visible = true;
            BtnHRTeam.Visible = true;
            BtnNurturingTeam.Visible = true;
            BtnAdministratio.Visible = true;
            BtnMarketingTeam.Visible = true;
            BtnDevelopmentTeam.Visible = true;
            BtnMentoringTeam.Visible = true;
        }





        int Designation = CurrentUser.CurrentDesignationId;
        switch (Designation)
        {


            case 4:

                BtnProcessTeam.Visible = true;
                BtnHRTeam.Visible = false;
                BtnNurturingTeam.Visible = false;
                BtnAdministratio.Visible = false;
                BtnMarketingTeam.Visible = false;
                BtnDevelopmentTeam.Visible = false;
                BtnMentoringTeam.Visible = false;

                break;

            case 3:

                if (CurrentUser.CurrentEmployeeId != 6349)
                {
                    BtnProcessTeam.Visible = false;
                    BtnHRTeam.Visible = false;
                    BtnNurturingTeam.Visible = false;
                    BtnAdministratio.Visible = false;
                    BtnMarketingTeam.Visible = false;
                    BtnDevelopmentTeam.Visible = false;
                    BtnMentoringTeam.Visible = true;
                }

                if (CurrentUser.CurrentEmployeeId == 6349)
                {
                    BtnProcessTeam.Visible = true;
                    BtnHRTeam.Visible = true;
                    BtnNurturingTeam.Visible = true;
                    BtnAdministratio.Visible = true;
                    BtnMarketingTeam.Visible = true;
                    BtnDevelopmentTeam.Visible = true;
                    BtnMentoringTeam.Visible = true;
                }

                break;

            case 9:

                BtnProcessTeam.Visible = true;
                BtnHRTeam.Visible = true;
                BtnNurturingTeam.Visible = true;
                BtnAdministratio.Visible = true;
                BtnMarketingTeam.Visible = true;
                BtnDevelopmentTeam.Visible = true;
                BtnMentoringTeam.Visible = true;

                break;

            case 20:

                BtnProcessTeam.Visible = false;
                BtnHRTeam.Visible = true;
                BtnNurturingTeam.Visible = false;
                BtnAdministratio.Visible = false;
                BtnMarketingTeam.Visible = false;
                BtnDevelopmentTeam.Visible = false;
                BtnMentoringTeam.Visible = false;

                break;

            case 10:


                BtnProcessTeam.Visible = false;
                BtnHRTeam.Visible = false;
                BtnNurturingTeam.Visible = false;
                BtnAdministratio.Visible = false;
                BtnMarketingTeam.Visible = true;
                BtnDevelopmentTeam.Visible = false;
                BtnMentoringTeam.Visible = false;
                break;


            case 25:

                BtnProcessTeam.Visible = false;
                BtnHRTeam.Visible = false;
                BtnNurturingTeam.Visible = true;
                BtnAdministratio.Visible = false;
                BtnMarketingTeam.Visible = false;
                BtnDevelopmentTeam.Visible = false;
                BtnMentoringTeam.Visible = false;

                break;

            case 11:

                BtnProcessTeam.Visible = false;
                BtnHRTeam.Visible = false;
                BtnNurturingTeam.Visible = false;
                BtnAdministratio.Visible = true;
                BtnMarketingTeam.Visible = false;
                BtnDevelopmentTeam.Visible = false;
                BtnMentoringTeam.Visible = false;

                break;


        }





        #region
        //if (CurrentUser.CurrentDesignationId==9)
        //{
        //    BtnProcessTeam.Visible = true;
        //    BtnHRTeam.Visible = true;
        //    BtnNurturingTeam.Visible = true;
        //    BtnAdministratio.Visible = true;
        //    BtnMarketingTeam.Visible = true;
        //    BtnDevelopmentTeam.Visible = true;
        //    BtnMentoringTeam.Visible = true;

        //}

        //if (obj.DesignationId == 3)
        //{
        //    Button7.Visible = true;
        //}
        //else
        //{
        //    Button1.Visible = false;
        //    Button2.Visible = false;
        //    Button3.Visible = false;
        //    Button4.Visible = false;
        //    Button5.Visible = false;
        //    Button6.Visible = false;
        //}

        //if (obj.DesignationId == 4)
        //{
        //    Button1.Visible = true;
        //}
        //else
        //{
        //    Button7.Visible = false;
        //    Button2.Visible = false;
        //    Button3.Visible = false;
        //    Button4.Visible = false;
        //    Button5.Visible = false;
        //    Button6.Visible = false;
        //}
        #endregion

    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("CMS.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        if (ddlLocation.Items.Count > 0)
        {
            clsLead obj = new clsLead();

            obj.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);

            obj.keywords = txtSearchByEmployee.Text;

            gv.DataSource = obj.LoadAllFollowups(obj);
            gv.DataBind();
        }
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("FollowUp.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdRegister")
        {
            Response.Redirect("LeadRegister.aspx?ItemId=" + e.CommandArgument);
        }
    }
    protected void BindLocation()
    {
        if (CurrentUser.IsAdmin == true)
        {
            clsLocation obj = new clsLocation();
            ddlLocation.DataSource = obj.LoadAll(obj);
            ddlLocation.DataTextField = "Location";
            ddlLocation.DataValueField = "LocationId";
            ddlLocation.DataBind();
            ddlLocation.Items.Insert(0, new ListItem("-- All Locations --", "0"));
        }
        else
        {
            clsUserLocation obj = new clsUserLocation();
            obj.UserId = CurrentUser.CurrentUserId;
            ddlLocation.DataSource = obj.LoadAll(obj);
            ddlLocation.DataTextField = "Location";
            ddlLocation.DataValueField = "LocationId";
            ddlLocation.DataBind();
        }
    }
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.DataItem != null)
            {
                string Date = e.Row.Cells[5].Text;

                foreach (TableCell cell in e.Row.Cells)
                {
                    if (Date != DateTime.UtcNow.AddHours(5).AddMinutes(30).ToString("dd-MM-yyyy"))
                    {
                        e.Row.Cells[5].ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        e.Row.Cells[5].ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
        }
    }
    protected void BindRole()
    {
        clsEmployee Item = new clsEmployee();
        Item = Item.Load(CurrentUser.CurrentEmployeeId);
        if (Item != null)
        {
            lilcontent.Text = Convert.ToString(Item.Roles);
        }
    }
    protected void BindNews()
    {
        CurrentUser CU = new CurrentUser();
        Int32 currentuserbranchid = CU.UserBranchId;
        if (currentuserbranchid == 19)
        {
            string strNews = string.Empty;
            List<clsBranchEmployeeNews> Items = new List<clsBranchEmployeeNews>();
            clsBranchEmployeeNews News = new clsBranchEmployeeNews();
            Items = News.LoadAll(News);
            if (Items != null)
            {
                foreach (clsBranchEmployeeNews item in Items)
                {
                    strNews = "<strong>" + strNews + "  " + item.NewsDescription + ";<strong>&nbsp;&nbsp;&nbsp;";
                }
                ltlNews.Text = strNews;
            }
        }
        else
        {
            string strNews = string.Empty;
            CurrentUser cu = new CurrentUser();
            Int32 UserBranchId = cu.UserBranchId;

            List<clsBranchEmployeeNews> Items = new List<clsBranchEmployeeNews>();
            clsBranchEmployeeNews News = new clsBranchEmployeeNews();
            News.BranchId = UserBranchId;
            Items = News.LoadAll_By_BranchId(News);
            if (Items != null)
            {
                foreach (clsBranchEmployeeNews item in Items)
                {
                    strNews = "<strong>" + strNews + "  " + item.NewsDescription + ";<strong>&nbsp;&nbsp;&nbsp;";
                }
                ltlNews.Text = strNews;
            }
        }
    }

    protected void BindRetakeExamData()
    {
        clsRetakeExam obj = new clsRetakeExam();
        obj.RetakeStatusId = 0;
        gvRetakeExam.DataSource = obj.LoadAll(obj);
        gvRetakeExam.DataBind();
    }
    protected void gvRetakeExam_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdAccept")
        {
            clsExam Item = new clsExam();
            int ItemId = Convert.ToInt32(e.CommandArgument);
            Item.Remove(ItemId);
            clsRetakeExam obj = new clsRetakeExam();
            GridViewRow gvrow = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
            obj.RetakeExamID = Convert.ToInt32(gvRetakeExam.DataKeys[gvrow.RowIndex].Value);
            obj.RetakeStatusId = 1;
            obj.ModifiedBy = CurrentUser.CurrentUserId;
            obj.UpdateStatus(obj);
            FormMessage.Text = "Request approved successfully";
            FormMessage.Visible = true;
            BindRetakeExamData();
        }
        if (e.CommandName == "cmdReject")
        {
            hdnRetakeExamId.Value = Convert.ToString(e.CommandArgument);
            Popup(true);
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        clsRetakeExam RetakeExam = new clsRetakeExam();
        RetakeExam.UserComments = txtComments.Text;
        RetakeExam.ModifiedBy = CurrentUser.CurrentUserId;
        RetakeExam.RetakeExamID = Convert.ToInt32(hdnRetakeExamId.Value);
        RetakeExam.RetakeStatusId = 2;
        RetakeExam.UpdateStatus(RetakeExam);
        ErrorMessage.Text = "Request rejected Successfully";
        ErrorMessage.Visible = true;
        BindRetakeExamData();
        Popup(false);
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Popup(false);
    }
    protected void Popup(bool isDisplay)
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        if (isDisplay)
        {
            builder.Append("<script language=JavaScript> ShowPopup(); </script>\n");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "ShowPopup", builder.ToString());
        }
        else
        {
            builder.Append("<script language=JavaScript> HidePopup(); </script>\n");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "HidePopup", builder.ToString());
        }
    }
    protected void ResumesCounts()
    {
        clsResumePreparation obj = new clsResumePreparation();
        obj = obj.MentorRequestsCount(obj);
        if (obj != null)
        {
            lblProcess.Text = obj.ResumesProcessCount.ToString();
            lblApprove.Text = obj.ResumesApprovedCount.ToString();
            lblResumeReq.Text = obj.SampleResumesRequests.ToString();
            lblQustnReq.Text = obj.InterviewQuestionRequests.ToString();
        }
    }
    protected void ShortlistedResumes()
    {
        clsResumePreparation obj = new clsResumePreparation();
        obj = obj.MentorRequestsCount(obj);
        if (obj != null)
        {
            litApproved.Text = obj.NotShortlistedResumes.ToString();
            litSampleQustns.Text = obj.InterviewQuestionRequests.ToString();
            litShortlisted.Text = obj.ShortlistedResumes.ToString();
        }
    }

  




    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProcessTeam.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("HRTeam.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingTeam.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Administratio.aspx");
    }


    protected void Button5_Click1(object sender, EventArgs e)
    {
        Response.Redirect("MarketingTeam.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("DevelopmentTeam.aspx");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("MentoringTeam.aspx");
    }

    protected void BindAward()
    {

        clsAssignAward obj = new clsAssignAward();
        if (CurrentUser.CurrentUserId == obj.UserId)
        {
            obj.UserId = Convert.ToInt32(CurrentUser.CurrentUserId);
        }
        obj.EmployeeId = CurrentUser.CurrentEmployeeId;
        GridViewAward.DataSource = obj.LoadAll(obj);
        GridViewAward.DataBind();
    }



}