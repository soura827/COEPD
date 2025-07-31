using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Participant_HrProcess : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsHrProcess Item;
    int ItemId = 0;
    int HrProcessSlotsId = 0;
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
        Item = new clsHrProcess();
        //BindTopOneSlot();
        //BindSlots();
        if (!IsPostBack)
        {
            //BindTopOneSlot();
            //BindSlots();
            if (ItemId > 0)
            {
                lblTitle.Text = "Hr Process - Assigned Exam";
                Item = Item.Load(ItemId);
                BindSlots();
                if (Item != null)
                {
                    // clsHrProcessStageTask HrProcessStageTask = new clsHrProcessStageTask();
                    //HrProcessStageTask = HrProcessStageTask.Load(Convert.ToInt16(Item.HrProcessStageTaskId));

                    // clsHrProcessStage  HrProcessStage = new clsHrProcessStage();
                    // HrProcessStage = HrProcessStage.Load(Convert.ToInt16(Item.HrProcessStageTaskId));

                    // BindTopOneSlot();
                    // BindData();
                    // lblStage.Text = Convert.ToString(HrProcessStage.HrProcessStageName);
                    // lblStageTask.Text = Convert.ToString(HrProcessStageTask.HrProcessStageTaskName);
                    lblNotes.Text = Item.Notes;
                    lblTargetDate.Text = Item.TargetDate.ToString("dd/MM/yyyy");
                    if (Item.HrProcessSlotsId > 0)
                    {
                        //txtSlotDate.Enabled = false;
                        //ddlAvilableSlots.Visible = false;
                        // lblAvilableSlots.Visible = true;
                        clsHrProcessSlots HrProcessSlots = new clsHrProcessSlots();
                        HrProcessSlots = HrProcessSlots.Load(Convert.ToInt32(Item.HrProcessSlotsId));
                        //txtSlotDate.Text = HrProcessSlots.SlotDate.ToString("dd/MM/yyyy");
                        //lblAvilableSlots.Text = HrProcessSlots.StartEndTime;
                        //btnSubmit.Visible = false;
                        //FileUpload1.Visible = false;
                        //btnUploadFile.Visible = true;

                    }
                    else
                    {
                        //lblAvilableSlots.Visible = false;
                    }
                    if (Item.IsApproved == true)
                    {
                        lblStatus.Text = "Approved";
                        btnSubmit.Visible = false;
                        //btnUploadFile.Visible = false;
                        // FileUpload1.Visible = false;
                        //txtSlotDate.Visible = false;
                        ddlAvilableSlots.Visible = false;
                        //lblSelectSlotDate.Visible = false;
                        //lblSelectSlot.Visible = false;

                    }
                    else
                    {
                        lblStatus.Text = "Not Approved";
                    }


                }
            }
            else
            {
                Response.Redirect("HrProcessSearch.aspx");
            }
        }


    }
    //protected void BindTopOneSlot()
    //{
    //    clsParticipant Participant = new clsParticipant();
    //    Participant = Participant.Load(CurrentUser.CurrentParticipantId);
    //    if (Participant != null)
    //    {
    //        LastSlotStartTime = Convert.ToDateTime(Participant.LastSlotStartTime);
    //    }
    //    if (LastSlotStartTime < DateTime.UtcNow.AddHours(-6).AddMinutes(30))
    //    {
    //        SlotPriorityStartTime = DateTime.UtcNow.AddHours(8).AddMinutes(30);
    //    }
    //    else
    //    {
    //        SlotPriorityStartTime = LastSlotStartTime.AddHours(15);
    //    }
    //    clsHrProcessSlots obj = new clsHrProcessSlots();
    //    //obj.HrProcessStageTaskId = Convert.ToInt32(hdnStageTaskId.Value);
    //    obj.SlotStartTime = Convert.ToDateTime(SlotPriorityStartTime);
    //    obj = obj.LoadTopOne(obj);
    //    if (obj != null)
    //    {
    //        DateTime Date = Convert.ToDateTime(obj.SlotStartTime);
    //        lblNextAvailableSlots.Text = "Next Time Slot Available From " + Date.ToString("dd MMM yyyy hh:mm tt");
    //    }
    //    else
    //    {
    //        lblNextAvailableSlots.Text = "Please raise Service Request to release next batch of slots ...";
    //    }


    //}

    protected void BindDates()
    {
        clsHrProcessSlots obj = new clsHrProcessSlots();
        ddlAvilableSlots.DataSource = obj.LoadPriorityAll(obj);
        ddlAvilableSlots.DataTextField = "StartEndTime";
        ddlAvilableSlots.DataValueField = "SlotDate";
        ddlAvilableSlots.DataBind();
        //BindSlots();
        //if (ddlAvilableSlots.Items.Count == 0)
        //{
        //    ddlAvilableSlots.Items.Insert(0, new ListItem("--- No Time Slots Available - Try Next Day ---", ""));
        //    ddlAvilableSlots.Items[0].Attributes.Add("style", "background-color:red");
        //    //BindTopOneSlot();
        //}

        //else
        //{
        //    ddlAvilableSlots.Items.Insert(0, new ListItem("--- Select Time Slot ---", ""));

        //}

    }

    protected void BindSlots()
    {
        int data;

        if (ViewState["HrProcessStageTaskId"] != null)
        {
            // Retrieve the value from ViewState if it exists.
            data = (int)ViewState["HrProcessStageTaskId"];
        }
        else
        {
            // If ViewState doesn't contain the value, initialize it here.
            data = Item.HrProcessStageTaskId;

            // Store the value in ViewState to maintain it between postbacks.
            ViewState["HrProcessStageTaskId"] = data;
        }

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
            clsHrProcessSlots obj = new clsHrProcessSlots();
            obj.HrProcessStageTaskId = data; // Use the data variable here.
            obj.SlotDate = Convert.ToDateTime(Date);
            obj.SlotStartTime = Convert.ToDateTime(SlotPriorityStartTime);
            ddlAvilableSlots.Items.Clear();
            ddlAvilableSlots.DataSource = obj.LoadPriorityAll(obj);
            ddlAvilableSlots.DataTextField = "StartEndTime";
            ddlAvilableSlots.DataValueField = "HrProcessSlotsId";
            ddlAvilableSlots.DataBind();
            if (ddlAvilableSlots.Items.Count == 0 || ddlAvilableSlots.DataSource == null)
            {
                ddlAvilableSlots.Items.Insert(0, new ListItem("--- No Time Slots Available - Try Next Day ---", ""));
                ddlAvilableSlots.Items[0].Attributes.Add("style", "background-color:red");
                //BindTopOneSlot();
            }
            else
            {
                ddlAvilableSlots.Items.Insert(0, new ListItem("--- Select Time Slot ---", ""));
            }
        }
    }






    protected void BindDuplicateSlotsCount()
    {
        clsHrProcessSlots objSlots = new clsHrProcessSlots();
        objSlots.HrProcessSlotsId = Convert.ToInt32(ddlAvilableSlots.SelectedValue);
        SlotsCount = objSlots.LoadSlotValidation(objSlots);

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        #region
        // System.Threading.Thread.Sleep(3000);
        // BindDuplicateSlotsCount();
        //if (SlotsCount > 0)
        //{
        //    //txtSlotDate.Text = "";
        //    ddlAvilableSlots.SelectedIndex = -1;
        //    ErrorMessage.Text = "This Slot already booked. Please select other slot.";
        //    ErrorMessage.Visible = true;
        //}
        #endregion


        clsHrProcessSlots objSlots = new clsHrProcessSlots();
        objSlots.EmployeeId = EmployeeId;
        objSlots.SlotDate = SlotDate;
        objSlots.IsSlotAssigned = true;
        objSlots.ParticipantId = Convert.ToInt32(CurrentUser.CurrentParticipantId);
        List<clsHrProcessSlots> slotData = new clsHrProcessSlots().LoadAllParticipant(objSlots);

        if (slotData != null && slotData.Count > 0)
        {
            bool isSlotAssigned = slotData[0].IsSlotAssigned;

            if (isSlotAssigned)
            {
                ddlAvilableSlots.SelectedIndex = -1;
                ErrorMessage.Text = "This Slot already booked. Please select other slot.";
                ErrorMessage.Visible = true;
            }
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
                        Item.HrProcessId = ItemId;
                    }
                    Item.ParticipantId = Convert.ToInt32(CurrentUser.CurrentParticipantId);

                    //if (flUpload.FileName.Length > 0)
                    //{
                    //    clsFileUpload Upload = new clsFileUpload();
                    //    string strFilePath = Upload.HrProcessUploadDoc(flUpload);
                    //    Item.ReceiverImagePath = strFilePath;
                    //}
                    Item.ExamDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                    Item.ApprovedBy = 0;
                    Item.IsApproved = false;
                    if (lblTargetDate.Text != "")
                    {
                        DateTime Date = DateTime.ParseExact(lblTargetDate.Text, "dd/MM/yyyy", null);
                        Item.TargetDate = Convert.ToDateTime(Date);
                    }
                    Item.CreatedBy = CurrentUser.CurrentUserId;
                    Item.HrProcessSlotsId = Convert.ToInt32(ddlAvilableSlots.SelectedValue);
                    Item.AddUpdate(Item);


                    clsHrProcessSlots Obj = new clsHrProcessSlots();
                    HrProcessSlotsId = Convert.ToInt32(ddlAvilableSlots.SelectedValue);
                    if (HrProcessSlotsId > 0)
                    {

                        Obj = Obj.Load(HrProcessSlotsId);
                        if (Obj != null)
                        {
                            EmployeeId = Convert.ToInt32(Obj.EmployeeId);
                            SlotDate = Convert.ToDateTime(Obj.SlotDate);
                            SlotStartTime = Convert.ToDateTime(Obj.SlotStartTime);
                            SlotEndTime = Convert.ToDateTime(Obj.SlotEndTime);
                            StartEndTime = Convert.ToString(Obj.StartEndTime);

                            Obj.HrProcessSlotsId = HrProcessSlotsId;
                            Obj.EmployeeId = EmployeeId;
                            //Obj.HrProcessStageTaskId = Convert.ToInt16(hdnStageTaskId.Value);
                            Obj.ParticipantId = Convert.ToInt32(CurrentUser.CurrentParticipantId);
                            Obj.SlotDate = Convert.ToDateTime(SlotDate);
                            Obj.SlotStartTime = Convert.ToDateTime(SlotStartTime);
                            Obj.SlotEndTime = Convert.ToDateTime(SlotEndTime);
                            Obj.IsSlotAssigned = true;
                            Obj.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                            Obj.StartEndTime = Convert.ToString(StartEndTime);
                            Obj.HrProcessId = Convert.ToInt32(ItemId);
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
        Response.Redirect("HrProcessSearch.aspx");
    }
    //protected void btnSend_Click(object sender, EventArgs e)
    //{
    //    if (txtNotes.Text.Length > 0)
    //    {
    //        clsHrChat ParticipantHrChat = new clsHrChat();
    //        ParticipantHrChat.ParticipantId = Convert.ToInt16(CurrentUser.CurrentParticipantId);
    //        ParticipantHrChat.Chat = txtNotes.Text;
    //        ParticipantHrChat.HrProcessStageId = Convert.ToInt16(hdnStageId.Value);
    //        ParticipantHrChat.HrProcessStageTaskId = Convert.ToInt16(hdnStageTaskId.Value);
    //        ParticipantHrChat.CreatedBy = CurrentUser.CurrentUserId;
    //        ParticipantHrChat.AddUpdate(ParticipantHrChat);
    //        txtNotes.Text = "";
    //        //FormMessage.Text = "Your request is successfully sent.";
    //        //FormMessage.Visible = true;
    //        Response.Redirect("HrProcess.aspx?ItemId=" + ItemId);
    //    }
    //}
    //protected void BindData()
    //{
    //    clsHrChat HrChat = new clsHrChat();
    //    HrChat.HrProcessStageId = Convert.ToInt16(Item.HrProcessStageId);
    //    HrChat.ParticipantId = CurrentUser.CurrentParticipantId;
    //    rp.DataSource = HrChat.LoadAll(HrChat);
    //    rp.DataBind();
    //}
    //protected void rp_OnItemDataBound(object sender, RepeaterItemEventArgs e)
    //{
    //    RepeaterItem item = e.Item;
    //    if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
    //    {
    //        HiddenField hdnRoleId = (HiddenField)item.FindControl("hdnRoleId");
    //        int RoleId = Convert.ToInt16(hdnRoleId.Value);
    //        if (RoleId == 3)
    //        {
    //            Panel pnlIn = (Panel)item.FindControl("pnlIn");
    //            pnlIn.Visible = true;
    //        }
    //        else
    //        {
    //            Panel PnlOut = (Panel)item.FindControl("PnlOut");
    //            PnlOut.Visible = true;
    //        }
    //    }
    //}
    protected void txtSlotDate_TextChanged(object sender, EventArgs e)
    {
        BindSlots();
        ErrorMessage.Visible = false;
    }

    //protected void btnUploadFile_Click(object sender, EventArgs e)
    //{
    //    //System.Threading.Thread.Sleep(6000);
    //    if (CurrentUser.CurrentParticipantId > 0)
    //    {
    //        if (ItemId > 0)
    //        {
    //            Item.HrProcessId = ItemId;
    //            if (flUpload.FileName.Length > 0)
    //            {
    //                clsFileUpload Upload = new clsFileUpload();
    //                string strFilePath = Upload.HrProcessUploadDoc(flUpload);
    //                Item.ReceiverImagePath = strFilePath;
    //            }
    //            Item.CreatedBy = CurrentUser.CurrentUserId;
    //            Item.UpdateExamFile(Item);
    //            //FormMessage.Text = "New Answer Sheet Successfully Updated.";
    //            //FormMessage.Visible = true;
    //            btnUploadFile.Enabled = false;

    //        }
    //        else
    //        {
    //            Response.Redirect("~/Login.html");
    //        }

    //    }
    //    else
    //    {
    //        Response.Redirect("~/Login.html");
    //    }
    //}
}