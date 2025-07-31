using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLayer;

public partial class Counselling : System.Web.UI.Page
{
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

    CurrentUser CurrentUser = new CurrentUser();
    clsCounselling Item;
    int ItemId = 0;
    DateTime dt;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsCounselling();
        if (!IsPostBack)
        {
            BindEmployee();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Counselling Details";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    ddlEmployee.SelectedValue = Item.EmployeeId.ToString();
                    txtVisitor.Text = Item.Counselling;
                    txtComments.Text = Item.Comments;
                    txtRemarks.Text = Item.Remarks;
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
                    }
                }
            }
            else
            {
                lblTitle.Text = "Add New Counselling Details";
            }
        }
    }
    protected void BindEmployee()
    {
        clsEmployee obj = new clsEmployee();
        ddlEmployee.DataSource = obj.LoadAll(obj);
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("--Select Employee--", ""));
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.CounsellingId = Convert.ToInt16(ItemId);
        }
        DateTime dtime = DateTime.UtcNow.AddHours(5).AddMinutes(30);

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

            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(dtime.ToString("dd/MM/yyyy") + " " + stHours + ":" + stMin, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
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
            if (txtEmints.Text.Length == 1)
            {
                etMin = "0" + txtEmints.Text;
            }
            else
            {
                etMin = txtEmints.Text;
            }
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(dtime.ToString("dd/MM/yyyy") + " " + etHours + ":" + etMin, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            Item.EndTime = dt1;
        }
        dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        Item.Date = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null));
        Item.LeadId = 0;
        Item.Counselling = txtVisitor.Text;
        Item.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        Item.Comments = Convert.ToString(txtComments.Text);
        Item.Remarks = Convert.ToString(txtRemarks.Text);
        Item.CounsellingStatusId = 1;
        Item.IsActive = true;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("CounsellingSearch.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CounsellingSearch.aspx");
    }
}