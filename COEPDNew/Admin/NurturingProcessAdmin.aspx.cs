using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_NurturingProcessAdmin : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsNurturingProcess Item;
    int ItemId = 0;
    clsNurturingChat ItemNurturingChat;
    int NurturingChatId = 0;
    string Message = "";
    int NurturingProcessStageId = 0;
    int NurturingProcessStageTaskId = 0;
    int ParticipantId = 0;
    int CountNO = 0;
    int UserId = 0;
    int EmployeeId = 0;
    // int NurtureTypeLinkId = 0;
    int StageCountNo = 0;

    //int TotalBAConceptsRevision = 0;
    int TotalCapstoneProjects = 0;
    int TotalProfileBuilding = 0;
    int TotalWaterfallModel = 0;
    int TotalAgileScrumModel = 0;
    int TotalBAExposure = 0;
    int TotalMocks = 0;
    int TotalResume = 0;
    int TotalInterviewReady = 0;
    //int CountBAConceptsRevision = 0;
    int CountCapstoneProjects = 0;
    int CountProfileBuilding = 0;
    int CountWaterfallModel = 0;
    int CountAgileScrumModel = 0;
    int CountBAExposure = 0;
    int CountMocks = 0;
    int CountResume = 0;
    int CountInterviewReady = 0;
    int NurturingProcessStageStatusId = 0;
    DateTime SlotDate;

    int StatusCode = 0;
    int StatusDashboardCount = 0;
    int ParticipantStatusDashboardId = 0;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        UserId = CurrentUser.CurrentUserId;
        EmployeeId = CurrentUser.CurrentEmployeeId;
        Item = new clsNurturingProcess();

        if (!IsPostBack)
        {
            BindNurturingProcessStage();
            // BindNurturingProcessStageTask();

            if (ItemId > 0)
            {
                divParticipant.Visible = false;

                lblTitle.Text = "Edit Nurturing Process Stage Task Details";

                Item = Item.Load(ItemId);

                if (Item != null)
                {
                    BindParticipant();
                    ddlParticipant.SelectedValue = Item.ParticipantId.ToString();
                    ddlParticipant.Enabled = false;
                    ddlNurturingProcessStage.SelectedValue = Item.NurturingProcessStageId.ToString();
                    ddlNurturingProcessStage.Enabled = false;
                    BindNurturingProcessStageTask();
                    ddlNurturingProcessStageTask.SelectedValue = Item.NurturingProcessStageTaskId.ToString();
                    ddlNurturingProcessStageTask.Enabled = false;
                    BindData();
                    BindNurturingTasksInputsData();
                    //ReqFileUpload.Enabled = false;
                    txtMarks.Text = Item.ExamScore.ToString();
                    txtNotes.Text = Item.Notes;
                    txtTargetDate.Text = Item.TargetDate.ToString("dd/MM/yyyy");
                    txtSlot.Enabled = false;
                    if (Item.NurturingProcessSlotsId > 0)
                    {
                        hdnNurturingProcessSlotsId.Value = Item.NurturingProcessSlotsId.ToString();
                        clsNurturingProcessSlots NurturingProcessSlots = new clsNurturingProcessSlots();
                        NurturingProcessSlots = NurturingProcessSlots.Load(Convert.ToInt32(Item.NurturingProcessSlotsId));
                        if (NurturingProcessSlots != null)
                        {
                            DateTime DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(40);
                            DateTime SlotStartTime = Convert.ToDateTime(NurturingProcessSlots.SlotStartTime);
                            //string DatetimeVisibleEndTime = DateTime.ToString("dd-mm-yyyy") + " " + "23:59:00 PM";

                            //DateTime SlotVisibleEndTime = Convert.ToDateTime(DatetimeVisibleEndTime);

                            //txtSlot.Text = NurturingProcessSlots.SlotDate.ToString("dd MMM yyyy") + " - " + NurturingProcessSlots.StartEndTime;
                            txtSlot.Text = NurturingProcessSlots.SlotDate + " - " + NurturingProcessSlots.StartEndTime;

                            if (DateTime >= SlotStartTime)
                            {
                                btnApprove.Enabled = true;
                                btnSubmit.Enabled = true;
                            }
                            else
                            {
                                btnApprove.Enabled = false;
                                btnSubmit.Enabled = false;
                            }
                        }
                    }

                    //txtTargetDate.Enabled = false;
                    if (Item.SenderImagePath != "")
                    {
                        hplSentFile.NavigateUrl = "~/UserDocs/NurturingProcess/" + Item.SenderImagePath;
                    }
                    else
                    {
                        hplSentFile.Visible = false;
                    }
                    if (Item.ReceiverImagePath != "")
                    {
                        hplReplyFile.NavigateUrl = "~/UserDocs/NurturingProcess/" + Item.ReceiverImagePath;
                    }
                    else
                    {
                        hplReplyFile.Visible = false;
                    }

                    if (Item.ExamDate == null)
                    {
                        divMarks.Visible = false;
                        btnApprove.Visible = false;
                    }
                    if (Item.IsApproved == true)
                    {
                        btnApprove.Visible = false;
                        btnSubmit.Visible = false;
                        txtMarks.Enabled = false;
                        txtNotes.Enabled = false;
                        divUpload.Visible = false;
                        lblSlot.Visible = false;
                        txtSlot.Visible = false;
                        txtTargetDate.Enabled = false;
                    }


                }
            }
            else
            {
                lblTitle.Text = "Add Nurturing Process Stage Task";
                btnApprove.Visible = false;
                ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant -- ", ""));
                divMarks.Visible = false;
                divAttachments.Visible = false;
                //divMenterinputs.Visible = false;
                lblSlot.Visible = false;
                txtSlot.Visible = false;
            }
        }
    }
    protected void BindParticipant()
    {
        ddlParticipant.Items.Clear();
        clsParticipant obj = new clsParticipant();
        obj.keywords = txtSearch.Text;
        ddlParticipant.DataSource = obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Participant";
        ddlParticipant.DataValueField = "ParticipantId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant -- ", ""));
    }
    protected void BindNurturingProcessStage()
    {
        clsNurturingProcessStage obj = new clsNurturingProcessStage();
        ddlNurturingProcessStage.DataSource = obj.LoadAll(obj);
        ddlNurturingProcessStage.DataTextField = "NurturingProcessStageName";
        ddlNurturingProcessStage.DataValueField = "NurturingProcessStageId";
        ddlNurturingProcessStage.DataBind();
        ddlNurturingProcessStage.Items.Insert(0, new ListItem("---Select Nurturing Process Stage---", ""));
    }
    protected void ddlNurturingProcessStage_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlNurturingProcessStage.SelectedValue != null)
            BindNurturingProcessStageTask();
    }
    protected void BindNurturingProcessStageTask()
    {
        ddlNurturingProcessStageTask.Items.Clear();
        if (ddlNurturingProcessStage.SelectedValue != "")
        {
            clsNurturingProcessStageTask obj = new clsNurturingProcessStageTask();
            obj.NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
            ddlNurturingProcessStageTask.DataSource = obj.LoadAll(obj);
            ddlNurturingProcessStageTask.DataTextField = "NurturingProcessStageTaskName";
            ddlNurturingProcessStageTask.DataValueField = "NurturingProcessStageTaskId";
            ddlNurturingProcessStageTask.DataBind();
            ddlNurturingProcessStageTask.Items.Insert(0, new ListItem("-- Select Nurturing Process Stage Task -- ", ""));
        }

    }

    //protected void btnSearch_Click(object sender, EventArgs e)
    //{
    //    ddlParticipant.Items.Clear();
    //    ddlParticipant.Items.Insert(0, new ListItem("-- Select participant -- ", ""));
    //    if (txtSearch.Text != "")
    //    {
    //        BindParticipant();
    //    }
    //}

    protected void BindNurturingProcessStageStatus()
    {
        ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
        clsNurturingProcessStageTask NPST = new clsNurturingProcessStageTask();
        NPST.ParticipantId = ParticipantId;
        NPST = NPST.NurturingDashboardCount(NPST);
        //TotalBAConceptsRevision = NPST.TotalBAConceptsRevision;
        TotalCapstoneProjects = NPST.TotalCapstoneProjects;
        TotalProfileBuilding = NPST.TotalProfileBuilding;
        TotalWaterfallModel = NPST.TotalWaterfallModel;
        TotalAgileScrumModel = NPST.TotalAgileScrumModel;
        TotalBAExposure = NPST.TotalBAExposure;
        TotalMocks = NPST.TotalMocks;
        TotalResume = NPST.TotalResume;
        TotalInterviewReady = NPST.TotalInterviewReady;
        //CountBAConceptsRevision = NPST.CountBAConceptsRevision;
        CountCapstoneProjects = NPST.CountCapstoneProjects;
        CountProfileBuilding = NPST.CountProfileBuilding;
        CountWaterfallModel = NPST.CountWaterfallModel;
        CountAgileScrumModel = NPST.CountAgileScrumModel;
        CountBAExposure = NPST.CountBAExposure;
        CountMocks = NPST.CountMocks;
        CountResume = NPST.CountResume;
        CountInterviewReady = NPST.CountInterviewReady;
        NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
        if (NurturingProcessStageId == 2)
        {
            if (CountCapstoneProjects == TotalCapstoneProjects)
            {
                clsNurturingProcessStageStatus StageObj = new clsNurturingProcessStageStatus();
                StageObj.ParticipantId = ParticipantId;
                StageObj.NurturingProcessStageId = NurturingProcessStageId;
                if (StageObj.ParticipantId > 0)
                {
                    StageObj = StageObj.LoadNurturingProcessStageStatusId(StageObj.ParticipantId, StageObj.NurturingProcessStageId);
                    if (StageObj != null)
                    {
                        NurturingProcessStageStatusId = Convert.ToInt32(StageObj.NurturingProcessStageStatusId);

                    }

                }
            }
        }
        else if (NurturingProcessStageId == 3)
        {
            if (CountProfileBuilding == TotalProfileBuilding)
            {
                clsNurturingProcessStageStatus StageObj = new clsNurturingProcessStageStatus();
                StageObj.ParticipantId = ParticipantId;
                StageObj.NurturingProcessStageId = NurturingProcessStageId;
                if (StageObj.ParticipantId > 0)
                {
                    StageObj = StageObj.LoadNurturingProcessStageStatusId(StageObj.ParticipantId, StageObj.NurturingProcessStageId);
                    if (StageObj != null)
                    {
                        NurturingProcessStageStatusId = Convert.ToInt32(StageObj.NurturingProcessStageStatusId);

                    }

                }
            }
        }
        else if (NurturingProcessStageId == 4)
        {
            if (CountWaterfallModel == TotalWaterfallModel)
            {
                clsNurturingProcessStageStatus StageObj = new clsNurturingProcessStageStatus();
                StageObj.ParticipantId = ParticipantId;
                StageObj.NurturingProcessStageId = NurturingProcessStageId;
                if (StageObj.ParticipantId > 0)
                {
                    StageObj = StageObj.LoadNurturingProcessStageStatusId(StageObj.ParticipantId, StageObj.NurturingProcessStageId);
                    if (StageObj != null)
                    {
                        NurturingProcessStageStatusId = Convert.ToInt32(StageObj.NurturingProcessStageStatusId);

                    }

                }
            }
        }
        else if (NurturingProcessStageId == 5)
        {
            if (CountAgileScrumModel == TotalAgileScrumModel)
            {
                clsNurturingProcessStageStatus StageObj = new clsNurturingProcessStageStatus();
                StageObj.ParticipantId = ParticipantId;
                StageObj.NurturingProcessStageId = NurturingProcessStageId;
                if (StageObj.ParticipantId > 0)
                {
                    StageObj = StageObj.LoadNurturingProcessStageStatusId(StageObj.ParticipantId, StageObj.NurturingProcessStageId);
                    if (StageObj != null)
                    {
                        NurturingProcessStageStatusId = Convert.ToInt32(StageObj.NurturingProcessStageStatusId);

                    }

                }
            }
        }
        else if (NurturingProcessStageId == 6)
        {
            if (CountBAExposure == TotalBAExposure)
            {
                clsNurturingProcessStageStatus StageObj = new clsNurturingProcessStageStatus();
                StageObj.ParticipantId = ParticipantId;
                StageObj.NurturingProcessStageId = NurturingProcessStageId;
                if (StageObj.ParticipantId > 0)
                {
                    StageObj = StageObj.LoadNurturingProcessStageStatusId(StageObj.ParticipantId, StageObj.NurturingProcessStageId);
                    if (StageObj != null)
                    {
                        NurturingProcessStageStatusId = Convert.ToInt32(StageObj.NurturingProcessStageStatusId);

                    }

                }
            }
        }
        else if (NurturingProcessStageId == 7)
        {
            if (CountMocks == TotalMocks)
            {
                clsNurturingProcessStageStatus StageObj = new clsNurturingProcessStageStatus();
                StageObj.ParticipantId = ParticipantId;
                StageObj.NurturingProcessStageId = NurturingProcessStageId;
                if (StageObj.ParticipantId > 0)
                {
                    StageObj = StageObj.LoadNurturingProcessStageStatusId(StageObj.ParticipantId, StageObj.NurturingProcessStageId);
                    if (StageObj != null)
                    {
                        NurturingProcessStageStatusId = Convert.ToInt32(StageObj.NurturingProcessStageStatusId);

                    }

                }
            }
        }
        else if (NurturingProcessStageId == 8)
        {
            if (CountResume == TotalResume)
            {
                clsNurturingProcessStageStatus StageObj = new clsNurturingProcessStageStatus();
                StageObj.ParticipantId = ParticipantId;
                StageObj.NurturingProcessStageId = NurturingProcessStageId;
                if (StageObj.ParticipantId > 0)
                {
                    StageObj = StageObj.LoadNurturingProcessStageStatusId(StageObj.ParticipantId, StageObj.NurturingProcessStageId);
                    if (StageObj != null)
                    {
                        NurturingProcessStageStatusId = Convert.ToInt32(StageObj.NurturingProcessStageStatusId);

                    }

                }
            }
        }
        else if (NurturingProcessStageId == 9)
        {
            if (CountInterviewReady == TotalInterviewReady)
            {
                clsNurturingProcessStageStatus StageObj = new clsNurturingProcessStageStatus();
                StageObj.ParticipantId = ParticipantId;
                StageObj.NurturingProcessStageId = NurturingProcessStageId;
                if (StageObj.ParticipantId > 0)
                {
                    StageObj = StageObj.LoadNurturingProcessStageStatusId(StageObj.ParticipantId, StageObj.NurturingProcessStageId);
                    if (StageObj != null)
                    {
                        NurturingProcessStageStatusId = Convert.ToInt32(StageObj.NurturingProcessStageStatusId);

                    }

                }
            }
        }
        else
        {

        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BindDuplicateTask();
        if (CountNO > 0)
        {
            ddlNurturingProcessStageTask.SelectedIndex = -1;
            ErrorMessage.Text = "NurturingProcessStageTask already asigned to this participant";
            ErrorMessage.Visible = true;
            FormMessage.Visible = false;
        }
        else
        {
            if (EmployeeId > 0 || UserId > 0)
            {
                if (ItemId > 0)
                {
                    Item.NurturingProcessId = ItemId;
                    Item.EvaluatedBy = EmployeeId;
                    Item.EvaluatedOn = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                }
                Item.NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
                Item.NurturingProcessStageTaskId = Convert.ToInt16(ddlNurturingProcessStageTask.SelectedValue);
                Item.EmployeeId = EmployeeId;
                Item.AssignedEmployeeId = 0;
                Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
                Item.ApprovedBy = 0;
                if (txtMarks.Text != "")
                {
                    Item.ExamScore = Convert.ToDecimal(txtMarks.Text);
                }
                if (flUpload.HasFile)
                {
                    clsFileUpload Upload = new clsFileUpload();
                    string filePath = Upload.NurturingProcessUploadDoc(flUpload);
                    Item.SenderImagePath = filePath;
                }
                if (txtTargetDate.Text != "")
                {
                    DateTime Date = DateTime.ParseExact(txtTargetDate.Text, "dd/MM/yyyy", null);
                    Item.TargetDate = Convert.ToDateTime(Date);
                }
                Item.Notes = txtNotes.Text;
                Item.IsApproved = false;
                Item.CreatedBy = UserId;
                Item.AddUpdate(Item);
                int NurturingProcessSlotsId = Convert.ToInt32(hdnNurturingProcessSlotsId.Value);
                if (NurturingProcessSlotsId > 0)
                {
                    clsNurturingProcessSlots Obj = new clsNurturingProcessSlots();
                    Obj = Obj.Load(NurturingProcessSlotsId);
                    if (Obj != null)
                    {
                        SlotDate = Convert.ToDateTime(Obj.SlotDate);
                    }
                    Obj.NurturingProcessSlotsId = NurturingProcessSlotsId;
                    Obj.SlotDate = SlotDate;
                    Obj.CreatedBy = UserId;
                    Obj.IsSlotAssigned = true;
                    Obj.SlotsStatusId = 3;
                    Obj.AddUpdate(Obj);
                }

                flUpload.Enabled = false;
                txtNotes.Enabled = false;
                ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
                NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
                if (ParticipantId > 0 && NurturingProcessStageId > 0)
                {
                    clsNurturingProcessStageStatus StageObj = new clsNurturingProcessStageStatus();
                    StageObj.ParticipantId = ParticipantId;
                    StageObj.NurturingProcessStageId = NurturingProcessStageId;
                    StageCountNo = StageObj.LoadNurturingProcessStageStatusValidation(StageObj);
                    if (StageCountNo == 0)
                    {
                        StageObj.NurturingProcessStageId = NurturingProcessStageId;
                        StageObj.ParticipantId = ParticipantId;
                        StageObj.AddUpdate(StageObj);
                    }
                }



                if (ItemId > 0)
                {
                    FormMessage.Text = "Nurturing Process Stage Task Successfully Updated.";
                    FormMessage.Visible = true;
                    btnSubmit.Enabled = false;
                    ErrorMessage.Visible = false;
                }
                else
                {
                    clsParticipantStatusDashboard PSD = new clsParticipantStatusDashboard();
                    PSD.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
                    NurturingProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.SelectedValue);
                    if (NurturingProcessStageTaskId > 0)
                    {
                        clsNurturingProcessStageTask CNPST = new clsNurturingProcessStageTask();
                        CNPST = CNPST.Load(NurturingProcessStageTaskId);
                        if (CNPST != null)
                        {
                            StatusCode = CNPST.StatusCode;
                            PSD.StatusCode = StatusCode;
                            PSD.CreatedBy = CurrentUser.CurrentUserId;
                            PSD.AddUpdate(PSD);
                            clsParticipant CP = new clsParticipant();
                            CP.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
                            CP.StatusCode = StatusCode;
                            CP.AddUpdateStatusCode(CP);
                            //StatusDashboardCount = PSD.LoadParticipantStatusDashboardValidation(PSD);
                            //if (StatusDashboardCount == 0)
                            //{
                            //    PSD.CreatedBy = CurrentUser.CurrentUserId;
                            //    PSD.AddUpdate(PSD);
                            //    clsParticipant CP = new clsParticipant();
                            //    CP.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
                            //    CP.StatusCode = StatusCode;
                            //    CP.AddUpdateStatusCode(CP);
                            //}
                        }

                    }

                    btnSubmit.Enabled = false;
                    FormMessage.Text = "Nurturing Process Stage Task Successfully Saved";
                    FormMessage.Visible = true;
                    ErrorMessage.Visible = false;
                }

            }
            else
            {
                Response.Redirect("~/Login.html");
            }
        }



    }

    protected void btnApprove_Click(object sender, EventArgs e)
    {
        if (txtMarks.Text != "" && Convert.ToDecimal(txtMarks.Text) > Convert.ToDecimal(94))
        {
            if (ItemId > 0)
            {
                Item.NurturingProcessId = ItemId;
            }
            Item.NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
            Item.NurturingProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.SelectedValue);
            Item.EmployeeId = EmployeeId;
            Item.AssignedEmployeeId = 0;
            Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
            Item.ApprovedBy = EmployeeId;
            Item.ApprovedDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            Item.ExamScore = Convert.ToDecimal(txtMarks.Text);
            Item.Notes = txtNotes.Text;
            if (txtTargetDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtTargetDate.Text, "dd/MM/yyyy", null);
                Item.TargetDate = Convert.ToDateTime(Date);
            }
            Item.IsApproved = true;
            Item.CreatedBy = UserId;
            Item.AddUpdate(Item);

            int NurturingProcessSlotsId = Convert.ToInt32(hdnNurturingProcessSlotsId.Value);
            if (NurturingProcessSlotsId > 0)
            {
                clsNurturingProcessSlots Obj = new clsNurturingProcessSlots();
                Obj = Obj.Load(NurturingProcessSlotsId);
                if (Obj != null)
                {
                    SlotDate = Convert.ToDateTime(Obj.SlotDate);
                }
                Obj.NurturingProcessSlotsId = NurturingProcessSlotsId;
                Obj.SlotDate = SlotDate;
                Obj.CreatedBy = UserId;
                Obj.IsSlotAssigned = true;
                Obj.SlotsStatusId = 4;
                Obj.AddUpdate(Obj);
            }
            clsParticipantStatusDashboard PSD = new clsParticipantStatusDashboard();
            PSD.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
            NurturingProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.SelectedValue);
            if (NurturingProcessStageTaskId > 0)
            {
                clsNurturingProcessStageTask NPST = new clsNurturingProcessStageTask();
                NPST = NPST.Load(NurturingProcessStageTaskId);
                if (NPST != null)
                {
                    StatusCode = NPST.StatusCode;
                    PSD.StatusCode = StatusCode;
                    if (PSD.ParticipantId > 0 && PSD.StatusCode > 0)
                    {
                        PSD = PSD.LoadParticipantStatusCodeDashboardId(PSD.ParticipantId, PSD.StatusCode);
                        if (PSD != null)
                        {
                            ParticipantStatusDashboardId = Convert.ToInt32(PSD.ParticipantStatusDashboardId);
                        }
                        if (ParticipantStatusDashboardId > 0)
                        {
                            PSD.ParticipantStatusDashboardId = ParticipantStatusDashboardId;
                            PSD.CreatedBy = CurrentUser.CurrentUserId;
                            PSD.AddUpdate(PSD);
                        }

                    }
                }
            }

            //Response.Redirect("NurtureExamSearch.aspx");
            FormMessage.Text = "Exam Approved Successfully";
            FormMessage.Visible = true;
            ErrorMessage.Visible = false;
            btnApprove.Enabled = false;
            txtMarks.Enabled = false;
            txtNotes.Enabled = false;


        }
        else
        {
            ErrorMessage.Text = "Exam score should be Greater Than or Equal to 95 ";
            ErrorMessage.Visible = true;
            FormMessage.Visible = false;
        }
        BindNurturingProcessStageStatus();
        if (NurturingProcessStageStatusId > 0)
        {
            clsNurturingProcessStageStatus ObjStageExit = new clsNurturingProcessStageStatus();
            ObjStageExit.Exit(NurturingProcessStageStatusId);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingProcessSearch.aspx");
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (txtChat.Text.Length > 0)
        {
            ParticipantId = Convert.ToInt16(ddlParticipant.SelectedValue);
            NurturingProcessStageId = Convert.ToInt16(ddlNurturingProcessStage.SelectedValue);
            NurturingProcessStageTaskId = Convert.ToInt16(ddlNurturingProcessStageTask.SelectedValue);
            ItemNurturingChat = new clsNurturingChat();
            ItemNurturingChat.ParticipantId = ParticipantId;
            ItemNurturingChat.NurturingProcessStageTaskId = NurturingProcessStageTaskId;
            ItemNurturingChat = ItemNurturingChat.GetByPendingChat(ParticipantId, NurturingProcessStageTaskId);
            if (ItemNurturingChat != null)
            {
                NurturingChatId = Convert.ToInt32(ItemNurturingChat.NurturingChatId);
                Message = ItemNurturingChat.Chat;
            }
            if (NurturingChatId > 0)
            {

                clsNurturingChat ParticipantNurturingChatUpdate = new clsNurturingChat();
                ParticipantNurturingChatUpdate.NurturingChatId = NurturingChatId;
                ParticipantNurturingChatUpdate.EmployeeId = 0;
                ParticipantNurturingChatUpdate.ParticipantId = ParticipantId;
                ParticipantNurturingChatUpdate.Chat = Message;
                ParticipantNurturingChatUpdate.NurturingProcessStageId = NurturingProcessStageId;
                ParticipantNurturingChatUpdate.NurturingProcessStageTaskId = NurturingProcessStageTaskId;
                ParticipantNurturingChatUpdate.CreatedBy = CurrentUser.CurrentUserId;
                ParticipantNurturingChatUpdate.IsReplied = Convert.ToBoolean(1);
                ParticipantNurturingChatUpdate.AddUpdate(ParticipantNurturingChatUpdate);
            }

            clsNurturingChat ParticipantNurturingChat = new clsNurturingChat();
            ParticipantNurturingChat.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            ParticipantNurturingChat.ParticipantId = Convert.ToInt16(ddlParticipant.SelectedValue);
            ParticipantNurturingChat.Chat = txtChat.Text;
            ParticipantNurturingChat.NurturingProcessStageId = Convert.ToInt16(ddlNurturingProcessStage.SelectedValue);
            ParticipantNurturingChat.NurturingProcessStageTaskId = Convert.ToInt16(ddlNurturingProcessStageTask.SelectedValue);
            ParticipantNurturingChat.CreatedBy = CurrentUser.CurrentUserId;
            ParticipantNurturingChat.IsReplied = Convert.ToBoolean(1);
            ParticipantNurturingChat.AddUpdate(ParticipantNurturingChat);
            txtChat.Text = "";
            FormMessage.Text = "Your request is successfully sent.";
            FormMessage.Visible = true;
            Response.Redirect("NurturingProcess.aspx?ItemId=" + ItemId);
        }
    }
    protected void BindData()
    {
        clsNurturingChat Item = new clsNurturingChat();
        Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
        Item.NurturingProcessStageTaskId = Convert.ToInt16(ddlNurturingProcessStageTask.SelectedValue);
        rp.DataSource = Item.LoadAll(Item);
        rp.DataBind();

    }

    protected void rp_OnItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        RepeaterItem item = e.Item;
        if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
        {
            HiddenField hdnRoleId = (HiddenField)item.FindControl("hdnRoleId");
            int RoleId = Convert.ToInt16(hdnRoleId.Value);

            if (RoleId == 2)
            {
                Panel pnlIn = (Panel)item.FindControl("pnlIn");
                pnlIn.Visible = true;
            }
            else
            {
                Panel PnlOut = (Panel)item.FindControl("PnlOut");
                PnlOut.Visible = true;
            }
        }
    }
    protected void BindDuplicateTask()
    {
        if (ItemId == 0)
        {
            if (ddlParticipant.SelectedValue != "" & ddlNurturingProcessStageTask.SelectedValue != "")
            {
                Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
                Item.NurturingProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.SelectedValue);
                CountNO = Item.LoadNurturingProcessValidation(Item);
                if (CountNO > 0)
                {
                    ddlNurturingProcessStageTask.SelectedIndex = -1;
                    ErrorMessage.Text = "NurturingProcessStageTask already asigned to this participant";
                    ErrorMessage.Visible = true;
                    FormMessage.Visible = false;
                }
                else
                {
                    ErrorMessage.Visible = false;
                }
            }

        }
    }

    protected void ddlNurturingProcessStageTask_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDuplicateTask();
    }

    protected void ddlParticipant_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDuplicateTask();
        BindNurturingTasksInputsData();
    }

    protected void btnBackToSlots_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingAvilableSlotsSearch.aspx");
    }
    protected void BindNurturingTasksInputsData()
    {
        clsNurturingChat Item = new clsNurturingChat();
        Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
        rpNurturingTeamInputs.DataSource = Item.LoadAllTasks(Item);
        rpNurturingTeamInputs.DataBind();
    }
    protected void rpNurturingTeamInputs_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        RepeaterItem item = e.Item;
        if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
        {
            HiddenField hdnRoleId = (HiddenField)item.FindControl("hdnNurturingTeamInputsRoleId");
            int RoleId = Convert.ToInt16(hdnRoleId.Value);
            if (RoleId == 3)
            {
                Panel pnlIn = (Panel)item.FindControl("pnlIn");
                pnlIn.Visible = true;
            }
            else
            {
                Panel PnlOut = (Panel)item.FindControl("PnlOut");
                PnlOut.Visible = true;
            }
        }
    }

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        ddlParticipant.Items.Clear();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select participant -- ", ""));
        if (txtSearch.Text != "")
        {
            BindParticipant();
        }
    }
}