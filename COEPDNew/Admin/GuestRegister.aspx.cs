using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class GuestRegister : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsRegister Item;
    int ItemId = 0;
    DateTime dt;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsRegister();
        if (!IsPostBack)
        {
            BindEmployee();

            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Visitor Info";
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
                    txtRegister.Text = Item.Register;
                    txtPrimaryMobile.Text = Item.PrimaryMobile;
                    txtPrimaryEmail.Text = Item.PrimaryEmail;
                    txtAddress.Text = Item.Address;
                    txtComments.Text = Item.Comments;
                    txtRemarks.Text = Item.Remarks;
                    ddlEmployee.SelectedValue = Item.EmployeeId.ToString();
                }
            }
            else
            {
                lblTitle.Text = "Add Visitor Info";               
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
        dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        if (ItemId > 0)
        {
            Item.RegisterId = Convert.ToInt16(ItemId);
        }
        Item.ParticipantId = 0;
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
            if (txtEmints.Text.Length == 1)
            {
                etMin = "0" + txtEmints.Text;
            }
            else
            {
                etMin = txtEmints.Text;
            }
            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy") + " " + etHours + ":" + etMin, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            Item.EndTime = dt1;
        }
        Item.Date = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null));
        Item.Register = Convert.ToString(txtRegister.Text);
        Item.PrimaryMobile = Convert.ToString(txtPrimaryMobile.Text);
        Item.PrimaryEmail = Convert.ToString(txtPrimaryEmail.Text);
        Item.Address = Convert.ToString(txtAddress.Text);
        Item.Comments = Convert.ToString(txtComments.Text);
        Item.Remarks = Convert.ToString(txtRemarks.Text);
        Item.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        Item.RegisterTypeId = 1;
        Item.RegisterStatusId = 1;
        Item.IsActive = true;
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("GuestRegisterSearch.aspx");
    }
    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("GuestRegister.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("GuestRegisterSearch.aspx");
    }
}