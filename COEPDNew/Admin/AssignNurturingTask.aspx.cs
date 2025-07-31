using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_AssignNurturingTask : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsAssignNurturingTask Item;
    int ItemId = 0;
    int NurturingProcessStageId = 0;
    int NurturingProcessStageTaskId = 0;
    int ParticipantId = 0;
    int CountNO = 0;
    int Countno = 0;
    int UserId = 0;
    int EmployeeId = 0;
    int StageCountNo = 0;
    DateTime SlotDate;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        UserId = CurrentUser.CurrentUserId;
        EmployeeId = CurrentUser.CurrentEmployeeId;
        Item = new clsAssignNurturingTask();
        if (!IsPostBack)
        {
            BindNurturingProcessStage();
            if (ItemId > 0)
            {
                divParticipant.Visible = false;
                divEdit.Visible = true;
                divMarks.Visible = true;
                btnApprove.Visible = true;
                btnSubmit.Visible = false;
                btnSave.Visible = true;
                divTaskInputs.Visible = true; 

                lblTitle.Text = "Edit Nurturing Process Stage Task Details";

                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    BindParticipant();
                    ddlParticipant.SelectedValue = Item.ParticipantId.ToString();
                    ddlParticipant.Enabled = false;
                    BindNurturingProcessStage();
                    ddlNurturingProcessStage.SelectedValue = Convert.ToString(Item.NurturingProcessStageId);
                    ddlNurturingProcessStage.Enabled = false;
                    BindNurturingProcessStageTask();
                    ddlNurturingProcessStageTask.Text = Convert.ToString(Item.NurturingProcessStageTaskId);
                    ddlNurturingProcessStageTask.Enabled = false;
                    txtMarks.Text = Item.ExamScore.ToString();
                    txtTaskInputs.Text = Item.TaskInputs;
                    txtTaskInputs.Enabled= false;
                    txtNotes.Text = Item.MentorInputs;
                    txtTargetDate.Text = Convert.ToString(Item.TargetDate);
                    txtTargetDate.Enabled = false;
                    txtSlot.Enabled= false;
                    if (Item.NurturingProcessSlotsId > 0)
                    {
                        clsNurturingProcessSlots NurturingProcessSlots = new clsNurturingProcessSlots();
                        NurturingProcessSlots = NurturingProcessSlots.Load(Convert.ToInt32(Item.NurturingProcessSlotsId));
                        if (NurturingProcessSlots != null)
                        {
                            DateTime DateTime = DateTime.UtcNow.AddHours(5).AddMinutes(40);
                            DateTime SlotStartTime = Convert.ToDateTime(NurturingProcessSlots.SlotStartTime);

                            //txtSlot.Text = NurturingProcessSlots.SlotDate.ToString("dd MMM yyyy") + " - " + NurturingProcessSlots.StartEndTime;
                            txtSlot.Text = NurturingProcessSlots.SlotDate + " - " + NurturingProcessSlots.StartEndTime;
                            if (DateTime >= SlotStartTime)
                            {
                                btnApprove.Enabled = true;
                                btnSave.Enabled = true;
                            }
                            else
                            {
                                btnApprove.Enabled = false;
                                btnSave.Enabled = false;
                            }
                        }
                    }
                    if (Item.SenderImagePath != "")
                    {
                        hplSentFile.NavigateUrl = "~/UserDocs/NurturingTask/" + Item.SenderImagePath;
                    }
                    else
                    {
                        hplSentFile.Visible = false;
                    }
                    if (Item.ReceiverImagePath != "")
                    {
                        hplReplyFile.NavigateUrl = "~/UserDocs/AssignNurturingTask/" + Item.ReceiverImagePath;
                    }
                    else
                    {
                        hplReplyFile.Visible = false;
                    }

                    if (Item.TaskCompletedOn == null)
                    {
                        //divMarks.Visible = false;
                        //btnApprove.Visible = false;
                    }
                    if (Item.IsApproved == true)
                    {
                        //btnApprove.Visible = false;
                        btnSave.Visible = false;
                        txtMarks.Enabled = false;
                        txtNotes.Enabled = false;
                        divUpload.Visible = false;
                        lblSlot.Visible = false;
                        txtSlot.Visible = false;
                        txtTargetDate.Enabled = false;
                        txtTaskInputs.Enabled = false;
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
                divMentorInputs.Visible = false;
                lblSlot.Visible = false;
                txtSlot.Visible = false;
                btnSave.Visible = false;
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
        if (ddlParticipant.Items.Count == 0)
        {
            ddlParticipant.Items.Insert(0, new ListItem("-- There is no such Participant -- ", ""));
        }
        else
        {
            ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant -- ", ""));
        }
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
            ddlNurturingProcessStageTask.Items.Insert(0, new ListItem("--Select Nurturing Process Stage Task-- ", ""));
        }

    }

    protected void BindDuplicateTaskAssign()
    {
        if (ItemId == 0)
        {
            if (ddlParticipant.SelectedValue != "" & ddlNurturingProcessStageTask.SelectedValue != "")
            {
                Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
                Item.NurturingProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.SelectedValue);
                CountNO = Item.LoadAssignNurturingTaskValidation(Item);
                if (CountNO > 0)
                {
                    ddlNurturingProcessStageTask.SelectedIndex = -1;
                    ErrorMessage.Text = "Nurturing Process Stage Task already asigned to this participant";
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

    protected void BindAtleastOneTask()
    {
        //ErrorMessage.Visible= false;
        clsNurturingTask item = new clsNurturingTask();

        if (ddlParticipant.SelectedValue != "" & ddlNurturingProcessStageTask.SelectedValue != "")
        {
            //item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
            item.NurturingProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.SelectedValue);
            Countno = item.LoadNurturingTaskValidation(item);
            if (Countno == 0)
            {
                ddlNurturingProcessStageTask.SelectedIndex = -1;
                ErrorMessage.Text = "Nurturing Process Stage Task is not yet created. Please create it first!";
                ErrorMessage.Visible = true;
                FormMessage.Visible = false;
                BindNurturingProcessStage();
                BindNurturingProcessStageTask();
            }
            else
            {
                ErrorMessage.Visible = false;
            }
        }
    }
    protected void ddlParticipant_SelectedIndexChanged(object sender, EventArgs e)
    {
        ErrorMessage.Visible = false;
        BindDuplicateTaskAssign();
    }

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        ErrorMessage.Visible = false;
        ddlParticipant.Items.Clear();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select participant -- ", ""));
        if (txtSearch.Text != "")
        {
            BindParticipant();
        }
    }
    protected void ddlNurturingProcessStage_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlNurturingProcessStage.SelectedValue != null)
            BindNurturingProcessStageTask();
    }
    protected void ddlNurturingProcessStageTask_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDuplicateTaskAssign();
        BindAtleastOneTask();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BindDuplicateTaskAssign();
        if (CountNO > 0)
        {
            ddlNurturingProcessStageTask.SelectedIndex = -1;
            ErrorMessage.Text = "NurturingProcessStageTask already asigned to this participant";
            ErrorMessage.Visible = true;
            FormMessage.Visible = false;
        }
        else
        {
            if (ItemId > 0)
                Item.AssignNurturingTaskId = Convert.ToInt32(ItemId);
            Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
            Item.NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
            Item.NurturingProcessStageTaskId = Convert.ToInt16(ddlNurturingProcessStageTask.SelectedValue);
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.AddUpdate(Item);
            //btnSubmit.Enabled = false;
            if (ItemId > 0)
            {
                FormMessage.Text = "Nurturing Process Stage Task Successfully Updated.";
                FormMessage.Visible = true;
                btnSubmit.Enabled = false;
                ErrorMessage.Visible = false;
            }
            else
            {
                btnSubmit.Enabled = false;
                FormMessage.Text = "Nurturing Process Stage Task Successfully Saved";
                FormMessage.Visible = true;
                ErrorMessage.Visible = false;
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AssignNurturingTaskSearch.aspx");
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

    protected void btnApprove_Click(object sender, EventArgs e)
    {
        if (txtMarks.Text != "" && Convert.ToDecimal(txtMarks.Text) > Convert.ToDecimal(94))
        {
            if (ItemId > 0)
            {
                Item.AssignNurturingTaskId = ItemId;
            }
            Item.NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
            Item.NurturingProcessStageTaskId = Convert.ToInt32(ddlNurturingProcessStageTask.SelectedValue);
            Item.TaskAssignedTo = 0;
            Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
            Item.ApprovedBy = EmployeeId;
            Item.ApprovedOn = DateTime.UtcNow.AddHours(5).AddMinutes(30);
            Item.ExamScore = Convert.ToDecimal(txtMarks.Text);
            Item.MentorInputs = txtNotes.Text;
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


    }
     
    protected void btnSave_Click(object sender, EventArgs e)
    {
        BindDuplicateTaskAssign();
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
                    Item.AssignNurturingTaskId = ItemId;
                    Item.EvaluatedBy = EmployeeId;
                    Item.EvaluatedOn = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                }
                Item.NurturingProcessStageId = Convert.ToInt32(ddlNurturingProcessStage.SelectedValue);
                Item.NurturingProcessStageTaskId = Convert.ToInt16(ddlNurturingProcessStageTask.SelectedValue);
                Item.EmployeeId = EmployeeId;
                Item.TaskAssignedTo = 0;
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
                //if (txtTargetDate.Text != "")
                //{
                //    DateTime Date = DateTime.ParseExact(txtTargetDate.Text, "dd/MM/yyyy ", null);
                //    Item.TargetDate = Convert.ToDateTime(Date);
                //}
                Item.MentorInputs = txtNotes.Text;
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
                    btnSave.Enabled = false;
                    ErrorMessage.Visible = false;
                }
                else
                {
                    btnSave.Enabled = false;
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
}
