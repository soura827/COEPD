using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ChangeSlot : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsNurturingProcessSlots Item;
    int ItemId = 0;
    int ActionValue = 0;
    int SlotsCount = 0;
    int NurturingProcessSlotsId = 0;
    int EmployeeId = 0;
    DateTime SlotDate;
    DateTime SlotStartTime;
    DateTime SlotEndTime;
    string StartEndTime = "";
    //DateTime LastSlotStartTime;
    DateTime SlotPriorityStartTime;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsNurturingProcessSlots();
        if(ItemId>0)
        {
            Item = Item.Load(ItemId);
            if(Item !=null)
            {
                lblParticipant.Text = Item.Participant;
                lblStageTask.Text = Item.NurturingProcessStageTaskName;
                lblMentor.Text = Item.Employee;
                //lblSlotDate.Text = Item.SlotDate.ToString("dd/MM/yyyy");
                lblSlotDate.Text = Convert.ToString(Item.SlotDate);
                lblSlotTime.Text = Item.StartEndTime;
                hdnStageTaskId.Value = Item.NurturingProcessStageTaskId.ToString();
                hdnSlotStartTime.Value = Item.SlotStartTime.ToString();
                hdnParticipantId.Value = Item.ParticipantId.ToString();
                hdnNurturingProcessId.Value = Item.NurturingProcessId.ToString();
            }
        }
        else
        {
            Response.Redirect("NurturingAvilableSlotsSearchAll.aspx");
        }
        if(!IsPostBack)
        {

        }
    }

    protected void BindChangeMentorSlots()
    {
        ddlMentor.Items.Clear();
        //DateTime Date = DateTime.ParseExact(txtSlotDate.Text, "dd/MM/yyyy", null);
        clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
        obj.NurturingProcessStageTaskId = Convert.ToInt16(hdnStageTaskId.Value);
        obj.SlotStartTime = Convert.ToDateTime(hdnSlotStartTime.Value);
        ddlMentor.DataSource = obj.LoadChangeMentorAll(obj);
        ddlMentor.DataTextField = "Employee";
        ddlMentor.DataValueField = "NurturingProcessSlotsId";
        ddlMentor.DataBind();
        if (ddlMentor.Items.Count == 0)
        {
            ddlMentor.Items.Insert(0, new ListItem("--- No Mentors Available --", ""));
            //ddlMentor.Items[0].Attributes.Add("style", "background-color:red");
        }

        else
        {
            ddlMentor.Items.Insert(0, new ListItem("--- Select Mentors ---", ""));

        }
    }
    protected void BindNewTimeSlots()

    {
        ddlSlotTime.Items.Clear();
        if (txtSlotDate.Text != "")
        {
            SlotPriorityStartTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        }

        DateTime Date = DateTime.ParseExact(txtSlotDate.Text, "dd/MM/yyyy", null);
        clsNurturingProcessSlots obj = new clsNurturingProcessSlots();
        obj.NurturingProcessStageTaskId = Convert.ToInt16(hdnStageTaskId.Value);
        obj.SlotDate = Convert.ToDateTime(Date);
        obj.SlotStartTime = Convert.ToDateTime(SlotPriorityStartTime);
        ddlSlotTime.DataSource = obj.LoadPriorityAll(obj);
        ddlSlotTime.DataTextField = "StartEndTime";
        ddlSlotTime.DataValueField = "NurturingProcessSlotsId";
        ddlSlotTime.DataBind();
        if (ddlSlotTime.Items.Count == 0)
        {
            ddlSlotTime.Items.Insert(0, new ListItem("--- No Time Slots Available - Try Next Day ---", ""));
        }
        else
        {
            ddlSlotTime.Items.Insert(0, new ListItem("--- Select Time Slot ---", ""));
        }
    }

    protected void BindDuplicateSlotsCount()
    {
            clsNurturingProcessSlots objSlots = new clsNurturingProcessSlots();
            objSlots.NurturingProcessSlotsId = Convert.ToInt32(ddlMentor.SelectedValue);
            SlotsCount = objSlots.LoadSlotValidation(objSlots);
        
    }
    protected void BindDuplicateSlotsTimeCount()
    {
        if(Convert.ToInt32(ddlSlotTime.SelectedValue) !=0)
        {
            clsNurturingProcessSlots objSlots = new clsNurturingProcessSlots();
            objSlots.NurturingProcessSlotsId = Convert.ToInt32(ddlSlotTime.SelectedValue);
            SlotsCount = objSlots.LoadSlotValidation(objSlots);
        }
        
    }
    protected void txtSlotDate_TextChanged(object sender, EventArgs e)
    {
        BindNewTimeSlots();

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("NurturingAvilableSlotsSearchAll.aspx");
    }

    protected void ddlAction_SelectedIndexChanged(object sender, EventArgs e)
    {
        ActionValue = Convert.ToInt16(ddlAction.SelectedValue);
        if(ActionValue == 0)
        {
            btnSelectAction.Visible = true;
            btnCalcelSlot.Visible = false;
            btnModifySlot.Visible = false;
            btnChangeMentor.Visible = false;

            lblNewSlotDate.Visible = false;
            txtSlotDate.Visible = false;
            lblNewMentor.Visible = false;
            ddlMentor.Visible = false;
            lblNewSlotTime.Visible = false;
            ddlSlotTime.Visible = false;

        }
        else if (ActionValue ==1)
        {
            btnSelectAction.Visible = false;
            btnCalcelSlot.Visible = true;
            btnModifySlot.Visible = false;
            btnChangeMentor.Visible = false;

            lblNewSlotDate.Visible = false;
            txtSlotDate.Visible = false;
            lblNewMentor.Visible = false;
            ddlMentor.Visible = false;
            lblNewSlotTime.Visible = false;
            ddlSlotTime.Visible = false;
            ActionValue = 1;
        }
        else if (ActionValue == 2)
        {
            btnSelectAction.Visible = false;
            btnCalcelSlot.Visible = false;
            btnModifySlot.Visible = true;
            btnChangeMentor.Visible = false;

            lblNewSlotDate.Visible = true;
            txtSlotDate.Visible = true;
            lblNewMentor.Visible = false;
            ddlMentor.Visible = false;
            lblNewSlotTime.Visible = true;
            ddlSlotTime.Visible = true;
        }
        else if (ActionValue == 3)
        {
            BindChangeMentorSlots();
            btnSelectAction.Visible = false;
            btnCalcelSlot.Visible = false;
            btnModifySlot.Visible = false;
            btnChangeMentor.Visible = true;

            lblNewSlotDate.Visible = false;
            txtSlotDate.Visible = false;
            lblNewMentor.Visible = true;
            ddlMentor.Visible = true;
            lblNewSlotTime.Visible = false;
            ddlSlotTime.Visible = false;
        }
    }

    protected void btnSelectAction_Click(object sender, EventArgs e)
    {

    }

    protected void btnCalcelSlot_Click(object sender, EventArgs e)
    {
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.SlotsStatusId = 8;
            Item.ActionValue = Convert.ToInt32(ddlAction.SelectedValue);
            Item.CancelSlot(Item);
            //BindMessage();
            btnCalcelSlot.Enabled = false;
        Response.Redirect("NurturingAvilableSlotsSearchAll.aspx");
        
    }

    protected void btnModifySlot_Click(object sender, EventArgs e)
    {
        BindDuplicateSlotsTimeCount();
        if (SlotsCount > 0)
        {
            txtSlotDate.Text = "";
            ddlMentor.SelectedIndex = -1;
            ErrorMessage.Text = "This Slot already booked. Please select other Slot.";
            ErrorMessage.Visible = true;
        }
        else
        {
            clsNurturingProcessSlots Obj = new clsNurturingProcessSlots();
            NurturingProcessSlotsId = Convert.ToInt32(ddlSlotTime.SelectedValue);
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
                    Obj.ParticipantId = Convert.ToInt32(hdnParticipantId.Value);
                    Obj.SlotDate = Convert.ToDateTime(SlotDate);
                    Obj.SlotStartTime = Convert.ToDateTime(SlotStartTime);
                    Obj.SlotEndTime = Convert.ToDateTime(SlotEndTime);
                    Obj.IsSlotAssigned = true;
                    Obj.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                    Obj.StartEndTime = Convert.ToString(StartEndTime);
                    Obj.NurturingProcessId = Convert.ToInt32(hdnNurturingProcessId.Value);
                    Obj.SlotsStatusId = 2;
                    Obj.AddUpdate(Obj);
                }
            }
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.SlotsStatusId = 10;
            Item.ActionValue = Convert.ToInt32(ddlAction.SelectedValue);
            Item.NurturingProcessId = Convert.ToInt32(hdnNurturingProcessId.Value);
            Item.NewNurturingProcessSlotsId = Convert.ToInt32(ddlSlotTime.SelectedValue);
            Item.CancelSlot(Item);
            //BindMessage();
            btnModifySlot.Enabled = false;
            Response.Redirect("NurturingAvilableSlotsSearchAll.aspx");
            if (ItemId > 0)
            {
                FormMessage.Text = "Slot Successfully Changed.";
                FormMessage.Visible = true;
                btnChangeMentor.Enabled = false;
                ErrorMessage.Visible = false;
            }

        }

    }

    protected void btnChangeMentor_Click(object sender, EventArgs e)
    {
        BindDuplicateSlotsCount();
        if (SlotsCount > 0)
        {
            txtSlotDate.Text = "";
            ddlMentor.SelectedIndex = -1;
            ErrorMessage.Text = "This Slot already booked. Please select other Mentor.";
            ErrorMessage.Visible = true;
        }
        else
            {
            clsNurturingProcessSlots Obj = new clsNurturingProcessSlots();
            NurturingProcessSlotsId = Convert.ToInt32(ddlMentor.SelectedValue);
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
                    Obj.ParticipantId = Convert.ToInt32(hdnParticipantId.Value);
                    Obj.SlotDate = Convert.ToDateTime(SlotDate);
                    Obj.SlotStartTime = Convert.ToDateTime(SlotStartTime);
                    Obj.SlotEndTime = Convert.ToDateTime(SlotEndTime);
                    Obj.IsSlotAssigned = true;
                    Obj.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                    Obj.StartEndTime = Convert.ToString(StartEndTime);
                    Obj.NurturingProcessId = Convert.ToInt32(hdnNurturingProcessId.Value);
                    Obj.SlotsStatusId = 2;
                    Obj.AddUpdate(Obj);
                }
            }
            clsNurturingProcessSlots Item = new clsNurturingProcessSlots();
            if (ItemId > 0)
            {
                Item.NurturingProcessSlotsId = Convert.ToInt32(ItemId);
            }
            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.SlotsStatusId = 9;
            Item.ActionValue = Convert.ToInt32(ddlAction.SelectedValue);
            Item.NurturingProcessId = Convert.ToInt32(hdnNurturingProcessId.Value);
            Item.NewNurturingProcessSlotsId = Convert.ToInt32(ddlMentor.SelectedValue);
            Item.CancelSlot(Item);
            //BindMessage();
            btnChangeMentor.Enabled = false;
            Response.Redirect("NurturingAvilableSlotsSearchAll.aspx");
            if (ItemId > 0)
            {
                FormMessage.Text = "Mentor Successfully Changed.";
                FormMessage.Visible = true;
                btnChangeMentor.Enabled = false;
                ErrorMessage.Visible = false;
            }
        }
    }
}