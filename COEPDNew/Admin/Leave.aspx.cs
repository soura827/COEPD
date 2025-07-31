using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Leave : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsLeave Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsLeave();
        if (!IsPostBack)
        {
            bindLeaveType();
            Bindday();
            BindMonths();
            BindYears();
            BindReportedEmploye();
            if (ItemId > 0)
            {
                if (Item != null)
                {
                    lblTitle.Text = "Edit Associate Leave Form";
                    Item = Item.Load(ItemId);
                    ddlLeavetype.SelectedValue = Item.LeaveTypeId.ToString();
                    DateTime date =(DateTime) Item.FromDate;
                    ddlFromDay.SelectedValue = date.Day.ToString();
                    ddlFromMonth.SelectedValue = date.Month.ToString();
                    ddlFromYear.SelectedValue = date.Year.ToString();
                     date = (DateTime)Item.ToDate;
                    ddlToday.SelectedValue = date.Day.ToString();
                    ddlToMonth.SelectedValue = date.Month.ToString();
                    ddlToYear.SelectedValue = date.Year.ToString();
                    ddlRepotedEmployee.SelectedValue = Item.ReportingEmployeeId.ToString();
                    txtDescription.Text = Item.Notes;
                }
            }
            else
            {
                lblTitle.Text = " Associate Leave Form";
            }
        }
    }

    private IList<int> days()
    {
        List<int> item = new List<int>();
        for (int i = 1; i <= 31; i++)
        {
            item.Add(i);
        }
        return item;
    }
    private IList<int> Months()
    {
        List<int> item = new List<int>();
        for (int i = 1; i <= 12; i++)
        {
            item.Add(i);
        }
        return item;
    }
    private IList<int> Years()
    {
        List<int> item = new List<int>();
        int year = Convert.ToInt32(DateTime.Now.Year);
        for (int i = 1; i <= 5; i++)
        {
            item.Add(year);
            year++;
        }
        return item;
    }
    private DateTime Date(string yyyy, string mm, string dd)
    {
        DateTime item = new DateTime(Convert.ToInt32(yyyy), Convert.ToInt32(mm), Convert.ToInt32(dd));
       // item = DateTime.ParseExact(item.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null);
        return item;
    }

    protected void bindLeaveType()
    {
        clsLeaveType objLeave = new clsLeaveType();
        ddlLeavetype.DataSource = objLeave.LoadAll(objLeave);
        ddlLeavetype.DataValueField = "LeaveTypeId";
        ddlLeavetype.DataTextField = "LeaveType";
        ddlLeavetype.DataBind();
        ddlLeavetype.Items.Insert(0, new ListItem("--Select LeaveType --", ""));
    }
    protected void Bindday()
    {
        IList<int> day = days();
        ddlFromDay.DataSource = day;
        ddlFromDay.DataBind();
        ddlFromDay.Items.Insert(0, new ListItem("DD", ""));
        ddlToday.DataSource = day;
        ddlToday.DataBind();
        ddlToday.Items.Insert(0, new ListItem("DD", ""));

    }
    protected void BindMonths()
    {
        IList<int> Month = Months();
        ddlFromMonth.DataSource = Month;
        ddlFromMonth.DataBind();
        ddlFromMonth.Items.Insert(0, new ListItem("MM", ""));
        ddlToMonth.DataSource = Month;
        ddlToMonth.DataBind();
        ddlToMonth.Items.Insert(0, new ListItem("MM", ""));
    }
    protected void BindYears()
    {
        IList<int> Year = Years();
        ddlFromYear.DataSource = Year;
        ddlFromYear.DataBind();
        ddlFromYear.Items.Insert(0, new ListItem("YYYY", ""));
        ddlToYear.DataSource = Year;
        ddlToYear.DataBind();
        ddlToYear.Items.Insert(0, new ListItem("YYYY", ""));

    }

    protected void BindReportedEmploye()
    {
        clsEmployee objemp = new clsEmployee();
        objemp.EmployeeId = CurrentUser.CurrentEmployeeId;
        ddlRepotedEmployee.DataSource = objemp.LoadAllEmployee(objemp);
        ddlRepotedEmployee.DataValueField = "EmployeeId";
        ddlRepotedEmployee.DataTextField = "Employee";
        ddlRepotedEmployee.DataBind();
        ddlRepotedEmployee.Items.Insert(0, new ListItem("-- Select Employee --", ""));

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.LeaveId = Convert.ToInt16(ItemId);
        }
        Item.EmployeeId = CurrentUser.CurrentEmployeeId;
        Item.FromDate = Date(ddlFromYear.SelectedValue, ddlFromMonth.SelectedValue, ddlFromDay.SelectedValue);
        Item.ToDate = Date(ddlToYear.SelectedValue, ddlToMonth.SelectedValue, ddlToday.SelectedValue);
        Item.ReportingEmployeeId = Convert.ToInt32(ddlRepotedEmployee.SelectedValue);
        Item.Notes = txtDescription.Text;
        Item.LeaveTypeId = Convert.ToInt16(ddlLeavetype.SelectedValue);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("LeaveSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("LeaveSearch.aspx");
    }
}