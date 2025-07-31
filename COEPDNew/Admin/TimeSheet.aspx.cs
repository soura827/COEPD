using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class TimeSheet : System.Web.UI.Page
{
    clsTimeSheet Item;
    int ItemId = 0;
    CurrentUser CurrentUser = new CurrentUser();

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt32(Request.QueryString["ItemId"]);
        Item = new clsTimeSheet();

        if (!IsPostBack)
        {
            LoadClient();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit TimeSheet";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    if (Item.StartTime != null)
                    {
                        DateTime dtStartTime = Convert.ToDateTime(Item.StartTime);
                        txtsHours.Text = dtStartTime.Hour.ToString();
                        txtsmints.Text = dtStartTime.Minute.ToString();
                    }
                    if (Item.EndTime != null)
                    {
                        DateTime dtEndTime = Convert.ToDateTime(Item.EndTime);
                        txtEHours.Text = dtEndTime.Hour.ToString();
                        txtEmints.Text = dtEndTime.Minute.ToString();
                    }
                    txtNote.Text = Item.Note;

                    clsProject Obj = new clsProject();
                    Obj = Obj.Load(Item.ProjectId);
                    ddlClient.SelectedValue = Obj.ClientId.ToString();
                    LoadProject();
                    ddlProject.SelectedValue = Convert.ToString(Item.ProjectId);
                }
            }
            else
            {
                lblTitle.Text = "Add New TimeSheet";
                LoadProject();
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.TimeSheetId = Convert.ToInt32(ItemId);
        }

        Item.EmployeeId = CurrentUser.CurrentEmployeeId;
        DateTime dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);

        if (txtsHours.Text.Length > 0)
        {
            string stHours;
            if (txtsHours.Text.Length == 1)
            {
                stHours = "0" + txtsHours.Text;
            }
            else
            {
                stHours = txtsHours.Text;
            }

            string stMin;
            if (txtsmints.Text.Length == 1)
            {
                stMin = "0" + txtsmints.Text;
            }
            else
            {
                stMin = txtsmints.Text;
            }

            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy") + " " + stHours + ":" + stMin, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            Item.StartTime = dt1;
        }

        if (txtEHours.Text.Length > 0)
        {
            string etHours;
            if (txtEHours.Text.Length == 1)
            {
                etHours = "0" + txtEHours.Text;
            }
            else
            {
                etHours = txtEHours.Text;
            }

            string etMin;
            if (txtEmints.Text.Length > 0)
            {
                if (txtEmints.Text.Length == 1)
                {
                    etMin = "0" + txtEmints.Text;
                }
                else
                {
                    etMin = txtEmints.Text;
                }
            }
            else
            {
                etMin = "00";
            }


            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy") + " " + etHours + ":" + etMin, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            Item.EndTime = dt1;
        }
        Item.Date = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null));
        Item.Note = Convert.ToString(txtNote.Text);
        Item.ProjectId = Convert.ToInt32(ddlProject.SelectedValue.ToString());
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);

        Response.Redirect("TimeSheetSearch.aspx");

    }

    protected void LoadProject()
    {
        ddlProject.Items.Clear();
        if (ddlClient.SelectedIndex > 0)
        {
            clsProject obj = new clsProject();
            obj.ClientId = Convert.ToInt32(ddlClient.SelectedValue);
            ddlProject.DataSource = obj.LoadAll(obj);
            ddlProject.DataTextField = "Project";
            ddlProject.DataValueField = "ProjectId";
            ddlProject.DataBind();
        }
        ddlProject.Items.Insert(0, new ListItem("-- Select --", ""));
    }

    protected void LoadClient()
    {
        ddlClient.Items.Clear();
        clsEmpClientAccess obj = new clsEmpClientAccess();
        obj.EmployeeId = CurrentUser.CurrentEmployeeId;
        ddlClient.DataSource = obj.LoadAll(obj);
        ddlClient.DataTextField = "Client";
        ddlClient.DataValueField = "ClientId";
        ddlClient.DataBind();
        ddlClient.Items.Insert(0, new ListItem("-- Select Client --", ""));
    }

    protected void ddlClient_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadProject();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TimeSheetSearch.aspx");
    }

}