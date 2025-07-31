using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

public partial class Admin_ActivityTaskInputs : System.Web.UI.Page
{
    clsActivityInteractions item = new clsActivityInteractions();
    int ItemId = 0;
    CurrentUser CurrentUser = new CurrentUser();
    clsActivityInstance Item = new clsActivityInstance();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        BindData();
        //Session["ActivityInstanceId"] = ItemId;
        if (!IsPostBack)
        {
            BindData();
            //if (ItemId > 0)
            // {
            lblTitle.Text = "Update Activity Task Inputs";
            Item = new clsActivityInstance();
            Item = Item.Load(ItemId);
            if (Item != null)
            {
                lblActivityCategory.Text = Convert.ToString(Item.ActivityCategory);
                lblActivitySubcategory.Text = Convert.ToString(Item.ActivitySubcategory);
                lblActivity.Text = Convert.ToString(Item.Activity);
                lblDescription.Text = Convert.ToString(Item.Description);
                lblInvolvedEmployees.Text = Convert.ToString(Item.InvolvedEmployees);
                lblInvolvedParticipants.Text = Convert.ToString(Item.InvolvedParticipants);
                lblInvolvedLeads.Text = Convert.ToString(Item.InvolvedLeads);
                lblInvolvedVendors.Text = Convert.ToString(Item.InvolvedVendors);
                hdnActivityId.Value = Convert.ToString(Item.ActivityId);
            }
            #region
            //item = item.Load(ItemId);
            //if (item != null)
            // {

            //    string ActivityInteractions = null;

            //    clsActivityInteractions obj = new clsActivityInteractions();
            //    obj.ActivityInstanceId = Convert.ToInt32(ItemId);
            //    List<clsActivityInteractions> obj1 =obj.LoadAll(obj);
            //if (obj1 != null)
            //{
            //    foreach (clsActivityInteractions obj3 in obj1 )
            //            {
            //            ActivityInteractions = ActivityInteractions + Convert.ToString( obj3.ActivityInteractionInputs.ToString());

            //            txtActivityDescription.Text = ActivityInteractions;


            //            }

            //txtActivityDescription.Text = obj.LoadAll(obj);

            //txtfollowup.Text = item.Description.ToString();
            #endregion

            int ActivityInstanceId = item.ActivityInstanceId;
            Session["ActivityInstanceId"] = ActivityInstanceId;
            int EmployeeId = Convert.ToInt32(item.EmployeeId);
            Session["EmployeeId"] = EmployeeId;
            // int ParticipantId = Convert.ToInt32(item.ParticipantId);

            // }

            //}
            // }

        }
        txtActivityInputs.Enabled = false;
        //btnbutton.Visible = false;
        btnEndActivity.Visible = false;
        btnUpdate.Enabled = false;
        txtsHours.Enabled = false;
        txtsmints.Enabled = false;
        txtEHours.Enabled = false;
        txtEmints.Enabled = false;
        //ddlEStartAMPM.Enabled = false;
        //ddlEEndAMPM.Enabled = false;
    }
    protected void BindData()
    {
        clsActivityInteractions obj = new clsActivityInteractions();
        obj.ActivityInstanceId = Convert.ToInt32(ItemId);
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    //protected void BindActivityInstance()
    //{
    //    clsActivityInstance obj = new clsActivityInstance();
    //    obj.ActivityInstanceId = Convert.ToInt32(ItemId);

    //}
    protected void btnEndActivity_Click(object sender, EventArgs e)
    {
        //if(ItemId>0)
        //{
        //    item.ActivityInteractionsId = Convert.ToInt32(ItemId);
        //}
        clsActivityInstance item = new clsActivityInstance();
        item = item.Load(ItemId);
        item.ActivityInstanceId = Convert.ToInt32(ItemId);
        item.Status = "Completed";
        item.AddUpdate(item);
    }
    protected void btnBackToList_Click(object sender, EventArgs e)
    {
        Response.Redirect("ActivityTasks.aspx");
    }

    protected void btnStartActivity_Click(object sender, EventArgs e)
    {

        //txtsHours.Text = DateTime.Now.ToString("HH");
        //txtsmints.Text = DateTime.Now.ToString("mm");




        //DateTime time = DateTime.Now;
        ////string s = time.ToString("yyyy.MM.dd hh:mm:ss t.\\M.");
        //txtTime.Text = time.ToString("t\\M");
        //if (txtTime.Text == "AM")
        //{
        //    ddlEStartAMPM.SelectedValue = "AM";
        //}
        //else
        //{
        //    ddlEStartAMPM.SelectedValue = "PM";
        //}

        //btnBackToList.Enabled = false;



        item.SystemStartTime = Convert.ToDateTime(DateTime.Now.ToString());
        item.SystemStartTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        Session["SystemStartTime"] = Convert.ToDateTime(item.SystemStartTime);


        //item.StartDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        //Session["StartDate"] = Convert.ToDateTime(item.StartDate);
        //txtActivityDescription.Enabled = true;
        txtActivityInputs.Enabled = true;
        btnStartActivity.Enabled = false;
        btnUpdate.Enabled = true;
        txtsHours.Enabled = true;
        txtsmints.Enabled = true;
        txtEHours.Enabled = true;
        txtEmints.Enabled = true;
        //ddlEStartAMPM.Enabled = true;
        //ddlEEndAMPM.Enabled = true;
    }

    #region

    //protected void btnFollowup_Click(object sender, EventArgs e)
    //{
    //    string url = "//ActivityFollowUp.aspx/";
    //    string script = "window.onload = function(){ confirm('";
    //   /* script += message*/;
    //    script += "');";
    //    script += "window.location = '";
    //    script += url;
    //    script += "'; }";
    //    ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
    //}

    //protected void btnFollowup_Command(object sender, CommandEventArgs e)
    //{
    //    if(e.CommandName=="cmdEdit")
    //    {
    //        Response.Redirect()
    //    }
    //}

    //protected void btnFollowup_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("<script language='javascript'>window.Confirm('Your Message');window.location='ActivityFollowUp.aspx';</script>");
    //}
    #endregion
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        Response.Redirect("ActivityFollowUp.aspx?ItemId=" + ItemId);
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ActivityInteractions.aspx?ItemId=" + ItemId);
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {

        //if(txtEHours.Text == "" || txtEmints.Text == "")
        //{
        //    txtEHours.Text = DateTime.Now.ToString("hh");
        //    txtEmints.Text = DateTime.Now.ToString("mm");



        //    DateTime time = DateTime.Now;
        //    txtTime.Text = time.ToString("t\\M");
        //    if (txtTime.Text == "AM")
        //    {
        //        ddlEStartAMPM.SelectedValue = "AM";
        //    }
        //    else
        //    {
        //        ddlEStartAMPM.SelectedValue = "PM";
        //    }

        //}
        //btnBackToList.Enabled = true;







        //if(ItemId>0)
        //{
        //    item.ActivityInteractionsId = Convert.ToInt32(ItemId);
        //}
        DateTime date = (DateTime.UtcNow.AddHours(5).AddMinutes(30));
        string date1 = Convert.ToString(date);
        string user = CurrentUser.CurrentName;
        item.ActivityInteractionInputs = Convert.ToString(txtActivityInputs.Text);
        item.ActivityInstanceId = Convert.ToInt32(ItemId);
        Session["ActivityInstanceId"] = ItemId;
        int ActivityCategoryId = Convert.ToInt32(Session["ActivityCategoryId"]);
        Session["ActivityCategoryId"] = ActivityCategoryId;
        int ActivitySubCategoryId = Convert.ToInt32(Session["ActivitySubCategoryId"]);
        Session["ActivitySubCategoryId"] = ActivitySubCategoryId;
        int ActivityId = Convert.ToInt32(Session["ActivityId"]);
        Session["ActivityId"] = ActivityId;
        //if (txtFollowupdate.Text != "")
        //{
        //    DateTime Date = DateTime.ParseExact(txtFollowupdate.Text, "mm/dd/yyyy", null);
        //    item.DateToWorkOn = Convert.ToDateTime(Date);
        //}
        //    string followup = Convert.ToString(txtfollowup.Text);
        //    string followupdescription = Convert.ToString(txtfollowupdescription.Text);
        DateTime date2 = (DateTime.UtcNow.AddHours(5).AddMinutes(30));
        string date3 = Convert.ToString(date2);
        //    string user1 = CurrentUser.CurrentName;
        //    item.Description = Convert.ToString(followupdescription + new string(' ', 10) + Environment.NewLine + followup + new string(' ', 10) + date3 + new string(' ', 10) + user1);
        //item.EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
        //item.EndDate = Convert.ToString(DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", null));
        //objInsert.EndDate = DateTime.Parse(txtEndDate.Text);
        item.CreatedBy = CurrentUser.CurrentUserId;
        item.SystemStartTime = Convert.ToDateTime(Session["SystemStartTime"]);
        //item.SystemEndTime = Convert.ToDateTime(DateTime.Now.ToString());
        item.SystemEndTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        DateTime dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        string stHours;
        if (txtsHours.Text.Length == 1)
        {
            stHours = "0" + txtsHours.Text;
        }
        else
        {
            stHours = txtsHours.Text;
        }
        string stTotalHours = stHours;
        //if (ddlEStartAMPM.SelectedIndex == 1) /**/
        //{
        //    int ESAddHours = 12;
        //    int SSHours = int.Parse(stTotalHours);
        //    int ESHours = ESAddHours + SSHours;
        //    stTotalHours = Convert.ToString(ESHours);
        //}
        //else
        //{
        //    stTotalHours = stHours;
        //}

        string stMin;
        if (txtsmints.Text.Length == 1)
        {
            stMin = "0" + txtsmints.Text;
        }
        else
        {
            stMin = txtsmints.Text;
        }

        DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy") + " " + stTotalHours + ":" + stMin, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
        item.EnteredStartTime = dt1;
        string etHours;
        if (txtEHours.Text.Length == 1)
        {
            etHours = "0" + txtEHours.Text;
        }
        else
        {
            etHours = txtEHours.Text;
        }
        string EEndTotalHours = etHours;
        //if (ddlEEndAMPM.SelectedIndex == 1)
        //{
        //    int EEAddHours = 12;
        //    int EEHours = int.Parse(EEndTotalHours);
        //    int EETotalHours = EEAddHours + EEHours;
        //    EEndTotalHours = Convert.ToString(EETotalHours);
        //}
        //else
        //{
        //    EEndTotalHours = etHours;
        //}
        string etMin;
        if (txtEmints.Text.Length == 1)
        {
            etMin = "0" + txtEmints.Text;
        }
        else
        {
            etMin = txtEmints.Text;
        }
        DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy") + " " + EEndTotalHours + ":" + etMin, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
        item.EnteredEndTime = dt2;
        item.Date = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null));
        //item.StartDate = Convert.ToDateTime(Session["StartDate"]);
        //item.EndDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        item.AddUpdate(item);
        BindData();
        btnEndActivity.Visible = true;
        btnStartActivity.Enabled = true;
        clsActivityInstance obj = new clsActivityInstance();
        obj = obj.Load(ItemId);
        if (ItemId == 0)
        {
            obj.ActivityInstanceId = Convert.ToInt32(ItemId);
        }
        obj.Status = "InProgress";
        obj.AddUpdate(obj);
        //btnbutton.Visible = true;
        BindData();
        txtActivityInputs.Text = "";
        txtsHours.Text = "";
        txtsmints.Text = "";
        txtEHours.Text = "";
        txtEmints.Text = "";
        //ddlEStartAMPM.SelectedIndex = 0;
        //ddlEEndAMPM.SelectedIndex = 0;
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
    protected void gv_PreRender(object sender, EventArgs e)
    {
        PageNumberHeader.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberHeader.Font.Bold = true;
        PageNumberFooter.Text = " Displaying Page " + (gv.PageIndex + 1).ToString() + " of " + gv.PageCount.ToString();
        PageNumberFooter.ForeColor = System.Drawing.Color.LightSteelBlue;
        PageNumberFooter.Font.Bold = true;
    }

    protected void txtsHours_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtsmints_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtEHours_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }

    protected void txtEmints_TextChanged(object sender, EventArgs e)
    {
        BindData();
    }


}