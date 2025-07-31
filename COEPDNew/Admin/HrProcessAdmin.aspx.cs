using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_HrProcessAdmin : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsHrProcess Item;


    int ItemId = 0;
    clsHrChat ItemNurturingChat;
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
        Item = new clsHrProcess();

        if (!IsPostBack)
        {
            BindNurturingProcessStage();
            // BindNurturingProcessStageTask();

            if (ItemId > 0)
            {
                divParticipant.Visible = false;

                lblTitle.Text = "Edit Hr Process Stage Task Details";

             //   Item = Item.Load(ItemId);

                if (Item != null)
                {
                    BindParticipant();
                    ddlParticipant.SelectedValue = Item.ParticipantId.ToString();
                    ddlParticipant.Enabled = false;
                    ddlNurturingProcessStage.SelectedValue = Item.HrProcessStageId.ToString();
                    ddlNurturingProcessStage.Enabled = false;
                    BindNurturingProcessStageTask();
                    ddlNurturingProcessStageTask.SelectedValue = Item.HrProcessStageTaskId.ToString();
                    ddlNurturingProcessStageTask.Enabled = false;
                    BindData();
                    BindNurturingTasksInputsData();
                    //ReqFileUpload.Enabled = false;
                    txtMarks.Text = Item.ExamScore.ToString();
                    txtNotes.Text = Item.Notes;
                    txtTargetDate.Text = Item.TargetDate.ToString("dd/MM/yyyy");
                    txtSlot.Enabled = false;
                    if (Item.HrProcessSlotsId > 0)
                    {
                        hdnNurturingProcessSlotsId.Value = Item.HrProcessSlotsId.ToString();

                        clsHrProcessSlots NurturingProcessSlots = new clsHrProcessSlots();
                        NurturingProcessSlots = NurturingProcessSlots.Load(Convert.ToInt32(Item.HrProcessSlotsId));
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
                        
                        lblSlot.Visible = false;
                        txtSlot.Visible = false;
                        txtTargetDate.Enabled = false;
                    }


                }
            }
            else
            {
                lblTitle.Text = "Add Hr Process Stage Task";
                btnApprove.Visible = false;
                ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant -- ", ""));
                divMarks.Visible = false;
               
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
        clsHrProcessStage obj = new clsHrProcessStage();
        ddlNurturingProcessStage.DataSource = obj.LoadAll(obj);
        ddlNurturingProcessStage.DataTextField = "HrProcessStageName";
        ddlNurturingProcessStage.DataValueField = "HrProcessStageId";
        ddlNurturingProcessStage.DataBind();
        ddlNurturingProcessStage.Items.Insert(0, new ListItem("---Select Hr Process Stage---", ""));
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
            clsHrProcessStageTask obj = new clsHrProcessStageTask();
            obj.HrProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
            obj.HrProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
            ddlNurturingProcessStageTask.DataSource = obj.LoadAll(obj);
            ddlNurturingProcessStageTask.DataTextField = "HrProcessStageTaskName";
            ddlNurturingProcessStageTask.DataValueField = "HrProcessStageTaskId";
            ddlNurturingProcessStageTask.DataBind();
            ddlNurturingProcessStageTask.Items.Insert(0, new ListItem("-- Select Hr Process Stage Task -- ", ""));
            ddlNurturingProcessStageTask.SelectedValue = Convert.ToString(obj.HrProcessStageTaskId);
            ddlNurturingProcessStageTask.Enabled = false;

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

    protected void BindDuplicateTask()
    {


        if (ItemId == 0)
        {
            if (ddlParticipant.SelectedValue != "" & ddlNurturingProcessStageTask.SelectedValue != "")
            {
                Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
                Item.HrProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.SelectedValue);
                CountNO = Item.LoadHrProcessValidation(Item);
                if (CountNO > 0)
                {
                    ddlNurturingProcessStageTask.SelectedIndex = -1;
                    ErrorMessage.Text = "HrProcessStageTask already asigned to this participant";
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

    protected void BindNurturingTasksInputsData()
    {
        clsHrChat Item = new clsHrChat();
        Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
        rpNurturingTeamInputs.DataSource = Item.LoadAllTasks(Item);
        rpNurturingTeamInputs.DataBind();
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
        clsHrProcessStageTask NPST = new clsHrProcessStageTask();
        NPST.ParticipantId = ParticipantId;
        NPST = NPST.HrDashboardCount(NPST);
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
                clsHrProcessStageStatus StageObj = new clsHrProcessStageStatus();
                StageObj.ParticipantId = ParticipantId;
                StageObj.HrProcessStageId = NurturingProcessStageId;
                if (StageObj.ParticipantId > 0)
                {
                    StageObj = StageObj.LoadHrProcessStageStatusId(StageObj.ParticipantId, StageObj.HrProcessStageId);
                    if (StageObj != null)
                    {
                        NurturingProcessStageStatusId = Convert.ToInt32(StageObj.HrProcessStageStatusId);

                    }

                }
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        clsHrProcessSlots obj = new clsHrProcessSlots();
        BindDuplicateTask();
        if (CountNO > 0)
        {
            ddlNurturingProcessStageTask.SelectedIndex = -1;
            ErrorMessage.Text = "HrProcessStageTask already asigned to this participant";
            ErrorMessage.Visible = true;
            FormMessage.Visible = false;
        }
        else
        {
            if (EmployeeId > 0 || UserId > 0)
            {
                if (ItemId > 0)
                {
                    Item.HrProcessId = ItemId;
                    Item.EvaluatedBy = EmployeeId;
                    Item.EvaluatedOn = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                }
                Item.HrProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
                Item.HrProcessStageTaskId = Convert.ToInt16(ddlNurturingProcessStageTask.SelectedValue);
                Item.EmployeeId = EmployeeId;
                Item.AssignedEmployeeId = 0;
                Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
                Item.ApprovedBy = 0;
                if (txtMarks.Text != "")
                {
                    Item.ExamScore = Convert.ToDecimal(txtMarks.Text);
                }
               
                if (txtTargetDate.Text != "")
                {
                    DateTime Date = DateTime.ParseExact(txtTargetDate.Text, "dd/MM/yyyy", null);
                    Item.TargetDate = Convert.ToDateTime(Date);
                }
                Item.Notes = txtNotes.Text;
                Item.IsApproved = false;
                Item.CreatedBy = UserId;
                Item.HrProcessSlotsId = Convert.ToInt32(obj.HrProcessSlotsId);
                Item.AddUpdate(Item);
                int NurturingProcessSlotsId = Convert.ToInt32(hdnNurturingProcessSlotsId.Value);
                if (NurturingProcessSlotsId > 0)
                {
                    clsHrProcessSlots Obj = new clsHrProcessSlots();
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

                
                txtNotes.Enabled = false;
                ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
                NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
                if (ParticipantId > 0 && NurturingProcessStageId > 0)
                {
                    clsHrProcessStageStatus StageObj = new clsHrProcessStageStatus();
                    StageObj.ParticipantId = ParticipantId;
                    StageObj.HrProcessStageId = NurturingProcessStageId;
                    StageCountNo = StageObj.LoadHrProcessStageStatusValidation(StageObj);
                    if (StageCountNo == 0)
                    {
                        StageObj.HrProcessStageId = NurturingProcessStageId;
                        StageObj.ParticipantId = ParticipantId;
                        StageObj.AddUpdate(StageObj);
                    }
                }

                Response.Redirect("PlacementInductionSearch.aspx");

                

                    btnSubmit.Enabled = false;
                    FormMessage.Text = "Hr Process Stage Task Successfully Saved";
                    FormMessage.Visible = true;
                    ErrorMessage.Visible = false;

            }
           
        }



    }

    protected void btnApprove_Click(object sender, EventArgs e)
    {
        if (txtMarks.Text != "" && Convert.ToDecimal(txtMarks.Text) > Convert.ToDecimal(94))
        {
            if (ItemId > 0)
            {
                Item.HrProcessId = ItemId;
            }
            Item.HrProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
            Item.HrProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.SelectedValue);
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
                clsHrProcessSlots Obj = new clsHrProcessSlots();
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
                clsHrProcessStageTask NPST = new clsHrProcessStageTask();
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
            clsHrProcessStageStatus ObjStageExit = new clsHrProcessStageStatus();
            ObjStageExit.Exit(NurturingProcessStageStatusId);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("HrProcessSearch.aspx");
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (txtChat.Text.Length > 0)
        {
            ParticipantId = Convert.ToInt16(ddlParticipant.SelectedValue);
            NurturingProcessStageId = Convert.ToInt16(ddlNurturingProcessStage.SelectedValue);
            NurturingProcessStageTaskId = Convert.ToInt16(ddlNurturingProcessStageTask.SelectedValue);
            ItemNurturingChat = new clsHrChat();
            ItemNurturingChat.ParticipantId = ParticipantId;
            ItemNurturingChat.HrProcessStageTaskId = NurturingProcessStageTaskId;
            ItemNurturingChat = ItemNurturingChat.GetByPendingChat(ParticipantId);
            if (ItemNurturingChat != null)
            {
                NurturingChatId = Convert.ToInt32(ItemNurturingChat.HrChatId);
                Message = ItemNurturingChat.Chat;
            }
            if (NurturingChatId > 0)
            {

                clsHrChat ParticipantNurturingChatUpdate = new clsHrChat();
                ParticipantNurturingChatUpdate.HrChatId = NurturingChatId;
                ParticipantNurturingChatUpdate.EmployeeId = 0;
                ParticipantNurturingChatUpdate.ParticipantId = ParticipantId;
                ParticipantNurturingChatUpdate.Chat = Message;
                ParticipantNurturingChatUpdate.HrProcessStageId = NurturingProcessStageId;
                ParticipantNurturingChatUpdate.HrProcessStageTaskId = NurturingProcessStageTaskId;
                ParticipantNurturingChatUpdate.CreatedBy = CurrentUser.CurrentUserId;
                ParticipantNurturingChatUpdate.IsReplied = Convert.ToBoolean(1);
                ParticipantNurturingChatUpdate.AddUpdate(ParticipantNurturingChatUpdate);
            }

            clsHrChat ParticipantNurturingChat = new clsHrChat();
            ParticipantNurturingChat.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            ParticipantNurturingChat.ParticipantId = Convert.ToInt16(ddlParticipant.SelectedValue);
            ParticipantNurturingChat.Chat = txtChat.Text;
            ParticipantNurturingChat.HrProcessStageId = Convert.ToInt16(ddlNurturingProcessStage.SelectedValue);
            ParticipantNurturingChat.HrProcessStageTaskId = Convert.ToInt16(ddlNurturingProcessStageTask.SelectedValue);
            ParticipantNurturingChat.CreatedBy = CurrentUser.CurrentUserId;
            ParticipantNurturingChat.IsReplied = Convert.ToBoolean(1);
            ParticipantNurturingChat.AddUpdate(ParticipantNurturingChat);
            txtChat.Text = "";
            FormMessage.Text = "Your request is successfully sent.";
            FormMessage.Visible = true;
            Response.Redirect("HrProcess.aspx?ItemId=" + ItemId);
        }
    }
    protected void BindData()
    {
        clsHrChat Item = new clsHrChat();
        Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
        Item.HrProcessStageTaskId = Convert.ToInt16(ddlNurturingProcessStageTask.SelectedValue);
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



    protected void btnBackToSlots_Click(object sender, EventArgs e)
    {
        Response.Redirect("HrAvailableSlotsSearch.aspx");
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