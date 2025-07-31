using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Configuration;
using System.Reflection.Emit;

public partial class Admin_HrProcess : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsHrProcess Item;
    int ItemId = 0;
    clsHrChat ItemHrChat;
    int HrChatId = 0;
    string Message = "";
    int HrProcessStageId = 0;
    int HrProcessStageTaskId = 0;
    int ParticipantId = 0;
    int CountNO = 0;
    int UserId = 0;
    int EmployeeId = 0;
    // int NurtureTypeLinkId = 0;
    int StageCountNo = 0;
    // int CountNos = 0;
    int HrMock = 0;
    int StudentInteractions = 0;
    int HrProcessStageStatusId = 0;
    DateTime SlotDate;
    int StatusCode = 0;
    //int StatusDashboardCount = 0;
    int ParticipantStatusDashboardId = 0;
    int TotalHrMock = 0;
    int TotalStudentInteractions = 0;
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

            BindHrProcessStage();



            //  //BindHrProcessStageTask();
            // //BindReshudule();
            if (ItemId > 0)
            {
                divParticipant.Visible = false;
                //btnSubmit.Enabled = false;
                lblTitle.Text = "Edit Hr Process Stage Task Details";

                Item = Item.Load(ItemId);


                if (Item != null)
                {
                    BindParticipant();
                    ddlParticipant.SelectedValue = Item.ParticipantId.ToString();
                    //ddlParticipant.Enabled = false;
                    ddlHrProcessStage.SelectedValue = Item.HrProcessStageId.ToString();
                    //ddlHrProcessStage.Enabled = false;
                    BindHrProcessStageTask();
                    ddlHrProcessStageTask.SelectedValue = Item.HrProcessStageTaskId.ToString();
                   // ddlHrProcessStageTask.Enabled = false;
                    ddlReshedule.SelectedValue = Item.SlotsStatusId.ToString();



                    BindData();
                   // BindHrTasksInputsData();
                    //ReqFileUpload.Enabled = false;
                    txtMarks.Text = Item.ExamScore.ToString();
                    txtNotes.Text = Item.Notes;
                    txtTargetDate.Text = Item.TargetDate.ToString("dd/MM/yyyy");
                    //txtSlot.Enabled = false;
                    if (Item.HrProcessSlotsId > 0)
                    {
                        hdnHrProcessSlotsId.Value = Item.HrProcessSlotsId.ToString();
                        clsHrProcessSlots HrProcessSlots = new clsHrProcessSlots();
                        HrProcessSlots = HrProcessSlots.Load(Convert.ToInt32(Item.HrProcessSlotsId));
                        if (HrProcessSlots != null)
                        {
                            DateTime DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(40);
                            DateTime SlotStartTime = Convert.ToDateTime(HrProcessSlots.SlotStartTime);
                            string DatetimeVisibleEndTime = DateTime.ToString("dd-mm-yyyy") + " " + "23:59:00 PM";

                            DateTime SlotVisibleEndTime = Convert.ToDateTime(DatetimeVisibleEndTime);

                            txtSlot.Text = HrProcessSlots.SlotDate.ToString("dd MMM yyyy") + " - " + HrProcessSlots.StartEndTime;

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

                    
                    if (Item.ExamDate == null)
                    {
                        divMarks.Visible = false;
                        //btnApprove.Visible = false;
                    }
                  
                    /**/



                }

            }
            else
            {
                lblTitle.Text = "Add Hr Process Stage Task";
                btnApprove.Visible = false;
                ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant -- ", ""));
                //ddlHrProcessStage.Enabled = false;
                //ddlHrProcessStageTask.Enabled = false;
                //divMarks.Visible = false;
                //divAttachments.Visible = false;
                //divMenterinputs.Visible = false;
                //lblSlot.Visible = false;
                //txtSlot.Visible = false;
                //divReshdule.Visible = false;
                //btnReShedule.Visible = false;
            }
        }
    }


    private void BindReshudule()
    {
        clsHrProcessSlots obj = new clsHrProcessSlots();
        ddlReshedule.DataSource = obj.LoadAlLReShedule(obj);
        ddlReshedule.DataTextField = "SlotStatus";
        ddlReshedule.DataValueField = "SlotsStatusId";
        ddlReshedule.DataBind();
        ddlReshedule.Items.Insert(0, new ListItem("Select Reshuedule Status", ""));
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
    protected void BindHrProcessStage()
    {
        clsHrProcessStage obj = new clsHrProcessStage();
        ddlHrProcessStage.DataSource = obj.LoadAll(obj);
        ddlHrProcessStage.DataTextField = "HrProcessStageName";
        ddlHrProcessStage.DataValueField = "HrProcessStageId";
        ddlHrProcessStage.DataBind();
        ddlHrProcessStage.Items.Insert(0, new ListItem("---Select Hr Process Stage---", ""));
    }
    protected void ddlHrProcessStage_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlHrProcessStage.SelectedValue != null)
            BindHrProcessStageTask();
    }
    protected void BindHrProcessStageTask()
    {
        //ddlHrProcessStageTask.Items.Clear();
        if (ddlHrProcessStage.SelectedValue != "")
        {
            clsHrProcessStageTask obj = new clsHrProcessStageTask();
            obj.HrProcessStageId = Convert.ToInt32(ddlHrProcessStage.SelectedValue);
            ddlHrProcessStageTask.DataSource = obj.LoadAll(obj);
            ddlHrProcessStageTask.DataTextField = "HrProcessStageTaskName";
            ddlHrProcessStageTask.DataValueField = "HrProcessStageTaskId";
            ddlHrProcessStageTask.DataBind();
            ddlHrProcessStageTask.Items.Insert(0, new ListItem("-- Select Hr Process Stage Task -- ", ""));
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

    protected void BindHrProcessStageStatus()
    {
        ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
        clsHrProcessStageTask NPST = new clsHrProcessStageTask();
        NPST.ParticipantId = ParticipantId;
        NPST = NPST.HrDashboardCount(NPST);
        HrMock = NPST.TotalHrMock;
        StudentInteractions = NPST.StudentInteractions;

        HrProcessStageId = Convert.ToInt32(ddlHrProcessStage.SelectedValue);
        if (HrProcessStageId == 1)
        {
            if (HrMock == TotalHrMock)
            {
                clsHrProcessStageStatus StageObj = new clsHrProcessStageStatus();
                StageObj.ParticipantId = ParticipantId;
                StageObj.HrProcessStageId = HrProcessStageId;
                if (StageObj.ParticipantId > 0)
                {
                    StageObj = StageObj.LoadHrProcessStageStatusId(StageObj.ParticipantId, StageObj.HrProcessStageId);
                    if (StageObj != null)
                    {
                        HrProcessStageStatusId = Convert.ToInt32(StageObj.HrProcessStageStatusId);

                    }

                }
            }
        }
        else if (HrProcessStageId == 2)
        {
            if (StudentInteractions == TotalStudentInteractions)
            {
                clsHrProcessStageStatus StageObj = new clsHrProcessStageStatus();
                StageObj.ParticipantId = ParticipantId;
                StageObj.HrProcessStageId = HrProcessStageId;
                if (StageObj.ParticipantId > 0)
                {
                    StageObj = StageObj.LoadHrProcessStageStatusId(StageObj.ParticipantId, StageObj.HrProcessStageId);
                    if (StageObj != null)
                    {
                        HrProcessStageStatusId = Convert.ToInt32(StageObj.HrProcessStageStatusId);

                    }

                }
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // BindDuplicateTask();


        if (EmployeeId > 0 || UserId > 0)
        {
            if (ItemId > 0)
            {
                Item.HrProcessId = ItemId;
                Item.EvaluatedBy = EmployeeId;
                Item.EvaluatedOn = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            }
            Item.HrProcessStageId = Convert.ToInt32(ddlHrProcessStage.SelectedValue);
              Item.HrProcessStageTaskId = Convert.ToInt16(ddlHrProcessStageTask.SelectedValue);
            Item.EmployeeId = EmployeeId;
            Item.AssignedEmployeeId = 0;
            Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
            Item.ApprovedBy = 0;


            if (txtMarks.Text != "")
            {
                Item.ExamScore = Convert.ToDecimal(txtMarks.Text);
            }
            //if (flUpload.HasFile)
            //{
            //    clsFileUpload Upload = new clsFileUpload();
            //    string filePath = Upload.HrProcessUploadDoc(flUpload);
            //    Item.SenderImagePath = filePath;
            //}
            if (txtTargetDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtTargetDate.Text, "dd/MM/yyyy", null);
                Item.TargetDate = Convert.ToDateTime(Date);
            }
            Item.Notes = txtNotes.Text;
            //Item.IsApproved = false;
            Item.CreatedBy = UserId;
            Item.SlotsStatusId = Convert.ToInt32(ddlReshedule.SelectedValue);
            Item.AddUpdate(Item);
            int HrProcessSlotsId = Convert.ToInt32(hdnHrProcessSlotsId.Value);
            if (HrProcessSlotsId > 0)
            {
                clsHrProcessSlots Obj = new clsHrProcessSlots();
                Obj = Obj.Load(HrProcessSlotsId);
                if (Obj != null)
                {
                    SlotDate = Convert.ToDateTime(Obj.SlotDate);
                }
                Obj.HrProcessSlotsId = HrProcessSlotsId;
                Obj.SlotDate = SlotDate;
                Obj.CreatedBy = UserId;
                Obj.IsSlotAssigned = true;
                Obj.SlotsStatusId = Convert.ToInt32(ddlReshedule.SelectedValue);
                Obj.AddUpdate(Obj);
            }

           // flUpload.Enabled = false;
            txtNotes.Enabled = false;
            ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
            HrProcessStageId = Convert.ToInt32(ddlHrProcessStage.SelectedValue);
            //if (ParticipantId > 0 && HrProcessStageId > 0)
            //{
            //    clsHrProcessStageStatus StageObj = new clsHrProcessStageStatus();
            //    StageObj.ParticipantId = ParticipantId;
            //    StageObj.HrProcessStageId = HrProcessStageId;
            //    StageCountNo = StageObj.LoadHrProcessStageStatusValidation(StageObj);
            //    if (StageCountNo == 0)
            //    {
            //        StageObj.HrProcessStageId = HrProcessStageId;
            //        StageObj.ParticipantId = ParticipantId;
            //        StageObj.AddUpdate(StageObj);
            //    }
            //}



            //if (ItemId > 0)
            //{
            //    //FormMessage.Text = "Hr Process Stage Task Successfully Updated.";
            //    //FormMessage.Visible = true;
            //    btnSubmit.Enabled = false;
            //    // ErrorMessage.Visible = false;
            //    //btnReShedule.Enabled = false;
            //    //ddlReshedule.Enabled = false;
            //}
            //else
            //{
            //    clsParticipantStatusDashboard PSD = new clsParticipantStatusDashboard();
            //    PSD.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
            //    //HrProcessStageTaskId = Convert.ToInt32(ddlHrProcessStageTask.SelectedValue);
            //    if (HrProcessStageTaskId > 0)
            //    {
            //        clsHrProcessStageTask CNPST = new clsHrProcessStageTask();
            //        CNPST = CNPST.Load(HrProcessStageTaskId);
            //        if (CNPST != null)
            //        {
            //            StatusCode = CNPST.StatusCode;
            //            PSD.StatusCode = StatusCode;
            //            PSD.CreatedBy = CurrentUser.CurrentUserId;
            //            PSD.AddUpdate(PSD);
            //            clsParticipant CP = new clsParticipant();
            //            CP.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
            //            CP.StatusCode = StatusCode;
            //            CP.AddUpdateStatusCode(CP);
            //            //StatusDashboardCount = PSD.LoadParticipantStatusDashboardValidation(PSD);
            //            //if (StatusDashboardCount == 0)
            //            //{
            //            //    PSD.CreatedBy = CurrentUser.CurrentUserId;
            //            //    PSD.AddUpdate(PSD);
            //            //    clsParticipant CP = new clsParticipant();
            //            //    CP.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
            //            //    CP.StatusCode = StatusCode;
            //            //    CP.AddUpdateStatusCode(CP);
            //            //}
            //        }

            //    }


            //    btnSubmit.Enabled = false;
            //    //FormMessage.Text = "Hr Process Stage Task Successfully Saved";
            //    //FormMessage.Visible = true;
            //    // ErrorMessage.Visible = false;

            //}


        }
        else
        {
            Response.Redirect("~/Login.html");
        }
    }



    

    protected void btnApprove_Click(object sender, EventArgs e)
    {
        if (txtMarks.Text != "" && Convert.ToDecimal(txtMarks.Text) > Convert.ToDecimal(59))
        {
            if (ItemId > 0)
            {
                Item.HrProcessId = ItemId;
            }
            Item.HrProcessStageId = Convert.ToInt32(ddlHrProcessStage.SelectedValue);
           Item.HrProcessStageTaskId = Convert.ToInt32(ddlHrProcessStageTask.SelectedValue);
            Item.EmployeeId = EmployeeId;
            Item.AssignedEmployeeId = 0;
            Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
            Item.ApprovedBy = EmployeeId;
            Item.ApprovedDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            Item.ExamScore = Convert.ToDecimal(txtMarks.Text);
            Item.SlotsStatusId = 4;
            Item.Notes = txtNotes.Text;
            if (txtTargetDate.Text != "")
            {
                DateTime Date = DateTime.ParseExact(txtTargetDate.Text, "dd/MM/yyyy", null);
                Item.TargetDate = Convert.ToDateTime(Date);
            }
            Item.IsApproved = true;
            Item.CreatedBy = UserId;
            Item.AddUpdate(Item);

            int HrProcessSlotsId = Convert.ToInt32(hdnHrProcessSlotsId.Value);
            if (HrProcessSlotsId > 0)
            {
                clsHrProcessSlots Obj = new clsHrProcessSlots();
                Obj = Obj.Load(HrProcessSlotsId);
                if (Obj != null)
                {
                    SlotDate = Convert.ToDateTime(Obj.SlotDate);
                }
                Obj.HrProcessSlotsId = HrProcessSlotsId;
                Obj.SlotDate = SlotDate;
                Obj.CreatedBy = UserId;
                Obj.IsSlotAssigned = true;
                Obj.SlotsStatusId = 4;
                Obj.AddUpdate(Obj);
            }
            //Response.Redirect("NurtureExamSearch.aspx");

            clsParticipantStatusDashboard PSD = new clsParticipantStatusDashboard();
            PSD.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
            HrProcessStageTaskId = Convert.ToInt32(ddlHrProcessStageTask.SelectedValue);
            if (HrProcessStageTaskId > 0)
            {
                clsHrProcessStageTask NPST = new clsHrProcessStageTask();
                NPST = NPST.Load(HrProcessStageTaskId);
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
            //FormMessage.Text = "Exam Approved Successfully";
            //FormMessage.Visible = true;
           // ErrorMessage.Visible = false;
            btnApprove.Enabled = false;
            txtMarks.Enabled = false;
            txtNotes.Enabled = false;
            //btnReShedule.Enabled = false;



        }
        else
        {
           // ErrorMessage.Text = "Exam score should be Greater Than or Equal to 60 ";
           // ErrorMessage.Visible = true;
            //FormMessage.Visible = false;
        }
        BindHrProcessStageStatus();
        if (HrProcessStageStatusId > 0)
        {
            clsHrProcessStageStatus ObjStageExit = new clsHrProcessStageStatus();
            ObjStageExit.Exit(HrProcessStageStatusId);
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
            HrProcessStageId = Convert.ToInt16(ddlHrProcessStage.SelectedValue);
           // HrProcessStageTaskId = Convert.ToInt16(ddlHrProcessStageTask.SelectedValue);
            ItemHrChat = new clsHrChat();
            ItemHrChat.ParticipantId = ParticipantId;
            //ItemHrChat.HrProcessStageTaskId = HrProcessStageTaskId;
            ItemHrChat = ItemHrChat.GetByPendingChat(ParticipantId);
            if (ItemHrChat != null)
            {
                HrChatId = Convert.ToInt32(ItemHrChat.HrChatId);
                Message = ItemHrChat.Chat;
            }
            if (HrChatId > 0)
            {

                clsHrChat ParticipantHrChatUpdate = new clsHrChat();
                ParticipantHrChatUpdate.HrChatId = HrChatId;
                ParticipantHrChatUpdate.EmployeeId = 0;
                ParticipantHrChatUpdate.ParticipantId = ParticipantId;
                ParticipantHrChatUpdate.Chat = Message;
                ParticipantHrChatUpdate.HrProcessStageId = HrProcessStageId;
                //ParticipantHrChatUpdate.HrProcessStageTaskId = HrProcessStageTaskId;
                ParticipantHrChatUpdate.CreatedBy = CurrentUser.CurrentUserId;
                ParticipantHrChatUpdate.IsReplied = Convert.ToBoolean(1);
                ParticipantHrChatUpdate.AddUpdate(ParticipantHrChatUpdate);
            }

            clsHrChat ParticipantHrChat = new clsHrChat();
            ParticipantHrChat.EmployeeId = Convert.ToInt16(CurrentUser.CurrentEmployeeId);
            ParticipantHrChat.ParticipantId = Convert.ToInt16(ddlParticipant.SelectedValue);
            ParticipantHrChat.Chat = txtChat.Text;
            ParticipantHrChat.HrProcessStageId = Convert.ToInt16(ddlHrProcessStage.SelectedValue);
           // ParticipantHrChat.HrProcessStageTaskId = Convert.ToInt16(ddlHrProcessStageTask.SelectedValue);
            ParticipantHrChat.CreatedBy = CurrentUser.CurrentUserId;
            ParticipantHrChat.IsReplied = Convert.ToBoolean(1);
            ParticipantHrChat.AddUpdate(ParticipantHrChat);
            txtChat.Text = "";
            //FormMessage.Text = "Your request is successfully sent.";
            //FormMessage.Visible = true;
            Response.Redirect("HrProcess.aspx?ItemId=" + ItemId);
        }
    }
    protected void BindData()
    {
        clsHrChat Item = new clsHrChat();
        Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
        //Item.HrProcessStageTaskId = Convert.ToInt16(ddlHrProcessStageTask.SelectedValue);
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
            if (ddlParticipant.SelectedValue != "")
            {
                Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
               // Item.HrProcessStageTaskId = Convert.ToInt32(ddlHrProcessStageTask.SelectedValue);
                CountNO = Item.LoadHrProcessValidation(Item);
                if (CountNO > 0)
                {
                   // ddlHrProcessStageTask.SelectedIndex = -1;
                   // ErrorMessage.Text = "HrProcessStageTask already asigned to this participant";
                   // ErrorMessage.Visible = true;
                    //FormMessage.Visible = false;
                }
                else
                {
                   // ErrorMessage.Visible = false;
                }
            }

        }
    }

    protected void BindNextStageTask()
    {
        clsHrProcess HrNextTask = new clsHrProcess();
        if (ddlParticipant.SelectedValue != "")
        {
            HrNextTask = HrNextTask.LoadNextStageTask(Convert.ToInt32(ddlParticipant.SelectedValue));
            if (HrNextTask != null)
            {
                ddlHrProcessStage.SelectedValue = Convert.ToString(HrNextTask.HrProcessStageId);
              //  ddlHrProcessStageTask.SelectedValue = Convert.ToString(HrNextTask.HrProcessStageTaskId);
                //BindHrProcessStageTask();
            }
        }
    }

    protected void ddlHrProcessStageTask_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDuplicateTask();
    }

    protected void ddlParticipant_SelectedIndexChanged(object sender, EventArgs e)
    {
        //BindNextStageTask();
        //BindDuplicateTask();
        //BindHrTasksInputsData();
    }

    protected void btnBackToSlots_Click(object sender, EventArgs e)
    {
        Response.Redirect("HrAvailableSlotsSearch.aspx");
    }
    protected void BindHrTasksInputsData()
    {
        clsHrChat Item = new clsHrChat();
        Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
        rpHrTeamInputs.DataSource = Item.LoadAllTasks(Item);
        rpHrTeamInputs.DataBind();
    }
    protected void rpHrTeamInputs_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        RepeaterItem item = e.Item;
        if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
        {
            HiddenField hdnRoleId = (HiddenField)item.FindControl("hdnHrTeamInputsRoleId");
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
            BindHrProcessStage();
        }
    }


    //protected void btnReShedule_Click(object sender, EventArgs e)
    //{

    //ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
    //int HrProcessId = ItemId;
    //clsHrProcessSlots Obj = new clsHrProcessSlots();
    //Obj = Obj.Load(HrProcessId);
    //if (Obj != null)
    //{
    //    SlotDate = Convert.ToDateTime(Obj.SlotDate);
    //}

    ////Obj.HrProcessSlotsId = HrProcessId;
    //Obj.HrProcessId = ItemId;
    //Obj.SlotDate = SlotDate;
    //Obj.CreatedBy = UserId;
    //Obj.IsSlotAssigned = true;
    //Obj.SlotsStatusId = Convert.ToInt32(ddlReshedule.SelectedValue);
    //Obj.AddUpdate(Obj);

    //btnSubmit.Enabled = false;
    //btnReShedule.Enabled = false;
    //btnApprove.Enabled = false;
    //FormMessage.Text = "Reshedule Status and score Successfully Saved";
    //FormMessage.Visible = true;
    //ErrorMessage.Visible = false;


    //    string mycon = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    //    SqlConnection con = new SqlConnection(mycon);

    //    SqlCommand cmd = new SqlCommand("insert into tblHrProcessSlots (SlotsStatusId) values (@SlotsStatusId)", con);
    //    cmd.Parameters.AddWithValue("SlotsStatusId", ddlReshedule.SelectedItem.Value);
    //    con.Open();
    //    int i = cmd.ExecuteNonQuery();
    //    con.Close();
    //    if (i != 0)
    //    {
    //        lbmsg.Text = " Your data is been saved in the database";
    //        lbmsg.ForeColor = System.Drawing.Color.ForestGreen;

    //    }
    //    else
    //    {
    //        lbmsg.Text = "Something went wrong with selection";
    //        lbmsg.ForeColor = System.Drawing.Color.Red;



    //    }
    //}
    protected void ddlReshedule_SelectedIndexChanged(object sender, EventArgs e)
    {
        //clsHrProcessSlots obj = new clsHrProcessSlots();
        //obj.SlotStatus = Convert.ToString(ddlReshedule.SelectedValue);
        //CountNos = obj.LoadSlotStatusValidation(obj);
        //if (CountNos > 0)
        //{
        //    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeDuplicate()", true);
        //    //ddlReshedule.SelectedValue = "";
        //    //ddlReshedule.Enabled = false;

        //}
    }
}