using System;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ParticipantSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    //DateTime DateTime;
    
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //int PId = CurrentUser.CurrentParticipantId;
        if (!IsPostBack)
        {
            //datetime = datetime.utcnow.addhours(5).addminutes(30);
            //txttodate.text = datetime.tostring("dd/mm/yyyy");
            // gv.Visible = false;
            //BindCourse();
            //BindBatchType();
            BindLocation();
            BindTrainer();
            BindData();
        }
    }

    //protected void BindCourse()
    //{
    //    clsCourse obj = new clsCourse();
    //    ddlCourse.DataSource = obj.LoadAll(obj);
    //    ddlCourse.DataTextField = "Course";
    //    ddlCourse.DataValueField = "CourseId";
    //    ddlCourse.DataBind();
    //    ddlCourse.Items.Insert(0, new ListItem("-- Select Course --", "0"));
    //}

    //protected void BindBatchType()
    //{
    //    clsBatchType obj = new clsBatchType();
    //    ddlBatchType.DataSource = obj.LoadAll(obj);
    //    ddlBatchType.DataTextField = "BatchType";
    //    ddlBatchType.DataValueField = "BatchTypeId";
    //    ddlBatchType.DataBind();
    //    ddlBatchType.Items.Insert(0, new ListItem("-- Select Batch --", "0"));

    //}

    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("Search by Location", "0"));
    }

    protected void BindTrainer()
    {
        clsEmployee obj = new clsEmployee();
        obj.DesignationId = 2;
        ddlTrainer.DataSource = obj.LoadAll(obj);
        ddlTrainer.DataTextField = "Employee";
        ddlTrainer.DataValueField = "EmployeeId";
        ddlTrainer.DataBind();
        ddlTrainer.Items.Insert(0, new ListItem("Search by Trainer", "0"));
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Participant.aspx");
    }

    protected void BindData()
    {
        FormMessage.Visible = false;
        ErrorMessage.Visible = false;
        clsParticipant obj = new clsParticipant();
        if (txtSearch.Text.Length > 0)
        {
            obj.keywords = txtSearch.Text;
        }
        //obj.CourseId = Convert.ToInt16(ddlCourse.SelectedValue);
        //obj.BatchTypeId = Convert.ToInt16(ddlBatchType.SelectedValue);
        obj.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        obj.EmployeeId = Convert.ToInt16(ddlTrainer.SelectedValue);
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
        //gv.Caption = "Participants Batch From " + txtFromDate.Text + " To " + txtToDate.Text;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
       
    }

    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Participant.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdRequest")
        {
            Response.Redirect("PlacementRequest.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsParticipant Item = new clsParticipant();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Participant successfully removed";
            ErrorMessage.Visible = true;
        }
        else if (e.CommandName == "cmdSend")
        {
            int ItemId = Convert.ToInt16(e.CommandArgument);

            //Send User Credentials to Participant
            clsUser ItemUser = new clsUser();
            ItemUser = ItemUser.LoadByParticipantId(ItemId);
            clsParticipant Participant = new clsParticipant();
            Participant = Participant.Load(ItemId);

            //Send Email Asigned Features to Participant.
            clsParticipantFeatureAccess objFeature = new clsParticipantFeatureAccess();
            objFeature = objFeature.LoadParticipantAssignedFeatures(ItemId);
            if (objFeature != null)
            {
                objFeature.SendAssignedFeaturesToParticipant = objFeature.Feature.Replace("<TPM>", "").Replace("</TPM>", "").Replace("<Module>", "").Replace("</Module>", "").Replace("<T>", "").Replace("</T>", "").Replace("Feature", "li");
            }
            //Send Email Asigned ExamCategories to Participant.
            clsExamCategoryAssignment objCategory = new clsExamCategoryAssignment();            
            objCategory = objCategory.LoadByParticipantAssignedCategories(ItemId);
            if(objCategory!=null)
            {
                objCategory.SendAssignedExamCategoriesToParticipant = objCategory.Category.Replace("<ExamCategory>", "");
            }

            if (ItemUser != null  )
            {
                if(ItemUser.Username =="")
                {
                    ErrorMessage.Text = "Please Enter ReferenceNo ";
                    ErrorMessage.Visible = true;                  
                }
                else
                {
                    FormMessage.Text = ItemUser.Fullname + " Credentials successfully sent";
                    FormMessage.Visible = true;
                     #region "Send Email"

                    string strMessage = string.Empty;
                    //#region "old versition"
                    //strMessage = "Dear Mr./Ms. " + ItemUser.Fullname + ",<br /><br /><br />";
                    //strMessage = strMessage + "Greetings from COEPD !!!<br /><br />";
                    //strMessage = strMessage + "Please find the below COEPD Participant credentials.<br />";
                    //strMessage = strMessage + "Here you can get daily Job Openings, Documents and daily updates on trainings.<br /><br />";

                    //strMessage = strMessage + "Login : <a href=https://www.coepd.com/login.html>www.coepd.com/login.html</a><br />";
                    //strMessage = strMessage + "Username : " + ItemUser.Username + "<br />";
                    //strMessage = strMessage + "Password : " + ItemUser.Pwd + "<br /><br /><br />";

                    //strMessage = strMessage + "Please check and revert back if any assistance required.<br /><br /><br />";
                    //strMessage = strMessage + "Thanks & Regards<br />";
                    //strMessage = strMessage + "COEPD Team<br />";
                    //strMessage = strMessage + "+91 99635 55711<br />";
                    //strMessage = strMessage + "+91 40 66612216<br />";
                    //strMessage = strMessage + "dhileep.coepd@gmail.com<br />";
                    //strMessage = strMessage + "<a href=https://www.coepd.com>www.coepd.com</a><br />";

                    //strMessage = strMessage + "<a href=https://www.coepd.com><img src='https://www.coepd.com/img/logo.png'></a><br />";
                    //#endregion

                    #region "New vertion"

                    strMessage = "<p style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Dear Mr./Ms. " + ItemUser.Fullname + ",</p>";
                    strMessage = strMessage + "<p style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Greetings from COEPD !!!</p>";
                    strMessage = strMessage + "<p style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Please find below credentials for Portal, Blog, Forums.</p>";
                    //strMessage = strMessage + "<p style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Congratulations on kick starting your journey on Business Analysis by attending the Business Analyst Training Program.</p>";
                    //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Now it&#39;s time to start the next phase -&nbsp;<b><i>THE&nbsp;MENTORING&nbsp;PROCESS</i></b>.</p>";
                    //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'><strong><em>Why&nbsp;Mentoring&nbsp;Process?</em></strong></p>";
                    //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Job is a consequence of your acquired or gained knowledge. Before attending interview, you should make sure that you speak Business Analyst Language and act and contribute like a Business Analyst. It is just like a stage show. The more you practice, the better you can impress your audience (interviewers/ recruiters). We understand that you have some prior work experience but we want you to justify BA knowledge rather than your past experience. Kindly follow the success mantra aligned to achieve your Goal by expert services at each phase of the&nbsp;process.</p>";
                    //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Kindly make sure that you score minimum 7 points out of 10 in all Activities (evaluated by Mentors).</p>";
                    //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>If you score less, kindly repeat that activity until you score 7 points.</p>";
                    //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Please find below, the Activities of&nbsp;<strong><em>THE&nbsp;MENTORING&nbsp;PROCESS</em></strong>.</p>";
                    //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Take minimum 3 Examinations (descriptive) with at least 80% score in 2.</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Prepare UML diagrams (Minimum 10 No&rsquo;s) such as Use case along with Specification Documents &amp; Activity diagrams for our Workbook Case studies/ Generic case Studies and get it evaluated by the Mentors.</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Work on following BA Tools for minimum 3 Workbook Case Studies/Generic Case Studies and get it evaluated by the Mentors.</p>";
                    //strMessage = strMessage + "<ol style='list-style-type:none'>";
                    //strMessage = strMessage + "<li ><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>a. MS Visio </p></li><li><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>b. Axure</p></li><li><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>c. Balsamiq Mockups</p></li>";
                    //strMessage = strMessage + "</ol>";
                    //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Write and Post minimum 3 Blogs in our COEPD Blog Portal.</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Participate in minimum 10 Forums (Either New Topics or Existed Topics).</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Work on Documents like BRD, FRD, RTM and Understanding Documents for minimum 2 Workbook Case Studies/ Generic Case Studies and get it evaluated by Mentors.</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Projects/Domain Selection(If Any) by the Mentors.</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Assistance/Guidance in Resume Preparation.</p>";
                    //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For Selected Projects, repeat 2, 3 and 6 phases in&nbsp; Mentoring &nbsp; process.</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'> 10.&nbsp; Attend Mock Interviews </p> ";
                    //strMessage = strMessage + "<ol style='list-style-type:none'>";
                    //strMessage = strMessage + "<li><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>a. HR</p></li><li><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>b.Technical</p></li><li><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>c. Techno-Functional</p></li>";
                    //strMessage = strMessage + "</ol>";
                    //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Find below attachment.</p>";
                    strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'><strong><em><u>COEPD Web Portal Login credentials:</u></em></strong></p><p style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Here you can get daily Job Openings, Documents and daily updates on trainings.</p>";
                    strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Login :&nbsp;<a  href='https://www.coepd.com/login.html' target='_blank'>www.coepd.com/login.html</a><br />";
                    strMessage = strMessage + "Username :  " + ItemUser.Username + "<br />";
                    strMessage = strMessage + "Password : " + ItemUser.Pwd + "</p>";
                    strMessage = strMessage + "<p style='color: red;'> <strong>Note:</strong> Blogs and Forums login Credentials will be activated after completing waterfall and agile project</p>";
                    strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'><strong><em><u>Blogs Credentials(Refer Mentoring Phase No. 4):</u></em></strong></p><p style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Here you can post your own blogs and make some comments to other blogs as well.</p>";
                    strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Blogs Login :<a  href='http://blog.coepd.com/wp-login.php' target='_blank'>http://blog.coepd.com/wp-login.php<wbr />/login.aspx</a></p>";
                    strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Username :  " + ItemUser.Username + "<br />Password : " + ItemUser.Pwd + "</p>";
                    strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'><strong><em><u>Forums Credentials(Refer Mentoring Phase No. 5):</u></em></strong></p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Here you can contribute your acquired BA knowledge and give &amp; take inputs from group members.</p>";
                    strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Forums Login :<a  href='http://forum.coepd.com/' target='_blank'>http://forum.coepd.com</a>&nbsp;</p>";
                    strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Username :  " + ItemUser.Username + "<br />Password : " + ItemUser.Pwd + "</p>";

                    if (objFeature != null)
                    {
                        strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'><strong><em><u>Assigned Features:</u></em></strong></p>";
                        strMessage = strMessage + objFeature.SendAssignedFeaturesToParticipant + "<br/>";

                    }
                    if (objCategory != null)
                    {
                        strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'><strong><em><u>Assigned Exam Categories:</u></em></strong></p>";
                        strMessage = strMessage + objCategory.SendAssignedExamCategoriesToParticipant + "<br/>";
                    }

                    //strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>&nbsp;</p><P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'><strong><em>Note:&nbsp;</em></strong>In&nbsp;Resume Projections&nbsp;you can use&nbsp;<strong><em>Active Blogger</em></strong>&nbsp;keyword by participating in these Blogs.</p>";
                    strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Please revert if you need any further clarifications.</p>";
                    strMessage = strMessage + "<P style=' font-family: Georgia;color:rgb(34, 34, 34);font-size: 17px;'>Thanks &amp; Regards,</p>";
                    strMessage = strMessage + "<hr style='border-color: red; width: 1000px; margin: 0; ' >";
                    strMessage = strMessage + "<h3 >Mentoring Team</h3>";
                    strMessage = strMessage + "<p ><span >Mobile (India): +91&nbsp;<span >83744 21444<span >&nbsp;<span >|<span >&nbsp;<span >Desk: +91 40 66612216 Ext-24<span >&nbsp;<span >|<span >&nbsp;<span ></p><p ><a href='https://www.coepd.com/' target='_blank'>www.coepd.com</a>&nbsp;|&nbsp;<a href='mailto:NurtureBA@coepd.com' target='_blank'>NurtureBA@coepd.com</a>&nbsp; &nbsp; &nbsp;&nbsp;</p><hr style='border-color: red;width: 1000px ;margin:0;' >";



                    #endregion

                    string strSubject = "COEPD Portal Access, Blog, Forums - Mr./ Ms. " + ItemUser.Fullname;

                    Alerts.SendEmail(Participant.Email, strSubject, strMessage);
                    Alerts.SendEmail("nurtureba@coepd.com", strSubject, strMessage);
                    FormMessage.Text = ItemUser.Fullname + " Credentials successfully sent";
                    FormMessage.Visible = true;
                    ErrorMessage.Visible = false;
                    //lblMessage.Text = ItemUser.Username + " credentials successfully sent";
                    //lblMessage.Visible = true;
                    #endregion 
                }

            }
        }
        else if (e.CommandName == "cmdDownload")
        {
            string FilePath = Server.MapPath("~/UserDocs/Participant/" + e.CommandArgument);
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(FilePath));
            Response.WriteFile(FilePath);


        }
        else if (e.CommandName == "cmdAssignDefaultFeatures")
        {
            int[] FeatureIds = { 10, 12, 13, 14, 17, 18 };
            int PartcipantId = Convert.ToInt32(e.CommandArgument);
            int CountNo = 0;
            clsParticipantFeatureAccess Obj = new clsParticipantFeatureAccess();
            foreach (int i in FeatureIds)
            {
                Obj.ParticipantId = PartcipantId;
                Obj.FeatureId = i;
                Obj.CreatedBy = CurrentUser.CurrentUserId;
                CountNo = Obj.ParticipantFeatureValidation(Obj);
                if(CountNo == 0)
                {
                    Obj.AddUpdate(Obj);
                }
                
            }
            clsExamCategoryAssignment ObjECA = new clsExamCategoryAssignment();
            ObjECA.ParticipantId = PartcipantId;
            ObjECA.CategoryId = 1;
            ObjECA.CreatedBy = CurrentUser.CurrentUserId;
            int CategoryCountNO = 0;
            CategoryCountNO = ObjECA.Validation(ObjECA);
            if(CategoryCountNO == 0)
            {
                ObjECA.AddUpdate(ObjECA);
            }
            FormMessage.Text = "Default Features Assigned successfully";
            FormMessage.Visible = true;
            ErrorMessage.Visible = false;

        }
    }

    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton lnkDownload = (LinkButton)e.Row.FindControl("lnkDownload");
            HiddenField hdnCertificatePath = (HiddenField)e.Row.FindControl("hdnCertificatePath");

            if (hdnCertificatePath.Value.Length > 0)
            {
                lnkDownload.Visible = true;
            }
            if (CurrentUser.CurrentEmployeeId == 1 || CurrentUser.CurrentEmployeeId == 2)
            {
                LinkButton lnk = (LinkButton)e.Row.FindControl("lnkDelete");
                lnk.Visible = true;
            }
            else
            {
                LinkButton lnk = (LinkButton)e.Row.FindControl("lnkDelete");
                lnk.Visible = false;
            } 

        }
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        FormMessage.Visible = false;
        ErrorMessage.Visible = false;
        BindData();
    }

    protected void ddlCourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        FormMessage.Visible = false;
        ErrorMessage.Visible = false;
        BindData();
    }

    protected void ddlBatchType_SelectedIndexChanged(object sender, EventArgs e)
    {
        FormMessage.Visible = false;
        ErrorMessage.Visible = false;
        BindData();
    }

    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        FormMessage.Visible = false;
        ErrorMessage.Visible = false;
        BindData();
    }

    protected void ddlTrainer_SelectedIndexChanged(object sender, EventArgs e)
    {
        FormMessage.Visible = false;
        ErrorMessage.Visible = false;
        BindData();
    }


    protected void gv_PreRender(object sender, EventArgs e)
    {
        PageNumberHeader.Text = "Displaying Page" + (gv.PageIndex + 1).ToString() + "of" + gv.PageCount.ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = "Displaying Page" + (gv.PageIndex + 1).ToString() + "of" + gv.PageCount.ToString();
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }

    protected void txtFromDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtToDate_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }
}