using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Participant_NurturingProcess : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsNurturingProcess Item;
    int ItemId = 0;
    int NurturingProcessSlotsId = 0;
    int EmployeeId = 0;
    DateTime SlotDate;
    DateTime SlotStartTime;
    DateTime SlotEndTime;
    string StartEndTime = "";
    int SlotsCount = 0;
    DateTime LastSlotStartTime;
    DateTime SlotPriorityStartTime;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsNurturingProcess();
        if (!IsPostBack)
        {
            if (ItemId > 0)
            {
                lblTitle.Text = "Nurturing Process - Assigned Exam";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    clsNurturingProcessStageTask NurturingProcessStageTask = new clsNurturingProcessStageTask();
                    NurturingProcessStageTask = NurturingProcessStageTask.Load(Convert.ToInt16(Item.NurturingProcessStageTaskId));
                    hdnStageTaskId.Value = NurturingProcessStageTask.NurturingProcessStageTaskId.ToString();
                    clsNurturingProcessStage NurturingProcessStage = new clsNurturingProcessStage();
                    NurturingProcessStage = NurturingProcessStage.Load(Convert.ToInt16(Item.NurturingProcessStageId));
                    hdnStageId.Value = NurturingProcessStage.NurturingProcessStageId.ToString();

                   BindData();
                    lblStage.Text = NurturingProcessStage.NurturingProcessStageName;
                    lblStageTask.Text = NurturingProcessStageTask.NurturingProcessStageTaskName;
                    lblNotes.Text = Item.Notes;
                    lblTargetDate.Text = Item.TargetDate.ToString("dd/MM/yyyy");
                    if(Item.NurturingProcessSlotsId >0)
                    {
                        txtSlotDate.Enabled = false;
                        ddlAvilableSlots.Visible = false;
                        lblAvilableSlots.Visible = true;
                        clsNurturingProcessSlots NurturingProcessSlots = new clsNurturingProcessSlots();
                        NurturingProcessSlots = NurturingProcessSlots.Load(Convert.ToInt32(Item.NurturingProcessSlotsId));
                        txtSlotDate.Text = NurturingProcessSlots.SlotDate.ToString("dd/MM/yyyy");
                        lblAvilableSlots.Text = NurturingProcessSlots.StartEndTime;
                        btnSubmit.Visible = false;
                        //FileUpload1.Visible = false;
                        btnUploadFile.Visible = true;

                    }
                    else
                    {
                        lblAvilableSlots.Visible = false;
                    }
                    if (Item.IsApproved == true)
                    {
                        lblStatus.Text = "Approved";
                        btnSubmit.Visible = false;
                        btnUploadFile.Visible = false;
                        FileUpload1.Visible = false;
                        txtSlotDate.Visible = false;
                        ddlAvilableSlots.Visible = false;
                        lblSelectSlotDate.Visible = false;
                        lblSelectSlot.Visible = false;

                    }
                    else
                    {
                        lblStatus.Text = "Not Approved";
                    }
                    if (Item.SenderImagePath != "")
                    {
                        hplSentFile.Visible = true;
                        hplSentFile.NavigateUrl = "~/UserDocs/NurturingProcess/" + Item.SenderImagePath;
                    }
                    else
                    {
                        hplSentFile.Visible = false;
                    }
                    if (Item.ReceiverImagePath != "")
                    {
                        hplReplyFile.Visible = true;
                        hplReplyFile.NavigateUrl = "~/UserDocs/NurturingProcess/" + Item.ReceiverImagePath;
                    }
                    else
                    {
                        hplReplyFile.Visible = false;
                    }


                }
            }
            else
            {
                Response.Redirect("NurturingProcessSearch.aspx");
            }
        }
    }
    protected void BindTopOneSlot()
    {
        clsParticipant Participant = new clsParticipant();
        Participant = Participant.Load(CurrentUser.CurrentParticipantId);
        if (Participant != null)
        {
            LastSlotStartTime = Convert.ToDateTime(Participant.LastSlotStartTime);
        }
        if (LastSlotStartTime < DateTime.UtcNow.AddHours(-6).AddMinutes(30))
        {
            SlotPriorityStartTime = DateTime.UtcNow.AddHours(8).AddMinutes(30);
        }
        else
        {
            SlotPriorityStartTime = LastSlotStartTime.AddHours(15);
        }
        clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
        obj.NurturingProcessStageTaskId = Convert.ToInt16(hdnStageTaskId.Value);
        obj.SlotStartTime = Convert.ToDateTime(SlotPriorityStartTime);
        obj = obj.LoadTopOne(obj);
        if(obj != null)
        {
            DateTime Date = Convert.ToDateTime(obj.SlotStartTime);
            lblNextAvailableSlots.Text = "Next Time Slot Available From " + Date.ToString("dd MMM yyyy hh:mm tt");
        }
        else
        {
            lblNextAvailableSlots.Text = "Please raise Service Request to release next batch of slots ...";
        }
        

    }
    protected void BindSlots()
        
    {
        if (Convert.ToInt32(CurrentUser.CurrentParticipantId)>0)
        {
            ddlAvilableSlots.Items.Clear();
            lblNextAvailableSlots.Text = "";
            if (txtSlotDate.Text != "")
            {
                clsParticipant Participant = new clsParticipant();
                Participant = Participant.Load(CurrentUser.CurrentParticipantId);
                if (Participant != null)
                {
                    LastSlotStartTime = Convert.ToDateTime(Participant.LastSlotStartTime);
                }
                if (LastSlotStartTime < DateTime.UtcNow.AddHours(-6).AddMinutes(30))
                {
                    SlotPriorityStartTime = DateTime.UtcNow.AddHours(8).AddMinutes(30);
                }
                else
                {
                    SlotPriorityStartTime = LastSlotStartTime.AddHours(15);
                }
                DateTime Date = DateTime.ParseExact(txtSlotDate.Text, "dd/MM/yyyy", null);
                clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
                obj.NurturingProcessStageTaskId = Convert.ToInt16(hdnStageTaskId.Value);
                obj.SlotDate = Convert.ToDateTime(Date);
                obj.SlotStartTime = Convert.ToDateTime(SlotPriorityStartTime);
                //obj.FromDate = Convert.ToDateTime(Date);
                //obj.ToDate = Convert.ToDateTime(Date);

                ddlAvilableSlots.DataSource = obj.LoadPriorityAll(obj);
                ddlAvilableSlots.DataTextField = "StartEndTime";
                ddlAvilableSlots.DataValueField = "NurturingProcessSlotsId";
                ddlAvilableSlots.DataBind();
                if (ddlAvilableSlots.Items.Count == 0)
                {
                    ddlAvilableSlots.Items.Insert(0, new ListItem("--- No Time Slots Available - Try Next Day ---", ""));
                    //ddlAvilableSlots.Items[0].Attributes.Add("style", "background-color:red");
                    BindTopOneSlot();
                }
                    
                else
                {
                    ddlAvilableSlots.Items.Insert(0, new ListItem("--- Select Time Slot ---", ""));
                    
                }
                    
            }
        }
        else
        {
            Response.Redirect("~/Login.html");
        }
       
    }
    protected void BindDuplicateSlotsCount()
    {
        clsNurturingProcessSlots objSlots = new clsNurturingProcessSlots();
        objSlots.NurturingProcessSlotsId = Convert.ToInt32(ddlAvilableSlots.SelectedValue);
        SlotsCount = objSlots.LoadSlotValidation(objSlots);
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       // System.Threading.Thread.Sleep(3000);
        BindDuplicateSlotsCount();
        if(SlotsCount > 0)
        {
            txtSlotDate.Text = "";
            ddlAvilableSlots.SelectedIndex = -1;
            ErrorMessage.Text = "This Slot already booked. Please select other slot.";
            ErrorMessage.Visible = true;
        }
        else
        {
            if (CurrentUser.CurrentParticipantId > 0)
            {
                
                if (ItemId > 0)
                {
                    btnSubmit.Enabled = false;
                    if (ItemId > 0)
                    {
                        Item.NurturingProcessId = ItemId;
                    }
                    Item.ParticipantId = Convert.ToInt32(CurrentUser.CurrentParticipantId);

                    if (flUpload.FileName.Length > 0)
                    {
                        clsFileUpload Upload = new clsFileUpload();
                        string strFilePath = Upload.NurturingProcessUploadDoc(flUpload);
                        Item.ReceiverImagePath = strFilePath;
                    }
                    Item.ExamDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                    Item.ApprovedBy = 0;
                    Item.IsApproved = false;
                    if (lblTargetDate.Text != "")
                    {
                        DateTime Date = DateTime.ParseExact(lblTargetDate.Text, "dd/MM/yyyy", null);
                        Item.TargetDate = Convert.ToDateTime(Date);
                    }
                    Item.CreatedBy = CurrentUser.CurrentUserId;
                    Item.NurturingProcessSlotsId = Convert.ToInt32(ddlAvilableSlots.SelectedValue);
                    Item.AddUpdate(Item);


                    clsNurturingProcessSlots Obj = new clsNurturingProcessSlots();
                    NurturingProcessSlotsId = Convert.ToInt32(ddlAvilableSlots.SelectedValue);
                    if (NurturingProcessSlotsId > 0)
                    {

                        Obj = Obj.Load(NurturingProcessSlotsId);
                        if (Obj != null)
                        {
                            EmployeeId = Convert.ToInt32(Obj.EmployeeId);
                            SlotDate = Convert.ToDateTime(Obj.SlotDate);
                            SlotStartTime = Convert.ToDateTime(Obj.SlotStartTime);
                            SlotEndTime = Convert.ToDateTime(Obj.SlotEndTime);
                            StartEndTime = Convert.ToString(Obj.StartEndTime);

                            Obj.NurturingProcessSlotsId = NurturingProcessSlotsId;
                            Obj.EmployeeId = EmployeeId;
                            Obj.NurturingProcessStageTaskId = Convert.ToInt16(hdnStageTaskId.Value);
                            Obj.ParticipantId = Convert.ToInt32(CurrentUser.CurrentParticipantId);
                            Obj.SlotDate = Convert.ToDateTime(SlotDate);
                            Obj.SlotStartTime = Convert.ToDateTime(SlotStartTime);
                            Obj.SlotEndTime = Convert.ToDateTime(SlotEndTime);
                            Obj.IsSlotAssigned = true;
                            Obj.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                            Obj.StartEndTime = Convert.ToString(StartEndTime);
                            Obj.NurturingProcessId = Convert.ToInt32(ItemId);
                            Obj.SlotsStatusId = 2;
                            Obj.AddUpdate(Obj);
                        }




                    }


                    if (ItemId > 0)
                    {
                        FormMessage.Text = "Your Slot Successfully Booked. You will get a call from Evaluator in the slot time.";
                        FormMessage.Visible = true;
                        btnSubmit.Enabled = false;
                        ErrorMessage.Visible = false;
                    }
                }
                else
                {
                    Response.Redirect("~/Login.html");
                }

                //Response.Redirect("NurtureExamSearch.aspx");
            }
            else
            {
                Response.Redirect("~/Login.html");
            }
        }
       

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingProcessSearch.aspx");
    }
    //protected void btnSend_Click(object sender, EventArgs e)
    //{
    //    if (txtNotes.Text.Length > 0)
    //    {
    //        clsNurturingChat ParticipantNurturingChat = new clsNurturingChat();
    //        ParticipantNurturingChat.ParticipantId = Convert.ToInt16(CurrentUser.CurrentParticipantId);
    //        ParticipantNurturingChat.Chat = txtNotes.Text;
    //        ParticipantNurturingChat.NurturingProcessStageId = Convert.ToInt16(hdnStageId.Value);
    //        ParticipantNurturingChat.NurturingProcessStageTaskId = Convert.ToInt16(hdnStageTaskId.Value);
    //        ParticipantNurturingChat.CreatedBy = CurrentUser.CurrentUserId;
    //        ParticipantNurturingChat.AddUpdate(ParticipantNurturingChat);
    //        txtNotes.Text = "";
    //        FormMessage.Text = "Your request is successfully sent.";
    //        FormMessage.Visible = true;
    //        Response.Redirect("NurturingProcess.aspx?ItemId=" + ItemId);
    //    }
    //}
    protected void BindData()
    {
        clsNurturingChat NurturingChat = new clsNurturingChat();
        NurturingChat.NurturingProcessStageTaskId = Convert.ToInt16(hdnStageTaskId.Value);
        NurturingChat.ParticipantId = CurrentUser.CurrentParticipantId;
        rp.DataSource = NurturingChat.LoadAll(NurturingChat);
        rp.DataBind();
    }
    protected void rp_OnItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        RepeaterItem item = e.Item;
        if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
        {
            HiddenField hdnRoleId = (HiddenField)item.FindControl("hdnRoleId");
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
    protected void txtSlotDate_TextChanged(object sender, EventArgs e)
    {
        BindSlots();
        ErrorMessage.Visible = false;
    }

    protected void btnUploadFile_Click(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(6000);
        if (CurrentUser.CurrentParticipantId>0)
        {
            if(ItemId>0)
            {
                Item.NurturingProcessId = ItemId;
                if(flUpload.FileName.Length>0)
                {
                    clsFileUpload Upload = new clsFileUpload();
                    string strFilePath = Upload.NurturingProcessUploadDoc(flUpload);
                    Item.ReceiverImagePath = strFilePath;
                }
                Item.CreatedBy = CurrentUser.CurrentUserId;
                Item.UpdateExamFile(Item);
                FormMessage.Text = "New Answer Sheet Successfully Updated.";
                FormMessage.Visible = true;
                btnUploadFile.Enabled = false;

            }
            else
            {
                Response.Redirect("~/Login.html");
            }

        }
        else
        {
            Response.Redirect("~/Login.html");
        }

    }
}